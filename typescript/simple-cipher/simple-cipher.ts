class SimpleCipher {
  public key: string
  private letters = "abcdefghijklmnopqrstuvwxyz"

  constructor(key?: string) {
    if (!key && key !== "") {
      this.key = this.randomString(key ? key.length : 100)
    } else if (!key.match(/^[a-z]+$/)) {
      throw "Bad key"
    } else {
      this.key = key
    }
  }

  encode = (s: string) => this.code(s, (i: number, j: number) => i + j)

  decode = (s: string) => this.code(s, (i: number, j: number) => i - j)

  code = (
    s: string,
    shiftUpOrDown: (charNum: number, shiftNum: number) => number
  ) => {
    let cipher = ""
    for (let i = 0; i < s.length; i++) {
      const charNum = this.letters.indexOf(s[i])
      const shiftNum = this.letters.indexOf(this.key[i % this.key.length])
      const newPosition = shiftUpOrDown(charNum, shiftNum)
      const encodedChar = this.moveChar(newPosition)
      cipher += encodedChar
    }
    return cipher
  }

  randomString = (length: number) => {
    let text = ""
    for (let i = 0; i < length; i++) {
      const position = Math.floor(Math.random() * this.letters.length)
      text += this.moveChar(position)
    }
    return text
  }

  moveChar = (position: number) => {
    position += this.letters.length // to ensure position is a positive number
    return this.letters.charAt(position % this.letters.length)
  }
}

export default SimpleCipher
