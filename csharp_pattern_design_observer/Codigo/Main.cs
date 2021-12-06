using Codigo.ShowLastNotifications;

Newsletter youtube = new Newsletter();
LectorKindle paperwhite_de_pepe = new LectorKindle(youtube, "PaperWhite de Pepe");
LectorKindle oasis_de_juan = new LectorKindle(youtube, "Oasis de Juan");


youtube.AddObserver(paperwhite_de_pepe);
youtube.AddObserver(oasis_de_juan);

youtube.RemoveObserver(paperwhite_de_pepe);

youtube.LastUrl="https://www.youtube.com/watch?v=rPR0bMoVk9M&ab_channel=PeriLyrics";
youtube.LastImage = "https://i.ytimg.com/an_webp/rPR0bMoVk9M/mqdefault_6s.webp?du=3000&sqp=CImkto0G&rs=AOn4CLBtAum7RsjqdN7Ro8aIvjaNxChuAA";
youtube.LastTitle = "LA SANTA GRIFA (YUSAK) // AMNESIA // LETRA";
youtube.LastDescription = "Video oficial: https://youtu.be/yMETEHL2iTM";



youtube.NotifyObservers();

