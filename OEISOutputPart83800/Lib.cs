using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A104479
{
public static readonly long[] Value={ 3L,4L,9L,12L,14L,16L,18L,20L,26L,29L,40L,41L,48L,58L,70L,73L,81L,87L,92L,96L,104L,111L,113L,114L,118L,122L,130L,140L,142L,144L,146L,150L,157L,162L,164L,167L,168L,172L,173L,184L,187L,192L,194L,195L,199L,200L,202L,208L,220L,230L,232L,244L,253L,256L,266L,278L,292L,295L,298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104479Inst : IEnumerable<long>
{
public static readonly long[] Value=A104479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104479.Bytes);
public long this[int i]=>Value[i];

public static A104479Inst Instance=new A104479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104480
{
public static readonly long[] Value={ 1L,7L,17L,21L,25L,34L,68L,97L,119L,127L,133L,136L,152L,175L,189L,238L,266L,275L,323L,337L,343L,357L,378L,381L,391L,399L,425L,437L,475L,476L,505L,525L,532L,544L,577L,608L,621L,625L,646L,647L,679L,707L,714L,749L,755L,756L,782L,798L,850L,864L,874L,889L,950L,952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104480Inst : IEnumerable<long>
{
public static readonly long[] Value=A104480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104480.Bytes);
public long this[int i]=>Value[i];

public static A104480Inst Instance=new A104480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104481
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,2L,3L,2L,4L,3L,4L,4L,3L,5L,6L,4L,5L,5L,6L,6L,6L,5L,8L,7L,6L,7L,8L,7L,7L,9L,8L,9L,8L,9L,8L,8L,11L,10L,11L,10L,8L,11L,10L,12L,9L,12L,14L,9L,10L,14L,15L,11L,12L,10L,11L,16L,12L,15L,15L,12L,16L,14L,13L,15L,14L,14L,16L,12L,20L,14L,14L,16L,16L,17L,21L,13L,17L,22L,12L,19L,18L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104481Inst : IEnumerable<long>
{
public static readonly long[] Value=A104481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104481.Bytes);
public long this[int i]=>Value[i];

public static A104481Inst Instance=new A104481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104482
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,2L,1L,3L,2L,2L,2L,4L,3L,3L,4L,1L,2L,5L,4L,3L,4L,2L,2L,4L,2L,3L,4L,2L,3L,6L,4L,4L,2L,3L,5L,3L,5L,5L,3L,3L,4L,6L,4L,4L,3L,2L,3L,2L,1L,6L,2L,7L,2L,2L,4L,4L,3L,6L,2L,3L,2L,4L,4L,5L,4L,6L,3L,5L,5L,6L,4L,6L,5L,5L,10L,4L,3L,5L,5L,3L,7L,3L,2L,9L,5L,7L,5L,8L,5L,6L,4L,5L,5L,5L,6L,5L,2L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104482Inst : IEnumerable<long>
{
public static readonly long[] Value=A104482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104482.Bytes);
public long this[int i]=>Value[i];

public static A104482Inst Instance=new A104482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104483
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,3L,3L,2L,2L,2L,3L,3L,4L,4L,3L,4L,3L,3L,4L,5L,4L,4L,4L,4L,4L,5L,3L,4L,2L,4L,4L,5L,4L,4L,4L,8L,2L,2L,2L,3L,5L,4L,6L,6L,1L,5L,3L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104483Inst : IEnumerable<long>
{
public static readonly long[] Value=A104483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104483.Bytes);
public long this[int i]=>Value[i];

public static A104483Inst Instance=new A104483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104484
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,4L,2L,2L,3L,1L,3L,4L,3L,2L,4L,3L,3L,2L,4L,3L,3L,2L,3L,4L,6L,2L,2L,3L,3L,4L,4L,1L,3L,3L,6L,6L,3L,2L,3L,5L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104484Inst : IEnumerable<long>
{
public static readonly long[] Value=A104484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104484.Bytes);
public long this[int i]=>Value[i];

public static A104484Inst Instance=new A104484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104485
{
public static readonly long[] Value={ 19L,31L,47L,83L,109L,113L,127L,199L,251L,257L,293L,353L,401L,443L,467L,479L,487L,491L,499L,503L,557L,571L,577L,647L,677L,743L,761L,787L,829L,863L,911L,937L,941L,947L,971L,977L,983L,1109L,1187L,1193L,1291L,1327L,1361L,1381L,1399L,1459L,1499L,1553L,1559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104485Inst : IEnumerable<long>
{
public static readonly long[] Value=A104485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104485.Bytes);
public long this[int i]=>Value[i];

public static A104485Inst Instance=new A104485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104486
{
public static readonly long[] Value={ 10L,1003L,10001L,100001L,1000001L,10000001L,100000001L,1000000006L,10000000003L,100000000007L,1000000000007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104486Inst : IEnumerable<long>
{
public static readonly long[] Value=A104486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104486.Bytes);
public long this[int i]=>Value[i];

public static A104486Inst Instance=new A104486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104487
{
public static readonly long[] Value={ 1L,4L,14L,47L,154L,496L,1577L,4964L,15502L,48103L,148490L,456416L,1397905L,4268740L,13002638L,39522143L,119912698L,363262672L,1099015481L,3321204260L,10026858766L,30246156439L,91171963754L,274650794432L,826923598369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104487Inst : IEnumerable<long>
{
public static readonly long[] Value=A104487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104487.Bytes);
public long this[int i]=>Value[i];

public static A104487Inst Instance=new A104487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104488
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104488Inst : IEnumerable<long>
{
public static readonly long[] Value=A104488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104488.Bytes);
public long this[int i]=>Value[i];

public static A104488Inst Instance=new A104488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104489
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,5L,3L,1L,9L,9L,11L,1L,5L,5L,3L,1L,17L,17L,19L,17L,5L,5L,3L,1L,9L,9L,11L,1L,5L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104489Inst : IEnumerable<long>
{
public static readonly long[] Value=A104489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104489.Bytes);
public long this[int i]=>Value[i];

public static A104489Inst Instance=new A104489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104490
{
public static readonly long[] Value={ 1L,1L,11L,1L,101L,101L,11L,1L,1001L,1001L,1011L,1L,101L,101L,11L,1L,10001L,10001L,10011L,10001L,101L,101L,11L,1L,1001L,1001L,1011L,1L,101L,101L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104490Inst : IEnumerable<long>
{
public static readonly long[] Value=A104490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104490.Bytes);
public long this[int i]=>Value[i];

public static A104490Inst Instance=new A104490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104491
{
public static readonly long[] Value={ 2L,5L,13L,19L,23L,37L,67L,71L,83L,107L,109L,113L,139L,157L,173L,199L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104491Inst : IEnumerable<long>
{
public static readonly long[] Value=A104491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104491.Bytes);
public long this[int i]=>Value[i];

public static A104491Inst Instance=new A104491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104492
{
public static readonly long[] Value={ 1L,2L,4L,6L,3L,5L,9L,11L,15L,2L,4L,10L,14L,16L,20L,26L,32L,34L,3L,7L,9L,15L,19L,25L,33L,37L,39L,43L,45L,49L,2L,6L,12L,14L,24L,26L,32L,38L,42L,48L,54L,56L,66L,68L,72L,74L,86L,7L,11L,13L,17L,23L,25L,35L,41L,47L,53L,55L,61L,65L,67L,77L,91L,95L,97L,101L,115L,121L,4L,6L,10L,16L,24L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104492Inst : IEnumerable<long>
{
public static readonly long[] Value=A104492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104492.Bytes);
public long this[int i]=>Value[i];

public static A104492Inst Instance=new A104492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104493
{
public static readonly long[] Value={ 2L,5L,6L,8L,10L,19L,20L,23L,26L,28L,31L,48L,49L,50L,51L,52L,55L,56L,57L,59L,61L,65L,66L,99L,100L,105L,110L,112L,114L,117L,121L,125L,127L,170L,171L,173L,178L,184L,185L,186L,190L,192L,194L,196L,200L,201L,206L,208L,214L,270L,271L,272L,274L,277L,278L,279L,280L,282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104493Inst : IEnumerable<long>
{
public static readonly long[] Value=A104493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104493.Bytes);
public long this[int i]=>Value[i];

public static A104493Inst Instance=new A104493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104494
{
public static readonly long[] Value={ 2L,58L,66L,166L,268L,270L,408L,600L,672L,808L,822L,970L,1050L,1090L,1150L,1200L,1212L,1380L,1578L,1752L,1912L,1950L,1986L,2016L,2038L,2292L,2340L,2548L,2590L,2656L,2718L,2800L,2856L,3162L,3300L,3342L,3738L,4138L,4152L,4228L,4270L,4272L,4362L,4782L,5080L,5166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104494Inst : IEnumerable<long>
{
public static readonly long[] Value=A104494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104494.Bytes);
public long this[int i]=>Value[i];

public static A104494Inst Instance=new A104494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104495
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-2L,1L,-1L,3L,-4L,1L,1L,-4L,12L,-5L,1L,-1L,5L,-34L,17L,-7L,1L,1L,-6L,98L,-51L,32L,-8L,1L,-1L,7L,-294L,149L,-124L,40L,-10L,1L,1L,-8L,919L,-443L,448L,-164L,61L,-11L,1L,-1L,9L,-2974L,1362L,-1576L,612L,-298L,72L,-13L,1L,1L,-10L,9891L,-4336L,5510L,-2188L,1294L,-370L,99L,-14L,1L,-1L,11L,-33604L,14227L,-19322L,7698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104495Inst : IEnumerable<long>
{
public static readonly long[] Value=A104495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104495.Bytes);
public long this[int i]=>Value[i];

public static A104495Inst Instance=new A104495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104496
{
public static readonly long[] Value={ 1L,0L,0L,-1L,5L,-19L,67L,-232L,804L,-2806L,9878L,-35072L,125512L,-452388L,1641028L,-5986993L,21954973L,-80884423L,299233543L,-1111219333L,4140813373L,-15478839553L,58028869153L,-218123355523L,821908275547L,-3104046382351L,11747506651599L,-44546351423299L,169227201341651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104496Inst : IEnumerable<long>
{
public static readonly long[] Value=A104496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104496.Bytes);
public long this[int i]=>Value[i];

public static A104496Inst Instance=new A104496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104497
{
public static readonly long[] Value={ 1L,-2L,-10L,-52L,-282L,-1596L,-9412L,-57640L,-364922L,-2376812L,-15852204L,-107821656L,-745342500L,-5221954776L,-36997822536L,-264620356944L,-1907962439994L,-13852652486220L,-101186612941084L,-743057485099384L,-5482375128919820L,-40620301416309128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104497Inst : IEnumerable<long>
{
public static readonly long[] Value=A104497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104497.Bytes);
public long this[int i]=>Value[i];

public static A104497Inst Instance=new A104497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104498
{
public static readonly long[] Value={ 0L,1L,5L,26L,141L,798L,4706L,28820L,182461L,1188406L,7926102L,53910828L,372671250L,2610977388L,18498911268L,132310178472L,953981219997L,6926326243110L,50593306470542L,371528742549692L,2741187564459910L,20310150708154564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104498Inst : IEnumerable<long>
{
public static readonly long[] Value=A104498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104498.Bytes);
public long this[int i]=>Value[i];

public static A104498Inst Instance=new A104498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104499
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,11L,15L,17L,19L,23L,25L,31L,41L,47L,59L,61L,71L,113L,127L,137L,157L,167L,223L,401L,443L,457L,503L,523L,619L,701L,859L,991L,1021L,1187L,1217L,1223L,1361L,1847L,1867L,2237L,2579L,2693L,3313L,4219L,4931L,4967L,5413L,7727L,8011L,8389L,8761L,13781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104499Inst : IEnumerable<long>
{
public static readonly long[] Value=A104499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104499.Bytes);
public long this[int i]=>Value[i];

public static A104499Inst Instance=new A104499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104500
{
public static readonly long[] Value={ 1L,4L,11L,35L,98L,294L,832L,2401L,6774L,19137L,53466L,148994L,412233L,1136383L,3116654L,8515706L,23172455L,62836916L,169801824L,457406173L,1228382159L,3289493887L,8784935160L,23400668297L,62179339101L,164832960183L,435978612329L,1150673925933L,3030701471118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104500Inst : IEnumerable<long>
{
public static readonly long[] Value=A104500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104500.Bytes);
public long this[int i]=>Value[i];

public static A104500Inst Instance=new A104500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104501
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,22L,30L,42L,56L,76L,100L,133L,172L,225L,288L,371L,470L,598L,751L,945L,1177L,1468L,1815L,2245L,2757L,3386L,4133L,5043L,6121L,7425L,8966L,10818L,13001L,15610L,18677L,22324L,26600L,31662L,37582L,44560L,52701L,62261L,73387L,86406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104501Inst : IEnumerable<long>
{
public static readonly long[] Value=A104501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104501.Bytes);
public long this[int i]=>Value[i];

public static A104501Inst Instance=new A104501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104502
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,22L,29L,41L,54L,74L,96L,128L,165L,216L,275L,354L,447L,569L,712L,896L,1113L,1388L,1712L,2117L,2595L,3186L,3882L,4735L,5739L,6959L,8392L,10121L,12150L,14582L,17429L,20823L,24789L,29494L,34979L,41456L,48993L,57856L,68148L,80204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104502Inst : IEnumerable<long>
{
public static readonly long[] Value=A104502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104502.Bytes);
public long this[int i]=>Value[i];

public static A104502Inst Instance=new A104502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104503
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,10L,14L,20L,27L,37L,49L,66L,86L,113L,146L,189L,241L,308L,389L,492L,615L,770L,956L,1187L,1463L,1802L,2207L,2701L,3288L,3999L,4842L,5857L,7056L,8491L,10183L,12197L,14564L,17369L,20658L,24539L,29075L,34408L,40627L,47912L,56385L,66277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104503Inst : IEnumerable<long>
{
public static readonly long[] Value=A104503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104503.Bytes);
public long this[int i]=>Value[i];

public static A104503Inst Instance=new A104503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104504
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,8L,10L,15L,19L,27L,34L,47L,59L,79L,99L,130L,162L,209L,259L,330L,407L,512L,628L,782L,955L,1179L,1432L,1755L,2122L,2583L,3109L,3762L,4510L,5427L,6480L,7760L,9231L,11004L,13043L,15485L,18293L,21634L,25475L,30021L,35245L,41396L,48459L,56740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104504Inst : IEnumerable<long>
{
public static readonly long[] Value=A104504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104504.Bytes);
public long this[int i]=>Value[i];

public static A104504Inst Instance=new A104504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104505
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,-2L,1L,-5L,0L,3L,-1L,-5L,8L,2L,-4L,1L,11L,15L,-10L,-5L,5L,-1L,41L,-6L,-30L,10L,9L,-6L,1L,29L,-77L,-14L,49L,-7L,-14L,7L,-1L,-125L,-120L,112L,56L,-70L,0L,20L,-8L,1L,-365L,117L,288L,-126L,-126L,90L,12L,-27L,9L,-1L,-131L,770L,45L,-540L,90L,228L,-105L,-30L,35L,-10L,1L,1409L,946L,-1265L,-495L,858L,33L,-363L,110L,55L,-44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104505Inst : IEnumerable<long>
{
public static readonly long[] Value=A104505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104505.Bytes);
public long this[int i]=>Value[i];

public static A104505Inst Instance=new A104505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104506
{
public static readonly long[] Value={ 0L,-1L,-2L,0L,8L,15L,-6L,-77L,-120L,117L,770L,946L,-1728L,-7735L,-6930L,22800L,76960L,42245L,-282150L,-751640L,-125800L,3341205L,7145710L,-2002725L,-38228232L,-65418925L,55550014L,424605078L,566938400L,-936604097L,-4587287310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104506Inst : IEnumerable<long>
{
public static readonly long[] Value=A104506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104506.Bytes);
public long this[int i]=>Value[i];

public static A104506Inst Instance=new A104506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104507
{
public static readonly long[] Value={ 1L,0L,-2L,-3L,2L,15L,19L,-28L,-134L,-129L,353L,1254L,791L,-4238L,-11818L,-3123L,49162L,110007L,-17783L,-554458L,-996323L,690932L,6096792L,8624747L,-12287153L,-65419110L,-69285296L,178655307L,684550946L,483569751L,-2354830741L,-6970706252L,-2324044054L,29195280375L,68793790705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104507Inst : IEnumerable<long>
{
public static readonly long[] Value=A104507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104507.Bytes);
public long this[int i]=>Value[i];

public static A104507Inst Instance=new A104507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104508
{
public static readonly long[] Value={ 1L,2L,4L,9L,20L,47L,103L,198L,512L,1161L,1985L,5590L,13005L,21684L,59294L,142273L,270858L,634187L,1526399L,3256372L,6779657L,16020364L,37758202L,79702477L,164647757L,424655100L,940639154L,1709638551L,4675803604L,10774789429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104508Inst : IEnumerable<long>
{
public static readonly long[] Value=A104508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104508.Bytes);
public long this[int i]=>Value[i];

public static A104508Inst Instance=new A104508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104509
{
public static readonly long[] Value={ 1L,1L,-1L,3L,-2L,1L,4L,-6L,3L,-1L,7L,-12L,10L,-4L,1L,11L,-25L,25L,-15L,5L,-1L,18L,-48L,60L,-44L,21L,-6L,1L,29L,-91L,133L,-119L,70L,-28L,7L,-1L,47L,-168L,284L,-296L,210L,-104L,36L,-8L,1L,76L,-306L,585L,-699L,576L,-342L,147L,-45L,9L,-1L,123L,-550L,1175L,-1580L,1485L,-1022L,525L,-200L,55L,-10L,1L,199L,-979L,2310L,-3454L,3641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104509Inst : IEnumerable<long>
{
public static readonly long[] Value=A104509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104509.Bytes);
public long this[int i]=>Value[i];

public static A104509Inst Instance=new A104509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104510
{
public static readonly long[] Value={ 0L,-1L,2L,-4L,4L,-7L,4L,-5L,0L,5L,-18L,23L,-46L,65L,-82L,108L,-132L,152L,-164L,168L,-144L,132L,-48L,-39L,212L,-365L,658L,-947L,1382L,-1800L,2394L,-2947L,3644L,-4289L,5102L,-5687L,6392L,-6820L,7112L,-7139L,6776L,-5836L,4338L,-2036L,-1342L,5585L,-11392L,18513L,-27456L,37876L,-51072L,65488L,-82982L,101898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104510Inst : IEnumerable<long>
{
public static readonly long[] Value=A104510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104510.Bytes);
public long this[int i]=>Value[i];

public static A104510Inst Instance=new A104510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104511
{
public static readonly long[] Value={ 6L,28L,496L,128L,336L,56L,328L,128L,176L,216L,128L,128L,976L,128L,328L,528L,776L,56L,536L,528L,216L,576L,336L,656L,376L,816L,456L,528L,528L,16L,128L,328L,936L,128L,616L,976L,856L,736L,56L,128L,528L,128L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104511Inst : IEnumerable<long>
{
public static readonly long[] Value=A104511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104511.Bytes);
public long this[int i]=>Value[i];

public static A104511Inst Instance=new A104511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104512
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,3L,0L,2L,1L,5L,3L,6L,2L,1L,0L,8L,3L,9L,2L,1L,4L,11L,7L,3L,5L,2L,1L,14L,4L,15L,0L,3L,7L,2L,1L,18L,8L,4L,6L,20L,3L,21L,2L,1L,10L,23L,15L,4L,8L,6L,3L,26L,2L,1L,5L,7L,13L,29L,4L,30L,14L,3L,0L,2L,1L,33L,5L,9L,7L,35L,4L,36L,17L,3L,6L,2L,1L,39L,14L,5L,19L,41L,7L,4L,20L,12L,3L,44L,2L,1L,8L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104512Inst : IEnumerable<long>
{
public static readonly long[] Value=A104512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104512.Bytes);
public long this[int i]=>Value[i];

public static A104512Inst Instance=new A104512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104513
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,3L,2L,0L,3L,4L,2L,3L,2L,4L,5L,0L,2L,4L,2L,5L,6L,4L,2L,3L,5L,4L,6L,7L,2L,5L,2L,0L,6L,4L,7L,8L,2L,4L,6L,5L,2L,7L,2L,8L,9L,4L,2L,3L,7L,5L,6L,8L,2L,9L,10L,7L,6L,4L,2L,8L,2L,4L,9L,0L,10L,11L,2L,8L,6L,7L,2L,9L,2L,4L,10L,8L,11L,12L,2L,5L,9L,4L,2L,8L,10L,4L,6L,11L,2L,12L,13L,8L,6L,4L,10L,3L,2L,7L,11L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104513Inst : IEnumerable<long>
{
public static readonly long[] Value=A104513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104513.Bytes);
public long this[int i]=>Value[i];

public static A104513Inst Instance=new A104513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104514
{
public static readonly long[] Value={ 0L,0L,3L,0L,4L,3L,4L,0L,3L,5L,4L,3L,4L,7L,3L,0L,4L,3L,4L,5L,3L,8L,4L,3L,4L,8L,3L,7L,4L,3L,4L,0L,3L,8L,4L,3L,4L,8L,3L,5L,4L,3L,4L,11L,3L,8L,4L,3L,4L,5L,3L,13L,4L,3L,4L,7L,3L,8L,4L,3L,4L,8L,3L,0L,4L,3L,4L,16L,3L,5L,4L,3L,4L,8L,3L,16L,4L,3L,4L,5L,3L,8L,4L,3L,4L,8L,3L,11L,4L,3L,4L,16L,3L,8L,4L,3L,4L,7L,3L,5L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104514Inst : IEnumerable<long>
{
public static readonly long[] Value=A104514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104514.Bytes);
public long this[int i]=>Value[i];

public static A104514Inst Instance=new A104514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104515
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,3L,0L,0L,1L,0L,0L,4L,0L,0L,0L,3L,0L,4L,0L,0L,2L,0L,0L,4L,0L,5L,5L,0L,0L,4L,0L,0L,4L,0L,0L,7L,0L,0L,0L,5L,1L,4L,0L,0L,6L,8L,0L,4L,0L,0L,5L,0L,0L,7L,0L,8L,8L,0L,0L,4L,3L,0L,6L,0L,0L,8L,0L,9L,9L,0L,0L,7L,0L,0L,5L,8L,0L,4L,0L,0L,9L,11L,0L,4L,0L,8L,0L,0L,3L,9L,3L,0L,9L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104515Inst : IEnumerable<long>
{
public static readonly long[] Value=A104515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104515.Bytes);
public long this[int i]=>Value[i];

public static A104515Inst Instance=new A104515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104516
{
public static readonly long[] Value={ 1L,9L,30L,15L,21L,35L,54L,45L,55L,77L,156L,91L,105L,135L,204L,153L,171L,209L,252L,231L,253L,299L,450L,325L,351L,405L,522L,435L,465L,527L,594L,561L,595L,665L,888L,703L,741L,819L,984L,861L,903L,989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104516Inst : IEnumerable<long>
{
public static readonly long[] Value=A104516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104516.Bytes);
public long this[int i]=>Value[i];

public static A104516Inst Instance=new A104516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104517
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,2L,3L,2L,5L,4L,1L,1L,3L,2L,5L,3L,4L,2L,4L,5L,4L,5L,3L,2L,3L,3L,3L,5L,3L,4L,6L,4L,4L,2L,4L,4L,3L,3L,5L,2L,2L,3L,2L,3L,7L,4L,3L,2L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104517Inst : IEnumerable<long>
{
public static readonly long[] Value=A104517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104517.Bytes);
public long this[int i]=>Value[i];

public static A104517Inst Instance=new A104517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104518
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,1L,3L,2L,2L,3L,4L,3L,3L,4L,2L,2L,4L,3L,3L,5L,2L,2L,6L,1L,3L,4L,5L,7L,4L,4L,3L,6L,4L,4L,7L,5L,6L,4L,3L,3L,5L,2L,4L,6L,4L,5L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104518Inst : IEnumerable<long>
{
public static readonly long[] Value=A104518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104518.Bytes);
public long this[int i]=>Value[i];

public static A104518Inst Instance=new A104518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104519
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,10L,12L,16L,20L,24L,29L,35L,40L,47L,53L,60L,68L,76L,84L,92L,101L,111L,121L,131L,141L,152L,164L,176L,188L,200L,213L,227L,241L,255L,269L,284L,300L,316L,332L,348L,365L,383L,401L,419L,437L,456L,476L,496L,516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104519Inst : IEnumerable<long>
{
public static readonly long[] Value=A104519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104519.Bytes);
public long this[int i]=>Value[i];

public static A104519Inst Instance=new A104519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104520
{
public static readonly long[] Value={ 10L,115L,111L,1111L,11111L,1111114L,1111111L,110111111L,1111111141L,11101111111L,11111111111L,1111111111101L,10111111111111L,111111011111111L,1111111111101111L,10111111111111111L,11111111111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104520Inst : IEnumerable<long>
{
public static readonly long[] Value=A104520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104520.Bytes);
public long this[int i]=>Value[i];

public static A104520Inst Instance=new A104520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104521
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104521Inst : IEnumerable<long>
{
public static readonly long[] Value=A104521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104521.Bytes);
public long this[int i]=>Value[i];

public static A104521Inst Instance=new A104521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104522
{
public static readonly long[] Value={ 1L,3L,7L,19L,53L,155L,459L,1371L,4105L,12307L,36911L,110723L,332157L,996459L,2989363L,8968075L,26904209L,80712611L,242137815L,726413427L,2179240261L,6537720763L,19613162267L,58839486779L,176518460313L,529555380915L,1588666142719L,4765998428131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104522Inst : IEnumerable<long>
{
public static readonly long[] Value=A104522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104522.Bytes);
public long this[int i]=>Value[i];

public static A104522Inst Instance=new A104522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104523
{
public static readonly long[] Value={ 6L,9L,10L,12L,14L,15L,16L,17L,19L,20L,22L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,53L,54L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104523Inst : IEnumerable<long>
{
public static readonly long[] Value=A104523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104523.Bytes);
public long this[int i]=>Value[i];

public static A104523Inst Instance=new A104523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104524
{
public static readonly long[] Value={ 2L,1L,1L,2L,1L,3L,3L,3L,1L,3L,2L,5L,3L,1L,4L,3L,3L,3L,4L,2L,1L,2L,7L,4L,4L,4L,4L,5L,4L,4L,3L,2L,3L,5L,3L,4L,3L,7L,2L,4L,2L,4L,4L,8L,2L,4L,3L,6L,3L,2L,4L,7L,7L,7L,5L,5L,6L,7L,2L,4L,6L,3L,5L,5L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104524Inst : IEnumerable<long>
{
public static readonly long[] Value=A104524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104524.Bytes);
public long this[int i]=>Value[i];

public static A104524Inst Instance=new A104524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104525
{
public static readonly long[] Value={ 1L,4L,12L,40L,123L,395L,1227L,3851L,11944L,37032L,114144L,351040L,1075316L,3285398L,10007731L,30409157L,92169561L,278738219L,841132013L,2533138770L,7614144053L,22845435104L,68427663680L,204623945617L,610951554377L,1821438443615L,5422608839874L,16121857331124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104525Inst : IEnumerable<long>
{
public static readonly long[] Value=A104525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104525.Bytes);
public long this[int i]=>Value[i];

public static A104525Inst Instance=new A104525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104526
{
public static readonly long[] Value={ 1L,4L,35L,257L,11L,271L,183L,2773L,36329L,109897L,110443L,27757L,55709L,37291L,49873L,1549703L,13975537L,14010257L,2806565L,2811401L,5631265L,9400487L,103518197L,103642321L,103738417L,311569891L,311818139L,312084119L,312296903L,312607213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104526Inst : IEnumerable<long>
{
public static readonly long[] Value=A104526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104526.Bytes);
public long this[int i]=>Value[i];

public static A104526Inst Instance=new A104526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104527
{
public static readonly long[] Value={ 1L,3L,24L,168L,7L,168L,112L,1680L,21840L,65520L,65520L,16380L,32760L,21840L,29120L,902720L,8124480L,8124480L,1624896L,1624896L,3249792L,5416320L,59579520L,59579520L,59579520L,178738560L,178738560L,178738560L,178738560L,178738560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104527Inst : IEnumerable<long>
{
public static readonly long[] Value=A104527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104527.Bytes);
public long this[int i]=>Value[i];

public static A104527Inst Instance=new A104527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104528
{
public static readonly long[] Value={ 1L,3L,2L,7L,17L,37L,43L,23L,25L,53L,59L,61L,67L,35L,73L,377L,407L,139L,149L,457L,118L,487L,517L,1049L,363L,373L,383L,1169L,1229L,311L,163L,331L,677L,173L,707L,2141L,2231L,569L,2321L,4687L,4867L,614L,1273L,644L,1303L,2651L,2741L,2759L,2819L,2849L,1447L,731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104528Inst : IEnumerable<long>
{
public static readonly long[] Value=A104528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104528.Bytes);
public long this[int i]=>Value[i];

public static A104528Inst Instance=new A104528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104529
{
public static readonly long[] Value={ 1L,2L,1L,3L,6L,12L,12L,6L,6L,12L,12L,12L,12L,6L,12L,60L,60L,20L,20L,60L,15L,60L,60L,120L,40L,40L,40L,120L,120L,30L,15L,30L,60L,15L,60L,180L,180L,45L,180L,360L,360L,45L,90L,45L,90L,180L,180L,180L,180L,180L,90L,45L,90L,360L,360L,45L,180L,90L,45L,180L,180L,90L,45L,315L,1260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104529Inst : IEnumerable<long>
{
public static readonly long[] Value=A104529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104529.Bytes);
public long this[int i]=>Value[i];

public static A104529Inst Instance=new A104529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104530
{
public static readonly long[] Value={ 1L,3L,15L,78L,411L,2178L,11574L,61596L,328083L,1748346L,9319650L,49688004L,264943902L,1412826132L,7534329804L,40180417848L,214285867011L,1142822599722L,6094924220394L,32505784870068L,173362418710506L,924593002335612L,4931138212856244L,26299312319336328L,140262655976846766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104530Inst : IEnumerable<long>
{
public static readonly long[] Value=A104530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104530.Bytes);
public long this[int i]=>Value[i];

public static A104530Inst Instance=new A104530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104531
{
public static readonly long[] Value={ 1L,4L,24L,148L,920L,5736L,35808L,223668L,1397496L,8732920L,54575888L,341082504L,2131706864L,13322959888L,83267756400L,520420803060L,3252620324280L,20328841669080L,127055130786960L,794094089779800L,4963086293860560L,31019282772508080L,193870492861908480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104531Inst : IEnumerable<long>
{
public static readonly long[] Value=A104531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104531.Bytes);
public long this[int i]=>Value[i];

public static A104531Inst Instance=new A104531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104532
{
public static readonly long[] Value={ 1L,5L,35L,250L,1795L,12910L,92910L,668820L,4815075L,34667110L,249598330L,1797091180L,12938997710L,93160575500L,670755400700L,4829436210600L,34771931021475L,250357867996950L,1802576519933250L,12978550465880700L,93445561587077850L,672808036862840100L,4844217840946181700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104532Inst : IEnumerable<long>
{
public static readonly long[] Value=A104532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104532.Bytes);
public long this[int i]=>Value[i];

public static A104532Inst Instance=new A104532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104533
{
public static readonly BigInteger[] Value={ 1L,2L,12L,104L,1168L,16032L,259264L,4817024L,100954368L,2353435136L,60355677184L,1687701792768L,51077784506368L,1662782678736896L,57917727119818752L,2148722382829027328L,BigInteger.Parse("84569896954751942656"),BigInteger.Parse("3518839711497761980416"),BigInteger.Parse("154306731918073225019392") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104533Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104533.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104533Inst Instance=new A104533Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104534
{
public static readonly long[] Value={ 3L,7L,11L,12L,36L,56L,401L,2707L,8417L,14096L,31561L,50696L,53192L,155182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104534Inst : IEnumerable<long>
{
public static readonly long[] Value=A104534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104534.Bytes);
public long this[int i]=>Value[i];

public static A104534Inst Instance=new A104534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104535
{
public static readonly long[] Value={ 2L,29L,401L,773L,5350220959L,2682493808945359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104535Inst : IEnumerable<long>
{
public static readonly long[] Value=A104535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104535.Bytes);
public long this[int i]=>Value[i];

public static A104535Inst Instance=new A104535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104536
{
public static readonly BigInteger[] Value={ 17L,3486013L,BigInteger.Parse("95546861187714408803829067490017"),BigInteger.Parse("11521371769146027198878540116068812681880419688486700618357345699743923465881941319972521176540806894433040020358370202464446915550483588097961647367908157261449080390753803350619037518472005174420394730557755077744685894370803149416209738934082646247291") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104536Inst Instance=new A104536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104537
{
public static readonly long[] Value={ 1L,-1L,-2L,8L,-8L,-16L,64L,-64L,-128L,512L,-512L,-1024L,4096L,-4096L,-8192L,32768L,-32768L,-65536L,262144L,-262144L,-524288L,2097152L,-2097152L,-4194304L,16777216L,-16777216L,-33554432L,134217728L,-134217728L,-268435456L,1073741824L,-1073741824L,-2147483648L,8589934592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104537Inst : IEnumerable<long>
{
public static readonly long[] Value=A104537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104537.Bytes);
public long this[int i]=>Value[i];

public static A104537Inst Instance=new A104537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104538
{
public static readonly long[] Value={ 1L,0L,-4L,8L,0L,-32L,64L,0L,-256L,512L,0L,-2048L,4096L,0L,-16384L,32768L,0L,-131072L,262144L,0L,-1048576L,2097152L,0L,-8388608L,16777216L,0L,-67108864L,134217728L,0L,-536870912L,1073741824L,0L,-4294967296L,8589934592L,0L,-34359738368L,68719476736L,0L,-274877906944L,549755813888L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104538Inst : IEnumerable<long>
{
public static readonly long[] Value=A104538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104538.Bytes);
public long this[int i]=>Value[i];

public static A104538Inst Instance=new A104538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104539
{
public static readonly long[] Value={ 0L,9L,2L,3L,4L,5L,7L,3L,5L,2L,2L,8L,0L,4L,6L,6L,7L,0L,3L,8L,5L,7L,2L,8L,4L,8L,6L,1L,9L,2L,0L,6L,7L,8L,8L,6L,7L,7L,4L,1L,3L,2L,2L,1L,6L,6L,2L,8L,2L,4L,6L,5L,0L,9L,3L,9L,9L,6L,3L,2L,5L,9L,7L,9L,3L,3L,9L,8L,5L,3L,8L,9L,2L,0L,3L,1L,1L,6L,1L,1L,5L,4L,1L,1L,7L,2L,9L,4L,0L,2L,3L,4L,6L,2L,1L,0L,7L,4L,7L,6L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104539Inst : IEnumerable<long>
{
public static readonly long[] Value=A104539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104539.Bytes);
public long this[int i]=>Value[i];

public static A104539Inst Instance=new A104539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104540
{
public static readonly long[] Value={ 2L,0L,7L,6L,3L,8L,9L,2L,0L,5L,5L,4L,3L,2L,4L,8L,0L,3L,7L,9L,1L,4L,9L,2L,0L,4L,6L,6L,1L,7L,8L,0L,3L,2L,0L,6L,9L,8L,2L,6L,3L,6L,0L,7L,9L,1L,7L,9L,6L,0L,0L,7L,3L,0L,8L,5L,2L,4L,4L,8L,1L,2L,4L,4L,9L,0L,1L,5L,0L,8L,8L,5L,1L,7L,8L,5L,4L,8L,3L,6L,6L,0L,9L,6L,1L,0L,9L,5L,1L,7L,5L,0L,0L,0L,2L,1L,3L,7L,5L,7L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104540Inst : IEnumerable<long>
{
public static readonly long[] Value=A104540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104540.Bytes);
public long this[int i]=>Value[i];

public static A104540Inst Instance=new A104540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104541
{
public static readonly long[] Value={ 3L,6L,8L,7L,9L,0L,4L,7L,9L,4L,9L,2L,2L,4L,1L,6L,3L,8L,5L,9L,0L,5L,1L,1L,4L,8L,9L,6L,3L,7L,7L,5L,6L,0L,7L,2L,2L,6L,2L,1L,6L,6L,6L,9L,3L,9L,6L,0L,8L,5L,2L,8L,0L,4L,8L,2L,3L,1L,1L,8L,8L,5L,6L,8L,5L,0L,9L,4L,6L,2L,5L,3L,2L,2L,6L,5L,7L,7L,9L,0L,2L,6L,2L,9L,0L,3L,1L,5L,2L,8L,3L,9L,8L,6L,0L,1L,5L,5L,8L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104541Inst : IEnumerable<long>
{
public static readonly long[] Value=A104541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104541.Bytes);
public long this[int i]=>Value[i];

public static A104541Inst Instance=new A104541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104542
{
public static readonly long[] Value={ 5L,7L,5L,5L,4L,2L,7L,1L,4L,4L,6L,1L,1L,7L,7L,4L,5L,2L,4L,3L,1L,1L,0L,6L,4L,0L,5L,4L,9L,2L,8L,6L,3L,8L,3L,3L,5L,6L,7L,4L,5L,6L,6L,1L,5L,1L,7L,9L,7L,9L,9L,5L,3L,9L,5L,2L,9L,2L,4L,7L,5L,8L,1L,9L,3L,5L,9L,5L,4L,5L,2L,1L,3L,8L,3L,6L,2L,3L,6L,4L,0L,7L,8L,1L,9L,0L,1L,6L,3L,1L,0L,0L,5L,4L,8L,5L,8L,9L,4L,7L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104542Inst : IEnumerable<long>
{
public static readonly long[] Value=A104542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104542.Bytes);
public long this[int i]=>Value[i];

public static A104542Inst Instance=new A104542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104543
{
public static readonly long[] Value={ 1L,2L,3L,2L,2L,3L,1L,2L,4L,3L,1L,3L,3L,2L,4L,4L,1L,3L,3L,2L,4L,4L,4L,5L,1L,5L,4L,5L,4L,5L,1L,2L,4L,5L,5L,4L,2L,2L,3L,4L,3L,4L,4L,3L,5L,2L,5L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104543Inst : IEnumerable<long>
{
public static readonly long[] Value=A104543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104543.Bytes);
public long this[int i]=>Value[i];

public static A104543Inst Instance=new A104543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104544
{
public static readonly long[] Value={ 1L,1L,1L,3L,0L,1L,5L,3L,0L,1L,11L,6L,3L,0L,1L,25L,13L,9L,3L,0L,1L,55L,40L,16L,12L,3L,0L,1L,129L,95L,60L,20L,15L,3L,0L,1L,303L,250L,155L,80L,25L,18L,3L,0L,1L,721L,661L,415L,235L,100L,31L,21L,3L,0L,1L,1743L,1708L,1206L,620L,335L,120L,38L,24L,3L,0L,1L,4241L,4515L,3262L,1946L,875L,455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104544Inst : IEnumerable<long>
{
public static readonly long[] Value=A104544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104544.Bytes);
public long this[int i]=>Value[i];

public static A104544Inst Instance=new A104544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104545
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,11L,25L,55L,129L,303L,721L,1743L,4241L,10415L,25761L,64095L,160385L,403263L,1018369L,2581887L,6569089L,16767871L,42927105L,110194175L,283574017L,731427583L,1890600193L,4896499455L,12704869633L,33021750015L,85966113281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104545Inst : IEnumerable<long>
{
public static readonly long[] Value=A104545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104545.Bytes);
public long this[int i]=>Value[i];

public static A104545Inst Instance=new A104545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104546
{
public static readonly long[] Value={ 1L,2L,5L,1L,16L,6L,60L,29L,1L,245L,138L,11L,1051L,670L,84L,1L,4660L,3319L,562L,17L,21174L,16691L,3536L,184L,1L,98072L,84864L,21510L,1628L,24L,461330L,435048L,128134L,12860L,345L,1L,2197997L,2244532L,752486L,94534L,3865L,32L,10585173L,11639558L,4373658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104546Inst : IEnumerable<long>
{
public static readonly long[] Value=A104546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104546.Bytes);
public long this[int i]=>Value[i];

public static A104546Inst Instance=new A104546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104547
{
public static readonly long[] Value={ 1L,2L,5L,16L,60L,245L,1051L,4660L,21174L,98072L,461330L,2197997L,10585173L,51443379L,251982793L,1242734592L,6165798680L,30754144182L,154123971932L,775669589436L,3918703613376L,19866054609754L,101029857327802L,515275408644773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104547Inst : IEnumerable<long>
{
public static readonly long[] Value=A104547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104547.Bytes);
public long this[int i]=>Value[i];

public static A104547Inst Instance=new A104547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104548
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,3L,3L,0L,1L,6L,15L,15L,0L,1L,10L,45L,105L,105L,0L,1L,15L,105L,420L,945L,945L,0L,1L,21L,210L,1260L,4725L,10395L,10395L,0L,1L,28L,378L,3150L,17325L,62370L,135135L,135135L,0L,1L,36L,630L,6930L,51975L,270270L,945945L,2027025L,2027025L,0L,1L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104548Inst : IEnumerable<long>
{
public static readonly long[] Value=A104548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104548.Bytes);
public long this[int i]=>Value[i];

public static A104548Inst Instance=new A104548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104549
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,5L,14L,3L,14L,49L,26L,1L,42L,175L,154L,23L,132L,637L,786L,241L,10L,429L,2353L,3728L,1831L,215L,2L,1430L,8788L,16966L,11723L,2564L,115L,4862L,33098L,75249L,67669L,22866L,2319L,35L,16796L,125476L,328012L,364864L,171310L,29869L,1386L,5L,58786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104549Inst : IEnumerable<long>
{
public static readonly long[] Value=A104549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104549.Bytes);
public long this[int i]=>Value[i];

public static A104549Inst Instance=new A104549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104550
{
public static readonly long[] Value={ 1L,4L,20L,104L,552L,2972L,16172L,88720L,489872L,2719028L,15157188L,84799992L,475894200L,2677788492L,15102309468L,85347160608L,483183316512L,2739851422820L,15558315261812L,88462135512712L,503569008273992L,2869602773253884L,16368396446913420L,93449566652932784L,533954950648248752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104550Inst : IEnumerable<long>
{
public static readonly long[] Value=A104550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104550.Bytes);
public long this[int i]=>Value[i];

public static A104550Inst Instance=new A104550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104551
{
public static readonly long[] Value={ 0L,1L,1L,-1L,-1L,5L,5L,-15L,-15L,55L,55L,-197L,-197L,727L,727L,-2705L,-2705L,10165L,10165L,-38455L,-38455L,146301L,146301L,-559131L,-559131L,2145025L,2145025L,-8255575L,-8255575L,31861025L,31861025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104551Inst : IEnumerable<long>
{
public static readonly long[] Value=A104551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104551.Bytes);
public long this[int i]=>Value[i];

public static A104551Inst Instance=new A104551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104552
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,8L,9L,4L,1L,21L,35L,25L,8L,1L,55L,128L,128L,66L,16L,1L,144L,448L,591L,422L,168L,32L,1L,377L,1515L,2537L,2350L,1298L,416L,64L,1L,987L,4984L,10304L,11897L,8481L,3796L,1008L,128L,1L,2584L,16032L,40057L,56083L,49448L,28557L,10680L,2400L,256L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104552Inst : IEnumerable<long>
{
public static readonly long[] Value=A104552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104552.Bytes);
public long this[int i]=>Value[i];

public static A104552Inst Instance=new A104552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104553
{
public static readonly long[] Value={ 1L,7L,38L,198L,1039L,5533L,29852L,162716L,893997L,4942723L,27466082L,153264066L,858230875L,4820155001L,27141345912L,153168964216L,866086326425L,4905744855359L,27830459812830L,158102366711550L,899290473825511L,5120997554408597L,29191620055374228L,166560724629655188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104553Inst : IEnumerable<long>
{
public static readonly long[] Value=A104553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104553.Bytes);
public long this[int i]=>Value[i];

public static A104553Inst Instance=new A104553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104554
{
public static readonly long[] Value={ 0L,1L,0L,0L,-2L,-1L,-1L,3L,3L,4L,-3L,-6L,-11L,-1L,8L,24L,15L,-2L,-42L,-48L,-29L,53L,107L,117L,-18L,-179L,-306L,-153L,187L,620L,620L,93L,-960L,-1580L,-1146L,867L,3067L,3779L,899L,-4368L,-8859L,-6878L,2757L,16107L,21004L,8612L,-20845L,-46746L,-42966L,7336L,79983L,119169L,61531L,-91099L,-249454L,-253347L,-9618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104554Inst : IEnumerable<long>
{
public static readonly long[] Value=A104554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104554.Bytes);
public long this[int i]=>Value[i];

public static A104554Inst Instance=new A104554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104555
{
public static readonly long[] Value={ 0L,1L,2L,0L,-5L,-7L,0L,12L,15L,0L,-22L,-26L,0L,35L,40L,0L,-51L,-57L,0L,70L,77L,0L,-92L,-100L,0L,117L,126L,0L,-145L,-155L,0L,176L,187L,0L,-210L,-222L,0L,247L,260L,0L,-287L,-301L,0L,330L,345L,0L,-376L,-392L,0L,425L,442L,0L,-477L,-495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104555Inst : IEnumerable<long>
{
public static readonly long[] Value=A104555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104555.Bytes);
public long this[int i]=>Value[i];

public static A104555Inst Instance=new A104555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104556
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-3L,1L,0L,3L,-6L,1L,0L,0L,15L,-10L,1L,0L,0L,-15L,45L,-15L,1L,0L,0L,0L,-105L,105L,-21L,1L,0L,0L,0L,105L,-420L,210L,-28L,1L,0L,0L,0L,0L,945L,-1260L,378L,-36L,1L,0L,0L,0L,0L,-945L,4725L,-3150L,630L,-45L,1L,0L,0L,0L,0L,0L,-10395L,17325L,-6930L,990L,-55L,1L,0L,0L,0L,0L,0L,10395L,-62370L,51975L,-13860L,1485L,-66L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104556Inst : IEnumerable<long>
{
public static readonly long[] Value=A104556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104556.Bytes);
public long this[int i]=>Value[i];

public static A104556Inst Instance=new A104556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104557
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,6L,6L,4L,1L,24L,24L,18L,6L,1L,120L,120L,96L,36L,9L,1L,720L,720L,600L,240L,72L,12L,1L,5040L,5040L,4320L,1800L,600L,120L,16L,1L,40320L,40320L,35280L,15120L,5400L,1200L,200L,20L,1L,362880L,362880L,322560L,141120L,52920L,12600L,2400L,300L,25L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104557Inst : IEnumerable<long>
{
public static readonly long[] Value=A104557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104557.Bytes);
public long this[int i]=>Value[i];

public static A104557Inst Instance=new A104557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104558
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-2L,1L,0L,2L,-4L,1L,0L,0L,6L,-6L,1L,0L,0L,-6L,18L,-9L,1L,0L,0L,0L,-24L,36L,-12L,1L,0L,0L,0L,24L,-96L,72L,-16L,1L,0L,0L,0L,0L,120L,-240L,120L,-20L,1L,0L,0L,0L,0L,-120L,600L,-600L,200L,-25L,1L,0L,0L,0L,0L,0L,-720L,1800L,-1200L,300L,-30L,1L,0L,0L,0L,0L,0L,720L,-4320L,5400L,-2400L,450L,-36L,1L,0L,0L,0L,0L,0L,0L,5040L,-15120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104558Inst : IEnumerable<long>
{
public static readonly long[] Value=A104558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104558.Bytes);
public long this[int i]=>Value[i];

public static A104558Inst Instance=new A104558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104559
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,1L,1L,4L,9L,6L,1L,1L,5L,16L,18L,9L,1L,1L,6L,25L,40L,36L,12L,1L,1L,7L,36L,75L,100L,60L,16L,1L,1L,8L,49L,126L,225L,200L,100L,20L,1L,1L,9L,64L,196L,441L,525L,400L,150L,25L,1L,1L,10L,81L,288L,784L,1176L,1225L,700L,225L,30L,1L,1L,11L,100L,405L,1296L,2352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104559Inst : IEnumerable<long>
{
public static readonly long[] Value=A104559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104559.Bytes);
public long this[int i]=>Value[i];

public static A104559Inst Instance=new A104559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104560
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-2L,1L,-2L,5L,-4L,1L,6L,-16L,15L,-6L,1L,-30L,81L,-79L,36L,-9L,1L,204L,-552L,543L,-256L,72L,-12L,1L,-1944L,5262L,-5184L,2461L,-712L,132L,-16L,1L,23340L,-63180L,62260L,-29596L,8615L,-1640L,220L,-20L,1L,-360060L,974670L,-960520L,456700L,-133091L,25475L,-3500L,350L,-25L,1L,6692280L,-18115800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104560Inst : IEnumerable<long>
{
public static readonly long[] Value=A104560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104560.Bytes);
public long this[int i]=>Value[i];

public static A104560Inst Instance=new A104560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104561
{
public static readonly BigInteger[] Value={ 1L,-1L,1L,-2L,6L,-30L,204L,-1944L,23340L,-360060L,6692280L,-151908120L,4032593040L,-126425330640L,4537069829880L,-187762669281600L,8751745668796200L,-462088269954518760L,BigInteger.Parse("27132285729049971120"),BigInteger.Parse("-1779812144439507990000"),BigInteger.Parse("128512316060872730854560") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104561Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104561.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104561Inst Instance=new A104561Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104562
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-2L,1L,1L,1L,-3L,1L,-1L,2L,3L,-4L,1L,0L,-4L,2L,6L,-5L,1L,1L,2L,-9L,0L,10L,-6L,1L,-1L,3L,9L,-15L,-5L,15L,-7L,1L,0L,-6L,3L,24L,-20L,-14L,21L,-8L,1L,1L,3L,-18L,-6L,49L,-21L,-28L,28L,-9L,1L,-1L,4L,18L,-36L,-35L,84L,-14L,-48L,36L,-10L,1L,0L,-8L,4L,60L,-50L,-98L,126L,6L,-75L,45L,-11L,1L,1L,4L,-30L,-20L,145L,-36L,-210L,168L,45L,-110L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104562Inst : IEnumerable<long>
{
public static readonly long[] Value=A104562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104562.Bytes);
public long this[int i]=>Value[i];

public static A104562Inst Instance=new A104562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104563
{
public static readonly long[] Value={ 0L,1L,3L,5L,8L,13L,19L,25L,32L,41L,51L,61L,72L,85L,99L,113L,128L,145L,163L,181L,200L,221L,243L,265L,288L,313L,339L,365L,392L,421L,451L,481L,512L,545L,579L,613L,648L,685L,723L,761L,800L,841L,883L,925L,968L,1013L,1059L,1105L,1152L,1201L,1251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104563Inst : IEnumerable<long>
{
public static readonly long[] Value=A104563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104563.Bytes);
public long this[int i]=>Value[i];

public static A104563Inst Instance=new A104563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104564
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,2L,2L,2L,2L,3L,3L,1L,3L,4L,2L,2L,3L,2L,1L,4L,3L,1L,3L,3L,2L,3L,4L,2L,7L,1L,5L,6L,3L,3L,4L,3L,4L,5L,5L,3L,5L,4L,2L,3L,3L,6L,2L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104564Inst : IEnumerable<long>
{
public static readonly long[] Value=A104564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104564.Bytes);
public long this[int i]=>Value[i];

public static A104564Inst Instance=new A104564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104565
{
public static readonly long[] Value={ 1L,-2L,3L,-2L,-6L,28L,-61L,54L,158L,-860L,2062L,-2004L,-5804L,33720L,-84509L,86054L,247862L,-1492908L,3838298L,-4019452L,-11537556L,71101832L,-185868978L,198310460L,567902572L,-3555617432L,9404104764L,-10168382696L,-29069700056L,184127171952L,-491229517661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104565Inst : IEnumerable<long>
{
public static readonly long[] Value=A104565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104565.Bytes);
public long this[int i]=>Value[i];

public static A104565Inst Instance=new A104565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104566
{
public static readonly long[] Value={ 1L,3L,2L,4L,3L,1L,6L,5L,3L,2L,7L,6L,4L,3L,1L,9L,8L,6L,5L,3L,2L,10L,9L,7L,6L,4L,3L,1L,12L,11L,9L,8L,6L,5L,3L,2L,13L,12L,10L,9L,7L,6L,4L,3L,1L,15L,14L,12L,11L,9L,8L,6L,5L,3L,2L,16L,15L,13L,12L,10L,9L,7L,6L,4L,3L,1L,18L,17L,15L,14L,12L,11L,9L,8L,6L,5L,3L,2L,19L,18L,16L,15L,13L,12L,10L,9L,7L,6L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104566Inst : IEnumerable<long>
{
public static readonly long[] Value=A104566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104566.Bytes);
public long this[int i]=>Value[i];

public static A104566Inst Instance=new A104566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104567
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,1L,4L,6L,2L,2L,5L,8L,3L,4L,1L,6L,10L,4L,6L,2L,2L,7L,12L,5L,8L,3L,4L,1L,8L,14L,6L,10L,4L,6L,2L,2L,9L,16L,7L,12L,5L,8L,3L,4L,1L,10L,18L,8L,14L,6L,10L,4L,6L,2L,2L,11L,20L,9L,16L,7L,12L,5L,8L,3L,4L,1L,12L,22L,10L,18L,8L,14L,6L,10L,4L,6L,2L,2L,13L,24L,11L,20L,9L,16L,7L,12L,5L,8L,3L,4L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104567Inst : IEnumerable<long>
{
public static readonly long[] Value=A104567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104567.Bytes);
public long this[int i]=>Value[i];

public static A104567Inst Instance=new A104567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104568
{
public static readonly long[] Value={ 1L,3L,1L,4L,3L,1L,6L,4L,3L,1L,7L,6L,4L,3L,1L,9L,7L,6L,4L,3L,1L,10L,9L,7L,6L,4L,3L,1L,12L,10L,9L,7L,6L,4L,3L,1L,13L,12L,10L,9L,7L,6L,4L,3L,1L,15L,13L,12L,10L,9L,7L,6L,4L,3L,1L,16L,15L,13L,12L,10L,9L,7L,6L,4L,3L,1L,18L,16L,15L,13L,12L,10L,9L,7L,6L,4L,3L,1L,19L,18L,16L,15L,13L,12L,10L,9L,7L,6L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104568Inst : IEnumerable<long>
{
public static readonly long[] Value=A104568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104568.Bytes);
public long this[int i]=>Value[i];

public static A104568Inst Instance=new A104568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104569
{
public static readonly long[] Value={ 1L,4L,3L,5L,4L,1L,8L,7L,4L,3L,9L,8L,5L,4L,1L,12L,11L,8L,7L,4L,3L,13L,12L,9L,8L,5L,4L,1L,16L,15L,12L,11L,8L,7L,4L,3L,17L,16L,13L,12L,9L,8L,5L,4L,1L,20L,19L,16L,15L,12L,11L,8L,7L,4L,3L,21L,20L,17L,16L,13L,12L,9L,8L,5L,4L,1L,24L,23L,20L,19L,16L,15L,12L,11L,8L,7L,4L,3L,25L,24L,21L,20L,17L,16L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104569Inst : IEnumerable<long>
{
public static readonly long[] Value=A104569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104569.Bytes);
public long this[int i]=>Value[i];

public static A104569Inst Instance=new A104569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104570
{
public static readonly long[] Value={ 1L,2L,3L,3L,6L,1L,4L,9L,2L,3L,5L,12L,3L,6L,1L,6L,15L,4L,9L,2L,3L,7L,18L,5L,12L,3L,6L,1L,8L,21L,6L,15L,4L,9L,2L,3L,9L,24L,7L,18L,5L,12L,3L,6L,1L,10L,27L,8L,21L,6L,15L,4L,9L,2L,3L,11L,30L,9L,24L,7L,18L,5L,12L,3L,6L,1L,12L,33L,10L,27L,8L,21L,6L,15L,4L,9L,2L,3L,13L,36L,11L,30L,9L,24L,7L,18L,5L,12L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104570Inst : IEnumerable<long>
{
public static readonly long[] Value=A104570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104570.Bytes);
public long this[int i]=>Value[i];

public static A104570Inst Instance=new A104570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104571
{
public static readonly long[] Value={ 1L,4L,1L,5L,4L,1L,8L,5L,4L,1L,9L,8L,5L,4L,1L,12L,9L,8L,5L,4L,1L,13L,12L,9L,8L,5L,4L,1L,16L,13L,12L,9L,8L,5L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104571Inst : IEnumerable<long>
{
public static readonly long[] Value=A104571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104571.Bytes);
public long this[int i]=>Value[i];

public static A104571Inst Instance=new A104571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104572
{
public static readonly long[] Value={ 1L,5L,1L,12L,5L,1L,22L,12L,5L,1L,35L,22L,12L,5L,1L,51L,35L,22L,12L,5L,1L,70L,51L,35L,22L,12L,5L,1L,92L,70L,51L,35L,22L,12L,5L,1L,117L,92L,70L,51L,35L,22L,12L,5L,1L,145L,117L,92L,70L,51L,35L,22L,12L,5L,1L,176L,145L,117L,92L,70L,51L,35L,22L,12L,5L,1L,210L,176L,145L,117L,92L,70L,51L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104572Inst : IEnumerable<long>
{
public static readonly long[] Value=A104572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104572.Bytes);
public long this[int i]=>Value[i];

public static A104572Inst Instance=new A104572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104573
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,6L,2L,1L,12L,8L,1L,24L,22L,4L,1L,48L,58L,20L,1L,96L,149L,69L,8L,1L,192L,373L,221L,48L,1L,384L,914L,675L,198L,16L,1L,768L,2200L,1977L,740L,112L,1L,1536L,5216L,5597L,2593L,536L,32L,1L,3072L,12208L,15407L,8611L,2280L,256L,1L,6144L,28256L,41418L,27389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104573Inst : IEnumerable<long>
{
public static readonly long[] Value=A104573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104573.Bytes);
public long this[int i]=>Value[i];

public static A104573Inst Instance=new A104573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104574
{
public static readonly long[] Value={ 0L,1L,3L,10L,28L,80L,224L,633L,1793L,5109L,14619L,42003L,121089L,350116L,1014892L,2948429L,8582357L,25024833L,73080783L,213714517L,625756147L,1834282280L,5382370208L,15808450470L,46470788358L,136715063545L,402505866459L,1185835240498L,3495843681868L,10311848123968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104574Inst : IEnumerable<long>
{
public static readonly long[] Value=A104574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104574.Bytes);
public long this[int i]=>Value[i];

public static A104574Inst Instance=new A104574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104575
{
public static readonly long[] Value={ -1L,-2L,-1L,-1L,3L,1L,7L,4L,4L,4L,2L,-9L,-7L,-7L,-28L,-17L,-25L,-15L,-24L,-11L,-8L,34L,19L,53L,46L,108L,110L,106L,113L,122L,108L,75L,103L,-16L,-87L,-107L,-169L,-329L,-257L,-574L,-501L,-676L,-609L,-749L,-588L,-808L,-548L,-521L,-315L,-240L,369L,485L,865L,1099L,1738L,2129L,2686L,3088L,3460L,4103L,4011L,4480L,3983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104575Inst : IEnumerable<long>
{
public static readonly long[] Value=A104575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104575.Bytes);
public long this[int i]=>Value[i];

public static A104575Inst Instance=new A104575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104576
{
public static readonly long[] Value={ 2L,3L,4L,7L,8L,9L,10L,12L,20L,30L,33L,66L,76L,77L,82L,87L,98L,180L,205L,360L,553L,719L,766L,1390L,1879L,1999L,4033L,5620L,16506L,17436L,23676L,24428L,27758L,31932L,58199L,67661L,85040L,102023L,185595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104576Inst : IEnumerable<long>
{
public static readonly long[] Value=A104576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104576.Bytes);
public long this[int i]=>Value[i];

public static A104576Inst Instance=new A104576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104577
{
public static readonly long[] Value={ 2L,3L,8L,9L,16L,19L,24L,27L,46L,68L,71L,78L,107L,198L,309L,377L,477L,1057L,1631L,2419L,3974L,4293L,8247L,10513L,10709L,12011L,15042L,30543L,31607L,39664L,47552L,145858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104577Inst : IEnumerable<long>
{
public static readonly long[] Value=A104577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104577.Bytes);
public long this[int i]=>Value[i];

public static A104577Inst Instance=new A104577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104578
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,2L,0L,1L,1L,2L,3L,0L,1L,2L,3L,3L,4L,0L,1L,2L,6L,6L,4L,5L,0L,1L,3L,7L,12L,10L,5L,6L,0L,1L,4L,12L,16L,20L,15L,6L,7L,0L,1L,5L,17L,30L,30L,30L,21L,7L,8L,0L,1L,7L,24L,45L,60L,50L,42L,28L,8L,9L,0L,1L,9L,36L,70L,95L,105L,77L,56L,36L,9L,10L,0L,1L,12L,50L,111L,160L,175L,168L,112L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104578Inst : IEnumerable<long>
{
public static readonly long[] Value=A104578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104578.Bytes);
public long this[int i]=>Value[i];

public static A104578Inst Instance=new A104578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}