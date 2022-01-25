using System;

namespace lab6
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
			//Set
			Account User = new Account();
			Figure View = new Figure();
			Friends[] Human = new Friends[2];
			Music[] LikeMAS = new Music[2];
			Messages Letter = new Messages();

			//Init
			User.InitAccount("Anton", "Petrov", "Petrov22@gmail.com", "111222333");

			View.InitFigure(2, 1);
			User.FigureFigure = View.Getfigure();
			User.FigureColor = View.Getcolor();

			for (int j = 0; j < 2; j++)
			{
				Human[j] = new Friends();
			}
			Human[0].InitFriends("Ivan", "Ivanov");
			Human[1].InitFriends("Sergey", "Sergeev");

			User.FriendsName[0] = Human[0].Getname();
			User.FriendsSurname[0] = Human[0].Getsurname();
			User.FriendsName[1] = Human[1].Getname();
			User.FriendsSurname[1] = Human[1].Getsurname();

			for (int j = 0; j < 2; j++)
			{
				LikeMAS[j] = new Music();
			}
			LikeMAS[0].MUSICinit("Choi", "Kukushka");
			LikeMAS[1].MUSICinit("Grigoriy Leps", "London");
			User.MusicExecutor[0] = LikeMAS[0].Getexecutor();
			User.MusicTitle[0] = LikeMAS[0].Gettitle();
			User.MusicExecutor[1] = LikeMAS[1].Getexecutor();
			User.MusicTitle[1] = LikeMAS[1].Gettitle();

			Letter.InitMessages("Ivan Ivanov", "Anton Petrov", "Hello!");
			User.MessagestoWhom = Letter.GettoWhom();
			User.MessagesfromWhom = Letter.GetfromWhom();
			User.Messagesmessage = Letter.Getmessage();
			//Output
			Console.WriteLine("Output: ");
			User.OutputAccount();
			//Delete
			Console.WriteLine("\nDelete: ");
			User.DeleteAccount();
			View.DeleteFigure();
			Human[0].DeleteFriends();
			Human[1].DeleteFriends();
			LikeMAS[0].DeleteMusic();
			LikeMAS[1].DeleteMusic();
			Letter.DeleteMessages();
			User.OutputAccount();

			//Input
			Console.WriteLine("Input: ");
			User.InputAccount();

			Console.WriteLine("Output NEW: ");
			User.OutputAccount();
		}
	}
}
