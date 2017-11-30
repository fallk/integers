using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A194757
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,0L,2L,4L,6L,8L,10L,12L,0L,3L,6L,9L,12L,15L,18L,0L,4L,8L,12L,16L,20L,24L,0L,5L,10L,15L,20L,25L,30L,0L,6L,12L,18L,24L,30L,36L,0L,7L,14L,21L,28L,35L,42L,0L,8L,16L,24L,32L,40L,48L,0L,9L,18L,27L,36L,45L,54L,0L,10L,20L,30L,40L,50L,60L,0L,11L,22L,33L,44L,55L,66L };
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
public class A194757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194757Inst : IEnumerable<long>
{
public static readonly long[] Value=A194757.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194757.Bytes);
public long this[int i]=>Value[i];

public static A194757Inst Instance=new A194757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194758
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,2L,7L,5L,3L,10L,7L,4L,1L,11L,7L,3L,15L,10L,5L,19L,13L,7L,23L,16L,9L,2L,21L,13L,5L,26L,17L,8L,31L,21L,11L,36L,25L,14L,3L,31L,19L,7L,37L,24L,11L,43L,29L,15L,49L,34L,19L,4L,41L,25L,9L,48L,31L,14L,55L,37L,19L,62L,43L,24L,5L,51L,31L,11L,59L,38L,17L,67L,45L,23L,75L };
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
public class A194758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194758Inst : IEnumerable<long>
{
public static readonly long[] Value=A194758.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194758.Bytes);
public long this[int i]=>Value[i];

public static A194758Inst Instance=new A194758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194759
{
public static readonly long[] Value={ 0L,1L,2L,0L,2L,4L,0L,3L,6L,0L,4L,8L,12L,3L,8L,13L,2L,8L,14L,1L,8L,15L,0L,8L,16L,24L,6L,15L,24L,4L,14L,24L,2L,13L,24L,0L,12L,24L,36L,9L,22L,35L,6L,20L,34L,3L,18L,33L,0L,16L,32L,48L,12L,29L,46L,8L,26L,44L,4L,23L,42L,0L,20L,40L,60L,15L,36L,57L,10L,32L,54L,5L,28L,51L,0L,24L,48L };
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
public class A194759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194759Inst : IEnumerable<long>
{
public static readonly long[] Value=A194759.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194759.Bytes);
public long this[int i]=>Value[i];

public static A194759Inst Instance=new A194759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194760
{
public static readonly long[] Value={ 1L,2L,3L,1L,3L,5L,1L,4L,7L,1L,5L,9L,13L,4L,9L,14L,3L,9L,15L,2L,9L,16L,1L,9L,17L,25L,7L,16L,25L,5L,15L,25L,3L,14L,25L,1L,13L,25L,37L,10L,23L,36L,7L,21L,35L,4L,19L,34L,1L,17L,33L,49L,13L,30L,47L,9L,27L,45L,5L,24L,43L,1L,21L,41L,61L,16L,37L,58L,11L,33L,55L,6L,29L,52L,1L,25L,49L };
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
public class A194760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194760Inst : IEnumerable<long>
{
public static readonly long[] Value=A194760.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194760.Bytes);
public long this[int i]=>Value[i];

public static A194760Inst Instance=new A194760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194761
{
public static readonly long[] Value={ 0L,0L,0L,3L,2L,1L,6L,4L,2L,9L,6L,3L,0L,10L,6L,2L,14L,9L,4L,18L,12L,6L,22L,15L,8L,1L,20L,12L,4L,25L,16L,7L,30L,20L,10L,35L,24L,13L,2L,30L,18L,6L,36L,23L,10L,42L,28L,14L,48L,33L,18L,3L,40L,24L,8L,47L,30L,13L,54L,36L,18L,61L,42L,23L,4L,50L,30L,10L,58L,37L,16L,66L,44L,22L,74L };
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
public class A194761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194761Inst : IEnumerable<long>
{
public static readonly long[] Value=A194761.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194761.Bytes);
public long this[int i]=>Value[i];

public static A194761Inst Instance=new A194761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194762
{
public static readonly long[] Value={ 1L,2L,3L,1L,3L,5L,7L,2L,5L,8L,11L,3L,7L,11L,15L,4L,9L,14L,19L,5L,11L,17L,23L,6L,13L,20L,1L,9L,17L,25L,3L,12L,21L,30L,5L,15L,25L,35L,7L,18L,29L,40L,9L,21L,33L,45L,11L,24L,37L,50L,13L,27L,41L,2L,17L,32L,47L,5L,21L,37L,53L,8L,25L,42L,59L,11L,29L,47L,65L,14L,33L,52L,71L,17L,37L };
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
public class A194762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194762Inst : IEnumerable<long>
{
public static readonly long[] Value=A194762.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194762.Bytes);
public long this[int i]=>Value[i];

public static A194762Inst Instance=new A194762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194763
{
public static readonly long[] Value={ 0L,0L,0L,3L,2L,1L,0L,6L,4L,2L,0L,9L,6L,3L,0L,12L,8L,4L,0L,15L,10L,5L,0L,18L,12L,6L,26L,19L,12L,5L,28L,20L,12L,4L,30L,21L,12L,3L,32L,22L,12L,2L,34L,23L,12L,1L,36L,24L,12L,0L,38L,25L,12L,52L,38L,24L,10L,53L,38L,23L,8L,54L,38L,22L,6L,55L,38L,21L,4L,56L,38L,20L,2L,57L,38L,19L,76L };
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
public class A194763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194763Inst : IEnumerable<long>
{
public static readonly long[] Value=A194763.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194763.Bytes);
public long this[int i]=>Value[i];

public static A194763Inst Instance=new A194763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194764
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,2L,1L,7L,5L,3L,1L,10L,7L,4L,1L,13L,9L,5L,1L,16L,11L,6L,1L,19L,13L,7L,27L,20L,13L,6L,29L,21L,13L,5L,31L,22L,13L,4L,33L,23L,13L,3L,35L,24L,13L,2L,37L,25L,13L,1L,39L,26L,13L,53L,39L,25L,11L,54L,39L,24L,9L,55L,39L,23L,7L,56L,39L,22L,5L,57L,39L,21L,3L,58L,39L,20L };
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
public class A194764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194764Inst : IEnumerable<long>
{
public static readonly long[] Value=A194764.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194764.Bytes);
public long this[int i]=>Value[i];

public static A194764Inst Instance=new A194764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194765
{
public static readonly long[] Value={ 0L,1L,2L,0L,2L,4L,6L,1L,4L,7L,10L,2L,6L,10L,14L,3L,8L,13L,18L,4L,10L,16L,22L,5L,12L,19L,0L,8L,16L,24L,2L,11L,20L,29L,4L,14L,24L,34L,6L,17L,28L,39L,8L,20L,32L,44L,10L,23L,36L,49L,12L,26L,40L,1L,16L,31L,46L,4L,20L,36L,52L,7L,24L,41L,58L,10L,28L,46L,64L,13L,32L,51L,70L,16L,36L };
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
public class A194765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194765Inst : IEnumerable<long>
{
public static readonly long[] Value=A194765.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194765.Bytes);
public long this[int i]=>Value[i];

public static A194765Inst Instance=new A194765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194766
{
public static readonly long[] Value={ 128L,175L,384L,672L,735L,1296L,6144L,18432L,23328L,34992L,82944L,442368L,1492992L,2333772L,2612736L,3981312L,4128768L,9289728L,12192768L,13226976L,13395375L,13436928L,21233664L,22127616L,27869184L,49787136L,161243136L };
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
public class A194766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194766Inst : IEnumerable<long>
{
public static readonly long[] Value=A194766.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194766.Bytes);
public long this[int i]=>Value[i];

public static A194766Inst Instance=new A194766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194767
{
public static readonly long[] Value={ 2L,2L,12L,20L,10L,42L,56L,24L,90L,110L,44L,156L,182L,70L,240L,272L,102L,342L,380L,140L,462L,506L,184L,600L,650L,234L,756L,812L,290L,930L,992L,352L,1122L,1190L };
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
public class A194767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194767Inst : IEnumerable<long>
{
public static readonly long[] Value=A194767.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194767.Bytes);
public long this[int i]=>Value[i];

public static A194767Inst Instance=new A194767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194768
{
public static readonly long[] Value={ 1L,32L,33L,243L,244L,275L,276L,1024L,1025L,1056L,1057L,1267L,1268L,1299L,1300L,3125L,3126L,3157L,3158L,3368L,3369L,3400L,3401L,4149L,4150L,4181L,4182L,4392L,4393L,4424L,4425L,7776L,7777L,7808L,7809L,8019L,8020L,8051L,8052L,8800L,8801L,8832L,8833L,9043L,9044L,9075L,9076L };
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
public class A194768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194768Inst : IEnumerable<long>
{
public static readonly long[] Value=A194768.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194768.Bytes);
public long this[int i]=>Value[i];

public static A194768Inst Instance=new A194768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194769
{
public static readonly long[] Value={ 1L,64L,65L,729L,730L,793L,794L,4096L,4097L,4160L,4161L,4825L,4826L,4889L,4890L,15625L,15626L,15689L,15690L,16354L,16355L,16418L,16419L,19721L,19722L,19785L,19786L,20450L,20451L,20514L,20515L };
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
public class A194769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194769Inst : IEnumerable<long>
{
public static readonly long[] Value=A194769.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194769.Bytes);
public long this[int i]=>Value[i];

public static A194769Inst Instance=new A194769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194770
{
public static readonly BigInteger[] Value={ 1L,-1L,0L,6L,-24L,0L,720L,-5040L,0L,362880L,-3628800L,0L,479001600L,-6227020800L,0L,1307674368000L,-20922789888000L,0L,6402373705728000L,-121645100408832000L,0L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("-1124000727777607680000") };
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
public class A194770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194770.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194770Inst Instance=new A194770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194771
{
public static readonly long[] Value={ 2L,12L,56L,240L,992L,1344L,16256L,60480L,65520L,1047552L,4357080L,47139840L,67100672L,91065600L,285981696L,919636480L,2758909440L,2952609792L,17179738112L,28364878080L,63996791040L,87722956800L,102002360320L,132867440640L,137438691328L };
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
public class A194771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194771Inst : IEnumerable<long>
{
public static readonly long[] Value=A194771.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194771.Bytes);
public long this[int i]=>Value[i];

public static A194771Inst Instance=new A194771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194772
{
public static readonly long[] Value={ 7L,17L,41L,95L,219L,493L,1101L,2427L,5311L,11529L,24881L,53399L,114083L,242725L,514581L,1087411L,2291335L,4815681L,10097401L,21126863L,44117867L,91963997L,191384541L,397682155L,825190479L,1710033273L,3539371201L,7317351687L };
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
public class A194772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194772Inst : IEnumerable<long>
{
public static readonly long[] Value=A194772.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194772.Bytes);
public long this[int i]=>Value[i];

public static A194772Inst Instance=new A194772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194773
{
public static readonly long[] Value={ 43L,105L,265L,655L,1641L,4069L,10121L,25025L,61809L,152019L,372979L,912017L,2224175L,5408825L,13120905L,31752431L,76673045L,184762437L,444388957L,1066954113L,2557518625L,6121119363L,14629468735L,34918297649L,83242029523L,198212839881L };
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
public class A194773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194773Inst : IEnumerable<long>
{
public static readonly long[] Value=A194773.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194773.Bytes);
public long this[int i]=>Value[i];

public static A194773Inst Instance=new A194773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194774
{
public static readonly long[] Value={ 268L,672L,1736L,4464L,11686L,30608L,80961L,214469L,570921L,1521287L,4061881L,10847647L,28982750L,77406210L,206655490L,551301206L,1469565060L,3913609398L,10412354243L,27674510615L,73480819187L,194908131709L,516485443463L };
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
public class A194774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194774Inst : IEnumerable<long>
{
public static readonly long[] Value=A194774.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194774.Bytes);
public long this[int i]=>Value[i];

public static A194774Inst Instance=new A194774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194775
{
public static readonly long[] Value={ 1740L,4490L,11857L,31429L,84727L,229869L,631373L,1745459L,4867831L,13649561L,38503606L,109050858L,310061698L,883972100L,2526165997L,7230962925L,20725462609L,59454601239L,170659921683L,490024454069L,1407237659011L };
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
public class A194775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194775Inst : IEnumerable<long>
{
public static readonly long[] Value=A194775.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194775.Bytes);
public long this[int i]=>Value[i];

public static A194775Inst Instance=new A194775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194776
{
public static readonly long[] Value={ 11862L,31466L,85007L,231395L,639325L,1782111L,5029741L,14321783L,41203606L,119499674L,349498634L,1029170664L,3050715488L,9092629968L,27237137985L,81930133845L,247359353107L,749090477957L };
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
public class A194776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194776Inst : IEnumerable<long>
{
public static readonly long[] Value=A194776.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194776.Bytes);
public long this[int i]=>Value[i];

public static A194776Inst Instance=new A194776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194777
{
public static readonly long[] Value={ 85013L,231445L,639753L,1784723L,5044981L,14399939L,41587186L,121261490L,357312638L,1062459348L,3188769448L,9649809740L,29439886715L,90469050263L,279932030931L,871510145365L };
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
public class A194777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194777Inst : IEnumerable<long>
{
public static readonly long[] Value=A194777.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194777.Bytes);
public long this[int i]=>Value[i];

public static A194777Inst Instance=new A194777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194778
{
public static readonly long[] Value={ 1L,7L,3L,43L,17L,6L,268L,105L,41L,12L,1740L,672L,265L,95L,23L,11862L,4490L,1736L,655L,219L,43L,85013L,31466L,11857L,4464L,1641L,493L,79L,639760L,231445L,85007L,31429L,11686L,4069L,1101L,143L,5045610L,1784788L,639753L,231395L,84727L,30608L,10121L,2427L,256L };
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
public class A194778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194778Inst : IEnumerable<long>
{
public static readonly long[] Value=A194778.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194778.Bytes);
public long this[int i]=>Value[i];

public static A194778Inst Instance=new A194778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194779
{
public static readonly long[] Value={ 1L,7L,43L,268L,1740L,11862L,85013L,639760L,5045610L,41615165L,358185399L,3210667490L,29914284833L,289187621900L,2895861006415L };
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
public class A194779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194779Inst : IEnumerable<long>
{
public static readonly long[] Value=A194779.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194779.Bytes);
public long this[int i]=>Value[i];

public static A194779Inst Instance=new A194779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194780
{
public static readonly long[] Value={ 3L,17L,105L,672L,4490L,31466L,231445L,1784788L,14404218L,121421075L,1066906979L,9753108510L,92586250999L,911156724048L };
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
public class A194780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194780Inst : IEnumerable<long>
{
public static readonly long[] Value=A194780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194780.Bytes);
public long this[int i]=>Value[i];

public static A194780Inst Instance=new A194780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194781
{
public static readonly long[] Value={ 6L,41L,265L,1736L,11857L,85007L,639753L,5045602L,41615156L,358185389L,3210667479L,29914284821L,289187621887L };
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
public class A194781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194781Inst : IEnumerable<long>
{
public static readonly long[] Value=A194781.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194781.Bytes);
public long this[int i]=>Value[i];

public static A194781Inst Instance=new A194781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194782
{
public static readonly long[] Value={ 12L,95L,655L,4464L,31429L,231395L,1784723L,14404136L,121420974L,1066906857L,9753108365L,92586250829L,911156723851L };
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
public class A194782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194782Inst : IEnumerable<long>
{
public static readonly long[] Value=A194782.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194782.Bytes);
public long this[int i]=>Value[i];

public static A194782Inst Instance=new A194782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194783
{
public static readonly long[] Value={ 23L,219L,1641L,11686L,84727L,639325L,5044981L,41614291L,358184223L,3210665949L,29914282858L,289187619416L };
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
public class A194783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194783Inst : IEnumerable<long>
{
public static readonly long[] Value=A194783.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194783.Bytes);
public long this[int i]=>Value[i];

public static A194783Inst Instance=new A194783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194784
{
public static readonly long[] Value={ 43L,493L,4069L,30608L,229869L,1782111L,14399939L,121414559L,1066897441L,9753094999L,92586232382L,911156698994L };
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
public class A194784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194784Inst : IEnumerable<long>
{
public static readonly long[] Value=A194784.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194784.Bytes);
public long this[int i]=>Value[i];

public static A194784Inst Instance=new A194784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194785
{
public static readonly long[] Value={ 79L,1101L,10121L,80961L,631373L,5029741L,41587186L,358138793L,3210593393L,29914171526L,289187454251L };
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
public class A194785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194785Inst : IEnumerable<long>
{
public static readonly long[] Value=A194785.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194785.Bytes);
public long this[int i]=>Value[i];

public static A194785Inst Instance=new A194785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194786
{
public static readonly BigInteger[] Value={ 1L,1L,2L,12L,108L,1360L,21780L,424998L,9774912L,259012080L,7769656800L,260283596760L,9631680917760L,390185658289128L,17175153440774784L,816267894739416000L,BigInteger.Parse("41658264473400852480"),BigInteger.Parse("2272233977181361580160"),BigInteger.Parse("131913883517800157429760"),BigInteger.Parse("8121310193676734923381056") };
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
public class A194786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194786Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194786.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194786.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194786Inst Instance=new A194786Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194787
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,272L,3630L,60714L,1221864L,28779120L,776965680L,23662145160L,802640076480L,30014281406856L,1226796674341056L,54417859649294400L,2603641529587553280L,BigInteger.Parse("133660822187138916480"),BigInteger.Parse("7328549084322230968320"),BigInteger.Parse("427437378614564995967424") };
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
public class A194787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194787Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194787.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194787.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194787Inst Instance=new A194787Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194788
{
public static readonly long[] Value={ 0L,0L,0L,0L,242L,51504L,2484382L,44601420L,450193818L,3112919712L,16471667554L,71393226972L,265069706646L,869583076752L,2577681275622L,7020477731884L,17794428237522L,42397762374912L,95726217156906L,206149749502012L,425731784898894L,846919172059632L };
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
public class A194788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194788Inst : IEnumerable<long>
{
public static readonly long[] Value=A194788.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194788.Bytes);
public long this[int i]=>Value[i];

public static A194788Inst Instance=new A194788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194789
{
public static readonly long[] Value={ 6L,9L,7L,3L,8L,7L,9L,4L,5L,7L,6L,2L,1L,4L,3L,0L,7L,0L,4L,0L,7L,5L,3L,2L,3L,6L,7L,3L,5L,4L,9L,0L,4L,2L,3L,4L,5L,7L,7L,0L,3L,5L,5L,1L,8L,6L,1L,0L,5L,0L,2L,9L,8L,3L,6L,3L,7L,6L,2L,5L,3L,0L,4L,8L,2L,0L,4L,8L,5L,2L,0L,3L,2L,2L,4L,6L,9L,5L,4L,9L,3L,4L,3L,8L,1L,9L,0L,3L,5L,5L,5L,6L,1L,8L,7L,0L,5L,7L,2L,5L };
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
public class A194789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194789Inst : IEnumerable<long>
{
public static readonly long[] Value=A194789.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194789.Bytes);
public long this[int i]=>Value[i];

public static A194789Inst Instance=new A194789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194790
{
public static readonly BigInteger[] Value={ 1L,9L,252L,11160L,779544L,86082552L,15042748752L,4162973481720L,1825584767007624L,1269014066306135784L,BigInteger.Parse("1398647178389920392360"),BigInteger.Parse("2444528051373276536144472"),BigInteger.Parse("6776054483832917004333974184") };
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
public class A194790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194790.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194790Inst Instance=new A194790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194791
{
public static readonly BigInteger[] Value={ 1L,10L,942L,267856L,187321720L,320268943536L,1338718951693520L,13681233554467188752UL,BigInteger.Parse("341845510164048367758144"),BigInteger.Parse("20883629381235404306727327808"),BigInteger.Parse("3119284181051765188519492660687792") };
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
public class A194791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194791Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194791.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194791.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194791Inst Instance=new A194791Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194792
{
public static readonly BigInteger[] Value={ 1L,10L,1530L,1587724L,6012771932L,76835222989340L,3302081001560127592L,BigInteger.Parse("477232970093526846547868"),BigInteger.Parse("231946991234978104864701810980"),BigInteger.Parse("379107829075672054750390251800219732") };
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
public class A194792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194792Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194792.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194792.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194792Inst Instance=new A194792Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194793
{
public static readonly BigInteger[] Value={ 1L,10L,1719L,4018152L,55882468218L,3454550787171726L,BigInteger.Parse("921229375293720351150"),BigInteger.Parse("1058115897991435552912456494"),BigInteger.Parse("5234423089116609084311564185372068"),BigInteger.Parse("111525513162694816614399225360134812623972") };
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
public class A194793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194793Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194793.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194793.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194793Inst Instance=new A194793Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194794
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,1L,4L,0L,0L,1L,9L,12L,0L,0L,1L,10L,252L,32L,0L,0L,1L,10L,942L,11160L,80L,0L,0L,1L,10L,1530L,267856L,779544L,192L,0L,0L,1L,10L,1719L,1587724L,187321720L,86082552L,448L,0L,0L,1L,10L,1743L,4018152L,6012771932L,320268943536L,15042748752L,1024L,0L,0L,1L,10L };
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
public class A194794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194794Inst : IEnumerable<long>
{
public static readonly long[] Value=A194794.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194794.Bytes);
public long this[int i]=>Value[i];

public static A194794Inst Instance=new A194794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194795
{
public static readonly long[] Value={ 0L,-1L,0L,-2L,0L,-4L,0L,-7L,1L,-11L,3L,-18L,6L,-28L,13L,-42L,24L,-64L,41L,-96L,69L,-141L,112L,-208L,175L,-303L,271L,-437L,410L,-629L,609L,-898L,896L,-1271L,1302L,-1792L,1868L,-2510L,2660L,-3493L,3752L,-4839L,5248L,-6666L,7293L,-9131L,10065L,-12454L };
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
public class A194795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194795Inst : IEnumerable<long>
{
public static readonly long[] Value=A194795.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194795.Bytes);
public long this[int i]=>Value[i];

public static A194795Inst Instance=new A194795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194796
{
public static readonly long[] Value={ 0L,-1L,0L,-3L,0L,-8L,0L,-17L,3L,-31L,10L,-58L,22L,-101L,52L,-167L,104L,-278L,191L,-451L,344L,-711L,594L,-1119L,983L,-1730L,1606L,-2635L,2555L,-3990L,3978L,-5972L,6118L,-8835L,9269L,-12986L,13835L,-18917L,20454L,-27320L,29900L,-39204L,43268L,-55846L,62112L };
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
public class A194796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194796Inst : IEnumerable<long>
{
public static readonly long[] Value=A194796.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194796.Bytes);
public long this[int i]=>Value[i];

public static A194796Inst Instance=new A194796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194797
{
public static readonly long[] Value={ 0L,-2L,1L,-7L,3L,-21L,7L,-49L,23L,-97L,57L,-195L,117L,-359L,256L,-624L,498L,-1086L,909L,-1831L,1634L,-2986L,2833L,-4847L,4728L,-7700L,7798L,-12026L,12537L,-18633L,19745L,-28479L,30723L,-42955L,47100L,-64284L,71136L,-95228L,106402L,-139718L,157327L,-203495L };
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
public class A194797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194797Inst : IEnumerable<long>
{
public static readonly long[] Value=A194797.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194797.Bytes);
public long this[int i]=>Value[i];

public static A194797Inst Instance=new A194797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194798
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,10L,13L,17L,22L,23L,26L,28L,29L,30L,33L,34L,35L,37L,39L,40L,41L,42L,43L,46L,49L,50L,51L,53L,58L,61L,62L,63L,64L,66L,67L,69L,70L,71L,73L,74L,77L,78L,80L,81L,83L,84L,85L,86L,87L,89L,91L,93L,94L,95L,96L,98L,99L,100L,105L,106L,107L,108L,110L,111L };
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
public class A194798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194798Inst : IEnumerable<long>
{
public static readonly long[] Value=A194798.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194798.Bytes);
public long this[int i]=>Value[i];

public static A194798Inst Instance=new A194798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194799
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,4L,2L,2L,1L,1L,1L,4L,4L,2L,2L,1L,1L,1L,7L,4L,4L,2L,2L,1L,1L,1L,8L,7L,4L,4L,2L,2L,1L,1L,1L,12L,8L,7L,4L,4L,2L,2L,1L,1L,1L,14L,12L,8L,7L,4L,4L,2L,2L,1L,1L,1L,21L,14L,12L,8L,7L,4L,4L,2L,2L,1L,1L,1L,24L,21L,14L };
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
public class A194799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194799Inst : IEnumerable<long>
{
public static readonly long[] Value=A194799.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194799.Bytes);
public long this[int i]=>Value[i];

public static A194799Inst Instance=new A194799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194800
{
public static readonly long[] Value={ 0L,3L,11L,17L,31L,39L,67L };
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
public class A194800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194800Inst : IEnumerable<long>
{
public static readonly long[] Value=A194800.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194800.Bytes);
public long this[int i]=>Value[i];

public static A194800Inst Instance=new A194800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194801
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,0L,1L,1L,3L,0L,1L,2L,4L,1L,0L,1L,3L,5L,4L,6L,0L,1L,4L,6L,7L,9L,3L,0L,1L,5L,7L,10L,12L,9L,10L,0L,1L,6L,8L,13L,15L,15L,16L,6L,0L,1L,7L,9L,16L,18L,21L,22L,16L,15L,0L,1L,8L,10L,19L,21L,27L,28L,26L,25L,10L,0L,1L,9L,11L,22L,24L,33L,34L,36L,35L };
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
public class A194801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194801Inst : IEnumerable<long>
{
public static readonly long[] Value=A194801.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194801.Bytes);
public long this[int i]=>Value[i];

public static A194801Inst Instance=new A194801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194802
{
public static readonly long[] Value={ 0L,5L,9L,23L,29L,45L,57L };
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
public class A194802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194802Inst : IEnumerable<long>
{
public static readonly long[] Value=A194802.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194802.Bytes);
public long this[int i]=>Value[i];

public static A194802Inst Instance=new A194802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194803
{
public static readonly long[] Value={ 0L,1L,3L,5L,8L,11L,17L,23L,33L,46L,64L,86L,121L,161L,217L,291L,388L,507L,671L,870L,1131L,1458L,1872L,2383L,3042L,3840L,4841L,6076L,7605L,9460L,11765L,14544L,17950L,22073L,27077L,33092L,40395L,49113L,59611L,72162L,87185L,105035L,126366L };
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
public class A194803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194803Inst : IEnumerable<long>
{
public static readonly long[] Value=A194803.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194803.Bytes);
public long this[int i]=>Value[i];

public static A194803Inst Instance=new A194803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194804
{
public static readonly long[] Value={ 0L,1L,4L,8L,15L,23L,40L,59L,92L,137L,202L,285L,418L,577L,802L,1106L,1511L,2019L,2724L,3598L,4755L,6226L,8107L,10462L,13523L,17280L,22029L,27953L,35350L,44416L,55763L,69579L,86634L,107459L,132914L,163768L,201475L,246841L,301822L,368033L,447790L,543206L };
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
public class A194804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194804Inst : IEnumerable<long>
{
public static readonly long[] Value=A194804.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194804.Bytes);
public long this[int i]=>Value[i];

public static A194804Inst Instance=new A194804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194805
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,11L,17L,25L,36L,51L,71L,97L,132L,177L,235L,310L,406L,527L,681L,874L,1116L,1418L,1793L,2256L,2829L,3532L,4393L,5445L,6727L,8282L,10168L,12445L,15190L,18491L,22452L,27192L,32859L,39613L,47651L,57199L,68522L,81920L,97756L,116434L,138435L };
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
public class A194805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194805Inst : IEnumerable<long>
{
public static readonly long[] Value=A194805.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194805.Bytes);
public long this[int i]=>Value[i];

public static A194805Inst Instance=new A194805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194806
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,4L,5L,6L,6L,6L,7L,7L,8L,8L,8L,8L,9L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,14L,14L,15L,16L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,19L,19L,19L,19L,20L,20L,20L,21L,21L,21L,22L,22L,22L,22L,22L,22L,23L,23L,24L,24L,24L,24L,24L,24L,25L,25L,25L,25L,26L,26L,27L,27L,28L,28L,28L,28L,29L,29L,29L,29L,30L,31L,31L,31L,31L,31L,32L,32L,32L,32L,32L,32L,32L,32L,33L,34L,34L,34L };
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
public class A194806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194806Inst : IEnumerable<long>
{
public static readonly long[] Value=A194806.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194806.Bytes);
public long this[int i]=>Value[i];

public static A194806Inst Instance=new A194806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194807
{
public static readonly long[] Value={ 1L,3L,9L,2L,2L,1L,1L,1L,9L,1L,1L,7L,7L,3L,3L,2L,8L,1L,4L,3L,7L,6L,5L,5L,2L,8L,7L,8L,4L,7L,9L,8L,1L,6L,5L,2L,8L,3L,7L,3L,9L,7L,8L,3L,8L,5L,3L,1L,5L,2L,8L,7L,1L,2L,3L,5L,9L,1L,3L,2L,4L,5L,6L,7L,0L,8L,3L,2L,7L,9L,5L,7L,0L,4L,6L,1L,6L,1L,0L,9L,2L,6L,6L,9L,1L,7L,1L,0L,5L,8L,7L,2L,6L,7L,6L,1L,2L,9L,9L,8L,8L,8L,8L,5L,6L };
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
public class A194807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194807Inst : IEnumerable<long>
{
public static readonly long[] Value=A194807.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194807.Bytes);
public long this[int i]=>Value[i];

public static A194807Inst Instance=new A194807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194808
{
public static readonly long[] Value={ 3L,0L,2L,1L,3L,2L,4L,4L,1L,1L,3L,4L,1L,1L,3L,1L,3L,2L,4L,2L,4L,4L,1L,4L,1L,1L,3L,2L,4L,2L,4L,4L,1L,4L,1L,1L,3L,1L,3L,2L,4L,4L,1L,1L,3L,1L,3L,1L,3L,4L,1L,4L,1L,2L,4L,1L,3L,4L,1L,4L,1L,1L,3L,2L,4L,2L,4L,1L,3L,4L,1L,1L,3L,4L,1L,1L,3L,1L,3L,1L,3L,4L,1L,2L,4L,4L,1L,1L };
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
public class A194808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194808Inst : IEnumerable<long>
{
public static readonly long[] Value=A194808.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194808.Bytes);
public long this[int i]=>Value[i];

public static A194808Inst Instance=new A194808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194809
{
public static readonly long[] Value={ 0L,-2L,1L,-5L,3L,-12L,7L,-25L,17L,-47L,36L,-88L,69L,-155L,133L,-262L,240L,-439L,415L,-717L,705L,-1142L,1165L,-1803L,1874L,-2797L,2975L,-4276L,4632L,-6478L,7094L,-9698L,10741L,-14355L,16059L,-21079L,23719L,-30670L,34716L,-44243L,50315L,-63372L };
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
public class A194809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194809Inst : IEnumerable<long>
{
public static readonly long[] Value=A194809.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194809.Bytes);
public long this[int i]=>Value[i];

public static A194809Inst Instance=new A194809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194810
{
public static readonly BigInteger[] Value={ 2L,4L,8L,32L,64L,256L,512L,2048L,32768L,2097152L,1073741824L,549755813888L,1125899906842624L,9223372036854775808UL,BigInteger.Parse("9671406556917033397649408"),BigInteger.Parse("39614081257132168796771975168"),BigInteger.Parse("633825300114114700748351602688") };
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
public class A194810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194810Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194810.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194810.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194810Inst Instance=new A194810Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194811
{
public static readonly long[] Value={ 1L,5L,13L,25L,37L,53L,81L,113L,133L,149L,177L,213L,253L,313L,401L,481L,517L,533L,561L,597L,637L,697L,785L,869L,925L,985L,1077L,1189L,1329L,1537L,1793L,1985L,2053L,2069L,2097L,2133L,2173L,2233L,2321L,2405L,2461L,2521L,2613L,2725L,2865L,3073L,3329L,3525L,3613L };
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
public class A194811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194811Inst : IEnumerable<long>
{
public static readonly long[] Value=A194811.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194811.Bytes);
public long this[int i]=>Value[i];

public static A194811Inst Instance=new A194811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194812
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,0L,3L,0L,0L,0L,5L,2L,1L,0L,0L,7L,1L,0L,0L,0L,0L,11L,4L,1L,1L,0L,0L,0L,15L,3L,2L,0L,0L,0L,0L,0L,22L,8L,2L,1L,1L,0L,0L,0L,0L,30L,7L,3L,1L,0L,0L,0L,0L,0L,0L,42L,15L,6L,3L,1L,1L,0L,0L,0L,0L,0L,56L,15L,6L,2L,1L,0L,0L,0L,0L,0L,0L,0L,77L,27L,10L };
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
public class A194812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194812Inst : IEnumerable<long>
{
public static readonly long[] Value=A194812.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194812.Bytes);
public long this[int i]=>Value[i];

public static A194812Inst Instance=new A194812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194813
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,3L,4L,5L,5L,5L,6L,6L,6L,6L,7L,8L,8L,8L,9L,10L,11L,11L,12L,13L,13L,13L,13L,14L,15L,15L,15L,16L,16L,16L,16L,17L,18L,18L,18L,19L,20L,21L,21L,22L,23L,23L,23L,23L,24L,25L,25L,25L,26L,27L,28L,28L,29L,30L,30L,30L,31L,32L,33L,33L,33L,34L,34L,34L,34L,35L,36L,36L };
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
public class A194813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194813Inst : IEnumerable<long>
{
public static readonly long[] Value=A194813.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194813.Bytes);
public long this[int i]=>Value[i];

public static A194813Inst Instance=new A194813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194814
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,4L,4L,4L,4L,5L,6L,6L,7L,8L,9L,9L,9L,10L,11L,11L,11L,11L,12L,12L,12L,13L,14L,15L,15L,15L,16L,17L,17L,18L,19L,20L,20L,20L,21L,22L,22L,22L,22L,23L,23L,23L,24L,25L,26L,26L,26L,27L,28L,28L,28L,28L,29L,29L,29L,30L,31L,31L,31L,31L,32L,33L,33L,34L,35L,36L,36L,36L };
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
public class A194814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194814Inst : IEnumerable<long>
{
public static readonly long[] Value=A194814.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194814.Bytes);
public long this[int i]=>Value[i];

public static A194814Inst Instance=new A194814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194815
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,2L,3L,4L,5L,5L,5L,6L,7L,8L,9L,9L,9L,9L,10L,11L,11L,11L,11L,12L,13L,14L,14L,14L,14L,14L,15L,16L,16L,16L,16L,17L,18L,19L,19L,19L,20L,21L,22L,23L,23L,23L,23L,24L,25L,26L,26L,26L,27L,28L,29L,29L,29L,29L,29L,30L,31L,31L,31L,31L,32L,33L,34L,34L,34L,35L,36L,37L };
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
public class A194815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194815Inst : IEnumerable<long>
{
public static readonly long[] Value=A194815.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194815.Bytes);
public long this[int i]=>Value[i];

public static A194815Inst Instance=new A194815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194816
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,4L,4L,4L,5L,6L,6L,6L,6L,6L,7L,8L,9L,9L,9L,10L,11L,12L,12L,12L,12L,13L,14L,15L,16L,16L,16L,17L,18L,19L,19L,19L,19L,20L,21L,21L,21L,21L,21L,22L,23L,24L,24L,24L,24L,25L,26L,26L,26L,26L,27L,28L,29L,30L,30L,30L,31L,32L,33L,33L,33L,33L,34L,35L,35L,35L,35L,35L };
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
public class A194816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194816Inst : IEnumerable<long>
{
public static readonly long[] Value=A194816.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194816.Bytes);
public long this[int i]=>Value[i];

public static A194816Inst Instance=new A194816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194817
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,4L,4L,5L,5L,5L,5L,6L,6L,7L,8L,9L,9L,10L,11L,12L,12L,12L,13L,13L,13L,13L,14L,14L,15L,16L,17L,17L,18L,19L,19L,19L,19L,20L,20L,20L,20L,21L,21L,22L,23L,24L,24L,25L,26L,26L,26L,26L,27L,27L,28L,29L,30L,30L,31L,32L,33L,33L,33L,34L,34L,34L,34L,35L,35L,36L,37L };
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
public class A194817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194817Inst : IEnumerable<long>
{
public static readonly long[] Value=A194817.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194817.Bytes);
public long this[int i]=>Value[i];

public static A194817Inst Instance=new A194817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194818
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,3L,4L,4L,5L,6L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,11L,11L,12L,13L,14L,14L,15L,15L,15L,15L,16L,16L,16L,17L,18L,19L,19L,20L,21L,22L,22L,23L,23L,23L,23L,24L,24L,24L,25L,26L,27L,27L,28L,28L,28L,28L,29L,29L,29L,29L,30L,31L,31L,32L,33L,34L,34L,35L,35L,35L,35L };
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
public class A194818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194818Inst : IEnumerable<long>
{
public static readonly long[] Value=A194818.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194818.Bytes);
public long this[int i]=>Value[i];

public static A194818Inst Instance=new A194818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194819
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,3L,3L,4L,4L,5L,6L,6L,6L,6L,7L,7L,8L,9L,10L,10L,10L,11L,11L,12L,13L,14L,14L,14L,15L,15L,16L,17L,18L,18L,18L,19L,19L,19L,19L,20L,20L,21L,22L,22L,22L,22L,23L,23L,24L,25L,25L,25L,25L,26L,26L,27L,28L,29L,29L,29L,30L,30L,31L,32L,33L,33L,33L,34L,34L,35L,36L,37L };
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
public class A194819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194819Inst : IEnumerable<long>
{
public static readonly long[] Value=A194819.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194819.Bytes);
public long this[int i]=>Value[i];

public static A194819Inst Instance=new A194819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194820
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,4L,5L,5L,6L,6L,6L,7L,8L,9L,9L,10L,10L,10L,10L,11L,12L,12L,13L,13L,13L,13L,14L,15L,15L,16L,16L,16L,16L,17L,18L,18L,19L,20L,21L,21L,22L,22L,22L,23L,24L,25L,25L,26L,26L,26L,27L,28L,29L,29L,30L,30L,30L,30L,31L,32L,32L,33L,33L,33L,33L,34L,35L,35L,36L,36L,36L };
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
public class A194820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194820Inst : IEnumerable<long>
{
public static readonly long[] Value=A194820.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194820.Bytes);
public long this[int i]=>Value[i];

public static A194820Inst Instance=new A194820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194821
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,0L,1L,0L,1L,1L,1L,1L,2L,2L,2L,1L,2L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,2L,2L,1L,2L,1L,2L,2L,2L,2L,3L,2L,2L,1L,2L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,1L,1L,0L,1L,0L,1L,1L,1L,1L,2L,1L,1L,0L,1L,0L,1L,1L,1L,1L,2L,2L,2L,1L,2L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,2L,2L,1L,2L,1L,2L,2L,2L,2L,3L,3L };
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
public class A194821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194821Inst : IEnumerable<long>
{
public static readonly long[] Value=A194821.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194821.Bytes);
public long this[int i]=>Value[i];

public static A194821Inst Instance=new A194821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194822
{
public static readonly long[] Value={ 2L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,3L,3L,3L,3L,3L,2L,3L,2L,2L,2L,3L,2L,3L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,1L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,0L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,2L,1L,2L,2L };
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
public class A194822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194822Inst : IEnumerable<long>
{
public static readonly long[] Value=A194822.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194822.Bytes);
public long this[int i]=>Value[i];

public static A194822Inst Instance=new A194822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194823
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L };
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
public class A194823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194823Inst : IEnumerable<long>
{
public static readonly long[] Value=A194823.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194823.Bytes);
public long this[int i]=>Value[i];

public static A194823Inst Instance=new A194823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194824
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,2L,1L,2L,1L,2L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,3L,3L,3L,3L,3L,2L,3L,2L,3L,2L,2L,2L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,3L,3L,3L,3L };
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
public class A194824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194824Inst : IEnumerable<long>
{
public static readonly long[] Value=A194824.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194824.Bytes);
public long this[int i]=>Value[i];

public static A194824Inst Instance=new A194824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194825
{
public static readonly long[] Value={ 1L,9L,6L,1L,3L,3L,1L,6L,9L,1L,9L,6L,1L,3L,3L,1L,6L,9L,1L,9L,6L,1L,3L,3L,1L,6L,9L,1L,9L,6L,1L,3L,3L,1L,6L,9L,1L,9L,6L,1L,3L,3L,1L,6L,9L,1L,9L,6L,1L,3L,3L,1L,6L,9L,1L,9L,6L,1L,3L,3L,1L,6L,9L,1L,9L,6L,1L,3L,3L,1L,6L,9L,1L,9L,6L,1L,3L,3L,1L,6L,9L,1L,9L,6L,1L,3L };
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
public class A194825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194825Inst : IEnumerable<long>
{
public static readonly long[] Value=A194825.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194825.Bytes);
public long this[int i]=>Value[i];

public static A194825Inst Instance=new A194825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194826
{
public static readonly long[] Value={ 1L,9L,4L,6L,5L,1L,4L,4L,1L,5L,6L,4L,9L,1L,0L,6L,9L,9L,6L,0L,1L,9L,4L,6L,5L,1L,4L,4L,1L,5L,6L,4L,9L,1L,0L,6L,9L,9L,6L,0L,1L,9L,4L,6L,5L,1L,4L,4L,1L,5L,6L,4L,9L,1L,0L,6L,9L,9L,6L,0L,1L,9L,4L,6L,5L,1L,4L,4L,1L,5L,6L,4L,9L,1L,0L,6L,9L,9L,6L,0L,1L,9L,4L,6L,5L,1L };
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
public class A194826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194826Inst : IEnumerable<long>
{
public static readonly long[] Value=A194826.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194826.Bytes);
public long this[int i]=>Value[i];

public static A194826Inst Instance=new A194826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194827
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,2L,2L,3L,2L,2L,0L,2L,2L,4L,4L,5L,4L,4L,2L,2L,0L,3L,4L,6L,6L,7L,6L,8L,8L,10L,10L,11L,10L,10L,8L,8L,6L,7L,6L,6L,4L,3L,0L,3L,4L,7L,8L,10L,10L,11L,10L,11L,10L,13L,14L,16L,16L,17L,16L,18L,18L,20L,20L,21L,20L,20L,18L,18L,16L,17L,16L,16L,14L,13L,10L,11L,10L,11L,10L,10L };
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
public class A194827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194827Inst : IEnumerable<long>
{
public static readonly long[] Value=A194827.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194827.Bytes);
public long this[int i]=>Value[i];

public static A194827Inst Instance=new A194827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194828
{
public static readonly long[] Value={ 7L,11L,21L,23L,55L,83L,167L,611L,887L,1487L,1571L,10771L,12227L,13523L,16321L,44881L,54863L,57887L,93167L,189947L,404939L,442307L,1746551L,3383593L,3544391L,5056787L,6811307L,25619213L,87170987L,404940757L,526805663L,707095391L,1009465507L,1048720723L };
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
public class A194828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194828Inst : IEnumerable<long>
{
public static readonly long[] Value=A194828.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194828.Bytes);
public long this[int i]=>Value[i];

public static A194828Inst Instance=new A194828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194829
{
public static readonly long[] Value={ 3L,5L,7L,13L,17L,37L,61L,73L,109L,181L,277L,317L,349L,397L,419L,503L,577L,601L,709L,829L,877L,1129L,1237L,1367L,1429L,1669L,1993L,2467L,2833L,2879L,3001L,3037L,3329L,3821L,4861L,5003L,5281L,5821L,5897L,6301L,6329L,6421L,7129L,7309L,7873L,8017L,8597L,8821L,8969L,9157L };
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
public class A194829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194829Inst : IEnumerable<long>
{
public static readonly long[] Value=A194829.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194829.Bytes);
public long this[int i]=>Value[i];

public static A194829Inst Instance=new A194829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194830
{
public static readonly long[] Value={ 7L,9L,17L,33L,45L,51L,75L,93L,105L,135L,153L,165L,225L,273L,285L,315L,405L,465L,495L,525L,735L,765L,945L,1155L,1365L,1785L,1995L,2145L,2415L,2625L,3045L,3255L,3465L,3885L,4095L,4305L,4725L,4935L,5145L,5355L,5565L,5775L,6405L,6825L,7665L,8085L,8925L,9555L };
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
public class A194830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194830Inst : IEnumerable<long>
{
public static readonly long[] Value=A194830.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194830.Bytes);
public long this[int i]=>Value[i];

public static A194830Inst Instance=new A194830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194831
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,8L,11L,12L,13L,14L,16L,21L,22L,26L,27L,31L,32L,35L,43L,48L,52L,65L,77L,87L,101L,104L,115L,128L,133L,146L,155L,169L,180L,188L,194L,196L,201L,209L,225L,228L,248L,250L,282L,286L,325L,332L,359L,391L,400L,443L,449L,470L,555L,579L,582L,679L,741L };
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
public class A194831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194831Inst : IEnumerable<long>
{
public static readonly long[] Value=A194831.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194831.Bytes);
public long this[int i]=>Value[i];

public static A194831Inst Instance=new A194831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194832
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,3L,1L,4L,2L,3L,1L,4L,2L,5L,3L,6L,1L,4L,2L,5L,3L,6L,1L,4L,7L,2L,5L,8L,3L,6L,1L,4L,7L,2L,5L,8L,3L,6L,1L,9L,4L,7L,2L,5L,8L,3L,6L,1L,9L,4L,7L,2L,10L,5L,8L,3L,11L,6L,1L,9L,4L,7L,2L,10L,5L,8L,3L,11L,6L,1L,9L,4L,12L,7L,2L,10L,5L,8L,3L,11L,6L,1L,9L,4L,12L,7L,2L,10L,5L,13L,8L,3L,11L };
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
public class A194832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194832Inst : IEnumerable<long>
{
public static readonly long[] Value=A194832.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194832.Bytes);
public long this[int i]=>Value[i];

public static A194832Inst Instance=new A194832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194833
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,4L,8L,10L,7L,9L,12L,14L,11L,13L,15L,18L,20L,16L,19L,21L,17L,24L,27L,22L,25L,28L,23L,26L,32L,35L,30L,33L,36L,31L,34L,29L,40L,44L,38L,42L,45L,39L,43L,37L,41L,49L,53L,47L,51L,55L,48L,52L,46L,50L,54L,60L,64L,57L,62L,66L,59L,63L,56L,61L,65L,58L,71L,76L,68L };
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
public class A194833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194833Inst : IEnumerable<long>
{
public static readonly long[] Value=A194833.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194833.Bytes);
public long this[int i]=>Value[i];

public static A194833Inst Instance=new A194833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194834
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,5L,9L,7L,10L,8L,13L,11L,14L,12L,15L,18L,21L,16L,19L,17L,20L,24L,27L,22L,25L,28L,23L,26L,36L,31L,34L,29L,32L,35L,30L,33L,44L,39L,42L,37L,45L,40L,43L,38L,41L,53L,48L,51L,46L,54L,49L,52L,47L,55L,50L,63L,58L,66L,61L,56L,64L,59L,62L,57L,65L,60L,74L,69L,77L };
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
public class A194834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194834Inst : IEnumerable<long>
{
public static readonly long[] Value=A194834.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194834.Bytes);
public long this[int i]=>Value[i];

public static A194834Inst Instance=new A194834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194835
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,2L,4L,1L,3L,2L,4L,1L,3L,5L,2L,4L,6L,1L,3L,5L,7L,2L,4L,6L,1L,3L,5L,7L,2L,4L,6L,1L,8L,3L,5L,7L,2L,9L,4L,6L,1L,8L,3L,5L,7L,2L,9L,4L,6L,1L,8L,3L,10L,5L,7L,2L,9L,4L,11L,6L,1L,8L,3L,10L,5L,12L,7L,2L,9L,4L,11L,6L,1L,8L,3L,10L,5L,12L,7L,2L,9L,4L,11L,6L,1L,13L,8L,3L,10L,5L,12L,7L,2L };
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
public class A194835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194835Inst : IEnumerable<long>
{
public static readonly long[] Value=A194835.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194835.Bytes);
public long this[int i]=>Value[i];

public static A194835Inst Instance=new A194835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194836
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,6L,9L,7L,10L,8L,13L,11L,14L,12L,15L,19L,16L,20L,17L,21L,18L,26L,23L,27L,24L,28L,25L,22L,33L,30L,35L,31L,36L,32L,29L,34L,42L,38L,44L,40L,45L,41L,37L,43L,39L,51L,47L,53L,49L,55L,50L,46L,52L,48L,54L,62L,57L,64L,59L,66L,61L,56L,63L,58L,65L,60L,74L,69L,76L };
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
public class A194836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194836Inst : IEnumerable<long>
{
public static readonly long[] Value=A194836.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194836.Bytes);
public long this[int i]=>Value[i];

public static A194836Inst Instance=new A194836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194837
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,6L,8L,10L,7L,9L,12L,14L,11L,13L,15L,17L,19L,21L,16L,18L,20L,28L,23L,25L,27L,22L,24L,26L,35L,30L,32L,34L,29L,36L,31L,33L,43L,38L,45L,40L,42L,37L,44L,39L,41L,52L,47L,54L,49L,51L,46L,53L,48L,55L,50L,62L,57L,64L,59L,66L,61L,56L,63L,58L,65L,60L,78L,73L,68L };
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
public class A194837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194837Inst : IEnumerable<long>
{
public static readonly long[] Value=A194837.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194837.Bytes);
public long this[int i]=>Value[i];

public static A194837Inst Instance=new A194837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194838
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,3L,2L,1L,4L,3L,2L,5L,1L,4L,3L,6L,2L,5L,1L,4L,7L,3L,6L,2L,5L,1L,4L,7L,3L,6L,2L,5L,1L,8L,4L,7L,3L,6L,2L,9L,5L,1L,8L,4L,7L,3L,10L,6L,2L,9L,5L,1L,8L,4L,11L,7L,3L,10L,6L,2L,9L,5L,1L,8L,4L,11L,7L,3L,10L,6L,2L,9L,5L,1L,12L,8L,4L,11L,7L,3L,10L,6L,2L,13L,9L,5L,1L,12L,8L,4L,11L,7L,3L };
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
public class A194838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194838Inst : IEnumerable<long>
{
public static readonly long[] Value=A194838.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194838.Bytes);
public long this[int i]=>Value[i];

public static A194838Inst Instance=new A194838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194839
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,9L,8L,7L,10L,14L,12L,11L,15L,13L,20L,18L,16L,21L,19L,17L,27L,25L,23L,28L,26L,24L,22L,34L,32L,30L,36L,33L,31L,29L,35L,43L,40L,38L,45L,42L,39L,37L,44L,41L,53L,50L,47L,55L,52L,49L,46L,54L,51L,48L,64L,61L,58L,66L,63L,60L,57L,65L,62L,59L,56L,75L,72L,69L };
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
public class A194839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194839Inst : IEnumerable<long>
{
public static readonly long[] Value=A194839.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194839.Bytes);
public long this[int i]=>Value[i];

public static A194839Inst Instance=new A194839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194840
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,9L,8L,7L,10L,13L,12L,15L,11L,14L,18L,21L,17L,20L,16L,19L,28L,24L,27L,23L,26L,22L,25L,35L,31L,34L,30L,33L,29L,36L,32L,43L,39L,42L,38L,45L,41L,37L,44L,40L,52L,48L,55L,51L,47L,54L,50L,46L,53L,49L,66L,62L,58L,65L,61L,57L,64L,60L,56L,63L,59L,77L,73L,69L };
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
public class A194840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194840Inst : IEnumerable<long>
{
public static readonly long[] Value=A194840.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194840.Bytes);
public long this[int i]=>Value[i];

public static A194840Inst Instance=new A194840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194841
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,4L,1L,2L,3L,4L,1L,5L,2L,3L,4L,1L,5L,2L,6L,3L,4L,1L,5L,2L,6L,3L,7L,4L,8L,1L,5L,2L,6L,3L,7L,4L,8L,1L,5L,9L,2L,6L,3L,7L,4L,8L,1L,5L,9L,2L,6L,10L,3L,7L,4L,8L,1L,5L,9L,2L,6L,10L,3L,7L,11L,4L,8L,12L,1L,5L,9L,2L,6L,10L,3L,7L,11L,4L,8L,12L,1L,5L,9L,13L,2L,6L,10L,3L,7L,11L,4L,8L,12L };
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
public class A194841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194841Inst : IEnumerable<long>
{
public static readonly long[] Value=A194841.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194841.Bytes);
public long this[int i]=>Value[i];

public static A194841Inst Instance=new A194841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194842
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,7L,12L,14L,15L,11L,13L,17L,19L,21L,16L,18L,20L,23L,25L,27L,22L,24L,26L,28L,31L,33L,35L,29L,32L,34L,36L,30L,39L,42L,44L,37L,40L,43L,45L,38L,41L,48L,51L,54L,46L,49L,52L,55L,47L,50L,53L,58L,61L,64L,56L,59L,62L,65L,57L,60L,63L,66L,70L,73L,76L };
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
public class A194842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194842Inst : IEnumerable<long>
{
public static readonly long[] Value=A194842.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194842.Bytes);
public long this[int i]=>Value[i];

public static A194842Inst Instance=new A194842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194843
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,10L,7L,8L,9L,14L,11L,15L,12L,13L,19L,16L,20L,17L,21L,18L,25L,22L,26L,23L,27L,24L,28L,32L,36L,29L,33L,30L,34L,31L,35L,40L,44L,37L,41L,45L,38L,42L,39L,43L,49L,53L,46L,50L,54L,47L,51L,55L,48L,52L,59L,63L,56L,60L,64L,57L,61L,65L,58L,62L,66L,70L,74L,78L };
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
public class A194843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194843Inst : IEnumerable<long>
{
public static readonly long[] Value=A194843.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194843.Bytes);
public long this[int i]=>Value[i];

public static A194843Inst Instance=new A194843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194844
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,6L,2L,3L,4L,5L,1L,6L,2L,7L,3L,4L,5L,1L,6L,2L,7L,3L,8L,4L,9L,5L,1L,6L,2L,7L,3L,8L,4L,9L,5L,1L,10L,6L,2L,7L,3L,8L,4L,9L,5L,1L,10L,6L,2L,11L,7L,3L,8L,4L,9L,5L,1L,10L,6L,2L,11L,7L,3L,12L,8L,4L,13L,9L,5L,1L,10L,6L,2L,11L,7L,3L,12L,8L,4L,13L,9L,5L };
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
public class A194844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194844Inst : IEnumerable<long>
{
public static readonly long[] Value=A194844.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194844.Bytes);
public long this[int i]=>Value[i];

public static A194844Inst Instance=new A194844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194845
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,14L,15L,11L,17L,19L,20L,21L,16L,18L,23L,25L,27L,28L,22L,24L,26L,30L,32L,34L,36L,29L,31L,33L,35L,39L,41L,43L,45L,38L,40L,42L,44L,37L,48L,51L,53L,55L,47L,50L,52L,54L,46L,49L,58L,61L,64L,66L,57L,60L,63L,65L,56L,59L,62L,69L,72L,75L };
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
public class A194845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194845Inst : IEnumerable<long>
{
public static readonly long[] Value=A194845.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194845.Bytes);
public long this[int i]=>Value[i];

public static A194845Inst Instance=new A194845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194846
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,15L,11L,12L,13L,14L,20L,16L,21L,17L,18L,19L,26L,22L,27L,23L,28L,24L,25L,33L,29L,34L,30L,35L,31L,36L,32L,45L,41L,37L,42L,38L,43L,39L,44L,40L,54L,50L,46L,55L,51L,47L,52L,48L,53L,49L,64L,60L,56L,65L,61L,57L,66L,62L,58L,63L,59L,75L,71L,67L };
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
public class A194846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194846Inst : IEnumerable<long>
{
public static readonly long[] Value=A194846.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194846.Bytes);
public long this[int i]=>Value[i];

public static A194846Inst Instance=new A194846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194847
{
public static readonly long[] Value={ 2L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L };
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
public class A194847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194847Inst : IEnumerable<long>
{
public static readonly long[] Value=A194847.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194847.Bytes);
public long this[int i]=>Value[i];

public static A194847Inst Instance=new A194847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194848
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,2L,3L,3L,3L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,5L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,1L,2L,2L };
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
public class A194848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194848Inst : IEnumerable<long>
{
public static readonly long[] Value=A194848.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194848.Bytes);
public long this[int i]=>Value[i];

public static A194848Inst Instance=new A194848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194849
{
public static readonly long[] Value={ 2L,1L,0L,3L,1L,0L,3L,2L,0L,3L,2L,1L,4L,1L,0L,4L,2L,0L,4L,2L,1L,4L,3L,0L,4L,3L,1L,4L,3L,2L,5L,1L,0L,5L,2L,0L,5L,2L,1L,5L,3L,0L,5L,3L,1L,5L,3L,2L,5L,4L,0L,5L,4L,1L,5L,4L,2L,5L,4L,3L,6L,1L,0L,6L,2L,0L,6L,2L,1L,6L,3L,0L,6L,3L,1L,6L,3L,2L,6L,4L,0L,6L,4L,1L,6L,4L,2L,6L,4L,3L,6L,5L,0L,6L,5L,1L,6L,5L,2L,6L,5L,3L,6L,5L,4L,7L,1L,0L,7L,2L,0L,7L,2L,1L,7L,3L,0L,7L,3L,1L,7L,3L,2L,7L,4L };
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
public class A194849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194849Inst : IEnumerable<long>
{
public static readonly long[] Value=A194849.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194849.Bytes);
public long this[int i]=>Value[i];

public static A194849Inst Instance=new A194849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194850
{
public static readonly long[] Value={ 2L,3L,5L,8L,14L,23L,41L,70L,125L,218L,395L,697L,1273L,2279L,4185L,7568L,13997L,25500L,47414L,87024L,162456L,299947L,562345L,1043212L,1962589L,3657530L,6900717L,12910042L,24427486L,45850670L,86970163L,163756708L,311283363L,587739559L,1119581278L,2119042830L };
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
public class A194850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194850Inst : IEnumerable<long>
{
public static readonly long[] Value=A194850.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194850.Bytes);
public long this[int i]=>Value[i];

public static A194850Inst Instance=new A194850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194851
{
public static readonly long[] Value={ 15L,51L,60L,85L,90L,102L,105L,150L,153L,165L,170L,195L,204L,240L };
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
public class A194851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194851Inst : IEnumerable<long>
{
public static readonly long[] Value=A194851.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194851.Bytes);
public long this[int i]=>Value[i];

public static A194851Inst Instance=new A194851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194852
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,1L,1L,1L,2L,0L,2L,1L,1L,1L,2L,1L,2L,1L,2L,0L,3L,2L,1L,0L,2L,2L,0L,2L,2L,1L,3L,0L,3L,1L,1L,1L,3L,2L,1L,1L,3L,2L,1L,1L,2L,2L,1L,1L,3L,1L,2L,2L,1L,2L,2L,1L,3L,2L,3L,1L,2L,2L,2L,2L,0L,2L,1L,3L,1L,2L,3L,3L,1L,3L,3L,1L,2L,2L,1L,2L,2L,2L,3L,1L,2L,2L,2L };
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
public class A194852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194852Inst : IEnumerable<long>
{
public static readonly long[] Value=A194852.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194852.Bytes);
public long this[int i]=>Value[i];

public static A194852Inst Instance=new A194852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194853
{
public static readonly long[] Value={ 0L,1L,0L,2L,-2L,1L,0L,2L,0L,4L,-1L,2L,-4L,1L,0L,2L,-2L,2L,0L,3L,0L,6L };
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
public class A194853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194853Inst : IEnumerable<long>
{
public static readonly long[] Value=A194853.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194853.Bytes);
public long this[int i]=>Value[i];

public static A194853Inst Instance=new A194853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194854
{
public static readonly long[] Value={ 1L,2L,5L,11L,13L,18L,28L,30L,32L,34L,40L,42L,44L,46L,54L,56L,58L,60L,62L,64L,66L,68L,70L,79L,90L,92L,94L,96L,98L,100L,103L,106L,100L,94L,87L,89L,91L,84L,86L,88L,81L,83L,85L,87L,89L,82L,84L,86L,88L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,104L,107L,110L,113L };
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
public class A194854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194854Inst : IEnumerable<long>
{
public static readonly long[] Value=A194854.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194854.Bytes);
public long this[int i]=>Value[i];

public static A194854Inst Instance=new A194854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194855
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,10L,15L,16L,17L,18L,20L,22L,25L,35L,36L,37L,38L,54L,92L,140L,162L,212L,303L,320L,455L,456L,974L,1028L,1136L,1296L,1297L,1353L,1869L,2215L,2405L,2548L,3065L,3265L,4230L,4410L,5584L,7886L,21420L,23727L,36001L,60662L,85722L,100117L,117094L,173973L };
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
public class A194855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194855Inst : IEnumerable<long>
{
public static readonly long[] Value=A194855.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194855.Bytes);
public long this[int i]=>Value[i];

public static A194855Inst Instance=new A194855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194856
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,5L,4L,3L,2L,6L,1L,5L,4L,3L,7L,2L,6L,1L,5L,4L,8L,3L,7L,2L,6L,1L,5L,4L,8L,3L,7L,2L,6L,1L,5L,9L,4L,8L,3L,7L,2L,6L,10L,1L,5L,9L,4L,8L,3L,7L,11L,2L,6L,10L,1L,5L,9L,4L,8L,12L,3L,7L,11L,2L,6L,10L,1L,5L,9L,4L,8L,12L,3L,7L,11L,2L,6L,10L,1L,5L,9L,13L,4L,8L,12L };
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
public class A194856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194856Inst : IEnumerable<long>
{
public static readonly long[] Value=A194856.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194856.Bytes);
public long this[int i]=>Value[i];

public static A194856Inst Instance=new A194856Inst();

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