# Solution

## Convert a file to a List<string>
```
if (file exists and can be opened)
    create an object of type List<string>
    example:
    List<string> log = new List<string>()
else 
    exit
```

## Convert a text line to a string

```
read a line of text and assign it to a string object.  
Example:
string line = log.ReadLine();
```

## Add a string to the List of strings

```
log.add(line);
```

## Reverse the list of strings

```
assign a reverse copy of the list to a new list.
Example:
List<string> rLog = log.Reverse();
```

## Save the reversed list of strings on a file

```
if (output file can be opened and is writable)
    read each element of the reversed list and
    write it to the output file, output.
    Example:
    for each line in rLog
        write line to output file
```

## Display first 5 lines from list

```
for each line from 1 to 5
    print line to standard output
    
```
### The solution must meet the following requirements:
1. Create a method to read each line of the web log file.  This method must use exception handling to ensure that the file is opened successfully (4 points).
2. Each line of the file should then be stored in a collection class object such that the first element of the collection is the first line of the web log file. You can choose any of the collection classes covered in this module unit.  Because each element will hold an entire line from the file, the collection should be declared as a collection of strings (4 points).
3. Create another method to write the contents of the collection to another file in reverse order. Each element should be on its own line in the new file. The contents of the new file should look like the original input file once your program completes, but in reverse order, so that the last line of the original file will be the first line of the new file and so on (4 points).
4. Create another method that will display the first five lines only from the collection (not from the file) (2 points).
5. Create a main function (2 points). Test your code by verifying the contents of the newly created file. The file is somewhat large, so not display the entire contents of the file!