namespace basics.Models;

public class Repository
{
    private static readonly List<Course> _courses = [];

    static Repository()
    {
        _courses = [
            new(){
                Id =1, Title="aspnet kursu",
                Description ="güzel bir kurs",Image="WebGelistirme.jpg",
                Tags =["aspnet","web geliştirme"],
                isActive =true,
                isHome =true
            },
            new(){
                Id =2, Title="php kursu",
                Description ="güzel bir kurs",
                Image ="php.jpg",
                Tags =["php","web geliştirme"],
                isActive =true,
                isHome =true
            },
            new(){
                Id =3, Title="django kursu",
                Description ="güzel bir kurs",
                Image ="Python.jpg",
                isActive=true,
                isHome =false
            },
            new(){
                Id =4, Title="javascript kursu",
                Description ="güzel bir kurs",
                Image ="WebGelistirme.jpg",
                isActive=true,
                isHome =true
            }
        ];
    }
    public static List<Course> Courses
    {
        get { return _courses; }
    }

    public static Course? GetById(int? id)
    {
        return _courses.FirstOrDefault(c => c.Id == id);
    }


}
