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
be %icc, .L111
nop
ba %icc, .L117
nop
.L111:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L122
nop
.L117:
ba %icc, .L122
nop
.L122:
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
be %icc, .L186
nop
ba %icc, .L296
nop
.L186:
or %l3, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l3
ba %icc, .L122
nop
.L296:
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
be %icc, .L362
nop
ba %icc, .L374
nop
.L362:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L381
nop
.L374:
ba %icc, .L381
nop
.L381:
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
be %icc, .L453
nop
ba %icc, .L471
nop
.L453:
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L478
nop
.L471:
ba %icc, .L478
nop
.L478:
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
be %icc, .L593
nop
ba %icc, .L640
nop
.L593:
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
ba %icc, .L645
nop
.L640:
ba %icc, .L645
nop
.L645:
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
be %icc, .L659
nop
ba %icc, .L681
nop
.L659:
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
ba %icc, .L686
nop
.L681:
ba %icc, .L686
nop
.L686:
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
be %icc, .L708
nop
ba %icc, .L735
nop
.L708:
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call freeList
nop
mov %i0, %l0
mov %l0, %o0
call free
nop
ba %icc, .L745
nop
.L735:
ba %icc, .L745
nop
.L745:
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
be %icc, .L838
nop
ba %icc, .L854
nop
.L838:
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
ba %icc, .L859
nop
.L854:
ba %icc, .L859
nop
.L859:
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
be %icc, .L873
nop
ba %icc, .L930
nop
.L873:
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
ba %icc, .L935
nop
.L930:
ba %icc, .L935
nop
.L935:
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
be %icc, .L952
nop
ba %icc, .L979
nop
.L952:
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
ba %icc, .L984
nop
.L979:
ba %icc, .L984
nop
.L984:
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
be %icc, .L1068
nop
ba %icc, .L1082
nop
.L1068:
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
ba %icc, .L1099
nop
.L1082:
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
ba %icc, .L1099
nop
.L1099:
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
sethi %hi(0), %l4
or %l4, %lo(0), %l4
sethi %hi(0), %l5
or %l5, %lo(0), %l5
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
be %icc, .L1126
nop
ba %icc, .L1132
nop
.L1126:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1137
nop
.L1132:
ba %icc, .L1137
nop
.L1137:
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
add %l1, %l0, %l0
sra %l0, 1, %l0
or %l0, 0, %l3
mov %i0, %l0
or %l0, 0, %l1
sethi %hi(0), %l2
or %l2, %lo(0), %l2
.L1172:
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
be %icc, .L1178
nop
ba %icc, .L1251
nop
.L1178:
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
be %icc, .L1192
nop
ba %icc, .L1209
nop
.L1192:
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
ba %icc, .L1229
nop
.L1209:
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
ba %icc, .L1229
nop
.L1229:
or %l1, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l1
or %l2, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
or %l0, 0, %l2
ba %icc, .L1172
nop
.L1251:
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
mov %l0, %o0
call printList
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
mov %l0, %o0
call printList
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-1), %l0
or %l0, %lo(-1), %l0
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
be %icc, .L1321
nop
ba %icc, .L1388
nop
.L1321:
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
be %icc, .L1331
nop
ba %icc, .L1336
nop
.L1331:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1341
nop
.L1336:
ba %icc, .L1341
nop
.L1341:
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
be %icc, .L1353
nop
ba %icc, .L1358
nop
.L1353:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1363
nop
.L1358:
ba %icc, .L1363
nop
.L1363:
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
be %icc, .L1375
nop
ba %icc, .L1380
nop
.L1375:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1390
nop
.L1380:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1390
nop
.L1390:
ba %icc, .L1393
nop
.L1388:
ba %icc, .L1393
nop
.L1393:
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
be %icc, .L1409
nop
ba %icc, .L1447
nop
.L1409:
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
ba %icc, .L1455
nop
.L1447:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1455
nop
.L1455:
	.size    inOrder, .-inOrder
	.align 4
	.global bintreesearch
.type    bintreesearch, #function
bintreesearch:
save %sp, -96, %sp
sethi %hi(-1), %l0
or %l0, %lo(-1), %l0
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
be %icc, .L1473
nop
ba %icc, .L1528
nop
.L1473:
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
be %icc, .L1483
nop
ba %icc, .L1488
nop
.L1483:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1493
nop
.L1488:
ba %icc, .L1493
nop
.L1493:
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
be %icc, .L1501
nop
ba %icc, .L1513
nop
.L1501:
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
ba %icc, .L1530
nop
.L1513:
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
ba %icc, .L1530
nop
.L1530:
ba %icc, .L1533
nop
.L1528:
ba %icc, .L1533
nop
.L1533:
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
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(0), %l2
or %l2, %lo(0), %l2
.L1551:
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
be %icc, .L1560
nop
ba %icc, .L1596
nop
.L1560:
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
ba %icc, .L1551
nop
.L1596:
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l2
or %l2, %lo(-999), %l2
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
sethi %hi(-999), %l2
or %l2, %lo(-999), %l2
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(-2), %l0
or %l0, %lo(-2), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(-2), %l0
or %l0, %lo(-2), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
be %icc, .L1847
nop
ba %icc, .L1852
nop
.L1847:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1857
nop
.L1852:
ba %icc, .L1857
nop
.L1857:
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
sethi %hi(0), %l3
or %l3, %lo(0), %l3
.L1888:
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
be %icc, .L1894
nop
ba %icc, .L1953
nop
.L1894:
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
ba %icc, .L1888
nop
.L1953:
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

