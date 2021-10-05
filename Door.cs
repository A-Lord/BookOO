using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOO
{
    public class Door
    {
        private DoorLock _DoorState;
        private int _passcode;

        public Door(int passcode)
        {
            _passcode = passcode;
            _DoorState = DoorLock.Lock;
        }
        private bool UnlockChek(int passTry)
        {
            if (passTry == _passcode)
                return true;
            else
                return false;
        }
        public void DoorStatusText()
        {
            Console.WriteLine($"Dörren är {_DoorState}"); 
        }
        public DoorLock UseDoor(DoorLock userChoice)
        {
            switch (userChoice)
            {
                case DoorLock.Close:
                    if (_DoorState == DoorLock.Open )
                    {
                        _DoorState = DoorLock.Close;
                        return _DoorState;
                    }
                    else
                    {
                        return _DoorState;
                    }
                case DoorLock.Open:
                    if (_DoorState == DoorLock.Close || _DoorState == DoorLock.Unlock)
                    {
                        _DoorState = DoorLock.Open;
                        return _DoorState;
                    }
                    else
                    {
                        return _DoorState;
                    }
               
                case DoorLock.Lock:
                    if (_DoorState == DoorLock.Close)
                    {
                        _DoorState = DoorLock.Lock;
                    }
                        return _DoorState;

                case DoorLock.Unlock:
                    if(_DoorState == DoorLock.Lock)
                    {
                        Console.WriteLine("Skriv lösenordet för att låsa upp");
                        var coden = int.Parse(Console.ReadLine());
                        if (UnlockChek(coden))
                        {
                            _DoorState = DoorLock.Unlock;
                        }
                        else
                        {
                            Console.WriteLine("fel lösenord");
                         return _DoorState;
                        }
                    }
                    return _DoorState;
                default:
                    return _DoorState;
            }
        }



        public void ChangeCode()
        {
            int OldPasscode;
            while (true)
            {
                Console.WriteLine("För att byta lösenord, Skriv in nuvarande lösenord.");
                bool success = int.TryParse(Console.ReadLine(), out OldPasscode);
                if (success)
                {
                    if (OldPasscode == _passcode)
                    {
                        Console.WriteLine("Rätt Lösenord, Skriv in nya lösenordet:");
                        int NewPass = int.Parse(Console.ReadLine());
                        _passcode = NewPass;
                        Console.WriteLine("Lösenordete är bytt!");
                        break;
                    }
                    else if (OldPasscode != _passcode)
                    {
                        Console.WriteLine("Fel lösen ord, vill du försöka igen ja/nej?");
                        string choiceses = Console.ReadLine();
                        if (choiceses == "nej")
                        {
                            break;
                        }
                    }

                }
            }

        }


    }


    public enum DoorLock { Open,Close,Lock,Unlock}
}
