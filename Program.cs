string message = "The quick brown fox jumps over the lazy dog.";

// Reverse the message
char[] newMessage = message.ToCharArray();
Array.Reverse(newMessage);

// Count the o's
int numberOfOs = 0;
foreach (char i in message)
{
    if (i == 'o')
    {
        numberOfOs++;
    }
}

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {numberOfOs} times.");