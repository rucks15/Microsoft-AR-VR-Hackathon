private void OpenPicture(string name)
        {
            Process Photoviewer = new Process();
            switch (name)
            {
                case "Heart":
                    Process.Start(@"C:\Users\manju\Pictures\Images\Brain.jpg");
                    break;
                case "Ear":
                    Process.Start(@"C: \Users\manju\Pictures\Images\Ear.jpg");
                    break;
                case "Brain":
                    Process.Start(@"C: \Users\manju\Pictures\Images");
                    break;

                default:
                    return;
            }
        }