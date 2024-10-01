Feature: ProfileFeature

A short summary of the feature


Background: 
	Given I logged into profile page successfully
	
@regression
Scenario Outline: User add languages
	And I add new '<Language>' and '<LanguageLevel>'
	Then I should be able to view the added '<Language>' and '<LanguageLevel>'

	Examples: 
	| Language | LanguageLevel    |
	| English  | Fluent           |
	| German   | Conversational   |
	| Chinese  | Basic            |
	| Arabic   | Native/Bilingual |

Scenario Outline: User update languages
	And I update existing '<Language>' and '<LanguageLevel>'
	Then I should be able to view the updated '<Language>' and '<LanguageLevel>'

	Examples: 
	| Language | LanguageLevel    |
	| Spanish  | Fluent           |
	| French   | Conversational   |
	| Russian  | Basic            |
	| Mandarin | Native/Bilingual |


Scenario: User Delete languages 
	When I delete an existing language
	Then the deleted language should not be similar to existing language

Scenario: User add skills

Scenario: User create profile

Scenario: User view added languages

Scenario: User view added skills
