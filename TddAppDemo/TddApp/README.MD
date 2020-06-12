TDD

Good articles
http://www.butunclebob.com/ArticleS.UncleBob.TheThreeRulesOfTdd
http://www.butunclebob.com/ArticleS.UncleBob.TheBowlingGameKata

**Red** 
- A common mistake for newbies to TDD is to gloss over the need to see the test fail first. It's part of keeping on course; the red is extremely valuable feedback that tells us our assumptions still hold true. Once in a while, they won't, and you'll have saved yourself a lot of time by finding that out immediately.

**Green** 
- Keep rough track of how long it takes you to derive a solution that passes all your tests. If you're taking 5-10 minutes on average, or more, start figuring out ways to take smaller steps.

**Refactor** 
- You should always take advantage of the refactoring step. Even if you added perfect code (that doesn't duplicate any other code in the system), treat the refactoring step as "mandatory bonus time." Poke around the area you're changing. Get rid of a warning. Rename a test. Improve the readability of an existing method. Follow the boy scout rule: Make things a little better when you leave than they were when you arrived. Note that the refactor step doesn't necessarily represent a single green test run: You should look to decompose refactoring efforts into even tinier steps, getting a rapid succession of green bars before moving on.
