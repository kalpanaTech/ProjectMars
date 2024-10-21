Feature: Skill

This is a platform where users can add and show skills ​​known by users.
People looking for skills ​​can see what details other users have.
User can perform actions add, Update, delete etc.

Background:
	Given I logged into profile page successfully
	Then I remove existing skill details
	
@regression
Scenario Outline: User add skills
	When I click on the Add New Skill button
	When I add new '<Skill>' and '<SkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<Skill>' on the skill related toast message with the '<ActionAdd>'
	Then I should be able to view the added '<Skill>' and '<SkillLevel>' on Skills section
	When I open the '<User>' profile to view added skills
	Then the people seeking for skills can see what '<Skill>' and '<SkillLevel>' I hold
	Then I remove added skill details

Examples:
	| Skill              | SkillLevel   | ActionAdd | User                |
	| Manual Testing     | Beginner     | Add       | Kalpana Dissanayake |
	| Automation Testing | Intermediate | Add       | Kalpana Dissanayake |
	| API Testing        | Expert       | Add       | Kalpana Dissanayake |

Scenario Outline: User update skills
	When I click on the Add New Skill button
	When I add new '<NewSkill>' and '<NewSkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<NewSkill>' on the skill related toast message with the '<ActionAdd>'
	Given I update existing '<Skill>' and '<SkillLevel>' on Skills section
	Then I click on the skill update button
	Then I can see the updated '<Skill>' on the skill related toast message with the '<ActionUpdate>'
	Then I should be able to view the updated '<Skill>' and '<SkillLevel>' on Skills section
	When I open the '<User>' profile to view added skills
	Then the people seeking for skills can see what '<Skill>' and '<SkillLevel>' I hold
	Then I remove added skill details

Examples:
	| NewSkill           | NewSkillLevel | ActionAdd | Skill | SkillLevel   | ActionUpdate | User                |
	| Manual Testing     | Beginner      | Add       | C#    | Intermediate | Update       | Kalpana Dissanayake |
	| Automation Testing | Intermediate  | Add       | C++   | Expert       | Update       | Kalpana Dissanayake |
	| API Testing        | Expert        | Add       | Java  | Beginner     | Update       | Kalpana Dissanayake |

Scenario Outline: User Delete skills
	When I click on the Add New Skill button
	When I add new '<Skill>' and '<SkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<Skill>' on the skill related toast message with the '<ActionAdd>'
	Then I should be able to view the added '<Skill>' and '<SkillLevel>' on Skills section
	When I delete the added skill
	Then I can see the deleted '<Skill>' on the skill related toast message with the '<ActionDelete>'

Examples:
	| Skill        | SkillLevel | ActionAdd | ActionDelete |
	| Load Testing | Beginner   | Add       | Delete       |

Scenario Outline: User cancel the Add Skill
	When I click on the Add New Skill button
	When I add new '<NewSkill>' and '<NewSkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<NewSkill>' on the skill related toast message with the '<ActionAdd>'
	Then I should be able to view the added '<NewSkill>' and '<NewSkillLevel>' on Skills section
	When I click on the Add New Skill button
	When I add new '<Skill>' and '<SkillLevel>' to Skills section
	Then I click on the skill add cancel button
	Then I can see the existing last added '<Skill>' on the Skill section
	Then I remove added skill details

Examples:
	| NewSkill       | NewSkillLevel | ActionAdd | Skill | SkillLevel   |
	| Manual Testing | Beginner      | Add       | C#    | Intermediate |

Scenario Outline: User Cancel the Update Skill
	When I click on the Add New Skill button
	When I add new '<NewSkill>' and '<NewSkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<NewSkill>' on the skill related toast message with the '<ActionAdd>'
	Given I update existing '<Skill>' and '<SkillLevel>' on Skills section
	And I click on the update skill cancellation button
	Then I can see the relevent '<Skill>' and '<SkillLevel>' not updated on Skills section
	Then I remove added skill details

Examples:
	| NewSkill       | NewSkillLevel | ActionAdd | Skill | SkillLevel   |
	| Manual Testing | Beginner      | Add       | C#    | Intermediate |

Scenario Outline: User can add skill with a huge payload
	When I click on the Add New Skill button
	When I add new '<Skill>' and '<SkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<Skill>' on the skill related toast message with the '<ActionAdd>'
	Then I should be able to view the added '<Skill>' and '<SkillLevel>' on Skills section
	When I open the '<User>' profile to view added skills
	Then the people seeking for skills can see what '<Skill>' and '<SkillLevel>' I hold
	Then I remove added skill details

Examples:
	| Skill     | SkillLevel | ActionAdd | User                |
	| HugeSkill | Beginner   | Add       | Kalpana Dissanayake |

Scenario Outline: User input duplicate skill and skill level
	When I click on the Add New Skill button
	When I add new '<FirstSkill>' and '<FirstSkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<FirstSkill>' on the skill related toast message with the '<ActionAdd>'
	Then I should be able to view the added '<FirstSkill>' and '<FirstSkillLevel>' on Skills section
	When I click on the Add New Skill button
	When I add new '<SecondSkill>' and '<SecondSkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<SecondSkill>' on the skill related toast message with the '<ActionAdd>'
	Then I remove added skill details

Examples:
	| FirstSkill         | FirstSkillLevel | SecondSkill        | SecondSkillLevel | ActionAdd | ActionAddExist        |
	| Automation Testing | Beginner        | Automation Testing | Expert           | Add       | AddExistingSkill      |
	| Security Testing   | Expert          | Regression Testing | Expert           | Add       | AddExistingSkillLevel |


Scenario Outline: User input invalid inputs as skill and skill level
	When I click on the Add New Skill button
	When I add new '<Skill>' and '<SkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<Skill>' on the skill related toast message with the '<ActionAdd>'

Examples:
	| Skill          | SkillLevel   | ActionAdd |
	| Sanity Testing |              | AddNull   |
	|                | Intermediate | AddNull   |

