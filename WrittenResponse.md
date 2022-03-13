# Cipher Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

A person would run my program to translate between computer science language and English for entertainment.

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

This video demonstrates that my program can test help the user picking the language they want to translate and generate it according to the user selections. 

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program accepts user input from the keyboard, which they enter their choice as a number.  
Then it generates their translated code and display the result (output).

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp

List<string> choices = new List<string>();

choices.Add("Translate ENG to CS.");
choices.Add("Translate CS to ENG");

```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp

if (options == 1)
{
    Console.WriteLine("What do you want to generate?");
    string Text = Console.ReadLine();
    string E_C = ENG_CS(Text);
    Console.WriteLine(E_C);
}
else
{
    Console.WriteLine("What do you want to generate?");
    string Words = Console.ReadLine();
    string C_E = CS_ENG(Words);
    Console.WriteLine(C_E);
}

```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in "choices".

### 3b iv.

Describes what the data contained in the list represents in your program

This list contains the choices that my program is about to ask the user to select.

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

My list manages complexity by allowing me to easily add choices without make a bunch of changes to my code.  
Without a list, I would have to create several new choice variables each time I want to add a code. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp

public static int Choice(List<string> choices)
{
    if (choices == null) throw new ArgumentNullException("List of options may not be null.");
    if (choices.Count == 0) throw new ArgumentException("The List of options must contain at least 1 option.");

    int ix = 1;
    foreach (string option in choices)
    {
        Console.WriteLine($"{ix}.{option}");
        ix = ix + 1;
    }

int choice;
do
{
    string userInput;
    userInput = Console.ReadLine();
    // Parse translates the user input into an int value
    choice = int.Parse(userInput);


    // List<string> options = new List<string>();
    // options.Add("Yes!");
    // options.Add("No.");
    // Choice(options);
    if (choice > 2)
    {
        Console.Error.WriteLine("Number must be less than 2.");
    }
    if (choice < 1)
    {
        Console.Error.WriteLine("Number has to be 0 or 1");
    }
            }
while (choice > 2 || choice < 1);

return choice;

```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp

int options = Choice(choices);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

Given a series of questions to the user, score the points when the player enters an answer.  This is the main functionality of my program.

“The Choice method accepts a "choices" as a parameter, displays the question, displays a list of choices, then waits for the user to select one. Finally, it returns the result that the player selected.”



### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. Display the text.
2. Loop through for each choice option in the question
3. Display the answer
4. Get user input
5. return the result

// 1. Display text with user input.
// 2. Shows a for each loop allowing the user to select between loop 2 and loop 3.
// 3. If the user didn't pick a choice, return invalided input.
// 4. Bring the user into the room they just selected.
   
## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

Choice(null);

Second call:

Choice(choices);

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
This tests that the method fails when the input is null by throwing an exception.
This will test if the input is mull thus executing the body of the if statement.

Condition(s) tested by the second call:

This tests that the method runs when then input is not null.

### 3d iii.

Result of the first call:

This result is an exception is thrown.

Result of the second call:

The result is a generated code or text being displayed. 