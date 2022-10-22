//фрактал. треугольник серпинского
        Console.Clear();
        // как нарисовать
        //Console.SetCursorPosition(10,4);
        //Console.WriteLie("*");
       /* длинная запись
        //положение первой точки а
        int xa=40;
        int ya=1;
        // положение второй точки b
        int xb=1;
        int yb=20;
        // положение третей точки с
        int xc=80;
        int yc=20;
        */
        // то же самое, но более экономно
        int xa=40, ya=1,
            xb=1, yb=20,
            xc=80, yc=20;
        Console.SetCursorPosition(xa,ya);
        Console.WriteLine("*");
        
        Console.SetCursorPosition(xb,yb);
        Console.WriteLine("*");
        
        Console.SetCursorPosition(xc,yc);
        Console.WriteLine("*");
        
        int x=xa, y=xb;
        int count=0;
        while (count<10000)
        {
        	int what = new Random().Next(0,3);
        	if (what==0)
        	{
        		x=(x+xa)/2;
        		y=(y+ya)/2;
        	}
        	if (what==1)
        	{
        		x=(x+xb)/2;
        		y=(y+yb)/2;
        	}
        	if (what==2)
        	{
        		x=(x+xc)/2;
        		y=(y+yc)/2;
        	}
        	Console.SetCursorPosition(x,y);
        	Console.WriteLine("*");
        	count++;
        }
        