using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A189887
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,9L,11L,12L,14L,17L,19L,20L,22L,25L,27L,28L,30L,33L,35L,36L,38L,41L,43L,44L,46L,49L,51L,52L,54L,57L,59L,60L,62L,65L,67L,68L,70L,73L,75L,76L,78L,81L,83L,84L,86L,89L,91L,92L,94L,97L,99L,100L,102L,105L,107L,108L,110L,113L,115L,116L,118L,121L,123L,124L,126L,129L,131L,132L,134L,137L,139L,140L,142L,145L,147L,148L,150L,153L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189887Inst : IEnumerable<long>
{
public static readonly long[] Value=A189887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189887.Bytes);
public long this[int i]=>Value[i];

public static A189887Inst Instance=new A189887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189888
{
public static readonly long[] Value={ 11L,19L,43L,97L,163L,191L,223L,457L,877L,1049L,1307L,1987L,2029L,2129L,4217L,6599L,9967L,10357L,18233L,66343L,74573L,95911L,99719L,186551L,196337L,211219L,262469L,277301L,416573L,603487L,994549L,1403137L,4117441L,4805761L,4895789L,5823067L,5842813L,7704409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189888Inst : IEnumerable<long>
{
public static readonly long[] Value=A189888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189888.Bytes);
public long this[int i]=>Value[i];

public static A189888Inst Instance=new A189888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189889
{
public static readonly long[] Value={ 1L,1L,1L,4L,5L,9L,10L,16L,18L,25L,27L,36L,39L,49L,52L,64L,68L,81L,85L,100L,105L,121L,126L,144L,150L,169L,175L,196L,203L,225L,232L,256L,264L,289L,297L,324L,333L,361L,370L,400L,410L,441L,451L,484L,495L,529L,540L,576L,588L,625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189889Inst : IEnumerable<long>
{
public static readonly long[] Value=A189889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189889.Bytes);
public long this[int i]=>Value[i];

public static A189889Inst Instance=new A189889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189890
{
public static readonly long[] Value={ 2L,4L,10L,23L,46L,82L,134L,205L,298L,416L,562L,739L,950L,1198L,1486L,1817L,2194L,2620L,3098L,3631L,4222L,4874L,5590L,6373L,7226L,8152L,9154L,10235L,11398L,12646L,13982L,15409L,16930L,18548L,20266L,22087L,24014L,26050L,28198L,30461L,32842L,35344L,37970L,40723L,43606L,46622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189890Inst : IEnumerable<long>
{
public static readonly long[] Value=A189890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189890.Bytes);
public long this[int i]=>Value[i];

public static A189890Inst Instance=new A189890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189891
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,11L,12L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,74L,75L,76L,77L,78L,79L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189891Inst : IEnumerable<long>
{
public static readonly long[] Value=A189891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189891.Bytes);
public long this[int i]=>Value[i];

public static A189891Inst Instance=new A189891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189892
{
public static readonly long[] Value={ 2L,4L,10L,18L,38L,50L,78L,94L,130L,190L,212L,284L,336L,364L,424L,520L,622L,658L,772L,852L,894L,1026L,1118L,1262L,1462L,1566L,1620L,1732L,1790L,1910L,2344L,2472L,2670L,2738L,3088L,3160L,3382L,3610L,3766L,4006L,4252L,4336L,4766L,4854L,5034L,5126L,5690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189892Inst : IEnumerable<long>
{
public static readonly long[] Value=A189892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189892.Bytes);
public long this[int i]=>Value[i];

public static A189892Inst Instance=new A189892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189893
{
public static readonly long[] Value={ 0L,4L,10L,65L,173L,22L,96L,15L,48L,78L,13L,201L,487L,594L,2719L,5146L,8719L,11530L,15308L,76411L,76016L,42220L,67129L,45349L,170266L,255576L,457846L,865810L,1131083L,8045547L,7669757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189893Inst : IEnumerable<long>
{
public static readonly long[] Value=A189893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189893.Bytes);
public long this[int i]=>Value[i];

public static A189893Inst Instance=new A189893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189894
{
public static readonly long[] Value={ 4L,50L,208L,582L,1308L,2556L,4528L,7460L,11620L,17310L,24864L,34650L,47068L,62552L,81568L,104616L,132228L,164970L,203440L,248270L,300124L,359700L,427728L,504972L,592228L,690326L,800128L,922530L,1058460L,1208880L,1374784L,1557200L,1757188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189894Inst : IEnumerable<long>
{
public static readonly long[] Value=A189894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189894.Bytes);
public long this[int i]=>Value[i];

public static A189894Inst Instance=new A189894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189895
{
public static readonly long[] Value={ 4L,10L,10L,16L,28L,16L,22L,50L,50L,22L,28L,74L,96L,74L,28L,34L,98L,150L,150L,98L,34L,40L,122L,208L,244L,208L,122L,40L,46L,146L,268L,350L,350L,268L,146L,46L,52L,170L,328L,464L,516L,464L,328L,170L,52L,58L,194L,388L,582L,700L,700L,582L,388L,194L,58L,64L,218L,448L,702L,896L,968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189895Inst : IEnumerable<long>
{
public static readonly long[] Value=A189895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189895.Bytes);
public long this[int i]=>Value[i];

public static A189895Inst Instance=new A189895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189896
{
public static readonly long[] Value={ 1L,2L,4L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189896Inst : IEnumerable<long>
{
public static readonly long[] Value=A189896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189896.Bytes);
public long this[int i]=>Value[i];

public static A189896Inst Instance=new A189896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189897
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,329L,8636L,355297L,21117286L,1710243761L,180811765432L,24158025584801L,3977274470362634L,790696358461658761L,BigInteger.Parse("186695449895152470052"),BigInteger.Parse("51635196859642278380513"),BigInteger.Parse("16532803795918313120452246") };
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
public class A189897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189897.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189897Inst Instance=new A189897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189898
{
public static readonly long[] Value={ 1L,3L,1L,54L,9L,1L,3834L,243L,18L,1L,1027080L,20790L,675L,30L,1L,1067308488L,6364170L,67635L,1485L,45L,1L,4390480193904L,7543111716L,23031540L,171045L,2835L,63L,1L,72022346388181584L,35217115838604L,30469951764L,63580545L,370440L,4914L,84L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189898Inst : IEnumerable<long>
{
public static readonly long[] Value=A189898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189898.Bytes);
public long this[int i]=>Value[i];

public static A189898Inst Instance=new A189898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189899
{
public static readonly long[] Value={ 2L,16L,512L,35656L,6442436L,2719427244L,2662054379066L,6207537762978575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189899Inst : IEnumerable<long>
{
public static readonly long[] Value=A189899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189899.Bytes);
public long this[int i]=>Value[i];

public static A189899Inst Instance=new A189899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189948
{
public static readonly long[] Value={ 14L,61L,542L,6733L,77459L,839968L,9133420L,101599137L,1148390301L,13075280021L,149477475730L,1715275336520L,19756078906837L,228289957465939L,2645189908828920L,30720393567321132L,357493766148806039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189948Inst : IEnumerable<long>
{
public static readonly long[] Value=A189948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189948.Bytes);
public long this[int i]=>Value[i];

public static A189948Inst Instance=new A189948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189949
{
public static readonly long[] Value={ 16L,75L,889L,13034L,168737L,2095080L,26586582L,346371666L,4569825052L,60616719909L,807520929855L,10805101528251L,145152790595820L,1956318942197183L,26437935517478725L,358117322511949885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189949Inst : IEnumerable<long>
{
public static readonly long[] Value=A189949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189949.Bytes);
public long this[int i]=>Value[i];

public static A189949Inst Instance=new A189949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189950
{
public static readonly long[] Value={ 20L,103L,1350L,22220L,327880L,4678100L,68081570L,1012894742L,15245829657L,230937539015L,3515809056902L,53766069905706L,825394005427540L,12711935460761503L,196311914160978767L,3038824326513268799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189950Inst : IEnumerable<long>
{
public static readonly long[] Value=A189950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189950.Bytes);
public long this[int i]=>Value[i];

public static A189950Inst Instance=new A189950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189951
{
public static readonly long[] Value={ 1L,3L,2L,5L,8L,4L,8L,15L,22L,8L,10L,29L,63L,72L,16L,14L,39L,159L,384L,280L,32L,16L,61L,306L,1246L,2393L,1152L,64L,20L,75L,542L,3247L,9884L,13569L,4632L,128L,23L,103L,889L,6733L,31284L,73992L,72744L,17888L,256L,27L,124L,1350L,13034L,77459L,280284L,542353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189951Inst : IEnumerable<long>
{
public static readonly long[] Value=A189951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189951.Bytes);
public long this[int i]=>Value[i];

public static A189951Inst Instance=new A189951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189952
{
public static readonly long[] Value={ 2L,8L,15L,29L,39L,61L,75L,103L,124L,155L,176L,225L,250L,289L,325L,381L,413L,475L,512L,578L,626L,688L,730L,826L,877L,947L,1009L,1095L,1150L,1255L,1317L,1419L,1489L,1578L,1650L,1789L,1862L,1959L,2040L,2176L,2254L,2391L,2476L,2601L,2708L,2831L,2918L,3098L,3197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189952Inst : IEnumerable<long>
{
public static readonly long[] Value=A189952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189952.Bytes);
public long this[int i]=>Value[i];

public static A189952Inst Instance=new A189952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189953
{
public static readonly long[] Value={ 4L,22L,63L,159L,306L,542L,889L,1350L,1940L,2734L,3670L,4819L,6238L,7852L,9688L,11986L,14411L,17274L,20412L,23919L,27900L,32443L,37028L,42280L,48028L,54459L,60919L,68477L,76078L,84753L,93786L,103538L,113637L,125008L,136030L,149100L,162115L,176241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189953Inst : IEnumerable<long>
{
public static readonly long[] Value=A189953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189953.Bytes);
public long this[int i]=>Value[i];

public static A189953Inst Instance=new A189953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189954
{
public static readonly long[] Value={ 8L,72L,384L,1246L,3247L,6733L,13034L,22220L,36293L,55724L,82485L,116630L,162360L,219198L,290165L,376419L,481243L,606253L,754108L,927521L,1130575L,1364106L,1631281L,1935163L,2280562L,2673957L,3110403L,3602734L,4147102L,4757233L,5423413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189954Inst : IEnumerable<long>
{
public static readonly long[] Value=A189954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189954.Bytes);
public long this[int i]=>Value[i];

public static A189954Inst Instance=new A189954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189955
{
public static readonly long[] Value={ 16L,280L,2393L,9884L,31284L,77459L,168737L,327880L,595697L,1005710L,1621554L,2504978L,3738572L,5418036L,7662698L,10565406L,14315713L,19055943L,24956731L,32281835L,41217268L,51991454L,64917759L,80355606L,98539718L,119899372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189955Inst : IEnumerable<long>
{
public static readonly long[] Value=A189955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189955.Bytes);
public long this[int i]=>Value[i];

public static A189955Inst Instance=new A189955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189956
{
public static readonly long[] Value={ 32L,1152L,13569L,73992L,280284L,839968L,2095080L,4678100L,9483181L,17859030L,31526421L,53335818L,86113621L,134395470L,203331437L,299865250L,431183908L,608327784L,840894817L,1144932377L,1534996553L,2030482093L,2648947079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189956Inst : IEnumerable<long>
{
public static readonly long[] Value=A189956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189956.Bytes);
public long this[int i]=>Value[i];

public static A189956Inst Instance=new A189956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189957
{
public static readonly long[] Value={ 64L,4632L,72744L,542353L,2514945L,9133420L,26586582L,68081570L,154928607L,325585559L,631690148L,1167609345L,2043508680L,3435508142L,5566095860L,8767568010L,13387924849L,20010820026L,29195103851L,41845814529L,58906853906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189957Inst : IEnumerable<long>
{
public static readonly long[] Value=A189957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189957.Bytes);
public long this[int i]=>Value[i];

public static A189957Inst Instance=new A189957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189958
{
public static readonly long[] Value={ 128L,17888L,393006L,4014514L,23257218L,101599137L,346371666L,1012894742L,2594438857L,6057314932L,12928069327L,26059247016L,49402250718L,89428018287L,155225765626L,260730899098L,422939460592L,669282239159L,1030485287990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189958Inst : IEnumerable<long>
{
public static readonly long[] Value=A189958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189958.Bytes);
public long this[int i]=>Value[i];

public static A189958Inst Instance=new A189958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189959
{
public static readonly long[] Value={ 2L,7L,6L,7L,7L,6L,6L,9L,5L,2L,9L,6L,6L,3L,6L,8L,8L,1L,1L,0L,0L,2L,1L,1L,0L,9L,0L,5L,2L,6L,2L,1L,2L,2L,5L,9L,8L,2L,1L,2L,0L,8L,9L,8L,4L,4L,2L,2L,1L,1L,8L,5L,0L,9L,1L,4L,7L,0L,8L,4L,9L,6L,7L,2L,4L,8L,8L,4L,1L,5L,5L,9L,8L,0L,7L,7L,6L,3L,3L,7L,9L,8L,5L,6L,2L,9L,8L,4L,4L,1L,7L,9L,0L,9L,5L,5L,1L,9L,6L,5L,9L,1L,8L,7L,6L,7L,3L,0L,7L,7L,8L,8L,6L,4L,0L,3L,7L,1L,2L,8L,1L,1L,5L,6L,0L,4L,5L,0L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189959Inst : IEnumerable<long>
{
public static readonly long[] Value=A189959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189959.Bytes);
public long this[int i]=>Value[i];

public static A189959Inst Instance=new A189959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189960
{
public static readonly long[] Value={ 2L,7L,7L,5L,5L,1L,5L,6L,5L,7L,8L,8L,6L,6L,8L,0L,3L,7L,1L,6L,2L,6L,2L,1L,1L,5L,0L,3L,1L,5L,6L,5L,7L,9L,3L,0L,1L,2L,5L,7L,7L,1L,4L,1L,5L,5L,0L,1L,0L,4L,4L,6L,9L,3L,9L,7L,5L,1L,1L,9L,7L,2L,3L,0L,9L,2L,6L,4L,5L,7L,4L,6L,5L,7L,9L,2L,7L,5L,8L,2L,3L,8L,1L,7L,4L,1L,4L,4L,9L,0L,7L,4L,6L,1L,5L,4L,8L,3L,8L,0L,2L,2L,6L,1L,9L,8L,4L,6L,1L,6L,6L,0L,8L,6L,0L,7L,0L,7L,0L,3L,9L,5L,8L,6L,5L,0L,4L,3L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189960Inst : IEnumerable<long>
{
public static readonly long[] Value=A189960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189960.Bytes);
public long this[int i]=>Value[i];

public static A189960Inst Instance=new A189960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189961
{
public static readonly long[] Value={ 2L,0L,6L,5L,2L,4L,7L,5L,8L,4L,2L,4L,9L,8L,5L,2L,7L,8L,7L,4L,8L,6L,4L,2L,1L,5L,6L,8L,1L,1L,1L,8L,9L,3L,3L,6L,4L,8L,0L,8L,4L,3L,2L,8L,5L,1L,7L,2L,8L,0L,6L,8L,0L,0L,6L,9L,8L,9L,6L,2L,8L,0L,7L,1L,7L,8L,7L,3L,6L,4L,6L,4L,7L,9L,4L,6L,4L,6L,3L,4L,2L,9L,5L,9L,0L,0L,9L,0L,0L,8L,5L,8L,6L,5L,1L,4L,7L,5L,9L,2L,4L,7L,8L,6L,5L,5L,7L,2L,3L,3L,0L,5L,5L,4L,1L,6L,4L,8L,4L,5L,2L,9L,7L,7L,2L,8L,7L,4L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189961Inst : IEnumerable<long>
{
public static readonly long[] Value=A189961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189961.Bytes);
public long this[int i]=>Value[i];

public static A189961Inst Instance=new A189961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189962
{
public static readonly long[] Value={ 2L,1L,0L,2L,2L,3L,7L,4L,3L,6L,1L,3L,6L,1L,9L,1L,5L,6L,9L,7L,8L,9L,3L,2L,3L,9L,1L,0L,7L,8L,0L,1L,3L,5L,1L,0L,1L,7L,2L,4L,1L,4L,2L,2L,9L,4L,2L,2L,7L,6L,1L,1L,9L,5L,6L,2L,2L,1L,6L,4L,3L,2L,0L,0L,7L,9L,0L,4L,2L,6L,2L,1L,1L,8L,8L,5L,4L,7L,6L,7L,3L,5L,8L,8L,4L,5L,2L,0L,8L,7L,9L,5L,8L,2L,6L,4L,0L,0L,4L,3L,1L,5L,6L,8L,7L,0L,3L,2L,5L,9L,4L,1L,5L,4L,2L,1L,8L,6L,5L,0L,3L,4L,7L,9L,9L,4L,6L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189962Inst : IEnumerable<long>
{
public static readonly long[] Value=A189962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189962.Bytes);
public long this[int i]=>Value[i];

public static A189962Inst Instance=new A189962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189963
{
public static readonly long[] Value={ 2L,0L,9L,3L,7L,1L,7L,6L,4L,9L,7L,9L,1L,5L,0L,8L,9L,3L,8L,9L,7L,3L,5L,4L,6L,9L,1L,8L,2L,1L,5L,1L,2L,3L,8L,4L,3L,2L,4L,7L,1L,3L,0L,4L,3L,6L,3L,7L,5L,3L,1L,0L,9L,5L,9L,8L,6L,9L,8L,3L,9L,6L,0L,0L,7L,2L,4L,5L,5L,7L,3L,6L,0L,8L,9L,5L,0L,2L,0L,3L,4L,1L,2L,2L,7L,4L,7L,7L,4L,7L,2L,9L,5L,0L,7L,5L,3L,3L,7L,2L,8L,9L,3L,7L,9L,7L,7L,9L,8L,7L,7L,9L,7L,4L,7L,0L,0L,4L,2L,9L,4L,8L,5L,6L,6L,1L,7L,4L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189963Inst : IEnumerable<long>
{
public static readonly long[] Value=A189963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189963.Bytes);
public long this[int i]=>Value[i];

public static A189963Inst Instance=new A189963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189996
{
public static readonly long[] Value={ 2L,2L,1L,0L,1L,1L,1L,0L,2L,2L,1L,0L,1L,1L,1L,0L,2L,2L,1L,0L,1L,1L,1L,0L,2L,2L,1L,0L,1L,1L,1L,0L,2L,2L,1L,0L,1L,1L,1L,0L,2L,2L,1L,0L,1L,1L,1L,0L,2L,2L,1L,0L,1L,1L,1L,0L,2L,2L,1L,0L,1L,1L,1L,0L,2L,2L,1L,0L,1L,1L,1L,0L,2L,2L,1L,0L,1L,1L,1L,0L,2L,2L,1L,0L,1L,1L,1L,0L,2L,2L,1L,0L,1L,1L,1L,0L,2L,2L,1L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189996Inst : IEnumerable<long>
{
public static readonly long[] Value=A189996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189996.Bytes);
public long this[int i]=>Value[i];

public static A189996Inst Instance=new A189996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189997
{
public static readonly BigInteger[] Value={ 1L,5L,41L,941L,45041L,5381141L,907182041L,94345513738241L,94345513738241L,49864774158575141L,BigInteger.Parse("41906795264466408041"),BigInteger.Parse("40266416996450293824941"),BigInteger.Parse("40224560065959985992041"),BigInteger.Parse("92623330435402220948130112241") };
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
public class A189997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189997Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189997.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189997.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189997Inst Instance=new A189997Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189998
{
public static readonly long[] Value={ 137L,29L,153L,743L,1879L,1627L,15797L,2021L,11899L,25381L,7793L,2627L,124877L,26987L,68879L,65003L,107699L,66167L,482897L,16167L,77293L,412561L,323959L,94781L,1323137L,255127L,587299L,504563L,255733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189998Inst : IEnumerable<long>
{
public static readonly long[] Value=A189998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189998.Bytes);
public long this[int i]=>Value[i];

public static A189998Inst Instance=new A189998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189999
{
public static readonly long[] Value={ 3L,7L,10L,14L,17L,22L,25L,29L,32L,36L,39L,44L,48L,51L,55L,58L,62L,66L,70L,73L,77L,80L,85L,89L,92L,96L,99L,103L,107L,111L,114L,118L,121L,125L,130L,133L,137L,140L,144L,148L,152L,155L,159L,162L,166L,170L,174L,178L,181L,185L,188L,193L,196L,200L,203L,207L,210L,215L,219L,222L,226L,229L,234L,237L,241L,244L,248L,251L,256L,260L,263L,267L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189999Inst : IEnumerable<long>
{
public static readonly long[] Value=A189999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189999.Bytes);
public long this[int i]=>Value[i];

public static A189999Inst Instance=new A189999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190000
{
public static readonly long[] Value={ 2L,5L,8L,12L,15L,18L,21L,24L,27L,31L,34L,37L,41L,43L,46L,50L,53L,56L,59L,63L,65L,68L,72L,75L,78L,82L,84L,87L,91L,94L,97L,101L,104L,106L,109L,113L,116L,119L,123L,126L,128L,132L,135L,138L,142L,145L,147L,151L,154L,157L,160L,164L,167L,169L,173L,176L,179L,183L,186L,189L,192L,195L,198L,202L,205L,208L,211L,214L,217L,220L,224L,227L,230L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190000Inst : IEnumerable<long>
{
public static readonly long[] Value=A190000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190000.Bytes);
public long this[int i]=>Value[i];

public static A190000Inst Instance=new A190000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190001
{
public static readonly long[] Value={ 1L,4L,6L,9L,11L,13L,16L,19L,20L,23L,26L,28L,30L,33L,35L,38L,40L,42L,45L,47L,49L,52L,54L,57L,60L,61L,64L,67L,69L,71L,74L,76L,79L,81L,83L,86L,88L,90L,93L,95L,98L,100L,102L,105L,108L,110L,112L,115L,117L,120L,122L,124L,127L,129L,131L,134L,136L,139L,141L,143L,146L,149L,150L,153L,156L,158L,161L,163L,165L,168L,171L,172L,175L,177L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190001Inst : IEnumerable<long>
{
public static readonly long[] Value=A190001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190001.Bytes);
public long this[int i]=>Value[i];

public static A190001Inst Instance=new A190001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190002
{
public static readonly long[] Value={ 4L,8L,14L,18L,22L,28L,32L,38L,42L,46L,52L,56L,60L,66L,70L,76L,80L,84L,90L,94L,100L,104L,108L,114L,118L,122L,128L,132L,138L,142L,146L,152L,156L,160L,166L,170L,176L,180L,184L,190L,194L,200L,204L,208L,214L,218L,222L,228L,232L,238L,242L,246L,252L,256L,260L,266L,270L,276L,280L,284L,290L,294L,300L,304L,308L,314L,318L,322L,328L,332L,338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190002Inst : IEnumerable<long>
{
public static readonly long[] Value=A190002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190002.Bytes);
public long this[int i]=>Value[i];

public static A190002Inst Instance=new A190002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190003
{
public static readonly long[] Value={ 2L,6L,10L,12L,16L,20L,24L,26L,30L,34L,36L,40L,44L,48L,50L,54L,58L,62L,64L,68L,72L,74L,78L,82L,86L,88L,92L,96L,98L,102L,106L,110L,112L,116L,120L,124L,126L,130L,134L,136L,140L,144L,148L,150L,154L,158L,162L,164L,168L,172L,174L,178L,182L,186L,188L,192L,196L,198L,202L,206L,210L,212L,216L,220L,224L,226L,230L,234L,236L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190003Inst : IEnumerable<long>
{
public static readonly long[] Value=A190003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190003.Bytes);
public long this[int i]=>Value[i];

public static A190003Inst Instance=new A190003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190004
{
public static readonly long[] Value={ 2L,4L,7L,9L,11L,14L,16L,19L,21L,23L,26L,28L,30L,33L,35L,38L,40L,42L,45L,47L,50L,52L,54L,57L,59L,61L,64L,66L,69L,71L,73L,76L,78L,80L,83L,85L,88L,90L,92L,95L,97L,100L,102L,104L,107L,109L,111L,114L,116L,119L,121L,123L,126L,128L,130L,133L,135L,138L,140L,142L,145L,147L,150L,152L,154L,157L,159L,161L,164L,166L,169L,171L,173L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190004Inst : IEnumerable<long>
{
public static readonly long[] Value=A190004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190004.Bytes);
public long this[int i]=>Value[i];

public static A190004Inst Instance=new A190004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190005
{
public static readonly long[] Value={ 0L,1L,6L,46L,336L,2476L,18216L,134056L,986496L,7259536L,53422176L,393128416L,2892992256L,21289237696L,156665348736L,1152884469376L,8483960303616L,62432606515456L,459435242128896L,3380937517927936L,24879977528856576L,183089240352418816L,1347335217403078656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190005Inst : IEnumerable<long>
{
public static readonly long[] Value=A190005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190005.Bytes);
public long this[int i]=>Value[i];

public static A190005Inst Instance=new A190005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190006
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,21L,23L,26L,29L,32L,35L,39L,42L,44L,47L,50L,53L,56L,60L,63L,66L,68L,71L,74L,78L,81L,84L,87L,89L,92L,95L,99L,102L,105L,108L,111L,113L,117L,120L,123L,126L,129L,132L,134L,138L,141L,144L,147L,150L,153L,157L,159L,162L,165L,168L,171L,174L,178L,180L,183L,186L,189L,192L,196L,199L,202L,204L,207L,210L,213L,217L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190006Inst : IEnumerable<long>
{
public static readonly long[] Value=A190006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190006.Bytes);
public long this[int i]=>Value[i];

public static A190006Inst Instance=new A190006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190007
{
public static readonly long[] Value={ 3L,6L,10L,13L,16L,20L,24L,27L,31L,34L,37L,41L,45L,48L,52L,55L,58L,62L,65L,69L,73L,76L,79L,83L,86L,90L,94L,97L,100L,104L,107L,110L,115L,118L,121L,125L,128L,131L,136L,139L,142L,146L,149L,152L,156L,160L,163L,167L,170L,173L,177L,181L,184L,188L,191L,194L,198L,201L,205L,209L,212L,215L,219L,222L,226L,230L,233L,236L,240L,243L,246L,251L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190007Inst : IEnumerable<long>
{
public static readonly long[] Value=A190007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190007.Bytes);
public long this[int i]=>Value[i];

public static A190007Inst Instance=new A190007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190008
{
public static readonly long[] Value={ 1L,4L,7L,10L,12L,15L,18L,20L,22L,25L,28L,31L,33L,36L,38L,41L,43L,46L,49L,52L,54L,57L,59L,62L,64L,67L,70L,73L,75L,77L,80L,83L,85L,88L,91L,94L,96L,98L,101L,104L,106L,109L,112L,115L,116L,119L,122L,125L,127L,130L,133L,136L,137L,140L,143L,146L,148L,151L,154L,156L,158L,161L,164L,167L,169L,172L,175L,177L,179L,182L,185L,188L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190008Inst : IEnumerable<long>
{
public static readonly long[] Value=A190008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190008.Bytes);
public long this[int i]=>Value[i];

public static A190008Inst Instance=new A190008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190009
{
public static readonly long[] Value={ 1L,1L,3L,9L,49L,237L,1739L,11557L,105313L,886201L,9596211L,97408641L,1218112465L,14446293669L,204461028347L,2769624924637L,43702453433281L,664858164527089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190009Inst : IEnumerable<long>
{
public static readonly long[] Value=A190009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190009.Bytes);
public long this[int i]=>Value[i];

public static A190009Inst Instance=new A190009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190010
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,73L,537L,3899L,35623L,345553L,3767185L,44993331L,575013087L,8040614041L,118459611753L,1883371991531L,31449522256183L,558550869727393L,10410156829764769L,204093418753532259L,4191381846930998319L,BigInteger.Parse("89889103856588434921") };
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
public class A190010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190010Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190010.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190010.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190010Inst Instance=new A190010Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190011
{
public static readonly long[] Value={ 4320L,6048L,9504L,9720L,11232L,12000L,13608L,14688L,16416L,19872L,21384L,25056L,25272L,26784L,28000L,31968L,32928L,33048L,35424L,36936L,37152L,40608L,44000L,44712L,45792L,50976L,52000L,52704L,54880L,56376L,57888L,60264L,60750L,61344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190011Inst : IEnumerable<long>
{
public static readonly long[] Value=A190011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190011.Bytes);
public long this[int i]=>Value[i];

public static A190011Inst Instance=new A190011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190076
{
public static readonly long[] Value={ 40L,1896L,28656L,191456L,834717L,2783714L,7737762L,18951546L,41786130L,84902980L,162378720L,292892946L,503182507L,835582280L,1339061119L,2077237619L,3144963614L,4653920446L,6746522401L,9597835033L,13398597773L,18439060711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190076Inst : IEnumerable<long>
{
public static readonly long[] Value=A190076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190076.Bytes);
public long this[int i]=>Value[i];

public static A190076Inst Instance=new A190076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190077
{
public static readonly long[] Value={ 0L,7584L,162028L,1436962L,7843113L,31391655L,101530262L,282859251L,698197690L,1570715217L,3291688243L,6460935664L,12000071771L,21412481203L,36702670681L,60642753250L,97406905547L,152416471950L,232926480058L,348492673798L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190077Inst : IEnumerable<long>
{
public static readonly long[] Value=A190077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190077.Bytes);
public long this[int i]=>Value[i];

public static A190077Inst Instance=new A190077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190078
{
public static readonly long[] Value={ 140L,27328L,910716L,10802667L,73725405L,353856100L,1333341624L,4232955454L,11720735320L,29213945353L,67119317038L,143366487211L,287901954546L,552087286271L,1012169804786L,1781377206624L,3036183971866L,5024176668242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190078Inst : IEnumerable<long>
{
public static readonly long[] Value=A190078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190078.Bytes);
public long this[int i]=>Value[i];

public static A190078Inst Instance=new A190078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190079
{
public static readonly long[] Value={ 2L,5L,8L,11L,15L,17L,20L,23L,27L,30L,32L,35L,39L,42L,45L,47L,51L,54L,57L,60L,62L,66L,69L,72L,75L,79L,81L,84L,87L,91L,94L,96L,99L,103L,106L,109L,111L,114L,118L,121L,124L,126L,130L,133L,136L,139L,143L,145L,148L,151L,155L,158L,160L,163L,166L,170L,173L,175L,178L,182L,185L,188L,190L,194L,197L,200L,203L,207L,209L,212L,215L,218L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190079Inst : IEnumerable<long>
{
public static readonly long[] Value=A190079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190079.Bytes);
public long this[int i]=>Value[i];

public static A190079Inst Instance=new A190079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190080
{
public static readonly long[] Value={ 3L,7L,10L,14L,18L,22L,25L,29L,33L,37L,40L,44L,48L,52L,55L,59L,63L,67L,71L,74L,78L,82L,86L,89L,93L,97L,101L,104L,108L,112L,116L,119L,123L,127L,131L,135L,138L,142L,146L,150L,153L,157L,161L,165L,168L,172L,176L,180L,183L,187L,191L,195L,198L,202L,206L,210L,214L,217L,221L,225L,229L,232L,236L,240L,244L,247L,251L,255L,259L,262L,266L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190080Inst : IEnumerable<long>
{
public static readonly long[] Value=A190080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190080.Bytes);
public long this[int i]=>Value[i];

public static A190080Inst Instance=new A190080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190081
{
public static readonly long[] Value={ 1L,4L,6L,9L,12L,13L,16L,19L,21L,24L,26L,28L,31L,34L,36L,38L,41L,43L,46L,49L,50L,53L,56L,58L,61L,64L,65L,68L,70L,73L,76L,77L,80L,83L,85L,88L,90L,92L,95L,98L,100L,102L,105L,107L,110L,113L,115L,117L,120L,122L,125L,128L,129L,132L,134L,137L,140L,141L,144L,147L,149L,152L,154L,156L,159L,162L,164L,167L,169L,171L,174L,177L,179L,181L,184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190081Inst : IEnumerable<long>
{
public static readonly long[] Value=A190081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190081.Bytes);
public long this[int i]=>Value[i];

public static A190081Inst Instance=new A190081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190082
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,20L,23L,26L,29L,32L,35L,38L,41L,44L,47L,50L,53L,56L,60L,62L,65L,68L,71L,74L,77L,80L,83L,86L,89L,92L,95L,98L,101L,104L,107L,110L,113L,117L,120L,122L,125L,128L,131L,134L,137L,140L,143L,146L,149L,152L,155L,158L,161L,164L,167L,170L,173L,177L,180L,183L,185L,188L,191L,194L,197L,200L,203L,206L,209L,212L,215L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190082Inst : IEnumerable<long>
{
public static readonly long[] Value=A190082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190082.Bytes);
public long this[int i]=>Value[i];

public static A190082Inst Instance=new A190082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190083
{
public static readonly long[] Value={ 3L,6L,9L,12L,15L,18L,21L,24L,27L,31L,34L,37L,40L,43L,46L,49L,52L,55L,59L,63L,66L,69L,72L,75L,78L,81L,84L,87L,91L,94L,97L,100L,103L,106L,109L,112L,115L,119L,123L,126L,129L,132L,135L,138L,141L,144L,147L,151L,154L,157L,160L,163L,166L,169L,172L,175L,179L,182L,186L,189L,192L,195L,198L,201L,204L,207L,211L,214L,217L,220L,223L,226L,229L,232L,235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190083Inst : IEnumerable<long>
{
public static readonly long[] Value=A190083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190083.Bytes);
public long this[int i]=>Value[i];

public static A190083Inst Instance=new A190083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190084
{
public static readonly long[] Value={ 1L,4L,7L,10L,13L,16L,19L,22L,25L,28L,30L,33L,36L,39L,42L,45L,48L,51L,54L,57L,58L,61L,64L,67L,70L,73L,76L,79L,82L,85L,88L,90L,93L,96L,99L,102L,105L,108L,111L,114L,116L,118L,121L,124L,127L,130L,133L,136L,139L,142L,145L,148L,150L,153L,156L,159L,162L,165L,168L,171L,174L,176L,178L,181L,184L,187L,190L,193L,196L,199L,202L,205L,208L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190084Inst : IEnumerable<long>
{
public static readonly long[] Value=A190084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190084.Bytes);
public long this[int i]=>Value[i];

public static A190084Inst Instance=new A190084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190085
{
public static readonly long[] Value={ 1L,3L,6L,8L,11L,13L,16L,18L,20L,22L,25L,27L,30L,32L,35L,37L,39L,41L,44L,46L,49L,51L,54L,56L,57L,60L,62L,65L,67L,70L,72L,75L,76L,79L,81L,84L,86L,89L,91L,94L,95L,98L,100L,103L,105L,108L,110L,113L,115L,116L,119L,121L,124L,126L,129L,131L,134L,135L,138L,140L,143L,145L,148L,150L,153L,154L,157L,159L,162L,164L,167L,169L,171L,173L,175L,178L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190085Inst : IEnumerable<long>
{
public static readonly long[] Value=A190085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190085.Bytes);
public long this[int i]=>Value[i];

public static A190085Inst Instance=new A190085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190086
{
public static readonly long[] Value={ 4L,9L,14L,19L,24L,28L,33L,38L,43L,48L,53L,58L,63L,68L,73L,78L,83L,87L,92L,97L,102L,107L,112L,117L,122L,127L,132L,137L,142L,146L,151L,156L,161L,166L,172L,176L,181L,186L,191L,196L,201L,205L,210L,215L,220L,225L,231L,235L,240L,245L,250L,255L,260L,264L,269L,274L,279L,284L,289L,294L,299L,304L,309L,314L,318L,323L,328L,333L,338L,344L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190086Inst : IEnumerable<long>
{
public static readonly long[] Value=A190086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190086.Bytes);
public long this[int i]=>Value[i];

public static A190086Inst Instance=new A190086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190087
{
public static readonly long[] Value={ 2L,5L,7L,10L,12L,15L,17L,21L,23L,26L,29L,31L,34L,36L,40L,42L,45L,47L,50L,52L,55L,59L,61L,64L,66L,69L,71L,74L,77L,80L,82L,85L,88L,90L,93L,96L,99L,101L,104L,106L,109L,111L,114L,118L,120L,123L,125L,128L,130L,133L,136L,139L,141L,144L,147L,149L,152L,155L,158L,160L,163L,165L,168L,170L,174L,177L,179L,182L,184L,187L,189L,193L,195L,198L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190087Inst : IEnumerable<long>
{
public static readonly long[] Value=A190087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190087.Bytes);
public long this[int i]=>Value[i];

public static A190087Inst Instance=new A190087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190088
{
public static readonly long[] Value={ 1L,1L,3L,1L,15L,5L,1L,36L,70L,7L,1L,66L,330L,210L,9L,1L,105L,1001L,1716L,495L,11L,1L,153L,2380L,8008L,6435L,1001L,13L,1L,210L,4845L,27132L,43758L,19448L,1820L,15L,1L,276L,8855L,74613L,203490L,184756L,50388L,3060L,17L,1L,351L,14950L,177100L,735471L,1144066L,646646L,116280L,4845L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190088Inst : IEnumerable<long>
{
public static readonly long[] Value=A190088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190088.Bytes);
public long this[int i]=>Value[i];

public static A190088Inst Instance=new A190088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190089
{
public static readonly long[] Value={ 1L,4L,21L,114L,616L,3329L,17991L,97229L,525456L,2839729L,15346786L,82938844L,448227521L,2422362079L,13091204281L,70748973084L,382349636061L,2066337330754L,11167134898976L,60350698792449L,326154101090951L,1762639037938629L,9525854090667496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190089Inst : IEnumerable<long>
{
public static readonly long[] Value=A190089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190089.Bytes);
public long this[int i]=>Value[i];

public static A190089Inst Instance=new A190089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190090
{
public static readonly long[] Value={ 1L,1L,4L,16L,42L,137L,443L,1365L,4316L,13625L,42785L,134758L,424331L,1335378L,4203927L,13233947L,41657808L,131135696L,412803240L,1299458257L,4090567673L,12876698159L,40534529294L,127598621869L,401667591501L,1264408966284L,3980231826575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190090Inst : IEnumerable<long>
{
public static readonly long[] Value=A190090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190090.Bytes);
public long this[int i]=>Value[i];

public static A190090Inst Instance=new A190090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190091
{
public static readonly long[] Value={ 2L,6L,10L,15L,20L,26L,32L,39L,46L,54L,62L,71L,80L,90L,100L,111L,122L,134L,146L,159L,172L,186L,200L,215L,230L,246L,262L,279L,296L,314L,332L,351L,370L,390L,410L,431L,452L,474L,496L,519L,542L,566L,590L,615L,640L,666L,692L,719L,746L,774L,802L,831L,860L,890L,920L,951L,982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190091Inst : IEnumerable<long>
{
public static readonly long[] Value=A190091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190091.Bytes);
public long this[int i]=>Value[i];

public static A190091Inst Instance=new A190091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190140
{
public static readonly long[] Value={ 1L,2L,5L,15L,41L,112L,310L,855L,2356L,6497L,17915L,49395L,136196L,375532L,1035445L,2855010L,7872061L,21705467L,59848025L,165017700L,454999826L,1254561427L,3459175780L,9537912465L,26298684991L,72512809787L,199938041960L,551284948680L,1520046368681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190140Inst : IEnumerable<long>
{
public static readonly long[] Value=A190140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190140.Bytes);
public long this[int i]=>Value[i];

public static A190140Inst Instance=new A190140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190141
{
public static readonly long[] Value={ 2L,4L,5L,8L,10L,18L,22L,34L,41L,63L,77L,111L,135L,190L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190141Inst : IEnumerable<long>
{
public static readonly long[] Value=A190141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190141.Bytes);
public long this[int i]=>Value[i];

public static A190141Inst Instance=new A190141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190142
{
public static readonly long[] Value={ 1L,2L,9L,1L,3L,4L,3L,1L,7L,2L,1L,0L,7L,2L,5L,9L,5L,4L,6L,1L,3L,8L,8L,2L,2L,9L,5L,6L,5L,3L,3L,4L,3L,8L,6L,9L,7L,0L,3L,2L,2L,0L,5L,0L,2L,2L,9L,6L,1L,8L,7L,4L,2L,4L,0L,3L,6L,5L,9L,8L,4L,8L,6L,7L,3L,9L,6L,4L,3L,9L,4L,9L,0L,6L,5L,2L,4L,1L,4L,9L,4L,0L,8L,9L,9L,7L,7L,9L,0L,3L,7L,0L,7L,9L,3L,4L,1L,3L,7L,3L,3L,8L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190142Inst : IEnumerable<long>
{
public static readonly long[] Value=A190142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190142.Bytes);
public long this[int i]=>Value[i];

public static A190142Inst Instance=new A190142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190143
{
public static readonly long[] Value={ 5L,4L,6L,6L,8L,0L,3L,2L,4L,4L,6L,6L,4L,2L,3L,3L,7L,1L,4L,6L,2L,1L,7L,2L,7L,2L,4L,7L,0L,9L,5L,0L,0L,2L,7L,2L,2L,6L,3L,0L,2L,5L,6L,8L,9L,8L,5L,2L,7L,9L,2L,1L,6L,6L,1L,4L,5L,4L,3L,4L,9L,8L,1L,2L,6L,4L,9L,0L,4L,2L,0L,4L,8L,4L,0L,8L,5L,9L,4L,9L,0L,0L,9L,7L,3L,2L,6L,7L,0L,6L,5L,1L,6L,0L,3L,7L,3L,0L,3L,0L,4L,0L,6L,8L,2L,1L,6L,0L,7L,7L,4L,4L,8L,4L,2L,9L,0L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190143Inst : IEnumerable<long>
{
public static readonly long[] Value=A190143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190143.Bytes);
public long this[int i]=>Value[i];

public static A190143Inst Instance=new A190143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190144
{
public static readonly long[] Value={ 2L,6L,0L,5L,0L,7L,2L,7L,0L,5L,2L,9L,7L,3L,2L,2L,8L,7L,0L,8L,0L,3L,4L,2L,6L,4L,1L,2L,4L,1L,8L,3L,8L,7L,8L,5L,1L,3L,7L,0L,8L,5L,7L,3L,6L,3L,2L,7L,6L,6L,3L,7L,2L,2L,4L,3L,8L,5L,8L,5L,0L,8L,4L,0L,7L,3L,1L,0L,5L,7L,5L,9L,3L,7L,1L,6L,1L,9L,7L,5L,1L,7L,0L,4L,7L,7L,4L,9L,9L,4L,5L,4L,7L,4L,8L,4L,5L,6L,1L,7L,0L,8L,8L,9L,4L,7L,7L,6L,2L,0L,9L,5L,9L,7L,8L,5L,2L,4L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190144Inst : IEnumerable<long>
{
public static readonly long[] Value=A190144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190144.Bytes);
public long this[int i]=>Value[i];

public static A190144Inst Instance=new A190144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190145
{
public static readonly long[] Value={ 1L,6L,6L,7L,4L,4L,7L,9L,3L,5L,8L,0L,3L,6L,9L,3L,9L,0L,5L,5L,8L,0L,5L,6L,7L,5L,1L,2L,8L,7L,3L,3L,9L,6L,0L,2L,0L,3L,9L,4L,4L,7L,8L,0L,1L,1L,3L,8L,1L,7L,7L,1L,6L,7L,0L,0L,5L,3L,7L,2L,8L,2L,2L,7L,6L,2L,0L,5L,8L,9L,3L,2L,9L,0L,2L,5L,2L,7L,7L,9L,1L,7L,0L,2L,4L,5L,2L,5L,4L,9L,9L,7L,7L,0L,8L,8L,1L,2L,2L,4L,8L,2L,4L,1L,6L,2L,6L,3L,3L,6L,8L,6L,1L,5L,1L,1L,1L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190145Inst : IEnumerable<long>
{
public static readonly long[] Value=A190145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190145.Bytes);
public long this[int i]=>Value[i];

public static A190145Inst Instance=new A190145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190146
{
public static readonly long[] Value={ 2L,3L,3L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190146Inst : IEnumerable<long>
{
public static readonly long[] Value=A190146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190146.Bytes);
public long this[int i]=>Value[i];

public static A190146Inst Instance=new A190146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190147
{
public static readonly long[] Value={ 1L,5L,0L,7L,8L,1L,0L,6L,6L,7L,6L,2L,2L,8L,9L,8L,2L,8L,3L,8L,3L,3L,1L,5L,3L,9L,0L,3L,7L,6L,5L,3L,7L,7L,7L,2L,7L,2L,4L,7L,3L,4L,6L,8L,8L,5L,1L,9L,3L,8L,9L,5L,5L,8L,5L,5L,3L,1L,9L,1L,3L,9L,0L,8L,6L,3L,0L,1L,2L,5L,3L,8L,1L,3L,3L,9L,5L,8L,9L,8L,9L,1L,1L,6L,7L,1L,4L,7L,5L,0L,5L,2L,5L,1L,0L,6L,3L,0L,6L,1L,3L,1L,7L,1L,2L,7L,1L,9L,4L,9L,9L,2L,2L,7L,3L,6L,6L,2L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190147Inst : IEnumerable<long>
{
public static readonly long[] Value=A190147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190147.Bytes);
public long this[int i]=>Value[i];

public static A190147Inst Instance=new A190147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190148
{
public static readonly long[] Value={ 5L,11L,23L,37L,53L,79L,101L,131L,167L,211L,271L,293L,349L,397L,457L,523L,601L,653L,727L,811L,887L,971L,1061L,1163L,1279L,1381L,1471L,1571L,1693L,1811L,1933L,2053L,2207L,2341L,2467L,2609L,2741L,2917L,3049L,3203L,3373L,3533L,3701L,3877L,4057L,4243L,4421L,4621L,4813L,5003L,5209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190148Inst : IEnumerable<long>
{
public static readonly long[] Value=A190148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190148.Bytes);
public long this[int i]=>Value[i];

public static A190148Inst Instance=new A190148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190149
{
public static readonly long[] Value={ 10010L,100010L,100110L,110010L,1000010L,1000100L,1000110L,1001010L,1001110L,1010010L,1100010L,1100110L,1110010L,10000010L,10000100L,10000110L,10001010L,10001100L,10001110L,10010010L,10010110L,10011010L,10011110L,10100010L,10100110L,10110010L,11000010L,11000100L,11000110L,11001010L,11001110L,11010010L,11100010L,11100110L,11110010L,100000010L,100000100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190149Inst : IEnumerable<long>
{
public static readonly long[] Value=A190149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190149.Bytes);
public long this[int i]=>Value[i];

public static A190149Inst Instance=new A190149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190150
{
public static readonly long[] Value={ 18L,34L,38L,50L,66L,68L,70L,74L,78L,82L,98L,102L,114L,130L,132L,134L,138L,140L,142L,146L,150L,154L,158L,162L,166L,178L,194L,196L,198L,202L,206L,210L,226L,230L,242L,258L,260L,262L,264L,266L,268L,270L,274L,276L,278L,282L,284L,286L,290L,294L,298L,302L,306L,310L,314L,318L,322L,324L,326L,330L,334L,338L,354L,358L,370L,386L,388L,390L,394L,396L,398L,402L,406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190150Inst : IEnumerable<long>
{
public static readonly long[] Value=A190150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190150.Bytes);
public long this[int i]=>Value[i];

public static A190150Inst Instance=new A190150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190151
{
public static readonly long[] Value={ 9L,17L,19L,25L,33L,34L,35L,37L,39L,41L,49L,51L,57L,65L,66L,67L,69L,70L,71L,73L,75L,77L,79L,81L,83L,89L,97L,98L,99L,101L,103L,105L,113L,115L,121L,129L,130L,131L,132L,133L,134L,135L,137L,138L,139L,141L,142L,143L,145L,147L,149L,151L,153L,155L,157L,159L,161L,162L,163L,165L,167L,169L,177L,179L,185L,193L,194L,195L,197L,198L,199L,201L,203L,205L,207L,209L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190151Inst : IEnumerable<long>
{
public static readonly long[] Value=A190151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190151.Bytes);
public long this[int i]=>Value[i];

public static A190151Inst Instance=new A190151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190152
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,1L,1L,28L,35L,1L,1L,55L,210L,84L,1L,1L,91L,715L,924L,165L,1L,1L,136L,1820L,5005L,3003L,286L,1L,1L,190L,3876L,18564L,24310L,8008L,455L,1L,1L,253L,7315L,54264L,125970L,92378L,18564L,680L,1L,1L,325L,12650L,134596L,490314L,646646L,293930L,38760L,969L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190152Inst : IEnumerable<long>
{
public static readonly long[] Value=A190152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190152.Bytes);
public long this[int i]=>Value[i];

public static A190152Inst Instance=new A190152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190153
{
public static readonly long[] Value={ 1L,2L,12L,65L,351L,1897L,10252L,55405L,299426L,1618192L,8745217L,47261895L,255418101L,1380359512L,7459895657L,40315615410L,217878227876L,1177482265857L,6363483400447L,34390259761825L,185855747875876L,1004422742303477L,5428215467030962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190153Inst : IEnumerable<long>
{
public static readonly long[] Value=A190153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190153.Bytes);
public long this[int i]=>Value[i];

public static A190153Inst Instance=new A190153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190154
{
public static readonly long[] Value={ 1L,1L,2L,11L,30L,91L,303L,936L,2936L,9300L,29209L,91917L,289547L,911218L,2868341L,9029949L,28424456L,89477119L,281667368L,886657081L,2791106585L,8786130132L,27657838272L,87064082194L,274068969337L,862741399379L,2715822822365L,8549136143060L,26911817257385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190154Inst : IEnumerable<long>
{
public static readonly long[] Value=A190154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190154.Bytes);
public long this[int i]=>Value[i];

public static A190154Inst Instance=new A190154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190155
{
public static readonly long[] Value={ 1L,2L,12L,64L,385L,2346L,14672L,92936L,595179L,3841970L,24959726L,162988464L,1068860884L,7034520304L,46437268905L,307351081056L,2038878634695L,13552394472612L,90242046694715L,601847594327000L,4019556724362165L,26879647264387170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190155Inst : IEnumerable<long>
{
public static readonly long[] Value=A190155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190155.Bytes);
public long this[int i]=>Value[i];

public static A190155Inst Instance=new A190155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190204
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190204Inst : IEnumerable<long>
{
public static readonly long[] Value=A190204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190204.Bytes);
public long this[int i]=>Value[i];

public static A190204Inst Instance=new A190204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190205
{
public static readonly long[] Value={ 1L,3L,5L,8L,9L,10L,15L,16L,18L,23L,25L,27L,29L,30L,32L,36L,37L,38L,43L,45L,47L,49L,50L,52L,54L,57L,58L,59L,64L,65L,67L,69L,72L,74L,76L,78L,79L,81L,85L,86L,87L,89L,92L,94L,96L,98L,99L,101L,103L,106L,107L,108L,113L,114L,116L,118L,121L,123L,125L,127L,128L,130L,134L,135L,136L,138L,141L,143L,145L,147L,148L,150L,152L,155L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190205Inst : IEnumerable<long>
{
public static readonly long[] Value=A190205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190205.Bytes);
public long this[int i]=>Value[i];

public static A190205Inst Instance=new A190205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190206
{
public static readonly long[] Value={ 2L,4L,6L,7L,11L,12L,13L,14L,17L,19L,20L,21L,22L,24L,26L,28L,31L,33L,34L,35L,39L,40L,41L,42L,44L,46L,48L,51L,53L,55L,56L,60L,61L,62L,63L,66L,68L,70L,71L,73L,75L,77L,80L,82L,83L,84L,88L,90L,91L,93L,95L,97L,100L,102L,104L,105L,109L,110L,111L,112L,115L,117L,119L,120L,122L,124L,126L,129L,131L,132L,133L,137L,139L,140L,142L,144L,146L,149L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190206Inst : IEnumerable<long>
{
public static readonly long[] Value=A190206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190206.Bytes);
public long this[int i]=>Value[i];

public static A190206Inst Instance=new A190206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190207
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190207Inst : IEnumerable<long>
{
public static readonly long[] Value=A190207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190207.Bytes);
public long this[int i]=>Value[i];

public static A190207Inst Instance=new A190207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190208
{
public static readonly long[] Value={ 8L,11L,14L,16L,19L,22L,24L,25L,27L,28L,30L,31L,32L,33L,35L,36L,38L,39L,40L,41L,42L,45L,53L,56L,59L,61L,62L,64L,67L,69L,70L,72L,73L,75L,76L,77L,78L,79L,80L,81L,83L,84L,90L,93L,98L,101L,104L,106L,107L,109L,110L,112L,114L,115L,117L,118L,120L,121L,122L,123L,124L,125L,126L,127L,135L,138L,141L,143L,146L,149L,151L,152L,154L,155L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190208Inst : IEnumerable<long>
{
public static readonly long[] Value=A190208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190208.Bytes);
public long this[int i]=>Value[i];

public static A190208Inst Instance=new A190208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190209
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,12L,13L,15L,17L,18L,20L,21L,23L,26L,29L,34L,37L,43L,44L,46L,47L,48L,49L,50L,51L,52L,54L,55L,57L,58L,60L,63L,65L,66L,68L,71L,74L,82L,85L,86L,87L,88L,89L,91L,92L,94L,95L,96L,97L,99L,100L,102L,103L,105L,108L,111L,113L,116L,119L,128L,129L,130L,131L,132L,133L,134L,136L,137L,139L,140L,142L,144L,145L,147L,148L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190209Inst : IEnumerable<long>
{
public static readonly long[] Value=A190209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190209.Bytes);
public long this[int i]=>Value[i];

public static A190209Inst Instance=new A190209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190210
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190210Inst : IEnumerable<long>
{
public static readonly long[] Value=A190210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190210.Bytes);
public long this[int i]=>Value[i];

public static A190210Inst Instance=new A190210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190211
{
public static readonly long[] Value={ 3L,4L,5L,9L,10L,15L,16L,17L,20L,21L,23L,26L,27L,29L,32L,34L,37L,38L,40L,43L,46L,49L,51L,52L,54L,57L,58L,60L,63L,64L,68L,69L,71L,74L,75L,80L,81L,85L,86L,87L,91L,92L,93L,97L,98L,99L,102L,103L,104L,108L,109L,114L,115L,116L,119L,120L,122L,125L,126L,128L,131L,133L,134L,136L,137L,139L,142L,145L,148L,150L,151L,153L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190211Inst : IEnumerable<long>
{
public static readonly long[] Value=A190211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190211.Bytes);
public long this[int i]=>Value[i];

public static A190211Inst Instance=new A190211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190212
{
public static readonly long[] Value={ 1L,2L,6L,7L,8L,11L,12L,13L,14L,18L,19L,22L,24L,25L,28L,30L,31L,33L,35L,36L,39L,41L,42L,44L,45L,47L,48L,50L,53L,55L,56L,59L,61L,62L,65L,66L,67L,70L,72L,73L,76L,77L,78L,79L,82L,83L,84L,88L,89L,90L,94L,95L,96L,100L,101L,105L,106L,107L,110L,111L,112L,113L,117L,118L,121L,123L,124L,127L,129L,130L,132L,135L,138L,140L,141L,143L,144L,146L,147L,149L,152L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190212Inst : IEnumerable<long>
{
public static readonly long[] Value=A190212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190212.Bytes);
public long this[int i]=>Value[i];

public static A190212Inst Instance=new A190212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190213
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,13L,17L,19L,31L,61L,89L,107L,127L,521L,607L,1279L,2203L,2281L,3217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190213Inst : IEnumerable<long>
{
public static readonly long[] Value=A190213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190213.Bytes);
public long this[int i]=>Value[i];

public static A190213Inst Instance=new A190213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190214
{
public static readonly long[] Value={ 1L,1L,4L,13L,41L,127L,395L,1232L,3842L,11977L,37336L,116392L,362846L,1131150L,3526285L,10992961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190214Inst : IEnumerable<long>
{
public static readonly long[] Value=A190214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190214.Bytes);
public long this[int i]=>Value[i];

public static A190214Inst Instance=new A190214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190215
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,5L,3L,1L,12L,14L,9L,4L,1L,29L,38L,28L,14L,5L,1L,70L,102L,84L,48L,20L,6L,1L,169L,271L,246L,157L,75L,27L,7L,1L,408L,714L,707L,496L,265L,110L,35L,8L,1L,985L,1868L,2001L,1526L,896L,417L,154L,44L,9L,1L,2378L,4858L,5592L,4596L,2930L,1500L,623L,208L,54L,10L,1L,5741L,12569L,15461L,13602L,9330L,5186L,2373L,894L,273L,65L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190215Inst : IEnumerable<long>
{
public static readonly long[] Value=A190215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190215.Bytes);
public long this[int i]=>Value[i];

public static A190215Inst Instance=new A190215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190216
{
public static readonly long[] Value={ 12L,80L,70L,21L,50L,40L,30L,20L,10L,171L,152L,133L,114L,207L,216L,132L,234L,243L,150L,224L,270L,408L,140L,112L,306L,315L,324L,204L,342L,351L,102L,644L,918L,111L,506L,405L,120L,423L,322L,441L,230L,715L,660L,605L,550L,312L,440L,513L,330L,531L,220L,0L,110L,640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190216Inst : IEnumerable<long>
{
public static readonly long[] Value=A190216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190216.Bytes);
public long this[int i]=>Value[i];

public static A190216Inst Instance=new A190216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190217
{
public static readonly ulong[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,33L,44L,55L,66L,77L,88L,99L,1111111111111111111L,2222222222222222222L,3333333333333333333L,4444444444444444444L,5555555555555555555L,6666666666666666666L,7777777777777777777L,8888888888888888888L,9999999999999999999UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190217Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A190217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190217.Bytes);
public ulong this[int i]=>Value[i];

public static A190217Inst Instance=new A190217Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190218
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,13L,14L,15L,16L,17L,18L,19L,23L,24L,25L,26L,27L,28L,29L,34L,35L,36L,37L,38L,39L,45L,46L,47L,48L,49L,56L,57L,58L,59L,67L,68L,69L,78L,79L,89L,125L,127L,134L,135L,136L,137L,138L,139L,145L,149L,157L,158L,167L,169L,178L,179L,235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190218Inst : IEnumerable<long>
{
public static readonly long[] Value=A190218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190218.Bytes);
public long this[int i]=>Value[i];

public static A190218Inst Instance=new A190218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190219
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,20L,21L,31L,40L,41L,43L,53L,61L,62L,63L,71L,73L,82L,83L,86L,93L,97L,421L,431L,521L,541L,631L,641L,643L,653L,743L,751L,761L,821L,842L,853L,862L,863L,941L,953L,961L,971L,983L,5431L,6421L,6521L,7321L,7541L,7621L,7643L,8431L,8521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190219Inst : IEnumerable<long>
{
public static readonly long[] Value=A190219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190219.Bytes);
public long this[int i]=>Value[i];

public static A190219Inst Instance=new A190219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190284
{
public static readonly long[] Value={ 2L,1L,1L,4L,6L,1L,2L,2L,2L,1L,1L,6L,1L,179L,46L,1L,1L,3L,2L,1L,1L,3L,6L,3L,1L,1L,1L,1L,2L,1L,1L,56L,1L,1L,1L,1L,66L,1L,1L,2L,17L,8L,2L,7L,12L,1L,1L,8L,1L,2L,2L,1L,1L,2L,1L,12L,1L,2L,2L,2L,2L,1L,1L,1L,8L,1L,1L,1L,1L,2L,1L,2L,5L,1L,6L,8L,1L,1L,1L,2L,7L,1L,9L,1L,2L,5L,7L,1L,6L,1L,10L,1L,2L,1L,3L,47L,1L,1L,998L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190284Inst : IEnumerable<long>
{
public static readonly long[] Value=A190284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190284.Bytes);
public long this[int i]=>Value[i];

public static A190284Inst Instance=new A190284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190285
{
public static readonly long[] Value={ 3L,4L,9L,5L,5L,0L,7L,6L,5L,6L,6L,0L,4L,9L,2L,4L,5L,0L,3L,7L,7L,2L,8L,6L,6L,6L,7L,9L,0L,5L,4L,4L,8L,1L,0L,0L,5L,1L,8L,8L,6L,1L,0L,8L,8L,4L,0L,4L,7L,7L,3L,2L,4L,5L,3L,1L,4L,2L,1L,1L,4L,5L,0L,6L,9L,7L,2L,1L,5L,2L,8L,1L,4L,6L,2L,1L,9L,5L,7L,6L,9L,3L,6L,8L,9L,3L,0L,5L,8L,5L,3L,9L,9L,3L,9L,4L,4L,9L,0L,9L,1L,2L,9L,6L,6L,7L,2L,8L,9L,9L,6L,0L,0L,8L,6L,3L,6L,9L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190285Inst : IEnumerable<long>
{
public static readonly long[] Value=A190285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190285.Bytes);
public long this[int i]=>Value[i];

public static A190285Inst Instance=new A190285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190286
{
public static readonly long[] Value={ 3L,2L,55L,6L,1L,1L,1L,9L,1L,1L,1L,7L,2L,2L,1L,4L,2L,6L,1L,27L,1L,10L,5L,1L,1L,2L,2L,3L,6L,6L,1L,9L,1L,1L,5L,1L,2L,3L,94L,1L,13L,18L,7L,1L,1L,1L,4L,1L,20L,1L,2L,7L,11L,1L,26251L,1L,43L,1L,1L,5L,1L,1L,1L,1L,5L,1L,47L,1L,1L,2L,12L,6L,3L,4L,6L,7L,5L,1L,1L,1L,1L,1L,4L,6L,23L,3L,2L,1L,1L,2L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190286Inst : IEnumerable<long>
{
public static readonly long[] Value=A190286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190286.Bytes);
public long this[int i]=>Value[i];

public static A190286Inst Instance=new A190286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190287
{
public static readonly long[] Value={ 5L,4L,1L,3L,0L,8L,5L,6L,4L,5L,4L,1L,1L,0L,2L,8L,7L,1L,0L,2L,8L,7L,0L,6L,5L,5L,6L,7L,5L,5L,7L,4L,9L,4L,1L,3L,5L,3L,1L,5L,9L,3L,2L,7L,3L,6L,5L,0L,4L,1L,2L,5L,8L,4L,1L,5L,5L,0L,5L,1L,3L,3L,7L,5L,9L,2L,2L,6L,7L,7L,4L,4L,9L,2L,3L,3L,0L,9L,7L,1L,9L,2L,2L,5L,1L,8L,4L,8L,8L,1L,5L,1L,0L,0L,2L,8L,8L,0L,8L,8L,7L,4L,0L,9L,0L,0L,2L,2L,3L,2L,0L,9L,6L,8L,1L,4L,0L,4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190287Inst : IEnumerable<long>
{
public static readonly long[] Value=A190287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190287.Bytes);
public long this[int i]=>Value[i];

public static A190287Inst Instance=new A190287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190288
{
public static readonly long[] Value={ 5L,2L,2L,2L,1L,1L,1L,10L,1L,1L,2L,1L,2L,1L,7L,1L,1L,1L,3L,1L,3L,1L,1L,2L,11L,22L,1L,1L,3L,3L,7L,1L,1L,1L,5L,1L,181L,1L,2L,2L,1L,2L,3L,17L,83L,1L,3L,2L,1L,14L,3L,1L,44L,3L,6L,4L,4L,1L,28L,1L,1L,1L,2L,1L,2L,1L,15L,1L,55L,1L,1L,3L,16L,3L,2L,1L,1L,1L,2L,1L,1L,2L,8L,4L,1L,1L,1L,1L,1L,1L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190288Inst : IEnumerable<long>
{
public static readonly long[] Value=A190288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190288.Bytes);
public long this[int i]=>Value[i];

public static A190288Inst Instance=new A190288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190289
{
public static readonly long[] Value={ 1L,8L,9L,5L,6L,4L,3L,9L,2L,3L,7L,3L,8L,9L,6L,0L,0L,0L,1L,6L,4L,7L,0L,1L,1L,7L,9L,8L,4L,3L,2L,0L,0L,2L,1L,2L,2L,2L,4L,6L,1L,1L,4L,1L,4L,4L,1L,9L,1L,9L,9L,2L,9L,7L,5L,6L,5L,1L,8L,1L,0L,5L,3L,0L,9L,7L,6L,7L,1L,7L,1L,0L,6L,3L,8L,6L,9L,4L,2L,7L,2L,1L,6L,5L,1L,0L,9L,0L,3L,8L,9L,8L,7L,3L,3L,6L,1L,2L,5L,8L,1L,6L,9L,4L,0L,0L,2L,2L,6L,3L,4L,9L,3L,9L,6L,4L,3L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190289Inst : IEnumerable<long>
{
public static readonly long[] Value=A190289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190289.Bytes);
public long this[int i]=>Value[i];

public static A190289Inst Instance=new A190289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190290
{
public static readonly long[] Value={ 2L,5L,2L,7L,5L,2L,5L,2L,3L,1L,6L,5L,1L,9L,4L,6L,6L,6L,8L,8L,6L,2L,6L,8L,2L,3L,9L,7L,9L,0L,9L,3L,3L,6L,1L,6L,2L,9L,9L,4L,8L,1L,8L,8L,5L,8L,9L,2L,2L,6L,5L,7L,3L,0L,0L,8L,6L,9L,0L,8L,0L,7L,0L,7L,9L,6L,8L,9L,5L,6L,1L,4L,1L,8L,4L,9L,2L,5L,6L,9L,6L,2L,2L,0L,1L,4L,5L,3L,8L,5L,3L,1L,6L,4L,4L,8L,1L,6L,7L,7L,5L,5L,9L,2L,0L,0L,3L,0L,1L,7L,9L,9L,1L,9L,5L,2L,4L,6L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190290Inst : IEnumerable<long>
{
public static readonly long[] Value=A190290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190290.Bytes);
public long this[int i]=>Value[i];

public static A190290Inst Instance=new A190290Inst();

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