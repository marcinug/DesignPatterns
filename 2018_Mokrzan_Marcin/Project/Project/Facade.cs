using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Facade
    {
        private RoomInstance chosenRoomInstance; 
        private GameInstance chosenRoot;
        private Room chosenRoom;

        public void createGame(char key, Account user) 
        {
            RoomCreation roomCreation = new RoomCreation();

            if (key == 'c')
            {
                Room roomChess = roomCreation.Create(new ChessBuilder());
                roomChess.Show();

                GameInstance root1 = new GameInstance();
                RoomInstance room1 = roomChess;
                room1.Name = roomChess.GameName;

                chosenRoomInstance = room1;
                chosenRoot = root1;
                chosenRoom = roomChess;
            }
            else if( key == 'g') 
            {
                Room roomGo = roomCreation.Create(new GoBuilder());
                roomGo.Show();

                GameInstance root = new GameInstance();
                RoomInstance room = roomGo;
                room.Name = roomGo.GameName;

                chosenRoomInstance = room;
                chosenRoot = root;
                chosenRoom = roomGo;
            }
            else if ( key == 'd')
            {
                Room roomDraughts = roomCreation.Create(new DraughtsBuilder());
                roomDraughts.Show();

                GameInstance root2 = new GameInstance();
                RoomInstance room2 = roomDraughts;
                room2.Name = roomDraughts.GameName;

                chosenRoomInstance = room2;
                chosenRoot = root2;
                chosenRoom = roomDraughts;
            }
            if( key == 'c' | key == 'd' | key == 'g' )
            {
                Player p1 = user;
                p1.Name = user.name;

                chosenRoot.AddChild(chosenRoomInstance);
                chosenRoomInstance.AddChild(user);

                chosenRoot.Show();
                chosenRoomInstance.Show();
            }
            Console.Write("Current player: " + chosenRoomInstance.ComponentList1.Count + " max players: " + chosenRoom.Stats["num"]);

            if (chosenRoomInstance.ComponentList1.Count == Int32.Parse(chosenRoom.Stats["num"]))
            {
                chosenRoomInstance.Request();
                Console.Write("Current player: " + chosenRoomInstance.ComponentList1.Count + " max players: " + chosenRoom.Stats["num"]);
                Console.Write("Room is full");
            }
        }

    }
}
