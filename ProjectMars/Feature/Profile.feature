Feature: ProfileFeature

A short summary of the feature


Background:
	Given I logged into profile page successfully
	
@regression
Scenario Outline: User add languages
	And I click on the Add New button
	And I add new '<Language>' and '<LanguageLevel>' to Languages section
	Then I click on the Add button
	Then I can see the added '<Language>' on the toast message with the '<ActionAdd>'
	Then I should be able to view the added '<Language>' and '<LanguageLevel>' on Languages section
	When I open the '<User>' profile to view added languages
	Then the people seeking for languages can see what '<Language>' and '<LanguageLevel>' I hold

Examples:
	| Language | LanguageLevel  | ActionAdd | User                |
	| English  | Fluent         | Add       | Kalpana Dissanayake |
	| German   | Conversational | Add       | Kalpana Dissanayake |
	| Chinese  | Basic          | Add       | Kalpana Dissanayake |

Scenario Outline: User update languages
	And I update existing '<Language>' and '<LanguageLevel>' on Languages section
	Then I click on the Update button
	Then I can see the updated '<Language>' on the toast message with the '<ActionUpdate>'
	Then I should be able to view the updated '<Language>' and '<LanguageLevel>' on Languages section
	When I open the '<User>' profile to view added languages
	Then the people seeking for languages can see what '<Language>' and '<LanguageLevel>' I hold

Examples:
	| Language | LanguageLevel    | ActionUpdate | User                |
	| Spanish  | Fluent           | Update       | Kalpana Dissanayake |
	| French   | Conversational   | Update       | Kalpana Dissanayake |
	| Russian  | Basic            | Update       | Kalpana Dissanayake |
	| Mandarin | Native/Bilingual | Update       | Kalpana Dissanayake |

Scenario Outline: User Delete language
	And I click on the Add New button
	And I add new '<Language>' and '<LanguageLevel>' to Languages section
	Then I click on the Add button
	Then I can see the added '<Language>' on the toast message with the '<ActionAdd>'
	Then I should be able to view the added '<Language>' and '<LanguageLevel>' on Languages section
	When I delete the added language
	Then I can see the deleted '<Language>' on the toast message with the '<ActionDelete>'
	Then the deleted '<Language>' should not be included on languages section

Examples:
	| Language | LanguageLevel | ActionAdd | ActionDelete |
	| Tamil    | Fluent        | Add       | Delete       |

Scenario Outline: User Cancel the Add language
	And I click on the Add New button
	And I add new '<Language>' and '<LanguageLevel>' to Languages section
	Then I click on the cancel button
	Then I can see the existing last added '<Language>' without any change

Examples:
	| Language | LanguageLevel |
	| English  | Fluent        |

Scenario Outline: User Cancel the Update Language

Scenario Outline: User add skills
	And I click on the Add New Skill button
	And I add new '<Skill>' and '<SkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<Skill>' on the skill related toast message with the '<ActionAdd>'
	Then I should be able to view the added '<Skill>' and '<SkillLevel>' on Skills section
	When I open the '<User>' profile to view added skills
	Then the people seeking for skills can see what '<Skill>' and '<SkillLevel>' I hold

Examples:
	| Skill              | SkillLevel   | ActionAdd | User                |
	| Manual Testing     | Beginner     | Add       | Kalpana Dissanayake |
	| Automation Testing | Intermediate | Add       | Kalpana Dissanayake |
	| API Testing        | Expert       | Add       | Kalpana Dissanayake |

Scenario Outline: User update skills
	And I update existing '<Skill>' and '<SkillLevel>' on Skills section
	Then I click on the skill update button
	Then I can see the updated '<Skill>' on the skill related toast message with the '<ActionUpdate>'
	Then I should be able to view the updated '<Skill>' and '<SkillLevel>' on Skills section
	When I open the '<User>' profile to view added skills
	Then the people seeking for skills can see what '<Skill>' and '<SkillLevel>' I hold

Examples:
	| Skill | SkillLevel   | ActionUpdate | User                |
	| C#    | Beginner     | Update       | Kalpana Dissanayake |
	| C++   | Intermediate | Update       | Kalpana Dissanayake |
	| Java  | Expert       | Update       | Kalpana Dissanayake |

Scenario Outline: User Delete skills
	And I click on the Add New Skill button
	And I add new '<Skill>' and '<SkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<Skill>' on the skill related toast message with the '<ActionAdd>'
	Then I should be able to view the added '<Skill>' and '<SkillLevel>' on Skills section
	When I delete the added skill
	Then I can see the deleted '<Skill>' on the skill related toast message with the '<ActionDelete>'
	Then the deleted '<Skill>' should not be included on skills section

Examples:
	| Skill        | SkillLevel | ActionAdd | ActionDelete |
	| Load Testing | Beginner   | Add       | Delete       |

Scenario Outline: User cancel the Add Skill
	And I click on the Add New Skill button
	And I add new '<Skill>' and '<SkillLevel>' to Skills section
	Then I click on the skill add cancel button
	Then I can see the existing last added '<Skill>' on the Skill section without any change

Examples:
	| Skill               | SkillLevel |
	| Performance Testing | Beginner   |
















#Scenario Outline: User create profile
	#And I provide '<Title>', '<Description>', '<Tags>', '<ServiceType>', '<LocationType>', '<EndDate>', '<SkillTrade>', '<SkillExchange>' and '<ActiveStatus>' on Service Listning page

#Examples:
	#| Title           | Description           | Tags     | ServiceTypes | LocationType | EndDate    | SkillTrade     | SkillExchange    | ActiveStatus |
	#| Test Automation | This is a Description | Software | Hourly Basis | On site      | 2025-02-23 | Skill Exchange | QualityAssurance | Active       |
	