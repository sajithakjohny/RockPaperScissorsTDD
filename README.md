# RockPaperScissorsTDD
RockPaperScissorsTDD with Dotnet Core framework 5.0

 Rock beats Scissors, Scissors beats Paper, Paper beats Rock.
        Your task is to create the core logic that checks which gesture wins in a matchup. For example:
        Gesture 1	Gesture 2	Result
        rock	scissors	rock beats scissors
        paper	rock	paper beats rock
        Paper  Scissors = Scissors wins
        If both people choose the same thing, then it is a draw and nobody wins.
        
        
Rock Paper Sizer Game TDD Example Map					
					
Feature/Function	Gesture 1	Gesture 2	Logic/Condition      	TestName	Expected Output
Game Play with Rock and Scissor	rock	scissor	rock beats scissor          	ChooseRockandScissorWinByRock	Rock
Game Play with paper and rock	paper	rock	paper beats rock            	ChoosePaperRockWinByPaper	Paper
Game Play with paper and Scissor	Paper	Scissor 	 Scissor Cut Paper  	ChooseScissorsandPaperWinbyScissor	Scissor
Game Play with same Gesture	rock	rock    	rock beats rock            	ChooseRockandRockWinByNoOne	NoOne
Game Play with same Gesture	paper	paper          	paper beats paper    	ChoosePaperandPaperWinByNoOne	NoOne
Game Play with same Gesture	Scissor     	Scissor   	Scissor beats Scissor 	ChooseScissorandScissorWinByNoOne	NoOne

