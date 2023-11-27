// Clase base para actividades
public abstract class MindfulnessActivity
{
    protected int duration; // Duración de la actividad en segundos

    public MindfulnessActivity(int duration)
    {
        this.duration = duration;
    }

    public abstract void StartActivity(); // Método abstracto para iniciar la actividad
    public abstract void DisplayStartingMessage(string activityName, string description); // Mostrar mensaje de inicio común
    public abstract void DisplayEndingMessage(string activityName, int elapsedTime); // Mostrar mensaje de finalización común

    // Método para mostrar el contador/pausa
    protected void ShowPause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000); // Espera de un segundo
        }
        Console.WriteLine();
    }
}