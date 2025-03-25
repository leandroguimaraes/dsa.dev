namespace DSA.Algorithms.Stacks
{
  public class CarFleet
  {
    // https://leetcode.com/problems/car-fleet/description/
    // https://www.youtube.com/watch?v=Pr6T-3yB9RM
    public static int Run(int target, int[] position, int[] speed)
    {
      var length = position.Length;
      var cars = new List<(int position, int speed)>();
      for (int i = 0; i < length; i++)
      {
        cars.Add((position[i], speed[i]));
      }
      cars.Sort((a, b) => b.position - a.position);

      var stackArrivalTime = new Stack<int>();
      foreach (var car in cars)
      {
        var arrivalTime = (target - car.position) / car.speed;
        if (stackArrivalTime.Count == 0 || stackArrivalTime.Peek() < arrivalTime)
        {
          stackArrivalTime.Push(arrivalTime);
        }
      }

      return stackArrivalTime.Count;
    }
  }
}