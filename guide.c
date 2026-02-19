#include <stdio.h>

void ShowGuide()
{
    printf("    ____  ____  _____    _    __  __            \n");
    printf("    |  _ \\|  _ \\| ____|  / \\  |  \\/  |           \n");
    printf("    | | | | |_) |  _|   / _ \\ | |\\/| |           \n");
    printf("    | |_| |  _ <| |___ / ___ \\| |  | |           \n");
    printf("    |____/|_|_\\_\\_____/_/__ \\_\\_|_ |_|_    _     \n");
    printf("        | |/ _ \\| | | |  _ \\| \\ | |  / \\  | |    \n");
    printf("    _  | | | | | | | | |_) |  \\| | / _ \\ | |    \n");
    printf("    | |_| | |_| | |_| |  _ <| |\\  |/ ___ \\| |___ \n");
    printf("    \\___/ \\___/ \\___/|_| \\_\\_| \\_/_/   \\_\\_____|  \n");

    printf("USAGE:\n");
    printf("  command [options] [arguments]\n\n");

    printf("COMMANDS:\n");

    printf("  add <title> <content> <lucid>\n");
    printf("    Add a new dream entry to the journal.\n");
    printf("    - title   : String (use quotes if it contains spaces)\n");
    printf("    - content : String (use quotes if it contains spaces)\n");
    printf("    - lucid   : Boolean (true or false)\n");
    printf("    Example:\n");
    printf("      add \"Flying Dream\" \"I was flying over a city\" true\n\n");

    printf("  remove <title>\n");
    printf("    Remove a dream entry by its title.\n");
    printf("    Example:\n");
    printf("      remove \"Flying Dream\"\n\n");

    printf("  journal\n");
    printf("    Display all journal entries.\n\n");

    printf("  journal -limit <number>\n");
    printf("    Display the last <number> of entries.\n");
    printf("    Example:\n");
    printf("      journal -limit 5\n\n");

    printf("  change -path <path>\n");
    printf("    Set the folder where the journal is saved.\n");
    printf("    Example:\n");
    printf("      change -path C:\\\\DreamJournal\n\n");

    printf("  change -startup-launch <Y/N>\n");
    printf("    Enable or disable launch on Windows startup.\n");
    printf("    Example:\n");
    printf("      change -startup-launch Y\n\n");

    printf("  donate\n");
    printf("    Open the Ko-fi donation page in your browser.\n");
}