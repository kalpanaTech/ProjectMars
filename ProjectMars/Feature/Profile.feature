Feature: ProfileFeature

A short summary of the feature


Background:
	Given I logged into profile page successfully
	
@regression
Scenario Outline: User add languages
	And I add new '<Language>' and '<LanguageLevel>' to Languages section
	Then I should be able to view the added '<Language>' and '<LanguageLevel>' on Languages section
	When I open the '<User>' profile to view added languages
	Then the people seeking for languages can see what '<Language>' and '<LanguageLevel>' I hold

Examples:
	| Language | LanguageLevel    | User                |
	| English  | Fluent           | Kalpana Dissanayake |
	| German   | Conversational   | Kalpana Dissanayake |
	| Chinese  | Basic            | Kalpana Dissanayake |
	| Arabic   | Native/Bilingual | Kalpana Dissanayake |

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
	When I open the '<User>' profile to view added skills
	Then the people seeking for skills can see what '<Skill>' and '<SkillLevel>' I hold

Examples:
	| Skill              | SkillLevel   |User                |
	| Manual Testing     | Beginner     |Kalpana Dissanayake |
	| Automation Testing | Intermediate |Kalpana Dissanayake |
	| API Testing        | Expert       |Kalpana Dissanayake |

Scenario Outline: User update skills
	And I update existing '<Skill>' and '<SkillLevel>' on Skills section
	Then I should be able to view the updated '<Skill>' and '<SkillLevel>' on Skills section

Examples:
	| Skill | SkillLevel   |
	| C#    | Beginner     |
	| C++   | Intermediate |
	| Java  | Expert       |

Scenario Outline: User Delete skills
	When I delete an existing skill
	Then the deleted skill should not be similar to existing skill

#Scenario Outline: User create profile
	#And I provide '<Title>', '<Description>', '<Tags>', '<ServiceType>', '<LocationType>', '<EndDate>', '<SkillTrade>', '<SkillExchange>' and '<ActiveStatus>' on Service Listning page

#Examples:
	#| Title           | Description           | Tags     | ServiceTypes | LocationType | EndDate    | SkillTrade     | SkillExchange    | ActiveStatus |
	#| Test Automation | This is a Description | Software | Hourly Basis | On site      | 2025-02-23 | Skill Exchange | QualityAssurance | Active       |
	