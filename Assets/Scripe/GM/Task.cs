
using System.Collections.Generic;
using Random = UnityEngine.Random;
public class Task
{
    private static int nextid = 0;
    private int id;
    private string name;
    private double acceptedProbability;
    private int needCompleteness;
    private List<Student> students;//记录当前任务有多少学生在进行

    private int completeness;

    public Task(string name, double acceptedProbability, int needCompleteness)
    {
        this.id = nextid;
        nextid++;
        this.name = name;
        this.needCompleteness = needCompleteness;
        this.acceptedProbability = acceptedProbability;
        this.students = new List<Student>();//初始时，项目没有任何学生在进行
        this.completeness = 0;//初始时，项目进度为 0
    }

    public void addStudent(Student student)
    {
        students.Add(student);
    }

    public void removeStudent(Student student)
    {
        students.Remove(student);
    }

    public void update()
    {
        //先更新学生状态，再根据学生状态更新任务状态
        foreach (Student student in students)
        {
            int contribution = student.contribution();//获取该学生对项目的贡献
            completeness += contribution;//更新项目进度
            if (completeness >= NeedCompleteness)
            {
                //控制项目进度上限
                completeness = NeedCompleteness;
            }
        }

    }

    public bool finish()
    {
        //结束工作，返回工作结果
        double finalAcceptedProbability = (System.Math.Pow(2, (double)completeness / (double)NeedCompleteness) - 1) * acceptedProbability;
        double test_probability = Random.Range(0.0f, 1.0f);
        if (test_probability <= finalAcceptedProbability) return true;
        else return false;
    }


    // get and set attribution
    public int Id { get => id; }
    public string Name { get => name; }
    public double AcceptedProbability { get => acceptedProbability; }
    public int NeedCompleteness { get => needCompleteness; }
    public List<Student> Students { get => students; }
}