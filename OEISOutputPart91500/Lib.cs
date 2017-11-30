using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A112179
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,6L,9L,8L,13L,20L,22L,28L,34L,46L,57L,68L,87L,104L,127L,152L,187L,232L,267L,318L,388L,462L,545L,632L,753L,896L,1043L,1216L,1416L,1664L,1928L,2228L,2597L,2996L,3454L,3976L,4585L,5286L,6031L,6900L,7918L,9060L,10325L,11720L,13372L,15228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112179Inst : IEnumerable<long>
{
public static readonly long[] Value=A112179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112179.Bytes);
public long this[int i]=>Value[i];

public static A112179Inst Instance=new A112179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112180
{
public static readonly long[] Value={ 1L,0L,3L,4L,4L,4L,7L,12L,13L,16L,22L,28L,38L,44L,55L,72L,83L,104L,129L,156L,187L,220L,273L,328L,384L,452L,539L,652L,757L,880L,1041L,1220L,1428L,1652L,1924L,2244L,2585L,2992L,3458L,3992L,4581L,5244L,6053L,6936L,7910L,9024L,10303L,11784L,13380L,15176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112180Inst : IEnumerable<long>
{
public static readonly long[] Value=A112180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112180.Bytes);
public long this[int i]=>Value[i];

public static A112180Inst Instance=new A112180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112181
{
public static readonly long[] Value={ 1L,2L,-1L,2L,0L,2L,-1L,4L,1L,4L,-2L,8L,2L,10L,-1L,12L,3L,16L,-3L,20L,3L,28L,-3L,34L,4L,42L,-5L,52L,5L,64L,-7L,84L,8L,100L,-8L,120L,9L,148L,-10L,176L,13L,218L,-15L,260L,14L,308L,-17L,368L,20L,436L,-23L,524L,24L,616L,-26L,724L,31L,852L,-34L,996L,38L,1178L,-41L,1370L,46L,1592L,-52L,1856L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112181Inst : IEnumerable<long>
{
public static readonly long[] Value=A112181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112181.Bytes);
public long this[int i]=>Value[i];

public static A112181Inst Instance=new A112181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112182
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,1L,-2L,2L,-1L,3L,-3L,3L,-3L,4L,-5L,5L,-7L,8L,-8L,9L,-10L,13L,-15L,14L,-17L,20L,-23L,24L,-26L,31L,-34L,38L,-41L,46L,-52L,55L,-62L,70L,-75L,82L,-90L,103L,-112L,118L,-131L,145L,-161L,172L,-185L,208L,-225L,244L,-265L,288L,-316L,339L,-370L,404L,-435L,469L,-507L,557L,-601L,640L,-696L,755L,-818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112182Inst : IEnumerable<long>
{
public static readonly long[] Value=A112182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112182.Bytes);
public long this[int i]=>Value[i];

public static A112182Inst Instance=new A112182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112183
{
public static readonly long[] Value={ 1L,1L,-1L,1L,0L,1L,0L,-1L,0L,0L,2L,2L,-1L,1L,0L,2L,1L,-1L,1L,0L,4L,3L,-3L,2L,0L,4L,2L,-3L,1L,0L,7L,5L,-5L,4L,0L,7L,4L,-5L,3L,0L,12L,9L,-8L,6L,0L,13L,7L,-9L,5L,0L,19L,14L,-13L,9L,0L,21L,12L,-14L,8L,0L,31L,22L,-21L,15L,0L,34L,19L,-23L,13L,0L,47L,33L,-31L,22L,0L,52L,31L,-35L,21L,0L,71L,49L,-48L,33L,0L,79L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112183Inst : IEnumerable<long>
{
public static readonly long[] Value=A112183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112183.Bytes);
public long this[int i]=>Value[i];

public static A112183Inst Instance=new A112183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112184
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,1L,-1L,1L,-1L,2L,-2L,2L,-3L,4L,-3L,4L,-5L,6L,-6L,6L,-8L,9L,-10L,10L,-12L,14L,-15L,16L,-19L,21L,-22L,24L,-27L,31L,-34L,36L,-40L,46L,-48L,52L,-58L,64L,-69L,74L,-82L,91L,-98L,104L,-115L,127L,-136L,145L,-159L,174L,-186L,200L,-218L,238L,-254L,272L,-296L,322L,-343L,366L,-398L,430L,-460L,492L,-531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112184Inst : IEnumerable<long>
{
public static readonly long[] Value=A112184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112184.Bytes);
public long this[int i]=>Value[i];

public static A112184Inst Instance=new A112184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112185
{
public static readonly long[] Value={ 1L,-1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,-1L,0L,1L,1L,2L,-2L,0L,1L,1L,3L,-1L,0L,2L,1L,3L,-2L,0L,2L,1L,5L,-4L,0L,4L,3L,6L,-3L,0L,4L,2L,7L,-5L,0L,5L,4L,10L,-7L,0L,7L,5L,12L,-7L,0L,9L,5L,14L,-9L,0L,10L,6L,20L,-14L,0L,14L,10L,23L,-13L,0L,16L,9L,27L,-18L,0L,19L,13L,35L,-24L,0L,24L,16L,42L,-25L,0L,29L,18L,48L,-31L,0L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112185Inst : IEnumerable<long>
{
public static readonly long[] Value=A112185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112185.Bytes);
public long this[int i]=>Value[i];

public static A112185Inst Instance=new A112185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112186
{
public static readonly long[] Value={ 1L,1L,1L,-1L,2L,-1L,2L,1L,3L,0L,4L,-1L,5L,1L,7L,0L,8L,0L,10L,1L,13L,-2L,16L,0L,20L,3L,24L,-2L,30L,-2L,36L,4L,43L,0L,52L,-3L,61L,2L,73L,-1L,86L,-1L,102L,3L,120L,-4L,140L,-1L,165L,8L,192L,-5L,224L,-6L,260L,10L,301L,-2L,348L,-7L,401L,7L,462L,-2L,530L,-2L,608L,8L,696L,-10L,796L,-3L,909L,18L,1035L,-12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112186Inst : IEnumerable<long>
{
public static readonly long[] Value=A112186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112186.Bytes);
public long this[int i]=>Value[i];

public static A112186Inst Instance=new A112186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112187
{
public static readonly long[] Value={ 1L,-1L,1L,1L,2L,1L,2L,-1L,3L,0L,4L,1L,5L,-1L,7L,0L,8L,0L,10L,-1L,13L,2L,16L,0L,20L,-3L,24L,2L,30L,2L,36L,-4L,43L,0L,52L,3L,61L,-2L,73L,1L,86L,1L,102L,-3L,120L,4L,140L,1L,165L,-8L,192L,5L,224L,6L,260L,-10L,301L,2L,348L,7L,401L,-7L,462L,2L,530L,2L,608L,-8L,696L,10L,796L,3L,909L,-18L,1035L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112187Inst : IEnumerable<long>
{
public static readonly long[] Value=A112187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112187.Bytes);
public long this[int i]=>Value[i];

public static A112187Inst Instance=new A112187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112188
{
public static readonly long[] Value={ 1L,-1L,1L,1L,0L,-1L,0L,1L,1L,0L,2L,1L,1L,-1L,1L,2L,2L,-2L,2L,1L,1L,-2L,2L,2L,4L,-3L,4L,4L,2L,-4L,2L,4L,5L,-4L,6L,5L,5L,-6L,5L,7L,8L,-7L,8L,7L,6L,-8L,8L,9L,13L,-12L,14L,13L,10L,-14L,10L,14L,17L,-14L,20L,17L,17L,-19L,18L,22L,24L,-24L,26L,24L,22L,-26L,26L,29L,37L,-34L,39L,38L,32L,-40L,34L,42L,48L,-44L,54L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112188Inst : IEnumerable<long>
{
public static readonly long[] Value=A112188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112188.Bytes);
public long this[int i]=>Value[i];

public static A112188Inst Instance=new A112188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112189
{
public static readonly long[] Value={ 1L,1L,1L,-1L,0L,1L,0L,-1L,1L,0L,2L,-1L,1L,1L,1L,-2L,2L,2L,2L,-1L,1L,2L,2L,-2L,4L,3L,4L,-4L,2L,4L,2L,-4L,5L,4L,6L,-5L,5L,6L,5L,-7L,8L,7L,8L,-7L,6L,8L,8L,-9L,13L,12L,14L,-13L,10L,14L,10L,-14L,17L,14L,20L,-17L,17L,19L,18L,-22L,24L,24L,26L,-24L,22L,26L,26L,-29L,37L,34L,39L,-38L,32L,40L,34L,-42L,48L,44L,54L,-49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112189Inst : IEnumerable<long>
{
public static readonly long[] Value=A112189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112189.Bytes);
public long this[int i]=>Value[i];

public static A112189Inst Instance=new A112189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112190
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,0L,-1L,0L,-1L,1L,0L,-2L,-1L,1L,-1L,-1L,-2L,2L,-2L,-2L,-1L,1L,-2L,-2L,-2L,4L,-3L,-4L,-4L,2L,-4L,-2L,-4L,5L,-4L,-6L,-5L,5L,-6L,-5L,-7L,8L,-7L,-8L,-7L,6L,-8L,-8L,-9L,13L,-12L,-14L,-13L,10L,-14L,-10L,-14L,17L,-14L,-20L,-17L,17L,-19L,-18L,-22L,24L,-24L,-26L,-24L,22L,-26L,-26L,-29L,37L,-34L,-39L,-38L,32L,-40L,-34L,-42L,48L,-44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112190Inst : IEnumerable<long>
{
public static readonly long[] Value=A112190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112190.Bytes);
public long this[int i]=>Value[i];

public static A112190Inst Instance=new A112190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112191
{
public static readonly long[] Value={ 1L,1L,-1L,1L,0L,1L,0L,1L,1L,0L,-2L,1L,1L,1L,-1L,2L,2L,2L,-2L,1L,1L,2L,-2L,2L,4L,3L,-4L,4L,2L,4L,-2L,4L,5L,4L,-6L,5L,5L,6L,-5L,7L,8L,7L,-8L,7L,6L,8L,-8L,9L,13L,12L,-14L,13L,10L,14L,-10L,14L,17L,14L,-20L,17L,17L,19L,-18L,22L,24L,24L,-26L,24L,22L,26L,-26L,29L,37L,34L,-39L,38L,32L,40L,-34L,42L,48L,44L,-54L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112191Inst : IEnumerable<long>
{
public static readonly long[] Value=A112191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112191.Bytes);
public long this[int i]=>Value[i];

public static A112191Inst Instance=new A112191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112192
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,7L,8L,10L,13L,16L,20L,24L,30L,36L,43L,52L,61L,73L,86L,102L,120L,140L,165L,192L,224L,260L,301L,348L,401L,462L,530L,608L,696L,796L,909L,1035L,1178L,1338L,1518L,1720L,1945L,2198L,2480L,2796L,3148L,3540L,3978L,4464L,5006L,5606L,6273L,7012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112192Inst : IEnumerable<long>
{
public static readonly long[] Value=A112192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112192.Bytes);
public long this[int i]=>Value[i];

public static A112192Inst Instance=new A112192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112193
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,5L,6L,7L,9L,11L,13L,16L,19L,23L,27L,32L,38L,44L,52L,61L,71L,82L,95L,110L,127L,145L,167L,191L,218L,249L,283L,322L,365L,414L,469L,529L,597L,673L,757L,851L,955L,1071L,1199L,1341L,1499L,1673L,1865L,2078L,2313L,2572L,2857L,3171L,3517L,3897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112193Inst : IEnumerable<long>
{
public static readonly long[] Value=A112193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112193.Bytes);
public long this[int i]=>Value[i];

public static A112193Inst Instance=new A112193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112194
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,4L,4L,6L,8L,10L,11L,14L,16L,20L,23L,28L,32L,40L,45L,55L,61L,74L,83L,98L,111L,130L,148L,172L,195L,224L,253L,291L,327L,374L,420L,481L,539L,612L,683L,775L,865L,976L,1087L,1224L,1365L,1530L,1701L,1902L,2113L,2358L,2613L,2910L,3221L,3584L,3960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112194Inst : IEnumerable<long>
{
public static readonly long[] Value=A112194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112194.Bytes);
public long this[int i]=>Value[i];

public static A112194Inst Instance=new A112194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112195
{
public static readonly long[] Value={ 1L,1L,-1L,1L,0L,0L,1L,1L,0L,2L,1L,-1L,2L,1L,-1L,2L,1L,-1L,4L,3L,-2L,4L,2L,-1L,5L,3L,-2L,7L,4L,-3L,8L,4L,-3L,9L,5L,-3L,13L,8L,-6L,14L,7L,-5L,16L,10L,-6L,21L,12L,-9L,24L,13L,-9L,27L,15L,-10L,35L,21L,-15L,39L,20L,-14L,45L,26L,-17L,55L,31L,-22L,62L,34L,-23L,70L,39L,-26L,86L,50L,-35L,96L,51L,-35L,109L,62L,-41L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112195Inst : IEnumerable<long>
{
public static readonly long[] Value=A112195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112195.Bytes);
public long this[int i]=>Value[i];

public static A112195Inst Instance=new A112195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112196
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,2L,5L,6L,7L,7L,9L,12L,13L,16L,20L,25L,27L,31L,38L,44L,51L,58L,69L,80L,92L,102L,118L,141L,157L,177L,203L,234L,261L,292L,336L,382L,428L,475L,540L,610L,677L,757L,852L,957L,1060L,1179L,1318L,1470L,1634L,1806L,2011L,2236L,2469L,2724L,3020L,3350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112196Inst : IEnumerable<long>
{
public static readonly long[] Value=A112196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112196.Bytes);
public long this[int i]=>Value[i];

public static A112196Inst Instance=new A112196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112197
{
public static readonly long[] Value={ 1L,1L,1L,-1L,1L,0L,2L,-1L,2L,1L,3L,-1L,4L,1L,4L,0L,5L,1L,7L,-2L,8L,1L,10L,-1L,12L,2L,14L,-2L,17L,3L,21L,-3L,24L,3L,28L,-4L,34L,4L,39L,-4L,46L,5L,53L,-4L,61L,4L,71L,-6L,82L,6L,94L,-7L,108L,7L,124L,-8L,142L,11L,162L,-11L,185L,10L,210L,-12L,238L,14L,271L,-15L,306L,15L,345L,-14L,390L,17L,439L,-20L,494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112197Inst : IEnumerable<long>
{
public static readonly long[] Value=A112197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112197.Bytes);
public long this[int i]=>Value[i];

public static A112197Inst Instance=new A112197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112198
{
public static readonly long[] Value={ 1L,-1L,1L,1L,1L,0L,2L,1L,2L,-1L,3L,1L,4L,-1L,4L,0L,5L,-1L,7L,2L,8L,-1L,10L,1L,12L,-2L,14L,2L,17L,-3L,21L,3L,24L,-3L,28L,4L,34L,-4L,39L,4L,46L,-5L,53L,4L,61L,-4L,71L,6L,82L,-6L,94L,7L,108L,-7L,124L,8L,142L,-11L,162L,11L,185L,-10L,210L,12L,238L,-14L,271L,15L,306L,-15L,345L,14L,390L,-17L,439L,20L,494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112198Inst : IEnumerable<long>
{
public static readonly long[] Value=A112198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112198.Bytes);
public long this[int i]=>Value[i];

public static A112198Inst Instance=new A112198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112199
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,4L,4L,5L,6L,8L,9L,12L,13L,16L,18L,23L,25L,31L,36L,43L,48L,57L,64L,76L,86L,99L,112L,131L,146L,169L,190L,217L,243L,278L,310L,353L,394L,446L,498L,562L,624L,704L,781L,877L,972L,1088L,1204L,1345L,1488L,1656L,1829L,2033L,2240L,2486L,2738L,3030L,3334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112199Inst : IEnumerable<long>
{
public static readonly long[] Value=A112199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112199.Bytes);
public long this[int i]=>Value[i];

public static A112199Inst Instance=new A112199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112200
{
public static readonly long[] Value={ 1L,0L,0L,-1L,1L,-1L,1L,0L,1L,-1L,1L,-1L,2L,-2L,1L,-3L,2L,-2L,3L,-3L,4L,-4L,3L,-4L,6L,-5L,5L,-7L,7L,-7L,9L,-8L,9L,-11L,10L,-12L,14L,-13L,14L,-17L,18L,-18L,20L,-21L,23L,-27L,25L,-27L,33L,-32L,34L,-39L,39L,-42L,46L,-48L,51L,-56L,57L,-61L,71L,-69L,72L,-83L,85L,-90L,97L,-99L,108L,-117L,119L,-126L,140L,-143L,149L,-167L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112200Inst : IEnumerable<long>
{
public static readonly long[] Value=A112200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112200.Bytes);
public long this[int i]=>Value[i];

public static A112200Inst Instance=new A112200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112201
{
public static readonly long[] Value={ 1L,-1L,0L,1L,1L,0L,1L,0L,0L,2L,1L,0L,2L,-1L,0L,2L,0L,0L,3L,0L,0L,4L,1L,0L,4L,-1L,0L,6L,1L,0L,7L,-2L,0L,8L,2L,0L,10L,-2L,0L,12L,2L,0L,14L,-2L,0L,16L,1L,0L,19L,-2L,0L,22L,3L,0L,26L,-2L,0L,30L,3L,0L,35L,-5L,0L,41L,5L,0L,47L,-4L,0L,54L,5L,0L,62L,-6L,0L,70L,4L,0L,80L,-4L,0L,92L,7L,0L,104L,-7L,0L,118L,7L,0L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112201Inst : IEnumerable<long>
{
public static readonly long[] Value=A112201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112201.Bytes);
public long this[int i]=>Value[i];

public static A112201Inst Instance=new A112201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112202
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,0L,0L,0L,-1L,0L,-1L,0L,-1L,-1L,0L,0L,1L,0L,-1L,0L,-1L,1L,-1L,-2L,0L,-1L,1L,-1L,-1L,0L,-1L,2L,-2L,-3L,0L,0L,1L,-1L,-3L,0L,-2L,2L,-3L,-4L,0L,-1L,3L,-2L,-4L,0L,-2L,3L,-4L,-6L,0L,-2L,3L,-3L,-5L,0L,-3L,6L,-6L,-9L,0L,-2L,4L,-4L,-9L,0L,-5L,6L,-8L,-11L,0L,-3L,8L,-6L,-12L,0L,-6L,9L,-10L,-16L,0L,-6L,9L,-9L,-15L,0L,-8L,14L,-15L,-22L,0L,-6L,12L,-11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112202Inst : IEnumerable<long>
{
public static readonly long[] Value=A112202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112202.Bytes);
public long this[int i]=>Value[i];

public static A112202Inst Instance=new A112202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112203
{
public static readonly long[] Value={ 1L,1L,0L,1L,-1L,0L,1L,0L,0L,2L,-1L,0L,2L,1L,0L,2L,0L,0L,3L,0L,0L,4L,-1L,0L,4L,1L,0L,6L,-1L,0L,7L,2L,0L,8L,-2L,0L,10L,2L,0L,12L,-2L,0L,14L,2L,0L,16L,-1L,0L,19L,2L,0L,22L,-3L,0L,26L,2L,0L,30L,-3L,0L,35L,5L,0L,41L,-5L,0L,47L,4L,0L,54L,-5L,0L,62L,6L,0L,70L,-4L,0L,80L,4L,0L,92L,-7L,0L,104L,7L,0L,118L,-7L,0L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112203Inst : IEnumerable<long>
{
public static readonly long[] Value=A112203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112203.Bytes);
public long this[int i]=>Value[i];

public static A112203Inst Instance=new A112203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112204
{
public static readonly long[] Value={ 1L,0L,2L,2L,1L,2L,3L,2L,4L,6L,6L,6L,9L,8L,13L,14L,15L,18L,23L,22L,29L,34L,35L,44L,52L,52L,65L,74L,80L,92L,110L,114L,134L,152L,164L,188L,215L,230L,266L,296L,321L,362L,412L,438L,503L,558L,602L,674L,755L,810L,912L,1010L,1093L,1210L,1346L,1446L,1614L,1772L,1922L,2118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112204Inst : IEnumerable<long>
{
public static readonly long[] Value=A112204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112204.Bytes);
public long this[int i]=>Value[i];

public static A112204Inst Instance=new A112204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112205
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,2L,2L,3L,4L,4L,4L,5L,7L,7L,8L,10L,12L,14L,14L,17L,20L,22L,24L,28L,33L,36L,40L,45L,52L,56L,62L,71L,80L,88L,96L,109L,122L,133L,144L,163L,182L,198L,216L,240L,268L,290L,316L,349L,386L,420L,456L,502L,552L,600L,650L,713L,780L,846L,916L,1001L,1093L,1182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112205Inst : IEnumerable<long>
{
public static readonly long[] Value=A112205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112205.Bytes);
public long this[int i]=>Value[i];

public static A112205Inst Instance=new A112205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112206
{
public static readonly long[] Value={ 1L,1L,0L,2L,2L,1L,2L,2L,3L,4L,4L,4L,7L,7L,6L,10L,11L,11L,14L,16L,17L,21L,22L,24L,32L,34L,34L,44L,49L,50L,60L,66L,72L,84L,90L,98L,117L,125L,132L,156L,171L,181L,206L,226L,245L,277L,298L,322L,369L,397L,422L,480L,522L,557L,620L,674L,728L,807L,868L,936L,1043L,1121L,1198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112206Inst : IEnumerable<long>
{
public static readonly long[] Value=A112206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112206.Bytes);
public long this[int i]=>Value[i];

public static A112206Inst Instance=new A112206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112207
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,2L,-1L,0L,0L,0L,0L,3L,1L,0L,0L,0L,0L,3L,-1L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,5L,1L,0L,0L,0L,0L,6L,-2L,0L,0L,0L,0L,7L,2L,0L,0L,0L,0L,8L,-1L,0L,0L,0L,0L,9L,0L,0L,0L,0L,0L,10L,-1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112207Inst : IEnumerable<long>
{
public static readonly long[] Value=A112207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112207.Bytes);
public long this[int i]=>Value[i];

public static A112207Inst Instance=new A112207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112208
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,2L,-1L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,3L,-1L,0L,0L,0L,0L,3L,1L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,5L,-1L,0L,0L,0L,0L,6L,2L,0L,0L,0L,0L,7L,-2L,0L,0L,0L,0L,8L,1L,0L,0L,0L,0L,9L,0L,0L,0L,0L,0L,10L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112208Inst : IEnumerable<long>
{
public static readonly long[] Value=A112208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112208.Bytes);
public long this[int i]=>Value[i];

public static A112208Inst Instance=new A112208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112209
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,2L,2L,1L,3L,3L,3L,3L,4L,5L,5L,7L,8L,8L,9L,10L,13L,15L,14L,17L,20L,23L,24L,26L,31L,34L,38L,41L,46L,52L,55L,62L,70L,75L,82L,90L,103L,112L,118L,131L,145L,161L,172L,185L,208L,225L,244L,265L,288L,316L,339L,370L,404L,435L,469L,507L,557L,601L,640L,696L,755L,818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112209Inst : IEnumerable<long>
{
public static readonly long[] Value=A112209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112209.Bytes);
public long this[int i]=>Value[i];

public static A112209Inst Instance=new A112209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112210
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,4L,5L,6L,7L,7L,9L,9L,11L,12L,14L,15L,18L,19L,22L,24L,27L,29L,34L,36L,41L,44L,50L,54L,61L,65L,73L,79L,88L,95L,106L,114L,126L,136L,150L,162L,179L,192L,211L,228L,249L,268L,294L,316L,345L,371L,404L,434L,473L,507L,551L,592L,641L,688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112210Inst : IEnumerable<long>
{
public static readonly long[] Value=A112210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112210.Bytes);
public long this[int i]=>Value[i];

public static A112210Inst Instance=new A112210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112211
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,-1L,1L,-1L,1L,0L,1L,-2L,2L,-2L,1L,0L,1L,-2L,3L,-3L,1L,0L,2L,-4L,5L,-4L,2L,-2L,3L,-4L,6L,-6L,3L,-2L,3L,-7L,10L,-8L,5L,-4L,5L,-10L,13L,-10L,6L,-4L,7L,-14L,16L,-14L,11L,-8L,11L,-18L,22L,-21L,14L,-8L,14L,-24L,29L,-26L,17L,-14L,22L,-32L,39L,-36L,24L,-20L,28L,-40L,49L,-44L,32L,-28L,34L,-52L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112211Inst : IEnumerable<long>
{
public static readonly long[] Value=A112211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112211.Bytes);
public long this[int i]=>Value[i];

public static A112211Inst Instance=new A112211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112212
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,2L,3L,2L,3L,3L,4L,4L,4L,6L,7L,7L,7L,9L,10L,12L,13L,14L,17L,18L,19L,22L,26L,28L,29L,34L,38L,41L,44L,50L,57L,60L,65L,72L,81L,86L,94L,105L,114L,124L,133L,146L,161L,174L,187L,204L,224L,240L,258L,282L,309L,332L,354L,386L,419L,450L,481L,524L,569L,606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112212Inst : IEnumerable<long>
{
public static readonly long[] Value=A112212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112212.Bytes);
public long this[int i]=>Value[i];

public static A112212Inst Instance=new A112212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112213
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,1L,2L,2L,2L,3L,4L,3L,4L,5L,6L,6L,6L,8L,9L,10L,10L,12L,14L,15L,16L,19L,21L,22L,24L,27L,31L,34L,36L,40L,46L,48L,52L,58L,64L,69L,74L,82L,91L,98L,104L,115L,127L,136L,145L,159L,174L,186L,200L,218L,238L,254L,272L,296L,322L,343L,366L,398L,430L,460L,492L,531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112213Inst : IEnumerable<long>
{
public static readonly long[] Value=A112213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112213.Bytes);
public long this[int i]=>Value[i];

public static A112213Inst Instance=new A112213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112214
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,-1L,0L,2L,1L,0L,2L,0L,0L,2L,0L,0L,2L,-1L,0L,3L,1L,0L,3L,-1L,0L,4L,1L,0L,5L,0L,0L,5L,0L,0L,5L,-1L,0L,6L,2L,0L,7L,-2L,0L,8L,2L,0L,9L,-1L,0L,10L,0L,0L,11L,-1L,0L,12L,3L,0L,14L,-2L,0L,15L,1L,0L,17L,-1L,0L,18L,1L,0L,20L,-2L,0L,22L,4L,0L,25L,-5L,0L,28L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112214Inst : IEnumerable<long>
{
public static readonly long[] Value=A112214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112214.Bytes);
public long this[int i]=>Value[i];

public static A112214Inst Instance=new A112214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112215
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,-1L,1L,0L,0L,-1L,1L,-1L,1L,0L,0L,-1L,2L,-2L,2L,-1L,0L,-1L,3L,-2L,1L,-1L,1L,-2L,4L,-5L,3L,-1L,1L,-2L,4L,-6L,4L,-2L,3L,-5L,6L,-7L,6L,-2L,1L,-6L,10L,-10L,9L,-6L,4L,-7L,12L,-12L,9L,-7L,6L,-10L,18L,-20L,13L,-8L,9L,-12L,18L,-24L,20L,-12L,13L,-21L,27L,-29L,24L,-14L,13L,-25L,36L,-38L,35L,-25L,19L,-30L,46L,-46L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112215Inst : IEnumerable<long>
{
public static readonly long[] Value=A112215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112215.Bytes);
public long this[int i]=>Value[i];

public static A112215Inst Instance=new A112215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112216
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,4L,5L,5L,5L,6L,7L,8L,8L,10L,12L,12L,13L,15L,17L,18L,19L,22L,25L,27L,28L,32L,36L,38L,41L,46L,51L,54L,58L,64L,71L,76L,81L,89L,99L,105L,112L,123L,134L,143L,153L,167L,182L,194L,207L,225L,244L,260L,277L,301L,325L,346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112216Inst : IEnumerable<long>
{
public static readonly long[] Value=A112216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112216.Bytes);
public long this[int i]=>Value[i];

public static A112216Inst Instance=new A112216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112217
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,8L,8L,9L,10L,12L,12L,14L,15L,17L,18L,21L,22L,25L,27L,30L,32L,36L,38L,43L,46L,51L,54L,60L,64L,71L,76L,83L,89L,98L,104L,114L,122L,133L,142L,155L,165L,180L,192L,208L,222L,241L,256L,278L,296L,320L,341L,368L,391L,422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112217Inst : IEnumerable<long>
{
public static readonly long[] Value=A112217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112217.Bytes);
public long this[int i]=>Value[i];

public static A112217Inst Instance=new A112217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112218
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,1L,1L,2L,1L,2L,3L,2L,2L,4L,3L,4L,5L,5L,5L,7L,6L,7L,9L,9L,9L,12L,11L,13L,15L,15L,16L,20L,19L,22L,25L,26L,27L,33L,32L,36L,41L,42L,44L,52L,52L,57L,64L,66L,70L,81L,82L,89L,99L,103L,109L,123L,125L,136L,150L,156L,165L,185L,189L,204L,223L,233L,247L,273L,281L,302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112218Inst : IEnumerable<long>
{
public static readonly long[] Value=A112218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112218.Bytes);
public long this[int i]=>Value[i];

public static A112218Inst Instance=new A112218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112219
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,1L,1L,2L,1L,2L,1L,3L,2L,3L,3L,4L,3L,5L,4L,6L,5L,7L,6L,9L,7L,11L,9L,13L,11L,15L,13L,18L,16L,21L,19L,25L,22L,29L,27L,34L,31L,40L,37L,46L,43L,53L,50L,62L,58L,71L,68L,83L,78L,95L,91L,109L,104L,124L,120L,143L,137L,162L,158L,185L,180L,210L,206L,239L,234L,270L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112219Inst : IEnumerable<long>
{
public static readonly long[] Value=A112219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112219.Bytes);
public long this[int i]=>Value[i];

public static A112219Inst Instance=new A112219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112220
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,3L,4L,3L,4L,5L,4L,6L,6L,6L,7L,8L,7L,9L,10L,10L,11L,13L,12L,15L,16L,16L,18L,21L,19L,23L,25L,25L,28L,31L,30L,35L,38L,38L,42L,47L,46L,52L,56L,57L,62L,69L,68L,77L,82L,84L,91L,100L,100L,111L,118L,121L,131L,142L,144L,158L,168L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112220Inst : IEnumerable<long>
{
public static readonly long[] Value=A112220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112220.Bytes);
public long this[int i]=>Value[i];

public static A112220Inst Instance=new A112220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112221
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,2L,2L,1L,3L,2L,2L,3L,3L,4L,4L,3L,4L,6L,5L,5L,7L,7L,7L,9L,8L,9L,11L,10L,12L,14L,13L,14L,17L,18L,18L,20L,21L,23L,27L,25L,27L,33L,32L,34L,39L,39L,42L,46L,48L,51L,56L,57L,61L,71L,69L,72L,83L,85L,90L,97L,99L,108L,117L,119L,126L,140L,143L,149L,167L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112221Inst : IEnumerable<long>
{
public static readonly long[] Value=A112221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112221.Bytes);
public long this[int i]=>Value[i];

public static A112221Inst Instance=new A112221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112222
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,3L,4L,3L,4L,5L,4L,5L,6L,6L,6L,8L,7L,8L,9L,9L,10L,12L,11L,13L,14L,14L,15L,19L,17L,20L,22L,21L,23L,27L,26L,29L,32L,32L,34L,39L,38L,43L,46L,47L,50L,56L,55L,61L,67L,67L,72L,80L,79L,86L,93L,96L,101L,112L,112L,121L,130L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112222Inst : IEnumerable<long>
{
public static readonly long[] Value=A112222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112222.Bytes);
public long this[int i]=>Value[i];

public static A112222Inst Instance=new A112222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112223
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,3L,1L,3L,2L,3L,3L,5L,3L,5L,4L,5L,5L,7L,5L,8L,7L,8L,8L,11L,8L,12L,10L,12L,12L,16L,12L,18L,16L,19L,18L,23L,19L,26L,23L,27L,27L,33L,28L,37L,34L,39L,38L,47L,41L,52L,48L,55L,55L,66L,58L,73L,68L,77L,77L,91L,82L,100L,95L,107L,107L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112223Inst : IEnumerable<long>
{
public static readonly long[] Value=A112223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112223.Bytes);
public long this[int i]=>Value[i];

public static A112223Inst Instance=new A112223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112224
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,3L,2L,3L,2L,4L,3L,4L,3L,5L,4L,5L,5L,6L,5L,8L,6L,9L,6L,9L,8L,11L,10L,12L,11L,14L,12L,16L,13L,18L,16L,20L,18L,22L,20L,25L,23L,29L,25L,31L,29L,36L,33L,39L,36L,45L,40L,49L,45L,54L,51L,61L,58L,66L,63L,75L,70L,84L,77L,91L,86L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112224Inst : IEnumerable<long>
{
public static readonly long[] Value=A112224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112224.Bytes);
public long this[int i]=>Value[i];

public static A112224Inst Instance=new A112224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112225
{
public static readonly BigInteger[] Value={ 1L,13L,135L,1537L,19811L,289073L,4741923L,86705417L,1752264235L,38832482641L,937035652035L,24465531961465L,687363659349179L,20679220894484897L,663327190230305715L,BigInteger.Parse("22600083539456536457"),BigInteger.Parse("815088161465498630635") };
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
public class A112225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112225Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112225.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112225.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112225Inst Instance=new A112225Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112226
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,13L,7L,3L,1L,135L,40L,12L,4L,1L,1537L,293L,66L,18L,5L,1L,19811L,2646L,451L,100L,25L,6L,1L,289073L,28887L,3753L,663L,143L,33L,7L,1L,4741923L,374820L,37798L,5232L,940L,196L,42L,8L,1L,86705417L,5676121L,457508L,49444L,7174L,1294L,260L,52L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112226Inst : IEnumerable<long>
{
public static readonly long[] Value=A112226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112226.Bytes);
public long this[int i]=>Value[i];

public static A112226Inst Instance=new A112226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112227
{
public static readonly long[] Value={ 1L,0L,1L,-2L,0L,1L,0L,-6L,0L,1L,12L,0L,-12L,0L,1L,0L,60L,0L,-20L,0L,1L,-120L,0L,180L,0L,-30L,0L,1L,0L,-840L,0L,420L,0L,-42L,0L,1L,1680L,0L,-3360L,0L,840L,0L,-56L,0L,1L,0L,15120L,0L,-10080L,0L,1512L,0L,-72L,0L,1L,-30240L,0L,75600L,0L,-25200L,0L,2520L,0L,-90L,0L,1L,0L,-332640L,0L,277200L,0L,-55440L,0L,3960L,0L,-110L,0L,1L,665280L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112227Inst : IEnumerable<long>
{
public static readonly long[] Value=A112227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112227.Bytes);
public long this[int i]=>Value[i];

public static A112227Inst Instance=new A112227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112228
{
public static readonly BigInteger[] Value={ 3L,15L,120L,1080L,14040L,196560L,3931200L,82555200L,1981324800L,49533120000L,1585059840000L,52306974720000L,1778437140480000L,65802174197760000L,2500482619514880000L,BigInteger.Parse("112521717878169600000"),BigInteger.Parse("5401042458152140800000") };
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
public class A112228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112228Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112228.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112228.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112228Inst Instance=new A112228Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112229
{
public static readonly long[] Value={ 2L,4L,1L,2L,2L,4L,1L,4L,2L,8L,1L,2L,4L,28L,2L,11L,2L,4L,1L,4L,2L,32L,1L,3L,4L,40L,2L,14L,2L,4L,1L,37L,6L,138L,1L,2L,10L,40L,2L,5L,2L,16L,1L,16L,2L,26L,3L,4L,4L,10L,2L,20L,4L,10L,1L,7L,2L,50L,1L,2L,10L,22L,3L,6L,2L,6L,3L,69L,2L,8L,1L,2L,4L,40L,5L,20L,2L,4L,1L,7L,2L,20L,1L,8L,4L,10L,2L,32L,4L,12L,1L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112229Inst : IEnumerable<long>
{
public static readonly long[] Value=A112229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112229.Bytes);
public long this[int i]=>Value[i];

public static A112229Inst Instance=new A112229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112230
{
public static readonly long[] Value={ 13L,13L,89L,83L,449L,89L,5711L,1511L,701L,449L,8117L,479L,27611L,5711L,1889L,10079L,241739L,701L,145349L,4139L,14489L,8117L,28151L,7079L,25349L,27611L,29537L,5711L,85607L,1889L,212411L,18719L,13331L,241739L,19949L,2699L,220667L,145349L,12401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112230Inst : IEnumerable<long>
{
public static readonly long[] Value=A112230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112230.Bytes);
public long this[int i]=>Value[i];

public static A112230Inst Instance=new A112230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112231
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,5L,5L,6L,7L,7L,8L,9L,10L,11L,11L,12L,13L,13L,14L,15L,16L,17L,17L,18L,19L,19L,20L,21L,22L,23L,23L,24L,25L,26L,27L,28L,29L,29L,30L,31L,31L,32L,33L,34L,35L,36L,37L,37L,38L,39L,40L,41L,41L,42L,43L,43L,44L,45L,46L,47L,47L,48L,49L,50L,51L,52L,53L,53L,54L,55L,56L,57L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112231Inst : IEnumerable<long>
{
public static readonly long[] Value=A112231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112231.Bytes);
public long this[int i]=>Value[i];

public static A112231Inst Instance=new A112231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112232
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,5L,6L,6L,7L,8L,8L,9L,9L,10L,10L,11L,12L,12L,13L,14L,14L,15L,15L,16L,16L,17L,18L,18L,19L,20L,20L,21L,21L,22L,22L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L,30L,30L,31L,32L,32L,33L,33L,34L,34L,35L,35L,36L,36L,37L,38L,38L,39L,39L,40L,40L,41L,42L,42L,43L,44L,44L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112232Inst : IEnumerable<long>
{
public static readonly long[] Value=A112232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112232.Bytes);
public long this[int i]=>Value[i];

public static A112232Inst Instance=new A112232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112233
{
public static readonly long[] Value={ 2L,4L,5L,7L,7L,9L,11L,11L,13L,15L,15L,17L,18L,20L,21L,22L,24L,25L,26L,28L,29L,31L,32L,33L,34L,36L,37L,38L,40L,42L,43L,44L,45L,47L,48L,50L,52L,53L,54L,55L,57L,57L,59L,60L,62L,63L,65L,67L,67L,69L,71L,72L,74L,74L,76L,77L,78L,79L,81L,82L,84L,85L,86L,88L,89L,91L,92L,94L,95L,96L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112233Inst : IEnumerable<long>
{
public static readonly long[] Value=A112233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112233.Bytes);
public long this[int i]=>Value[i];

public static A112233Inst Instance=new A112233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112234
{
public static readonly long[] Value={ 1L,3L,6L,8L,10L,12L,14L,16L,19L,23L,27L,30L,35L,39L,41L,46L,49L,51L,56L,58L,61L,64L,66L,68L,70L,73L,75L,80L,83L,87L,90L,93L,97L,99L,102L,107L,111L,114L,117L,119L,122L,124L,126L,131L,134L,137L,141L,143L,148L,151L,154L,156L,158L,161L,164L,167L,171L,173L,178L,180L,183L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112234Inst : IEnumerable<long>
{
public static readonly long[] Value=A112234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112234.Bytes);
public long this[int i]=>Value[i];

public static A112234Inst Instance=new A112234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112235
{
public static readonly long[] Value={ 2L,4L,5L,7L,9L,11L,13L,15L,17L,18L,20L,21L,22L,24L,25L,26L,28L,29L,31L,32L,33L,34L,36L,37L,38L,40L,42L,43L,44L,45L,47L,48L,50L,52L,53L,54L,55L,57L,59L,60L,62L,63L,65L,67L,69L,71L,72L,74L,76L,77L,78L,79L,81L,82L,84L,85L,86L,88L,89L,91L,92L,94L,95L,96L,98L,100L,101L,103L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112235Inst : IEnumerable<long>
{
public static readonly long[] Value=A112235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112235.Bytes);
public long this[int i]=>Value[i];

public static A112235Inst Instance=new A112235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112236
{
public static readonly long[] Value={ 1L,3L,12L,24L,42L,46L,42L,24L,12L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112236Inst : IEnumerable<long>
{
public static readonly long[] Value=A112236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112236.Bytes);
public long this[int i]=>Value[i];

public static A112236Inst Instance=new A112236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112237
{
public static readonly BigInteger[] Value={ 1L,2L,3L,8L,144L,BigInteger.Parse("9969216677189303386214405760200") };
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
public class A112237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112237Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112237.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112237.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112237Inst Instance=new A112237Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112238
{
public static readonly long[] Value={ 1L,0L,0L,0L,3L,0L,4L,6L,7L,9L,2L,9L,1L,6L,4L,8L,2L,9L,1L,5L,9L,2L,4L,9L,9L,5L,1L,4L,1L,9L,2L,2L,6L,3L,7L,0L,2L,7L,2L,6L,5L,3L,6L,6L,3L,5L,8L,5L,5L,8L,4L,3L,9L,7L,3L,7L,8L,0L,6L,8L,8L,5L,6L,2L,1L,3L,3L,9L,9L,7L,0L,7L,9L,9L,9L,7L,6L,5L,7L,6L,7L,1L,6L,5L,2L,2L,6L,6L,7L,1L,0L,9L,0L,6L,8L,8L,8L,9L,2L,3L,1L,2L,7L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112238Inst : IEnumerable<long>
{
public static readonly long[] Value=A112238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112238.Bytes);
public long this[int i]=>Value[i];

public static A112238Inst Instance=new A112238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112239
{
public static readonly long[] Value={ 0L,0L,0L,1L,-2L,0L,3L,3L,-6L,0L,12L,12L,6L,-12L,0L,60L,60L,30L,10L,-20L,0L,360L,360L,180L,60L,15L,-30L,0L,2520L,2520L,1260L,420L,105L,21L,-42L,0L,20160L,20160L,10080L,3360L,840L,168L,28L,-56L,0L,181440L,181440L,90720L,30240L,7560L,1512L,252L,36L,-72L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112239Inst : IEnumerable<long>
{
public static readonly long[] Value=A112239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112239.Bytes);
public long this[int i]=>Value[i];

public static A112239Inst Instance=new A112239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112240
{
public static readonly BigInteger[] Value={ 1L,1L,3L,25L,217L,2541L,34531L,550453L,9957585L,202137337L,4543312771L,112004037201L,3003936136873L,87057179039845L,2710682505789987L,90230919126896941L,3197152300287286561L,BigInteger.Parse("120131212083966304113") };
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
public class A112240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112240Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112240.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112240.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112240Inst Instance=new A112240Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112241
{
public static readonly BigInteger[] Value={ 1L,1L,5L,49L,601L,9281L,170941L,3662065L,89368049L,2446433281L,74212220341L,2470200090161L,89490288001225L,3504680581915969L,147513939627740141L,6639918363792119281L,BigInteger.Parse("318237954786998696161"),BigInteger.Parse("16178761263710217424385") };
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
public class A112241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112241Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112241.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112241.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112241Inst Instance=new A112241Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112242
{
public static readonly BigInteger[] Value={ 1L,1L,5L,25L,169L,1361L,12781L,136585L,1633745L,21594529L,312239701L,4898379641L,82810239865L,1500015354865L,28970936174909L,594083320767721L,12886811207794081L,294742414455540545L,7087332775240107685L,BigInteger.Parse("178707496551303048409"),BigInteger.Parse("4714241296084031285321"),BigInteger.Parse("129830157857411005318801") };
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
public class A112242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112242Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112242.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112242.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112242Inst Instance=new A112242Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112243
{
public static readonly BigInteger[] Value={ 1L,1L,7L,55L,577L,7441L,113671L,2003527L,39971905L,889608097L,21834577351L,585555975511L,17027451783937L,533460597334705L,17908302027585607L,641152804988733031L,BigInteger.Parse("24380543011087797121"),BigInteger.Parse("981149507717921468737") };
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
public class A112243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112243Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112243.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112243.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112243Inst Instance=new A112243Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112244
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,5L,2L,3L,2L,8L,0L,4L,3L,9L,0L,7L,6L,6L,5L,4L,2L,8L,4L,2L,6L,4L,3L,4L,2L,1L,2L,5L,7L,3L,8L,0L,1L,4L,7L,8L,9L,1L,1L,8L,0L,4L,2L,2L,1L,4L,4L,5L,5L,6L,4L,7L,1L,4L,0L,3L,3L,7L,8L,3L,0L,3L,6L,9L,9L,8L,4L,9L,1L,1L,5L,1L,0L,4L,9L,0L,5L,5L,5L,3L,1L,3L,9L,1L,9L,4L,7L,4L,1L,2L,7L,1L,5L,8L,9L,5L,4L,3L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112244Inst : IEnumerable<long>
{
public static readonly long[] Value=A112244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112244.Bytes);
public long this[int i]=>Value[i];

public static A112244Inst Instance=new A112244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112245
{
public static readonly long[] Value={ 287L,1695L,81359L,512895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112245Inst : IEnumerable<long>
{
public static readonly long[] Value=A112245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112245.Bytes);
public long this[int i]=>Value[i];

public static A112245Inst Instance=new A112245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112246
{
public static readonly long[] Value={ 1L,0L,0L,0L,6L,0L,9L,4L,5L,1L,4L,1L,2L,7L,6L,7L,3L,4L,2L,4L,8L,9L,7L,2L,5L,9L,7L,6L,6L,9L,2L,3L,2L,0L,1L,9L,7L,6L,9L,4L,5L,0L,2L,8L,9L,1L,5L,8L,4L,1L,6L,1L,1L,9L,0L,2L,1L,3L,6L,3L,6L,8L,0L,6L,4L,0L,2L,0L,9L,5L,3L,7L,2L,1L,6L,1L,4L,1L,3L,5L,9L,4L,7L,5L,5L,7L,9L,4L,0L,0L,2L,6L,3L,8L,7L,5L,7L,5L,9L,1L,0L,8L,7L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112246Inst : IEnumerable<long>
{
public static readonly long[] Value=A112246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112246.Bytes);
public long this[int i]=>Value[i];

public static A112246Inst Instance=new A112246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112247
{
public static readonly long[] Value={ 1L,0L,0L,0L,4L,5L,7L,0L,5L,3L,7L,4L,6L,7L,5L,6L,4L,7L,2L,9L,7L,8L,2L,8L,8L,3L,1L,3L,8L,1L,8L,4L,0L,0L,4L,5L,8L,9L,1L,6L,9L,9L,8L,3L,5L,5L,6L,2L,1L,3L,0L,2L,6L,3L,3L,4L,2L,0L,0L,9L,2L,6L,0L,6L,4L,8L,3L,8L,1L,6L,0L,9L,1L,9L,4L,0L,1L,7L,2L,0L,7L,8L,3L,8L,2L,2L,2L,0L,2L,8L,8L,2L,4L,8L,4L,8L,7L,4L,7L,1L,3L,9L,5L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112247Inst : IEnumerable<long>
{
public static readonly long[] Value=A112247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112247.Bytes);
public long this[int i]=>Value[i];

public static A112247Inst Instance=new A112247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112248
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,2L,3L,4L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112248Inst : IEnumerable<long>
{
public static readonly long[] Value=A112248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112248.Bytes);
public long this[int i]=>Value[i];

public static A112248Inst Instance=new A112248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112249
{
public static readonly long[] Value={ 2L,3L,4L,6L,9L,12L,15L,16L,20L,24L,28L,35L,40L,45L,50L,55L,60L,66L,72L,78L,84L,90L,96L,102L,108L,114L,120L,126L,133L,140L,147L,154L,161L,168L,175L,182L,189L,196L,203L,210L,217L,224L,231L,238L,245L,252L,256L,264L,272L,280L,288L,296L,304L,312L,320L,328L,336L,344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112249Inst : IEnumerable<long>
{
public static readonly long[] Value=A112249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112249.Bytes);
public long this[int i]=>Value[i];

public static A112249Inst Instance=new A112249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112250
{
public static readonly long[] Value={ 5L,7L,8L,10L,11L,13L,14L,17L,18L,19L,21L,22L,23L,25L,26L,27L,29L,30L,31L,32L,33L,34L,36L,37L,38L,39L,41L,42L,43L,44L,46L,47L,48L,49L,51L,52L,53L,54L,56L,57L,58L,59L,61L,62L,63L,64L,65L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,79L,80L,81L,82L,83L,85L,86L,87L,88L,89L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112250Inst : IEnumerable<long>
{
public static readonly long[] Value=A112250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112250.Bytes);
public long this[int i]=>Value[i];

public static A112250Inst Instance=new A112250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112251
{
public static readonly long[] Value={ 5L,7L,10L,13L,17L,21L,25L,29L,36L,41L,46L,51L,56L,61L,67L,73L,79L,85L,91L,97L,103L,109L,115L,121L,127L,134L,141L,148L,155L,162L,169L,176L,183L,190L,197L,204L,211L,218L,225L,232L,239L,246L,253L,257L,265L,273L,281L,289L,297L,305L,313L,321L,329L,337L,345L,353L,361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112251Inst : IEnumerable<long>
{
public static readonly long[] Value=A112251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112251.Bytes);
public long this[int i]=>Value[i];

public static A112251Inst Instance=new A112251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112252
{
public static readonly long[] Value={ 1L,0L,0L,0L,7L,6L,1L,8L,7L,2L,2L,9L,3L,2L,1L,6L,5L,7L,1L,5L,3L,0L,6L,2L,5L,8L,5L,6L,1L,7L,6L,0L,4L,8L,4L,6L,9L,0L,6L,9L,0L,5L,1L,9L,3L,6L,5L,8L,4L,0L,2L,1L,4L,2L,1L,0L,7L,3L,3L,2L,3L,4L,7L,7L,1L,4L,9L,1L,5L,8L,8L,9L,1L,8L,7L,4L,5L,3L,7L,1L,4L,9L,7L,1L,0L,8L,7L,2L,2L,4L,0L,5L,7L,6L,4L,3L,6L,9L,4L,7L,7L,2L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112252Inst : IEnumerable<long>
{
public static readonly long[] Value=A112252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112252.Bytes);
public long this[int i]=>Value[i];

public static A112252Inst Instance=new A112252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112253
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,7L,6L,1L,6L,1L,1L,2L,1L,6L,9L,5L,6L,0L,3L,7L,4L,7L,9L,3L,1L,2L,6L,0L,9L,2L,7L,7L,3L,6L,6L,3L,2L,8L,0L,8L,9L,1L,2L,7L,0L,8L,0L,1L,8L,6L,2L,0L,1L,3L,1L,2L,9L,7L,2L,3L,3L,1L,9L,9L,9L,6L,8L,4L,1L,2L,1L,6L,2L,9L,2L,6L,1L,3L,9L,4L,3L,0L,6L,8L,0L,3L,7L,7L,0L,6L,1L,1L,2L,5L,1L,9L,6L,6L,3L,1L,8L,1L,0L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112253Inst : IEnumerable<long>
{
public static readonly long[] Value=A112253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112253.Bytes);
public long this[int i]=>Value[i];

public static A112253Inst Instance=new A112253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112254
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,5L,0L,7L,7L,3L,4L,3L,6L,6L,5L,0L,3L,8L,8L,8L,6L,2L,3L,6L,1L,5L,5L,3L,8L,7L,0L,2L,3L,0L,1L,4L,3L,8L,6L,4L,3L,8L,2L,9L,0L,3L,9L,7L,7L,2L,1L,8L,4L,4L,6L,2L,0L,6L,3L,5L,4L,9L,6L,1L,8L,9L,3L,0L,5L,7L,9L,1L,9L,8L,4L,3L,4L,2L,7L,4L,0L,1L,5L,1L,1L,4L,1L,4L,8L,8L,5L,6L,4L,1L,7L,2L,4L,0L,8L,8L,2L,0L,2L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112254Inst : IEnumerable<long>
{
public static readonly long[] Value=A112254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112254.Bytes);
public long this[int i]=>Value[i];

public static A112254Inst Instance=new A112254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112255
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,3L,8L,0L,7L,9L,8L,3L,5L,8L,1L,0L,8L,5L,4L,1L,8L,3L,1L,5L,9L,2L,9L,7L,9L,5L,5L,7L,7L,0L,2L,7L,1L,3L,6L,9L,0L,6L,6L,4L,2L,2L,3L,7L,4L,3L,9L,5L,9L,9L,9L,4L,0L,1L,6L,8L,0L,9L,1L,6L,0L,9L,7L,6L,5L,0L,7L,0L,6L,3L,5L,4L,8L,3L,6L,4L,0L,8L,1L,7L,0L,1L,2L,2L,6L,4L,7L,3L,7L,7L,2L,8L,2L,2L,0L,3L,3L,6L,6L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112255Inst : IEnumerable<long>
{
public static readonly long[] Value=A112255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112255.Bytes);
public long this[int i]=>Value[i];

public static A112255Inst Instance=new A112255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112256
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,3L,0L,4L,6L,3L,7L,5L,2L,6L,4L,4L,5L,3L,8L,6L,7L,3L,4L,1L,8L,7L,4L,6L,9L,4L,4L,6L,1L,5L,0L,7L,8L,0L,8L,0L,5L,2L,1L,7L,1L,0L,2L,3L,1L,9L,4L,7L,6L,1L,5L,7L,2L,8L,6L,2L,5L,5L,9L,5L,7L,9L,4L,3L,2L,0L,1L,1L,6L,1L,6L,3L,3L,3L,3L,8L,6L,3L,8L,4L,8L,8L,2L,5L,0L,1L,4L,7L,7L,5L,3L,6L,9L,6L,1L,3L,0L,5L,2L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112256Inst : IEnumerable<long>
{
public static readonly long[] Value=A112256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112256.Bytes);
public long this[int i]=>Value[i];

public static A112256Inst Instance=new A112256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112257
{
public static readonly long[] Value={ 2L,7L,1L,8L,6L,9L,5L,9L,3L,0L,5L,5L,1L,6L,4L,4L,2L,9L,6L,0L,6L,1L,5L,0L,6L,9L,1L,4L,1L,6L,0L,7L,4L,8L,7L,5L,5L,9L,7L,3L,8L,6L,1L,0L,7L,6L,0L,4L,6L,7L,7L,0L,2L,2L,4L,0L,4L,9L,0L,8L,3L,0L,7L,5L,4L,3L,8L,8L,7L,9L,2L,6L,7L,3L,6L,7L,0L,3L,0L,5L,5L,6L,1L,1L,4L,4L,1L,2L,8L,6L,9L,9L,8L,7L,7L,6L,0L,1L,0L,6L,3L,0L,2L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112257Inst : IEnumerable<long>
{
public static readonly long[] Value=A112257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112257.Bytes);
public long this[int i]=>Value[i];

public static A112257Inst Instance=new A112257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112258
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,12L,13L,14L,17L,23L,29L,39L,61L,81L,95L,119L,164L,242L,5193L,9004L,23432L,246968L,8876708L,32886598L,2141194665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112258Inst : IEnumerable<long>
{
public static readonly long[] Value=A112258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112258.Bytes);
public long this[int i]=>Value[i];

public static A112258Inst Instance=new A112258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112259
{
public static readonly long[] Value={ 1L,5L,9L,605L,961L,16245L,284089L,29645L,15046641L,101025125L,73222249L,9908816445L,23755748641L,204034140245L,5031349566489L,1965713970605L,219320727489361L,1965265930868805L,374345220088009L,158335559155140125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112259Inst : IEnumerable<long>
{
public static readonly long[] Value=A112259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112259.Bytes);
public long this[int i]=>Value[i];

public static A112259Inst Instance=new A112259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112260
{
public static readonly long[] Value={ 1L,-1L,-1L,11L,31L,19L,-41L,11L,431L,899L,199L,-1349L,1951L,15539L,24119L,-5269L,-36209L,115939L,522919L,583451L,-459649L,-696301L,5336599L,16510411L,11941231L,-20545981L,-1202041L,215199611L,488443231L,164515699L,-715515401L,773905451L,7930934351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112260Inst : IEnumerable<long>
{
public static readonly long[] Value=A112260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112260.Bytes);
public long this[int i]=>Value[i];

public static A112260Inst Instance=new A112260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112261
{
public static readonly long[] Value={ -2L,0L,12L,20L,-12L,-60L,52L,420L,468L,-700L,-1548L,3300L,13588L,8580L,-29388L,-30940L,152148L,406980L,60532L,-1043100L,-236652L,6032900L,11173812L,-4569180L,-32487212L,19343940L,216401652L,273243620L,-323927532L,-880031100L,1489420852L,7157028900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112261Inst : IEnumerable<long>
{
public static readonly long[] Value=A112261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112261.Bytes);
public long this[int i]=>Value[i];

public static A112261Inst Instance=new A112261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112262
{
public static readonly long[] Value={ 1L,4L,9L,24L,58L,171L,340L,1097L,2673L,5467L,13353L,35957L,128823L,451488L,494198L,499871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112262Inst : IEnumerable<long>
{
public static readonly long[] Value=A112262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112262.Bytes);
public long this[int i]=>Value[i];

public static A112262Inst Instance=new A112262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112263
{
public static readonly long[] Value={ 1L,4L,13L,23L,61L,177L,444L,1325L,3716L,8186L,18168L,62025L,275360L,461299L,498201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112263Inst : IEnumerable<long>
{
public static readonly long[] Value=A112263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112263.Bytes);
public long this[int i]=>Value[i];

public static A112263Inst Instance=new A112263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112264
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,5L,7L,6L,6L,7L,1L,7L,1L,9L,8L,8L,1L,8L,1L,9L,10L,3L,2L,9L,10L,3L,9L,11L,2L,10L,3L,10L,4L,3L,12L,10L,3L,3L,4L,11L,4L,12L,4L,5L,11L,4L,4L,11L,14L,12L,4L,5L,5L,11L,6L,13L,4L,4L,5L,12L,6L,5L,13L,12L,6L,6L,6L,5L,5L,14L,7L,12L,7L,5L,13L,5L,8L,6L,7L,13L,12L,6L,8L,14L,6L,6L,5L,7L,8L,13L,8L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112264Inst : IEnumerable<long>
{
public static readonly long[] Value=A112264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112264.Bytes);
public long this[int i]=>Value[i];

public static A112264Inst Instance=new A112264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112265
{
public static readonly long[] Value={ 0L,2L,5L,9L,14L,19L,26L,32L,38L,45L,46L,53L,54L,63L,71L,79L,80L,88L,89L,98L,108L,111L,113L,122L,132L,135L,144L,155L,157L,167L,170L,180L,184L,187L,199L,209L,212L,215L,219L,230L,234L,246L,250L,255L,266L,270L,274L,285L,299L,311L,315L,320L,325L,336L,342L,355L,359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112265Inst : IEnumerable<long>
{
public static readonly long[] Value=A112265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112265.Bytes);
public long this[int i]=>Value[i];

public static A112265Inst Instance=new A112265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112266
{
public static readonly long[] Value={ 2L,5L,19L,53L,71L,79L,89L,113L,157L,167L,199L,311L,359L,439L,521L,541L,587L,593L,613L,769L,947L,977L,1009L,1097L,1171L,1223L,1249L,1289L,1427L,1447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112266Inst : IEnumerable<long>
{
public static readonly long[] Value=A112266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112266.Bytes);
public long this[int i]=>Value[i];

public static A112266Inst Instance=new A112266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112267
{
public static readonly long[] Value={ 3L,6L,7L,8L,2L,3L,4L,0L,7L,0L,8L,3L,6L,6L,4L,6L,7L,2L,8L,3L,6L,1L,3L,6L,8L,1L,1L,2L,7L,1L,6L,5L,6L,2L,1L,5L,1L,3L,3L,4L,9L,0L,7L,7L,0L,1L,4L,7L,2L,7L,5L,2L,6L,1L,3L,8L,7L,9L,2L,9L,6L,3L,4L,7L,7L,4L,4L,7L,3L,1L,2L,4L,3L,3L,4L,5L,8L,4L,1L,3L,0L,9L,7L,2L,1L,8L,7L,2L,2L,9L,8L,2L,9L,1L,9L,4L,7L,6L,5L,7L,8L,2L,6L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112267Inst : IEnumerable<long>
{
public static readonly long[] Value=A112267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112267.Bytes);
public long this[int i]=>Value[i];

public static A112267Inst Instance=new A112267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112268
{
public static readonly long[] Value={ 1L,0L,1L,8L,0L,10L,25L,20L,25L,30L,209L,88L,209L,494L,1729L,494L,1984L,744L,2500L,2450L,2500L,2550L,1984L,5288L,1729L,6048L,14336L,3008L,17284L,4938L,17284L,60494L,14336L,68320L,122449L,20408L,126201L,21948L,148761L,33058L,152100L,35010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112268Inst : IEnumerable<long>
{
public static readonly long[] Value=A112268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112268.Bytes);
public long this[int i]=>Value[i];

public static A112268Inst Instance=new A112268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112269
{
public static readonly long[] Value={ 5L,8L,15L,13L,9L,19L,29L,19L,30L,78L,15L,20L,36L,83L,30L,34L,65L,69L,101L,133L,32L,19L,271L,110L,20L,187L,14L,185L,106L,173L,587L,80L,12L,35L,46L,224L,72L,38L,42L,315L,101L,26L,73L,172L,383L,27L,84L,362L,35L,250L,37L,29L,507L,305L,55L,38L,178L,332L,62L,537L,778L,459L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112269Inst : IEnumerable<long>
{
public static readonly long[] Value=A112269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112269.Bytes);
public long this[int i]=>Value[i];

public static A112269Inst Instance=new A112269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112270
{
public static readonly long[] Value={ 43L,127L,167L,213L,321L,387L,457L,531L,617L,709L,809L,1029L,1149L,1277L,1409L,1863L,2027L,2290L,3397L,3629L,4113L,4367L,4629L,4899L,5179L,5467L,5761L,6063L,6371L,7516L,7864L,8600L,8980L,9368L,10168L,10578L,11856L,12296L,12746L,13204L,13674L,14156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112270Inst : IEnumerable<long>
{
public static readonly long[] Value=A112270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112270.Bytes);
public long this[int i]=>Value[i];

public static A112270Inst Instance=new A112270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112271
{
public static readonly long[] Value={ 1L,2L,20L,32L,88L,212L,296L,344L,1070L,1166L,1374L,1655L,2248L,2698L,3368L,3730L,3916L,4936L,5160L,5388L,6725L,6983L,8788L,11338L,12382L,12923L,13480L,15026L,16244L,17717L,19033L,19481L,19937L,21108L,24584L,29191L,30345L,33008L,33921L,34850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112271Inst : IEnumerable<long>
{
public static readonly long[] Value=A112271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112271.Bytes);
public long this[int i]=>Value[i];

public static A112271Inst Instance=new A112271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112272
{
public static readonly long[] Value={ 4L,11L,34L,113L,284L,441L,634L,731L,943L,1226L,1657L,2343L,2469L,3767L,3931L,4271L,4712L,5759L,5963L,7154L,8221L,8467L,8971L,9362L,9763L,12655L,13279L,13595L,13915L,15941L,17560L,19641L,21261L,21675L,22091L,22937L,23363L,23793L,24671L,26702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112272Inst : IEnumerable<long>
{
public static readonly long[] Value=A112272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112272.Bytes);
public long this[int i]=>Value[i];

public static A112272Inst Instance=new A112272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112273
{
public static readonly long[] Value={ 5L,15L,365L,945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112273Inst : IEnumerable<long>
{
public static readonly long[] Value=A112273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112273.Bytes);
public long this[int i]=>Value[i];

public static A112273Inst Instance=new A112273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112274
{
public static readonly long[] Value={ 1L,-1L,-1L,2L,0L,-2L,2L,1L,-4L,1L,4L,-4L,-1L,6L,-3L,-6L,7L,3L,-10L,4L,10L,-12L,-6L,18L,-5L,-18L,20L,8L,-30L,10L,29L,-31L,-12L,46L,-17L,-44L,47L,20L,-68L,23L,66L,-72L,-31L,104L,-33L,-98L,107L,44L,-156L,51L,144L,-154L,-61L,220L,-75L,-206L,220L,90L,-310L,104L,290L,-312L,-131L,442L,-143L,-408L,437L,178L,-618L,202L,567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112274Inst : IEnumerable<long>
{
public static readonly long[] Value=A112274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112274.Bytes);
public long this[int i]=>Value[i];

public static A112274Inst Instance=new A112274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112275
{
public static readonly long[] Value={ 2L,3L,4L,6L,6L,8L,8L,10L,10L,12L,12L,18L,14L,15L,16L,18L,18L,20L,20L,24L,22L,24L,24L,30L,26L,27L,28L,30L,30L,36L,32L,36L,34L,35L,36L,48L,38L,39L,40L,42L,42L,48L,44L,45L,48L,48L,48L,60L,50L,52L,52L,54L,54L,56L,56L,60L,58L,60L,60L,72L,62L,63L,64L,66L,66L,70L,68L,70L,70L,72L,72L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112275Inst : IEnumerable<long>
{
public static readonly long[] Value=A112275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112275.Bytes);
public long this[int i]=>Value[i];

public static A112275Inst Instance=new A112275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112276
{
public static readonly long[] Value={ 1L,3L,5L,5L,7L,7L,11L,9L,11L,11L,13L,13L,17L,15L,17L,17L,19L,19L,23L,21L,22L,23L,29L,25L,29L,27L,29L,29L,31L,31L,37L,33L,34L,35L,37L,37L,41L,39L,41L,41L,43L,43L,47L,45L,46L,47L,53L,49L,53L,51L,53L,53L,59L,55L,57L,57L,58L,59L,61L,61L,67L,65L,65L,65L,67L,67L,71L,69L,71L,71L,73L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112276Inst : IEnumerable<long>
{
public static readonly long[] Value=A112276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112276.Bytes);
public long this[int i]=>Value[i];

public static A112276Inst Instance=new A112276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112277
{
public static readonly long[] Value={ 8L,14L,20L,21L,24L,26L,32L,33L,34L,38L,44L,45L,48L,50L,54L,55L,56L,57L,62L,63L,64L,68L,74L,75L,76L,80L,81L,84L,85L,86L,90L,91L,92L,93L,94L,98L,104L,105L,110L,114L,115L,116L,117L,118L,119L,120L,122L,123L,124L,128L,132L,133L,135L,140L,141L,142L,143L,144L,145L,147L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112277Inst : IEnumerable<long>
{
public static readonly long[] Value=A112277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112277.Bytes);
public long this[int i]=>Value[i];

public static A112277Inst Instance=new A112277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112278
{
public static readonly long[] Value={ 1L,2L,4L,8L,20L,72L,360L,282L,422L,80L,410L,30L,114L,44L,194L,492L,480L,410L,30L,114L,44L,194L,492L,480L,410L,30L,114L,44L,194L,492L,480L,410L,30L,114L,44L,194L,492L,480L,410L,30L,114L,44L,194L,492L,480L,410L,30L,114L,44L,194L,492L,480L,410L,30L,114L,44L,194L,492L,480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112278Inst : IEnumerable<long>
{
public static readonly long[] Value=A112278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112278.Bytes);
public long this[int i]=>Value[i];

public static A112278Inst Instance=new A112278Inst();

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