using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A056845
{
public static readonly long[] Value={ 1L,2L,9L,41L,248L,1609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056845Inst : IEnumerable<long>
{
public static readonly long[] Value=A056845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056845.Bytes);
public long this[int i]=>Value[i];

public static A056845Inst Instance=new A056845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056846
{
public static readonly long[] Value={ 1L,2L,11L,80L,780L,8781L,104828L,1298506L,16462696L,212457221L,2780615627L,36817036777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056846Inst : IEnumerable<long>
{
public static readonly long[] Value=A056846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056846.Bytes);
public long this[int i]=>Value[i];

public static A056846Inst Instance=new A056846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056847
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,3L,4L,4L,5L,6L,7L,8L,9L,9L,10L,11L,12L,13L,14L,15L,16L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056847Inst : IEnumerable<long>
{
public static readonly long[] Value=A056847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056847.Bytes);
public long this[int i]=>Value[i];

public static A056847Inst Instance=new A056847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056848
{
public static readonly long[] Value={ 1L,10L,16L,65L,160L,180L,366L,406L,896L,1436L,3904L,5464L,6312L,7168L,12558L,17957L,36960L,48097L,48256L,61952L,88646L,94400L,107340L,112240L,114863L,127540L,171856L,270336L,383360L,392736L,459012L,623639L,960484L,1222656L,1312768L,1463990L,1480704L,2244736L,2380968L,3183563L,4161888L,4787280L,5107455L,5606400L,6826556L,7878400L,9188414L,9533238L,10219520L,10356472L,12981760L,15162808L,22062080L,25240360L,28313472L,32215040L,41284864L,72160576L,79563520L,91164167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056848Inst : IEnumerable<long>
{
public static readonly long[] Value=A056848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056848.Bytes);
public long this[int i]=>Value[i];

public static A056848Inst Instance=new A056848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056849
{
public static readonly long[] Value={ 1L,4L,7L,6L,5L,6L,3L,6L,9L,0L,1L,6L,3L,6L,5L,6L,7L,4L,9L,0L,1L,4L,7L,6L,5L,6L,3L,6L,9L,0L,1L,6L,3L,6L,5L,6L,7L,4L,9L,0L,1L,4L,7L,6L,5L,6L,3L,6L,9L,0L,1L,6L,3L,6L,5L,6L,7L,4L,9L,0L,1L,4L,7L,6L,5L,6L,3L,6L,9L,0L,1L,6L,3L,6L,5L,6L,7L,4L,9L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056849Inst : IEnumerable<long>
{
public static readonly long[] Value=A056849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056849.Bytes);
public long this[int i]=>Value[i];

public static A056849Inst Instance=new A056849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056850
{
public static readonly long[] Value={ 0L,1L,1L,5L,17L,13L,217L,139L,1631L,3299L,6487L,46075L,7153L,502829L,588665L,2428309L,9492289L,5077565L,118985033L,88519643L,808182895L,1870418611L,2978678759L,25423702091L,7551629537L,252223018333L,342842572777L,1170495537221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056850Inst : IEnumerable<long>
{
public static readonly long[] Value=A056850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056850.Bytes);
public long this[int i]=>Value[i];

public static A056850Inst Instance=new A056850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056851
{
public static readonly long[] Value={ 0L,1L,2L,3L,11L,26L,83L,128L,186L,258L,572L,875L,1494L,2029L,3859L,4810L,6497L,9274L,18033L,19243L,24600L,26073L,30828L,32528L,34287L,41930L,48325L,96475L,103590L,118814L,126936L,205022L,240742L,260009L,331334L,379612L,396656L,405360L,414186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056851Inst : IEnumerable<long>
{
public static readonly long[] Value=A056851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056851.Bytes);
public long this[int i]=>Value[i];

public static A056851Inst Instance=new A056851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056852
{
public static readonly BigInteger[] Value={ 7L,521L,102943L,23775972551L,21633936185161L,BigInteger.Parse("45957792327018709121"),BigInteger.Parse("98920982783015679456199"),BigInteger.Parse("870019499993663001431459704607"),BigInteger.Parse("85589538438707037818727607157700537549449") };
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
public class A056852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056852Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A056852.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A056852.Bytes);
public BigInteger this[int i]=>Value[i];

public static A056852Inst Instance=new A056852Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056853
{
public static readonly long[] Value={ 4L,6L,7L,12L,13L,15L,18L,19L,21L,30L,42L,45L,60L,63L,72L,93L,102L,108L,117L,138L,150L,165L,180L,192L,198L,213L,228L,240L,255L,270L,282L,312L,333L,348L,357L,420L,432L,453L,462L,522L,525L,570L,600L,618L,642L,660L,693L,717L,765L,810L,822L,828L,858L,882L,933L,957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056853Inst : IEnumerable<long>
{
public static readonly long[] Value=A056853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056853.Bytes);
public long this[int i]=>Value[i];

public static A056853Inst Instance=new A056853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056854
{
public static readonly long[] Value={ 2L,7L,47L,322L,2207L,15127L,103682L,710647L,4870847L,33385282L,228826127L,1568397607L,10749957122L,73681302247L,505019158607L,3461452808002L,23725150497407L,162614600673847L,1114577054219522L,7639424778862807L,52361396397820127L,358890350005878082L,2459871053643326447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056854Inst : IEnumerable<long>
{
public static readonly long[] Value=A056854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056854.Bytes);
public long this[int i]=>Value[i];

public static A056854Inst Instance=new A056854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056855
{
public static readonly BigInteger[] Value={ 1L,1L,3L,4L,50L,6L,1764L,176L,4968L,300L,10628640L,552L,1486442880L,34986L,2024400L,4098240L,70734282393600L,133542L,22376988058521600L,16294800L,121402713600L,2612325870L,BigInteger.Parse("4148476779335454720000"),61931424L,BigInteger.Parse("138951136600657920000"),1330269185700L };
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
public class A056855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056855Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A056855.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A056855.Bytes);
public BigInteger this[int i]=>Value[i];

public static A056855Inst Instance=new A056855Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056856
{
public static readonly long[] Value={ 1L,1L,2L,2L,9L,9L,6L,44L,96L,64L,24L,250L,875L,1250L,625L,120L,1644L,8100L,18360L,19440L,7776L,720L,12348L,79576L,252105L,420175L,352947L,117649L,5040L,104544L,840448L,3465728L,8028160L,10551296L,7340032L,2097152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056856Inst : IEnumerable<long>
{
public static readonly long[] Value=A056856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056856.Bytes);
public long this[int i]=>Value[i];

public static A056856Inst Instance=new A056856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056857
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,6L,3L,1L,15L,20L,12L,4L,1L,52L,75L,50L,20L,5L,1L,203L,312L,225L,100L,30L,6L,1L,877L,1421L,1092L,525L,175L,42L,7L,1L,4140L,7016L,5684L,2912L,1050L,280L,56L,8L,1L,21147L,37260L,31572L,17052L,6552L,1890L,420L,72L,9L,1L,115975L,211470L,186300L,105240L,42630L,13104L,3150L,600L,90L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056857Inst : IEnumerable<long>
{
public static readonly long[] Value=A056857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056857.Bytes);
public long this[int i]=>Value[i];

public static A056857Inst Instance=new A056857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056858
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,6L,7L,1L,1L,10L,26L,14L,1L,1L,15L,71L,89L,26L,1L,1L,21L,161L,380L,267L,46L,1L,1L,28L,322L,1268L,1709L,732L,79L,1L,1L,36L,588L,3571L,8136L,6794L,1887L,133L,1L,1L,45L,1002L,8878L,31532L,44924L,24717L,4654L,221L,1L,1L,55L,1617L,20053L,104927L,234412L,221857L,84170L,11113L,364L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056858Inst : IEnumerable<long>
{
public static readonly long[] Value=A056858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056858.Bytes);
public long this[int i]=>Value[i];

public static A056858Inst Instance=new A056858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056859
{
public static readonly long[] Value={ 1L,2L,0L,4L,1L,0L,8L,7L,0L,0L,16L,32L,4L,0L,0L,32L,121L,49L,1L,0L,0L,64L,411L,360L,42L,0L,0L,0L,128L,1304L,2062L,624L,22L,0L,0L,0L,256L,3949L,10163L,6042L,730L,7L,0L,0L,0L,512L,11567L,45298L,45810L,12170L,617L,1L,0L,0L,0L,1024L,33056L,187941L,296017L,141822L,18325L,385L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056859Inst : IEnumerable<long>
{
public static readonly long[] Value=A056859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056859.Bytes);
public long this[int i]=>Value[i];

public static A056859Inst Instance=new A056859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056860
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,6L,5L,1L,4L,12L,20L,15L,1L,5L,20L,50L,75L,52L,1L,6L,30L,100L,225L,312L,203L,1L,7L,42L,175L,525L,1092L,1421L,877L,1L,8L,56L,280L,1050L,2912L,5684L,7016L,4140L,1L,9L,72L,420L,1890L,6552L,17052L,31572L,37260L,21147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056860Inst : IEnumerable<long>
{
public static readonly long[] Value=A056860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056860.Bytes);
public long this[int i]=>Value[i];

public static A056860Inst Instance=new A056860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056861
{
public static readonly long[] Value={ 1L,3L,2L,10L,7L,6L,37L,27L,23L,21L,151L,114L,97L,88L,83L,674L,523L,446L,403L,378L,363L,3263L,2589L,2217L,1999L,1867L,1785L,1733L,17007L,13744L,11829L,10658L,9923L,9452L,9145L,8942L,94828L,77821L,67340L,60689L,56380L,53541L,51644L,50361L,49484L,562595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056861Inst : IEnumerable<long>
{
public static readonly long[] Value=A056861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056861.Bytes);
public long this[int i]=>Value[i];

public static A056861Inst Instance=new A056861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056862
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,4L,0L,10L,14L,16L,0L,37L,54L,63L,68L,0L,151L,228L,271L,296L,311L,0L,674L,1046L,1264L,1396L,1478L,1530L,0L,3263L,5178L,6349L,7084L,7555L,7862L,8065L,0L,17007L,27488L,34139L,38448L,41287L,43184L,44467L,45344L,0L,94828L,155642L,195494L,222044L,239976L,252230L,260690L,266584L,270724L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056862Inst : IEnumerable<long>
{
public static readonly long[] Value=A056862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056862.Bytes);
public long this[int i]=>Value[i];

public static A056862Inst Instance=new A056862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056863
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,1L,1L,-3L,4L,2L,1L,-4L,9L,10L,4L,1L,-5L,16L,28L,24L,8L,1L,-6L,25L,60L,80L,56L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056863Inst : IEnumerable<long>
{
public static readonly long[] Value=A056863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056863.Bytes);
public long this[int i]=>Value[i];

public static A056863Inst Instance=new A056863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056864
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,3L,4L,5L,6L,8L,10L,12L,14L,17L,20L,23L,26L,29L,32L,36L,40L,44L,48L,53L,58L,63L,68L,73L,78L,84L,90L,96L,102L,109L,116L,123L,130L,137L,144L,152L,160L,168L,176L,185L,194L,203L,212L,221L,230L,240L,250L,260L,270L,281L,292L,303L,314L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056864Inst : IEnumerable<long>
{
public static readonly long[] Value=A056864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056864.Bytes);
public long this[int i]=>Value[i];

public static A056864Inst Instance=new A056864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056865
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,3L,4L,6L,8L,10L,12L,14L,16L,19L,22L,25L,28L,32L,36L,40L,44L,48L,52L,57L,62L,67L,72L,78L,84L,90L,96L,102L,108L,115L,122L,129L,136L,144L,152L,160L,168L,176L,184L,193L,202L,211L,220L,230L,240L,250L,260L,270L,280L,291L,302L,313L,324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056865Inst : IEnumerable<long>
{
public static readonly long[] Value=A056865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056865.Bytes);
public long this[int i]=>Value[i];

public static A056865Inst Instance=new A056865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056866
{
public static readonly long[] Value={ 60L,120L,168L,180L,240L,300L,336L,360L,420L,480L,504L,540L,600L,660L,672L,720L,780L,840L,900L,960L,1008L,1020L,1080L,1092L,1140L,1176L,1200L,1260L,1320L,1344L,1380L,1440L,1500L,1512L,1560L,1620L,1680L,1740L,1800L,1848L,1860L,1920L,1980L,2016L,2040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056866Inst : IEnumerable<long>
{
public static readonly long[] Value=A056866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056866.Bytes);
public long this[int i]=>Value[i];

public static A056866Inst Instance=new A056866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056867
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,13L,15L,16L,17L,19L,23L,25L,27L,29L,31L,32L,33L,35L,37L,41L,43L,45L,47L,49L,51L,53L,59L,61L,64L,65L,67L,69L,71L,73L,77L,79L,81L,83L,85L,87L,89L,91L,95L,97L,99L,101L,103L,107L,109L,113L,115L,119L,121L,123L,125L,127L,128L,131L,133L,135L,137L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056867Inst : IEnumerable<long>
{
public static readonly long[] Value=A056867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056867.Bytes);
public long this[int i]=>Value[i];

public static A056867Inst Instance=new A056867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056868
{
public static readonly long[] Value={ 6L,10L,12L,14L,18L,20L,21L,22L,24L,26L,28L,30L,34L,36L,38L,39L,40L,42L,44L,46L,48L,50L,52L,54L,55L,56L,57L,58L,60L,62L,63L,66L,68L,70L,72L,74L,75L,76L,78L,80L,82L,84L,86L,88L,90L,92L,93L,94L,96L,98L,100L,102L,104L,105L,106L,108L,110L,111L,112L,114L,116L,117L,118L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056868Inst : IEnumerable<long>
{
public static readonly long[] Value=A056868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056868.Bytes);
public long this[int i]=>Value[i];

public static A056868Inst Instance=new A056868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056869
{
public static readonly BigInteger[] Value={ 5L,29L,5741L,33461L,44560482149L,1746860020068409L,BigInteger.Parse("68480406462161287469"),BigInteger.Parse("13558774610046711780701"),BigInteger.Parse("4125636888562548868221559797461449"),BigInteger.Parse("4760981394323203445293052612223893281") };
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
public class A056869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056869Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A056869.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A056869.Bytes);
public BigInteger this[int i]=>Value[i];

public static A056869Inst Instance=new A056869Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056870
{
public static readonly long[] Value={ 0L,1L,2L,5L,9L,16L,26L,42L,64L,96L,140L,202L,285L,398L,547L,746L,1005L,1344L,1780L,2343L,3059L,3972L,5123L,6576L,8392L,10663L,13481L,16977L,21286L,26594L,33096L,41055L,50750L,62548L,76846L,94155L,115032L,140183L,170386L,206611L,249934L,301682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056870Inst : IEnumerable<long>
{
public static readonly long[] Value=A056870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056870.Bytes);
public long this[int i]=>Value[i];

public static A056870Inst Instance=new A056870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056871
{
public static readonly long[] Value={ 2L,5L,10L,17L,27L,42L,62L,90L,128L,180L,248L,340L,459L,616L,819L,1082L,1417L,1848L,2392L,3083L,3951L,5042L,6401L,8098L,10198L,12799L,16001L,19941L,24762L,30662L,37844L,46583L,57174L,69996L,85464L,104109L,126506L,153385L,185552L,224003L,269846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056871Inst : IEnumerable<long>
{
public static readonly long[] Value=A056871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056871.Bytes);
public long this[int i]=>Value[i];

public static A056871Inst Instance=new A056871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056872
{
public static readonly long[] Value={ 1L,5L,25L,42L,133L,618L,643L,701L,1962L,8150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056872Inst : IEnumerable<long>
{
public static readonly long[] Value=A056872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056872.Bytes);
public long this[int i]=>Value[i];

public static A056872Inst Instance=new A056872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056873
{
public static readonly long[] Value={ 1L,8L,11L,34L,310L,1688L,2307L,2708L,13988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056873Inst : IEnumerable<long>
{
public static readonly long[] Value=A056873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056873.Bytes);
public long this[int i]=>Value[i];

public static A056873Inst Instance=new A056873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056874
{
public static readonly long[] Value={ 3L,5L,11L,23L,31L,37L,47L,53L,59L,67L,71L,89L,97L,103L,113L,137L,157L,163L,179L,181L,191L,199L,223L,229L,251L,257L,269L,311L,313L,317L,331L,353L,367L,379L,383L,389L,397L,401L,419L,421L,433L,443L,449L,463L,467L,487L,499L,509L,521L,577L,587L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056874Inst : IEnumerable<long>
{
public static readonly long[] Value=A056874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056874.Bytes);
public long this[int i]=>Value[i];

public static A056874Inst Instance=new A056874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056875
{
public static readonly long[] Value={ 1L,3L,5L,6L,9L,10L,11L,13L,14L,18L,19L,20L,21L,23L,24L,27L,28L,30L,33L,34L,36L,38L,40L,41L,42L,43L,44L,46L,47L,50L,51L,53L,55L,58L,59L,60L,62L,65L,68L,69L,70L,71L,73L,74L,76L,79L,80L,82L,83L,84L,85L,88L,89L,91L,92L,93L,95L,96L,97L,101L,102L,103L,105L,106L,109L,111L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056875Inst : IEnumerable<long>
{
public static readonly long[] Value=A056875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056875.Bytes);
public long this[int i]=>Value[i];

public static A056875Inst Instance=new A056875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056876
{
public static readonly long[] Value={ 1L,0L,0L,2L,6L,0L,184L,936L,6688L,0L,420480L,4298664L,44405142L,0L,6732621476L,92014579912L,1345077232898L,0L,349174373111790L,6179276762966832L,114913276077265202L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056876Inst : IEnumerable<long>
{
public static readonly long[] Value=A056876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056876.Bytes);
public long this[int i]=>Value[i];

public static A056876Inst Instance=new A056876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056877
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,3L,4L,4L,8L,10L,15L,17L,30L,35L,60L,64L,117L,128L,236L,241L,459L,476L,937L,912L,1813L,1789L,3706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056877Inst : IEnumerable<long>
{
public static readonly long[] Value=A056877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056877.Bytes);
public long this[int i]=>Value[i];

public static A056877Inst Instance=new A056877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056878
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,2L,3L,3L,5L,6L,14L,9L,20L,20L,56L,32L,80L,64L,224L,114L,315L,217L,863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056878Inst : IEnumerable<long>
{
public static readonly long[] Value=A056878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056878.Bytes);
public long this[int i]=>Value[i];

public static A056878Inst Instance=new A056878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056879
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,6L,9L,23L,37L,87L,138L,313L,510L,1130L,1859L,4070L,6786L,14750L,24811L,53715L,91096L,196769L,335815L,724470L,1243175L,2680212L,4619999L,9957652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056879Inst : IEnumerable<long>
{
public static readonly long[] Value=A056879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056879.Bytes);
public long this[int i]=>Value[i];

public static A056879Inst Instance=new A056879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056880
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,3L,4L,4L,6L,10L,11L,16L,18L,33L,34L,56L,56L,110L,106L,193L,177L,372L,335L,662L,571L,1269L,1084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056880Inst : IEnumerable<long>
{
public static readonly long[] Value=A056880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056880.Bytes);
public long this[int i]=>Value[i];

public static A056880Inst Instance=new A056880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056881
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,2L,6L,5L,21L,18L,70L,61L,239L,206L,828L,711L,2903L,2485L,10314L,8791L,37031L,31451L,134147L,113566L,489672L,413419L,1799084L,1515282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056881Inst : IEnumerable<long>
{
public static readonly long[] Value=A056881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056881.Bytes);
public long this[int i]=>Value[i];

public static A056881Inst Instance=new A056881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056882
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,2L,1L,2L,3L,4L,4L,6L,7L,12L,12L,17L,18L,33L,34L,51L,52L,93L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056882Inst : IEnumerable<long>
{
public static readonly long[] Value=A056882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056882.Bytes);
public long this[int i]=>Value[i];

public static A056882Inst Instance=new A056882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056883
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,5L,4L,18L,19L,72L,72L,268L,276L,1002L,1043L,3733L,3926L,14000L,14810L,52658L,55987L,199020L,212364L,754826L,807861L,2872926L,3082202L,10966333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056883Inst : IEnumerable<long>
{
public static readonly long[] Value=A056883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056883.Bytes);
public long this[int i]=>Value[i];

public static A056883Inst Instance=new A056883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056884
{
public static readonly long[] Value={ 0L,0L,0L,1L,5L,20L,84L,311L,1165L,4276L,15802L,58280L,216070L,803116L,2997360L,11221443L,42147842L,158749808L,599513836L,2269390757L,8609258335L,32725209938L,124621150623L,475367241264L,1816100804241L,6948222137523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056884Inst : IEnumerable<long>
{
public static readonly long[] Value=A056884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056884.Bytes);
public long this[int i]=>Value[i];

public static A056884Inst Instance=new A056884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056885
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,0L,1L,3L,0L,0L,1L,3L,5L,0L,0L,1L,5L,8L,7L,0L,0L,1L,8L,19L,17L,11L,0L,0L,1L,12L,45L,56L,35L,15L,0L,0L,1L,17L,107L,194L,151L,65L,22L,0L,0L,1L,24L,244L,713L,728L,365L,118L,30L,0L,0L,1L,32L,547L,2697L,3996L,2413L,835L,203L,42L,0L,0L,1L,42L,1173L,10356L,24446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056885Inst : IEnumerable<long>
{
public static readonly long[] Value=A056885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056885.Bytes);
public long this[int i]=>Value[i];

public static A056885Inst Instance=new A056885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056886
{
public static readonly long[] Value={ 1L,0L,-1L,2L,5L,-8L,3L,8L,141L,-204L,11L,-4L,-11L,-30L,99L,1836L,164997L,-224532L,2403L,-126L,-39L,14L,-5L,-14L,-267L,-738L,351L,-1134L,-28431L,-538002L,9537507L,891167508L,361226647845L,-471103550820L,1127461923L,-11787930L,-675783L,34992L,-1377L,-432L,-927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056886Inst : IEnumerable<long>
{
public static readonly long[] Value=A056886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056886.Bytes);
public long this[int i]=>Value[i];

public static A056886Inst Instance=new A056886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056887
{
public static readonly long[] Value={ 1L,0L,-1L,-2L,1L,2L,7L,-8L,-7L,-6L,27L,-54L,57L,-56L,-233L,-232L,-7L,-6L,187L,-588L,1485L,-1242L,-6177L,-3184L,-639L,640L,-1441L,-3472L,13033L,13032L,-20745L,-24120L,1593L,1594L,20891L,-60476L,9069L,-26964L,-1916541L,-6305202L,1619109L,-1599426L,-8587701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056887Inst : IEnumerable<long>
{
public static readonly long[] Value=A056887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056887.Bytes);
public long this[int i]=>Value[i];

public static A056887Inst Instance=new A056887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056888
{
public static readonly long[] Value={ 2L,3L,2L,0L,4L,1L,3L,1L,1L,5L,2L,2L,3L,1L,0L,3L,6L,2L,3L,0L,0L,4L,1L,3L,1L,4L,1L,1L,0L,1L,3L,2L,3L,5L,1L,1L,3L,3L,2L,5L,0L,3L,3L,1L,1L,3L,2L,2L,0L,2L,1L,5L,2L,1L,1L,1L,1L,3L,4L,5L,1L,0L,1L,3L,2L,1L,2L,4L,5L,1L,1L,2L,1L,0L,1L,2L,4L,1L,2L,5L,0L,2L,4L,3L,2L,2L,1L,2L,2L,2L,0L,2L,3L,2L,1L,5L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056888Inst : IEnumerable<long>
{
public static readonly long[] Value=A056888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056888.Bytes);
public long this[int i]=>Value[i];

public static A056888Inst Instance=new A056888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056889
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,-1L,-2L,1L,2L,-1L,-3L,2L,9L,-7L,-40L,33L,224L,-191L,-1495L,1304L,11545L,-10241L,-101106L,90865L,989274L,-898409L,-10690043L,9791634L,126392833L,-116601199L,-1622625152L,1506023953L,22473758096L,-20967734143L,-333977722335L,313009988192L,5300202065121L,-4987192076929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056889Inst : IEnumerable<long>
{
public static readonly long[] Value=A056889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056889.Bytes);
public long this[int i]=>Value[i];

public static A056889Inst Instance=new A056889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056890
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,-2L,1L,1L,0L,1L,-1L,-4L,3L,14L,-11L,-63L,52L,353L,-301L,-2356L,2055L,18194L,-16139L,-159335L,143196L,1559017L,-1415821L,-16846656L,15430835L,199185034L,-183754199L,-2557127951L,2373373752L,35416852081L,-33043478329L,-526322279512L,493278801183L,8352696141782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056890Inst : IEnumerable<long>
{
public static readonly long[] Value=A056890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056890.Bytes);
public long this[int i]=>Value[i];

public static A056890Inst Instance=new A056890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056891
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,8L,11L,18L,23L,35L,38L,61L,69L,98L,107L,148L,138L,213L,226L,295L,311L,396L,377L,518L,539L,663L,686L,833L,717L,1030L,1059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056891Inst : IEnumerable<long>
{
public static readonly long[] Value=A056891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056891.Bytes);
public long this[int i]=>Value[i];

public static A056891Inst Instance=new A056891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056892
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,4L,1L,3L,7L,4L,6L,1L,5L,7L,11L,4L,10L,12L,3L,7L,9L,15L,2L,8L,16L,1L,3L,7L,9L,13L,6L,10L,16L,18L,5L,7L,13L,19L,23L,4L,10L,12L,22L,24L,1L,3L,15L,27L,2L,4L,8L,14L,16L,26L,1L,7L,13L,15L,21L,25L,27L,4L,18L,22L,24L,28L,7L,13L,23L,25L,29L,35L,6L,12L,18L,22L,28L,36L,1L,9L,19L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056892Inst : IEnumerable<long>
{
public static readonly long[] Value=A056892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056892.Bytes);
public long this[int i]=>Value[i];

public static A056892Inst Instance=new A056892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056893
{
public static readonly long[] Value={ 2L,3L,7L,13L,41L,31L,23L,89L,73L,59L,47L,61L,113L,239L,79L,97L,593L,139L,163L,461L,277L,191L,167L,193L,281L,251L,223L,317L,353L,991L,431L,761L,433L,563L,359L,397L,521L,479L,439L,569L,617L,571L,619L,773L,829L,887L,947L,673L,1493L,1571L,727L,1013L,953L,1279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056893Inst : IEnumerable<long>
{
public static readonly long[] Value=A056893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056893.Bytes);
public long this[int i]=>Value[i];

public static A056893Inst Instance=new A056893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056894
{
public static readonly long[] Value={ 1L,1L,4L,9L,36L,25L,16L,81L,64L,49L,36L,49L,100L,225L,64L,81L,576L,121L,144L,441L,256L,169L,144L,169L,256L,225L,196L,289L,324L,961L,400L,729L,400L,529L,324L,361L,484L,441L,400L,529L,576L,529L,576L,729L,784L,841L,900L,625L,1444L,1521L,676L,961L,900L,1225L,784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056894Inst : IEnumerable<long>
{
public static readonly long[] Value=A056894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056894.Bytes);
public long this[int i]=>Value[i];

public static A056894Inst Instance=new A056894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056895
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,5L,4L,9L,8L,7L,6L,7L,10L,15L,8L,9L,24L,11L,12L,21L,16L,13L,12L,13L,16L,15L,14L,17L,18L,31L,20L,27L,20L,23L,18L,19L,22L,21L,20L,23L,24L,23L,24L,27L,28L,29L,30L,25L,38L,39L,26L,31L,30L,35L,28L,45L,34L,31L,42L,31L,34L,33L,32L,33L,36L,35L,34L,75L,40L,37L,36L,41L,48L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056895Inst : IEnumerable<long>
{
public static readonly long[] Value=A056895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056895.Bytes);
public long this[int i]=>Value[i];

public static A056895Inst Instance=new A056895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056896
{
public static readonly long[] Value={ 2L,2L,3L,5L,5L,7L,7L,17L,13L,11L,11L,13L,13L,23L,19L,17L,17L,19L,19L,29L,37L,23L,23L,73L,29L,107L,31L,29L,29L,31L,31L,41L,37L,43L,71L,37L,37L,47L,43L,41L,41L,43L,43L,53L,61L,47L,47L,73L,53L,59L,67L,53L,53L,79L,59L,137L,61L,59L,59L,61L,61L,71L,67L,73L,101L,67L,67L,149L,73L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056896Inst : IEnumerable<long>
{
public static readonly long[] Value=A056896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056896.Bytes);
public long this[int i]=>Value[i];

public static A056896Inst Instance=new A056896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056897
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,9L,4L,1L,0L,1L,0L,9L,4L,1L,0L,1L,0L,9L,16L,1L,0L,49L,4L,81L,4L,1L,0L,1L,0L,9L,4L,9L,36L,1L,0L,9L,4L,1L,0L,1L,0L,9L,16L,1L,0L,25L,4L,9L,16L,1L,0L,25L,4L,81L,4L,1L,0L,1L,0L,9L,4L,9L,36L,1L,0L,81L,4L,1L,0L,1L,0L,9L,4L,25L,36L,1L,0L,9L,16L,1L,0L,25L,4L,81L,16L,1L,0L,49L,16L,9L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056897Inst : IEnumerable<long>
{
public static readonly long[] Value=A056897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056897.Bytes);
public long this[int i]=>Value[i];

public static A056897Inst Instance=new A056897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056898
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,3L,2L,1L,0L,1L,0L,3L,2L,1L,0L,1L,0L,3L,4L,1L,0L,7L,2L,9L,2L,1L,0L,1L,0L,3L,2L,3L,6L,1L,0L,3L,2L,1L,0L,1L,0L,3L,4L,1L,0L,5L,2L,3L,4L,1L,0L,5L,2L,9L,2L,1L,0L,1L,0L,3L,2L,3L,6L,1L,0L,9L,2L,1L,0L,1L,0L,3L,2L,5L,6L,1L,0L,3L,4L,1L,0L,5L,2L,9L,4L,1L,0L,7L,4L,3L,2L,3L,6L,1L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056898Inst : IEnumerable<long>
{
public static readonly long[] Value=A056898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056898.Bytes);
public long this[int i]=>Value[i];

public static A056898Inst Instance=new A056898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056899
{
public static readonly long[] Value={ 2L,3L,11L,83L,227L,443L,1091L,1523L,2027L,3251L,6563L,9803L,11027L,12323L,13691L,15131L,21611L,29243L,47963L,50627L,56171L,59051L,62003L,65027L,74531L,88211L,91811L,95483L,103043L,119027L,123203L,131771L,136163L,140627L,149771L,173891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056899Inst : IEnumerable<long>
{
public static readonly long[] Value=A056899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056899.Bytes);
public long this[int i]=>Value[i];

public static A056899Inst Instance=new A056899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056900
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,9L,13L,16L,17L,18L,19L,20L,24L,28L,36L,37L,39L,40L,41L,42L,45L,49L,50L,51L,53L,57L,58L,60L,61L,62L,64L,69L,70L,71L,73L,74L,75L,79L,83L,85L,91L,92L,93L,95L,100L,101L,108L,112L,113L,116L,118L,125L,129L,134L,136L,139L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056900Inst : IEnumerable<long>
{
public static readonly long[] Value=A056900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056900.Bytes);
public long this[int i]=>Value[i];

public static A056900Inst Instance=new A056900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056901
{
public static readonly long[] Value={ 6L,15L,20L,45L,42L,35L,72L,153L,110L,63L,156L,77L,210L,99L,88L,561L,342L,143L,420L,117L,130L,195L,600L,209L,702L,255L,812L,165L,930L,187L,1056L,2145L,238L,399L,204L,221L,1482L,483L,304L,273L,1806L,247L,1980L,285L,266L,675L,2352L,665L,2550L,783L,460L,357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056901Inst : IEnumerable<long>
{
public static readonly long[] Value=A056901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056901.Bytes);
public long this[int i]=>Value[i];

public static A056901Inst Instance=new A056901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056902
{
public static readonly long[] Value={ 0L,-1L,1L,-2L,2L,-4L,-5L,6L,8L,-9L,10L,-11L,-12L,12L,-13L,15L,-16L,-18L,-19L,20L,-22L,22L,23L,24L,-26L,26L,-27L,-29L,-30L,36L,38L,40L,-41L,41L,-43L,-46L,-48L,-50L,-51L,-53L,-54L,54L,-57L,58L,59L,-61L,61L,66L,-68L,69L,-71L,-72L,72L,73L,76L,78L,-79L,-81L,-85L,85L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056902Inst : IEnumerable<long>
{
public static readonly long[] Value=A056902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056902.Bytes);
public long this[int i]=>Value[i];

public static A056902Inst Instance=new A056902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056903
{
public static readonly long[] Value={ 2L,3L,5L,8L,9L,21L,26L,41L,56L,62L,69L,79L,89L,91L,122L,127L,143L,167L,201L,230L,247L,252L,290L,349L,376L,459L,489L,492L,516L,662L,687L,714L,771L,932L,944L,1061L,1281L,1352L,1489L,1730L,1969L,2012L,2116L,2457L,2663L,2955L,3083L,3130L,3204L,3359L,3494L,3572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056903Inst : IEnumerable<long>
{
public static readonly long[] Value=A056903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056903.Bytes);
public long this[int i]=>Value[i];

public static A056903Inst Instance=new A056903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056904
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,9L,12L,30L,45L,51L,57L,84L,92L,135L,176L,187L,222L,301L,315L,376L,392L,442L,551L,570L,651L,759L,782L,900L,1001L,1107L,1162L,1305L,1395L,1552L,1717L,1785L,1926L,1962L,2262L,2301L,2460L,2501L,2667L,2709L,2926L,2970L,3151L,3197L,3432L,3577L,3825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056904Inst : IEnumerable<long>
{
public static readonly long[] Value=A056904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056904.Bytes);
public long this[int i]=>Value[i];

public static A056904Inst Instance=new A056904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056905
{
public static readonly long[] Value={ 5L,41L,149L,1301L,2309L,5189L,6089L,9221L,13001L,15881L,26249L,28229L,39209L,41621L,60521L,66569L,86441L,112901L,116969L,138389L,171401L,186629L,207941L,213449L,242069L,254021L,266261L,285161L,304709L,331781L,345749L,352841L,389381L,443561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056905Inst : IEnumerable<long>
{
public static readonly long[] Value=A056905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056905.Bytes);
public long this[int i]=>Value[i];

public static A056905Inst Instance=new A056905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056906
{
public static readonly long[] Value={ 0L,1L,2L,6L,8L,12L,13L,16L,19L,21L,27L,28L,33L,34L,41L,43L,49L,56L,57L,62L,69L,72L,76L,77L,82L,84L,86L,89L,92L,96L,98L,99L,104L,111L,119L,121L,126L,128L,131L,132L,133L,134L,139L,142L,146L,148L,153L,159L,166L,168L,169L,173L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056906Inst : IEnumerable<long>
{
public static readonly long[] Value=A056906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056906.Bytes);
public long this[int i]=>Value[i];

public static A056906Inst Instance=new A056906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056907
{
public static readonly long[] Value={ 0L,-1L,1L,2L,-3L,-6L,6L,-8L,-11L,11L,12L,14L,-16L,16L,17L,19L,-21L,-23L,-26L,27L,-28L,32L,-34L,-36L,36L,-39L,39L,-41L,42L,44L,-46L,46L,-48L,-49L,51L,52L,-53L,-58L,62L,64L,67L,-68L,-71L,71L,-76L,77L,79L,81L,-84L,-89L,91L,96L,-99L,-101L,101L,102L,-104L,-111L,111L,-113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056907Inst : IEnumerable<long>
{
public static readonly long[] Value=A056907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056907.Bytes);
public long this[int i]=>Value[i];

public static A056907Inst Instance=new A056907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056908
{
public static readonly long[] Value={ 0L,2L,4L,5L,7L,9L,14L,19L,22L,24L,29L,30L,34L,40L,42L,44L,50L,59L,62L,70L,72L,74L,75L,79L,80L,82L,84L,95L,102L,110L,119L,125L,132L,135L,139L,149L,150L,157L,160L,165L,172L,180L,197L,199L,200L,209L,210L,212L,224L,225L,227L,229L,230L,232L,235L,240L,244L,249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056908Inst : IEnumerable<long>
{
public static readonly long[] Value=A056908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056908.Bytes);
public long this[int i]=>Value[i];

public static A056908Inst Instance=new A056908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056909
{
public static readonly long[] Value={ 7L,31L,127L,367L,631L,967L,1231L,3727L,4231L,6247L,7927L,8287L,11887L,17167L,21031L,22807L,30631L,34231L,39607L,48847L,72367L,108247L,109567L,126031L,160807L,185767L,198031L,231367L,235231L,261127L,265231L,279847L,290527L,323767L,354031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056909Inst : IEnumerable<long>
{
public static readonly long[] Value=A056909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056909.Bytes);
public long this[int i]=>Value[i];

public static A056909Inst Instance=new A056909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056910
{
public static readonly long[] Value={ 0L,-1L,-2L,3L,4L,5L,-6L,10L,-11L,13L,-15L,15L,18L,-22L,24L,25L,29L,-31L,33L,-37L,-45L,-55L,55L,59L,-67L,-72L,74L,80L,-81L,85L,-86L,88L,-90L,-95L,99L,-101L,-102L,108L,-116L,118L,-122L,129L,-130L,143L,148L,-151L,-155L,-157L,158L,159L,-162L,164L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056910Inst : IEnumerable<long>
{
public static readonly long[] Value=A056910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056910.Bytes);
public long this[int i]=>Value[i];

public static A056910Inst Instance=new A056910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056911
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,15L,17L,19L,21L,23L,29L,31L,33L,35L,37L,39L,41L,43L,47L,51L,53L,55L,57L,59L,61L,65L,67L,69L,71L,73L,77L,79L,83L,85L,87L,89L,91L,93L,95L,97L,101L,103L,105L,107L,109L,111L,113L,115L,119L,123L,127L,129L,131L,133L,137L,139L,141L,143L,145L,149L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056911Inst : IEnumerable<long>
{
public static readonly long[] Value=A056911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056911.Bytes);
public long this[int i]=>Value[i];

public static A056911Inst Instance=new A056911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056912
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,105L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,165L,167L,173L,179L,181L,191L,193L,195L,197L,199L,211L,223L,227L,229L,231L,233L,239L,241L,251L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056912Inst : IEnumerable<long>
{
public static readonly long[] Value=A056912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056912.Bytes);
public long this[int i]=>Value[i];

public static A056912Inst Instance=new A056912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056913
{
public static readonly long[] Value={ 1L,15L,21L,33L,35L,39L,51L,55L,57L,65L,69L,77L,85L,87L,91L,93L,95L,111L,115L,119L,123L,129L,133L,141L,143L,145L,155L,159L,161L,177L,183L,185L,187L,201L,203L,205L,209L,213L,215L,217L,219L,221L,235L,237L,247L,249L,253L,259L,265L,267L,287L,291L,295L,299L,301L,303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056913Inst : IEnumerable<long>
{
public static readonly long[] Value=A056913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056913.Bytes);
public long this[int i]=>Value[i];

public static A056913Inst Instance=new A056913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056914
{
public static readonly long[] Value={ 1L,11L,76L,521L,3571L,24476L,167761L,1149851L,7881196L,54018521L,370248451L,2537720636L,17393796001L,119218851371L,817138163596L,5600748293801L,38388099893011L,263115950957276L,1803423556807921L,12360848946698171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056914Inst : IEnumerable<long>
{
public static readonly long[] Value=A056914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056914.Bytes);
public long this[int i]=>Value[i];

public static A056914Inst Instance=new A056914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056915
{
public static readonly long[] Value={ 25326001L,161304001L,960946321L,1157839381L,3215031751L,3697278427L,5764643587L,6770862367L,14386156093L,15579919981L,18459366157L,19887974881L,21276028621L,27716349961L,29118033181L,37131467521L,41752650241L,42550716781L,43536545821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056915Inst : IEnumerable<long>
{
public static readonly long[] Value=A056915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056915.Bytes);
public long this[int i]=>Value[i];

public static A056915Inst Instance=new A056915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056916
{
public static readonly BigInteger[] Value={ 1L,2L,9L,32L,625L,648L,117649L,131072L,4782969L,12500000L,25937424601L,214990848L,23298085122481L,1771684761728L,14416259765625L,562949953421312L,BigInteger.Parse("48661191875666868481"),11712917736940032L,BigInteger.Parse("104127350297911241532841"),5120000000000000000L,BigInteger.Parse("7788651757984142343081") };
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
public class A056916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056916Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A056916.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A056916.Bytes);
public BigInteger this[int i]=>Value[i];

public static A056916Inst Instance=new A056916Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056917
{
public static readonly long[] Value={ 1L,15L,30L,44L,65L,77L,78L,87L,105L,141L,147L,186L,242L,247L,282L,301L,330L,335L,345L,450L,481L,560L,570L,589L,591L,606L,671L,705L,717L,767L,777L,785L,819L,820L,870L,1007L,1032L,1056L,1071L,1102L,1167L,1173L,1185L,1230L,1247L,1271L,1351L,1374L,1415L,1416L,1501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056917Inst : IEnumerable<long>
{
public static readonly long[] Value=A056917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056917.Bytes);
public long this[int i]=>Value[i];

public static A056917Inst Instance=new A056917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056918
{
public static readonly long[] Value={ 2L,9L,79L,702L,6239L,55449L,492802L,4379769L,38925119L,345946302L,3074591599L,27325378089L,242853811202L,2158358922729L,19182376493359L,170483029517502L,1515164889164159L,13466000972959929L,119678843867475202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056918Inst : IEnumerable<long>
{
public static readonly long[] Value=A056918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056918.Bytes);
public long this[int i]=>Value[i];

public static A056918Inst Instance=new A056918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056919
{
public static readonly long[] Value={ 0L,1L,1L,0L,-2L,-2L,4L,10L,-6L,-46L,-16L,214L,310L,-974L,-3144L,3674L,28826L,-566L,-260000L,-254906L,2345094L,4894154L,-20901880L,-74737574L,176084986L,1072935874L,-1216168944L,-15164335306L,1862029910L,214162724194L,186232275544L,-3026208587366L,-6005924996070L,42413412401786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056919Inst : IEnumerable<long>
{
public static readonly long[] Value=A056919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056919.Bytes);
public long this[int i]=>Value[i];

public static A056919Inst Instance=new A056919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056920
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-1L,1L,4L,1L,-15L,-19L,56L,151L,-185L,-1091L,204L,7841L,6209L,-56519L,-112400L,396271L,1520271L,-2442439L,-19165420L,7701409L,237686449L,145269541L,-2944654296L,-4833158329L,36392001815L,104056218421L,-441823808804L,-2002667085119L,5066513855745L,37109187217649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056920Inst : IEnumerable<long>
{
public static readonly long[] Value=A056920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056920.Bytes);
public long this[int i]=>Value[i];

public static A056920Inst Instance=new A056920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056921
{
public static readonly long[] Value={ 0L,1L,1L,2L,5L,7L,26L,33L,158L,191L,1113L,1304L,8937L,10241L,80624L,90865L,807544L,898409L,8893225L,9791634L,106809565L,116601199L,1389422754L,1506023953L,19461710190L,20967734143L,292042254049L,313009988192L,4674182088737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056921Inst : IEnumerable<long>
{
public static readonly long[] Value=A056921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056921.Bytes);
public long this[int i]=>Value[i];

public static A056921Inst Instance=new A056921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056922
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,11L,41L,52L,249L,301L,1754L,2055L,14084L,16139L,127057L,143196L,1272625L,1415821L,14015014L,15430835L,168323364L,183754199L,2189619553L,2373373752L,30670104577L,33043478329L,460235322854L,493278801183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056922Inst : IEnumerable<long>
{
public static readonly long[] Value=A056922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056922.Bytes);
public long this[int i]=>Value[i];

public static A056922Inst Instance=new A056922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056923
{
public static readonly BigInteger[] Value={ 0L,2L,60L,3024L,240240L,27907200L,4475671200L,948964262400L,257256702743040L,86839771951296000L,BigInteger.Parse("35728290125079552000"),BigInteger.Parse("17602963463032472448000"),BigInteger.Parse("10233395250958706770944000"),BigInteger.Parse("6932022668773077815267328000") };
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
public class A056923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056923Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A056923.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A056923.Bytes);
public BigInteger this[int i]=>Value[i];

public static A056923Inst Instance=new A056923Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056924
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,3L,2L,2L,1L,4L,1L,2L,2L,3L,1L,4L,1L,3L,2L,2L,2L,4L,1L,2L,2L,4L,1L,4L,1L,3L,3L,2L,1L,5L,1L,3L,2L,3L,1L,4L,2L,4L,2L,2L,1L,6L,1L,2L,3L,3L,2L,4L,1L,3L,2L,4L,1L,6L,1L,2L,3L,3L,2L,4L,1L,5L,2L,2L,1L,6L,2L,2L,2L,4L,1L,6L,2L,3L,2L,2L,2L,6L,1L,3L,3L,4L,1L,4L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056924Inst : IEnumerable<long>
{
public static readonly long[] Value=A056924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056924.Bytes);
public long this[int i]=>Value[i];

public static A056924Inst Instance=new A056924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056925
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,36L,7L,64L,9L,100L,11L,1728L,13L,196L,225L,256L,17L,5832L,19L,8000L,441L,484L,23L,331776L,25L,676L,729L,21952L,29L,810000L,31L,32768L,1089L,1156L,1225L,1679616L,37L,1444L,1521L,2560000L,41L,3111696L,43L,85184L,91125L,2116L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056925Inst : IEnumerable<long>
{
public static readonly long[] Value=A056925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056925.Bytes);
public long this[int i]=>Value[i];

public static A056925Inst Instance=new A056925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056926
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,6L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056926Inst : IEnumerable<long>
{
public static readonly long[] Value=A056926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056926.Bytes);
public long this[int i]=>Value[i];

public static A056926Inst Instance=new A056926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056927
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,2L,3L,2L,3L,8L,5L,2L,3L,2L,5L,6L,7L,2L,3L,2L,5L,6L,5L,6L,3L,2L,11L,2L,13L,8L,3L,2L,3L,2L,5L,2L,5L,10L,3L,12L,5L,2L,3L,8L,3L,2L,7L,2L,23L,8L,5L,6L,7L,2L,15L,20L,3L,12L,7L,2L,11L,2L,3L,6L,7L,6L,3L,2L,11L,2L,5L,6L,5L,2L,27L,2L,5L,12L,3L,8L,5L,6L,13L,6L,3L,8L,3L,2L,7L,8L,3L,2L,5L,12L,7L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056927Inst : IEnumerable<long>
{
public static readonly long[] Value=A056927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056927.Bytes);
public long this[int i]=>Value[i];

public static A056927Inst Instance=new A056927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056928
{
public static readonly long[] Value={ 4L,9L,15L,26L,34L,50L,64L,81L,99L,120L,144L,170L,195L,225L,254L,288L,324L,363L,399L,441L,483L,532L,574L,625L,675L,730L,780L,846L,897L,960L,1026L,1089L,1158L,1226L,1294L,1370L,1443L,1517L,1599L,1681L,1768L,1854L,1941L,2022L,2121L,2210L,2303L,2405L,2490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056928Inst : IEnumerable<long>
{
public static readonly long[] Value=A056928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056928.Bytes);
public long this[int i]=>Value[i];

public static A056928Inst Instance=new A056928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056929
{
public static readonly long[] Value={ 0L,0L,1L,-1L,2L,-1L,0L,0L,1L,1L,0L,-1L,1L,0L,2L,1L,0L,-2L,1L,0L,1L,-3L,2L,0L,1L,-1L,4L,-5L,3L,1L,-2L,0L,-2L,-1L,2L,-1L,1L,4L,1L,0L,-4L,-5L,-5L,3L,-5L,-1L,1L,-4L,10L,0L,1L,-2L,3L,-5L,7L,9L,-2L,1L,0L,-2L,4L,-9L,0L,1L,3L,1L,-5L,-10L,4L,-4L,0L,1L,2L,-6L,12L,-4L,0L,3L,-9L,3L,-2L,-2L,6L,1L,-6L,2L,-3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056929Inst : IEnumerable<long>
{
public static readonly long[] Value=A056929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056929.Bytes);
public long this[int i]=>Value[i];

public static A056929Inst Instance=new A056929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056930
{
public static readonly long[] Value={ 6L,12L,20L,30L,42L,57L,73L,90L,107L,133L,158L,183L,210L,239L,270L,305L,345L,382L,420L,461L,505L,556L,598L,652L,702L,753L,813L,870L,930L,994L,1059L,1122L,1193L,1260L,1332L,1406L,1479L,1560L,1635L,1726L,1812L,1897L,1983L,2070L,2168L,2255L,2354L,2444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056930Inst : IEnumerable<long>
{
public static readonly long[] Value=A056930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056930.Bytes);
public long this[int i]=>Value[i];

public static A056930Inst Instance=new A056930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056931
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,-1L,-1L,0L,3L,-1L,-2L,-1L,0L,1L,2L,1L,-3L,-2L,0L,1L,1L,-4L,2L,-2L,0L,3L,-1L,0L,0L,-2L,-3L,0L,-3L,0L,0L,0L,3L,0L,5L,-4L,-6L,-5L,-3L,0L,-6L,1L,-2L,6L,2L,-2L,1L,-2L,0L,1L,9L,0L,2L,-2L,-3L,2L,-1L,-9L,1L,1L,2L,-1L,-6L,-6L,-1L,-3L,0L,0L,0L,6L,-1L,-3L,3L,-2L,-7L,1L,-2L,1L,2L,-1L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056931Inst : IEnumerable<long>
{
public static readonly long[] Value=A056931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056931.Bytes);
public long this[int i]=>Value[i];

public static A056931Inst Instance=new A056931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056932
{
public static readonly long[] Value={ 1L,20L,168L,887L,3490L,11196L,30900L,75966L,170379L,354640L,693836L,1288365L,2287844L,3908776L,6456600L,10352796L,16167765L,24660252L,36824128L,53943395L,77656326L,110029700L,153644140L,211691610L,288086175L,387589176L,515950020L,680063833L,888147272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056932Inst : IEnumerable<long>
{
public static readonly long[] Value=A056932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056932.Bytes);
public long this[int i]=>Value[i];

public static A056932Inst Instance=new A056932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056933
{
public static readonly long[] Value={ 1L,336L,30900L,1301610L,32046856L,530962446L,6479344016L,61951251333L,485198553532L,3217462615688L,18528857431906L,94529315562186L,434088353496446L,1817613939845670L,7014049051387480L,25167786776727516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056933Inst : IEnumerable<long>
{
public static readonly long[] Value=A056933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056933.Bytes);
public long this[int i]=>Value[i];

public static A056933Inst Instance=new A056933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056934
{
public static readonly long[] Value={ 1L,540L,75966L,4701698L,164489084L,3764727340L,61951251333L,782318812002L,7946895019096L,67270102239520L,487605585591870L,3092040981805272L,17451258588313354L,88902214572208640L,413569247116248032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056934Inst : IEnumerable<long>
{
public static readonly long[] Value=A056934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056934.Bytes);
public long this[int i]=>Value[i];

public static A056934Inst Instance=new A056934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056935
{
public static readonly long[] Value={ 1L,175L,8790L,211250L,3092808L,31635580L,246441430L,1549486490L,8192995479L,37548347569L,152602439244L,559835910940L,1880152558980L,5846268790220L,16988036626948L,46486024648180L,120562654732065L,297976456047575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056935Inst : IEnumerable<long>
{
public static readonly long[] Value=A056935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056935.Bytes);
public long this[int i]=>Value[i];

public static A056935Inst Instance=new A056935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056936
{
public static readonly long[] Value={ 1L,490L,59542L,3092808L,89613429L,1691136270L,22954776044L,239831111938L,2024703039198L,14318216628378L,87184226214168L,467034400160664L,2239064967256060L,9741467994941264L,38902816410160608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056936Inst : IEnumerable<long>
{
public static readonly long[] Value=A056936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056936.Bytes);
public long this[int i]=>Value[i];

public static A056936Inst Instance=new A056936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056937
{
public static readonly long[] Value={ 1L,980L,211250L,17792748L,781429368L,21238316210L,398925639186L,5585711269074L,61555624183223L,555895303974238L,4242859829536322L,28038281717424550L,163544036697306396L,855242362045150398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056937Inst : IEnumerable<long>
{
public static readonly long[] Value=A056937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056937.Bytes);
public long this[int i]=>Value[i];

public static A056937Inst Instance=new A056937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056938
{
public static readonly BigInteger[] Value={ 49L,77L,711L,3379L,31109L,132393L,344131L,1731653L,71143523L,11115771019L,31135742029L,717261644891L,11193431873899L,116134799345907L,3204751189066719L,31068250396355573L,62161149980213343L,336906794442245927L,734615161567701999L,BigInteger.Parse("31318836286194043641") };
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
public class A056938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056938Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A056938.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A056938.Bytes);
public BigInteger this[int i]=>Value[i];

public static A056938Inst Instance=new A056938Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056939
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,10L,10L,1L,1L,20L,50L,20L,1L,1L,35L,175L,175L,35L,1L,1L,56L,490L,980L,490L,56L,1L,1L,84L,1176L,4116L,4116L,1176L,84L,1L,1L,120L,2520L,14112L,24696L,14112L,2520L,120L,1L,1L,165L,4950L,41580L,116424L,116424L,41580L,4950L,165L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056939Inst : IEnumerable<long>
{
public static readonly long[] Value=A056939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056939.Bytes);
public long this[int i]=>Value[i];

public static A056939Inst Instance=new A056939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056940
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,15L,15L,1L,1L,35L,105L,35L,1L,1L,70L,490L,490L,70L,1L,1L,126L,1764L,4116L,1764L,126L,1L,1L,210L,5292L,24696L,24696L,5292L,210L,1L,1L,330L,13860L,116424L,232848L,116424L,13860L,330L,1L,1L,495L,32670L,457380L,1646568L,1646568L,457380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056940Inst : IEnumerable<long>
{
public static readonly long[] Value=A056940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056940.Bytes);
public long this[int i]=>Value[i];

public static A056940Inst Instance=new A056940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056941
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,21L,21L,1L,1L,56L,196L,56L,1L,1L,126L,1176L,1176L,126L,1L,1L,252L,5292L,14112L,5292L,252L,1L,1L,462L,19404L,116424L,116424L,19404L,462L,1L,1L,792L,60984L,731808L,1646568L,731808L,60984L,792L,1L,1L,1287L,169884L,3737448L,16818516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056941Inst : IEnumerable<long>
{
public static readonly long[] Value=A056941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056941.Bytes);
public long this[int i]=>Value[i];

public static A056941Inst Instance=new A056941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056942
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,6L,9L,12L,12L,12L,16L,20L,20L,20L,20L,25L,30L,30L,30L,30L,30L,36L,42L,42L,42L,42L,42L,42L,49L,56L,56L,56L,56L,56L,56L,56L,64L,72L,72L,72L,72L,72L,72L,72L,72L,81L,90L,90L,90L,90L,90L,90L,90L,90L,90L,100L,110L,110L,110L,110L,110L,110L,110L,110L,110L,110L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056942Inst : IEnumerable<long>
{
public static readonly long[] Value=A056942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056942.Bytes);
public long this[int i]=>Value[i];

public static A056942Inst Instance=new A056942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056943
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,1L,3L,5L,4L,3L,6L,9L,8L,7L,6L,10L,14L,13L,12L,11L,10L,15L,20L,19L,18L,17L,16L,15L,21L,27L,26L,25L,24L,23L,22L,21L,28L,35L,34L,33L,32L,31L,30L,29L,28L,36L,44L,43L,42L,41L,40L,39L,38L,37L,36L,45L,54L,53L,52L,51L,50L,49L,48L,47L,46L,45L,55L,65L,64L,63L,62L,61L,60L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056943Inst : IEnumerable<long>
{
public static readonly long[] Value=A056943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056943.Bytes);
public long this[int i]=>Value[i];

public static A056943Inst Instance=new A056943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A056944
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,4L,3L,2L,4L,6L,4L,2L,4L,6L,8L,5L,2L,4L,6L,8L,10L,6L,2L,4L,6L,8L,10L,12L,7L,2L,4L,6L,8L,10L,12L,14L,8L,2L,4L,6L,8L,10L,12L,14L,16L,9L,2L,4L,6L,8L,10L,12L,14L,16L,18L,10L,2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,11L,2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,22L,12L,2L,4L,6L,8L,10L,12L,14L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A056944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A056944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A056944Inst : IEnumerable<long>
{
public static readonly long[] Value=A056944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A056944.Bytes);
public long this[int i]=>Value[i];

public static A056944Inst Instance=new A056944Inst();

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