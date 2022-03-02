//part of the main namespace for the project
namespace Quest
{
  //this is the hat class where our hat get its properties
  public class Hat
  {
    public int ShininessLevel { get; set; }

    public string ShininessDescription
    {
      get
      {
        if (ShininessLevel < 2)
        {
          return "dull";
        }
        else if (ShininessLevel > 2 && ShininessLevel <= 5)
        {
          return "noticeable";
        }
        else if (ShininessLevel >= 6 && ShininessLevel <= 9)
        {
          return "bright";
        }
        else
        {
          return "blinding";
        }
      }
    }
  }
}