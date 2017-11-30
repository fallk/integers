using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A104679
{
public static readonly long[] Value={ 252L,2772L,16632L,72072L,252252L,756756L,2018016L,4900896L,11027016L,23279256L,46558512L,88884432L,162954792L,288304632L,494236512L,823727520L,1338557220L,2125943820L,3307023720L,5047562520L,7571343780L,11176745580L,16257084480L,23325382080L,33044291280L };
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
public class A104679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104679Inst : IEnumerable<long>
{
public static readonly long[] Value=A104679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104679.Bytes);
public long this[int i]=>Value[i];

public static A104679Inst Instance=new A104679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104680
{
public static readonly long[] Value={ 792L,13728L,123552L,772200L,3775200L,15402816L,54609984L,172931616L,498841200L,1330243200L,3316739712L,7801876368L,17439488352L,37263864000L,76488984000L,151448188320L,290275694280L,540192201120L,978609060000L,1729734435000L,2988981103680L,5058275713920L };
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
public class A104680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104680Inst : IEnumerable<long>
{
public static readonly long[] Value=A104680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104680.Bytes);
public long this[int i]=>Value[i];

public static A104680Inst Instance=new A104680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104681
{
public static readonly long[] Value={ -1L,1L,2L,2L,9L,9L,4L,-4L,5L,5L,18L,18L,7L,-7L,8L,8L,27L,27L,10L,-10L,11L,11L,36L,36L,13L,-13L,14L,14L,45L,45L,16L,-16L,17L,17L,54L,54L,19L,-19L,20L,20L,63L,63L,22L,-22L,23L,23L,72L,72L,25L,-25L,26L,26L,81L,81L,28L,-28L,29L,29L,90L,90L,31L,-31L,32L,32L,99L,99L,34L,-34L,35L,35L,108L,108L,37L,-37L,38L,38L,117L,117L,40L,-40L,41L,41L,126L };
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
public class A104681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104681Inst : IEnumerable<long>
{
public static readonly long[] Value=A104681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104681.Bytes);
public long this[int i]=>Value[i];

public static A104681Inst Instance=new A104681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104682
{
public static readonly long[] Value={ 1L,15L,32767L,7174453L,357913941L,7629394531L,94036996915L,791260251657L,5026338869833L,25736391511831L,111111111111111L,417724816941565L,1400638324962397L,4265491084507563L,11966776581370171L,31278135027204241L,76861433640456465L,178901440719363487L };
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
public class A104682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104682Inst : IEnumerable<long>
{
public static readonly long[] Value=A104682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104682.Bytes);
public long this[int i]=>Value[i];

public static A104682Inst Instance=new A104682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104683
{
public static readonly long[] Value={ 1L,1L,5L,7L,29L,41L,169L,239L,985L,1393L,5741L,8119L,33461L,47321L,195025L,275807L,1136689L,1607521L,6625109L,9369319L,38613965L,54608393L,225058681L,318281039L,1311738121L,1855077841L,7645370045L,10812186007L,44560482149L,63018038201L };
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
public class A104683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104683Inst : IEnumerable<long>
{
public static readonly long[] Value=A104683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104683.Bytes);
public long this[int i]=>Value[i];

public static A104683Inst Instance=new A104683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104684
{
public static readonly long[] Value={ 1L,2L,1L,6L,6L,1L,20L,30L,12L,1L,70L,140L,90L,20L,1L,252L,630L,560L,210L,30L,1L,924L,2772L,3150L,1680L,420L,42L,1L,3432L,12012L,16632L,11550L,4200L,756L,56L,1L,12870L,51480L,84084L,72072L,34650L,9240L,1260L,72L,1L,48620L,218790L,411840L,420420L,252252L };
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
public class A104684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104684Inst : IEnumerable<long>
{
public static readonly long[] Value=A104684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104684.Bytes);
public long this[int i]=>Value[i];

public static A104684Inst Instance=new A104684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104685
{
public static readonly long[] Value={ 34L,33L,1333L,13333L,133333L,3323333L,13333333L,303333333L,1333333333L,33133333333L,233333333333L,2333333333333L,13333333333333L,233333333333333L,3331333333333333L,33333133333333333L,133333333333333333L };
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
public class A104685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104685Inst : IEnumerable<long>
{
public static readonly long[] Value=A104685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104685.Bytes);
public long this[int i]=>Value[i];

public static A104685Inst Instance=new A104685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104686
{
public static readonly long[] Value={ 0L,1L,3L,0L,4L,3L,3L,4L,0L,3L,1L,0L,0L,1L,3L,0L,4L,3L,3L,4L,0L,3L,1L,0L,0L,1L,3L,0L,4L,3L,3L,4L,0L,3L,1L,0L,0L,1L,3L,0L,4L,3L,3L,4L,0L,3L,1L,0L,0L,1L,3L,0L,4L,3L,3L,4L,0L,3L,1L,0L,0L,1L,3L,0L,4L,3L,3L,4L,0L,3L,1L,0L,0L,1L,3L,0L,4L,3L,3L,4L,0L,3L,1L,0L,0L,1L,3L };
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
public class A104686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104686Inst : IEnumerable<long>
{
public static readonly long[] Value=A104686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104686.Bytes);
public long this[int i]=>Value[i];

public static A104686Inst Instance=new A104686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104687
{
public static readonly long[] Value={ 3L,0L,7L,5L,6L,0L,8L,8L,2L,7L,0L,3L,7L,0L,8L,1L,5L,4L,1L,1L,2L,4L,3L,0L,2L,3L,2L,5L,0L,3L,4L,6L,7L,0L,1L,4L,2L,2L,8L,3L,0L,1L,8L,8L,4L,1L,0L,6L,1L,5L,9L,5L,5L,0L,3L,1L,3L,6L,6L,0L,9L,5L,4L,5L,9L,4L,9L,8L,3L,6L,0L,5L,2L,2L,0L,3L,4L,6L,8L,1L,1L,6L,8L,7L,4L,7L,1L,3L,1L,1L,2L,5L,5L,7L,6L,1L,3L,1L,6L,7L,9L,5L,5L,5L,7L };
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
public class A104687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104687Inst : IEnumerable<long>
{
public static readonly long[] Value=A104687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104687.Bytes);
public long this[int i]=>Value[i];

public static A104687Inst Instance=new A104687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104688
{
public static readonly long[] Value={ 1L,0L,-2L,-5L,-10L,-18L,-30L,-48L,-77L,-127L,-213L,-351L,-551L,-817L,-1181L,-1819L,-3304L,-7003L,-15454L,-32185L,-59830L,-94733L,-116204L,-70931L,138782L,634477L,1440741L,2129014L,995270L,-6559829L,-30802323L,-91672920L,-223074852L,-473661244L,-893720326L,-1483495634L,-2049478628L };
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
public class A104688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104688Inst : IEnumerable<long>
{
public static readonly long[] Value=A104688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104688.Bytes);
public long this[int i]=>Value[i];

public static A104688Inst Instance=new A104688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104689
{
public static readonly long[] Value={ 1L,4L,2L,0L,3L,7L,0L,1L,1L,8L,0L,2L,0L,0L,8L,3L,4L,5L,8L,4L,5L,8L,4L,2L,1L,2L,8L,3L,8L,9L,9L,7L,7L,2L,9L,8L,0L,5L,8L,6L,4L,2L,7L,3L,3L,6L,7L,6L,4L,8L,9L,5L,2L,3L,6L,3L,2L,7L,4L,6L,4L,0L,1L,1L,6L,2L,9L,9L,7L,5L,2L,1L,4L,0L,1L,4L,0L,0L,6L,3L,3L,5L,8L,5L,5L,7L,3L,4L,3L,4L,6L,9L,7L,1L,3L,9L,7L,4L,4L,9L,8L,6L,2L,6L,4L };
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
public class A104689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104689Inst : IEnumerable<long>
{
public static readonly long[] Value=A104689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104689.Bytes);
public long this[int i]=>Value[i];

public static A104689Inst Instance=new A104689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104690
{
public static readonly long[] Value={ 4L,445L,4414L,44441L,444441L,4444441L,44444441L,444444449L,4444444441L,44444444443L,444444444447L,4444444444443L,44444444444441L,444444444444445L,4444444444444447L,44444444444444447L,444444444444444442L };
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
public class A104690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104690Inst : IEnumerable<long>
{
public static readonly long[] Value=A104690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104690.Bytes);
public long this[int i]=>Value[i];

public static A104690Inst Instance=new A104690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104691
{
public static readonly long[] Value={ 2L,3L,7L,1L,1L,4L,8L,1L,2L,5L,8L,9L,1L,2L,8L,6L,2L,5L,8L,3L,4L,5L,5L,8L,9L,9L,0L,7L,4L,9L,5L,3L,2L,2L,3L,3L,5L,8L,3L,4L,6L,6L,0L,2L,2L,6L,8L,4L,7L,3L,4L,3L,7L,8L,1L,3L,3L,2L,5L,7L,2L,9L,6L,5L,6L,0L,2L,2L,4L,8L,9L,8L,7L,4L,7L,1L,5L,9L,7L,7L,2L,1L,4L,6L,7L,9L,0L,3L,9L,9L,3L,9L,6L,3L,9L,7L,9L,5L,9L,1L,5L,0L,9L,5L,5L };
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
public class A104691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104691Inst : IEnumerable<long>
{
public static readonly long[] Value=A104691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104691.Bytes);
public long this[int i]=>Value[i];

public static A104691Inst Instance=new A104691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104692
{
public static readonly long[] Value={ 2L,4L,6L,10L,14L,16L,20L,22L,24L,29L,30L,32L,35L,36L,38L,40L,41L,42L,44L,50L,52L,60L,61L,62L,63L,64L,65L,66L,70L,74L,80L,86L,88L,90L,92L,94L,96L,100L,102L,104L,107L,112L,113L,114L,116L,118L,120L,122L,123L,124L,126L,127L,129L,130L,131L,132L,134L,135L };
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
public class A104692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104692Inst : IEnumerable<long>
{
public static readonly long[] Value=A104692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104692.Bytes);
public long this[int i]=>Value[i];

public static A104692Inst Instance=new A104692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104693
{
public static readonly long[] Value={ 1L,5L,7L,8L,9L,11L,13L,15L,17L,23L,25L,26L,27L,28L,31L,33L,34L,37L,39L,43L,45L,46L,48L,49L,51L,55L,56L,57L,58L,59L,71L,73L,77L,79L,81L,82L,83L,91L,95L,97L,98L,99L,101L,103L,105L,106L,108L,109L,110L,111L,115L,117L,119L,121L,125L,128L,133L,136L,137L,146L,147L };
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
public class A104693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104693Inst : IEnumerable<long>
{
public static readonly long[] Value=A104693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104693.Bytes);
public long this[int i]=>Value[i];

public static A104693Inst Instance=new A104693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104694
{
public static readonly long[] Value={ 2L,3L,1L,4L,12L,5L,6L,18L,7L,10L,19L,8L,14L,21L,9L,16L,47L,11L,20L,53L,13L,22L,54L,15L,24L,67L,17L,29L,68L,23L,30L,69L,25L,32L,72L,26L,35L,75L,27L,36L,76L,28L,38L,78L,31L,40L,84L,33L,41L,85L,34L,42L,87L,37L,44L,89L,39L,50L,93L,43L };
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
public class A104694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104694Inst : IEnumerable<long>
{
public static readonly long[] Value=A104694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104694.Bytes);
public long this[int i]=>Value[i];

public static A104694Inst Instance=new A104694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104695
{
public static readonly long[] Value={ 3L,1L,2L,4L,6L,7L,9L,12L,15L,10L,18L,5L,21L,13L,24L,16L,27L,8L,11L,19L,14L,22L,30L,25L,33L,36L,39L,42L,28L,31L,45L,34L,48L,51L,37L,40L,54L,43L,57L,46L,49L,52L,60L,55L };
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
public class A104695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104695Inst : IEnumerable<long>
{
public static readonly long[] Value=A104695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104695.Bytes);
public long this[int i]=>Value[i];

public static A104695Inst Instance=new A104695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104696
{
public static readonly long[] Value={ 9L,2L,7L,4L,5L,6L,3L,8L,1L,90L,99L,92L,97L,94L,95L,96L,93L,98L,91L,20L,29L,22L,27L,24L,25L,26L,23L,28L,21L,70L,79L,72L,77L,74L,75L,76L,73L,78L,71L,40L,49L,42L,47L,44L,45L,46L,43L,48L,41L,50L,59L,52L,57L,54L,55L,56L,53L,58L,51L,60L,69L,62L,67L,64L,65L,66L,63L,68L,61L,30L,39L,32L };
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
public class A104696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104696Inst : IEnumerable<long>
{
public static readonly long[] Value=A104696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104696.Bytes);
public long this[int i]=>Value[i];

public static A104696Inst Instance=new A104696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104697
{
public static readonly long[] Value={ 1L,8L,3L,6L,5L,4L,7L,2L,9L,20L,11L,18L,13L,16L,15L,14L,17L,12L,19L,90L,81L,88L,83L,86L,85L,84L,87L,82L,89L,40L,31L,38L,33L,36L,35L,34L,37L,32L,39L,70L,61L,68L,63L,66L,65L,64L,67L,62L,69L,60L,51L,58L,53L,56L,55L,54L,57L,52L,59L,50L,41L,48L,43L,46L,45L,44L,47L,42L,49L,80L,71L,78L };
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
public class A104697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104697Inst : IEnumerable<long>
{
public static readonly long[] Value=A104697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104697.Bytes);
public long this[int i]=>Value[i];

public static A104697Inst Instance=new A104697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104698
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,9L,6L,1L,5L,16L,19L,8L,1L,6L,25L,44L,33L,10L,1L,7L,36L,85L,96L,51L,12L,1L,8L,49L,146L,225L,180L,73L,14L,1L,9L,64L,231L,456L,501L,304L,99L,16L,1L,10L,81L,344L,833L,1182L,985L,476L,129L,18L,1L,11L,100L,489L,1408L,2471L,2668L,1765L,704L,163L,20L,1L,12L };
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
public class A104698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104698Inst : IEnumerable<long>
{
public static readonly long[] Value=A104698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104698.Bytes);
public long this[int i]=>Value[i];

public static A104698Inst Instance=new A104698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104699
{
public static readonly long[] Value={ 2731L,5462L,10923L,10924L,13655L,21846L,21848L,27307L,27310L,43691L,43692L,43696L,54614L,54615L,54620L,71003L,87382L,87384L,87392L,92843L,109227L,109228L,109230L,109240L,133819L,142006L,152919L,174763L,174764L,174768L };
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
public class A104699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104699Inst : IEnumerable<long>
{
public static readonly long[] Value=A104699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104699.Bytes);
public long this[int i]=>Value[i];

public static A104699Inst Instance=new A104699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104700
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,4L,8L,12L,96L,108L,10368L,10476L,108615168L,108625644L };
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
public class A104700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104700Inst : IEnumerable<long>
{
public static readonly long[] Value=A104700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104700.Bytes);
public long this[int i]=>Value[i];

public static A104700Inst Instance=new A104700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104701
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,13L,9L,10L,9L,9L,18L,10L,8L,8L,16L,9L,10L,9L,9L,18L,10L,8L,8L,16L };
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
public class A104701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104701Inst : IEnumerable<long>
{
public static readonly long[] Value=A104701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104701.Bytes);
public long this[int i]=>Value[i];

public static A104701Inst Instance=new A104701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104702
{
public static readonly long[] Value={ 1L,3L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,23L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,41L,43L,51L,53L,61L,63L,81L,83L };
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
public class A104702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104702Inst : IEnumerable<long>
{
public static readonly long[] Value=A104702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104702.Bytes);
public long this[int i]=>Value[i];

public static A104702Inst Instance=new A104702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104703
{
public static readonly long[] Value={ 7L,9L,27L,29L,47L,49L,57L,59L,67L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,87L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L };
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
public class A104703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104703Inst : IEnumerable<long>
{
public static readonly long[] Value=A104703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104703.Bytes);
public long this[int i]=>Value[i];

public static A104703Inst Instance=new A104703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104704
{
public static readonly long[] Value={ 2L,4L,5L,6L,8L,20L,22L,24L,25L,26L,28L,40L,42L,44L,45L,46L,48L,50L,52L,54L,55L,56L,58L,60L,62L,64L,65L,66L,68L,80L,82L,84L,85L,86L,88L };
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
public class A104704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104704Inst : IEnumerable<long>
{
public static readonly long[] Value=A104704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104704.Bytes);
public long this[int i]=>Value[i];

public static A104704Inst Instance=new A104704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104705
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,2L,1L,5L,6L,1L,2L,3L,1L,7L,2L,1L,8L,4L,1L,2L,3L,1L,9L,2L,1L,10L,11L,1L,2L,3L,1L,12L,2L,1L,4L,5L,1L,2L,3L,1L,13L,2L,1L,14L,6L,1L,2L,3L,1L,4L,2L,1L,15L,16L,1L,2L,3L,1L,17L,2L,1L,18L,4L,1L,2L,3L,1L,5L,2L,1L,7L,19L,1L,2L,3L,1L,20L,2L,1L,4L,8L,1L,2L,3L,1L,6L,2L,1L,21L,22L,1L,2L,3L,1L,4L,2L,1L,5L,23L };
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
public class A104705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104705Inst : IEnumerable<long>
{
public static readonly long[] Value=A104705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104705.Bytes);
public long this[int i]=>Value[i];

public static A104705Inst Instance=new A104705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104706
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,5L,1L,2L,6L,1L,7L,3L,1L,2L,8L,1L,9L,4L,1L,2L,10L,1L,3L,11L,1L,2L,5L,1L,12L,13L,1L,2L,3L,1L,4L,6L,1L,2L,14L,1L,15L,3L,1L,2L,7L,1L,5L,4L,1L,2L,16L,1L,3L,17L,1L,2L,8L,1L,18L,6L,1L,2L,3L,1L,4L,19L,1L,2L,5L,1L,9L,3L,1L,2L,20L,1L,21L,4L,1L,2L,7L,1L,3L,10L,1L,2L,22L,1L,5L,6L,1L,2L,3L,1L,4L,23L,1L };
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
public class A104706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104706Inst : IEnumerable<long>
{
public static readonly long[] Value=A104706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104706.Bytes);
public long this[int i]=>Value[i];

public static A104706Inst Instance=new A104706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104707
{
public static readonly long[] Value={ 1L,25L,1L,81L,20L,1L,25L,54L,15L,1L,100L,15L,36L,15L,1L,256L,60L,10L,27L,10L,1L,25L,128L,30L,5L,27L,10L,1L,100L,10L,64L,30L,5L,18L,10L,1L,81L,40L,5L,32L,10L,5L,9L,5L,1L,25L,27L,10L,0L,32L,10L,0L,9L,5L,1L,1L,5L,9L,10L,5L,16L,10L,5L,9L,5L,1L };
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
public class A104707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104707Inst : IEnumerable<long>
{
public static readonly long[] Value=A104707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104707.Bytes);
public long this[int i]=>Value[i];

public static A104707Inst Instance=new A104707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104708
{
public static readonly long[] Value={ 1L,1L,4L,12L,50L,182L,836L,3480L,16808L,78600L,398832L,1998976L,10791704L,57418904L,322714800L,1821518336L,10673756016L,62904395664L,383965822240L,2356753705600L,14896682388192L,95002532773632L,620122408189824L };
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
public class A104708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104708Inst : IEnumerable<long>
{
public static readonly long[] Value=A104708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104708.Bytes);
public long this[int i]=>Value[i];

public static A104708Inst Instance=new A104708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104709
{
public static readonly long[] Value={ 1L,3L,1L,7L,4L,1L,15L,11L,5L,1L,31L,26L,16L,6L,1L,63L,57L,42L,22L,7L,1L,127L,120L,99L,64L,29L,8L,1L,255L,247L,219L,163L,93L,37L,9L,1L,511L,502L,466L,382L,256L,130L,46L,10L,1L,1023L,1013L,968L,848L,638L,386L,176L,56L,11L,1L,2047L,2036L,1981L,1816L,1486L,1024L,562L,232L,67L };
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
public class A104709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104709Inst : IEnumerable<long>
{
public static readonly long[] Value=A104709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104709.Bytes);
public long this[int i]=>Value[i];

public static A104709Inst Instance=new A104709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104710
{
public static readonly long[] Value={ 1L,2L,1L,5L,4L,1L,14L,13L,7L,1L,42L,41L,31L,11L,1L,132L,131L,116L,66L,16L,1L,429L,428L,407L,302L,127L,22L,1L,1430L,1429L,1401L,1205L,715L,225L,29L,1L,4862L,4861L,4825L,4489L,3313L,1549L,373L,37L,1L,16796L,16795L,16750L,16210L,13690L,8398L,3106L,586L,46L,1L };
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
public class A104710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104710Inst : IEnumerable<long>
{
public static readonly long[] Value=A104710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104710.Bytes);
public long this[int i]=>Value[i];

public static A104710Inst Instance=new A104710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104711
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,10L,7L,1L,5L,20L,27L,11L,1L,6L,35L,77L,61L,16L,1L,7L,56L,182L,236L,121L,22L,1L,8L,84L,378L,726L,611L,218L,29L,1L,9L,120L,714L,1902L,2375L,1394L,365L,37L,1L,10L,165L,1254L,4422L,7667L,6686L,2885L,577L,46L,1L,11L,220L,2079L,9372L,21527L,26090L,16745L };
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
public class A104711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104711Inst : IEnumerable<long>
{
public static readonly long[] Value=A104711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104711.Bytes);
public long this[int i]=>Value[i];

public static A104711Inst Instance=new A104711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104712
{
public static readonly long[] Value={ 1L,3L,1L,6L,4L,1L,10L,10L,5L,1L,15L,20L,15L,6L,1L,21L,35L,35L,21L,7L,1L,28L,56L,70L,56L,28L,8L,1L,36L,84L,126L,126L,84L,36L,9L,1L,45L,120L,210L,252L,210L,120L,45L,10L,1L,55L,165L,330L,462L,462L,330L,165L,55L,11L,1L,66L,220L,495L,792L,924L,792L,495L,220L,66L,12L,1L,78L,286L,715L };
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
public class A104712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104712Inst : IEnumerable<long>
{
public static readonly long[] Value=A104712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104712.Bytes);
public long this[int i]=>Value[i];

public static A104712Inst Instance=new A104712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104713
{
public static readonly long[] Value={ 1L,4L,1L,10L,5L,1L,20L,15L,6L,1L,35L,35L,21L,7L,1L,56L,70L,56L,28L,8L,1L,84L,126L,126L,84L,36L,9L,1L,120L,210L,252L,210L,120L,45L,10L,1L,165L,330L,462L,462L,330L,165L,55L,11L,1L,220L,495L,792L,924L,792L,495L,220L,66L,12L,1L,286L,715L,1287L,1716L };
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
public class A104713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104713Inst : IEnumerable<long>
{
public static readonly long[] Value=A104713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104713.Bytes);
public long this[int i]=>Value[i];

public static A104713Inst Instance=new A104713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104714
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,5L,2L,1L,1L,1L,5L,1L,12L,1L,1L,5L,1L,1L,2L,1L,5L,1L,1L,1L,24L,25L,1L,1L,1L,1L,10L,1L,1L,1L,1L,5L,36L,1L,1L,1L,5L,1L,2L,1L,1L,5L,1L,1L,48L,1L,25L,1L,1L,1L,2L,5L,7L,1L,1L,1L,60L,1L,1L,1L,1L,5L,2L,1L,1L,1L,5L,1L,72L,1L,1L,25L,1L,1L,2L,1L,5L,1L,1L,1L,12L,5L,1L,1L,1L,1L,10L,13L,1L,1L,1L,5L,96L,1L };
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
public class A104714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104714Inst : IEnumerable<long>
{
public static readonly long[] Value=A104714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104714.Bytes);
public long this[int i]=>Value[i];

public static A104714Inst Instance=new A104714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104715
{
public static readonly long[] Value={ 1L,3L,3L,6L,9L,5L,10L,18L,15L,7L,15L,30L,30L,21L,9L,21L,45L,50L,42L,27L,11L,28L,63L,75L,70L,54L,33L,13L,36L,84L,105L,105L,90L,66L,39L,15L,45L,108L,140L,147L,135L,110L,78L,45L,17L,55L,135L,180L,196L,189L,165L,130L,90L,51L,19L,66L,165L };
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
public class A104715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104715Inst : IEnumerable<long>
{
public static readonly long[] Value=A104715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104715.Bytes);
public long this[int i]=>Value[i];

public static A104715Inst Instance=new A104715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104716
{
public static readonly long[] Value={ 1L,7L,3L,22L,13L,5L,50L,34L,19L,7L,95L,70L,46L,25L,9L,161L,125L,90L,58L,31L,11L,252L,203L,155L,110L,70L,37L,13L,372L,308L,245L,185L,130L,82L,43L,15L,525L,444L,364L,287L,215L,150L,94L,49L,17L,715L,615L,516L,420L,329L,245L,170L,106L,55L,19L,946L,825L,705L,588L,476L,371L,275L,190L,118L,61L,21L };
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
public class A104716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104716Inst : IEnumerable<long>
{
public static readonly long[] Value=A104716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104716.Bytes);
public long this[int i]=>Value[i];

public static A104716Inst Instance=new A104716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104717
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,5L,6L,7L,1L,2L,8L,9L,1L,10L,3L,11L,1L,2L,12L,13L,1L,4L,14L,15L,1L,2L,16L,3L,1L,5L,17L,18L,1L,2L,19L,6L,1L,20L,4L,3L,1L,2L,21L,22L,1L,7L,23L,24L,1L,2L,25L,5L,1L,3L,8L,26L,1L,2L,4L,27L,1L,28L,9L,29L,1L,2L,3L,6L,1L,30L,31L,10L,1L,2L,32L,4L,1L,5L,3L,33L,1L,2L,34L,7L,1L,11L,35L,36L,1L,2L };
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
public class A104717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104717Inst : IEnumerable<long>
{
public static readonly long[] Value=A104717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104717.Bytes);
public long this[int i]=>Value[i];

public static A104717Inst Instance=new A104717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104718
{
public static readonly long[] Value={ 311L,513L,1119L,2331L,2937L,5361L,5967L,7179L,8997L,101109L,131139L,149157L,173181L,191199L,233241L,263271L,269277L,359367L,389397L,401409L,431439L,449457L,479487L,491499L,563571L,569577L,593601L,599607L,653661L,683691L,701709L,719727L,743751L };
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
public class A104718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104718Inst : IEnumerable<long>
{
public static readonly long[] Value=A104718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104718.Bytes);
public long this[int i]=>Value[i];

public static A104718Inst Instance=new A104718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104719
{
public static readonly long[] Value={ 313L,717L,1323L,1929L,3141L,3747L,4353L,6171L,7383L,7989L,97107L,103113L,127137L,139149L,157167L,163173L,181191L,223233L,229239L,241251L,271281L,283293L,307317L,337347L,349359L,373383L,379389L,409419L,421431L,433443L,439449L,457467L,499509L };
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
public class A104719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104719Inst : IEnumerable<long>
{
public static readonly long[] Value=A104719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104719.Bytes);
public long this[int i]=>Value[i];

public static A104719Inst Instance=new A104719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104720
{
public static readonly long[] Value={ 1L,11L,112L,1122L,11223L,112233L,1122334L,11223344L,112233445L,1122334455L,11223344556L,112233445566L,1122334455667L,11223344556677L,112233445566778L,1122334455667788L,11223344556677889L,112233445566778899L,1122334455667789000L };
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
public class A104720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104720Inst : IEnumerable<long>
{
public static readonly long[] Value=A104720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104720.Bytes);
public long this[int i]=>Value[i];

public static A104720Inst Instance=new A104720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104721
{
public static readonly long[] Value={ 1L,2L,5L,8L,20L,32L,80L,128L,320L,512L,1280L,2048L,5120L,8192L,20480L,32768L,81920L,131072L,327680L,524288L,1310720L,2097152L,5242880L,8388608L,20971520L,33554432L,83886080L,134217728L,335544320L,536870912L,1342177280L,2147483648L };
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
public class A104721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104721Inst : IEnumerable<long>
{
public static readonly long[] Value=A104721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104721.Bytes);
public long this[int i]=>Value[i];

public static A104721Inst Instance=new A104721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104722
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,10L,19L,28L,56L,84L,174L,264L,561L,858L,1859L,2860L,6292L,9724L,21658L,33592L,75582L,117572L,266798L,416024L,950912L,1485800L,3417340L,5348880L,12369285L,19389690L,45052515L,70715340L,165002460L,259289580L,607283490L };
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
public class A104722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104722Inst : IEnumerable<long>
{
public static readonly long[] Value=A104722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104722.Bytes);
public long this[int i]=>Value[i];

public static A104722Inst Instance=new A104722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104723
{
public static readonly long[] Value={ 0L,1L,0L,2L,4L,10L,18L,42L,80L,168L,330L,682L,1340L,2730L,5418L,10910L,21760L,43690L,87192L,174762L,349180L,699006L,1397418L,2796202L,5590960L,11184800L,22366890L,44739072L,89473020L,178956970L,357902670L,715827882L,1431633920L,2863310846L };
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
public class A104723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104723Inst : IEnumerable<long>
{
public static readonly long[] Value=A104723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104723.Bytes);
public long this[int i]=>Value[i];

public static A104723Inst Instance=new A104723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104724
{
public static readonly long[] Value={ 15L,55L,1555L,50555L,505555L,1555555L,55255555L,355555555L,5155555555L,52555555555L,155555555555L,1555555555555L,25555555555555L,155555555555555L,5155555555555555L,25555555555555555L,505555555555555555L };
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
public class A104724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104724Inst : IEnumerable<long>
{
public static readonly long[] Value=A104724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104724.Bytes);
public long this[int i]=>Value[i];

public static A104724Inst Instance=new A104724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104725
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,3L,1L,5L,2L,3L,1L,11L,1L,3L,3L,15L,1L,11L,1L,11L,3L,3L,1L,45L,2L,3L,5L,11L,1L,19L,1L,52L,3L,3L,3L,62L,1L,3L,3L,45L,1L,19L,1L,11L,11L,3L,1L,200L,2L,11L,3L,11L,1L,45L,3L,45L,3L,3L,1L,113L,1L,3L,11L,203L,3L,19L,1L,11L,3L,19L,1L,355L,1L,3L,11L,11L,3L,19L,1L,200L,15L,3L,1L,113L,3L };
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
public class A104725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104725Inst : IEnumerable<long>
{
public static readonly long[] Value=A104725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104725.Bytes);
public long this[int i]=>Value[i];

public static A104725Inst Instance=new A104725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104726
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,3L,3L,1L,5L,5L,5L,4L,1L,8L,8L,8L,8L,5L,1L,13L,13L,13L,13L,12L,6L,1L,21L,21L,21L,21L,21L,17L,7L,1L,34L,34L,34L,34L,34L,33L,23L,8L,1L,55L,55L,55L,55L,55L,55L,50L,30L,9L,1L,89L,89L,89L,89L,89L,89L,88L,73L,38L };
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
public class A104726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104726Inst : IEnumerable<long>
{
public static readonly long[] Value=A104726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104726.Bytes);
public long this[int i]=>Value[i];

public static A104726Inst Instance=new A104726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104727
{
public static readonly long[] Value={ 1L,7L,3L,25L,15L,6L,65L,45L,26L,10L,140L,105L,71L,40L,15L,266L,210L,155L,103L,57L,21L,462L,378L,295L,215L,141L,77L,28L,750L,630L,511L,395L,285L,185L,100L,36L,1155L,990L,826L,665L,510L,365L,235L,126L,45L,1705L,1485L,1266L,1050L,840L,640L,455L,291L,155L,55L,2431L,2145L,1860L,1578L,1302L,1036L,785L,555L,353L,187L,66L,3367L,3003L };
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
public class A104727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104727Inst : IEnumerable<long>
{
public static readonly long[] Value=A104727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104727.Bytes);
public long this[int i]=>Value[i];

public static A104727Inst Instance=new A104727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104728
{
public static readonly long[] Value={ 1L,9L,4L,30L,18L,7L,70L,48L,27L,10L,135L,100L,66L,36L,13L,231L,180L,130L,84L,45L,16L,364L,294L,225L,160L,102L,54L,19L,540L,448L,357L,270L,190L,120L,63L,22L,765L,648L,532L,420L,315L,220L,138L,72L,25L,1045L,900L,756L,616L,483L,360L,250L,156L,81L,28L,1386L,1210L,1035L,864L,700L,546L,405L,280L,174L,90L,31L };
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
public class A104728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104728Inst : IEnumerable<long>
{
public static readonly long[] Value=A104728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104728.Bytes);
public long this[int i]=>Value[i];

public static A104728Inst Instance=new A104728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104729
{
public static readonly long[] Value={ 6L,166L,4666L,46666L,616666L,5666666L,62666666L,166666666L,6466666666L,46666666666L,666626666666L,6666566666666L,66266666666666L,646666666666666L,2666666666666666L,46666666666666666L,666566666666666666L };
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
public class A104729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104729Inst : IEnumerable<long>
{
public static readonly long[] Value=A104729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104729.Bytes);
public long this[int i]=>Value[i];

public static A104729Inst Instance=new A104729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104730
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,4L,5L,1L,1L,5L,10L,7L,1L,1L,6L,15L,19L,9L,1L,1L,7L,21L,35L,31L,11L };
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
public class A104730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104730Inst : IEnumerable<long>
{
public static readonly long[] Value=A104730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104730.Bytes);
public long this[int i]=>Value[i];

public static A104730Inst Instance=new A104730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104731
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,3L,1L,5L,11L,4L,1L,5L,16L,19L,5L,1L,5L,16L,37L,29L,6L,1L,5L,16L,44L,71L,41L,7L,1L,5L,16L,44L,103L,121L,55L,8L,1L,5L,16L,44L,112L,211L,190L,71L,9L,1L,5L,16L,44L,112L,261L,390L,281L,89L,10L,1L,5L,16L,44L,112L,272L,555L,666L,397L,109L,11L };
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
public class A104731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104731Inst : IEnumerable<long>
{
public static readonly long[] Value=A104731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104731.Bytes);
public long this[int i]=>Value[i];

public static A104731Inst Instance=new A104731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104732
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,1L,4L,5L,4L,1L,5L,7L,8L,5L,1L,6L,9L,12L,12L,6L,1L,7L,11L,16L,20L,17L,7L,1L,8L,13L,20L,28L,32L,23L,8L,1L,9L,15L,24L,36L,48L,49L,30L,9L,1L,10L,17L,28L,44L,64L,80L,72L,38L,10L,1L,11L,19L,32L,52L,80L,112L,129L,102L,47L,11L,1L,12L,21L,36L,60L,96L,144L,192L,201L,140L,57L,12L,1L };
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
public class A104732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104732Inst : IEnumerable<long>
{
public static readonly long[] Value=A104732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104732.Bytes);
public long this[int i]=>Value[i];

public static A104732Inst Instance=new A104732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104733
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,2L,7L,4L,4L,3L,12L,7L,8L,6L,5L,20L,12L,14L,12L,10L,8L,33L,20L,24L,21L,20L,16L,13L,54L,33L,40L,36L,35L,32L,26L,21L,88L,54L,66L,60L,60L,56L,52L,42L,34L,143L,88L,108L,99L,100L,96L,91L,84L,68L,55L,232L,143L,176L,162L,165L,160L,156L,147L,136L,110L,89L };
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
public class A104733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104733Inst : IEnumerable<long>
{
public static readonly long[] Value=A104733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104733.Bytes);
public long this[int i]=>Value[i];

public static A104733Inst Instance=new A104733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104734
{
public static readonly long[] Value={ 1L,3L,1L,5L,4L,1L,7L,8L,5L,1L,9L,12L,12L,6L,1L,11L,16L,20L,17L,7L,1L,13L,20L,28L,32L,23L,8L,1L,15L,24L,36L,48L,49L,30L,9L,1L,17L,28L,44L,64L,80L,72L,38L,10L,1L,19L,32L,52L,80L,112L,129L,102L,47L,11L,1L,21L,36L,60L,96L,144L,192L,201L,140L,57L,12L,1L,23L,40L,68L,112L,176L,256L,321L,303L,187L,68L,13L,1L,25L,44L,76L,128L,208L,320L,448L,522L,443L,244L,80L,14L,1L };
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
public class A104734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104734Inst : IEnumerable<long>
{
public static readonly long[] Value=A104734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104734.Bytes);
public long this[int i]=>Value[i];

public static A104734Inst Instance=new A104734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104735
{
public static readonly long[] Value={ 2L,3L,5L,13L,19L,23L,37L,41L,43L,53L,61L,67L,71L,79L,89L,109L,131L,137L,139L,157L,167L,173L,199L,211L,227L,233L,239L,241L,269L,271L,277L,307L,311L,313L,331L,337L,349L,379L,383L,389L,397L,409L,433L,443L,449L,461L,463L,509L,523L,547L,557L,569L,571L,593L,599L,601L };
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
public class A104735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104735Inst : IEnumerable<long>
{
public static readonly long[] Value=A104735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104735.Bytes);
public long this[int i]=>Value[i];

public static A104735Inst Instance=new A104735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104736
{
public static readonly long[] Value={ 2L,3L,5L,23L,41L,43L,61L,67L,89L,131L,137L,139L,157L,173L,199L,227L,241L,269L,311L,313L,331L,337L,379L,397L,409L,443L,449L,461L,463L,557L,571L,593L,599L,601L,607L,647L,683L,751L,797L,821L,827L,881L,883L,911L,953L,977L };
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
public class A104736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104736Inst : IEnumerable<long>
{
public static readonly long[] Value=A104736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104736.Bytes);
public long this[int i]=>Value[i];

public static A104736Inst Instance=new A104736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104737
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,9L,14L,17L,23L,26L,27L,32L,41L,44L,53L,54L,59L,62L,72L,77L,89L,90L,99L,104L,113L,116L,117L,134L,135L,143L,152L,161L,171L,176L,179L,189L,194L,206L,212L,224L,225L,233L,251L,252L,261L,266L,270L,284L,302L,314L,323L,324L,329L,332L,342L,347L,360L };
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
public class A104737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104737Inst : IEnumerable<long>
{
public static readonly long[] Value=A104737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104737.Bytes);
public long this[int i]=>Value[i];

public static A104737Inst Instance=new A104737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104738
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,11L,15L,17L,21L,24L,29L,30L,39L,41L,51L,54L,59L,66L,75L,77L,87L,96L,105L,107L,120L,129L,137L,141L,161L,165L,180L,186L,201L,209L,221L,227L,249L,255L,270L,285L,306L,311L,324L,336L,359L,366L,390L,401L,420L,435L,459L,465L,495L,501L,527L,534L };
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
public class A104738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104738Inst : IEnumerable<long>
{
public static readonly long[] Value=A104738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104738.Bytes);
public long this[int i]=>Value[i];

public static A104738Inst Instance=new A104738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104739
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,11L,12L,14L,16L,19L,20L,23L,24L,27L,31L,32L,35L,38L,43L,44L,47L,48L,51L,56L,60L,62L,64L,70L,71L,75L,80L,83L,87L,88L,91L,96L,103L,107L,110L,111L,115L,123L,124L,127L,135L,139L,140L,147L,148L,152L,163L,164L,166L,174L,179L,180L,184L,188L,192L };
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
public class A104739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104739Inst : IEnumerable<long>
{
public static readonly long[] Value=A104739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104739.Bytes);
public long this[int i]=>Value[i];

public static A104739Inst Instance=new A104739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104740
{
public static readonly long[] Value={ 1L,3L,1L,3L,1L,3L,1L,3L,2L,6L,3L,9L,4L,12L,6L,18L,9L,27L,14L,42L,21L,63L,31L,93L,47L,141L,70L,210L,105L,315L,158L,474L,237L,711L,355L,1065L,533L,1599L,799L,2397L,1199L,3597L,1798L,5394L,2697L,8091L,4046L,12138L,6069L,18207L,9103L,27309L,13655L,40965L,20482L,61446L };
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
public class A104740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104740Inst : IEnumerable<long>
{
public static readonly long[] Value=A104740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104740.Bytes);
public long this[int i]=>Value[i];

public static A104740Inst Instance=new A104740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104741
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,5L,3L,2L,1L,6L,7L,4L,8L,9L,10L,11L,5L,3L,2L,1L,12L,13L,6L,14L,15L,16L,17L,7L,4L,18L,19L,8L,20L,21L,22L,23L,9L,24L,25L,26L,27L,28L,29L,10L,30L,31L,11L,5L,3L,2L,1L,32L,33L,34L,35L,36L,37L,12L,38L,39L,40L,41L,13L,6L,42L,43L,14L,44L,45L,46L,47L,15L,48L,49L,50L,51L,52L,53L };
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
public class A104741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104741Inst : IEnumerable<long>
{
public static readonly long[] Value=A104741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104741.Bytes);
public long this[int i]=>Value[i];

public static A104741Inst Instance=new A104741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104742
{
public static readonly BigInteger[] Value={ 1485L,113256L,5008230L,167808024L,4721384790L,117593590752L,2675326679856L,56740864304592L,1137757854901806L,21789659909226960L,401602392805341924L,7165100439281414160L,BigInteger.Parse("124314235272290304540"),BigInteger.Parse("2105172926498512761984"),BigInteger.Parse("34899691847703927826500"),BigInteger.Parse("567797719808735191344672"),BigInteger.Parse("9084445205688065541367710") };
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
public class A104742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104742.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104742Inst Instance=new A104742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104743
{
public static readonly long[] Value={ 1L,4L,11L,30L,85L,248L,735L,2194L,6569L,19692L,59059L,177158L,531453L,1594336L,4782983L,14348922L,43046737L,129140180L,387420507L,1162261486L,3486784421L,10460353224L,31381059631L,94143178850L,282429536505L,847288609468L };
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
public class A104743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104743Inst : IEnumerable<long>
{
public static readonly long[] Value=A104743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104743.Bytes);
public long this[int i]=>Value[i];

public static A104743Inst Instance=new A104743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104744
{
public static readonly long[] Value={ 470L,1000L,1678L,2445L,3265L,4120L,5000L,5897L,6808L,7729L,8659L,9595L,10537L,11483L,12434L,13388L,14345L,15305L,16267L,17231L,18197L,19165L,20134L,21105L,22077L,23050L,24025L,25000L,25976L,26953L,27931L };
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
public class A104744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104744Inst : IEnumerable<long>
{
public static readonly long[] Value=A104744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104744.Bytes);
public long this[int i]=>Value[i];

public static A104744Inst Instance=new A104744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104745
{
public static readonly long[] Value={ 1L,6L,27L,128L,629L,3130L,15631L,78132L,390633L,1953134L,9765635L,48828136L,244140637L,1220703138L,6103515639L,30517578140L,152587890641L,762939453142L,3814697265643L,19073486328144L,95367431640645L,476837158203146L };
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
public class A104745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104745Inst : IEnumerable<long>
{
public static readonly long[] Value=A104745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104745.Bytes);
public long this[int i]=>Value[i];

public static A104745Inst Instance=new A104745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104746
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,7L,1L,5L,12L,15L,1L,6L,17L,32L,31L,1L,7L,22L,49L,80L,63L,1L,8L,27L,66L,129L,192L,127L,1L,9L,32L,83L,178L,321L,448L,255L,1L,10L,37L,100L,227L,450L,769L,1024L,511L,1L,11L,42L,117L,276L,579L,1090L,1793L,2304L,1023L,1L,12L,47L,134L,325L,708L,1411L,2562L,4097L,5120L,2047L,1L,13L,52L,151L,374L,837L };
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
public class A104746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104746Inst : IEnumerable<long>
{
public static readonly long[] Value=A104746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104746.Bytes);
public long this[int i]=>Value[i];

public static A104746Inst Instance=new A104746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104747
{
public static readonly long[] Value={ 1L,4L,12L,33L,87L,222L,550L,1327L,3129L,7236L,16464L,36957L,82027L,180346L,393354L,852123L,1835181L,3932352L,8388820L,17826025L,37748991L,79692054L,167772462L,352321863L,738197857L,1543504252L,3221225880L,6710886837L };
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
public class A104747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104747Inst : IEnumerable<long>
{
public static readonly long[] Value=A104747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104747.Bytes);
public long this[int i]=>Value[i];

public static A104747Inst Instance=new A104747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104748
{
public static readonly long[] Value={ 6L,4L,1L,1L,8L,5L,7L,4L,4L,5L,0L,4L,9L,8L,5L,9L,8L,4L,4L,8L,6L,2L,0L,0L,4L,8L,2L,1L,1L,4L,8L,2L,3L,6L,6L,6L,5L,6L,2L,8L,2L,0L,9L,5L,7L,1L,9L,1L,1L,0L,1L,7L,5L,5L,1L,3L,9L,6L,9L,8L,7L,9L,7L,5L,4L,3L,4L,8L,7L,4L,9L,1L,8L,7L,8L,7L,9L,9L,7L,6L,2L,2L,3L,4L,0L,5L,3L,6L,9L,3L,4L,9L,9L,1L,6L,8L,5L,8L,8L,5L,9L,2L,3L,3L,3L };
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
public class A104748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104748Inst : IEnumerable<long>
{
public static readonly long[] Value=A104748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104748.Bytes);
public long this[int i]=>Value[i];

public static A104748Inst Instance=new A104748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104749
{
public static readonly long[] Value={ 1L,-2L,-6L,20L,-26L,324L,932L,-3864L,-12282L,-8812L,123596L,-1011048L,1302748L,-9066968L,-11700216L,327436496L,500340678L,4725531060L,3741191612L,-11250963784L,-147523219212L,-1497706973320L,-7306482940296L,-675852523344L,10735087541148L };
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
public class A104749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104749Inst : IEnumerable<long>
{
public static readonly long[] Value=A104749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104749.Bytes);
public long this[int i]=>Value[i];

public static A104749Inst Instance=new A104749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104750
{
public static readonly long[] Value={ 1L,3L,1L,9L,9L,9L,7L,8L,1L,7L,8L,6L,8L,7L,1L,1L,2L,8L,9L,2L,9L,3L,9L,4L,3L,8L,5L,5L,1L,5L,9L,1L,6L,8L,0L,4L,7L,0L,5L,9L,5L,0L,8L };
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
public class A104750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104750Inst : IEnumerable<long>
{
public static readonly long[] Value=A104750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104750.Bytes);
public long this[int i]=>Value[i];

public static A104750Inst Instance=new A104750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104751
{
public static readonly long[] Value={ 1L,3L,0L,0L,9L,6L,2L,2L,2L,6L,3L,5L,8L,8L,5L,4L,3L,9L,2L,7L,3L,2L,6L,4L,0L,8L,5L,2L,6L,1L,8L,5L,6L,0L,5L,1L,0L,2L,4L,9L,8L,5L,5L,6L,9L,6L,8L,2L,9L,8L,4L,3L,1L,0L,8L,0L,6L,2L,9L,2L,5L,7L,3L,4L,4L,8L,0L,9L,9L,4L,0L,5L,6L,2L,3L,4L,7L,0L,8L,2L,5L,9L,4L,1L,8L,4L,6L,7L,3L,1L,7L,3L,2L,6L,4L,3L,1L,5L,5L,9L,8L,1L,2L,4L,7L,6L,6L,9L,1L,1L,9L,0L,3L,4L,5L,0L,9L,8L,7L,3L };
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
public class A104751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104751Inst : IEnumerable<long>
{
public static readonly long[] Value=A104751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104751.Bytes);
public long this[int i]=>Value[i];

public static A104751Inst Instance=new A104751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104752
{
public static readonly long[] Value={ 1L,2L,6L,9L,4L,1L,5L,4L,0L,7L,3L,0L,9L,7L,9L,2L,2L,7L,9L,9L,8L,6L,4L,1L,9L,9L,0L,9L,6L,1L,3L,6L,7L,7L,7L,9L,2L,6L,2L,4L,2L,1L,4L,2L,1L,9L,9L,0L,2L,3L,4L,7L,6L,2L,5L,4L,7L,6L,6L,3L,8L,5L,7L,6L,1L,9L,3L,6L,1L,6L,0L,7L,9L,0L,4L,4L,7L,4L,1L,5L,3L,8L,1L,8L,7L,5L,4L,7L,0L,2L,3L,1L,1L,5L,4L,1L,8L,4L,3L,6L,7L,7L,2L,1L,7L };
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
public class A104752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104752Inst : IEnumerable<long>
{
public static readonly long[] Value=A104752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104752.Bytes);
public long this[int i]=>Value[i];

public static A104752Inst Instance=new A104752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104753
{
public static readonly long[] Value={ 1L,2L,4L,3L,1L,4L,7L,4L,0L,7L,2L,3L,5L,6L,6L,4L,5L,3L,1L,6L,9L,8L,4L,3L,7L,2L,6L,4L,9L,3L,4L,4L,8L,6L,7L,2L,2L,4L,6L,9L,2L,5L,9L,0L,8L,7L,1L,7L,5L,5L,7L,0L,0L,5L,3L,8L,8L,9L,2L,3L,4L,5L,1L,8L,6L,2L,5L,7L,3L,0L,3L,9L,4L,1L,0L,6L,8L,7L,4L,9L,0L,6L,3L,6L,2L,3L };
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
public class A104753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104753Inst : IEnumerable<long>
{
public static readonly long[] Value=A104753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104753.Bytes);
public long this[int i]=>Value[i];

public static A104753Inst Instance=new A104753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104754
{
public static readonly long[] Value={ 1L,2L,2L,2L,1L,1L,3L,1L,7L,5L,4L,2L,3L,9L,5L,4L,3L,8L,0L,7L,4L,9L,4L,4L,9L,0L,0L,5L,8L,4L,8L,1L,3L,0L,7L,8L,9L,2L,3L,5L,6L,8L };
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
public class A104754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104754Inst : IEnumerable<long>
{
public static readonly long[] Value=A104754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104754.Bytes);
public long this[int i]=>Value[i];

public static A104754Inst Instance=new A104754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104755
{
public static readonly long[] Value={ 1L,2L,0L,5L,0L,5L,3L,4L,2L,6L,1L,9L,6L,3L,9L,1L,7L,4L,9L,3L,3L,8L,0L,9L,6L,3L,6L,5L,6L,5L,4L,9L,3L,2L,1L,0L,6L,8L,6L,6L,5L,1L };
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
public class A104755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104755Inst : IEnumerable<long>
{
public static readonly long[] Value=A104755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104755.Bytes);
public long this[int i]=>Value[i];

public static A104755Inst Instance=new A104755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104756
{
public static readonly long[] Value={ 1L,1L,9L,0L,9L,4L,7L,0L,7L,7L,0L,3L,6L,0L,7L,7L,2L,5L,6L,0L,1L,2L,0L,4L,6L,7L,8L,7L,3L,1L,5L,2L,3L,4L,8L,3L,7L,6L,5L,4L,6L,7L };
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
public class A104756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104756Inst : IEnumerable<long>
{
public static readonly long[] Value=A104756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104756.Bytes);
public long this[int i]=>Value[i];

public static A104756Inst Instance=new A104756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104757
{
public static readonly long[] Value={ 1L,1L,7L,9L,0L,6L,7L,9L,9L,4L,1L,3L,0L,5L,4L,6L,7L,1L,1L,3L,2L,6L,6L,2L,7L,2L,6L,8L,8L,7L,0L,6L,7L,2L,7L,1L,4L,2L,4L,7L,3L,6L,3L,8L,6L,3L,6L,9L,8L,8L,5L,7L,9L,0L,8L,9L,1L,3L,6L,0L,1L,4L,4L,8L,6L,5L,3L,9L,9L,2L,1L,7L,5L,4L,1L,0L,3L,8L,4L,8L,3L,2L,7L,2L,1L,2L,5L,0L,8L,3L,5L,7L,1L,5L,0L,2L,7L,1L,5L,8L,0L,0L,3L,9L,0L };
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
public class A104757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104757Inst : IEnumerable<long>
{
public static readonly long[] Value=A104757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104757.Bytes);
public long this[int i]=>Value[i];

public static A104757Inst Instance=new A104757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104758
{
public static readonly long[] Value={ 2L,1L,1L,1L,1L,2L,2L,3L,3L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,6L,6L,6L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,13L,13L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,15L,15L,15L };
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
public class A104758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104758Inst : IEnumerable<long>
{
public static readonly long[] Value=A104758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104758.Bytes);
public long this[int i]=>Value[i];

public static A104758Inst Instance=new A104758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104759
{
public static readonly long[] Value={ 1L,21L,321L,4321L,54321L,654321L,7654321L,87654321L,987654321L,1987654321L,1987654321L,101987654321L,1101987654321L,11101987654321L,211101987654321L,1211101987654321L,31211101987654321L,131211101987654321L };
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
public class A104759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104759Inst : IEnumerable<long>
{
public static readonly long[] Value=A104759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104759.Bytes);
public long this[int i]=>Value[i];

public static A104759Inst Instance=new A104759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104760
{
public static readonly long[] Value={ 57L,77L,3777L,17777L,277777L,1777777L,17777777L,707777777L,3777777777L,17777777777L,577777777777L,1777777777777L,37777777777777L,757777777777777L,4777777777777777L,37777777777777777L,277777777777777777L };
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
public class A104760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104760Inst : IEnumerable<long>
{
public static readonly long[] Value=A104760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104760.Bytes);
public long this[int i]=>Value[i];

public static A104760Inst Instance=new A104760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104761
{
public static readonly long[] Value={ 38L,818L,8818L,88887L,888883L,8888818L,88888881L,888888881L,8888888858L,88888888882L,888888888886L,8888888888878L,88888888888883L,888888888888881L,8888888888888881L,88888888888888883L,888888888888888838L };
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
public class A104761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104761Inst : IEnumerable<long>
{
public static readonly long[] Value=A104761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104761.Bytes);
public long this[int i]=>Value[i];

public static A104761Inst Instance=new A104761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104762
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,5L,3L,2L,1L,1L,8L,5L,3L,2L,1L,1L,13L,8L,5L,3L,2L,1L,1L,21L,13L,8L,5L,3L,2L,1L,1L,34L,21L,13L,8L,5L,3L,2L,1L,1L,55L,34L,21L,13L,8L,5L,3L,2L,1L,1L,89L,55L,34L,21L,13L,8L,5L,3L,2L,1L,1L,144L,89L,55L,34L,21L,13L,8L,5L,3L,2L,1L,1L,233L,144L,89L,55L,34L,21L,13L,8L,5L,3L,2L,1L };
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
public class A104762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104762Inst : IEnumerable<long>
{
public static readonly long[] Value=A104762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104762.Bytes);
public long this[int i]=>Value[i];

public static A104762Inst Instance=new A104762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104763
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,2L,3L,5L,1L,1L,2L,3L,5L,8L,1L,1L,2L,3L,5L,8L,13L,1L,1L,2L,3L,5L,8L,13L,21L,1L,1L,2L,3L,5L,8L,13L,21L,34L,1L,1L,2L,3L,5L,8L,13L,21L,34L,55L,1L,1L,2L,3L,5L,8L,13L,21L,34L,55L,89L,1L,1L,2L,3L,5L,8L,13L,21L,34L,55L,89L,144L,1L,1L,2L,3L,5L,8L,13L,21L,34L,55L,89L,144L };
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
public class A104763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104763Inst : IEnumerable<long>
{
public static readonly long[] Value=A104763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104763.Bytes);
public long this[int i]=>Value[i];

public static A104763Inst Instance=new A104763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104764
{
public static readonly long[] Value={ 1L,3L,1L,4L,3L,1L,7L,4L,3L,1L,11L,7L,4L,3L,1L,18L,11L,7L,4L,3L,1L,29L,18L,11L,7L,4L,3L,1L,47L,29L,18L,11L,7L,4L,3L,1L,76L,47L,29L,18L,11L,7L,4L,3L,1L,123L,76L,47L,29L,18L,11L,7L,4L,3L,1L,199L,123L,76L,47L,29L,18L,11L,7L,4L,3L,1L,322L,199L,123L };
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
public class A104764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104764Inst : IEnumerable<long>
{
public static readonly long[] Value=A104764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104764.Bytes);
public long this[int i]=>Value[i];

public static A104764Inst Instance=new A104764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104765
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,4L,1L,3L,4L,7L,1L,3L,4L,7L,11L,1L,3L,4L,7L,11L,18L,1L,3L,4L,7L,11L,18L,29L,1L,3L,4L,7L,11L,18L,29L,47L,1L,3L,4L,7L,11L,18L,29L,47L,76L,1L,3L,4L,7L,11L,18L,29L,47L,76L,123L,1L,3L,4L,7L,11L,18L,29L,47L,76L,123L,199L,1L,3L,4L,7L,11L,18L,29L,47L,76L,123L,199L,322L,1L,3L,4L,7L,11L };
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
public class A104765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104765Inst : IEnumerable<long>
{
public static readonly long[] Value=A104765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104765.Bytes);
public long this[int i]=>Value[i];

public static A104765Inst Instance=new A104765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104766
{
public static readonly long[] Value={ 1L,2L,1L,5L,2L,1L,10L,5L,2L,1L,20L,10L,5L,2L,1L,38L,20L,10L,5L,2L,1L,71L,38L,20L,10L,5L,2L,1L,130L,71L,38L,20L,10L,5L,2L,1L };
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
public class A104766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104766Inst : IEnumerable<long>
{
public static readonly long[] Value=A104766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104766.Bytes);
public long this[int i]=>Value[i];

public static A104766Inst Instance=new A104766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104767
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,10L,16L,24L,36L,56L,88L,136L,208L,320L,496L,768L,1184L,1824L,2816L,4352L,6720L,10368L,16000L,24704L,38144L,58880L,90880L,140288L,216576L,334336L,516096L,796672L,1229824L,1898496L,2930688L,4524032L,6983680L,10780672L,16642048L,25690112L,39657472L };
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
public class A104767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104767Inst : IEnumerable<long>
{
public static readonly long[] Value=A104767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104767.Bytes);
public long this[int i]=>Value[i];

public static A104767Inst Instance=new A104767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104768
{
public static readonly long[] Value={ 8L,4L,0L,8L,0L,0L,8L,0L,8L,0L,8L,0L,0L,0L,0L,16L,0L,0L,8L,0L,0L,16L,0L,0L,8L,0L,0L,0L,8L,0L,0L,0L,0L,8L,0L,16L,8L,0L,0L,8L,0L,0L,0L,0L,0L,16L,8L,0L,8L,0L,0L,0L,0L,8L,0L,16L,0L,8L,0L,0L,0L,0L,8L,8L,0L,0L,16L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,16L,0L,16L,8L,8L,0L,8L,0L,0L,0L,0L,0L,16L,8L,0L,0L,0L,0L,0L,0L,0L,8L,0L };
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
public class A104768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104768Inst : IEnumerable<long>
{
public static readonly long[] Value=A104768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104768.Bytes);
public long this[int i]=>Value[i];

public static A104768Inst Instance=new A104768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104769
{
public static readonly long[] Value={ 0L,-1L,1L,-1L,0L,1L,-2L,2L,-1L,-1L,3L,-4L,3L,0L,-4L,7L,-7L,3L,4L,-11L,14L,-10L,-1L,15L,-25L,24L,-9L,-16L,40L,-49L,33L,7L,-56L,89L,-82L,26L,63L,-145L,171L,-108L,-37L,208L,-316L,279L,-71L,-245L,524L,-595L,350L,174L,-769L,1119L,-945L,176L,943L,-1888L,2064L,-1121L,-767L,2831L,-3952L };
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
public class A104769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104769Inst : IEnumerable<long>
{
public static readonly long[] Value=A104769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104769.Bytes);
public long this[int i]=>Value[i];

public static A104769Inst Instance=new A104769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104770
{
public static readonly long[] Value={ 1L,-1L,2L,-1L,0L,2L,-3L,3L,-1L,-2L,5L,-6L,4L,1L,-7L,11L,-10L,3L,8L,-18L,21L,-13L,-5L,26L,-39L,34L,-8L,-31L,65L,-73L,42L,23L,-96L,138L,-115L,19L,119L,-234L,253L,-134L,-100L,353L,-487L,387L,-34L,-453L,840L,-874L,421L,419L,-1293L,1714L,-1295L,2L,1712L,-3007L,3009L,-1297L,-1710L,4719L,-6016L };
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
public class A104770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104770Inst : IEnumerable<long>
{
public static readonly long[] Value=A104770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104770.Bytes);
public long this[int i]=>Value[i];

public static A104770Inst Instance=new A104770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104771
{
public static readonly long[] Value={ 1L,-2L,3L,-2L,0L,3L,-5L,5L,-2L,-3L,8L,-10L,7L,1L,-11L,18L,-17L,6L,12L,-29L,35L,-23L,-6L,41L,-64L,58L,-17L,-47L,105L,-122L,75L,30L,-152L,227L,-197L,45L,182L,-379L,424L,-242L,-137L,561L,-803L,666L,-105L,-698L,1364L,-1469L,771L,593L,-2062L,2833L,-2240L,178L,2655L,-4895L,5073L,-2418L,-2477L,7550L,-9968L };
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
public class A104771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104771Inst : IEnumerable<long>
{
public static readonly long[] Value=A104771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104771.Bytes);
public long this[int i]=>Value[i];

public static A104771Inst Instance=new A104771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104772
{
public static readonly long[] Value={ 1L,2L,8L,4L,18L,9L,30L,15L,42L,21L,70L,35L,66L,33L,78L,39L,130L,65L,102L,51L,114L,57L,190L,95L,138L,69L,230L,115L,322L,161L,174L,87L,186L,93L,310L,155L,434L,217L,222L,111L,370L,185L,246L,123L,258L,129L,430L,215L,282L,141L,470L,235L,658L,329L,318L,159L,530L,265L,742L };
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
public class A104772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104772Inst : IEnumerable<long>
{
public static readonly long[] Value=A104772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104772.Bytes);
public long this[int i]=>Value[i];

public static A104772Inst Instance=new A104772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104773
{
public static readonly long[] Value={ 1L,2L,15L,4L,65L,42L,161L,78L,185L,114L,201L,310L,305L,186L,365L,222L,381L,610L,485L,470L,545L,530L,1969L,1246L,917L,402L,681L,678L,1585L,1570L,1169L,830L,905L,890L,921L,1510L,1293L,2954L,2321L,654L,1101L,1810L,1205L,2486L,1757L,762L,4609L,2110L,1385L,834L };
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
public class A104773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104773Inst : IEnumerable<long>
{
public static readonly long[] Value=A104773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104773.Bytes);
public long this[int i]=>Value[i];

public static A104773Inst Instance=new A104773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104774
{
public static readonly long[] Value={ 1L,2L,0L,4L,0L,0L,0L,3L,6L,0L,0L,0L,0L,0L,8L,2L,0L,5L,0L,0L,10L,0L,0L,0L,10L,0L,0L,0L,0L,7L,0L,1L,14L,0L,12L,4L,0L,0L,16L,0L,0L,9L,0L,0L,0L,0L,0L,0L,14L,9L,20L,0L,0L,0L,16L,0L,22L,0L,0L,6L,0L,0L,0L,0L,18L,13L,0L,0L,26L,11L,0L,3L,0L,0L,0L,0L,18L,15L,0L,0L,0L,0L,0L,8L,22L,0L,32L,0L,0L,0L,20L,0L,34L,0L,24L };
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
public class A104774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104774Inst : IEnumerable<long>
{
public static readonly long[] Value=A104774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104774.Bytes);
public long this[int i]=>Value[i];

public static A104774Inst Instance=new A104774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104775
{
public static readonly long[] Value={ 9L,299L,5999L,19999L,899999L,5999999L,79999999L,299999999L,1999999999L,49999999999L,499999999999L,1999999999999L,29999999999999L,199999999999999L,1999999999999999L,29999999999999999L,599999999999999999L };
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
public class A104775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104775Inst : IEnumerable<long>
{
public static readonly long[] Value=A104775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104775.Bytes);
public long this[int i]=>Value[i];

public static A104775Inst Instance=new A104775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104776
{
public static readonly long[] Value={ 14L,30L,67L,171L,246L,255L,315L,374L,455L,722L,822L,911L,963L,978L,1410L,1650L,1826L,2103L,2390L,2558L,2747L,3030L,3055L,3170L,6642L,8414L,8807L,8879L,10647L,10967L,11502L,11543L,11627L,11750L,12866L,13263L,13607L,15030L,16070L,16411L,16907L };
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
public class A104776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104776Inst : IEnumerable<long>
{
public static readonly long[] Value=A104776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104776.Bytes);
public long this[int i]=>Value[i];

public static A104776Inst Instance=new A104776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104777
{
public static readonly long[] Value={ 1L,25L,49L,121L,169L,289L,361L,529L,625L,841L,961L,1225L,1369L,1681L,1849L,2209L,2401L,2809L,3025L,3481L,3721L,4225L,4489L,5041L,5329L,5929L,6241L,6889L,7225L,7921L,8281L,9025L,9409L,10201L,10609L,11449L,11881L,12769L,13225L,14161L,14641L,15625L,16129L };
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
public class A104777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104777Inst : IEnumerable<long>
{
public static readonly long[] Value=A104777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104777.Bytes);
public long this[int i]=>Value[i];

public static A104777Inst Instance=new A104777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104778
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,4L,1L,2L,3L,5L,10L,1L,2L,3L,5L,7L,13L,26L,1L,2L,3L,4L,5L,8L,11L,14L,20L,38L,76L,1L,2L,3L,4L,5L,8L,10L,13L,14L,23L,32L,42L,60L,116L,232L,1L,2L,3L,4L,5L,5L,8L,11L,14L,17L,14L,24L,30L,40L,56L,43L,73L,103L,136L,196L,382L,764L,1L };
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
public class A104778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104778Inst : IEnumerable<long>
{
public static readonly long[] Value=A104778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104778.Bytes);
public long this[int i]=>Value[i];

public static A104778Inst Instance=new A104778Inst();

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