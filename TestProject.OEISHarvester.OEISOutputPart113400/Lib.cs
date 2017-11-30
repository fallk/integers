using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A242745
{
public static readonly long[] Value={ 2L,1L,2L,2L,3L,3L,4L,4L,3L,4L,5L,4L,5L,6L,5L,4L,5L,6L,7L,5L,6L,6L,7L,6L,5L,6L,7L,4L,5L,6L,7L,8L,9L,10L,5L,6L,7L,8L,9L,8L,9L,6L,7L,8L,5L,6L,7L,8L,7L,8L,6L,7L,8L,6L,7L,8L,9L,10L,11L,10L,11L,12L,7L,8L,5L,6L,7L,8L,9L,7L,8L,8L,9L,10L,11L,12L,7L,6L,7L,8L,9L,10L,11L,12L,10L,6L,7L,8L,9L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242745Inst : IEnumerable<long>
{
public static readonly long[] Value=A242745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242745.Bytes);
public long this[int i]=>Value[i];

public static A242745Inst Instance=new A242745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242746
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,1L,5L,3L,6L,1L,7L,1L,7L,6L,5L,1L,7L,1L,5L,4L,7L,1L,7L,6L,4L,9L,8L,1L,7L,1L,9L,8L,7L,6L,5L,1L,8L,7L,6L,1L,7L,1L,11L,10L,9L,1L,9L,8L,7L,10L,9L,1L,7L,6L,5L,7L,13L,1L,11L,1L,9L,8L,7L,8L,7L,1L,13L,12L,11L,1L,9L,1L,7L,6L,8L,8L,7L,1L,11L,10L,9L,1L,7L,6L,11L,10L,9L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242746Inst : IEnumerable<long>
{
public static readonly long[] Value=A242746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242746.Bytes);
public long this[int i]=>Value[i];

public static A242746Inst Instance=new A242746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242747
{
public static readonly BigInteger[] Value={ 2L,8L,25L,2874L,12337L,125124L,40312L,362871L,119710813081L,226288998L,479001588L,379491816246L,2857509238543899L,284854629849752642L,20922789887984L,BigInteger.Parse("158339857954376933898893600"),BigInteger.Parse("7802547932734125256832521"),BigInteger.Parse("1785042244078013092809522"),2432902008176639980L };
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
public class A242747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242747.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242747Inst Instance=new A242747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242748
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,3L,3L,3L,1L,3L,3L,2L,2L,3L,3L,2L,1L,2L,3L,3L,2L,3L,3L,3L,3L,1L,2L,3L,3L,3L,2L,1L,4L,2L,3L,3L,3L,3L,2L,5L,3L,4L,2L,4L,6L,6L,1L,5L,4L,6L,7L,4L,6L,4L,6L,3L,6L,3L,7L,5L,5L,6L,7L,4L,6L,8L,5L,6L,4L,6L,4L,8L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242748Inst : IEnumerable<long>
{
public static readonly long[] Value=A242748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242748.Bytes);
public long this[int i]=>Value[i];

public static A242748Inst Instance=new A242748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242749
{
public static readonly BigInteger[] Value={ 1L,4L,11L,60L,611L,8632L,151538L,3132140L,73883667L,1949844168L,56785116742L,1806695366616L,62314198956510L,2315470815127792L,92214156916779444L,3918743752606940812L,BigInteger.Parse("177018691811732542595"),BigInteger.Parse("8471087431826716955880"),BigInteger.Parse("428141645771934036086942"),BigInteger.Parse("22791557465710675500959688") };
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
public class A242749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242749.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242749Inst Instance=new A242749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242750
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,10L,11L,13L,15L,18L,24L,26L,28L,33L,39L,41L,44L,45L,48L,50L,54L,55L,56L,58L,62L,65L,68L,69L,71L,75L,79L,83L,85L,93L,95L,107L,108L,109L,110L,117L,118L,119L,120L,123L,126L,129L,130L,131L,133L,139L,142L,143L,145L,148L,157L,158L,160L,163L,164L,166L,170L,172L,173L,174L,179L,182L,186L,190L,191L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242750Inst : IEnumerable<long>
{
public static readonly long[] Value=A242750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242750.Bytes);
public long this[int i]=>Value[i];

public static A242750Inst Instance=new A242750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242751
{
public static readonly long[] Value={ 4L,6L,9L,46L,49L,69L,86L,94L,446L,466L,469L,489L,649L,669L,689L,694L,698L,699L,849L,866L,869L,886L,889L,898L,899L,949L,989L,998L,4006L,4009L,4069L,4406L,4449L,4469L,4486L,4489L,4499L,4609L,4666L,4694L,4699L,4846L,4849L,4894L,4946L,4989L,6009L,6046L,6049L,6098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242751Inst : IEnumerable<long>
{
public static readonly long[] Value=A242751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242751.Bytes);
public long this[int i]=>Value[i];

public static A242751Inst Instance=new A242751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242816
{
public static readonly long[] Value={ 1L,0L,7L,8L,6L,4L,7L,0L,1L,2L,0L,1L,6L,9L,2L,5L,5L,5L,8L,6L,4L,2L,6L,8L,4L,4L,8L,0L,0L,2L,7L,4L,1L,5L,0L,6L,1L,1L,5L,0L,3L,3L,1L,9L,9L,8L,7L,2L,3L,5L,3L,8L,3L,1L,1L,3L,2L,8L,1L,7L,8L,6L,8L,1L,8L,2L,4L,4L,0L,9L,1L,2L,7L,8L,9L,4L,4L,4L,5L,5L,9L,0L,8L,7L,4L,8L,0L,4L,8L,0L,7L,1L,6L,3L,2L,3L,1L,9L,0L,0L,7L,1L,0L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242816Inst : IEnumerable<long>
{
public static readonly long[] Value=A242816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242816.Bytes);
public long this[int i]=>Value[i];

public static A242816Inst Instance=new A242816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242817
{
public static readonly BigInteger[] Value={ 1L,1L,6L,57L,756L,12880L,268098L,6593839L,187104200L,6016681467L,216229931110L,8588688990640L,373625770888956L,17666550789597073L,902162954264563306L,BigInteger.Parse("49482106424507339565"),BigInteger.Parse("2901159958960121863952"),BigInteger.Parse("181069240855214001514460"),BigInteger.Parse("11985869691525854175222222") };
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
public class A242817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242817Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242817.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242817.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242817Inst Instance=new A242817Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242818
{
public static readonly long[] Value={ 1L,1L,3L,5L,19L,39L,173L,407L,2025L,5281L,28787L,81597L,479851L,1459015L,9156093L,29582303L,196506001L,669822849L,4680247715L,16737058997L,122398824579L,457140004519L,3484655325197L,13541735424615L,107230543328761L,432232193519521L,3545227970258067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242818Inst : IEnumerable<long>
{
public static readonly long[] Value=A242818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242818.Bytes);
public long this[int i]=>Value[i];

public static A242818Inst Instance=new A242818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242819
{
public static readonly long[] Value={ 1L,1L,2L,6L,21L,3L,90L,30L,450L,270L,2619L,2322L,99L,17334L,20772L,2214L,129114L,195372L,38394L,1067661L,1958337L,591543L,11259L,9713682L,20933154L,8826246L,443718L,96393726L,238789782L,131367258L,12450834L,1036348587L,2900868876L,1989555210L,297195804L,3052323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242819Inst : IEnumerable<long>
{
public static readonly long[] Value=A242819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242819.Bytes);
public long this[int i]=>Value[i];

public static A242819Inst Instance=new A242819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242820
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,116L,4L,672L,48L,4536L,504L,34944L,5376L,302896L,59488L,496L,2916992L,697856L,13952L,30899616L,8720448L,296736L,357080064L,116109312L,5812224L,4470310976L,1645662912L,110697408L,349504L,60269056512L,24776769024L,2114735616L,17730048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242820Inst : IEnumerable<long>
{
public static readonly long[] Value=A242820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242820.Bytes);
public long this[int i]=>Value[i];

public static A242820Inst Instance=new A242820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242821
{
public static readonly long[] Value={ 1L,0L,0L,2L,3L,11L,14L,33L,43L,82L,141L,260L,514L,1049L,2321L,4789L,10454L,21735L,46213L,94782L,196060L,398662L,810178L,1631089L,3278372L,6556096L,13088339L,26063238L,51824061L,102926784L,204239173L,405087125L,803109813L,1592179369L,3156298826L,6258390137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242821Inst : IEnumerable<long>
{
public static readonly long[] Value=A242821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242821.Bytes);
public long this[int i]=>Value[i];

public static A242821Inst Instance=new A242821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242822
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,8L,5L,2L,5L,1L,9L,9L,9L,4L,0L,6L,5L,9L,5L,1L,8L,2L,0L,0L,7L,5L,5L,5L,4L,4L,1L,1L,0L,7L,7L,9L,4L,7L,1L,5L,2L,5L,1L,6L,2L,5L,5L,6L,8L,9L,6L,8L,8L,2L,0L,8L,1L,9L,4L,2L,6L,2L,2L,8L,1L,2L,7L,0L,0L,8L,1L,0L,7L,3L,4L,2L,9L,5L,8L,3L,5L,2L,1L,0L,8L,2L,2L,9L,6L,3L,7L,7L,5L,4L,4L,7L,9L,8L,4L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242822Inst : IEnumerable<long>
{
public static readonly long[] Value=A242822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242822.Bytes);
public long this[int i]=>Value[i];

public static A242822Inst Instance=new A242822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242823
{
public static readonly long[] Value={ 1L,2L,5L,15L,39L,103L,269L,700L,1821L,4736L,12313L,32016L,83242L,216429L,562716L,1463063L,3803966L,9890311L,25714810L,66858508L,173832121L,451963515L,1175105140L,3055273364L,7943710747L,20653647942L,53699484649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242823Inst : IEnumerable<long>
{
public static readonly long[] Value=A242823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242823.Bytes);
public long this[int i]=>Value[i];

public static A242823Inst Instance=new A242823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242824
{
public static readonly BigInteger[] Value={ 1428571L,BigInteger.Parse("1428571428571428571428571") };
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
public class A242824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242824Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242824.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242824.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242824Inst Instance=new A242824Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242825
{
public static readonly long[] Value={ 6L,11L,10L,34L,27L,2L,44L,1L,55L,90L,54L,126L,16L,119L,21L,88L,8L,19L,141L,54L,56L,71L,106L,64L,69L,27L,72L,55L,135L,47L,168L,161L,137L,79L,64L,309L,123L,332L,307L,8L,254L,83L,448L,109L,27L,519L,567L,2L,259L,107L,225L,269L,216L,118L,90L,316L,164L,503L,1015L,333L,181L,47L,857L,6L,704L,63L,385L,253L,343L,604L,457L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242825Inst : IEnumerable<long>
{
public static readonly long[] Value=A242825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242825.Bytes);
public long this[int i]=>Value[i];

public static A242825Inst Instance=new A242825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242826
{
public static readonly BigInteger[] Value={ 7L,769L,769230769L,BigInteger.Parse("769230769230769230769"),BigInteger.Parse("769230769230769230769230769230769") };
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
public class A242826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242826Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242826.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242826.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242826Inst Instance=new A242826Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242827
{
public static readonly BigInteger[] Value={ 7L,71L,71428571L,7142857142857L,BigInteger.Parse("7142857142857142857142857142857") };
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
public class A242827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242827Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242827.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242827.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242827Inst Instance=new A242827Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242828
{
public static readonly BigInteger[] Value={ 5L,5882352941L,588235294117L,BigInteger.Parse("588235294117647058823529411764705882352941176470588235294117") };
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
public class A242828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242828Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242828.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242828.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242828Inst Instance=new A242828Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242829
{
public static readonly long[] Value={ 6639266409L,8628052209L,12692281897L,14492398389L,15798643881L,18883291565L,20404935965L,20825703713L,21342970293L,21597222381L,22221458853L,22567169229L,22578915665L,23000623161L,23198162685L,23247729109L,24163642653L,24802386189L,24894100941L,26297281109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242829Inst : IEnumerable<long>
{
public static readonly long[] Value=A242829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242829.Bytes);
public long this[int i]=>Value[i];

public static A242829Inst Instance=new A242829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242830
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,2L,2L,1L,0L,0L,1L,0L,2L,0L,0L,0L,1L,1L,0L,1L,1L,2L,1L,0L,2L,1L,0L,1L,0L,1L,1L,3L,0L,0L,1L,1L,1L,1L,0L,2L,0L,3L,0L,2L,2L,2L,2L,2L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,2L,0L,0L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242830Inst : IEnumerable<long>
{
public static readonly long[] Value=A242830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242830.Bytes);
public long this[int i]=>Value[i];

public static A242830Inst Instance=new A242830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242831
{
public static readonly long[] Value={ 10L,21L,136L,153L,351L,630L,780L,3403L,3570L,5671L,6441L,6670L,7503L,9870L,10011L,13366L,14535L,16653L,20301L,23220L,33153L,34716L,36046L,36315L,37950L,43660L,46360L,56616L,66430L,93096L,93961L,95703L,112101L,139656L,144453L,159895L,166753L,169653L,187578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242831Inst : IEnumerable<long>
{
public static readonly long[] Value=A242831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242831.Bytes);
public long this[int i]=>Value[i];

public static A242831Inst Instance=new A242831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242896
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,2L,0L,3L,3L,0L,2L,10L,0L,4L,12L,0L,2L,38L,0L,4L,56L,0L,3L,79L,0L,4L,152L,60L,0L,2L,251L,285L,0L,6L,284L,498L,0L,2L,594L,1438L,0L,4L,920L,2816L,0L,4L,1108L,5208L,0L,5L,2136L,11195L,0L,2L,3402L,24094L,0L,6L,4407L,38523L,0L,2L,8350L,85182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242896Inst : IEnumerable<long>
{
public static readonly long[] Value=A242896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242896.Bytes);
public long this[int i]=>Value[i];

public static A242896Inst Instance=new A242896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242897
{
public static readonly BigInteger[] Value={ 14L,42L,132L,4862L,35357670L,1767263190L,91482563640L,4861946401452L,212336130412243110L,BigInteger.Parse("2622127042276492108820"),BigInteger.Parse("10113918591637898134020"),BigInteger.Parse("39044429911904443959240"),BigInteger.Parse("116157871455782434250553845880"),BigInteger.Parse("6852456927844873497549658464312"),BigInteger.Parse("368479169875816659479009042713546950") };
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
public class A242897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242897.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242897Inst Instance=new A242897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242898
{
public static readonly long[] Value={ 5L,10L,13L,17L,20L,24L,28L,31L,34L,38L,43L,47L,52L,56L,61L,65L,70L,73L,78L,83L,87L,90L,93L,96L,100L,105L,110L,115L,120L,123L,128L,132L,136L,140L,143L,148L,153L,157L,160L,164L,169L,172L,175L,179L,184L,188L,192L,197L,202L,206L,209L,213L,217L,222L,225L,229L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242898Inst : IEnumerable<long>
{
public static readonly long[] Value=A242898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242898.Bytes);
public long this[int i]=>Value[i];

public static A242898Inst Instance=new A242898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242899
{
public static readonly long[] Value={ 2L,2L,3L,4L,3L,3L,3L,2L,3L,6L,8L,4L,11L,5L,3L,16L,7L,6L,5L,5L,3L,10L,5L,3L,4L,5L,3L,4L,11L,4L,7L,11L,3L,30L,5L,3L,7L,19L,3L,10L,7L,6L,7L,11L,5L,12L,14L,6L,7L,5L,3L,12L,13L,9L,5L,8L,6L,6L,11L,4L,4L,6L,3L,64L,5L,6L,10L,6L,3L,10L,6L,6L,5L,37L,3L,30L,7L,12L,7L,20L,3L,40L,19L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242899Inst : IEnumerable<long>
{
public static readonly long[] Value=A242899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242899.Bytes);
public long this[int i]=>Value[i];

public static A242899Inst Instance=new A242899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242900
{
public static readonly long[] Value={ 3L,10L,12L,38L,56L,79L,152L,251L,284L,594L,920L,1108L,2136L,3402L,4407L,8350L,12863L,17328L,33218L,52527L,70074L,133247L,214551L,294299L,547360L,883572L,1234509L,2284840L,3667144L,5219161L,9551081L,15386201L,22079741L,40061664L,64666975L,93985744L,168363731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242900Inst : IEnumerable<long>
{
public static readonly long[] Value=A242900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242900.Bytes);
public long this[int i]=>Value[i];

public static A242900Inst Instance=new A242900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242901
{
public static readonly long[] Value={ 1L,2L,6L,4L,10L,26L,46L,50L,36L,22L,110L,52L,88L,14L,140L,16L,34L,32L,76L,44L,168L,106L,146L,104L,100L,38L,522L,196L,64L,130L,3256L,224L,280L,94L,308L,526L,400L,266L,1026L,250L,386L,86L,298L,212L,438L,466L,674L,208L,1666L,200L,1236L,304L,424L,202L,550L,728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242901Inst : IEnumerable<long>
{
public static readonly long[] Value=A242901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242901.Bytes);
public long this[int i]=>Value[i];

public static A242901Inst Instance=new A242901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242902
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242902Inst : IEnumerable<long>
{
public static readonly long[] Value=A242902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242902.Bytes);
public long this[int i]=>Value[i];

public static A242902Inst Instance=new A242902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242903
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,8L,26L,89L,324L,1225L,4786L,19170L,78408L,326275L,1377772L,5891401L,25467509L,111144579L,489145720L,2168854885L,9681072845L,43473716527L,196286934526L,890640262188L,4059500301390L,18579693200838L,85360357637580L,393548515741979L,1820335724153452L,8445294476235727L,39291407672079211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242903Inst : IEnumerable<long>
{
public static readonly long[] Value=A242903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242903.Bytes);
public long this[int i]=>Value[i];

public static A242903Inst Instance=new A242903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242904
{
public static readonly long[] Value={ 2L,23L,223L,1223L,2213L,3221L,10223L,12203L,20123L,20231L,21023L,22013L,22031L,23021L,23201L,102023L,102203L,200231L,201203L,202031L,220013L,220301L,300221L,322001L,1002263L,1002623L,1060223L,1062203L,1202063L,1202603L,1600223L,2002361L,2002613L,2003621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242904Inst : IEnumerable<long>
{
public static readonly long[] Value=A242904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242904.Bytes);
public long this[int i]=>Value[i];

public static A242904Inst Instance=new A242904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242905
{
public static readonly long[] Value={ 3L,13L,31L,103L,1013L,1031L,1103L,1301L,3011L,10103L,10301L,11003L,13001L,30011L,100103L,103001L,1000133L,1000313L,1001303L,1003103L,1010033L,1013003L,1030031L,1031003L,1033001L,1100303L,1300031L,1330001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242905Inst : IEnumerable<long>
{
public static readonly long[] Value=A242905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242905.Bytes);
public long this[int i]=>Value[i];

public static A242905Inst Instance=new A242905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242906
{
public static readonly long[] Value={ 5L,53L,353L,3253L,5233L,5323L,13523L,15233L,23531L,31253L,32531L,33521L,52313L,53231L,102533L,105323L,123503L,125303L,130253L,130523L,150323L,203351L,203531L,205133L,210533L,231053L,231503L,235013L,251033L,253013L,253103L,302513L,305231L,320153L,320513L,321053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242906Inst : IEnumerable<long>
{
public static readonly long[] Value=A242906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242906.Bytes);
public long this[int i]=>Value[i];

public static A242906Inst Instance=new A242906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242907
{
public static readonly long[] Value={ 7L,17L,71L,107L,701L,1087L,8017L,10487L,10847L,14087L,18047L,48017L,70481L,70841L,78041L,78401L,80147L,80471L,81047L,84017L,84701L,87041L,100847L,104087L,184007L,400187L,400871L,401087L,407801L,408071L,408701L,410087L,410807L,418007L,470081L,478001L,480017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242907Inst : IEnumerable<long>
{
public static readonly long[] Value=A242907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242907.Bytes);
public long this[int i]=>Value[i];

public static A242907Inst Instance=new A242907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242908
{
public static readonly long[] Value={ 1L,5L,3L,1L,5L,4L,7L,0L,9L,6L,6L,8L,7L,4L,5L,7L,7L,7L,6L,6L,4L,0L,7L,7L,7L,8L,6L,5L,1L,3L,5L,8L,0L,2L,0L,6L,0L,2L,0L,1L,7L,8L,3L,3L,7L,6L,9L,0L,3L,6L,4L,8L,9L,9L,8L,8L,4L,5L,6L,2L,7L,8L,7L,1L,4L,2L,8L,8L,5L,1L,7L,5L,2L,7L,6L,9L,8L,6L,5L,6L,2L,0L,7L,8L,3L,8L,0L,2L,3L,7L,7L,6L,3L,8L,6L,3L,8L,5L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242908Inst : IEnumerable<long>
{
public static readonly long[] Value=A242908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242908.Bytes);
public long this[int i]=>Value[i];

public static A242908Inst Instance=new A242908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242909
{
public static readonly long[] Value={ 7L,4L,9L,3L,0L,6L,0L,0L,1L,2L,8L,8L,4L,4L,9L,0L,2L,3L,6L,0L,5L,8L,7L,1L,5L,1L,8L,6L,8L,5L,2L,6L,1L,5L,1L,1L,8L,3L,3L,3L,0L,1L,2L,2L,2L,0L,1L,6L,7L,2L,4L,9L,3L,0L,8L,9L,4L,3L,4L,1L,3L,8L,6L,5L,8L,6L,2L,9L,2L,2L,9L,8L,6L,4L,3L,8L,7L,3L,9L,7L,2L,6L,6L,5L,0L,2L,5L,6L,0L,2L,6L,3L,2L,8L,8L,3L,0L,7L,5L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242909Inst : IEnumerable<long>
{
public static readonly long[] Value=A242909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242909.Bytes);
public long this[int i]=>Value[i];

public static A242909Inst Instance=new A242909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242910
{
public static readonly long[] Value={ 1L,4L,3L,5L,9L,1L,2L,6L,3L,1L,6L,1L,1L,7L,7L,3L,1L,2L,4L,7L,7L,2L,2L,4L,7L,2L,4L,0L,2L,8L,9L,9L,6L,5L,4L,5L,0L,5L,9L,0L,9L,4L,3L,5L,6L,3L,2L,5L,6L,1L,1L,3L,1L,4L,6L,6L,8L,0L,0L,5L,8L,1L,9L,4L,7L,3L,5L,0L,3L,2L,5L,4L,8L,0L,4L,2L,8L,4L,7L,9L,0L,6L,1L,6L,2L,1L,3L,1L,8L,5L,4L,5L,7L,8L,0L,1L,7L,5L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242910Inst : IEnumerable<long>
{
public static readonly long[] Value=A242910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242910.Bytes);
public long this[int i]=>Value[i];

public static A242910Inst Instance=new A242910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242911
{
public static readonly long[] Value={ 1L,1L,2L,5L,3L,6L,14L,10L,5L,56L,6L,15L,153L,51L,8L,502L,9L,217L,1756L,25L,11L,7023L,264L,30L,24363L,1852L,14L,93629L,15L,6576L,352782L,40L,3827L,1377543L,18L,45L,5200379L,105812L,20L,20063228L,21L,352942L,77607976L,55L,23L,301906830L,5172L,185320L,1166803215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242911Inst : IEnumerable<long>
{
public static readonly long[] Value=A242911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242911.Bytes);
public long this[int i]=>Value[i];

public static A242911Inst Instance=new A242911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242960
{
public static readonly long[] Value={ 4L,5L,10L,20L,40L,80L,491531L,983062L,1966124L,2457655L,3932248L,4915310L,6389903L,9339089L,9830620L,12288275L,12779806L,18678178L,19169709L,19661240L,24576550L,25559612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242960Inst : IEnumerable<long>
{
public static readonly long[] Value=A242960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242960.Bytes);
public long this[int i]=>Value[i];

public static A242960Inst Instance=new A242960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242961
{
public static readonly long[] Value={ 3L,5L,19L,13L,43L,103L,67L,37L,137L,173L,61L,73L,163L,257L,281L,211L,353L,487L,401L,283L,1021L,157L,331L,1423L,193L,1009L,617L,641L,653L,677L,761L,523L,547L,277L,1489L,1811L,313L,977L,1669L,691L,1789L,1447L,4201L,1543L,787L,397L,421L,1783L,907L,457L,3727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242961Inst : IEnumerable<long>
{
public static readonly long[] Value=A242961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242961.Bytes);
public long this[int i]=>Value[i];

public static A242961Inst Instance=new A242961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242962
{
public static readonly long[] Value={ 0L,0L,0L,1L,6L,3L,8L,15L,13L,18L,12L,28L,14L,24L,24L,31L,18L,39L,20L,42L,32L,36L,24L,60L,31L,42L,40L,56L,30L,72L,32L,63L,48L,54L,48L,91L,38L,60L,56L,90L,42L,96L,44L,84L,78L,72L,48L,124L,57L,93L,72L,98L,54L,120L,72L,120L,80L,90L,60L,168L,62L,96L,104L,127L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242962Inst : IEnumerable<long>
{
public static readonly long[] Value=A242962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242962.Bytes);
public long this[int i]=>Value[i];

public static A242962Inst Instance=new A242962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242963
{
public static readonly long[] Value={ 5L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242963Inst : IEnumerable<long>
{
public static readonly long[] Value=A242963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242963.Bytes);
public long this[int i]=>Value[i];

public static A242963Inst Instance=new A242963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242964
{
public static readonly long[] Value={ 10L,20L,28L,30L,100L,200L,300L,302L,304L,306L,308L,511L,839L,864L,1000L,1100L,1500L,1600L,2000L,2100L,2438L,2500L,2600L,3000L,3002L,3004L,3006L,3008L,3100L,5099L,7046L,8020L,8073L,9082L,10000L,20000L,30000L,30002L,30004L,30006L,30008L,30604L,35000L,36000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242964Inst : IEnumerable<long>
{
public static readonly long[] Value=A242964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242964.Bytes);
public long this[int i]=>Value[i];

public static A242964Inst Instance=new A242964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242965
{
public static readonly long[] Value={ 3L,4L,5L,7L,8L,11L,16L,17L,19L,29L,43L,47L,61L,64L,71L,79L,89L,101L,107L,109L,151L,191L,197L,223L,251L,271L,317L,349L,359L,421L,439L,461L,521L,569L,601L,631L,659L,673L,691L,701L,719L,811L,821L,881L,911L,919L,947L,971L,991L,1009L,1024L,1051L,1091L,1109L,1153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242965Inst : IEnumerable<long>
{
public static readonly long[] Value=A242965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242965.Bytes);
public long this[int i]=>Value[i];

public static A242965Inst Instance=new A242965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242966
{
public static readonly BigInteger[] Value={ 4L,8L,16L,64L,1024L,4096L,65536L,262144L,4194304L,1073741824L,1152921504606846976L,BigInteger.Parse("1267650600228229401496703205376"),BigInteger.Parse("85070591730234615865843651857942052864"),BigInteger.Parse("93536104789177786765035829293842113257979682750464") };
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
public class A242966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242966Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242966.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242966.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242966Inst Instance=new A242966Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242967
{
public static readonly long[] Value={ 1L,7L,6L,4L,2L,9L,7L,3L,3L,1L,3L,0L,8L,0L,2L,4L,3L,0L,3L,4L,4L,2L,9L,4L,8L,0L,4L,7L,6L,1L,6L,7L,0L,3L,0L,2L,3L,6L,1L,7L,8L,1L,4L,8L,8L,2L,8L,0L,0L,6L,9L,6L,2L,5L,2L,0L,1L,0L,3L,1L,9L,9L,1L,3L,2L,5L,8L,1L,2L,3L,5L,1L,1L,5L,1L,9L,5L,4L,4L,7L,2L,0L,6L,0L,5L,4L,1L,0L,3L,6L,3L,6L,3L,2L,9L,3L,8L,1L,5L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242967Inst : IEnumerable<long>
{
public static readonly long[] Value=A242967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242967.Bytes);
public long this[int i]=>Value[i];

public static A242967Inst Instance=new A242967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242968
{
public static readonly long[] Value={ 8L,7L,9L,5L,8L,5L,3L,8L,6L,1L,6L,1L,5L,7L,1L,5L,1L,7L,0L,9L,3L,8L,9L,6L,0L,2L,8L,3L,0L,7L,9L,7L,2L,8L,4L,3L,0L,5L,6L,4L,8L,2L,0L,2L,9L,6L,7L,5L,9L,0L,7L,8L,0L,4L,4L,5L,3L,8L,3L,7L,5L,9L,7L,2L,3L,9L,8L,6L,1L,0L,1L,9L,6L,9L,8L,3L,6L,9L,7L,2L,1L,2L,9L,3L,9L,9L,6L,7L,4L,7L,5L,1L,8L,2L,0L,4L,8L,0L,1L,7L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242968Inst : IEnumerable<long>
{
public static readonly long[] Value=A242968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242968.Bytes);
public long this[int i]=>Value[i];

public static A242968Inst Instance=new A242968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242969
{
public static readonly long[] Value={ 1L,0L,2L,5L,0L,5L,9L,0L,9L,6L,4L,7L,1L,3L,1L,3L,2L,2L,0L,1L,7L,4L,4L,7L,3L,0L,0L,8L,3L,6L,4L,4L,7L,7L,7L,0L,2L,7L,8L,9L,9L,2L,5L,0L,0L,7L,6L,1L,1L,5L,4L,8L,7L,6L,0L,1L,5L,7L,5L,9L,9L,1L,7L,6L,1L,0L,7L,3L,3L,9L,2L,7L,5L,2L,9L,8L,5L,8L,6L,9L,0L,2L,1L,2L,6L,0L,7L,0L,1L,1L,3L,5L,6L,3L,3L,5L,6L,6L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242969Inst : IEnumerable<long>
{
public static readonly long[] Value=A242969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242969.Bytes);
public long this[int i]=>Value[i];

public static A242969Inst Instance=new A242969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242970
{
public static readonly long[] Value={ 4L,0L,7L,6L,5L,6L,1L,7L,8L,5L,2L,7L,6L,0L,4L,6L,1L,9L,8L,6L,0L,4L,0L,2L,2L,8L,5L,2L,8L,1L,5L,0L,2L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242970Inst : IEnumerable<long>
{
public static readonly long[] Value=A242970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242970.Bytes);
public long this[int i]=>Value[i];

public static A242970Inst Instance=new A242970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242971
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,4L,8L,5L,16L,6L,32L,7L,64L,8L,128L,9L,256L,10L,512L,11L,1024L,12L,2048L,13L,4096L,14L,8192L,15L,16384L,16L,32768L,17L,65536L,18L,131072L,19L,262144L,20L,524288L,21L,1048576L,22L,2097152L,23L,4194304L,24L,8388608L,25L,16777216L,26L,33554432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242971Inst : IEnumerable<long>
{
public static readonly long[] Value=A242971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242971.Bytes);
public long this[int i]=>Value[i];

public static A242971Inst Instance=new A242971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242972
{
public static readonly long[] Value={ 8L,9L,2L,8L,9L,4L,5L,7L,1L,4L,5L,1L,2L,6L,6L,0L,9L,0L,4L,5L,7L,0L,0L,9L,4L,3L,0L,0L,2L,2L,4L,2L,7L,0L,9L,3L,3L,6L,0L,5L,0L,4L,0L,8L,5L,9L,4L,4L,5L,6L,8L,4L,3L,2L,6L,4L,7L,4L,9L,5L,6L,7L,9L,0L,7L,4L,3L,7L,2L,7L,3L,4L,3L,8L,7L,2L,7L,6L,5L,6L,4L,9L,4L,9L,0L,6L,6L,9L,6L,8L,8L,7L,3L,6L,9L,4L,1L,7L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242972Inst : IEnumerable<long>
{
public static readonly long[] Value=A242972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242972.Bytes);
public long this[int i]=>Value[i];

public static A242972Inst Instance=new A242972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242973
{
public static readonly long[] Value={ 1L,5L,9L,16L,17L,18L,25L,29L,30L,34L,40L,54L,64L,65L,74L,77L,84L,90L,92L,94L,100L,103L,112L,115L,124L,132L,136L,137L,138L,143L,144L,159L,178L,179L,180L,195L,204L,211L,217L,236L,242L,253L,275L,283L,286L,293L,302L,303L,305L,307L,317L,321L,326L,334L,339L,344L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242973Inst : IEnumerable<long>
{
public static readonly long[] Value=A242973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242973.Bytes);
public long this[int i]=>Value[i];

public static A242973Inst Instance=new A242973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242974
{
public static readonly long[] Value={ 1L,1L,3L,25L,67L,131L,1556L,-1671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242974Inst : IEnumerable<long>
{
public static readonly long[] Value=A242974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242974.Bytes);
public long this[int i]=>Value[i];

public static A242974Inst Instance=new A242974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242975
{
public static readonly long[] Value={ 17L,18L,34L,40L,100L,143L,275L,326L,334L,365L,412L,420L,453L,501L,504L,507L,610L,622L,642L,743L,825L,840L,841L,864L,866L,875L,878L,898L,920L,926L,941L,948L,956L,963L,1009L,1054L,1059L,1078L,1147L,1158L,1180L,1203L,1283L,1292L,1306L,1338L,1355L,1362L,1407L,1469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242975Inst : IEnumerable<long>
{
public static readonly long[] Value=A242975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242975.Bytes);
public long this[int i]=>Value[i];

public static A242975Inst Instance=new A242975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242976
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,2L,3L,4L,5L,5L,6L,6L,8L,8L,9L,8L,9L,7L,9L,9L,9L,8L,9L,8L,9L,9L,10L,9L,9L,8L,8L,9L,9L,9L,8L,9L,9L,11L,13L,12L,12L,13L,13L,13L,12L,14L,12L,11L,13L,10L,13L,11L,15L,12L,12L,13L,11L,12L,11L,9L,8L,7L,9L,11L,12L,15L,12L,16L,17L,15L,19L,15L,19L,12L,17L,15L,15L,17L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242976Inst : IEnumerable<long>
{
public static readonly long[] Value=A242976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242976.Bytes);
public long this[int i]=>Value[i];

public static A242976Inst Instance=new A242976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242977
{
public static readonly long[] Value={ 7L,6L,6L,9L,4L,4L,4L,9L,0L,5L,2L,1L,0L,8L,8L,2L,4L,1L,6L,5L,2L,4L,1L,7L,9L,2L,3L,0L,0L,3L,1L,7L,6L,9L,3L,0L,9L,7L,4L,7L,5L,7L,8L,8L,9L,9L,3L,1L,9L,0L,5L,1L,6L,9L,6L,5L,4L,1L,2L,2L,0L,8L,1L,6L,0L,7L,8L,9L,6L,8L,4L,2L,3L,7L,5L,6L,7L,9L,5L,7L,7L,5L,7L,8L,9L,3L,7L,4L,6L,2L,9L,8L,4L,0L,9L,9L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242977Inst : IEnumerable<long>
{
public static readonly long[] Value=A242977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242977.Bytes);
public long this[int i]=>Value[i];

public static A242977Inst Instance=new A242977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242978
{
public static readonly long[] Value={ 2L,2L,6L,9L,4L,3L,8L,2L,5L,9L,5L,3L,6L,6L,6L,9L,5L,1L,9L,2L,8L,6L,0L,2L,1L,7L,1L,3L,6L,9L,3L,3L,3L,7L,6L,5L,1L,0L,2L,9L,8L,9L,6L,8L,9L,0L,1L,3L,0L,3L,1L,9L,1L,3L,6L,4L,8L,2L,6L,0L,8L,9L,4L,1L,6L,4L,2L,7L,1L,7L,1L,2L,9L,5L,6L,9L,8L,3L,0L,4L,2L,9L,0L,4L,9L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242978Inst : IEnumerable<long>
{
public static readonly long[] Value=A242978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242978.Bytes);
public long this[int i]=>Value[i];

public static A242978Inst Instance=new A242978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242979
{
public static readonly long[] Value={ 19L,37L,211L,727L,2287L,4507L,4951L,5857L,6217L,6337L,7237L,8329L,8629L,8941L,9127L,9319L,9721L,11467L,12109L,13411L,13831L,15331L,15661L,17029L,17971L,17989L,19489L,21169L,23431L,24439L,24907L,25849L,26161L,31387L,33151L,34039L,34897L,36451L,37441L,37879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242979Inst : IEnumerable<long>
{
public static readonly long[] Value=A242979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242979.Bytes);
public long this[int i]=>Value[i];

public static A242979Inst Instance=new A242979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242980
{
public static readonly long[] Value={ 172081L,1773289L,4463641L,47006785L,295643089L,798770161L,1150270849L,1420379065L,1976295241L,18390744505L,122160500281L,134642101321L,215741809801L,228944441089L,263610459505L,321140603665L,374464040689L,444722065201L,676328168881L,1009514855521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242980Inst : IEnumerable<long>
{
public static readonly long[] Value=A242980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242980.Bytes);
public long this[int i]=>Value[i];

public static A242980Inst Instance=new A242980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267892
{
public static readonly long[] Value={ 225L,441L,450L,882L,900L,1089L,1225L,1521L,1764L,1800L,2178L,2450L,2601L,3025L,3042L,3249L,3528L,3600L,4225L,4356L,4761L,4900L,5202L,5929L,6050L,6084L,6498L,6561L,7056L,7200L,7225L,7569L,8281L,8450L,8649L,8712L,9025L,9522L,9800L,10404L,11858L,12100L,12168L,12321L,12996L,13122L,13225L,14112L,14161L,14400L,14450L,15129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267892Inst : IEnumerable<long>
{
public static readonly long[] Value=A267892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267892.Bytes);
public long this[int i]=>Value[i];

public static A267892Inst Instance=new A267892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267893
{
public static readonly long[] Value={ 405L,567L,810L,891L,1053L,1134L,1377L,1539L,1620L,1782L,1863L,1875L,2106L,2268L,2349L,2511L,2754L,2997L,3078L,3240L,3321L,3483L,3564L,3726L,3750L,3807L,4212L,4293L,4375L,4536L,4698L,4779L,4941L,5022L,5427L,5508L,5751L,5913L,5994L,6156L,6399L,6480L,6642L,6723L,6875L,6966L,7128L,7203L,7209L,7452L,7500L,7614L,7857L,8125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267893Inst : IEnumerable<long>
{
public static readonly long[] Value=A267893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267893.Bytes);
public long this[int i]=>Value[i];

public static A267893Inst Instance=new A267893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267894
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,16L,21L,27L,30L,32L,33L,35L,39L,42L,45L,51L,54L,55L,57L,60L,63L,64L,65L,66L,69L,70L,75L,77L,78L,84L,85L,87L,90L,91L,93L,95L,99L,102L,105L,108L,110L,111L,114L,115L,117L,119L,120L,123L,125L,126L,128L,129L,130L,132L,133L,135L,138L,140L,141L,143L,145L,147L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267894Inst : IEnumerable<long>
{
public static readonly long[] Value=A267894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267894.Bytes);
public long this[int i]=>Value[i];

public static A267894Inst Instance=new A267894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267895
{
public static readonly long[] Value={ 3L,5L,6L,7L,9L,10L,11L,12L,13L,14L,17L,18L,19L,20L,22L,23L,24L,25L,26L,28L,29L,31L,34L,36L,37L,38L,40L,41L,43L,44L,46L,47L,48L,49L,50L,52L,53L,56L,58L,59L,61L,62L,67L,68L,71L,72L,73L,74L,76L,79L,80L,81L,82L,83L,86L,88L,89L,92L,94L,96L,97L,98L,100L,101L,103L,104L,106L,107L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267895Inst : IEnumerable<long>
{
public static readonly long[] Value=A267895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267895.Bytes);
public long this[int i]=>Value[i];

public static A267895Inst Instance=new A267895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267896
{
public static readonly long[] Value={ 2L,3L,9L,6L,15L,9L,21L,39L,15L,51L,39L,21L,45L,75L,84L,30L,96L,69L,36L,114L,81L,129L,186L,99L,51L,105L,54L,111L,420L,129L,201L,69L,360L,75L,231L,240L,165L,255L,264L,90L,465L,96L,195L,99L,615L,651L,225L,114L,231L,354L,120L,615L,381L,390L,399L,135L,411L,279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267896Inst : IEnumerable<long>
{
public static readonly long[] Value=A267896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267896.Bytes);
public long this[int i]=>Value[i];

public static A267896Inst Instance=new A267896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267897
{
public static readonly BigInteger[] Value={ 0L,3L,115L,5033L,39916789L,6227020787L,355687428095983L,121645100408831981L,BigInteger.Parse("25852016738884976639977"),BigInteger.Parse("8841761993739701954543615999971"),BigInteger.Parse("8222838654177922817725562879999969"),BigInteger.Parse("13763753091226345046315979581580902399999963") };
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
public class A267897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A267897.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A267897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A267897Inst Instance=new A267897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267898
{
public static readonly BigInteger[] Value={ 4L,9L,125L,5047L,39916811L,6227020813L,355687428096017L,121645100408832019L,BigInteger.Parse("25852016738884976640023"),BigInteger.Parse("8841761993739701954543616000029"),BigInteger.Parse("8222838654177922817725562880000031"),BigInteger.Parse("13763753091226345046315979581580902400000037") };
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
public class A267898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267898Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A267898.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A267898.Bytes);
public BigInteger this[int i]=>Value[i];

public static A267898Inst Instance=new A267898Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267899
{
public static readonly long[] Value={ 1L,3L,20L,138L,1488L,20400L,317520L,5911920L,126080640L,2999566080L,79604985600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267899Inst : IEnumerable<long>
{
public static readonly long[] Value=A267899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267899.Bytes);
public long this[int i]=>Value[i];

public static A267899Inst Instance=new A267899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267900
{
public static readonly long[] Value={ 1L,11L,268L,17658L,1696920L,273460560L,59383337040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267900Inst : IEnumerable<long>
{
public static readonly long[] Value=A267900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267900.Bytes);
public long this[int i]=>Value[i];

public static A267900Inst Instance=new A267900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267901
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,1L,3L,6L,0L,1L,11L,20L,30L,0L,1L,29L,268L,138L,192L,0L,1L,93L,2324L,17658L,1488L,1560L,0L,1L,268L,28318L,414138L,1696920L,20400L,15120L,0L,1L,842L,315196L,28493946L,134764368L,273460560L,317520L,171360L,0L,1L,2547L,3786836L,1246334388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267901Inst : IEnumerable<long>
{
public static readonly long[] Value=A267901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267901.Bytes);
public long this[int i]=>Value[i];

public static A267901Inst Instance=new A267901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267902
{
public static readonly long[] Value={ 0L,2L,3L,11L,29L,93L,268L,842L,2547L,7946L,24539L,76721L,239462L,751569L,2360679L,7437243L,23461543L,74155431L,234687456L,743792675L,2359972537L,7496293462L,23834595755L,75852059135L,241594260984L,770090455545L,2456436981617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267902Inst : IEnumerable<long>
{
public static readonly long[] Value=A267902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267902.Bytes);
public long this[int i]=>Value[i];

public static A267902Inst Instance=new A267902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267903
{
public static readonly long[] Value={ 0L,6L,20L,268L,2324L,28318L,315196L,3786836L,45099306L,547824556L,6687936028L,82350672500L,1019550923830L,12691867518330L,158695413996448L,1992293553570646L,25099547132728742L,317210539882144928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267903Inst : IEnumerable<long>
{
public static readonly long[] Value=A267903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267903.Bytes);
public long this[int i]=>Value[i];

public static A267903Inst Instance=new A267903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267904
{
public static readonly long[] Value={ 0L,30L,138L,17658L,414138L,28493946L,1246334388L,72638390592L,3823498828854L,218021286182580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267904Inst : IEnumerable<long>
{
public static readonly long[] Value=A267904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267904.Bytes);
public long this[int i]=>Value[i];

public static A267904Inst Instance=new A267904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267905
{
public static readonly long[] Value={ 1L,2L,5L,13L,34L,88L,225L,569L,1426L,3548L,8777L,21613L,53026L,129712L,316545L,770993L,1874914L,4553588L,11047625L,26779909L,64869586L,157043368L,380004897L,919150313L,2222499826L,5372538572L,12984354185L,31374801373L,75801065794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267905Inst : IEnumerable<long>
{
public static readonly long[] Value=A267905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267905.Bytes);
public long this[int i]=>Value[i];

public static A267905Inst Instance=new A267905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267906
{
public static readonly long[] Value={ 2L,14L,122L,938L,6734L,45938L,302402L,1939154L,12192302L,75508538L,462161714L,2802600938L,16870221902L,100950439394L,601202522882L,3566576610338L,21091803794894L,124410954720938L,732300042558002L,4302980995610234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267906Inst : IEnumerable<long>
{
public static readonly long[] Value=A267906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267906.Bytes);
public long this[int i]=>Value[i];

public static A267906Inst Instance=new A267906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267907
{
public static readonly long[] Value={ 4L,96L,2304L,43972L,754852L,12017350L,181535822L,2638824216L,37263580006L,514648921140L,6985835894832L,93540620739538L,1238999184320608L,16269402566811754L,212148448282604414L,2750808905345217294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267907Inst : IEnumerable<long>
{
public static readonly long[] Value=A267907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267907.Bytes);
public long this[int i]=>Value[i];

public static A267907Inst Instance=new A267907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267956
{
public static readonly BigInteger[] Value={ 77L,35574L,8239879L,2290723921L,495859988413L,112089546220707L,22894037516177941L,4695745214339217593L,BigInteger.Parse("920576027967120137161") };
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
public class A267956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267956Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A267956.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A267956.Bytes);
public BigInteger this[int i]=>Value[i];

public static A267956Inst Instance=new A267956Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267957
{
public static readonly long[] Value={ 1L,2L,2L,4L,14L,4L,11L,96L,96L,11L,29L,726L,1625L,726L,29L,77L,5046L,30145L,30145L,5046L,77L,201L,35574L,493087L,1414023L,493087L,35574L,201L,525L,242406L,8239879L,56103165L,56103165L,8239879L,242406L,525L,1361L,1653750L,130870815L,2290723921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267957Inst : IEnumerable<long>
{
public static readonly long[] Value=A267957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267957.Bytes);
public long this[int i]=>Value[i];

public static A267957Inst Instance=new A267957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267958
{
public static readonly long[] Value={ 0L,4L,12L,16L,20L,28L,32L,36L,44L,48L,52L,60L,64L,68L,76L,80L,84L,92L,96L,100L,108L,112L,116L,124L,128L,132L,140L,144L,148L,156L,160L,164L,172L,176L,180L,188L,192L,196L,204L,208L,212L,220L,224L,228L,236L,240L,244L,252L,256L,260L,268L,272L,276L,284L,288L,292L,300L,304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267958Inst : IEnumerable<long>
{
public static readonly long[] Value=A267958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267958.Bytes);
public long this[int i]=>Value[i];

public static A267958Inst Instance=new A267958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267959
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267959Inst : IEnumerable<long>
{
public static readonly long[] Value=A267959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267959.Bytes);
public long this[int i]=>Value[i];

public static A267959Inst Instance=new A267959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267960
{
public static readonly long[] Value={ 3L,9L,24L,63L,159L,394L,957L,2292L,5419L,12678L,29385L,67560L,154215L,349770L,788741L,1769388L,3950499L,8782094L,19445313L,42898032L,94315743L,206709714L,451711869L,984397108L,2139750939L,4639901334L,10038505657L,21672089592L,46693408599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267960Inst : IEnumerable<long>
{
public static readonly long[] Value=A267960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267960.Bytes);
public long this[int i]=>Value[i];

public static A267960Inst Instance=new A267960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267961
{
public static readonly long[] Value={ 9L,81L,576L,3969L,25281L,155236L,915849L,5253264L,29365561L,160731684L,863478225L,4564353600L,23782266225L,122339052900L,622112365081L,3130733894544L,15606442349001L,77125175024836L,378120197667969L,1840241149473024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267961Inst : IEnumerable<long>
{
public static readonly long[] Value=A267961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267961.Bytes);
public long this[int i]=>Value[i];

public static A267961Inst Instance=new A267961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267962
{
public static readonly long[] Value={ 24L,576L,9750L,157182L,2253828L,30649446L,392792334L,4834114074L,57285557832L,658558589712L,7367813384346L,80528684687118L,861990117512832L,9057816965527086L,93605798560795056L,952894000040209068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267962Inst : IEnumerable<long>
{
public static readonly long[] Value=A267962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267962.Bytes);
public long this[int i]=>Value[i];

public static A267962Inst Instance=new A267962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267963
{
public static readonly BigInteger[] Value={ 63L,3969L,157182L,5843562L,185900905L,5520230601L,151596664089L,3948855568663L,97889332200024L,2332332672746881L,53631396879772976L,1196249503631460096L,BigInteger.Parse("25965520951599991001"),BigInteger.Parse("550166212967293315266"),BigInteger.Parse("11406213718800127365141") };
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
public class A267963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267963Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A267963.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A267963.Bytes);
public BigInteger this[int i]=>Value[i];

public static A267963Inst Instance=new A267963Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267964
{
public static readonly BigInteger[] Value={ 159L,25281L,2253828L,185900905L,12628574785L,788980366553L,44750006935212L,2380009487628460L,119102221790408950L,5679107254350714417L,BigInteger.Parse("259271407469847625873"),BigInteger.Parse("11405005155091115435008"),BigInteger.Parse("485271704403173804854458") };
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
public class A267964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267964Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A267964.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A267964.Bytes);
public BigInteger this[int i]=>Value[i];

public static A267964Inst Instance=new A267964Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267965
{
public static readonly BigInteger[] Value={ 394L,155236L,30649446L,5520230601L,788980366553L,102223499117744L,11810588915957470L,1265251769611245447L,BigInteger.Parse("126142642452394981113"),BigInteger.Parse("11881829182693062116809") };
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
public class A267965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267965Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A267965.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A267965.Bytes);
public BigInteger this[int i]=>Value[i];

public static A267965Inst Instance=new A267965Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267966
{
public static readonly long[] Value={ 3L,9L,9L,24L,81L,24L,63L,576L,576L,63L,159L,3969L,9750L,3969L,159L,394L,25281L,157182L,157182L,25281L,394L,957L,155236L,2253828L,5843562L,2253828L,155236L,957L,2292L,915849L,30649446L,185900905L,185900905L,30649446L,915849L,2292L,5419L,5253264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267966Inst : IEnumerable<long>
{
public static readonly long[] Value=A267966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267966.Bytes);
public long this[int i]=>Value[i];

public static A267966Inst Instance=new A267966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267967
{
public static readonly long[] Value={ 30L,60L,70L,78L,102L,110L,120L,140L,150L,156L,174L,182L,190L,204L,210L,220L,222L,230L,238L,240L,246L,270L,280L,286L,300L,310L,312L,318L,330L,348L,350L,364L,366L,374L,380L,390L,406L,408L,420L,430L,438L,440L,444L,460L,470L,476L,480L,492L,494L,510L,518L,534L,540L,546L,550L,560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267967Inst : IEnumerable<long>
{
public static readonly long[] Value=A267967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267967.Bytes);
public long this[int i]=>Value[i];

public static A267967Inst Instance=new A267967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267968
{
public static readonly BigInteger[] Value={ 1L,1L,8L,648L,663552L,10368000000L,2902376448000000L,BigInteger.Parse("16731622649806848000000"),BigInteger.Parse("2245680377810414777401344000000"),BigInteger.Parse("7830203310981140781182893575634944000000"),BigInteger.Parse("783020331098114078118289357563494400000000000000000"),BigInteger.Parse("2457453226667794121573260254679367673480373862400000000000000000") };
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
public class A267968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267968Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A267968.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A267968.Bytes);
public BigInteger this[int i]=>Value[i];

public static A267968Inst Instance=new A267968Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267969
{
public static readonly long[] Value={ 5L,10L,13L,17L,20L,26L,27L,33L,34L,40L,43L,52L,54L,66L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267969Inst : IEnumerable<long>
{
public static readonly long[] Value=A267969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267969.Bytes);
public long this[int i]=>Value[i];

public static A267969Inst Instance=new A267969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267970
{
public static readonly long[] Value={ 7L,9L,11L,14L,18L,21L,22L,23L,25L,28L,29L,31L,35L,36L,37L,39L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A267970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267970Inst : IEnumerable<long>
{
public static readonly long[] Value=A267970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A267970.Bytes);
public long this[int i]=>Value[i];

public static A267970Inst Instance=new A267970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A267971
{
public static readonly BigInteger[] Value={ 64L,4096L,216000L,10941048L,519718464L,23689358848L,1040125019968L,44297983526887L,1837365396992000L,74486671360299008L,2959536976199968256L,BigInteger.Parse("115510695146966939968"),BigInteger.Parse("4436989542752316253696"),BigInteger.Parse("167999383203780355895296") };
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
public class A267971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A267971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A267971Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A267971.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A267971.Bytes);
public BigInteger this[int i]=>Value[i];

public static A267971Inst Instance=new A267971Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268036
{
public static readonly long[] Value={ 1096744L,2836295L,4473671462L,23040925705L,13579716377989L,119429556097859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268036Inst : IEnumerable<long>
{
public static readonly long[] Value=A268036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268036.Bytes);
public long this[int i]=>Value[i];

public static A268036Inst Instance=new A268036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268037
{
public static readonly long[] Value={ 4L,30L,48L,110L,208L,270L,320L,368L,510L,590L,688L,750L,1070L,1216L,1328L,1566L,1808L,2030L,2190L,2510L,2670L,2768L,3008L,3088L,3728L,4110L,4208L,4430L,4528L,4688L,4698L,4910L,5008L,5696L,5870L,5886L,5968L,6128L,6592L,6846L,7088L,7310L,7790L,8384L,9008L,9230L,9390L,9488L,9534L,9710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268037Inst : IEnumerable<long>
{
public static readonly long[] Value=A268037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268037.Bytes);
public long this[int i]=>Value[i];

public static A268037Inst Instance=new A268037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268038
{
public static readonly long[] Value={ 0L,0L,-1L,-1L,-1L,0L,1L,1L,1L,1L,0L,-1L,-2L,-2L,-2L,-2L,-2L,-1L,0L,1L,2L,2L,2L,2L,2L,2L,1L,0L,-1L,-2L,-3L,-3L,-3L,-3L,-3L,-3L,-3L,-2L,-1L,0L,1L,2L,3L,3L,3L,3L,3L,3L,3L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-4L,-4L,-4L,-4L,-4L,-4L,-4L,-4L,-3L,-2L,-1L,0L,1L,2L,3L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268038Inst : IEnumerable<long>
{
public static readonly long[] Value=A268038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268038.Bytes);
public long this[int i]=>Value[i];

public static A268038Inst Instance=new A268038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268039
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,40L,192L,959L,4988L,26587L,144672L,800229L,4486914L,25444355L,145681030L,840988369L,4889658927L,28607653570L,168299372745L,994978254267L,5908150711835L,35221346706997L,210723727773531L,1264832205228154L,7614504644529573L,45965528482747194L,278169935575048042L,1687298108487873673L,10256585388232231101UL,BigInteger.Parse("62470753620679133927"),BigInteger.Parse("381201089984659788693"),BigInteger.Parse("2330136670337522460729"),BigInteger.Parse("14266260150998229954489") };
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
public class A268039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268039Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268039.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268039.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268039Inst Instance=new A268039Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268040
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,2L,0L,1L,2L,3L,0L,0L,0L,2L,4L,0L,1L,0L,1L,4L,5L,0L,0L,2L,0L,4L,4L,6L,0L,1L,2L,3L,4L,5L,6L,7L,0L,0L,0L,2L,0L,4L,4L,6L,8L,0L,1L,0L,1L,0L,1L,4L,5L,8L,9L,0L,0L,2L,0L,0L,0L,2L,4L,8L,8L,10L,0L,1L,2L,3L,0L,1L,2L,3L,8L,9L,10L,11L,0L,0L,0L,2L,4L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268040Inst : IEnumerable<long>
{
public static readonly long[] Value=A268040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268040.Bytes);
public long this[int i]=>Value[i];

public static A268040Inst Instance=new A268040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268041
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,2L,1L,2L,1L,2L,0L,0L,0L,0L,0L,0L,4L,2L,3L,2L,3L,2L,4L,0L,0L,0L,0L,0L,0L,0L,0L,10L,5L,7L,3L,7L,3L,7L,5L,10L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,26L,14L,17L,8L,14L,8L,14L,8L,17L,14L,26L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,80L,42L,48L,24L,38L,20L,34L,20L,38L,24L,48L,42L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268041Inst : IEnumerable<long>
{
public static readonly long[] Value=A268041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268041.Bytes);
public long this[int i]=>Value[i];

public static A268041Inst Instance=new A268041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268042
{
public static readonly long[] Value={ 1L,3L,8L,20L,57L,166L,538L,1762L,6045L,21040L,74628L,267598L,970134L,3544416L,13043650L,48283236L,179665425L,671564330L,2520312810L,9492124534L,35863942748L,135893383596L,516258841134L,1965906973886L,7502329984510L,28687263026656L,109893836400756L,421684916479018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268042Inst : IEnumerable<long>
{
public static readonly long[] Value=A268042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268042.Bytes);
public long this[int i]=>Value[i];

public static A268042Inst Instance=new A268042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268043
{
public static readonly long[] Value={ 6L,1092L,1932L,2730L,4158L,6552L,11172L,25998L,30492L,55440L,76650L,79632L,85092L,102102L,150990L,152082L,152418L,166782L,211218L,235662L,236208L,248640L,264600L,298410L,300300L,301182L,317772L,380310L,387198L,441798L,476028L,488418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268043Inst : IEnumerable<long>
{
public static readonly long[] Value=A268043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268043.Bytes);
public long this[int i]=>Value[i];

public static A268043Inst Instance=new A268043Inst();

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