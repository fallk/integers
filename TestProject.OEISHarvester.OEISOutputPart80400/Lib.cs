using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A100041
{
public static readonly long[] Value={ -7L,-4L,3L,14L,29L,48L,71L,98L,129L,164L,203L,246L,293L,344L,399L,458L,521L,588L,659L,734L,813L,896L,983L,1074L,1169L,1268L,1371L,1478L,1589L,1704L,1823L,1946L,2073L,2204L,2339L,2478L,2621L,2768L,2919L,3074L,3233L,3396L,3563L,3734L,3909L,4088L,4271L,4458L,4649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100041Inst : IEnumerable<long>
{
public static readonly long[] Value=A100041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100041.Bytes);
public long this[int i]=>Value[i];

public static A100041Inst Instance=new A100041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100042
{
public static readonly BigInteger[] Value={ 8L,24L,160L,896L,22528L,106496L,2228224L,9961472L,192937984L,15569256448L,66571993088L,5085241278464L,90159953477632L,378231999954944L,6614661952700416L,477381560501272576L,BigInteger.Parse("34011184385901985792") };
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
public class A100042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100042Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100042.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100042.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100042Inst Instance=new A100042Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100043
{
public static readonly BigInteger[] Value={ 2L,120L,40320L,39916800L,87178291200L,355687428096000L,2432902008176640000L,BigInteger.Parse("25852016738884976640000"),BigInteger.Parse("403291461126605635584000000"),BigInteger.Parse("8841761993739701954543616000000"),BigInteger.Parse("263130836933693530167218012160000000") };
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
public class A100043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100043Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100043.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100043.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100043Inst Instance=new A100043Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100044
{
public static readonly long[] Value={ 1L,0L,9L,6L,6L,2L,2L,7L,1L,1L,2L,3L,2L,1L,5L,0L,9L,5L,7L,6L,4L,8L,2L,7L,6L,7L,7L,7L,7L,6L,4L,0L,1L,6L,7L,9L,2L,8L,1L,2L,6L,3L,3L,2L,6L,7L,4L,7L,1L,1L,9L,8L,9L,5L,8L,4L,9L,0L,3L,7L,2L,1L,5L,2L,9L,1L,3L,3L,3L,8L,3L,1L,3L,6L,0L,2L,1L,3L,3L,9L,1L,5L,8L,8L,9L,0L,8L,5L,9L,3L,3L,7L,4L,6L,5L,0L,5L,8L,0L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100044Inst : IEnumerable<long>
{
public static readonly long[] Value=A100044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100044.Bytes);
public long this[int i]=>Value[i];

public static A100044Inst Instance=new A100044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100045
{
public static readonly long[] Value={ 1L,4L,0L,1L,4L,8L,0L,5L,1L,3L,8L,9L,3L,2L,7L,8L,6L,4L,2L,7L,5L,0L,5L,6L,5L,4L,5L,4L,7L,9L,1L,5L,0L,9L,9L,0L,1L,4L,0L,8L,8L,3L,3L,4L,6L,7L,6L,9L,3L,5L,8L,8L,5L,8L,7L,4L,5L,4L,0L,1L,3L,3L,4L,2L,8L,2L,6L,7L,2L,6L,9L,5L,5L,3L,0L,3L,0L,2L,8L,0L,4L,8L,9L,3L,9L,1L,9L,6L,6L,6L,0L,3L,2L,9L,7L,5L,2L,0L,2L,0L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100045Inst : IEnumerable<long>
{
public static readonly long[] Value=A100045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100045.Bytes);
public long this[int i]=>Value[i];

public static A100045Inst Instance=new A100045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100046
{
public static readonly long[] Value={ 2L,5L,4L,3L,2L,2L,6L,0L,7L,4L,4L,2L,4L,6L,9L,6L,5L,4L,5L,1L,0L,1L,8L,7L,3L,3L,6L,3L,6L,7L,3L,8L,9L,1L,3L,1L,0L,6L,3L,9L,5L,7L,8L,5L,1L,6L,9L,6L,6L,0L,6L,4L,2L,5L,9L,3L,7L,2L,8L,3L,8L,6L,6L,1L,6L,3L,1L,3L,6L,3L,3L,1L,3L,8L,2L,9L,8L,9L,8L,2L,3L,7L,5L,1L,7L,8L,6L,2L,8L,4L,1L,5L,9L,0L,9L,8L,7L,6L,4L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100046Inst : IEnumerable<long>
{
public static readonly long[] Value=A100046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100046.Bytes);
public long this[int i]=>Value[i];

public static A100046Inst Instance=new A100046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100047
{
public static readonly long[] Value={ 0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100047Inst : IEnumerable<long>
{
public static readonly long[] Value=A100047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100047.Bytes);
public long this[int i]=>Value[i];

public static A100047Inst Instance=new A100047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100048
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,9L,16L,29L,56L,106L,198L,373L,704L,1325L,2494L,4698L,8848L,16661L,31376L,59089L,111276L,209554L,394634L,743177L,1399552L,2635641L,4963450L,9347186L,17602652L,33149377L,62427024L,117562789L,221394656L,416931194L,785166286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100048Inst : IEnumerable<long>
{
public static readonly long[] Value=A100048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100048.Bytes);
public long this[int i]=>Value[i];

public static A100048Inst Instance=new A100048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100049
{
public static readonly long[] Value={ 1L,0L,-1L,1L,-1L,-3L,3L,3L,-6L,2L,10L,-13L,-9L,29L,-9L,-43L,55L,32L,-126L,48L,183L,-243L,-121L,541L,-241L,-765L,1082L,450L,-2326L,1171L,3179L,-4803L,-1617L,9993L,-5601L,-13168L,21250L,5552L,-42849L,26489L,54351L,-93763L,-17765L,183347L,-124086L,-223422L,412698L,49827L,-782881L,576541L,914279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100049Inst : IEnumerable<long>
{
public static readonly long[] Value=A100049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100049.Bytes);
public long this[int i]=>Value[i];

public static A100049Inst Instance=new A100049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100050
{
public static readonly long[] Value={ 0L,1L,2L,0L,-4L,-5L,0L,7L,8L,0L,-10L,-11L,0L,13L,14L,0L,-16L,-17L,0L,19L,20L,0L,-22L,-23L,0L,25L,26L,0L,-28L,-29L,0L,31L,32L,0L,-34L,-35L,0L,37L,38L,0L,-40L,-41L,0L,43L,44L,0L,-46L,-47L,0L,49L,50L,0L,-52L,-53L,0L,55L,56L,0L,-58L,-59L,0L,61L,62L,0L,-64L,-65L,0L,67L,68L,0L,-70L,-71L,0L,73L,74L,0L,-76L,-77L,0L,79L,80L,0L,-82L,-83L,0L,85L,86L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100050Inst : IEnumerable<long>
{
public static readonly long[] Value=A100050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100050.Bytes);
public long this[int i]=>Value[i];

public static A100050Inst Instance=new A100050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100051
{
public static readonly long[] Value={ 1L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100051Inst : IEnumerable<long>
{
public static readonly long[] Value=A100051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100051.Bytes);
public long this[int i]=>Value[i];

public static A100051Inst Instance=new A100051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100052
{
public static readonly long[] Value={ 1L,3L,3L,-2L,-9L,-9L,2L,15L,15L,-2L,-21L,-21L,2L,27L,27L,-2L,-33L,-33L,2L,39L,39L,-2L,-45L,-45L,2L,51L,51L,-2L,-57L,-57L,2L,63L,63L,-2L,-69L,-69L,2L,75L,75L,-2L,-81L,-81L,2L,87L,87L,-2L,-93L,-93L,2L,99L,99L,-2L,-105L,-105L,2L,111L,111L,-2L,-117L,-117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100052Inst : IEnumerable<long>
{
public static readonly long[] Value=A100052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100052.Bytes);
public long this[int i]=>Value[i];

public static A100052Inst Instance=new A100052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100053
{
public static readonly long[] Value={ 0L,0L,2L,1L,3L,1L,4L,2L,5L,3L,4L,4L,3L,2L,4L,2L,6L,4L,4L,3L,5L,4L,4L,3L,5L,5L,4L,3L,4L,4L,4L,5L,8L,6L,5L,3L,5L,4L,5L,3L,5L,5L,5L,9L,7L,5L,11L,9L,7L,6L,8L,6L,4L,7L,5L,3L,5L,6L,5L,4L,4L,5L,5L,3L,14L,12L,10L,8L,6L,5L,4L,7L,5L,6L,4L,6L,4L,4L,6L,4L,6L,7L,5L,5L,4L,4L,11L,9L,7L,6L,4L,6L,7L,5L,7L,5L,8L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100053Inst : IEnumerable<long>
{
public static readonly long[] Value=A100053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100053.Bytes);
public long this[int i]=>Value[i];

public static A100053Inst Instance=new A100053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100054
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,8L,9L,11L,14L,15L,23L,24L,26L,28L,33L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100054Inst : IEnumerable<long>
{
public static readonly long[] Value=A100054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100054.Bytes);
public long this[int i]=>Value[i];

public static A100054Inst Instance=new A100054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100055
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,16L,32L,43L,46L,64L,128L,256L,512L,1024L,2048L,4096L,8192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100055Inst : IEnumerable<long>
{
public static readonly long[] Value=A100055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100055.Bytes);
public long this[int i]=>Value[i];

public static A100055Inst Instance=new A100055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100056
{
public static readonly long[] Value={ 1L,3L,7L,10L,16L,22L,27L,37L,47L,57L,67L,75L,91L,107L,123L,139L,155L,171L,187L,200L,226L,252L,278L,304L,330L,356L,382L,408L,434L,460L,486L,512L,533L,575L,617L,659L,701L,743L,785L,827L,869L,911L,953L,995L,1037L,1079L,1121L,1163L,1205L,1247L,1289L,1331L,1373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100056Inst : IEnumerable<long>
{
public static readonly long[] Value=A100056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100056.Bytes);
public long this[int i]=>Value[i];

public static A100056Inst Instance=new A100056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100057
{
public static readonly long[] Value={ 2L,4L,8L,12L,18L,24L,30L,40L,50L,60L,70L,80L,96L,112L,128L,144L,160L,176L,192L,208L,234L,260L,286L,312L,338L,364L,390L,416L,442L,468L,494L,520L,546L,588L,630L,672L,714L,756L,798L,840L,882L,924L,966L,1008L,1050L,1092L,1134L,1176L,1218L,1260L,1302L,1344L,1386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100057Inst : IEnumerable<long>
{
public static readonly long[] Value=A100057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100057.Bytes);
public long this[int i]=>Value[i];

public static A100057Inst Instance=new A100057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100058
{
public static readonly long[] Value={ 1L,3L,10L,31L,97L,302L,941L,2931L,9130L,28439L,88585L,275934L,859509L,2677291L,8339514L,25976815L,80915377L,252043918L,785093501L,2445493667L,7617486666L,23727766663L,73909799321L,230222191294L,717120839877L,2233765112283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100058Inst : IEnumerable<long>
{
public static readonly long[] Value=A100058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100058.Bytes);
public long this[int i]=>Value[i];

public static A100058Inst Instance=new A100058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100059
{
public static readonly long[] Value={ 1L,5L,14L,45L,139L,434L,1351L,4209L,13110L,40837L,127203L,396226L,1234207L,3844441L,11975078L,37301261L,116189979L,361921042L,1127350583L,3511592833L,10938286998L,34071752661L,106130359315L,330586256610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100059Inst : IEnumerable<long>
{
public static readonly long[] Value=A100059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100059.Bytes);
public long this[int i]=>Value[i];

public static A100059Inst Instance=new A100059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100060
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100060Inst : IEnumerable<long>
{
public static readonly long[] Value=A100060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100060.Bytes);
public long this[int i]=>Value[i];

public static A100060Inst Instance=new A100060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100061
{
public static readonly BigInteger[] Value={ 1L,10L,100L,1000L,10000L,100000L,1000000L,10000000L,100000000L,612579511L,5738374621L,53509541320L,496353364300L,4576113154000L,41886926650000L,380127217600000L,3413851687000000L,30264311980000000L,263901070900000000L,2401684855296999121L,BigInteger.Parse("21793684651236981541"),BigInteger.Parse("197206153848009709930") };
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
public class A100061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100061Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100061.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100061.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100061Inst Instance=new A100061Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100062
{
public static readonly long[] Value={ 9L,81L,729L,6561L,59049L,531441L,4782969L,43046721L,387420489L,3486784401L,31381059609L,282429536481L,2541865828329L,22876792454961L,205891132094649L,1853020188851841L,16677181699666569L,150094635296999121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100062Inst : IEnumerable<long>
{
public static readonly long[] Value=A100062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100062.Bytes);
public long this[int i]=>Value[i];

public static A100062Inst Instance=new A100062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100063
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100063Inst : IEnumerable<long>
{
public static readonly long[] Value=A100063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100063.Bytes);
public long this[int i]=>Value[i];

public static A100063Inst Instance=new A100063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100064
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,8L,1L,3L,15L,51L,1L,4L,24L,120L,408L,1L,5L,35L,225L,1215L,4365L,1L,6L,48L,372L,2628L,15084L,53856L,1L,7L,63L,567L,4851L,36603L,216405L,777609L,1L,8L,80L,816L,8112L,74352L,585792L,3558672L,12810240L,1L,9L,99L,1125L,12663L,135081L,1301157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100064Inst : IEnumerable<long>
{
public static readonly long[] Value=A100064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100064.Bytes);
public long this[int i]=>Value[i];

public static A100064Inst Instance=new A100064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100065
{
public static readonly BigInteger[] Value={ 1L,1L,3L,-3L,-57L,369L,3861L,-76617L,-413775L,26879103L,-52349229L,-13272657111L,163271276343L,8454393401121L,-248550519324411L,-5938622542044441L,389600359347114081L,2878180608333977343L,BigInteger.Parse("-677734293694386004317"),BigInteger.Parse("5701654525891937630409") };
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
public class A100065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100065Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100065.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100065.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100065Inst Instance=new A100065Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100066
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,9L,9L,29L,29L,99L,99L,351L,351L,1275L,1275L,4707L,4707L,17577L,17577L,66197L,66197L,250953L,250953L,956385L,956385L,3660541L,3660541L,14061141L,14061141L,54177741L,54177741L,209295261L,209295261L,810375651L,810375651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100066Inst : IEnumerable<long>
{
public static readonly long[] Value=A100066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100066.Bytes);
public long this[int i]=>Value[i];

public static A100066Inst Instance=new A100066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100067
{
public static readonly long[] Value={ 1L,2L,6L,14L,38L,92L,240L,590L,1510L,3740L,9476L,23564L,59372L,147968L,371636L,927374L,2324870L,5805740L,14538660L,36322340L,90898228L,227153192L,568235696L,1420236524L,3551943388L,8878506392L,22201466280L,55498465400L,138766221800L,346895496200L,867316299260L,2168213189390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100067Inst : IEnumerable<long>
{
public static readonly long[] Value=A100067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100067.Bytes);
public long this[int i]=>Value[i];

public static A100067Inst Instance=new A100067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100068
{
public static readonly long[] Value={ 1L,3L,11L,36L,123L,408L,1370L,4560L,15235L,50760L,169326L,564336L,1881582L,6271632L,20907156L,69689376L,232304355L,774343560L,2581169510L,8603882160L,28679699578L,95598937008L,318663476076L,1062211351776L,3540705857998L,11802351958608L,39341178395660L,131137257852000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100068Inst : IEnumerable<long>
{
public static readonly long[] Value=A100068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100068.Bytes);
public long this[int i]=>Value[i];

public static A100068Inst Instance=new A100068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100069
{
public static readonly long[] Value={ 1L,4L,18L,76L,326L,1384L,5892L,25036L,106438L,452344L,1922588L,8170936L,34726940L,147589264L,627256088L,2665837516L,11329815878L,48151714264L,204644809932L,869740430056L,3696396920116L,15709686864304L,66766169526008L,283756220309176L,1205963937666076L,5125346734404784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100069Inst : IEnumerable<long>
{
public static readonly long[] Value=A100069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100069.Bytes);
public long this[int i]=>Value[i];

public static A100069Inst Instance=new A100069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100070
{
public static readonly BigInteger[] Value={ 6L,117L,5632L,515625L,77262336L,17230990189L,5360119185408L,2219048868131217L,1180000000000000000L,BigInteger.Parse("783948341202404638821"),BigInteger.Parse("636404158746280870281216"),BigInteger.Parse("619884903445287035295372217"),BigInteger.Parse("713552333492738487958741450752") };
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
public class A100070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100070.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100070Inst Instance=new A100070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100071
{
public static readonly long[] Value={ 0L,1L,2L,6L,12L,30L,60L,140L,280L,630L,1260L,2772L,5544L,12012L,24024L,51480L,102960L,218790L,437580L,923780L,1847560L,3879876L,7759752L,16224936L,32449872L,67603900L,135207800L,280816200L,561632400L,1163381400L,2326762800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100071Inst : IEnumerable<long>
{
public static readonly long[] Value=A100071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100071.Bytes);
public long this[int i]=>Value[i];

public static A100071Inst Instance=new A100071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100072
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,7L,8L,5L,5L,2L,7L,2L,2L,9L,1L,2L,2L,4L,9L,5L,3L,9L,6L,0L,2L,9L,6L,0L,4L,9L,6L,6L,8L,8L,6L,9L,2L,9L,7L,8L,0L,4L,4L,8L,7L,5L,8L,6L,9L,1L,7L,7L,1L,5L,0L,2L,8L,2L,0L,2L,2L,6L,5L,9L,5L,9L,2L,9L,3L,5L,4L,3L,2L,4L,3L,1L,0L,7L,8L,0L,9L,2L,3L,4L,6L,6L,1L,5L,9L,2L,9L,7L,4L,0L,3L,1L,1L,5L,8L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100072Inst : IEnumerable<long>
{
public static readonly long[] Value=A100072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100072.Bytes);
public long this[int i]=>Value[i];

public static A100072Inst Instance=new A100072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100073
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,2L,1L,1L,0L,1L,1L,2L,0L,1L,2L,1L,0L,2L,1L,1L,0L,1L,2L,2L,0L,2L,1L,1L,0L,2L,2L,1L,0L,1L,1L,3L,0L,1L,3L,1L,0L,2L,1L,1L,0L,2L,2L,2L,0L,1L,2L,1L,0L,3L,2L,2L,0L,1L,1L,2L,0L,1L,3L,1L,0L,3L,1L,2L,0L,1L,3L,2L,0L,1L,2L,2L,0L,2L,2L,1L,0L,2L,1L,2L,0L,2L,4L,1L,0L,3L,1L,1L,0L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100073Inst : IEnumerable<long>
{
public static readonly long[] Value=A100073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100073.Bytes);
public long this[int i]=>Value[i];

public static A100073Inst Instance=new A100073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100074
{
public static readonly long[] Value={ 0L,4L,0L,9L,4L,8L,2L,2L,2L,4L,2L,3L,4L,0L,0L,5L,6L,3L,5L,2L,1L,9L,4L,1L,8L,0L,4L,6L,3L,3L,8L,0L,7L,2L,4L,2L,0L,9L,3L,7L,2L,7L,2L,9L,9L,7L,4L,5L,6L,8L,9L,6L,1L,8L,4L,7L,7L,7L,8L,1L,7L,0L,0L,3L,0L,2L,3L,0L,9L,3L,4L,7L,4L,9L,3L,8L,1L,0L,9L,7L,9L,2L,5L,8L,5L,4L,7L,4L,0L,1L,3L,4L,3L,4L,3L,2L,8L,0L,3L,5L,9L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100074Inst : IEnumerable<long>
{
public static readonly long[] Value=A100074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100074.Bytes);
public long this[int i]=>Value[i];

public static A100074Inst Instance=new A100074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100075
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,1L,3L,9L,15L,1L,4L,16L,48L,96L,1L,5L,25L,105L,345L,555L,1L,6L,36L,192L,864L,2772L,6408L,1L,7L,49L,315L,1785L,8169L,28665L,59157L,1L,8L,64L,480L,3264L,19056L,91296L,323424L,734976L,1L,9L,81L,693L,5481L,38583L,233361L,1144611L,4222449L,9129591L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100075Inst : IEnumerable<long>
{
public static readonly long[] Value=A100075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100075.Bytes);
public long this[int i]=>Value[i];

public static A100075Inst Instance=new A100075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100076
{
public static readonly BigInteger[] Value={ 1L,1L,1L,-3L,9L,-33L,513L,-10917L,155313L,-869697L,-27095391L,1126973331L,-25370851671L,400873570911L,-3945969886815L,-19472448499317L,3355787673885537L,-205870807636111233L,10635145244261722305UL,BigInteger.Parse("-447262563680813504349"),BigInteger.Parse("13896854240554592685081") };
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
public class A100076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100076Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100076.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100076.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100076Inst Instance=new A100076Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100077
{
public static readonly long[] Value={ 9L,4L,22L,3L,5L,10L,1L,6L,8L,2L,108L,195L,25L,43L,4L,80L,147L,20L,7L,72L,56L,24L,419L,22L,242L,49L,89L,161L,167L,255L,16L,3L,23L,66L,44L,128L,46L,169L,182L,67L,299L,19L,101L,45L,207L,14L,347L,5L,106L,64L,40L,146L,51L,15L,53L,10L,34L,112L,29L,11L,47L,155L,70L,86L,93L,33L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100077Inst : IEnumerable<long>
{
public static readonly long[] Value=A100077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100077.Bytes);
public long this[int i]=>Value[i];

public static A100077Inst Instance=new A100077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100078
{
public static readonly long[] Value={ 2L,10L,1L,9L,15L,5L,6L,22L,17L,7L,208L,29L,231L,77L,30L,10L,25L,54L,66L,103L,1L,136L,57L,45L,187L,97L,112L,58L,16L,43L,78L,9L,132L,94L,46L,95L,90L,138L,23L,19L,47L,65L,15L,194L,31L,85L,101L,309L,374L,32L,402L,28L,96L,18L,255L,61L,5L,72L,87L,11L,91L,26L,42L,75L,38L,224L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100078Inst : IEnumerable<long>
{
public static readonly long[] Value=A100078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100078.Bytes);
public long this[int i]=>Value[i];

public static A100078Inst Instance=new A100078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100079
{
public static readonly long[] Value={ 16L,2L,13L,24L,9L,3L,5L,11L,32L,1L,35L,34L,89L,52L,26L,2L,48L,10L,395L,14L,162L,13L,107L,30L,100L,76L,55L,182L,46L,90L,69L,140L,29L,129L,53L,24L,393L,43L,31L,247L,154L,9L,45L,139L,105L,715L,21L,78L,101L,27L,18L,25L,209L,159L,20L,6L,86L,103L,123L,3L,22L,93L,64L,68L,57L,5L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100079Inst : IEnumerable<long>
{
public static readonly long[] Value=A100079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100079.Bytes);
public long this[int i]=>Value[i];

public static A100079Inst Instance=new A100079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100080
{
public static readonly long[] Value={ 5L,2L,26L,1L,29L,19L,9L,13L,3L,6L,297L,64L,50L,385L,45L,18L,116L,65L,2L,41L,393L,102L,85L,125L,35L,93L,26L,86L,32L,43L,4L,1L,92L,58L,59L,69L,126L,12L,165L,151L,36L,717L,437L,196L,226L,29L,60L,160L,46L,55L,30L,112L,25L,19L,108L,90L,105L,134L,123L,70L,88L,9L,446L,149L,236L,511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100080Inst : IEnumerable<long>
{
public static readonly long[] Value=A100080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100080.Bytes);
public long this[int i]=>Value[i];

public static A100080Inst Instance=new A100080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100081
{
public static readonly long[] Value={ 13L,2L,4L,6L,1L,7L,8L,11L,18L,14L,76L,186L,113L,5L,2L,96L,21L,55L,42L,247L,28L,4L,114L,9L,26L,292L,138L,92L,233L,115L,12L,54L,68L,306L,89L,6L,125L,10L,80L,278L,242L,1L,3L,90L,140L,219L,73L,70L,17L,120L,15L,235L,188L,45L,310L,128L,7L,97L,129L,165L,126L,328L,8L,312L,94L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100081Inst : IEnumerable<long>
{
public static readonly long[] Value=A100081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100081.Bytes);
public long this[int i]=>Value[i];

public static A100081Inst Instance=new A100081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100082
{
public static readonly long[] Value={ 7L,6L,1L,15L,8L,2L,17L,14L,10L,3L,6L,61L,62L,74L,42L,48L,16L,392L,193L,57L,346L,5L,31L,461L,90L,1L,148L,28L,32L,67L,145L,15L,328L,621L,267L,34L,92L,81L,232L,75L,126L,99L,147L,91L,268L,139L,43L,18L,12L,8L,35L,41L,66L,255L,101L,65L,88L,37L,207L,2L,25L,112L,89L,266L,17L,72L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100082Inst : IEnumerable<long>
{
public static readonly long[] Value=A100082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100082.Bytes);
public long this[int i]=>Value[i];

public static A100082Inst Instance=new A100082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100083
{
public static readonly long[] Value={ 1L,2L,4L,8L,31L,62L,124L,248L,373L,746L,1492L,2984L,11563L,23126L,46252L,92504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100083Inst : IEnumerable<long>
{
public static readonly long[] Value=A100083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100083.Bytes);
public long this[int i]=>Value[i];

public static A100083Inst Instance=new A100083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100084
{
public static readonly long[] Value={ 1L,2L,5L,1L,3L,7L,1L,7L,4L,2L,1L,1L,2L,4L,8L,6L,4L,0L,5L,9L,3L,7L,2L,7L,2L,7L,6L,4L,8L,3L,5L,6L,3L,4L,4L,3L,1L,0L,6L,7L,1L,5L,4L,0L,7L,7L,1L,8L,1L,9L,2L,7L,2L,9L,7L,6L,6L,8L,0L,3L,8L,4L,0L,8L,7L,7L,9L,1L,4L,9L,5L,1L,9L,8L,9L,0L,2L,6L,0L,6L,3L,1L,0L,0L,2L,7L,0L,0L,9L,7L,0L,1L,0L,8L,2L,6L,7L,7L,6L,9L,0L,9L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100084Inst : IEnumerable<long>
{
public static readonly long[] Value=A100084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100084.Bytes);
public long this[int i]=>Value[i];

public static A100084Inst Instance=new A100084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100085
{
public static readonly long[] Value={ 1L,2L,5L,0L,0L,2L,1L,4L,3L,3L,4L,7L,0L,5L,0L,7L,5L,4L,4L,5L,8L,1L,6L,1L,8L,6L,5L,5L,6L,9L,2L,7L,3L,0L,5L,1L,6L,5L,7L,7L,5L,3L,4L,7L,0L,6L,2L,1L,8L,8L,6L,5L,7L,6L,8L,3L,0L,7L,4L,2L,9L,2L,0L,3L,7L,0L,2L,7L,4L,9L,6L,5L,1L,0L,3L,8L,1L,8L,9L,6L,0L,5L,1L,9L,6L,3L,5L,8L,7L,8L,2L,7L,4L,6L,2L,6L,1L,4L,4L,4L,4L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100085Inst : IEnumerable<long>
{
public static readonly long[] Value=A100085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100085.Bytes);
public long this[int i]=>Value[i];

public static A100085Inst Instance=new A100085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100086
{
public static readonly long[] Value={ 4L,1L,4L,1L,0L,4L,1L,5L,2L,5L,4L,1L,0L,7L,8L,8L,5L,0L,0L,9L,4L,5L,2L,3L,1L,4L,4L,6L,7L,3L,3L,5L,1L,5L,1L,5L,9L,9L,7L,9L,8L,5L,6L,8L,5L,2L,4L,4L,5L,5L,9L,9L,4L,8L,8L,1L,9L,6L,5L,4L,6L,6L,3L,1L,4L,9L,6L,4L,2L,4L,1L,1L,3L,1L,7L,6L,4L,8L,6L,7L,1L,7L,0L,2L,8L,0L,0L,8L,9L,2L,2L,6L,1L,9L,7L,3L,3L,8L,1L,6L,3L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100086Inst : IEnumerable<long>
{
public static readonly long[] Value=A100086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100086.Bytes);
public long this[int i]=>Value[i];

public static A100086Inst Instance=new A100086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100087
{
public static readonly long[] Value={ 1L,2L,4L,10L,24L,60L,148L,370L,920L,2300L,5736L,14340L,35808L,89520L,223668L,559170L,1397496L,3493740L,8732920L,21832300L,54575888L,136439720L,341082504L,852706260L,2131706864L,5329267160L,13322959888L,33307399720L,83267756400L,208169391000L,520420803060L,1301052007650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100087Inst : IEnumerable<long>
{
public static readonly long[] Value=A100087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100087.Bytes);
public long this[int i]=>Value[i];

public static A100087Inst Instance=new A100087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100088
{
public static readonly long[] Value={ 1L,2L,2L,4L,10L,20L,38L,76L,154L,308L,614L,1228L,2458L,4916L,9830L,19660L,39322L,78644L,157286L,314572L,629146L,1258292L,2516582L,5033164L,10066330L,20132660L,40265318L,80530636L,161061274L,322122548L,644245094L,1288490188L,2576980378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100088Inst : IEnumerable<long>
{
public static readonly long[] Value=A100088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100088.Bytes);
public long this[int i]=>Value[i];

public static A100088Inst Instance=new A100088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100089
{
public static readonly BigInteger[] Value={ 24L,5040L,3628800L,6227020800L,20922789888000L,121645100408832000L,BigInteger.Parse("1124000727777607680000"),BigInteger.Parse("15511210043330985984000000"),BigInteger.Parse("304888344611713860501504000000"),BigInteger.Parse("8222838654177922817725562880000000") };
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
public class A100089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100089Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100089.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100089.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100089Inst Instance=new A100089Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100090
{
public static readonly long[] Value={ 4L,4L,6L,8L,14L,15L,22L,22L,30L,36L,32L,50L,42L,49L,56L,61L,64L,69L,72L,75L,80L,83L,86L,112L,110L,108L,108L,108L,110L,143L,136L,162L,154L,148L,172L,163L,190L,178L,206L,193L,220L,208L,234L,219L,204L,238L,218L,239L,262L,238L,266L,241L,272L,299L,270L,296L,322L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100090Inst : IEnumerable<long>
{
public static readonly long[] Value=A100090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100090.Bytes);
public long this[int i]=>Value[i];

public static A100090Inst Instance=new A100090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100091
{
public static readonly long[] Value={ 3L,3L,4L,5L,7L,8L,10L,11L,13L,15L,16L,19L,20L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,43L,45L,47L,49L,51L,53L,56L,58L,61L,63L,65L,68L,70L,73L,75L,78L,80L,83L,85L,88L,90L,92L,95L,97L,100L,103L,105L,108L,110L,113L,116L,118L,121L,124L,126L,129L,131L,134L,137L,139L,142L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100091Inst : IEnumerable<long>
{
public static readonly long[] Value=A100091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100091.Bytes);
public long this[int i]=>Value[i];

public static A100091Inst Instance=new A100091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100092
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,4L,2L,1L,6L,1L,1L,11L,4L,2L,1L,11L,6L,1L,1L,28L,11L,4L,2L,1L,35L,11L,6L,1L,1L,65L,28L,11L,4L,2L,1L,73L,35L,11L,6L,1L,1L,147L,65L,28L,11L,4L,2L,1L,182L,73L,35L,11L,6L,1L,1L,321L,147L,65L,28L,11L,4L,2L,1L,374L,182L,73L,35L,11L,6L,1L,1L,678L,321L,147L,65L,28L,11L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100092Inst : IEnumerable<long>
{
public static readonly long[] Value=A100092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100092.Bytes);
public long this[int i]=>Value[i];

public static A100092Inst Instance=new A100092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100093
{
public static readonly long[] Value={ 1L,1L,6L,11L,35L,73L,182L,374L,816L,1615L,3244L,6160L,11678L,21353L,38742L,68541L,120082L,206448L,351386L,589237L,978626L,1605582L,2610694L,4201319L,6705559L,10607058L,16652362L,25937765L,40122446L,61629301L,94066442L,142668403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100093Inst : IEnumerable<long>
{
public static readonly long[] Value=A100093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100093.Bytes);
public long this[int i]=>Value[i];

public static A100093Inst Instance=new A100093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100094
{
public static readonly long[] Value={ 2L,4L,11L,28L,65L,147L,321L,678L,1382L,2738L,5289L,9985L,18452L,33455L,59616L,104556L,180690L,308058L,518648L,863037L,1420480L,2314170L,3734063L,5970888L,9466452L,14887746L,23235296L,36000876L,55395893L,84680624L,128636339L,194239572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100094Inst : IEnumerable<long>
{
public static readonly long[] Value=A100094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100094.Bytes);
public long this[int i]=>Value[i];

public static A100094Inst Instance=new A100094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100095
{
public static readonly long[] Value={ 0L,1L,1L,5L,7L,25L,41L,125L,225L,625L,1195L,3125L,6227L,15625L,32059L,78125L,163727L,390625L,831505L,1953125L,4206145L,9765625L,21215481L,48828125L,106782837L,244140625L,536618341L,1220703125L,2693492305L,6103515625L,13507578125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100095Inst : IEnumerable<long>
{
public static readonly long[] Value=A100095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100095.Bytes);
public long this[int i]=>Value[i];

public static A100095Inst Instance=new A100095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100096
{
public static readonly long[] Value={ 0L,1L,1L,6L,9L,36L,66L,218L,449L,1332L,2946L,8196L,18954L,50688L,120576L,314586L,761889L,1957092L,4794426L,12194828L,30093854L,76067256L,188595276L,474810276L,1180734234L,2965094536L,7387570516L,18521858088L,46203981924L,115721310552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100096Inst : IEnumerable<long>
{
public static readonly long[] Value=A100096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100096.Bytes);
public long this[int i]=>Value[i];

public static A100096Inst Instance=new A100096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100097
{
public static readonly long[] Value={ 0L,1L,2L,8L,20L,64L,172L,512L,1416L,4096L,11468L,32768L,92248L,262144L,739832L,2097152L,5925520L,16777216L,47429900L,134217728L,379536440L,1073741824L,3036661032L,8589934592L,24294699120L,68719476736L,194363001272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100097Inst : IEnumerable<long>
{
public static readonly long[] Value=A100097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100097.Bytes);
public long this[int i]=>Value[i];

public static A100097Inst Instance=new A100097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100098
{
public static readonly long[] Value={ 1L,1L,4L,7L,22L,46L,130L,295L,790L,1870L,4864L,11782L,30148L,73984L,187534L,463687L,1168870L,2902870L,7293640L,18161170L,45541492L,113576596L,284470564L,710118262L,1777323772L,4439253196L,11105933440L,27749232700L,69403169200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100098Inst : IEnumerable<long>
{
public static readonly long[] Value=A100098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100098.Bytes);
public long this[int i]=>Value[i];

public static A100098Inst Instance=new A100098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100099
{
public static readonly long[] Value={ 0L,1L,2L,7L,16L,46L,110L,295L,720L,1870L,4612L,11782L,29224L,73984L,184102L,463687L,1156000L,2902870L,7245020L,18161170L,45356736L,113576596L,283765132L,710118262L,1774619616L,4439253196L,11095532840L,27749232700L,69363052600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100099Inst : IEnumerable<long>
{
public static readonly long[] Value=A100099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100099.Bytes);
public long this[int i]=>Value[i];

public static A100099Inst Instance=new A100099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100100
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,10L,6L,3L,1L,35L,20L,10L,4L,1L,126L,70L,35L,15L,5L,1L,462L,252L,126L,56L,21L,6L,1L,1716L,924L,462L,210L,84L,28L,7L,1L,6435L,3432L,1716L,792L,330L,120L,36L,8L,1L,24310L,12870L,6435L,3003L,1287L,495L,165L,45L,9L,1L,92378L,48620L,24310L,11440L,5005L,2002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100100Inst : IEnumerable<long>
{
public static readonly long[] Value=A100100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100100.Bytes);
public long this[int i]=>Value[i];

public static A100100Inst Instance=new A100100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100101
{
public static readonly BigInteger[] Value={ 1L,2L,45L,3045L,434700L,109596375L,43800340815L,25797179878470L,21243510135522675L,BigInteger.Parse("23503974546075598575"),BigInteger.Parse("33865310276598741840900"),BigInteger.Parse("61964234361152712204340725"),BigInteger.Parse("141027420945032510510113517025") };
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
public class A100101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100101Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100101.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100101.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100101Inst Instance=new A100101Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100102
{
public static readonly long[] Value={ 2L,3L,13L,59L,249L,1015L,4085L,16371L,65521L,262127L,1048557L,4194283L,16777193L,67108839L,268435429L,1073741795L,4294967265L,17179869151L,68719476701L,274877906907L,1099511627737L,4398046511063L,17592186044373L,70368744177619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100102Inst : IEnumerable<long>
{
public static readonly long[] Value=A100102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100102.Bytes);
public long this[int i]=>Value[i];

public static A100102Inst Instance=new A100102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100103
{
public static readonly long[] Value={ 1L,2L,12L,58L,248L,1014L,4084L,16370L,65520L,262126L,1048556L,4194282L,16777192L,67108838L,268435428L,1073741794L,4294967264L,17179869150L,68719476700L,274877906906L,1099511627736L,4398046511062L,17592186044372L,70368744177618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100103Inst : IEnumerable<long>
{
public static readonly long[] Value=A100103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100103.Bytes);
public long this[int i]=>Value[i];

public static A100103Inst Instance=new A100103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100104
{
public static readonly long[] Value={ 1L,1L,5L,19L,49L,101L,181L,295L,449L,649L,901L,1211L,1585L,2029L,2549L,3151L,3841L,4625L,5509L,6499L,7601L,8821L,10165L,11639L,13249L,15001L,16901L,18955L,21169L,23549L,26101L,28831L,31745L,34849L,38149L,41651L,45361L,49285L,53429L,57799L,62401L,67241L,72325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100104Inst : IEnumerable<long>
{
public static readonly long[] Value=A100104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100104.Bytes);
public long this[int i]=>Value[i];

public static A100104Inst Instance=new A100104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100105
{
public static readonly long[] Value={ 2L,5L,27L,121L,2037L,8179L,131055L,524269L,8388585L,536870883L,2147483617L,137438953435L,2199023255511L,8796093022165L,140737488355281L,9007199254740939L,576460752303423429L,2305843009213693891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100105Inst : IEnumerable<long>
{
public static readonly long[] Value=A100105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100105.Bytes);
public long this[int i]=>Value[i];

public static A100105Inst Instance=new A100105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100106
{
public static readonly long[] Value={ 5L,9L,7L,5L,4L,2L,6L,1L,7L,5L,2L,6L,9L,3L,3L,8L,7L,4L,7L,6L,8L,6L,3L,2L,6L,0L,1L,9L,6L,8L,8L,2L,8L,9L,7L,7L,5L,8L,7L,4L,3L,3L,1L,9L,9L,3L,1L,8L,9L,8L,0L,4L,9L,3L,1L,7L,5L,7L,7L,0L,9L,2L,6L,2L,4L,1L,2L,7L,5L,9L,1L,8L,8L,5L,1L,0L,8L,3L,6L,4L,1L,2L,7L,8L,7L,4L,4L,9L,8L,8L,4L,9L,2L,9L,6L,6L,5L,8L,9L,6L,5L,2L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100106Inst : IEnumerable<long>
{
public static readonly long[] Value=A100106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100106.Bytes);
public long this[int i]=>Value[i];

public static A100106Inst Instance=new A100106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100107
{
public static readonly long[] Value={ 1L,4L,5L,11L,12L,26L,30L,58L,81L,138L,200L,355L,522L,876L,1380L,2265L,3572L,5880L,9350L,15272L,24510L,39806L,64080L,104084L,167773L,271968L,439285L,711530L,1149852L,1862022L,3010350L,4873112L,7881400L,12755618L,20633280L,33391491L,54018522L,87413156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100107Inst : IEnumerable<long>
{
public static readonly long[] Value=A100107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100107.Bytes);
public long this[int i]=>Value[i];

public static A100107Inst Instance=new A100107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100108
{
public static readonly long[] Value={ 11L,312211L,13112221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100108Inst : IEnumerable<long>
{
public static readonly long[] Value=A100108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100108.Bytes);
public long this[int i]=>Value[i];

public static A100108Inst Instance=new A100108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100109
{
public static readonly long[] Value={ 1L,2L,11L,34L,77L,146L,247L,386L,569L,802L,1091L,1442L,1861L,2354L,2927L,3586L,4337L,5186L,6139L,7202L,8381L,9682L,11111L,12674L,14377L,16226L,18227L,20386L,22709L,25202L,27871L,30722L,33761L,36994L,40427L,44066L,47917L,51986L,56279L,60802L,65561L,70562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100109Inst : IEnumerable<long>
{
public static readonly long[] Value=A100109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100109.Bytes);
public long this[int i]=>Value[i];

public static A100109Inst Instance=new A100109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100110
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,32L,33L,35L,37L,41L,43L,47L,49L,53L,59L,52L,53L,55L,57L,61L,63L,67L,69L,73L,79L,72L,73L,75L,77L,81L,83L,87L,89L,93L,99L,112L,113L,115L,117L,121L,123L,127L,129L,133L,139L,132L,133L,135L,137L,141L,143L,147L,149L,153L,159L,172L,173L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100110Inst : IEnumerable<long>
{
public static readonly long[] Value=A100110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100110.Bytes);
public long this[int i]=>Value[i];

public static A100110Inst Instance=new A100110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100111
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,16L,22L,26L,36L,45L,53L,63L,77L,88L,100L,116L,136L,149L,167L,187L,209L,228L,250L,276L,306L,329L,353L,383L,415L,442L,480L,514L,552L,581L,629L,665L,709L,744L,796L,838L,888L,925L,987L,1031L,1085L,1124L,1198L,1254L,1312L,1353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100111Inst : IEnumerable<long>
{
public static readonly long[] Value=A100111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100111.Bytes);
public long this[int i]=>Value[i];

public static A100111Inst Instance=new A100111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100112
{
public static readonly long[] Value={ 1L,2L,3L,0L,4L,5L,6L,0L,0L,7L,8L,0L,9L,10L,11L,0L,12L,0L,13L,0L,14L,15L,16L,0L,0L,17L,0L,0L,18L,19L,20L,0L,21L,22L,23L,0L,24L,25L,26L,0L,27L,28L,29L,0L,0L,30L,31L,0L,0L,0L,32L,0L,33L,0L,34L,0L,35L,36L,37L,0L,38L,39L,0L,0L,40L,41L,42L,0L,43L,44L,45L,0L,46L,47L,0L,0L,48L,49L,50L,0L,0L,51L,52L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100112Inst : IEnumerable<long>
{
public static readonly long[] Value=A100112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100112.Bytes);
public long this[int i]=>Value[i];

public static A100112Inst Instance=new A100112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100113
{
public static readonly long[] Value={ 1L,2L,6L,3L,15L,5L,10L,14L,7L,21L,30L,22L,11L,33L,39L,13L,26L,34L,17L,51L,42L,35L,55L,65L,70L,38L,19L,57L,66L,46L,23L,69L,78L,58L,29L,87L,93L,31L,62L,74L,37L,111L,102L,82L,41L,123L,105L,77L,91L,119L,85L,95L,110L,86L,43L,129L,114L,94L,47L,141L,138L,106L,53L,159L,165L,115L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100113Inst : IEnumerable<long>
{
public static readonly long[] Value=A100113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100113.Bytes);
public long this[int i]=>Value[i];

public static A100113Inst Instance=new A100113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100114
{
public static readonly long[] Value={ 1L,2L,5L,7L,3L,13L,10L,19L,23L,11L,6L,30L,41L,14L,17L,47L,26L,57L,15L,61L,21L,29L,34L,66L,39L,22L,71L,33L,87L,46L,94L,31L,102L,35L,42L,55L,110L,115L,62L,37L,43L,123L,51L,38L,139L,151L,65L,77L,53L,158L,70L,170L,82L,86L,58L,178L,78L,59L,93L,83L,190L,195L,69L,206L,74L,101L,213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100114Inst : IEnumerable<long>
{
public static readonly long[] Value=A100114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100114.Bytes);
public long this[int i]=>Value[i];

public static A100114Inst Instance=new A100114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100115
{
public static readonly long[] Value={ 1L,2L,6L,4L,3L,15L,5L,8L,9L,10L,14L,12L,7L,21L,30L,16L,22L,18L,11L,20L,33L,39L,13L,24L,25L,26L,27L,28L,34L,17L,51L,32L,42L,35L,55L,36L,65L,70L,38L,40L,19L,57L,66L,44L,45L,46L,23L,48L,49L,50L,69L,52L,78L,54L,58L,56L,29L,87L,93L,60L,31L,62L,63L,64L,74L,37L,111L,68L,102L,82L,41L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100115Inst : IEnumerable<long>
{
public static readonly long[] Value=A100115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100115.Bytes);
public long this[int i]=>Value[i];

public static A100115Inst Instance=new A100115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100116
{
public static readonly long[] Value={ 1L,2L,5L,4L,7L,3L,13L,8L,9L,10L,19L,12L,23L,11L,6L,16L,30L,18L,41L,20L,14L,17L,47L,24L,25L,26L,27L,28L,57L,15L,61L,32L,21L,29L,34L,36L,66L,39L,22L,40L,71L,33L,87L,44L,45L,46L,94L,48L,49L,50L,31L,52L,102L,54L,35L,56L,42L,55L,110L,60L,115L,62L,63L,64L,37L,43L,123L,68L,51L,38L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100116Inst : IEnumerable<long>
{
public static readonly long[] Value=A100116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100116.Bytes);
public long this[int i]=>Value[i];

public static A100116Inst Instance=new A100116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100117
{
public static readonly BigInteger[] Value={ 2L,4L,32L,32768L,4503599627370496L,BigInteger.Parse("12855504354071922204335696738729300820177623950262342682411008") };
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
public class A100117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100117Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100117.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100117.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100117Inst Instance=new A100117Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100118
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,10L,11L,12L,13L,17L,19L,22L,23L,28L,29L,31L,34L,37L,40L,41L,43L,45L,47L,48L,52L,53L,54L,56L,58L,59L,61L,63L,67L,71L,73L,75L,76L,79L,80L,82L,83L,88L,89L,90L,96L,97L,99L,101L,103L,104L,107L,108L,109L,113L,117L,118L,127L,131L,136L,137L,139L,142L,147L,148L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100118Inst : IEnumerable<long>
{
public static readonly long[] Value=A100118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100118.Bytes);
public long this[int i]=>Value[i];

public static A100118Inst Instance=new A100118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100119
{
public static readonly long[] Value={ 1L,2L,7L,19L,41L,76L,127L,197L,289L,406L,551L,727L,937L,1184L,1471L,1801L,2177L,2602L,3079L,3611L,4201L,4852L,5567L,6349L,7201L,8126L,9127L,10207L,11369L,12616L,13951L,15377L,16897L,18514L,20231L,22051L,23977L,26012L,28159L,30421L,32801L,35302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100119Inst : IEnumerable<long>
{
public static readonly long[] Value=A100119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100119.Bytes);
public long this[int i]=>Value[i];

public static A100119Inst Instance=new A100119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100120
{
public static readonly long[] Value={ 1L,6L,0L,4L,6L,5L,1L,2L,1L,8L,4L,1L,0L,0L,5L,5L,8L,2L,7L,9L,8L,3L,8L,6L,6L,5L,1L,1L,0L,1L,5L,1L,7L,3L,3L,9L,8L,8L,0L,8L,6L,4L,9L,7L,5L,4L,6L,9L,9L,5L,8L,0L,3L,4L,0L,4L,8L,4L,5L,7L,2L,7L,2L,8L,3L,2L,7L,1L,1L,4L,9L,2L,5L,5L,9L,9L,5L,4L,0L,0L,5L,3L,7L,9L,9L,1L,7L,5L,6L,0L,1L,9L,9L,0L,6L,5L,5L,9L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100120Inst : IEnumerable<long>
{
public static readonly long[] Value=A100120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100120.Bytes);
public long this[int i]=>Value[i];

public static A100120Inst Instance=new A100120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100121
{
public static readonly long[] Value={ 1L,8L,6L,0L,2L,0L,9L,4L,1L,1L,4L,5L,5L,6L,0L,6L,5L,6L,2L,2L,9L,1L,7L,3L,1L,9L,7L,6L,2L,0L,8L,2L,1L,8L,6L,2L,4L,7L,3L,8L,9L,8L,9L,8L,9L,8L,7L,6L,0L,3L,5L,8L,6L,5L,5L,7L,7L,1L,9L,8L,3L,0L,0L,8L,7L,6L,6L,6L,1L,7L,4L,6L,5L,1L,1L,1L,7L,8L,6L,1L,5L,8L,2L,8L,1L,1L,8L,6L,9L,8L,7L,2L,7L,9L,7L,5L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100121Inst : IEnumerable<long>
{
public static readonly long[] Value=A100121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100121.Bytes);
public long this[int i]=>Value[i];

public static A100121Inst Instance=new A100121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100122
{
public static readonly long[] Value={ 1L,5L,1L,7L,7L,7L,2L,3L,6L,6L,2L,1L,5L,2L,7L,5L,3L,9L,9L,7L,4L,3L,3L,6L,7L,3L,3L,5L,1L,8L,6L,9L,6L,2L,3L,2L,6L,5L,6L,0L,7L,8L,9L,9L,8L,3L,9L,4L,6L,3L,4L,9L,7L,4L,6L,9L,3L,6L,5L,5L,4L,0L,4L,3L,8L,0L,0L,5L,4L,4L,0L,9L,0L,3L,8L,9L,0L,7L,6L,8L,4L,5L,4L,4L,8L,9L,4L,7L,0L,4L,4L,0L,4L,7L,4L,6L,5L,8L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100122Inst : IEnumerable<long>
{
public static readonly long[] Value=A100122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100122.Bytes);
public long this[int i]=>Value[i];

public static A100122Inst Instance=new A100122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100123
{
public static readonly long[] Value={ 1L,6L,2L,9L,4L,9L,0L,2L,9L,9L,5L,2L,2L,8L,0L,7L,7L,6L,9L,3L,4L,7L,9L,5L,0L,1L,0L,1L,9L,5L,7L,9L,5L,8L,6L,4L,8L,1L,6L,0L,0L,1L,4L,5L,7L,0L,6L,7L,6L,7L,1L,3L,7L,9L,3L,4L,6L,0L,9L,9L,6L,2L,0L,7L,4L,2L,0L,6L,6L,8L,3L,2L,8L,3L,6L,7L,7L,3L,3L,0L,9L,3L,0L,5L,1L,3L,4L,6L,2L,5L,3L,4L,1L,9L,3L,7L,6L,6L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100123Inst : IEnumerable<long>
{
public static readonly long[] Value=A100123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100123.Bytes);
public long this[int i]=>Value[i];

public static A100123Inst Instance=new A100123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100124
{
public static readonly long[] Value={ 6L,7L,5L,1L,9L,8L,4L,3L,7L,9L,1L,1L,1L,1L,4L,3L,4L,1L,9L,0L,0L,5L,6L,1L,6L,0L,7L,5L,9L,1L,3L,5L,7L,2L,9L,9L,5L,3L,9L,2L,7L,6L,7L,8L,8L,5L,6L,5L,1L,3L,2L,6L,5L,1L,5L,6L,0L,3L,4L,1L,0L,6L,4L,5L,1L,6L,8L,8L,5L,8L,6L,1L,4L,8L,5L,4L,2L,4L,4L,3L,3L,4L,4L,1L,1L,4L,6L,2L,7L,2L,2L,8L,0L,2L,7L,8L,9L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100124Inst : IEnumerable<long>
{
public static readonly long[] Value=A100124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100124.Bytes);
public long this[int i]=>Value[i];

public static A100124Inst Instance=new A100124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100125
{
public static readonly long[] Value={ 6L,3L,0L,9L,2L,0L,5L,5L,9L,2L,5L,5L,1L,8L,5L,8L,6L,4L,7L,7L,8L,3L,2L,4L,0L,0L,3L,9L,0L,7L,9L,4L,3L,3L,7L,0L,0L,9L,2L,1L,5L,1L,4L,2L,9L,9L,2L,1L,7L,8L,7L,9L,8L,6L,8L,0L,6L,4L,4L,4L,2L,4L,8L,9L,9L,9L,8L,9L,8L,0L,8L,1L,0L,7L,8L,3L,8L,1L,7L,7L,3L,4L,7L,3L,8L,8L,2L,0L,0L,1L,9L,2L,0L,6L,4L,4L,4L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100125Inst : IEnumerable<long>
{
public static readonly long[] Value=A100125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100125.Bytes);
public long this[int i]=>Value[i];

public static A100125Inst Instance=new A100125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100126
{
public static readonly long[] Value={ 8L,5L,9L,1L,2L,7L,1L,1L,0L,3L,5L,1L,0L,8L,8L,4L,3L,0L,3L,6L,8L,2L,2L,8L,2L,6L,2L,3L,0L,7L,5L,3L,7L,9L,0L,8L,2L,5L,8L,5L,3L,4L,5L,7L,7L,0L,6L,1L,7L,7L,6L,1L,7L,5L,6L,6L,1L,6L,7L,6L,1L,7L,7L,5L,8L,6L,8L,3L,7L,3L,2L,7L,9L,8L,0L,3L,7L,3L,5L,8L,8L,9L,7L,5L,1L,3L,2L,2L,0L,2L,2L,4L,8L,2L,6L,2L,5L,6L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100126Inst : IEnumerable<long>
{
public static readonly long[] Value=A100126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100126.Bytes);
public long this[int i]=>Value[i];

public static A100126Inst Instance=new A100126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100127
{
public static readonly long[] Value={ 4L,7L,3L,8L,6L,3L,8L,7L,0L,2L,6L,8L,6L,2L,1L,9L,9L,9L,2L,7L,1L,7L,7L,9L,4L,7L,0L,3L,4L,8L,1L,2L,4L,9L,5L,5L,3L,6L,0L,1L,8L,2L,3L,8L,4L,6L,6L,4L,2L,1L,0L,6L,6L,4L,2L,4L,8L,0L,9L,6L,1L,9L,3L,4L,8L,4L,3L,7L,5L,4L,0L,8L,7L,7L,9L,6L,9L,7L,1L,6L,7L,4L,8L,9L,2L,2L,7L,2L,2L,1L,3L,7L,6L,0L,2L,3L,3L,7L,7L,4L,5L,6L,7L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100127Inst : IEnumerable<long>
{
public static readonly long[] Value=A100127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100127.Bytes);
public long this[int i]=>Value[i];

public static A100127Inst Instance=new A100127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100128
{
public static readonly long[] Value={ 5L,5L,8L,3L,2L,7L,6L,2L,2L,2L,3L,1L,7L,6L,9L,1L,5L,8L,6L,1L,4L,2L,7L,9L,1L,9L,6L,8L,0L,3L,6L,0L,4L,6L,9L,5L,1L,7L,5L,2L,5L,2L,1L,2L,8L,2L,0L,8L,7L,4L,2L,0L,1L,7L,3L,9L,0L,2L,2L,2L,9L,1L,7L,4L,2L,3L,5L,8L,5L,4L,7L,6L,3L,3L,1L,6L,3L,7L,6L,1L,7L,6L,5L,2L,0L,0L,9L,3L,6L,9L,6L,7L,2L,6L,5L,2L,1L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100128Inst : IEnumerable<long>
{
public static readonly long[] Value=A100128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100128.Bytes);
public long this[int i]=>Value[i];

public static A100128Inst Instance=new A100128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100129
{
public static readonly long[] Value={ 6L,10L,1542L,77075L,113939L,1122772L,2455891300L,2830138178L,136387767490L,2111259099790L,3456955336468L,4653248164310L,10393297007134L,321249146279171L,972926121017616L,72780032758751764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100129Inst : IEnumerable<long>
{
public static readonly long[] Value=A100129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100129.Bytes);
public long this[int i]=>Value[i];

public static A100129Inst Instance=new A100129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100130
{
public static readonly long[] Value={ 1L,-24L,300L,-2624L,18126L,-105504L,538296L,-2471424L,10400997L,-40674128L,149343012L,-519045888L,1718732998L,-5451292992L,16633756008L,-49010118656L,139877936370L,-387749049720L,1046413709980L,-2754808758144L,7087483527072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100130Inst : IEnumerable<long>
{
public static readonly long[] Value=A100130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100130.Bytes);
public long this[int i]=>Value[i];

public static A100130Inst Instance=new A100130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100131
{
public static readonly long[] Value={ 1L,2L,4L,8L,17L,38L,88L,208L,497L,1194L,2876L,6936L,16737L,40398L,97520L,235424L,568353L,1372114L,3312564L,7997224L,19306993L,46611190L,112529352L,271669872L,655869073L,1583407994L,3822685036L,9228778040L,22280241089L,53789260190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100131Inst : IEnumerable<long>
{
public static readonly long[] Value=A100131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100131.Bytes);
public long this[int i]=>Value[i];

public static A100131Inst Instance=new A100131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100132
{
public static readonly long[] Value={ 1L,2L,4L,8L,18L,44L,112L,288L,740L,1896L,4848L,12384L,31624L,80752L,206208L,526592L,1344784L,3434272L,8770368L,22397568L,57198368L,146071744L,373034240L,952645120L,2432840256L,6212924032L,15866403584L,40519208448L,103476899968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100132Inst : IEnumerable<long>
{
public static readonly long[] Value=A100132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100132.Bytes);
public long this[int i]=>Value[i];

public static A100132Inst Instance=new A100132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100133
{
public static readonly long[] Value={ 1L,2L,4L,8L,19L,50L,136L,368L,985L,2618L,6940L,18392L,48763L,129338L,343120L,910304L,2415025L,6406898L,16996852L,45090728L,119620579L,317340098L,841868632L,2233386320L,5924932489L,15718204970L,41698695820L,110622122360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100133Inst : IEnumerable<long>
{
public static readonly long[] Value=A100133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100133.Bytes);
public long this[int i]=>Value[i];

public static A100133Inst Instance=new A100133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100134
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,5L,11L,21L,36L,57L,86L,128L,194L,305L,497L,827L,1381L,2287L,3739L,6042L,9693L,15519L,24901L,40126L,64933L,105364L,171112L,277696L,450017L,728201L,1177181L,1902321L,3074733L,4972113L,8044478L,13020029L,21075947L,34114553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100134Inst : IEnumerable<long>
{
public static readonly long[] Value=A100134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100134.Bytes);
public long this[int i]=>Value[i];

public static A100134Inst Instance=new A100134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100135
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,9L,21L,41L,71L,113L,173L,269L,443L,777L,1413L,2577L,4615L,8065L,13813L,23413L,39691L,67801L,116973L,203337L,354519L,617345L,1071197L,1851677L,3192731L,5501033L,9485621L,16381185L,28330119L,49035777L,84883621L,146875717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100135Inst : IEnumerable<long>
{
public static readonly long[] Value=A100135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100135.Bytes);
public long this[int i]=>Value[i];

public static A100135Inst Instance=new A100135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100136
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,4L,13L,31L,61L,106L,169L,262L,424L,748L,1417L,2749L,5251L,9709L,17395L,30553L,53434L,94285L,168859L,306283L,558742L,1017895L,1844044L,3320044L,5952472L,10660177L,19119385L,34383781L,61985497L,111884665L,201938701L,364128136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100136Inst : IEnumerable<long>
{
public static readonly long[] Value=A100136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100136.Bytes);
public long this[int i]=>Value[i];

public static A100136Inst Instance=new A100136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100137
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,65L,136L,296L,672L,1584L,3840L,9473L,23566L,58736L,146080L,361760L,891328L,2184961L,5331476L,12958684L,31400160L,75910320L,183220800L,441787201L,1064687642L,2565404524L,6181873208L,14899796416L,35922756992L,86635757825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100137Inst : IEnumerable<long>
{
public static readonly long[] Value=A100137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100137.Bytes);
public long this[int i]=>Value[i];

public static A100137Inst Instance=new A100137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100138
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,66L,144L,336L,832L,2144L,5632L,14852L,38968L,101312L,260736L,664704L,1681152L,4226056L,10578080L,26407648L,65838848L,164095360L,409129472L,1020795408L,2549137824L,6371133120L,15935185792L,39878810624L,99837958144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100138Inst : IEnumerable<long>
{
public static readonly long[] Value=A100138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100138.Bytes);
public long this[int i]=>Value[i];

public static A100138Inst Instance=new A100138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100139
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,67L,152L,376L,992L,2704L,7424L,20233L,54398L,144112L,376736L,974368L,2500544L,6385435L,16264220L,41396788L,105423776L,268818064L,686499008L,1755723793L,4495691834L,11521647916L,29543647160L,75774096832L,194353495424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100139Inst : IEnumerable<long>
{
public static readonly long[] Value=A100139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100139.Bytes);
public long this[int i]=>Value[i];

public static A100139Inst Instance=new A100139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100140
{
public static readonly long[] Value={ 2L,6L,4L,20L,3L,231L,24L,45L,20L,4070L,12L,2145L,231L,120L,240L,3039345L,45L,2359420L,180L,1428L,4070L,1019084L,120L,53307975L,2145L,1350L,1428L,1003066152L,120L,1127619917796295L,16800L,26796L,3039345L,1104740L,72L,884004L,2359420L,1288092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100140Inst : IEnumerable<long>
{
public static readonly long[] Value=A100140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100140.Bytes);
public long this[int i]=>Value[i];

public static A100140Inst Instance=new A100140Inst();

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