#include <stdio.h>

#include "./headers/command.h"
#include "./headers/guide.h"

int main(int argc, char *argv[])
{
    if (argc == 1)
    {
        ShowGuide();
        return 0;
    }
    
    char *command = argv[1];

    CommandInit(command, argv);
}