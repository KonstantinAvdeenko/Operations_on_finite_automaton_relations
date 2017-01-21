This program, in the C# programming language, performs operations on the relations of the sets of finite automata.
State machines are the basis of any closed-loop automated system,
translate programs from high-level language to a language that is understandable to a computer processor.

The program OperaciiNadOtnosheniyamiKonethnyhAvtomatov contains the following interacting modules:
1) Program.cs - containing the main main function, which by default runs the main form Form1;
2) Form1.cs - is the main form of the program, within which all the work of the program takes place;
3) Form1.Designer.cs - contains settings for the above mentioned form.

The main module of the form Form1.cs contains the following main functions corresponding to the main buttons on the form:
1) Synthesis button - synthesizes a random primary state of the input and output data of the state machine,
and also synthesizes the setting of the number of states of the finite state machine that the user enters.
At this stage, the user must also enter input and output data, namely "1" or "0"
corresponding to the presence of a signal at the input and output of the state machine.
The input data on the main form is the primary state of two sets of the finite automaton - n-q0 and n-q1.
The output on the main form is the result of the relationship of two sets of a finite-state machine using
all numbers of the number of states of the finite automaton. The number of finite state machine states on the main form
this is the number of rows of the table for all states of the sets of the finite automaton;
2) Start button - it is pressed strictly after the “Synthesis” button. Calculates and displays new states of sets,
their output data and all their possible states in the finite state machine based on the formula n-q0 and n-q1,
it is possible to press this button again and recalculate as long as it is possible.
3) Stop button - closes Form1 and turns off this program.