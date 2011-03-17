	.section        ".text"
	.align 4
	.global concatLists
.type    concatLists, #function
concatLists:
save %sp, -96, %sp
mov %i0, %l0
or %l0, 0, %l3
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L15796
nop
ba %icc, .L15802
nop
.L15796:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15807
nop
.L15802:
ba %icc, .L15807
nop
.L15807:
or %l3, 0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L15814
nop
ba %icc, .L15831
nop
.L15814:
or %l3, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l3
ba %icc, .L15807
nop
.L15831:
or %l3, 0, %l1
mov %i1, %l0
stw %l0, [%l1 + 4]
mov %i0, %l0
or %l0, 0, %i0
ret
restore
	.size    concatLists, .-concatLists
	.align 4
	.global add
.type    add, #function
add:
save %sp, -96, %sp
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l2
or %l2, 0, %l1
mov %i1, %l0
stw %l0, [%l1 + 0]
or %l2, 0, %l1
mov %i0, %l0
stw %l0, [%l1 + 4]
or %l2, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    add, .-add
	.align 4
	.global size
.type    size, #function
size:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L15882
nop
ba %icc, .L15887
nop
.L15882:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15892
nop
.L15887:
ba %icc, .L15892
nop
.L15892:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
mov %i0, %l1
ldsw [%l1 + 4], %l1
mov %l1, %o0
call size
nop
mov %o0, %l1
add %l0, %l1, %l0
or %l0, 0, %i0
ret
restore
	.size    size, .-size
	.align 4
	.global get
.type    get, #function
get:
save %sp, -96, %sp
mov %i1, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L15916
nop
ba %icc, .L15923
nop
.L15916:
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15928
nop
.L15923:
ba %icc, .L15928
nop
.L15928:
mov %i0, %l0
ldsw [%l0 + 4], %l2
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l2, %o0
mov %l0, %o1
call get
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
	.size    get, .-get
	.align 4
	.global pop
.type    pop, #function
pop:
save %sp, -96, %sp
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %i0
mov %i0, %l0
or %l0, 0, %i0
ret
restore
	.size    pop, .-pop
	.align 4
	.global printList
.type    printList, #function
printList:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L15971
nop
ba %icc, .L15983
nop
.L15971:
mov %i0, %l0
ldsw [%l0 + 0], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call printList
nop
ba %icc, .L15988
nop
.L15983:
ba %icc, .L15988
nop
.L15988:
ret
restore
	.size    printList, .-printList
	.align 4
	.global treeprint
.type    treeprint, #function
treeprint:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L16001
nop
ba %icc, .L16018
nop
.L16001:
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call treeprint
nop
mov %i0, %l0
ldsw [%l0 + 0], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 8], %l0
mov %l0, %o0
call treeprint
nop
ba %icc, .L16023
nop
.L16018:
ba %icc, .L16023
nop
.L16023:
ret
restore
	.size    treeprint, .-treeprint
	.align 4
	.global freeList
.type    freeList, #function
freeList:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L16036
nop
ba %icc, .L16047
nop
.L16036:
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call freeList
nop
mov %i0, %l0
mov %l0, %o0
call free
nop
ba %icc, .L16052
nop
.L16047:
ba %icc, .L16052
nop
.L16052:
ret
restore
	.size    freeList, .-freeList
	.align 4
	.global freeTree
.type    freeTree, #function
freeTree:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
xor %l2, 1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l1, %l0
be %icc, .L16066
nop
ba %icc, .L16082
nop
.L16066:
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call freeTree
nop
mov %i0, %l0
ldsw [%l0 + 8], %l0
mov %l0, %o0
call freeTree
nop
mov %i0, %l0
mov %l0, %o0
call free
nop
ba %icc, .L16087
nop
.L16082:
ba %icc, .L16087
nop
.L16087:
ret
restore
	.size    freeTree, .-freeTree
	.align 4
	.global postOrder
.type    postOrder, #function
postOrder:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L16100
nop
ba %icc, .L16138
nop
.L16100:
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l1
or %l1, 0, %l2
mov %i0, %l0
ldsw [%l0 + 0], %l0
stw %l0, [%l2 + 0]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 4]
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call postOrder
nop
mov %o0, %l0
mov %i0, %l2
ldsw [%l2 + 8], %l2
mov %l2, %o0
call postOrder
nop
mov %o0, %l2
mov %l0, %o0
mov %l2, %o1
call concatLists
nop
mov %o0, %l2
or %l1, 0, %l0
mov %l2, %o0
mov %l0, %o1
call concatLists
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L16143
nop
.L16138:
ba %icc, .L16143
nop
.L16143:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    postOrder, .-postOrder
	.align 4
	.global treeadd
.type    treeadd, #function
treeadd:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L16160
nop
ba %icc, .L16186
nop
.L16160:
or %g0, 1, %o0
or %g0, 12, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l2
or %l2, 0, %l1
mov %i1, %l0
stw %l0, [%l1 + 0]
or %l2, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 4]
or %l2, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 8]
or %l2, 0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L16191
nop
.L16186:
ba %icc, .L16191
nop
.L16191:
mov %i1, %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L16199
nop
ba %icc, .L16213
nop
.L16199:
mov %i0, %l0
mov %i0, %l1
ldsw [%l1 + 4], %l2
mov %i1, %l1
mov %l2, %o0
mov %l1, %o1
call treeadd
nop
mov %o0, %l1
stw %l1, [%l0 + 4]
ba %icc, .L16230
nop
.L16213:
mov %i0, %l0
mov %i0, %l1
ldsw [%l1 + 8], %l2
mov %i1, %l1
mov %l2, %o0
mov %l1, %o1
call treeadd
nop
mov %o0, %l1
stw %l1, [%l0 + 8]
ba %icc, .L16230
nop
.L16230:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
	.size    treeadd, .-treeadd
	.align 4
	.global quickSort
.type    quickSort, #function
quickSort:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l4
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l5
mov %i0, %l0
mov %l0, %o0
call size
nop
mov %o0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L16257
nop
ba %icc, .L16263
nop
.L16257:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L16268
nop
.L16263:
ba %icc, .L16268
nop
.L16268:
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
mov %l1, %o0
mov %l0, %o1
call get
nop
mov %o0, %l1
mov %i0, %l0
mov %i0, %l2
mov %l2, %o0
call size
nop
mov %o0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
sub %l3, %l2, %l2
mov %l0, %o0
mov %l2, %o1
call get
nop
mov %o0, %l0
add %l1, %l0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sdivx %l1, %l0, %l0
or %l0, 0, %l3
mov %i0, %l0
or %l0, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l2
.L16303:
or %l1, 0, %l6
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l7
or %l7, %lo(0), %l7
cmp %l6, %l0
movne %icc, 1, %l7
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l7, %l0
be %icc, .L16309
nop
ba %icc, .L16382
nop
.L16309:
mov %i0, %l6
or %l2, 0, %l0
mov %l6, %o0
mov %l0, %o1
call get
nop
mov %o0, %l6
or %l3, 0, %l0
sethi %hi(0), %l7
or %l7, %lo(0), %l7
cmp %l6, %l0
movg %icc, 1, %l7
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l7, %l0
be %icc, .L16323
nop
ba %icc, .L16340
nop
.L16323:
or %l5, 0, %l0
mov %i0, %l6
or %l2, 0, %l5
mov %l6, %o0
mov %l5, %o1
call get
nop
mov %o0, %l5
mov %l0, %o0
mov %l5, %o1
call add
nop
mov %o0, %l0
or %l0, 0, %l5
ba %icc, .L16360
nop
.L16340:
or %l4, 0, %l0
mov %i0, %l6
or %l2, 0, %l4
mov %l6, %o0
mov %l4, %o1
call get
nop
mov %o0, %l4
mov %l0, %o0
mov %l4, %o1
call add
nop
mov %o0, %l0
or %l0, 0, %l4
ba %icc, .L16360
nop
.L16360:
or %l1, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l1
or %l2, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
or %l0, 0, %l2
ba %icc, .L16303
nop
.L16382:
mov %i0, %l0
mov %l0, %o0
call freeList
nop
or %l4, 0, %l0
mov %l0, %o0
call quickSort
nop
mov %o0, %l0
or %l5, 0, %l1
mov %l1, %o0
call quickSort
nop
mov %o0, %l1
mov %l0, %o0
mov %l1, %o1
call concatLists
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
	.size    quickSort, .-quickSort
	.align 4
	.global quickSortMain
.type    quickSortMain, #function
quickSortMain:
save %sp, -96, %sp
mov %i0, %l0
mov %l0, %o0
call printList
nop
sethi %hi(999), %l1
or %l1, %lo(999), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
mov %l0, %o0
call printList
nop
sethi %hi(999), %l1
or %l1, %lo(999), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
mov %l0, %o0
call printList
nop
sethi %hi(999), %l1
or %l1, %lo(999), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
or %l0, 0, %i0
ret
restore
	.size    quickSortMain, .-quickSortMain
	.align 4
	.global treesearch
.type    treesearch, #function
treesearch:
save %sp, -96, %sp
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L16452
nop
ba %icc, .L16519
nop
.L16452:
mov %i0, %l0
ldsw [%l0 + 0], %l1
mov %i1, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L16462
nop
ba %icc, .L16467
nop
.L16462:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L16472
nop
.L16467:
ba %icc, .L16472
nop
.L16472:
mov %i0, %l0
ldsw [%l0 + 4], %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L16484
nop
ba %icc, .L16489
nop
.L16484:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L16494
nop
.L16489:
ba %icc, .L16494
nop
.L16494:
mov %i0, %l0
ldsw [%l0 + 8], %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L16506
nop
ba %icc, .L16511
nop
.L16506:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L16521
nop
.L16511:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L16521
nop
.L16521:
ba %icc, .L16524
nop
.L16519:
ba %icc, .L16524
nop
.L16524:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    treesearch, .-treesearch
	.align 4
	.global inOrder
.type    inOrder, #function
inOrder:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L16540
nop
ba %icc, .L16578
nop
.L16540:
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l2
mov %i0, %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 0]
or %l0, 0, %l2
sethi %hi(0), %l1
or %l1, %lo(0), %l1
stw %l1, [%l2 + 4]
mov %i0, %l1
ldsw [%l1 + 4], %l1
mov %l1, %o0
call inOrder
nop
mov %o0, %l1
or %l0, 0, %l0
mov %i0, %l2
ldsw [%l2 + 8], %l2
mov %l2, %o0
call inOrder
nop
mov %o0, %l2
mov %l0, %o0
mov %l2, %o1
call concatLists
nop
mov %o0, %l0
mov %l1, %o0
mov %l0, %o1
call concatLists
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L16586
nop
.L16578:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L16586
nop
.L16586:
	.size    inOrder, .-inOrder
	.align 4
	.global bintreesearch
.type    bintreesearch, #function
bintreesearch:
save %sp, -96, %sp
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L16604
nop
ba %icc, .L16659
nop
.L16604:
mov %i0, %l0
ldsw [%l0 + 0], %l1
mov %i1, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L16614
nop
ba %icc, .L16619
nop
.L16614:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L16624
nop
.L16619:
ba %icc, .L16624
nop
.L16624:
mov %i1, %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L16632
nop
ba %icc, .L16644
nop
.L16632:
mov %i0, %l0
ldsw [%l0 + 4], %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L16661
nop
.L16644:
mov %i0, %l0
ldsw [%l0 + 8], %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L16661
nop
.L16661:
ba %icc, .L16664
nop
.L16659:
ba %icc, .L16664
nop
.L16664:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    bintreesearch, .-bintreesearch
	.align 4
	.global buildTree
.type    buildTree, #function
buildTree:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l2
.L16682:
or %l2, 0, %l0
mov %i0, %l3
mov %l3, %o0
call size
nop
mov %o0, %l3
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l0, %l3
movl %icc, 1, %l4
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l4, %l0
be %icc, .L16691
nop
ba %icc, .L16727
nop
.L16691:
or %l1, 0, %l0
mov %i0, %l3
or %l2, 0, %l1
mov %l3, %o0
mov %l1, %o1
call get
nop
mov %o0, %l1
mov %l0, %o0
mov %l1, %o1
call treeadd
nop
mov %o0, %l0
or %l0, 0, %l1
or %l2, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
or %l0, 0, %l2
ba %icc, .L16682
nop
.L16727:
or %l1, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    buildTree, .-buildTree
	.align 4
	.global treeMain
.type    treeMain, #function
treeMain:
save %sp, -96, %sp
mov %i0, %l0
mov %l0, %o0
call buildTree
nop
mov %o0, %l0
or %l0, 0, %l1
or %l1, 0, %l0
mov %l0, %o0
call treeprint
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l0
mov %l0, %o0
call inOrder
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l2
mov %l2, %o0
call printList
nop
sethi %hi(999), %l3
or %l3, %lo(999), %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sub %l2, %l3, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l0, 0, %l0
mov %l0, %o0
call freeList
nop
or %l1, 0, %l0
mov %l0, %o0
call postOrder
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l2
mov %l2, %o0
call printList
nop
sethi %hi(999), %l3
or %l3, %lo(999), %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sub %l2, %l3, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l0, 0, %l0
mov %l0, %o0
call freeList
nop
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(10), %l0
or %l0, %lo(10), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l3
sethi %hi(2), %l2
or %l2, %lo(2), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
mov %l3, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(3), %l0
or %l0, %lo(3), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(9), %l0
or %l0, %lo(9), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(10), %l0
or %l0, %lo(10), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l3
sethi %hi(2), %l2
or %l2, %lo(2), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
mov %l3, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(3), %l0
or %l0, %lo(3), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(9), %l0
or %l0, %lo(9), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l0
mov %l0, %o0
call freeTree
nop
ret
restore
	.size    treeMain, .-treeMain
	.align 4
	.global myCopy
.type    myCopy, #function
myCopy:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L16978
nop
ba %icc, .L16983
nop
.L16978:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L16988
nop
.L16983:
ba %icc, .L16988
nop
.L16988:
sethi %hi(0), %l1
or %l1, %lo(0), %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
mov %l1, %o0
mov %l0, %o1
call add
nop
mov %o0, %l0
mov %i0, %l1
ldsw [%l1 + 4], %l1
mov %l1, %o0
call myCopy
nop
mov %o0, %l1
mov %l0, %o0
mov %l1, %o1
call concatLists
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
	.size    myCopy, .-myCopy
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
sethi %hi(0), %l2
or %l2, %lo(0), %l2
or %l2, 0, %l2
sethi %hi(0), %l3
or %l3, %lo(0), %l3
or %l3, 0, %l3
.L17019:
or %l3, 0, %l5
sethi %hi(10), %l4
or %l4, %lo(10), %l4
sethi %hi(0), %l6
or %l6, %lo(0), %l6
cmp %l5, %l4
movl %icc, 1, %l6
sethi %hi(1), %l4
or %l4, %lo(1), %l4
cmp %l6, %l4
be %icc, .L17025
nop
ba %icc, .L17084
nop
.L17025:
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
or %l2, 0, %l1
or %l0, 0, %l0
mov %l1, %o0
mov %l0, %o1
call add
nop
mov %o0, %l0
or %l0, 0, %l2
or %l2, 0, %l0
mov %l0, %o0
call myCopy
nop
mov %o0, %l0
or %l0, 0, %l1
or %l2, 0, %l0
mov %l0, %o0
call myCopy
nop
mov %o0, %l0
or %l0, 0, %l0
or %l1, 0, %l4
mov %l4, %o0
call quickSortMain
nop
mov %o0, %l4
or %l4, 0, %l4
or %l4, 0, %l4
mov %l4, %o0
call freeList
nop
or %l0, 0, %l4
mov %l4, %o0
call treeMain
nop
or %l3, 0, %l4
sethi %hi(1), %l3
or %l3, %lo(1), %l3
add %l4, %l3, %l3
or %l3, 0, %l3
ba %icc, .L17019
nop
.L17084:
or %l2, 0, %l2
mov %l2, %o0
call freeList
nop
or %l1, 0, %l1
mov %l1, %o0
call freeList
nop
or %l0, 0, %l0
mov %l0, %o0
call freeList
nop
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    main, .-main
	.common a,4,4
	.common b,4,4
	.common i,4,4
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

