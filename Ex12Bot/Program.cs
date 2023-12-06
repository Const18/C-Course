string token = File.ReadAllText("app.config");
TelegramBotClient botClient = new(token);

// botClient.StartReceiving(m => Console.WriteLine(m));
botClient.StartReceiving(m => File.AppendAllText("Bot.log", m));

Console.WriteLine("stop");