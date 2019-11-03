using Random = UnityEngine.Random;
public class Student
{
    private static int nextid = 0;
    private int id;
    private string name;
    private string description;
    private int ability;
    private int mood;
    private double growth;


    public State state;

    public Student(string name, string description, int ability, int mood, double growth, State state)
    {
        this.id = nextid;
        nextid++;
        this.name = name;
        this.description = description;
        this.ability = ability;
        this.mood = mood;
        this.growth = growth;
        this.state = state;
    }

    public void update()
    {
        //更新学生的状态
        if (state == State.Idle)
        {
            if (mood > 1)
            {
                //划水时心情下降
                mood--;
            }
            if (ability > 0)
            {
                //划水时能力值下降
                ability--;
            }
        }
        else if (state == State.Work)
        {
            mood++;
            ability = ability + (int)growth;
        }
        else if (state == State.Write)
        {
            ability += 2;
        }
    }

    public int contribution()
    {
        double ef = Random.Range(0.5f, 1.0f) * (double)Random.Range(mood / 2, mood) / (double)mood;//引入随机系数
        return (int)ef * ability;
    }


    public void Changestate(State newstate,Task objtask=null)
    {
 
        if (this.state==State.Work&& newstate!=State.Work)
        {
            this.state = newstate;
            foreach (var item in GameManager.mymanager.tasks)
            {
                foreach (var i in item.Students)
                {
                    if(i.Id==this.Id)
                    {
                        item.Students.Remove(i);
                        return;
                    }
                }
            }
            return;
        }
        switch (newstate) 
        {
            case State.Idle:
                this.state = newstate;
                break;
            case State.learning:
                this.state = newstate;
                break;
            case State.Write:
                this.state = newstate;
                break;
            case State.Work:
                if(this.state== State.Work)
                {
                    this.state = newstate;
                    foreach (var item in GameManager.mymanager.tasks)
                    {
                        foreach (var i in item.Students)
                        {
                            if (i.Id == this.Id)
                            {
                                item.Students.Remove(i);
                                return;
                            }
                        }
                    }
                    objtask.addStudent(this);
                }else
                {
                    this.state = newstate;
                    objtask.addStudent(this);
                }
                break;
        }
        return;
    }


    // get and set attribution
    public int Id { get => id; }
    public string Name { get => name; }
    public string Description { get => description; set => description = value; }
    public int Ability { get => ability; }
    public int Mood { get => mood; }
    public double Growth { get => growth; }
 
}