# Idle Developer


### Setting
You are a developer starting out on your IT journey, you will be learning frameworks, languages and tools that will allow you to earn money in order to obtain the tools you need to get more money and StackOverflow fame. 
Starting out you will choose a path, this means you will be choosing what language you want to learn first (eg: `HTML`, `Python`, `Java`, etc), some languages will be harder than others.
Once you will start learning that language, other languages, frameworks and tools can be unlocked as well.
When you achieve proficiency in a language, you can look for jobs, from which you can earn coins. Job oppurtunites grow as you learn more languages, your overall player level increases, and you become more proficient in these languages.
You can also start working on side projects, which serve as another source of income to you, more projects become available in a similar way to how jobs do, (Meaning that you will not be able to start an Operating System project while being level 2 in HTML).
With coins you can buy items and numerous tools from the shop.

---

### Developer 
This is essentially your player character, you have coins, xp, levels, grades, and a number of other stuff we will go over.

#### XP
XP, or simply experience points, are points that contribute to your overall player level. This is your player XP, which is different to XP gained in languages, frameworks and tools.

##### Usages

* `Levelling:` Upon reaching enough XP, your player will level up
* `Unlocking Fields:` Using your player XP, you can purchase languages, frameworks and tools

##### Obtainment

* `Learning Sessions:` Player XP is obtained whenever you complete a learning session for a language, framework or tool.
* `Levelling Fields:` Player XP is obtained whenever you level up in a language, framework or tool

##### Multiplier

Your player has an XP Multiplier value, that adds to how much player XP you earn (by multiplying it), this value is at 1 by default, however can be increased by using items, learning certain tools, etc.


#### Level
This is your player level, when your player XP reaches a certain point, you level up. This may unlock certain items and may open up jobs and projects for you. 
This level directly contributes to your overall grade as a developer.

#### Grade
This is your overall grade as a developer, depending on your player level it can range from `F` to `S++`
Here is the complete list of possible grades, in ascending order:
`F` --> `D` --> `C` --> `B` --> `A` --> `S` --> `S+` --> `S++`

#### Coins
This is the in game currency. It can be used to purchase items from the shop.
It can be obtained through jobs or through projects.

---

### Languages
Languages are one of the things that you can level up in, essentially you have a language that you learn. Completing a learning session results in XP being earned in that language, when you have enough XP then the level of the language automatically goes up. This is very similar to your player, and languages even follow the same **Grade** system. However it is for this language, and while it contributes to your player XP, it is not the same thing. 
To unlock more languages you buy them using player XP.
Here is what we mean by `"learning session"`, it is an example from the popular mobile game AdVenture Capitalist: 

![AdVenture Capitalist Session](https://user-images.githubusercontent.com/56786013/113504625-95924e00-9539-11eb-8824-d2d3d1eeb0cc.jpg)  

The picture should make clear what is meant by session, given that you have played an "Idle" Game before.

---

### Frameworks
Frameworks are similar to languages, however these provide many more job oppurtunites, and also allow you to build your own projects, which may be another source of income. Frameworks also have language requirements, such that you may need to be proficient (eg: At least level 10) in a language or number of languages, in order to make that framework available to you.
To unlock a framework you buy it using player XP, given that of course, it is available to you.

---

### Tools
Tools are developer tools that aid in development, tools to learn can also be purchased for coins instead of player XP if they are proprietary(eg: IntelliJ Ultimate, Adobe Products).
Essentially these are similar to languages and frameworks, however may also provide certain benefits, like adding to the player's XP multiplier.

---

### Jobs
Jobs are unlocked when you have reached a certain level in what you are learning, allowing you to gain in game currency through a job session, which is similar to a learning session, except that it gets you money but less XP than a learning session. Jobs can be working at a company, Freelancing, Youtubing, Blogging, etc.

---

### Projects
Projects are coding projects that you create on ypour own based on your skill set, you can make money off of these and use them as a secondary income source. Projects are also a way of creating your own items, similar to crafting, you could build a robot and code it through an arduino/components bought in the shop, a discord bot, build and code a keyboard, etc. Projects are a central aspect of the game, equivalent to crafting.

---

### Items
Items are things you can buy from the shop using in game currency, these can be hardware components (Computer Components, Peripherals, Chipsets, etc.), proprietary software tools (IDEs, Subscriptions, etc), Computing Books (Increase Level), Furniture, etc. Tools that you buy will be treated as software tools, and as such will also have learning sessions for them. Items are divided into rarities, namely: Common, Uncommon, Rare, Epic, Legendary, Mythical, Ancient, Forbidden, and they also may have modifiers on them.

---

### Session
A session is a core component of this game, it can be a learning session that results in XP for a language/framework/tool or a job session that results in money being earned. Multiple sessions can be held at once, tapping on the session buttons will speed up their progress, all sessions automatically restart once finish.

---

## Misconceptions
**`Cost`**
```csharp
public int Cost {get; set;}
```
You will find this property in Language, Framework, Tool and Item classes.
However it can refer to the cost in Player XP to unlock a language/framework/tool or the cost in coins to purchase an item

