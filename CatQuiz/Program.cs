// See https://aka.ms/new-console-template for more information
{
    WhatCatAreYou();
}

static void WhatCatAreYou()
{
    int userScore = 0;

    Console.WriteLine("Welcome to Cat Quiz!\nINSTRUCTIONS: For each question, type the number that corresponds with your choice and press enter!\n" +
        "Press enter to start the quiz and see what cat you are!");
    Console.ReadLine();

    Console.WriteLine("Question 1: What is your go to item to order from Taco Bell?\n" +
        "1: Chicken Quesadilla\n2: 7 Layer Burrito\n3: Veggie Bean Burrito\n4: Doritos Nacho Taco");
    var userAnswer1 = Console.ReadLine();

    if (userAnswer1 == "1")
    {
        userScore += 1;
    }
    else if (userAnswer1 == "2")
    {
        userScore += 2;
    }
    else if (userAnswer1 == "3")
    {
        userScore += 3;
    }
    else if (userAnswer1 == "4")
    {
        userScore += 4;
    }

    Console.WriteLine("Question 2: What is your go to item to order from McDonalds?\n" +
        "1: Bic Mac\n2: Crispy Chicken Sandwich\n3: 10 McNuggets\n4: Any Happy Meal");
    var userAnswer2 = Console.ReadLine();

    if (userAnswer2 == "1")
    {
        userScore += 1;
    }
    else if (userAnswer2 == "2")
    {
        userScore += 2;
    }
    else if (userAnswer2 == "3")
    {
        userScore += 3;
    }
    else if (userAnswer2 == "4")
    {
        userScore += 4;
    }

    Console.WriteLine("Question 3: What is your go to item to order from Culvers?\n" +
        "1: Butter Bun Burger\n2: Chicken Tender Meal\n3: Atlantic Cod Sandwich\n4: Flavor of the Day Custard");
    var userAnswer3 = Console.ReadLine();

    if (userAnswer3 == "1")
    {
        userScore += 1;
    }
    else if (userAnswer3 == "2")
    {
        userScore += 2;
    }
    else if (userAnswer3 == "3")
    {
        userScore += 3;
    }
    else if (userAnswer3 == "4")
    {
        userScore += 4;
    }

    Console.WriteLine("Press enter to see which cat you are!\n(Copy the link to see a picture of your kitty conterpart!)");
    Console.ReadLine();

    switch (userScore)
    {
        case 1: case 2: case 3: case 4:
            Console.WriteLine("You are the hangry cat! Go eat some food! https://imgur.com/gallery/wYTCtRu");
            break;
        case 5: case 6: case 7: case 8:
            Console.WriteLine("You are the money cat! You will spend $50 at Taco Bell! https://imgur.com/gallery/MWaFg");
            break;
        case 9: case 10: case 11: case 12:
            Console.WriteLine("You are the \'I ate too much cat!' You just wanna sit and let it all digest! https://imgur.com/gallery/aifOQYw");
            break;
    }

    




}


