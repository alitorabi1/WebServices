package quiz1people.server;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.Scanner;

public class PeopleService implements PeopleInt {

    private static final String FILE_NAME = "data.txt";

    @Override
    public int addPerson(String name, int age, int height) throws IOException {
        System.out.println("call addPerson()");
        try (PrintWriter pw = new PrintWriter(new BufferedWriter(new FileWriter(FILE_NAME, true)))) {
            String person = String.format("%s;%s;%s", name, age, height);
            pw.println(person);
            pw.close();
        } catch (IOException e) {
            e.printStackTrace();
            throw e;
        }
        return 0;
    }

    @Override
    public ArrayList<String> getFilteredPersonList(String nameContains, int minAge, int maxAge, int minHeight, int maxHeight) throws IOException {
        System.out.println("call getFilteredPersonList");
        try (Scanner scanner = new Scanner(new File(FILE_NAME))) {
            ArrayList<String> personList = new ArrayList<>();
            while (scanner.hasNextLine()) {
                String line = scanner.nextLine();
                if (line.toLowerCase().contains(nameContains.toLowerCase())) {
                    personList.add(line);
                }
            }
            return personList;
        } catch (IOException e) {
            e.printStackTrace();
            throw e;
        }
    }

}
