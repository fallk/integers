using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

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

public static class A104579
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,2L,2L,0L,1L,1L,4L,3L,0L,1L,4L,3L,6L,4L,0L,1L,5L,12L,6L,8L,5L,0L,1L,6L,16L,24L,10L,10L,6L,0L,1L,13L,24L,34L,40L,15L,12L,7L,0L,1L,16L,53L,60L,60L,60L,21L,14L,8L,0L,1L,25L,72L,135L,120L,95L,84L,28L,16L,9L,0L,1L,42L,126L,200L,275L,210L,140L,112L,36L,18L,10L,0L,1L,57L,220L,381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104579Inst : IEnumerable<long>
{
public static readonly long[] Value=A104579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104579.Bytes);
public long this[int i]=>Value[i];

public static A104579Inst Instance=new A104579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104580
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,4L,5L,3L,1L,7L,12L,9L,4L,1L,13L,26L,25L,14L,5L,1L,24L,56L,63L,44L,20L,6L,1L,44L,118L,153L,125L,70L,27L,7L,1L,81L,244L,359L,336L,220L,104L,35L,8L,1L,149L,499L,819L,864L,646L,357L,147L,44L,9L,1L,274L,1010L,1830L,2144L,1800L,1134L,546L,200L,54L,10L,1L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104580Inst : IEnumerable<long>
{
public static readonly long[] Value=A104580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104580.Bytes);
public long this[int i]=>Value[i];

public static A104580Inst Instance=new A104580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104581
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,2L,-2L,3L,-3L,3L,-4L,4L,-4L,5L,-5L,5L,-6L,6L,-6L,7L,-7L,7L,-8L,8L,-8L,9L,-9L,9L,-10L,10L,-10L,11L,-11L,11L,-12L,12L,-12L,13L,-13L,13L,-14L,14L,-14L,15L,-15L,15L,-16L,16L,-16L,17L,-17L,17L,-18L,18L,-18L,19L,-19L,19L,-20L,20L,-20L,21L,-21L,21L,-22L,22L,-22L,23L,-23L,23L,-24L,24L,-24L,25L,-25L,25L,-26L,26L,-26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104581Inst : IEnumerable<long>
{
public static readonly long[] Value=A104581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104581.Bytes);
public long this[int i]=>Value[i];

public static A104581Inst Instance=new A104581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104582
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,1L,7L,4L,2L,1L,12L,7L,4L,2L,1L,20L,12L,7L,4L,2L,1L,33L,20L,12L,7L,4L,2L,1L,54L,33L,20L,12L,7L,4L,2L,1L,88L,54L,33L,20L,12L,7L,4L,2L,1L,143L,88L,54L,33L,20L,12L,7L,4L,2L,1L,232L,143L,88L,54L,33L,20L,12L,7L,4L,2L,1L,376L,232L,143L,88L,54L,33L,20L,12L,7L,4L,2L,1L,609L,376L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104582Inst : IEnumerable<long>
{
public static readonly long[] Value=A104582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104582.Bytes);
public long this[int i]=>Value[i];

public static A104582Inst Instance=new A104582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104583
{
public static readonly long[] Value={ 1L,4L,2L,9L,8L,1L,16L,18L,4L,2L,25L,32L,9L,8L,1L,36L,50L,16L,18L,4L,2L,49L,72L,25L,32L,9L,8L,1L,64L,98L,36L,50L,16L,18L,4L,2L,81L,128L,49L,72L,25L,32L,9L,8L,1L,100L,162L,64L,98L,36L,50L,16L,18L,4L,2L,121L,200L,81L,128L,49L,72L,25L,32L,9L,8L,1L,144L,242L,100L,162L,64L,98L,36L,50L,16L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104583Inst : IEnumerable<long>
{
public static readonly long[] Value=A104583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104583.Bytes);
public long this[int i]=>Value[i];

public static A104583Inst Instance=new A104583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104584
{
public static readonly long[] Value={ 0L,1L,7L,12L,26L,35L,57L,70L,100L,117L,155L,176L,222L,247L,301L,330L,392L,425L,495L,532L,610L,651L,737L,782L,876L,925L,1027L,1080L,1190L,1247L,1365L,1426L,1552L,1617L,1751L,1820L,1962L,2035L,2185L,2262L,2420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104584Inst : IEnumerable<long>
{
public static readonly long[] Value=A104584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104584.Bytes);
public long this[int i]=>Value[i];

public static A104584Inst Instance=new A104584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104585
{
public static readonly long[] Value={ 0L,2L,5L,15L,22L,40L,51L,77L,92L,126L,145L,187L,210L,260L,287L,345L,376L,442L,477L,551L,590L,672L,715L,805L,852L,950L,1001L,1107L,1162L,1276L,1335L,1457L,1520L,1650L,1717L,1855L,1926L,2072L,2147L,2301L,2380L,2542L,2625L,2795L,2882L,3060L,3151L,3337L,3432L,3626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104585Inst : IEnumerable<long>
{
public static readonly long[] Value=A104585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104585.Bytes);
public long this[int i]=>Value[i];

public static A104585Inst Instance=new A104585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104586
{
public static readonly long[] Value={ 1L,7L,2L,12L,5L,1L,26L,15L,7L,2L,35L,22L,12L,5L,1L,57L,40L,26L,15L,7L,2L,70L,51L,35L,22L,12L,5L,1L,100L,77L,57L,40L,26L,15L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104586Inst : IEnumerable<long>
{
public static readonly long[] Value=A104586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104586.Bytes);
public long this[int i]=>Value[i];

public static A104586Inst Instance=new A104586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104587
{
public static readonly long[] Value={ 1L,5L,3L,12L,9L,5L,22L,18L,13L,7L,35L,30L,24L,17L,9L,51L,45L,38L,30L,21L,11L,70L,63L,55L,46L,36L,25L,13L,92L,84L,75L,65L,54L,42L,29L,15L,117L,108L,98L,87L,75L,62L,48L,33L,17L,145L,135L,124L,112L,99L,85L,70L,54L,37L,19L,176L,165L,153L,140L,126L,111L,95L,78L,60L,41L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104587Inst : IEnumerable<long>
{
public static readonly long[] Value=A104587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104587.Bytes);
public long this[int i]=>Value[i];

public static A104587Inst Instance=new A104587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104588
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,2L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104588Inst : IEnumerable<long>
{
public static readonly long[] Value=A104588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104588.Bytes);
public long this[int i]=>Value[i];

public static A104588Inst Instance=new A104588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104589
{
public static readonly long[] Value={ 1L,2L,5L,13L,34L,55L,76L,97L,215L,333L,451L,569L,1256L,1943L,2630L,3317L,4004L,4691L,10069L,25516L,40963L,56410L,71857L,87304L,102751L,118198L,133645L,149092L,164539L,179986L,195433L,210880L,226327L,241774L,257221L,529889L,802557L,1075225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104589Inst : IEnumerable<long>
{
public static readonly long[] Value=A104589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104589.Bytes);
public long this[int i]=>Value[i];

public static A104589Inst Instance=new A104589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104590
{
public static readonly BigInteger[] Value={ 560L,191520L,42058800L,7864256400L,1407126890400L,257752421166240L,50607986220311520L,10995419195575214400UL,BigInteger.Parse("2692773804667509763200"),BigInteger.Parse("747221542837742897724800"),BigInteger.Parse("233698171655650029030743040"),BigInteger.Parse("81472765051132560093387934080"),BigInteger.Parse("31268587126068905034073041062400") };
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
public class A104590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104590Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104590.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104590.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104590Inst Instance=new A104590Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104591
{
public static readonly BigInteger[] Value={ 560L,5040L,957600L,123354000L,16842764400L,2764379217600L,527554510282800L,114387072405606000L,BigInteger.Parse("27728561968887780000"),BigInteger.Parse("7418031804967840056000"),BigInteger.Parse("2167306256125914230527200"),BigInteger.Parse("685709965521372865035362400"),BigInteger.Parse("233306923207078035272369412000") };
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
public class A104591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104591Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104591.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104591.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104591Inst Instance=new A104591Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104592
{
public static readonly BigInteger[] Value={ 1L,120L,10920L,988960L,99706320L,11897978400L,1729153068720L,306003079514880L,64657337524631280L,15890834362452489440UL,BigInteger.Parse("4435396700216405763840"),BigInteger.Parse("1379778057502074926142720"),BigInteger.Parse("471689356958791639787042560") };
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
public class A104592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104592.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104592Inst Instance=new A104592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104593
{
public static readonly BigInteger[] Value={ 1L,25L,1317L,96012L,8976600L,1027205280L,139315157730L,21864486188160L,3898841480307900L,778680435365714700L,BigInteger.Parse("172192746831203449890"),BigInteger.Parse("41765231538761743574100"),BigInteger.Parse("11024455369912310561835600") };
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
public class A104593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104593Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104593.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104593.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104593Inst Instance=new A104593Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104594
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,2L,3L,0L,4L,4L,5L,4L,6L,6L,7L,0L,8L,8L,9L,8L,10L,10L,11L,8L,12L,12L,13L,12L,14L,14L,15L,0L,16L,16L,17L,16L,18L,18L,19L,16L,20L,20L,21L,20L,22L,22L,23L,16L,24L,24L,25L,24L,26L,26L,27L,24L,28L,28L,29L,28L,30L,30L,31L,0L,32L,32L,33L,32L,34L,34L,35L,32L,36L,36L,37L,36L,38L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104594Inst : IEnumerable<long>
{
public static readonly long[] Value=A104594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104594.Bytes);
public long this[int i]=>Value[i];

public static A104594Inst Instance=new A104594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104595
{
public static readonly long[] Value={ 4L,106L,2382L,46680L,830848L,13804864L,218353000L,3328822880L,49325772812L,714586880940L,10164338225482L,142403410942816L,1969831979334086L,26954132420126920L,365393525753591368L,4913176199287631232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104595Inst : IEnumerable<long>
{
public static readonly long[] Value=A104595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104595.Bytes);
public long this[int i]=>Value[i];

public static A104595Inst Instance=new A104595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104596
{
public static readonly BigInteger[] Value={ 131L,8158L,313611L,9326858L,236095958L,5345316004L,111472798586L,2182345314816L,40634231364914L,726322104184848L,12550075287918360L,210738250570954064L,3453173212810875280L,BigInteger.Parse("55399287587418128520") };
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
public class A104596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104596Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104596.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104596.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104596Inst Instance=new A104596Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104597
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,1L,-1L,-2L,0L,1L,0L,-2L,-3L,0L,1L,1L,1L,-3L,-4L,0L,1L,1L,4L,3L,-4L,-5L,0L,1L,0L,3L,9L,6L,-5L,-6L,0L,1L,-1L,-2L,5L,16L,10L,-6L,-7L,0L,1L,-1L,-6L,-9L,6L,25L,15L,-7L,-8L,0L,1L,0L,-4L,-18L,-24L,5L,36L,21L,-8L,-9L,0L,1L,1L,3L,-7L,-39L,-50L,1L,49L,28L,-9L,-10L,0L,1L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104597Inst : IEnumerable<long>
{
public static readonly long[] Value=A104597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104597.Bytes);
public long this[int i]=>Value[i];

public static A104597Inst Instance=new A104597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104598
{
public static readonly long[] Value={ 1L,10L,68L,394L,2092L,10516L,50920L,239962L,1107836L,5033020L,22572376L,100168260L,440604088L,1923626344L,8344694224L,35998921978L,154546983580L,660652406572L,2813422792696L,11940478362796L,50522190460072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104598Inst : IEnumerable<long>
{
public static readonly long[] Value=A104598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104598.Bytes);
public long this[int i]=>Value[i];

public static A104598Inst Instance=new A104598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104599
{
public static readonly long[] Value={ 1L,7L,14L,27L,64L,77L,182L,189L,273L,286L,378L,448L,714L,729L,748L,896L,924L,1254L,1547L,1728L,1729L,2079L,2261L,2926L,3003L,3289L,3542L,4096L,4914L,4928L,5005L,5103L,6630L,7293L,7371L,7722L,8372L,9177L,9660L,10206L,10556L,11571L,11648L,12096L,13090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104599Inst : IEnumerable<long>
{
public static readonly long[] Value=A104599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104599.Bytes);
public long this[int i]=>Value[i];

public static A104599Inst Instance=new A104599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104600
{
public static readonly BigInteger[] Value={ 1L,1L,5L,49L,795L,18881L,611193L,25704253L,1356235163L,87419692453L,6741175388313L,611464105166993L,64336296019640307L,7760748741918246361L,BigInteger.Parse("1062626712168331953737"),BigInteger.Parse("163738827988386433177093") };
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
public class A104600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104600Inst Instance=new A104600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104601
{
public static readonly long[] Value={ 1L,0L,2L,0L,4L,6L,0L,1L,45L,24L,0L,0L,90L,432L,120L,0L,0L,78L,2248L,4200L,720L,0L,0L,36L,5776L,43000L,43200L,5040L,0L,0L,9L,9066L,222925L,755100L,476280L,40320L,0L,0L,1L,9696L,727375L,6700500L,13003620L,5644800L,362880L,0L,0L,0L,7480L,1674840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104601Inst : IEnumerable<long>
{
public static readonly long[] Value=A104601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104601.Bytes);
public long this[int i]=>Value[i];

public static A104601Inst Instance=new A104601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104602
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,70L,642L,7246L,97052L,1503700L,26448872L,520556146L,11333475922L,270422904986L,7016943483450L,196717253145470L,5925211960335162L,190825629733950454L,6543503207678564364L,BigInteger.Parse("238019066600097607402"),BigInteger.Parse("9153956822981328930170"),BigInteger.Parse("371126108428565106918404") };
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
public class A104602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104602Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104602.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104602.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104602Inst Instance=new A104602Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104603
{
public static readonly BigInteger[] Value={ 3L,10L,36L,544L,BigInteger.Parse("18518801667747479552") };
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
public class A104603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104603.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104603Inst Instance=new A104603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104604
{
public static readonly long[] Value={ 3L,22L,54L,106L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104604Inst : IEnumerable<long>
{
public static readonly long[] Value=A104604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104604.Bytes);
public long this[int i]=>Value[i];

public static A104604Inst Instance=new A104604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104605
{
public static readonly long[] Value={ 0L,-2L,1L,-2L,2L,-2L,0L,2L,-4L,-1L,3L,-4L,1L,3L,-4L,4L,-4L,0L,4L,-4L,-2L,1L,4L,-4L,-2L,2L,4L,-4L,-2L,0L,2L,4L,-6L,-3L,-1L,5L,-6L,-3L,1L,5L,-6L,-3L,2L,5L,-6L,-3L,0L,2L,5L,-6L,-1L,3L,5L,-6L,1L,3L,5L,-6L,6L,-6L,0L,6L,-6L,-2L,1L,6L,-6L,-2L,2L,6L,-6L,-2L,0L,2L,6L,-6L,-4L,-1L,3L,6L,-6L,-4L,1L,3L,6L,-6L,-4L,4L,6L,-6L,-4L,0L,4L,6L,-6L,-4L,-2L,1L,4L,6L,-6L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104605Inst : IEnumerable<long>
{
public static readonly long[] Value=A104605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104605.Bytes);
public long this[int i]=>Value[i];

public static A104605Inst Instance=new A104605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104606
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104606Inst : IEnumerable<long>
{
public static readonly long[] Value=A104606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104606.Bytes);
public long this[int i]=>Value[i];

public static A104606Inst Instance=new A104606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104607
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,1L,1L,2L,1L,2L,0L,1L,1L,0L,1L,1L,2L,0L,0L,1L,2L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,2L,1L,1L,2L,0L,0L,2L,2L,1L,2L,1L,2L,2L,2L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,2L,1L,2L,2L,1L,1L,2L,2L,1L,2L,0L,1L,2L,2L,2L,0L,2L,2L,1L,0L,2L,2L,2L,0L,1L,2L,2L,2L,2L,1L,1L,0L,1L,1L,2L,0L,1L,1L,0L,2L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104607Inst : IEnumerable<long>
{
public static readonly long[] Value=A104607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104607.Bytes);
public long this[int i]=>Value[i];

public static A104607Inst Instance=new A104607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104608
{
public static readonly long[] Value={ 1L,3L,1L,1L,1L,0L,1L,2L,1L,1L,0L,0L,2L,1L,2L,3L,1L,3L,1L,2L,2L,1L,1L,1L,2L,0L,0L,2L,1L,0L,2L,2L,2L,1L,0L,2L,0L,0L,3L,3L,2L,2L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,2L,3L,2L,1L,1L,2L,2L,3L,1L,1L,3L,2L,0L,2L,2L,1L,0L,1L,2L,2L,2L,3L,2L,2L,2L,3L,3L,3L,3L,3L,0L,0L,1L,3L,3L,2L,2L,2L,3L,3L,3L,2L,3L,0L,1L,1L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104608Inst : IEnumerable<long>
{
public static readonly long[] Value=A104608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104608.Bytes);
public long this[int i]=>Value[i];

public static A104608Inst Instance=new A104608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104609
{
public static readonly long[] Value={ 1L,3L,0L,2L,2L,2L,1L,0L,1L,0L,1L,1L,3L,1L,2L,1L,2L,2L,4L,3L,3L,3L,4L,4L,3L,0L,0L,0L,4L,1L,2L,0L,1L,2L,2L,3L,2L,1L,3L,3L,2L,2L,1L,1L,4L,2L,0L,2L,2L,1L,4L,0L,4L,3L,3L,2L,3L,3L,4L,4L,2L,4L,2L,3L,4L,3L,4L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,4L,2L,1L,1L,2L,2L,3L,1L,1L,3L,1L,4L,1L,1L,4L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104609Inst : IEnumerable<long>
{
public static readonly long[] Value=A104609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104609.Bytes);
public long this[int i]=>Value[i];

public static A104609Inst Instance=new A104609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104610
{
public static readonly long[] Value={ 1L,3L,1L,1L,4L,1L,2L,3L,1L,0L,1L,1L,1L,1L,1L,3L,1L,1L,0L,2L,2L,4L,2L,3L,2L,3L,3L,0L,4L,4L,5L,5L,5L,5L,1L,1L,0L,3L,1L,2L,3L,2L,1L,1L,2L,4L,3L,5L,4L,4L,1L,1L,5L,3L,2L,5L,3L,1L,2L,2L,2L,0L,4L,1L,0L,5L,2L,3L,0L,1L,3L,0L,1L,3L,3L,3L,4L,0L,4L,1L,0L,1L,4L,4L,3L,3L,2L,5L,3L,0L,5L,5L,2L,4L,2L,0L,4L,5L,4L,0L,1L,1L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104610Inst : IEnumerable<long>
{
public static readonly long[] Value=A104610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104610.Bytes);
public long this[int i]=>Value[i];

public static A104610Inst Instance=new A104610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104611
{
public static readonly long[] Value={ 1L,3L,6L,1L,1L,2L,3L,0L,3L,4L,1L,0L,1L,4L,2L,1L,6L,5L,1L,4L,4L,2L,5L,6L,2L,2L,4L,3L,2L,5L,3L,5L,2L,4L,4L,2L,5L,6L,5L,5L,4L,4L,6L,0L,2L,1L,3L,1L,1L,3L,1L,2L,2L,1L,1L,1L,1L,5L,4L,4L,4L,1L,1L,3L,1L,2L,6L,0L,2L,2L,3L,0L,2L,1L,2L,2L,2L,2L,0L,6L,2L,2L,5L,6L,4L,3L,6L,0L,3L,6L,2L,2L,2L,3L,0L,3L,3L,5L,6L,6L,2L,4L,3L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104611Inst : IEnumerable<long>
{
public static readonly long[] Value=A104611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104611.Bytes);
public long this[int i]=>Value[i];

public static A104611Inst Instance=new A104611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104612
{
public static readonly long[] Value={ 1L,3L,6L,1L,3L,6L,2L,2L,2L,7L,4L,5L,1L,0L,1L,0L,1L,1L,2L,1L,1L,5L,1L,1L,0L,2L,2L,3L,2L,2L,7L,3L,3L,3L,3L,3L,0L,4L,4L,5L,4L,5L,2L,5L,5L,0L,6L,6L,6L,7L,7L,4L,7L,0L,1L,1L,0L,5L,1L,3L,2L,1L,1L,1L,2L,2L,1L,3L,5L,3L,1L,1L,4L,7L,3L,5L,0L,6L,1L,1L,7L,4L,7L,1L,3L,0L,2L,2L,1L,1L,5L,7L,6L,3L,2L,2L,4L,6L,4L,0L,1L,6L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104612Inst : IEnumerable<long>
{
public static readonly long[] Value=A104612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104612.Bytes);
public long this[int i]=>Value[i];

public static A104612Inst Instance=new A104612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104613
{
public static readonly long[] Value={ 1L,3L,6L,0L,1L,1L,0L,4L,3L,3L,1L,7L,5L,6L,1L,0L,1L,1L,1L,1L,1L,3L,1L,1L,6L,1L,1L,0L,2L,2L,3L,2L,2L,7L,2L,3L,2L,3L,3L,6L,3L,4L,2L,4L,4L,7L,5L,5L,3L,5L,5L,0L,6L,6L,6L,6L,7L,3L,7L,7L,1L,8L,8L,8L,1L,3L,0L,0L,8L,1L,6L,6L,1L,0L,2L,2L,7L,1L,4L,6L,1L,0L,4L,4L,7L,1L,0L,4L,1L,1L,6L,6L,0L,1L,3L,0L,1L,4L,8L,0L,3L,2L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104613Inst : IEnumerable<long>
{
public static readonly long[] Value=A104613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104613.Bytes);
public long this[int i]=>Value[i];

public static A104613Inst Instance=new A104613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104614
{
public static readonly long[] Value={ 1L,3L,6L,10L,1L,1L,8L,1L,2L,3L,5L,0L,4L,5L,10L,7L,7L,8L,1L,0L,1L,0L,1L,1L,2L,1L,1L,5L,1L,1L,8L,1L,1L,0L,2L,2L,3L,2L,2L,6L,2L,2L,10L,3L,3L,3L,3L,3L,8L,3L,4L,1L,4L,4L,6L,4L,4L,0L,5L,5L,6L,5L,5L,1L,6L,6L,7L,6L,7L,2L,7L,7L,8L,8L,8L,4L,8L,8L,0L,9L,9L,8L,9L,10L,4L,10L,10L,2L,1L,5L,0L,0L,0L,1L,9L,0L,1L,0L,2L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104614Inst : IEnumerable<long>
{
public static readonly long[] Value=A104614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104614.Bytes);
public long this[int i]=>Value[i];

public static A104614Inst Instance=new A104614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104615
{
public static readonly long[] Value={ 1L,3L,6L,10L,1L,4L,1L,2L,4L,9L,3L,3L,3L,10L,5L,6L,10L,7L,8L,9L,1L,0L,1L,1L,1L,1L,1L,3L,1L,1L,6L,1L,1L,8L,1L,1L,11L,2L,2L,3L,2L,2L,6L,2L,2L,10L,2L,3L,2L,3L,3L,6L,3L,3L,11L,4L,4L,3L,4L,4L,8L,4L,5L,2L,5L,5L,7L,5L,5L,1L,6L,6L,7L,6L,6L,1L,7L,7L,8L,7L,8L,2L,8L,8L,9L,9L,9L,5L,9L,9L,0L,10L,10L,8L,10L,11L,4L,11L,11L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104615Inst : IEnumerable<long>
{
public static readonly long[] Value=A104615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104615.Bytes);
public long this[int i]=>Value[i];

public static A104615Inst Instance=new A104615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104616
{
public static readonly long[] Value={ 1L,3L,6L,10L,1L,1L,7L,11L,2L,2L,0L,6L,4L,4L,1L,9L,6L,7L,10L,7L,9L,10L,1L,0L,1L,8L,4L,1L,10L,7L,1L,2L,0L,1L,10L,9L,1L,8L,8L,1L,9L,10L,2L,0L,2L,2L,7L,10L,2L,4L,8L,3L,4L,9L,3L,7L,0L,3L,0L,7L,4L,9L,4L,4L,8L,4L,4L,10L,7L,5L,2L,0L,5L,10L,9L,6L,8L,8L,6L,9L,10L,7L,0L,2L,7L,7L,10L,8L,4L,8L,8L,4L,9L,9L,7L,0L,9L,0L,7L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104616Inst : IEnumerable<long>
{
public static readonly long[] Value=A104616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104616.Bytes);
public long this[int i]=>Value[i];

public static A104616Inst Instance=new A104616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104617
{
public static readonly long[] Value={ 1L,3L,6L,10L,0L,3L,1L,1L,1L,6L,2L,3L,10L,3L,4L,5L,13L,8L,7L,8L,10L,7L,10L,11L,1L,0L,1L,0L,1L,1L,2L,1L,1L,5L,1L,1L,7L,1L,1L,10L,1L,1L,13L,2L,2L,2L,2L,2L,6L,2L,2L,9L,2L,2L,13L,3L,3L,3L,3L,3L,8L,3L,3L,12L,4L,4L,3L,4L,4L,8L,4L,4L,13L,5L,5L,4L,5L,5L,10L,5L,6L,2L,6L,6L,8L,6L,6L,0L,7L,7L,6L,7L,7L,13L,8L,8L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104617Inst : IEnumerable<long>
{
public static readonly long[] Value=A104617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104617.Bytes);
public long this[int i]=>Value[i];

public static A104617Inst Instance=new A104617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104618
{
public static readonly long[] Value={ 1L,3L,6L,10L,1L,1L,6L,10L,2L,2L,10L,1L,3L,4L,7L,0L,5L,6L,12L,7L,8L,8L,10L,7L,11L,12L,1L,0L,1L,1L,1L,1L,1L,3L,1L,1L,5L,1L,1L,8L,1L,1L,11L,1L,1L,14L,2L,2L,2L,2L,2L,5L,2L,2L,9L,2L,2L,13L,2L,3L,2L,3L,3L,6L,3L,3L,10L,3L,3L,0L,4L,4L,5L,4L,4L,10L,4L,4L,0L,5L,5L,5L,5L,5L,11L,5L,6L,2L,6L,6L,8L,6L,6L,14L,7L,7L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104618Inst : IEnumerable<long>
{
public static readonly long[] Value=A104618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104618.Bytes);
public long this[int i]=>Value[i];

public static A104618Inst Instance=new A104618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104619
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,2L,1L,1L,14L,3L,2L,2L,5L,12L,4L,4L,4L,13L,6L,7L,11L,6L,9L,9L,10L,7L,12L,13L,1L,0L,1L,10L,5L,1L,12L,8L,1L,1L,14L,1L,9L,7L,1L,4L,3L,1L,2L,2L,1L,3L,4L,2L,7L,9L,2L,14L,1L,2L,8L,12L,2L,5L,10L,3L,5L,11L,3L,8L,15L,3L,14L,6L,3L,7L,0L,4L,3L,13L,4L,2L,13L,4L,4L,0L,5L,9L,6L,5L,1L,15L,5L,12L,11L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104619Inst : IEnumerable<long>
{
public static readonly long[] Value=A104619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104619.Bytes);
public long this[int i]=>Value[i];

public static A104619Inst Instance=new A104619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104620
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,9L,6L,1L,8L,2L,3L,1L,4L,2L,19L,10L,1L,7L,2L,5L,31L,8L,1L,6L,2L,10L,18L,3L,14L,1L,7L,2L,11L,12L,3L,10L,4L,1L,29L,2L,8L,13L,3L,12L,62L,13L,1L,5L,2L,12L,6L,3L,9L,23L,73L,12L,1L,9L,2L,13L,11L,3L,16L,7L,80L,4L,22L,1L,8L,2L,6L,15L,3L,18L,19L,10L,4L,37L,11L,1L,9L,2L,13L,70L,3L,7L,26L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104620Inst : IEnumerable<long>
{
public static readonly long[] Value=A104620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104620.Bytes);
public long this[int i]=>Value[i];

public static A104620Inst Instance=new A104620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104621
{
public static readonly long[] Value={ 7L,1L,3L,7L,15L,31L,63L,127L,247L,493L,983L,1959L,3903L,7775L,15487L,30847L,61447L,122401L,243819L,485679L,967455L,1927135L,3838783L,7646719L,15231991L,30341581L,60439343L,120393007L,239818559L,477709983L,951581183L,1895515647L,3775799303L,7521257025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104621Inst : IEnumerable<long>
{
public static readonly long[] Value=A104621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104621.Bytes);
public long this[int i]=>Value[i];

public static A104621Inst Instance=new A104621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104622
{
public static readonly long[] Value={ 0L,2L,3L,5L,7L,10L,17L,24L,25L,26L,28L,38L,40L,49L,62L,79L,89L,114L,140L,145L,182L,248L,353L,437L,654L,702L,784L,921L,931L,986L,1206L,2136L,2137L,3351L,5411L,13264L,13757L,16348L,27087L,27160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104622Inst : IEnumerable<long>
{
public static readonly long[] Value=A104622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104622.Bytes);
public long this[int i]=>Value[i];

public static A104622Inst Instance=new A104622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104623
{
public static readonly long[] Value={ 4L,8L,9L,11L,12L,14L,15L,16L,22L,23L,32L,34L,37L,41L,42L,50L,52L,57L,58L,66L,69L,76L,77L,81L,90L,120L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104623Inst : IEnumerable<long>
{
public static readonly long[] Value=A104623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104623.Bytes);
public long this[int i]=>Value[i];

public static A104623Inst Instance=new A104623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104624
{
public static readonly long[] Value={ 1L,-2L,2L,0L,-2L,0L,4L,0L,-10L,0L,28L,0L,-84L,0L,264L,0L,-858L,0L,2860L,0L,-9724L,0L,33592L,0L,-117572L,0L,416024L,0L,-1485800L,0L,5348880L,0L,-19389690L,0L,70715340L,0L,-259289580L,0L,955277400L,0L,-3534526380L,0L,13128240840L,0L,-48932534040L,0L,182965127280L,0L,-686119227300L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104624Inst : IEnumerable<long>
{
public static readonly long[] Value=A104624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104624.Bytes);
public long this[int i]=>Value[i];

public static A104624Inst Instance=new A104624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104625
{
public static readonly long[] Value={ 1L,2L,7L,24L,87L,322L,1211L,4604L,17645L,68042L,263655L,1025632L,4002601L,15662422L,61427543L,241386924L,950160607L,3745589510L,14784496003L,58424093536L,231112008371L,915065382154L,3626113490579L,14379912928572L,57064644495359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104625Inst : IEnumerable<long>
{
public static readonly long[] Value=A104625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104625.Bytes);
public long this[int i]=>Value[i];

public static A104625Inst Instance=new A104625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104626
{
public static readonly long[] Value={ 4L,5L,6L,8L,19L,48L,124L,323L,844L,2208L,5779L,15128L,39604L,103683L,271444L,710648L,1860499L,4870848L,12752044L,33385283L,87403804L,228826128L,599074579L,1568397608L,4106118244L,10749957123L,28143753124L,73681302248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104626Inst : IEnumerable<long>
{
public static readonly long[] Value=A104626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104626.Bytes);
public long this[int i]=>Value[i];

public static A104626Inst Instance=new A104626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104627
{
public static readonly long[] Value={ 9L,10L,12L,13L,14L,16L,17L,20L,21L,25L,36L,49L,50L,54L,65L,94L,125L,126L,130L,141L,170L,246L,324L,325L,329L,340L,369L,445L,644L,845L,846L,850L,861L,890L,966L,1165L,1686L,2209L,2210L,2214L,2225L,2254L,2330L,2529L,3050L,4414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104627Inst : IEnumerable<long>
{
public static readonly long[] Value=A104627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104627.Bytes);
public long this[int i]=>Value[i];

public static A104627Inst Instance=new A104627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104628
{
public static readonly long[] Value={ 11L,15L,22L,23L,24L,26L,30L,31L,32L,34L,35L,37L,41L,42L,43L,45L,46L,51L,52L,53L,55L,66L,83L,95L,112L,127L,128L,129L,131L,142L,171L,217L,247L,293L,326L,327L,328L,330L,341L,370L,446L,568L,645L,767L,847L,848L,849L,851L,862L,891L,967L,1166L,1487L,1687L,2008L,2211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104628Inst : IEnumerable<long>
{
public static readonly long[] Value=A104628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104628.Bytes);
public long this[int i]=>Value[i];

public static A104628Inst Instance=new A104628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104629
{
public static readonly long[] Value={ 1L,2L,6L,18L,57L,186L,622L,2120L,7338L,25724L,91144L,325878L,1174281L,4260282L,15548694L,57048048L,210295326L,778483932L,2892818244L,10786724388L,40347919626L,151355847012L,569274150156L,2146336125648L,8110508473252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104629Inst : IEnumerable<long>
{
public static readonly long[] Value=A104629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104629.Bytes);
public long this[int i]=>Value[i];

public static A104629Inst Instance=new A104629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104630
{
public static readonly long[] Value={ 0L,1L,5L,18L,60L,198L,655L,2171L,7200L,23880L,79200L,262669L,871145L,2889162L,9581940L,31778622L,105394195L,349541159L,1159257600L,3844692240L,12750969600L,42288749161L,140251162205L,465144722658L,1542658254060L,5116245273558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104630Inst : IEnumerable<long>
{
public static readonly long[] Value=A104630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104630.Bytes);
public long this[int i]=>Value[i];

public static A104630Inst Instance=new A104630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104631
{
public static readonly long[] Value={ 0L,1L,4L,18L,80L,365L,1686L,7875L,37080L,175725L,837100L,4004770L,19227924L,92599533L,447118140L,2163837030L,10492874384L,50972030189L,248000853348L,1208335275170L,5894873067200L,28791371852145L,140768761906190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104631Inst : IEnumerable<long>
{
public static readonly long[] Value=A104631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104631.Bytes);
public long this[int i]=>Value[i];

public static A104631Inst Instance=new A104631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104632
{
public static readonly long[] Value={ 1L,2L,6L,20L,73L,281L,1125L,4635L,19525L,83710L,364070L,1602327L,7123041L,31937010L,144255802L,655804649L,2998354717L,13777825186L,63596593430L,294743653360L,1371017707245L,6398580086645L,29952930770185L,140604572777250L,661708404611603L,3121439743413256L,14756658303857332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104632Inst : IEnumerable<long>
{
public static readonly long[] Value=A104632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104632.Bytes);
public long this[int i]=>Value[i];

public static A104632Inst Instance=new A104632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104633
{
public static readonly long[] Value={ 1L,3L,2L,6L,6L,3L,10L,12L,9L,4L,15L,20L,18L,12L,5L,21L,30L,30L,24L,15L,6L,28L,42L,45L,40L,30L,18L,7L,36L,56L,63L,60L,50L,36L,21L,8L,45L,72L,84L,84L,75L,60L,42L,24L,9L,55L,90L,108L,112L,105L,90L,70L,48L,27L,10L,66L,110L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104633Inst : IEnumerable<long>
{
public static readonly long[] Value=A104633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104633.Bytes);
public long this[int i]=>Value[i];

public static A104633Inst Instance=new A104633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104634
{
public static readonly long[] Value={ 1L,5L,2L,14L,8L,3L,30L,20L,11L,4L,55L,40L,26L,14L,5L,91L,70L,50L,32L,17L,6L,140L,112L,85L,60L,38L,20L,7L,204L,168L,133L,100L,70L,44L,23L,8L,285L,240L,196L,154L,115L,80L,50L,26L,9L,385L,330L,276L,224L,175L,130L,90L,56L,29L,10L,506L,440L,375L,312L,252L,196L,145L,100L,62L,32L,11L,650L,572L,495L,420L,348L,280L,217L,160L,110L,68L,35L,12L,819L,728L,638L,550L,465L,384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104634Inst : IEnumerable<long>
{
public static readonly long[] Value=A104634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104634.Bytes);
public long this[int i]=>Value[i];

public static A104634Inst Instance=new A104634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104635
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,15L,21L,23L,29L,33L,35L,39L,41L,51L,53L,63L,65L,69L,75L,81L,83L,89L,95L,99L,105L,111L,113L,119L,125L,131L,135L,141L,153L,155L,165L,173L,179L,183L,189L,191L,209L,215L,219L,221L,231L,233L,239L,243L,245L,249L,251L,261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104635Inst : IEnumerable<long>
{
public static readonly long[] Value=A104635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104635.Bytes);
public long this[int i]=>Value[i];

public static A104635Inst Instance=new A104635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104636
{
public static readonly long[] Value={ 2L,6L,8L,14L,18L,20L,26L,30L,36L,44L,48L,50L,54L,56L,68L,74L,78L,86L,90L,96L,98L,114L,116L,120L,128L,134L,138L,140L,146L,156L,158L,168L,174L,176L,186L,194L,198L,200L,204L,210L,216L,224L,228L,230L,254L,260L,270L,278L,284L,288L,296L,300L,306L,308L,320L,326L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104636Inst : IEnumerable<long>
{
public static readonly long[] Value=A104636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104636.Bytes);
public long this[int i]=>Value[i];

public static A104636Inst Instance=new A104636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104637
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,2L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,2L,2L,1L,2L,1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104637Inst : IEnumerable<long>
{
public static readonly long[] Value=A104637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104637.Bytes);
public long this[int i]=>Value[i];

public static A104637Inst Instance=new A104637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104638
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,3L,2L,3L,3L,3L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,3L,3L,2L,1L,1L,1L,2L,2L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,3L,3L,3L,3L,3L,2L,2L,3L,3L,2L,3L,3L,2L,2L,3L,1L,1L,2L,1L,2L,2L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104638Inst : IEnumerable<long>
{
public static readonly long[] Value=A104638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104638.Bytes);
public long this[int i]=>Value[i];

public static A104638Inst Instance=new A104638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104639
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,1L,1L,3L,0L,2L,1L,3L,0L,3L,1L,2L,2L,4L,2L,4L,2L,3L,2L,1L,2L,2L,3L,4L,1L,3L,0L,2L,3L,4L,2L,3L,0L,5L,3L,4L,1L,3L,1L,1L,3L,2L,2L,4L,2L,5L,3L,3L,2L,2L,1L,1L,2L,5L,4L,4L,4L,5L,4L,4L,3L,3L,3L,4L,0L,3L,2L,5L,3L,3L,2L,3L,2L,4L,2L,2L,1L,3L,3L,4L,3L,4L,3L,4L,0L,4L,3L,4L,1L,4L,2L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104639Inst : IEnumerable<long>
{
public static readonly long[] Value=A104639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104639.Bytes);
public long this[int i]=>Value[i];

public static A104639Inst Instance=new A104639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104640
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,2L,2L,2L,1L,4L,2L,3L,1L,4L,1L,3L,2L,2L,0L,2L,1L,3L,2L,3L,4L,3L,3L,2L,1L,4L,2L,5L,3L,2L,1L,3L,2L,5L,0L,2L,1L,4L,2L,4L,4L,3L,4L,4L,2L,4L,1L,3L,3L,4L,4L,5L,5L,4L,1L,2L,2L,2L,1L,2L,2L,3L,3L,3L,2L,6L,3L,4L,1L,3L,3L,4L,3L,4L,2L,4L,4L,5L,3L,3L,2L,3L,2L,3L,2L,6L,2L,3L,2L,5L,2L,4L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104640Inst : IEnumerable<long>
{
public static readonly long[] Value=A104640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104640.Bytes);
public long this[int i]=>Value[i];

public static A104640Inst Instance=new A104640Inst();

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