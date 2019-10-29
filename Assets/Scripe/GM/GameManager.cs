using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Manager mymanager;
     void Awake()
    {

        Application.targetFrameRate = 30 ;
        if (mymanager == null)
        {
            mymanager = new Manager();                  
            mymanager.students.Add(new Student("qingzheng", "长得很胖\n爱吃饭", 34, 100, 0.2, new Idle()));
            mymanager.students.Add(new Student("sb", "长得很瘦\n不爱吃饭", 34, 100, 0.2, new Idle()));

            mymanager.tasks.Add(new Task("超级水刊", 0.1, 100));
        }
    }
    private void Update()
    {
        mymanager.framenow = (mymanager.framenow + 1);
        if (mymanager.framenow%mymanager.frameday==0)
        {
            mymanager.day = mymanager.day + 1;
            mymanager.money = mymanager.money + 1;
            mymanager.framenow = 0;
        }
        
    }

}

 interface ManagerInterface
{
     void assignWork(int taskid, int studentid, State state);
     Student findStudent(int studentid);
     Task findTask(int taskid);
}
public class Manager : ManagerInterface
{
    public List<Task> tasks;
    public List<Student> students;
    public long  money;
    public int day;
    public int frameday ;//一天的帧数
    public int framenow;//现在过去的帧数0-frameday
    public Manager()
    {
        tasks = new List<Task>();
        students = new List<Student>();
        money = 999;
        frameday = 30;
        framenow = 0;
    }

    public void assignWork(int taskid, int studentid, State state)
    {
        Student student = findStudent(studentid);
        Task task = findTask(taskid);
        task.addStudent(student);
        student.SetState(state);
    }

    public Student findStudent(int studentid)
    {
        return students.Find(
            stu =>
            {
                if (stu.getid() == studentid)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            );
    }

    public Task findTask(int taskid)
    {
        return tasks.Find(
            task =>
            {
                if (task.getid() == taskid) return true;
                else return false;
            }
            );
    }
}
public class Task
{
    private static int nextid = 0;
    private int id;
    private string name;
    private double acceptedProbability;
    private int needCompleteness;
    private List<Student> students;

    public Task(string name, double acceptedProbability, int needCompleteness)
    {
        this.name = name;
        this.acceptedProbability = acceptedProbability;
        this.needCompleteness = needCompleteness;
        this.students = new List<Student>();
        this.id = nextid;
        nextid++;
    }
    public int getid()
    {
        return id;
    }
    public void addStudent(Student student)
    {
        students.Add(student);
    }
}
public class Student
{
    private static int nextid = 0;
    private int id;
    private string name;
    private string description;
    private int ability;
    private int mood;
    private double growth;
    private State state;

    public Student(string name, string description, int ability, int mood, double growth, State state)
    {
        id = nextid;
        nextid++;
        this.name = name;
        this.description = description;
        this.ability = ability;
        this.mood = mood;
        this.growth = growth;
        this.state = state;
    }

    public string Name { get => name; set => name = value; }
    public string Description { get => description; set => description = value; }
    public int Ability { get => ability; set => ability = value; }
    public int Mood { get => mood; set => mood = value; }
    public double Growth { get => growth; set => growth = value; }
    public State State { get => state; set => state = value; }

    public int getid()
    {
        return id;
    }
    public void SetState(State state)
    {
        this.state = state;
    }

}


public interface State
{
    void doAction();
}

public class Idle : State
{
    public void doAction()
    {
        throw new System.NotImplementedException();
    }
}
public class Work : State
{
    public void doAction()
    {
        throw new System.NotImplementedException();
    }
}
public class Write : State
{
    public void doAction()
    {
        throw new System.NotImplementedException();
    }
}