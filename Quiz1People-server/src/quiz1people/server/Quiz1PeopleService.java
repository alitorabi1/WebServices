package quiz1people.server;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.Scanner;

public class Quiz1PeopleService implements PeopleInt{

    private static final String FILE_NAME = "data.txt";
    
    @Override
    public int addPerson(String name, int age, int height) throws IOException {
        System.out.println("called addPerson()");
        try(PrintWriter pw = new PrintWriter(new BufferedWriter(new FileWriter(FILE_NAME, true)))) {
            String person = String.format("%s;%s;%s", name, age , height);
            pw.println(person);
        } catch (IOException e) {
            e.printStackTrace();
            throw e;
        }
        return 0; 
    }

    @Override
    public ArrayList<String> getFilteredPersonList(String nameContains, int minAge, int maxAge, int minHeight, int maxHeight) throws IOException {
        System.out.println("called getFilteredPersonList()");
        try(Scanner scanner = new Scanner(new File(FILE_NAME))) {
            ArrayList<String> personList = new ArrayList<>();
            while (scanner.hasNextLine()) {
                String line = scanner.nextLine();
                String[] splittedLine = line.split(";");
                //Get the name , age and height from each person
                String name = splittedLine[0];
                int age = Integer.parseInt(splittedLine[1]);
                int height = Integer.parseInt(splittedLine[2]);
                if(name.toLowerCase().contains(nameContains.toLowerCase())
                        && age >= minAge && age <= maxAge 
                        && height >= minHeight && height <= maxHeight ){
                    personList.add(line);
                }
            }
           // scanner.close();
            return personList;
        } catch (IOException e) {
            e.printStackTrace();
            throw e;
            //return "";
        }
    }
    
}
