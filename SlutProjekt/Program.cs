using Raylib_cs;

Raylib.InitWindow(800,900,"Pizza simulator");
Raylib.SetTargetFPS(61);

string scene = "start";

while(!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();

    if (scene == "start")
    {
        Raylib.ClearBackground(Color.Gray);

        Raylib.DrawText("*OBJECTIVE",60,210,35,Color.Black);
        Raylib.DrawText("Shoot the dubious pizzas",60,260,35,Color.Black);
        Raylib.DrawText("Be careful to not shoot the tasty ones*",60,310,35,Color.Black);
        Raylib.DrawText("PRESS ENTER TO START",60,500,50,Color.Black);

    }


    Raylib.EndDrawing();
}