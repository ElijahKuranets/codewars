public class God
{
  public static Human[] Create()
{
     Human[] humans = new Human[2];
     humans[0] = new Man();
     humans[1] = new Woman();
   return humans;
  }
}

public class Human
{}
class Man : Human
{}
class Woman : Human
{}
