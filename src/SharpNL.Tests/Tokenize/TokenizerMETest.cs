﻿// 
//  Copyright 2014 Gustavo J Knuppe (https://github.com/knuppe)
// 
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
// 
//       http://www.apache.org/licenses/LICENSE-2.0
// 
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// 
//   - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//   - May you do good and not evil.                                         -
//   - May you find forgiveness for yourself and forgive others.             -
//   - May you share freely, never taking more than you give.                -
//   - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//  

using NUnit.Framework;
using SharpNL.Tokenize;

namespace SharpNL.Tests.Tokenize {
    [TestFixture]
    internal class TokenizerMETest {

        [Test]
        public void TestTokenizerSimpleModel() {
            var model = TokenizerTestUtil.CreateMaxentTokenModel();
            var tokenizer = new TokenizerME(model);
            var tokens = tokenizer.Tokenize("test,");

            Assert.AreEqual(2, tokens.Length);
            Assert.AreEqual("test", tokens[0]);
            Assert.AreEqual(",", tokens[1]);
        }

        [Test]
        public void TestTokenizer() {
            var model = TokenizerTestUtil.CreateMaxentTokenModel();
            var tokenizer = new TokenizerME(model);
            var tokens = tokenizer.Tokenize("Sounds like it's not properly thought through!");

            Assert.AreEqual(9, tokens.Length);
            Assert.AreEqual("Sounds", tokens[0]);
            Assert.AreEqual("like", tokens[1]);
            Assert.AreEqual("it", tokens[2]);
            Assert.AreEqual("'s", tokens[3]);
            Assert.AreEqual("not", tokens[4]);
            Assert.AreEqual("properly", tokens[5]);
            Assert.AreEqual("thought", tokens[6]);
            Assert.AreEqual("through", tokens[7]);
            Assert.AreEqual("!", tokens[8]);

        }

    }
}