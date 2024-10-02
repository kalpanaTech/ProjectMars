Feature: ProfileFeature

A short summary of the feature


Background: 
	Given I logged into profile page successfully
	
@regression
Scenario Outline: User add languages
	And I add new '<Language>' and '<LanguageLevel>' to Languages section
	Then I should be able to view the added '<Language>' and '<LanguageLevel>' on Languages section

	Examples: 
	| Language | LanguageLevel    |
	| English  | Fluent           |
	| German   | Conversational   |
	| Chinese  | Basic            |
	| Arabic   | Native/Bilingual |

Scenario Outline: User update languages
	And I update existing '<Language>' and '<LanguageLevel>' on Languages section
	Then I should be able to view the updated '<Language>' and '<LanguageLevel>' on Languages section

	Examples: 
	| Language | LanguageLevel    |
	| Spanish  | Fluent           |
	| French   | Conversational   |
	| Russian  | Basic            |
	| Mandarin | Native/Bilingual |


Scenario: User Delete languages 
	When I delete an existing language
	Then the deleted language should not be similar to existing language

Scenario Outline: User add skills
	And I add new '<Skill>' and '<SkillLevel>' to Skills section
	Then I should be able to view the added '<Skill>' and '<SkillLevel>' on Skills section

	Examples: 
	| Skill              | SkillLevel   |
	| Manual Testing     | Beginner     |
	| Automation Testing | Intermediate |
	| API Testing        | Expert       |

Scenario Outline: User update skills
	And I update existing '<Skill>' and '<SkillLevel>' on Skills section
	Then I should be able to view the updated '<Skill>' and '<SkillLevel>' on Skills section

	Examples: 
	| Skill              | SkillLevel   |
	| C#                 | Beginner     |
	| C++                | Intermediate |
	| Java               | Expert       |

Scenario Outline: User Delete skills
	When I delete an existing skill
	Then the deleted skill should not be similar to existing skill

Scenario: User create profile

Scenario: User view added languages

Scenario: User view added skills
