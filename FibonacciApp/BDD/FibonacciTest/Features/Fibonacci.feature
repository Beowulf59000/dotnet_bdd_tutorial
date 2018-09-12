﻿Feature: Fibonacci
	En tant qu'étudiant
	Je veux interroger la suite de Fibonacci
	Pour connaitre une occurrence spécifique

@Occurences
Scenario Outline: Occurences
	Given Je cherche l'occurence <index>
	When J'interroge la suite de Fibonacci
	Then Le résultat est <valeur>
	Examples:
	| index | valeur |
	| 0     | 0      |
	| 1     | 1      |
	| 2     | 1      |
	| 3     | 2      |
	| 4     | 3      |
	| 5     | 5      |
	| 6     | 8      |
	| 7     | 13     |
	| 8     | 21     |
	| 9     | 34     |
	| 10    | 55     |
