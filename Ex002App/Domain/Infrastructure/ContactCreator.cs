using Model;

namespace Infrastructure;

// public abstract class ContactCreator
// {
//   public abstract Contact GetContact();
// } 

public interface IContactCreator
{
  Contact GetContact();
}