# hex

A tiny command-line tool that converts hexadecimal to decimal and vice versa.

## Usage

```
hex <value> [<value> ...]
```

Each argument is converted independently and printed as `input: result`.

- **Decimal in, hex out:** a plain integer is printed as lowercase hex with a `0x` prefix.
- **Hex in, decimal out:** a value starting with `0x` (or just `x`) is printed as decimal.

### Examples

```
> hex 255 4096
255: 0xff
4096: 0x1000

> hex 0xff x1F
0xff: 255
0x1f: 31

> hex 255 0x10
255: 0xff
0x10: 16
```

Input is case-insensitive, and the echoed input is normalized to lowercase (with a leading `0` added when you pass `x1F`).

## License

Released under the [MIT License](LICENSE).
