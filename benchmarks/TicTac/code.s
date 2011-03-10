	.section        ".text"
	.align 4
	.global cleanBoard
.type    cleanBoard, #function
cleanBoard:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 0]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 4]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 8]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 12]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 16]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 20]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 24]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 28]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 32]
ret
restore
	.size    cleanBoard, .-cleanBoard
	.align 4
	.global printBoard
.type    printBoard, #function
printBoard:
save %sp, -96, %sp
mov %i0, %l0
ldsw [%l0 + 0], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 4], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 8], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 12], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 16], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 20], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 24], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 28], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 32], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ret
restore
	.size    printBoard, .-printBoard
	.align 4
	.global printMoveBoard
.type    printMoveBoard, #function
printMoveBoard:
save %sp, -96, %sp
sethi %hi(123), %l0
or %l0, %lo(123), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(456), %l0
or %l0, %lo(456), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(789), %l0
or %l0, %lo(789), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ret
restore
	.size    printMoveBoard, .-printMoveBoard
	.align 4
	.global placePiece
.type    placePiece, #function
placePiece:
save %sp, -96, %sp
mov %i2, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11705
nop
ba %icc, .L11713
nop
.L11705:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 0]
ba %icc, .L11870
nop
.L11713:
mov %i2, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11721
nop
ba %icc, .L11729
nop
.L11721:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 4]
ba %icc, .L11868
nop
.L11729:
mov %i2, %l1
sethi %hi(3), %l0
or %l0, %lo(3), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11737
nop
ba %icc, .L11745
nop
.L11737:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 8]
ba %icc, .L11865
nop
.L11745:
mov %i2, %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11753
nop
ba %icc, .L11761
nop
.L11753:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 12]
ba %icc, .L11862
nop
.L11761:
mov %i2, %l1
sethi %hi(5), %l0
or %l0, %lo(5), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11769
nop
ba %icc, .L11777
nop
.L11769:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 16]
ba %icc, .L11859
nop
.L11777:
mov %i2, %l1
sethi %hi(6), %l0
or %l0, %lo(6), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11785
nop
ba %icc, .L11793
nop
.L11785:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 20]
ba %icc, .L11856
nop
.L11793:
mov %i2, %l1
sethi %hi(7), %l0
or %l0, %lo(7), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11801
nop
ba %icc, .L11809
nop
.L11801:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 24]
ba %icc, .L11853
nop
.L11809:
mov %i2, %l1
sethi %hi(8), %l0
or %l0, %lo(8), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11817
nop
ba %icc, .L11825
nop
.L11817:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 28]
ba %icc, .L11850
nop
.L11825:
mov %i2, %l1
sethi %hi(9), %l0
or %l0, %lo(9), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11833
nop
ba %icc, .L11841
nop
.L11833:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 32]
ba %icc, .L11847
nop
.L11841:
ba %icc, .L11847
nop
.L11847:
ba %icc, .L11850
nop
.L11850:
ba %icc, .L11853
nop
.L11853:
ba %icc, .L11856
nop
.L11856:
ba %icc, .L11859
nop
.L11859:
ba %icc, .L11862
nop
.L11862:
ba %icc, .L11865
nop
.L11865:
ba %icc, .L11868
nop
.L11868:
ba %icc, .L11870
nop
.L11870:
ret
restore
	.size    placePiece, .-placePiece
	.align 4
	.global checkWinner
.type    checkWinner, #function
checkWinner:
save %sp, -96, %sp
mov %i0, %l0
ldsw [%l0 + 0], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11884
nop
ba %icc, .L11917
nop
.L11884:
mov %i0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11893
nop
ba %icc, .L11912
nop
.L11893:
mov %i0, %l0
ldsw [%l0 + 8], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11902
nop
ba %icc, .L11907
nop
.L11902:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L11914
nop
.L11907:
ba %icc, .L11914
nop
.L11914:
ba %icc, .L11919
nop
.L11912:
ba %icc, .L11919
nop
.L11919:
ba %icc, .L11922
nop
.L11917:
ba %icc, .L11922
nop
.L11922:
mov %i0, %l0
ldsw [%l0 + 0], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11929
nop
ba %icc, .L11962
nop
.L11929:
mov %i0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11938
nop
ba %icc, .L11957
nop
.L11938:
mov %i0, %l0
ldsw [%l0 + 8], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11947
nop
ba %icc, .L11952
nop
.L11947:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L11959
nop
.L11952:
ba %icc, .L11959
nop
.L11959:
ba %icc, .L11964
nop
.L11957:
ba %icc, .L11964
nop
.L11964:
ba %icc, .L11967
nop
.L11962:
ba %icc, .L11967
nop
.L11967:
mov %i0, %l0
ldsw [%l0 + 12], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11974
nop
ba %icc, .L12007
nop
.L11974:
mov %i0, %l0
ldsw [%l0 + 16], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11983
nop
ba %icc, .L12002
nop
.L11983:
mov %i0, %l0
ldsw [%l0 + 20], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11992
nop
ba %icc, .L11997
nop
.L11992:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12004
nop
.L11997:
ba %icc, .L12004
nop
.L12004:
ba %icc, .L12009
nop
.L12002:
ba %icc, .L12009
nop
.L12009:
ba %icc, .L12012
nop
.L12007:
ba %icc, .L12012
nop
.L12012:
mov %i0, %l0
ldsw [%l0 + 12], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12019
nop
ba %icc, .L12052
nop
.L12019:
mov %i0, %l0
ldsw [%l0 + 16], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12028
nop
ba %icc, .L12047
nop
.L12028:
mov %i0, %l0
ldsw [%l0 + 20], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12037
nop
ba %icc, .L12042
nop
.L12037:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12049
nop
.L12042:
ba %icc, .L12049
nop
.L12049:
ba %icc, .L12054
nop
.L12047:
ba %icc, .L12054
nop
.L12054:
ba %icc, .L12057
nop
.L12052:
ba %icc, .L12057
nop
.L12057:
mov %i0, %l0
ldsw [%l0 + 24], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12064
nop
ba %icc, .L12097
nop
.L12064:
mov %i0, %l0
ldsw [%l0 + 28], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12073
nop
ba %icc, .L12092
nop
.L12073:
mov %i0, %l0
ldsw [%l0 + 32], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12082
nop
ba %icc, .L12087
nop
.L12082:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12094
nop
.L12087:
ba %icc, .L12094
nop
.L12094:
ba %icc, .L12099
nop
.L12092:
ba %icc, .L12099
nop
.L12099:
ba %icc, .L12102
nop
.L12097:
ba %icc, .L12102
nop
.L12102:
mov %i0, %l0
ldsw [%l0 + 24], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12109
nop
ba %icc, .L12142
nop
.L12109:
mov %i0, %l0
ldsw [%l0 + 28], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12118
nop
ba %icc, .L12137
nop
.L12118:
mov %i0, %l0
ldsw [%l0 + 32], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12127
nop
ba %icc, .L12132
nop
.L12127:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12139
nop
.L12132:
ba %icc, .L12139
nop
.L12139:
ba %icc, .L12144
nop
.L12137:
ba %icc, .L12144
nop
.L12144:
ba %icc, .L12147
nop
.L12142:
ba %icc, .L12147
nop
.L12147:
mov %i0, %l0
ldsw [%l0 + 0], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12154
nop
ba %icc, .L12187
nop
.L12154:
mov %i0, %l0
ldsw [%l0 + 12], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12163
nop
ba %icc, .L12182
nop
.L12163:
mov %i0, %l0
ldsw [%l0 + 24], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12172
nop
ba %icc, .L12177
nop
.L12172:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12184
nop
.L12177:
ba %icc, .L12184
nop
.L12184:
ba %icc, .L12189
nop
.L12182:
ba %icc, .L12189
nop
.L12189:
ba %icc, .L12192
nop
.L12187:
ba %icc, .L12192
nop
.L12192:
mov %i0, %l0
ldsw [%l0 + 0], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12199
nop
ba %icc, .L12232
nop
.L12199:
mov %i0, %l0
ldsw [%l0 + 12], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12208
nop
ba %icc, .L12227
nop
.L12208:
mov %i0, %l0
ldsw [%l0 + 24], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12217
nop
ba %icc, .L12222
nop
.L12217:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12229
nop
.L12222:
ba %icc, .L12229
nop
.L12229:
ba %icc, .L12234
nop
.L12227:
ba %icc, .L12234
nop
.L12234:
ba %icc, .L12237
nop
.L12232:
ba %icc, .L12237
nop
.L12237:
mov %i0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12244
nop
ba %icc, .L12277
nop
.L12244:
mov %i0, %l0
ldsw [%l0 + 16], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12253
nop
ba %icc, .L12272
nop
.L12253:
mov %i0, %l0
ldsw [%l0 + 28], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12262
nop
ba %icc, .L12267
nop
.L12262:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12274
nop
.L12267:
ba %icc, .L12274
nop
.L12274:
ba %icc, .L12279
nop
.L12272:
ba %icc, .L12279
nop
.L12279:
ba %icc, .L12282
nop
.L12277:
ba %icc, .L12282
nop
.L12282:
mov %i0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12289
nop
ba %icc, .L12322
nop
.L12289:
mov %i0, %l0
ldsw [%l0 + 16], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12298
nop
ba %icc, .L12317
nop
.L12298:
mov %i0, %l0
ldsw [%l0 + 28], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12307
nop
ba %icc, .L12312
nop
.L12307:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12319
nop
.L12312:
ba %icc, .L12319
nop
.L12319:
ba %icc, .L12324
nop
.L12317:
ba %icc, .L12324
nop
.L12324:
ba %icc, .L12327
nop
.L12322:
ba %icc, .L12327
nop
.L12327:
mov %i0, %l0
ldsw [%l0 + 8], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12334
nop
ba %icc, .L12367
nop
.L12334:
mov %i0, %l0
ldsw [%l0 + 20], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12343
nop
ba %icc, .L12362
nop
.L12343:
mov %i0, %l0
ldsw [%l0 + 32], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12352
nop
ba %icc, .L12357
nop
.L12352:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12364
nop
.L12357:
ba %icc, .L12364
nop
.L12364:
ba %icc, .L12369
nop
.L12362:
ba %icc, .L12369
nop
.L12369:
ba %icc, .L12372
nop
.L12367:
ba %icc, .L12372
nop
.L12372:
mov %i0, %l0
ldsw [%l0 + 8], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12379
nop
ba %icc, .L12412
nop
.L12379:
mov %i0, %l0
ldsw [%l0 + 20], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12388
nop
ba %icc, .L12407
nop
.L12388:
mov %i0, %l0
ldsw [%l0 + 32], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12397
nop
ba %icc, .L12402
nop
.L12397:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12409
nop
.L12402:
ba %icc, .L12409
nop
.L12409:
ba %icc, .L12414
nop
.L12407:
ba %icc, .L12414
nop
.L12414:
ba %icc, .L12417
nop
.L12412:
ba %icc, .L12417
nop
.L12417:
sethi %hi(-1), %l0
or %l0, %lo(-1), %l0
or %l0, 0, %i0
ret
restore
	.size    checkWinner, .-checkWinner
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(0), %l3
or %l3, %lo(0), %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(-1), %l2
or %l2, %lo(-1), %l2
or %g0, 1, %o0
or %g0, 36, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l4
mov %l4, %o0
call cleanBoard
nop
.L12456:
or %l2, 0, %l5
sethi %hi(0), %l4
or %l4, %lo(0), %l4
sethi %hi(0), %l7
or %l7, %lo(0), %l7
cmp %l5, %l4
movl %icc, 1, %l7
or %l1, 0, %l5
sethi %hi(8), %l4
or %l4, %lo(8), %l4
sethi %hi(0), %l6
or %l6, %lo(0), %l6
cmp %l5, %l4
movne %icc, 1, %l6
and %l7, %l6, %l5
sethi %hi(1), %l4
or %l4, %lo(1), %l4
cmp %l5, %l4
be %icc, .L12469
nop
ba %icc, .L12556
nop
.L12469:
or %l0, 0, %l2
mov %l2, %o0
call printBoard
nop
or %l3, 0, %l4
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l2
move %icc, 1, %l5
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l5, %l2
be %icc, .L12481
nop
ba %icc, .L12502
nop
.L12481:
or %l3, 0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
add %l3, %l2, %l2
or %l2, 0, %l3
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l2
or %l2, 0, %l2
or %l0, 0, %l5
sethi %hi(1), %l4
or %l4, %lo(1), %l4
or %l2, 0, %l2
mov %l5, %o0
mov %l4, %o1
mov %l2, %o2
call placePiece
nop
ba %icc, .L12526
nop
.L12502:
or %l3, 0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
sub %l3, %l2, %l2
or %l2, 0, %l3
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l2
or %l2, 0, %l2
or %l0, 0, %l5
sethi %hi(2), %l4
or %l4, %lo(2), %l4
or %l2, 0, %l2
mov %l5, %o0
mov %l4, %o1
mov %l2, %o2
call placePiece
nop
ba %icc, .L12526
nop
.L12526:
or %l0, 0, %l2
mov %l2, %o0
call checkWinner
nop
mov %o0, %l2
or %l2, 0, %l2
or %l1, 0, %l4
sethi %hi(1), %l1
or %l1, %lo(1), %l1
add %l4, %l1, %l1
or %l1, 0, %l1
ba %icc, .L12456
nop
.L12556:
or %l2, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    main, .-main
	.section        ".rodata"
	.align 8
.ConstantString0:
	.asciz  "%d "
	.align 8
.ConstantString1:
	.asciz  "%d\n"
	.align 8
.ConstantString2:
	.asciz  "%d"

