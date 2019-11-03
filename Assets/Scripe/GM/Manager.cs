//Manager的使用者仅知道学生id和任务id

using System.Collections.Generic;

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
    public long money;
    public int day;
    public int frameday;//一天的帧数
    public int framenow;//现在过去的帧数0-frameday
    public Manager()
    {
        tasks = new List<Task>();
        students = new List<Student>();
        money = 999;
        frameday = 360;
        framenow = 0;
    }


    public void assignWork(int taskid, int studentid, State state)
    {
        Student student = findStudent(studentid);
        Task task = findTask(taskid);
        task.addStudent(student);
        student.state=state;
    }

    public Student findStudent(int studentid)
    {
        return students.Find(
            stu =>
            {
                if (stu.Id == studentid)
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

    public void update()
    {
        foreach (Student student in students)
        {
            student.update();
        }
        foreach (Task task in tasks)
        {
            task.update();
        }
    }
    public Task findTask(int taskid)
    {
        return tasks.Find(
            task =>
            {
                if (task.Id == taskid) return true;
                else return false;
            }
            );
    }
}