# �`���[�g���A�� (�p�[�g1)

## Mokkosu���C���X�g�[�����悤

[Mokkosu�̃����[�X�y�[�W](https://github.com/lambdataro/Mokkosu/releases)
����ŐV�o�[�W�����̃C���X�g�[�����_�E�����[�h���Ă��܂��B

![�����[�X�y�[�W](img/release.png)

�_�E�����[�h���Ă����C���X�g�[���[���_�u���N���b�N���Ď��s���A
��ʂ̎w���ɏ]���ăC���X�g�[�����܂��B

�C���X�g�[������������ƃX�^�[�g���j���[�ƃf�B�X�N�g�b�v��
MokkosuPad�̃V���[�g�J�b�g���쐬����܂��B

![�V���[�g�J�b�g](img/shortcut.png)

�쐬���ꂽ�V���[�g�J�b�g���_�u���N���b�N����ƁA
MokkosuPad���N�����ȉ��̉�ʂ��\�������΃C���X�g�[���͐����ł��B

![MokkosuPad](img/mokkosupad.png)

## ���b�Z�[�W��\�����悤
### ���b�Z�[�W�{�b�N�X�̕\��

�\�[�X�t�@�C���̗ΐF�̕������������Ĉȉ��̃v���O���������
���Ă݂܂��傤�B

```
msgbox "Hello, World.";
```

`�t�@�C��`���j���[����`���O��t���ĕۑ�`��I��ŁA
�\�[�X�R�[�h��`Hello.mok`�Ƃ������O�ŕۑ����܂��B

`����`���j���[����`���s`��I�ԂƁA
Hello, World.�Ə����ꂽ���b�Z�[�W�{�b�N�X���\������܂��B

![MokkosuPad](img/hello.png)

### ���K���1
��ʂɎ����̖��O��\������v���O�������쐬���Ď��s���Ă݂܂��傤�B

## ���̌v�Z�����悤
Mokkosu �Ŏ����v�Z���Č��ʂ�\������v���O�����������܂��傤�B

�ȉ���`2 + 3 * 4`���v�Z���ĕ\������v���O�����ł��B

```
msgbox(int (2 + 3 * 4));
```

������`int`�͐����l�𕶎���ɕϊ�����֐��ł��B
`msgbox`�֐��̈����͕�����łȂ���΂Ȃ�Ȃ��̂ł��̂悤��
�ϊ����K�v�ɂȂ�܂��B

�v���O���������s����ƈȉ��̕\�����o�܂��B

![���s����](img/tutorial01.png)

�v�Z���ʂ�`14`�ɂȂ��Ă��邱�Ƃɒ��ڂ��Ă��������B
Mokkosu�ł͐��w�̂悤�ɑ����Z������Z�����|���Z�⊄��Z�̕���
��Ɍv�Z����܂��B

���w�Ɠ����悤�Ɋ��ʂ��g���Đ�Ɍv�Z����
�����𖾎����邱�Ƃ��ł��܂��B
�Ⴆ�Ώ�̎���`2 + 3`���Ɍv�Z��������΁A

```
msgbox(int ((2 + 3) * 4));
```

�Ə����܂��B���s����ƍ��x�͈ȉ��̂悤�ɕ\������܂��B

![���s����](img/tutorial02.png)

��̃v���O�����͊��ʂ������Č��Â炢�Ɗ������������Ǝv���܂��B
���̏ꍇ�A�ȉ��̂悤�ɏ������Ƃő������₷�����邱�Ƃ��ł��܂��B

```
msgbox((2 + 3) * 4 |> int);
```

������`|>`�͍��ӂ̌v�Z���ʂ��E�ӂ̊֐��Ɏ󂯓n������������܂��B

### ���K���2
��ӂ̒�����10������5�̎O�p�`�̖ʐς��v�Z����v���O������������
���s���Ă��������B

## �v�Z���ʂɖ��O��t���悤

`let`�����g���ƌv�Z���ʂɖ��O��t���ăv���O�����𕪂���₷��������A
���ʂ�ۑ�������ł��܂��B

�ȉ��̃v���O�����ł́A������`"Hello, World."`��`message`�Ɩ��O��
��t���āA`msgbox`�֐��̓����ŎQ�Ƃ��Ă��܂��B

```
let message = "Hello, World.";
msgbox message;
```

Mokkosu�ł͊֐��̈����Ɋ��ʂ͕s�v�ł��B
�����̈������X�y�[�X�ŋ�؂��ė^���邱�Ƃ��֐��̌Ăяo���������ł��܂��B

��̃v���O���������s����ƈȉ��̂悤�ɕ\������܂��B

![���s����](img/tutorial03.png)

����̃v���O�����͂���܂ł̂��̂ƈ���āA
�o�̓E�C���h�E�Ɉȉ��̂悤�ɕ\������܂��B

```
message : String
```

����͕ϐ�`message`�ɕ�����l���i�[����Ă��邱�Ƃ�
�\���Ă��܂��B

�ȉ��͕ϐ��ɐ����l���i�[������ł��B

```
let x = 1 + 2;
msgbox(x * x |> int);
```

���s����Əo�̓E�C���h�E��

```
x : Int
```

�ƕ\������Ĉȉ����\������܂��B

![���s����](img/tutorial04.png)

`x : Int`��`x`�ɐ����l���i�[����Ă��邱�Ƃ�
�\���Ă��܂��B

### ���K���3
`let`�ƕϐ����g����2��8����v�Z����v���O�����������Ď��s���Ă��������B

## �֐����`���悤

Mokkosu�ł͊ȒP�Ɋ֐����`���邱�Ƃ��ł��܂��B

�ȉ��͈����̒l��{�ɂ��ĕԂ��֐�`double`���`���Ďg����ł��B

```
fun double x = x * 2;
msgbox (double 10 |> int);
```

���s����ƈȉ��̂悤�ɕ\������܂��B

![���s����](img/tutorial05.png)

�E�̏o�̓E�C���h�E�ɒ��ڂ���ƁA

```
double : Int -> Int
```

�ƕ\������Ă��邱�ƂɋC�t���Ǝv���܂��B
����͊֐�`double`���������󂯎���Đ�����Ԃ��֐��ł��邱�Ƃ������Ă��܂��B
���̍����������̌^�ŁA�E�����߂�l�̌^�ł��B

�֐��������𕡐����ꍇ�́A�������𕡐����ׂ܂��B

�ȉ��͎l�p�`�̕��ƍ������^����ꂽ���ɁA
���̎l�p�`�̖ʐς�Ԃ��֐����`���Ďg����ł��B

```
fun area width height = width * height;
msgbox (area 3 5 |> int);
```

���s����ƈȉ��̂悤�ɕ\������܂��B

![���s����](img/tutorial06.png)

�^�͈ȉ��̂悤�ɂȂ�܂��B

```
area : Int -> Int -> Int
```

�����̈��������֐��̌^�͂��̂悤�Ɉ����̌^��`->`�ŋ�؂����^�ɂȂ�܂��B

### ���K���4
�O�p�`�̖ʐς����߂�֐����`���Ă��������B

## �����ɉ����ĕ��򂵂悤

�����ɉ����ĕ��򂷂�ɂ�`if`�����g���܂��B

�Ⴆ�΁A�����̐����̐�Βl�����߂�֐�`abs`�͈ȉ��̂悤�ɒ�`�ł��܂��B

```
fun abs x =
  if x < 0 -> ~-x
  else x;

msgbox (abs 5 |> int);
msgbox (abs ~-3 |> int);
```

������`~-`�͕����𔽓]�����鉉�Z�q�ł��B

���s����ƈȉ��̂悤�ɕ\������܂��B

![���s����](img/tutorial07.png)

![���s����](img/tutorial08.png)

### ���K���5
������2�󂯎���Ă���炪���������2�{�����l��Ԃ��֐����`���Ă��������B
2�̒l�����������ǂ����𒲂ׂ鉉�Z�q��`==`�ł��B

## �ċA�֐����`���悤

�ċA�֐��Ƃ͎������g���Ăяo���֐��̂��Ƃł��B
�ȉ��̃v���O�����ł͎������g���Ăяo�����ƂŁA
�����̐����̊K����v�Z����֐�`fact`���`���Ďg���Ă��܂��B

```
fun fact n =
  if n == 0 -> 1
  else n * fact (n - 1);

msgbox (fact 5 |> int);
```

���s����ƈȉ��̂悤�ɕ\������܂��B

![���s����](img/tutorial09.png)

### ���K���6
1����10�܂ł̐����𑫂����a���v�Z����֐����ċA�֐���p���Ē�`���Ă��������B

### ���K���7
�t�B�{�i�b�`�����n���ڂ��v�Z����֐����ċA�֐���p���Ē�`���Ă��������B

## �܂Ƃ߂Ɨ���E��
### ���b�Z�[�W�̕\��
���b�Z�[�W��\������ɂ�`msgbox`�֐����g���܂��B

������`msgbox`�̌Ăяo�����������ꍇ�́A�\�[�X�R�[�h��
�ォ�珇�ԂɎ��s����Ă����܂��B

### �������e����
�������
```
"abc"
```
�̂悤�Ƀ_�u���N�H�[�e�[�V�����}�[�N�ŕ��������؂��ĕ\���܂��B

�_�u���N�H�[�e�[�V�������̂���ꕶ����\�����߂ɁA
�ȉ��̃G�X�P�[�v�V�[�P���X����`����Ă��܂��B

|�G�X�P�[�v�V�[�P���X | �Ӗ� |
|----------|-----------------|
| \' | �P����p�� |
| \" | ��d���p�� |
| \\ | �~�L�� |
| \0 | �k�� |
| \a | �x�� |
| \b | �o�b�N�X�y�[�X |
| \f | �t�H�[���t�B�[�h |
| \n | ���s |
| \r | �L�����b�W���^�[�� }
| \t | �����^�u |
| \uxxxx | ���j�R�[�h���� |
| \v | �����^�u |

�Ⴆ�Έȉ��̃v���O���������s����ƁA
```
msgbox("hello\nworld");
```

![���s����](img/tutorial10.png)

�ƕ\������܂��B

### �������e����
�����l��
```
123
```
�̂悤�ɐ�������ׂĕ\�����܂��B

�ȉ��̂悤��16�i����8�i���A2�i���Ő����l��\�����邱�Ƃ��ł��܂��B
```
0xff
0o644
0b1101
```

### �������Z�q
�����Ɋւ��鉉�Z�q�ɂ͈ȉ��̂��̂�����܂��B

|���Z�q   |�Ӗ�|
|---------|----|
|��1 + ��2|���Z|
|��1 - ��2|���Z|
|��1 * ��2|��Z|
|��1 / ��2|���Z|
|��1 % ��2|��]|
|~- ��|�������]|

### �������當����ւ̕ϊ�
`int`�֐����g���Ɛ����𕶎���ɕϊ��ł��܂��B

### �����񓯎m�̘A��
`^`���Z�q��2�̕������A���ł��܂��B

�Ⴆ�Έȉ��̃v���O���������s����ƁA

```
msgbox ("2 * 3 = " ^ int (2 * 3));
```

![���s����](img/tutorial11.png)

�ƕ\������܂��B

### �֐��K�p���Z�q
```
��2 |> ��1
```
��
```
��1 ��2
```
�Ɠ����Ӗ��ɂȂ�܂��B

�܂��A
```
��1 <| ��2
```
��
```
��1 ��2
```
�Ɠ����Ӗ��ɂȂ�܂��B
`|>`���Z�q�͗D��x���Ⴂ�̂Ŋ֐��̈����̊��ʂ��ȗ�����Ƃ��Ɏg���܂��B

### let��
```
let ���O = ��;
```
`let`�����g�����ƂŎ��ɖ��O��t���邱�Ƃ��ł��܂��B
���O�Ƃ��ė��p�\�ȕ�����̓A���t�@�x�b�g�A�����A�A���_�[�X�R�A�ł��B
���������O�̍ŏ��̈ꕶ���͐����ȊO�ł���K�v������܂��B

### fun��
```
fun ���O ������1 ������2 ... = ��;
```
`fun`�����g����(�ċA)�֐����`���邱�Ƃ��ł��܂��B

### if��
```
if ������ -> ��1 else ��2
```
if���͏��������v�Z���Ēl��`true`�ɂȂ�Ύ�1���v�Z���A
`false`�ɂȂ�Ύ�2���v�Z���܂��B

��������������ꍇ�͈ȉ��̂悤��`else`�̌��ɂ������`if`���������܂��B

```
if ������1 -> ��1
else if ������2 -> ��2
...
else ��
```

### ��r���Z�q
��r�Ɋւ��鉉�Z�q�ɂ͈ȉ��̂��̂�����܂��B
��r���Z�q��`true`�܂���`false`��Ԃ��܂��B
��r���Z�q�͐����ɂ�������ɂ��g�����Ƃ��ł��܂��B

|���Z�q   |�Ӗ�|
|---------|----|
|��1 == ��2|������|
|��1 <> ��2|�������Ȃ�|
|��1 < ��2|��菬����|
|��1 > ��2|���傫��|
|��1 <= ��2|�ȉ�|
|��1 >= ��2|�ȏ�|

### �_�����Z�q
�^�U�l���Ȃ킿`true`�܂���`false`�Ɋւ��鉉�Z�q�ɂ͈ȉ��̂��̂�����܂��B

|���Z�q   |�Ӗ�|
|---------|----|
|��1 && ��2|����|
|��1 || ��2|�܂���|
|not ��|�ے�|

`(&&)`��`(||)`�̓V���[�g�T�[�L�b�g�]������܂��B
���Ȃ킿�A(&&)�̉E�ӂ̎���`false`�̏ꍇ�͍��ӂ͌v�Z���ꂸ�A
(||)�̉E�ӂ̎���`true`�̏ꍇ�͍��ӂ͌v�Z����܂���B

### �R�����g
�v���O�������ɂ̓R�����g���܂߂邱�Ƃ��ł��܂��B

�R�����g�ɂ�`#`������s�����܂ł̒P��s�R�����g

```
# �P��s�R�����g
```

�ƁA`#[`����`#]`�܂ł̕����s�R�����g

```
#[
�����s�R�����g
#]
```

������܂��B

�����s�R�����g���ꎞ�I�ɖ����ɂ���ɂ́A
�ȉ��̂悤�ɕ����s�R�����g�̊J�n�L����P��s�R�����g��
�R�����g�A�E�g���܂��B

```
##[
�����̓R�����g�ł͂Ȃ�
#]
```