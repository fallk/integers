using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A159764
{
public static readonly long[] Value={ 1L,-4L,1L,15L,-8L,1L,-56L,46L,-12L,1L,209L,-232L,93L,-16L,1L,-780L,1091L,-592L,156L,-20L,1L,2911L,-4912L,3366L,-1200L,235L,-24L,1L,-10864L,21468L,-17784L,8010L,-2120L,330L,-28L,1L,40545L,-91824L,89238L,-48624L,16255L,-3416L,441L,-32L,1L,-151316L,386373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159764Inst : IEnumerable<long>
{
public static readonly long[] Value=A159764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159764.Bytes);
public long this[int i]=>Value[i];

public static A159764Inst Instance=new A159764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159765
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L,16L,20L,25L,32L,40L,50L,64L,80L,100L,125L,160L,200L,250L,320L,400L,500L,625L,800L,1000L,1250L,1600L,2000L,2500L,3125L,4000L,5000L,6250L,8000L,10000L,12500L,15625L,20000L,25000L,31250L,40000L,50000L,62500L,100000L,125000L,200000L,250000L,500000L,1000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159765Inst : IEnumerable<long>
{
public static readonly long[] Value=A159765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159765.Bytes);
public long this[int i]=>Value[i];

public static A159765Inst Instance=new A159765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159766
{
public static readonly long[] Value={ 4L,1L,2L,43L,2L,163L,2L,3L,1L,1L,2L,5L,1L,2L,3L,80L,2L,5L,2L,1L,1L,1L,33L,1L,1L,53L,1L,1L,1L,1L,1L,1L,6L,1L,1L,2L,2L,1L,1L,239L,1L,3L,31L,1L,1L,11L,1L,13L,123L,2L,2L,2L,2L,13L,15L,1L,2L,3L,3L,1L,3L,1L,1L,6L,1L,3L,1L,1L,13L,8L,1L,7L,1L,2L,1L,8L,7L,1L,17L,1L,6L,1L,1L,3L,1L,1L,13L,1L,1L,4L,2L,9L,124L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159766Inst : IEnumerable<long>
{
public static readonly long[] Value=A159766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159766.Bytes);
public long this[int i]=>Value[i];

public static A159766Inst Instance=new A159766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159767
{
public static readonly long[] Value={ 2L,1L,1L,85L,2L,8L,1L,10L,16L,3L,8L,9L,2L,1L,40L,1L,2L,3L,2L,2L,1L,17L,1L,1L,5L,3L,2L,6L,3L,5L,1L,1L,3L,3L,15L,3L,1L,1L,7L,2L,3L,1L,7L,2L,1L,55L,1L,1L,1L,1L,4L,9L,1L,2L,1L,36L,1L,5L,10L,1L,1L,2L,1L,4L,1L,4L,5L,5L,1L,1L,130L,1L,3L,1L,1L,2L,1L,3L,1L,3L,2L,3L,2L,2L,547L,9L,18L,3L,1L,4L,2L,1L,1L,2L,2L,2L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159767Inst : IEnumerable<long>
{
public static readonly long[] Value=A159767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159767.Bytes);
public long this[int i]=>Value[i];

public static A159767Inst Instance=new A159767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159768
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,41L,124L,385L,1221L,3939L,12886L,42648L,142544L,480459L,1631287L,5574073L,19153815L,66146259L,229452587L,799140681L,2793373937L,9796395680L,34459558856L,121548541383L,429823475811L,1523511450184L,5411789548439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159768Inst : IEnumerable<long>
{
public static readonly long[] Value=A159768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159768.Bytes);
public long this[int i]=>Value[i];

public static A159768Inst Instance=new A159768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159769
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,41L,124L,384L,1212L,3885L,12614L,41400L,137132L,457841L,1539150L,5205612L,17700450L,60473476L,207491052L,714668954L,2470156910L,8564900629L,29783782326L,103846841946L,362970362118L,1271546963124L,4463801464608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159769Inst : IEnumerable<long>
{
public static readonly long[] Value=A159769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159769.Bytes);
public long this[int i]=>Value[i];

public static A159769Inst Instance=new A159769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159770
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,41L,124L,384L,1211L,3875L,12548L,41040L,135370L,449791L,1504057L,5057668L,17092030L,58018150L,197727023L,676290905L,2320721255L,7987481185L,27566740439L,95379299734L,330774138321L,1149589209136L,4003322875481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159770Inst : IEnumerable<long>
{
public static readonly long[] Value=A159770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159770.Bytes);
public long this[int i]=>Value[i];

public static A159770Inst Instance=new A159770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159771
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,41L,124L,385L,1220L,3929L,12822L,42309L,140922L,473169L,1599864L,5442561L,18615176L,63975857L,220816906L,765121477L,2660426630L,9280204025L,32466050612L,113883898241L,400464335116L,1411407234697L,4984885122974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159771Inst : IEnumerable<long>
{
public static readonly long[] Value=A159771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159771.Bytes);
public long this[int i]=>Value[i];

public static A159771Inst Instance=new A159771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159772
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,41L,124L,384L,1210L,3865L,12482L,40677L,133572L,441468L,1467296L,4900760L,16439370L,55357305L,187050302L,633998079L,2154950454L,7343407521L,25082709012L,85858848820L,294480653064L,1011871145116L,3482837144984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159772Inst : IEnumerable<long>
{
public static readonly long[] Value=A159772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159772.Bytes);
public long this[int i]=>Value[i];

public static A159772Inst Instance=new A159772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159773
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,41L,124L,384L,1212L,3885L,12613L,41389L,137055L,457403L,1536935L,5195215L,17654059L,60273846L,206654787L,711236960L,2456296348L,8509633845L,29565682912L,102993430854L,359654460720L,1258739058760L,4414576865348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159773Inst : IEnumerable<long>
{
public static readonly long[] Value=A159773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159773.Bytes);
public long this[int i]=>Value[i];

public static A159773Inst Instance=new A159773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159774
{
public static readonly long[] Value={ 1012L,102L,102342L,1031345242L,103524563142L,1042L,10467842L,105263157894736842L,316L,10631694842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159774Inst : IEnumerable<long>
{
public static readonly long[] Value=A159774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159774.Bytes);
public long this[int i]=>Value[i];

public static A159774Inst Instance=new A159774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159775
{
public static readonly long[] Value={ 9L,2859L,9009L,9041L,28491L,28509L,28541L,28559L,28591L,28609L,90009L,90041L,90059L,90091L,90109L,90141L,90159L,90191L,90209L,90241L,90259L,90291L,90309L,90341L,90359L,90391L,90409L,90441L,90459L,90491L,90509L,90541L,284609L,284641L,284659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159775Inst : IEnumerable<long>
{
public static readonly long[] Value=A159775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159775.Bytes);
public long this[int i]=>Value[i];

public static A159775Inst Instance=new A159775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159776
{
public static readonly BigInteger[] Value={ 1L,34L,274L,-50660L,-2447444L,95515384L,14040751096L,-28081874864L,-87642381012080L,-2781695245370336L,601127582131299616L,BigInteger.Parse("44972889856630550464"),BigInteger.Parse("-4303061546712430158656"),BigInteger.Parse("-622297158830800371505280"),BigInteger.Parse("28180800294357511567970176"),BigInteger.Parse("8642272527250878380658183424") };
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
public class A159776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159776Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159776.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159776.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159776Inst Instance=new A159776Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159777
{
public static readonly long[] Value={ 145L,167L,197L,673L,835L,1037L,3893L,4843L,6025L,22685L,28223L,35113L,132217L,164495L,204653L,770617L,958747L,1192805L,4491485L,5587987L,6952177L,26178293L,32569175L,40520257L,152578273L,189827063L,236169365L,889291345L,1106393203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159777Inst : IEnumerable<long>
{
public static readonly long[] Value=A159777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159777.Bytes);
public long this[int i]=>Value[i];

public static A159777Inst Instance=new A159777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159778
{
public static readonly long[] Value={ 1L,2L,4L,4L,1L,2L,9L,0L,5L,7L,6L,1L,4L,9L,7L,2L,8L,8L,1L,8L,4L,9L,3L,6L,4L,7L,1L,1L,5L,5L,3L,6L,0L,5L,6L,8L,8L,8L,7L,9L,1L,1L,0L,5L,9L,1L,3L,7L,6L,0L,5L,1L,7L,9L,5L,8L,2L,3L,9L,1L,4L,2L,1L,0L,7L,0L,5L,1L,4L,3L,9L,7L,8L,6L,8L,2L,7L,2L,3L,2L,5L,1L,5L,5L,7L,5L,4L,5L,3L,6L,4L,6L,2L,5L,8L,6L,0L,3L,6L,4L,6L,1L,7L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159778Inst : IEnumerable<long>
{
public static readonly long[] Value=A159778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159778.Bytes);
public long this[int i]=>Value[i];

public static A159778Inst Instance=new A159778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159779
{
public static readonly long[] Value={ 3L,7L,6L,5L,4L,8L,1L,3L,7L,3L,9L,2L,8L,6L,2L,8L,1L,3L,7L,7L,6L,5L,6L,5L,2L,3L,3L,1L,4L,7L,3L,9L,3L,8L,8L,5L,3L,7L,2L,1L,5L,1L,6L,5L,9L,8L,6L,3L,2L,3L,8L,1L,1L,5L,4L,0L,5L,0L,9L,5L,9L,7L,9L,6L,2L,6L,5L,9L,1L,7L,6L,6L,7L,6L,0L,1L,1L,0L,8L,4L,6L,2L,5L,0L,2L,3L,0L,8L,2L,1L,5L,0L,5L,4L,2L,1L,1L,7L,2L,0L,5L,7L,3L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159779Inst : IEnumerable<long>
{
public static readonly long[] Value=A159779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159779.Bytes);
public long this[int i]=>Value[i];

public static A159779Inst Instance=new A159779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159780
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,2L,1L,3L,0L,2L,0L,2L,0L,2L,2L,4L,0L,2L,0L,2L,1L,3L,1L,3L,0L,2L,2L,4L,1L,3L,3L,5L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,2L,4L,2L,4L,0L,2L,2L,4L,0L,2L,2L,4L,0L,2L,2L,4L,2L,4L,4L,6L,0L,2L,0L,2L,0L,2L,0L,2L,1L,3L,1L,3L,1L,3L,1L,3L,0L,2L,0L,2L,2L,4L,2L,4L,1L,3L,1L,3L,3L,5L,3L,5L,0L,2L,2L,4L,0L,2L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159780Inst : IEnumerable<long>
{
public static readonly long[] Value=A159780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159780.Bytes);
public long this[int i]=>Value[i];

public static A159780Inst Instance=new A159780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159781
{
public static readonly long[] Value={ 1105L,1885L,2405L,2465L,2665L,3145L,3445L,3485L,3965L,4505L,4745L,5185L,5365L,5525L,5785L,5945L,6205L,6305L,6409L,6565L,7085L,7345L,7565L,7585L,7685L,8177L,8245L,8585L,8845L,8905L,9061L,9265L,9425L,9605L,9685L,9805L,10205L,10585L,10865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159781Inst : IEnumerable<long>
{
public static readonly long[] Value=A159781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159781.Bytes);
public long this[int i]=>Value[i];

public static A159781Inst Instance=new A159781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159782
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,0L,4L,0L,4L,0L,4L,0L,4L,0L,2L,0L,2L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159782Inst : IEnumerable<long>
{
public static readonly long[] Value=A159782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159782.Bytes);
public long this[int i]=>Value[i];

public static A159782Inst Instance=new A159782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159783
{
public static readonly BigInteger[] Value={ 1L,4L,192L,221184L,10192158720L,28179280429056000L,BigInteger.Parse("6544446260541338419200000"),BigInteger.Parse("170229151878929266676890337280000000"),BigInteger.Parse("637613431509979741286846928045094207488000000000") };
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
public class A159783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159783Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159783.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159783.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159783Inst Instance=new A159783Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159784
{
public static readonly BigInteger[] Value={ 1L,38L,562L,-45676L,-3222740L,38680808L,15682154104L,391223020016L,-81955144677488L,-5874765126977440L,427318863624757024L,BigInteger.Parse("68053545237681787712"),BigInteger.Parse("-1559812895855484713792"),BigInteger.Parse("-779551612838132460267904"),BigInteger.Parse("-11738146623970045761841280"),BigInteger.Parse("9179853743614397880438109952") };
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
public class A159784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159784Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159784.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159784.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159784Inst Instance=new A159784Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159785
{
public static readonly long[] Value={ 3L,6L,9L,9L,12L,21L,24L,15L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159785Inst : IEnumerable<long>
{
public static readonly long[] Value=A159785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159785.Bytes);
public long this[int i]=>Value[i];

public static A159785Inst Instance=new A159785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159786
{
public static readonly long[] Value={ 0L,0L,0L,4L,8L,8L,12L,32L,48L,48L,52L,64L,72L,76L,104L,176L,224L,224L,228L,240L,248L,252L,280L,336L,368L,372L,392L,424L,444L,480L,608L,864L,960L,960L,964L,976L,984L,988L,1016L,1072L,1104L,1108L,1128L,1160L,1180L,1216L,1344L,1536L,1632L,1636L,1656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159786Inst : IEnumerable<long>
{
public static readonly long[] Value=A159786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159786.Bytes);
public long this[int i]=>Value[i];

public static A159786Inst Instance=new A159786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159787
{
public static readonly long[] Value={ 0L,0L,3L,6L,6L,9L,24L,36L,36L,39L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159787Inst : IEnumerable<long>
{
public static readonly long[] Value=A159787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159787.Bytes);
public long this[int i]=>Value[i];

public static A159787Inst Instance=new A159787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159788
{
public static readonly long[] Value={ 0L,0L,2L,4L,4L,6L,16L,24L,24L,26L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159788Inst : IEnumerable<long>
{
public static readonly long[] Value=A159788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159788.Bytes);
public long this[int i]=>Value[i];

public static A159788Inst Instance=new A159788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159789
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,3L,8L,12L,12L,13L,16L,18L,19L,26L,44L,56L,56L,57L,60L,62L,63L,70L,84L,92L,93L,98L,106L,111L,120L,152L,216L,240L,240L,241L,244L,246L,247L,254L,268L,276L,277L,282L,290L,295L,304L,336L,384L,408L,409L,414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159789Inst : IEnumerable<long>
{
public static readonly long[] Value=A159789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159789.Bytes);
public long this[int i]=>Value[i];

public static A159789Inst Instance=new A159789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159790
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,2L,7L,7L,2L,0L,1L,1L,4L,18L,35L,35L,22L,12L,5L,-3L,-8L,-2L,7L,3L,-6L,-4L,5L,17L,48L,106L,155L,155L,126L,100L,77L,53L,32L,22L,15L,-5L,-30L,-44L,-51L,-55L,-40L,2L,35L,23L,-10L,-32L,-47L,-59L,-52L,-18L,11L,11L,14L,48L,101L,181L,328L,522L,651L,651L,590L,532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159790Inst : IEnumerable<long>
{
public static readonly long[] Value=A159790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159790.Bytes);
public long this[int i]=>Value[i];

public static A159790Inst Instance=new A159790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159791
{
public static readonly long[] Value={ 0L,3L,11L,23L,43L,55L,79L,123L,171L,183L,207L,251L,303L,347L,423L,571L,683L,695L,719L,763L,815L,859L,935L,1083L,1199L,1243L,1319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159791Inst : IEnumerable<long>
{
public static readonly long[] Value=A159791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159791.Bytes);
public long this[int i]=>Value[i];

public static A159791Inst Instance=new A159791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159792
{
public static readonly long[] Value={ 1L,7L,15L,35L,47L,67L,95L,155L,175L,195L,223L,283L,319L,383L,483L,651L,687L,707L,735L,795L,831L,895L,995L,1163L,1215L,1279L,1379L,1551L,1667L,1871L,2219L,2667L,2735L,2755L,2783L,2843L,2879L,2943L,3043L,3211L,3263L,3327L,3427L,3599L,3715L,3919L,4267L,4715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159792Inst : IEnumerable<long>
{
public static readonly long[] Value=A159792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159792.Bytes);
public long this[int i]=>Value[i];

public static A159792Inst Instance=new A159792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159793
{
public static readonly long[] Value={ 0L,2L,6L,12L,18L,26L,40L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159793Inst : IEnumerable<long>
{
public static readonly long[] Value=A159793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159793.Bytes);
public long this[int i]=>Value[i];

public static A159793Inst Instance=new A159793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159794
{
public static readonly long[] Value={ 0L,3L,9L,18L,27L,39L,60L,84L,99L,111L,132L,159L,189L,234L,300L,360L,387L,399L,420L,447L,477L,522L,588L,651L,693L,738L,807L,891L,996L,1152L,1344L,1488L,1539L,1551L,1572L,1599L,1629L,1674L,1740L,1803L,1845L,1890L,1959L,2043L,2148L,2304L,2496L,2643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159794Inst : IEnumerable<long>
{
public static readonly long[] Value=A159794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159794.Bytes);
public long this[int i]=>Value[i];

public static A159794Inst Instance=new A159794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159795
{
public static readonly long[] Value={ 0L,4L,12L,24L,36L,52L,80L,112L,132L,148L,176L,212L,252L,312L,400L,480L,516L,532L,560L,596L,636L,696L,784L,868L,924L,984L,1076L,1188L,1328L,1536L,1792L,1984L,2052L,2068L,2096L,2132L,2172L,2232L,2320L,2404L,2460L,2520L,2612L,2724L,2864L,3072L,3328L,3524L,3612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159795Inst : IEnumerable<long>
{
public static readonly long[] Value=A159795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159795.Bytes);
public long this[int i]=>Value[i];

public static A159795Inst Instance=new A159795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159796
{
public static readonly long[] Value={ 0L,0L,4L,4L,0L,4L,20L,16L,0L,4L,12L,8L,4L,28L,72L,48L,0L,4L,12L,8L,4L,28L,56L,32L,4L,20L,32L,20L,36L,128L,256L,96L,0L,4L,12L,8L,4L,28L,56L,32L,4L,20L,32L,20L,36L,128L,192L,96L,4L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159796Inst : IEnumerable<long>
{
public static readonly long[] Value=A159796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159796.Bytes);
public long this[int i]=>Value[i];

public static A159796Inst Instance=new A159796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159797
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,3L,5L,7L,9L,4L,7L,10L,13L,16L,5L,9L,13L,17L,21L,25L,6L,11L,16L,21L,26L,31L,36L,7L,13L,19L,25L,31L,37L,43L,49L,8L,15L,22L,29L,36L,43L,50L,57L,64L,9L,17L,25L,33L,41L,49L,57L,65L,73L,81L,10L,19L,28L,37L,46L,55L,64L,73L,82L,91L,100L,11L,21L,31L,41L,51L,61L,71L,81L,91L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159797Inst : IEnumerable<long>
{
public static readonly long[] Value=A159797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159797.Bytes);
public long this[int i]=>Value[i];

public static A159797Inst Instance=new A159797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159798
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,2L,3L,4L,1L,3L,5L,7L,9L,1L,4L,7L,10L,13L,16L,1L,5L,9L,13L,17L,21L,25L,1L,6L,11L,16L,21L,26L,31L,36L,1L,7L,13L,19L,25L,31L,37L,43L,49L,1L,8L,15L,22L,29L,36L,43L,50L,57L,64L,1L,9L,17L,25L,33L,41L,49L,57L,65L,73L,81L,1L,10L,19L,28L,37L,46L,55L,64L,73L,82L,91L,100L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159798Inst : IEnumerable<long>
{
public static readonly long[] Value=A159798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159798.Bytes);
public long this[int i]=>Value[i];

public static A159798Inst Instance=new A159798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159799
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,5L,4L,0L,1L,3L,2L,1L,7L,18L,12L,0L,1L,3L,2L,1L,7L,14L,8L,1L,5L,8L,5L,9L,32L,64L,24L,0L,1L,3L,2L,1L,7L,14L,8L,1L,5L,8L,5L,9L,32L,48L,24L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159799Inst : IEnumerable<long>
{
public static readonly long[] Value=A159799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159799.Bytes);
public long this[int i]=>Value[i];

public static A159799Inst Instance=new A159799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159800
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,2L,1L,2L,2L,1L,1L,2L,2L,3L,3L,3L,3L,4L,4L,3L,3L,4L,5L,4L,3L,2L,3L,4L,4L,3L,2L,1L,2L,3L,3L,3L,2L,1L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,4L,5L,5L,5L,4L,4L,5L,6L,6L,5L,4L,4L,5L,6L,7L,6L,5L,4L,3L,4L,5L,6L,6L,5L,4L,3L,2L,3L,4L,5L,5L,5L,4L,3L,2L,1L,2L,3L,4L,4L,4L,4L,3L,2L,1L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159800Inst : IEnumerable<long>
{
public static readonly long[] Value=A159800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159800.Bytes);
public long this[int i]=>Value[i];

public static A159800Inst Instance=new A159800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159801
{
public static readonly long[] Value={ 4L,11L,20L,30L,45L,67L,88L,102L,117L,140L,168L,203L,255L,319L,368L,390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159801Inst : IEnumerable<long>
{
public static readonly long[] Value=A159801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159801.Bytes);
public long this[int i]=>Value[i];

public static A159801Inst Instance=new A159801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159802
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,2L,2L,4L,2L,3L,4L,4L,4L,4L,4L,5L,4L,7L,6L,8L,5L,4L,7L,7L,6L,9L,7L,7L,6L,8L,7L,9L,7L,10L,11L,7L,10L,12L,9L,6L,9L,8L,8L,8L,9L,8L,10L,10L,12L,11L,11L,12L,13L,9L,12L,14L,13L,11L,10L,14L,11L,14L,15L,12L,16L,14L,16L,11L,12L,11L,12L,14L,14L,15L,15L,13L,17L,15L,16L,18L,17L,15L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159802Inst : IEnumerable<long>
{
public static readonly long[] Value=A159802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159802.Bytes);
public long this[int i]=>Value[i];

public static A159802Inst Instance=new A159802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159803
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,2L,3L,4L,4L,3L,5L,3L,5L,4L,4L,5L,2L,6L,4L,4L,7L,3L,8L,5L,7L,6L,5L,7L,8L,10L,5L,8L,7L,10L,8L,7L,10L,9L,7L,10L,9L,13L,10L,11L,11L,11L,11L,11L,12L,9L,9L,11L,14L,12L,11L,12L,12L,11L,15L,12L,11L,14L,12L,12L,14L,15L,12L,15L,14L,17L,18L,20L,18L,17L,14L,18L,12L,15L,15L,15L,14L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159803Inst : IEnumerable<long>
{
public static readonly long[] Value=A159803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159803.Bytes);
public long this[int i]=>Value[i];

public static A159803Inst Instance=new A159803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159804
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,4L,1L,3L,4L,2L,4L,4L,4L,5L,6L,5L,3L,6L,5L,7L,6L,6L,6L,5L,7L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159804Inst : IEnumerable<long>
{
public static readonly long[] Value=A159804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159804.Bytes);
public long this[int i]=>Value[i];

public static A159804Inst Instance=new A159804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159805
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,2L,4L,3L,3L,4L,4L,4L,4L,5L,4L,5L,6L,5L,6L,5L,7L,7L,4L,10L,5L,5L,10L,8L,6L,7L,5L,7L,5L,7L,10L,7L,10L,12L,11L,10L,7L,11L,10L,10L,10L,12L,8L,9L,11L,9L,9L,8L,9L,15L,15L,9L,14L,11L,14L,17L,11L,11L,10L,17L,14L,15L,13L,17L,17L,13L,12L,16L,13L,20L,17L,11L,14L,14L,17L,16L,17L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159805Inst : IEnumerable<long>
{
public static readonly long[] Value=A159805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159805.Bytes);
public long this[int i]=>Value[i];

public static A159805Inst Instance=new A159805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159806
{
public static readonly BigInteger[] Value={ 1L,1L,-241L,-725L,174241L,876041L,-209955569L,-1481967101L,354182766785L,3223271074321L,-768186794983409L,-8568502794840229L,2036344745450994529L,BigInteger.Parse("26919276861667019545"),BigInteger.Parse("-6379421292327161768689"),BigInteger.Parse("-97581931299655023987149"),BigInteger.Parse("23059717359847942196353921") };
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
public class A159806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159806Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159806.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159806.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159806Inst Instance=new A159806Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159807
{
public static readonly BigInteger[] Value={ 1L,3L,-233L,-2151L,162705L,2570283L,-189162201L,-4299537519L,307542155937L,9246531104595L,-642087222317001L,-24302866940070903L,1636327584987643953L,BigInteger.Parse("75484508348928834171"),BigInteger.Parse("-4921433057324341373625"),BigInteger.Parse("-270505813458143914292223"),BigInteger.Parse("17053284557712927443382081") };
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
public class A159807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159807Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159807.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159807.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159807Inst Instance=new A159807Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159808
{
public static readonly BigInteger[] Value={ 1L,5L,-217L,-3505L,140017L,4092925L,-148955945L,-6687706825L,218892836705L,14041864596725L,-406539275359865L,-36014008700873825L,902137507503591505L,BigInteger.Parse("109095368804855545325"),BigInteger.Parse("-2292647754582021148105"),BigInteger.Parse("-381078348283760693301625"),BigInteger.Parse("6416919607713933301113025") };
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
public class A159808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159808Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159808.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159808.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159808Inst Instance=new A159808Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159809
{
public static readonly long[] Value={ 197L,223L,257L,925L,1115L,1345L,5353L,6467L,7813L,31193L,37687L,45533L,181805L,219655L,265385L,1059637L,1280243L,1546777L,6176017L,7461803L,9015277L,35996465L,43490575L,52544885L,209802773L,253481647L,306254033L,1222820173L,1477399307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159809Inst : IEnumerable<long>
{
public static readonly long[] Value=A159809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159809.Bytes);
public long this[int i]=>Value[i];

public static A159809Inst Instance=new A159809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159810
{
public static readonly long[] Value={ 1L,2L,0L,8L,1L,9L,0L,1L,6L,5L,3L,4L,1L,6L,7L,1L,9L,7L,9L,6L,5L,9L,4L,2L,0L,0L,0L,7L,7L,4L,1L,2L,1L,4L,9L,8L,8L,1L,4L,8L,3L,8L,6L,3L,5L,0L,9L,4L,7L,5L,7L,1L,4L,8L,9L,6L,6L,5L,0L,2L,4L,1L,7L,9L,9L,9L,8L,7L,5L,3L,2L,4L,8L,2L,2L,3L,6L,0L,1L,8L,4L,3L,7L,9L,1L,5L,3L,1L,9L,5L,5L,2L,9L,0L,7L,1L,4L,1L,1L,2L,9L,2L,3L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159810Inst : IEnumerable<long>
{
public static readonly long[] Value=A159810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159810.Bytes);
public long this[int i]=>Value[i];

public static A159810Inst Instance=new A159810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159811
{
public static readonly long[] Value={ 3L,9L,9L,2L,8L,2L,9L,6L,1L,6L,0L,5L,9L,5L,4L,0L,8L,7L,1L,9L,4L,7L,0L,2L,3L,1L,5L,9L,0L,3L,2L,9L,5L,2L,8L,8L,8L,1L,2L,8L,2L,0L,0L,2L,4L,6L,4L,5L,6L,8L,4L,4L,6L,8L,4L,5L,6L,7L,9L,4L,1L,7L,1L,2L,0L,8L,5L,7L,8L,9L,2L,9L,0L,3L,1L,0L,4L,7L,7L,1L,6L,5L,0L,8L,0L,2L,9L,1L,1L,5L,7L,7L,4L,8L,8L,0L,1L,7L,0L,9L,3L,2L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159811Inst : IEnumerable<long>
{
public static readonly long[] Value=A159811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159811.Bytes);
public long this[int i]=>Value[i];

public static A159811Inst Instance=new A159811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159812
{
public static readonly long[] Value={ 2104L,5573L,4093L,20131L,19637L,22523L,177913L,334634L,167084L,441730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159812Inst : IEnumerable<long>
{
public static readonly long[] Value=A159812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159812.Bytes);
public long this[int i]=>Value[i];

public static A159812Inst Instance=new A159812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159813
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,0L,0L,1L,1L,-1L,0L,0L,0L,0L,1L,-2L,1L,0L,3L,0L,0L,-2L,-2L,0L,0L,-1L,0L,0L,-1L,0L,2L,0L,-1L,0L,0L,0L,1L,4L,0L,2L,0L,0L,-2L,0L,0L,0L,-4L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,-1L,2L,-2L,0L,2L,0L,0L,-1L,-1L,-2L,0L,0L,0L,0L,4L,2L,-3L,0L,2L,0L,0L,2L,2L,-2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159813Inst : IEnumerable<long>
{
public static readonly long[] Value=A159813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159813.Bytes);
public long this[int i]=>Value[i];

public static A159813Inst Instance=new A159813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159814
{
public static readonly long[] Value={ 1L,-2L,0L,0L,-4L,12L,0L,0L,-3L,-20L,0L,0L,28L,-8L,0L,0L,-8L,42L,0L,0L,-72L,-20L,0L,0L,29L,36L,0L,0L,84L,-72L,0L,0L,24L,-40L,0L,0L,-68L,36L,0L,0L,-112L,24L,0L,0L,84L,248L,0L,0L,-39L,-158L,0L,0L,-12L,-144L,0L,0L,216L,-116L,0L,0L,-108L,-16L,0L,0L,80L,144L,0L,0L,48L,152L,0L,0L,-232L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159814Inst : IEnumerable<long>
{
public static readonly long[] Value=A159814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159814.Bytes);
public long this[int i]=>Value[i];

public static A159814Inst Instance=new A159814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159815
{
public static readonly long[] Value={ 7L,707L,7007L,7043L,7057L,22143L,22157L,22193L,22207L,22243L,22257L,22293L,22307L,22343L,22357L,70007L,70043L,70057L,70093L,70107L,70143L,70157L,70193L,70207L,70243L,70257L,70293L,70307L,70343L,70357L,70393L,70407L,70443L,70457L,70493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159815Inst : IEnumerable<long>
{
public static readonly long[] Value=A159815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159815.Bytes);
public long this[int i]=>Value[i];

public static A159815Inst Instance=new A159815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159816
{
public static readonly long[] Value={ 1025874L,1028574L,1042587L,1042857L,1052874L,1054287L,1072854L,1074285L,1078524L,1078542L,1085274L,1085427L,1087254L,1087425L,1087524L,1087542L,1207854L,1208754L,1240785L,1240875L,1245789L,1245879L,1247589L,1247859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159816Inst : IEnumerable<long>
{
public static readonly long[] Value=A159816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159816.Bytes);
public long this[int i]=>Value[i];

public static A159816Inst Instance=new A159816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159817
{
public static readonly long[] Value={ 1L,2L,-1L,-2L,1L,0L,2L,-2L,-6L,4L,-4L,-6L,1L,-4L,6L,4L,0L,2L,2L,4L,6L,10L,-1L,6L,-3L,-12L,-6L,0L,8L,-12L,2L,-2L,-2L,-2L,-12L,12L,2L,2L,0L,-8L,-11L,-6L,6L,12L,-6L,-4L,8L,-4L,2L,0L,6L,-14L,4L,6L,2L,4L,-6L,6L,2L,12L,-11L,12L,-1L,-2L,20L,0L,-8L,4L,18L,4L,12L,0L,-6L,-6L,-6L,-20L,-6L,-4L,-22L,-12L,12L,10L,0L,-18L,-9L,4L,-6L,-2L,-24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159817Inst : IEnumerable<long>
{
public static readonly long[] Value=A159817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159817.Bytes);
public long this[int i]=>Value[i];

public static A159817Inst Instance=new A159817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159818
{
public static readonly long[] Value={ 1L,1L,-1L,0L,0L,0L,1L,-2L,0L,0L,-2L,-1L,-1L,0L,0L,2L,0L,0L,0L,0L,1L,0L,2L,0L,0L,-2L,0L,2L,0L,0L,1L,1L,0L,0L,0L,0L,-2L,2L,0L,0L,0L,0L,1L,0L,0L,-2L,0L,0L,0L,0L,0L,-2L,0L,0L,0L,0L,-1L,-2L,0L,0L,-2L,-1L,0L,0L,0L,2L,0L,2L,0L,0L,-2L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-2L,0L,0L,1L,0L,2L,0L,0L,0L,0L,2L,0L,0L,2L,1L,-2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159818Inst : IEnumerable<long>
{
public static readonly long[] Value=A159818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159818.Bytes);
public long this[int i]=>Value[i];

public static A159818Inst Instance=new A159818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159819
{
public static readonly long[] Value={ 1L,1L,-2L,0L,1L,-4L,-2L,-2L,2L,4L,0L,8L,-1L,1L,6L,-8L,-4L,0L,6L,-2L,-6L,-4L,-2L,0L,-7L,2L,-2L,8L,4L,-4L,-2L,0L,4L,4L,8L,-8L,10L,-1L,0L,8L,1L,4L,-4L,6L,-6L,0L,-8L,-8L,2L,-4L,-18L,-16L,0L,12L,-2L,6L,18L,-16L,-2L,0L,5L,-6L,12L,8L,-4L,4L,0L,-2L,-6L,12L,0L,8L,-12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159819Inst : IEnumerable<long>
{
public static readonly long[] Value=A159819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159819.Bytes);
public long this[int i]=>Value[i];

public static A159819Inst Instance=new A159819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159820
{
public static readonly long[] Value={ 13L,1L,4L,2L,13L,3L,1L,1L,7L,3L,30L,1L,7L,1L,1L,40L,2L,6L,2L,1L,35L,4L,1L,3L,3L,1L,3L,3L,8L,1L,1L,4L,3L,5L,7L,1L,1L,1L,1L,2L,1L,2L,2L,1L,188L,3L,2L,1L,7L,1L,1L,13L,1L,7L,28L,2L,2L,47L,31L,1L,1L,1L,5L,3L,1L,7L,2L,3L,1L,3L,2L,1L,3L,4L,4L,2L,1L,1L,3L,1L,1L,1L,3L,4L,1L,19L,225L,1L,1L,16L,1L,1L,1L,1L,11L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159820Inst : IEnumerable<long>
{
public static readonly long[] Value=A159820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159820.Bytes);
public long this[int i]=>Value[i];

public static A159820Inst Instance=new A159820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159821
{
public static readonly long[] Value={ 190L,1L,12L,2L,2L,1L,12L,2L,10L,2L,1L,16L,1L,226L,2L,1L,2L,1L,2L,2L,1L,1L,9L,3L,7L,1L,1L,1L,2L,1L,1L,1L,6L,2L,2L,494L,1L,1L,60L,194L,2L,1L,2L,1L,4L,1L,1L,7L,1L,4L,7L,1L,1L,1L,5L,4L,2L,5L,2L,1L,4L,4L,1L,7L,1L,16L,4L,1L,1L,4L,2L,1L,5283L,4L,11L,1L,2L,1L,3L,1L,1L,1L,5L,1L,1L,2L,3L,3L,1L,3L,5L,3L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159821Inst : IEnumerable<long>
{
public static readonly long[] Value=A159821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159821.Bytes);
public long this[int i]=>Value[i];

public static A159821Inst Instance=new A159821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159822
{
public static readonly long[] Value={ 8L,1L,1L,5L,1L,3L,1L,4L,12L,3L,2L,1L,5L,2L,12L,1L,1L,1L,10L,2L,2L,2L,3L,8L,3L,2L,2L,2L,29L,1L,1L,13L,1L,1L,8L,11L,16L,3L,1L,4L,163L,2L,1L,1L,1L,5L,1L,6L,1L,17L,5L,1L,3L,6L,3L,1L,4L,1L,1L,1L,5L,1L,7L,15L,4L,1L,1L,1L,9L,1L,1L,4L,1L,1L,9L,1L,55L,14L,14L,1L,3L,2L,3L,7L,1L,118L,1L,2L,29L,1L,2L,2L,1L,4L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159822Inst : IEnumerable<long>
{
public static readonly long[] Value=A159822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159822.Bytes);
public long this[int i]=>Value[i];

public static A159822Inst Instance=new A159822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159823
{
public static readonly long[] Value={ 4L,2L,1L,1L,22L,1L,1L,4L,5L,2L,2L,1L,1L,15L,1L,12L,2L,2L,6L,10L,6L,1L,11L,3L,1L,3L,33L,1L,1L,1L,2L,2L,1L,4L,1L,2L,3L,3L,8L,1L,1L,1L,1L,2L,1L,3L,32L,3L,1L,1L,2L,2L,1L,5L,10L,1L,1L,1L,2L,2L,1L,1L,1L,4L,2L,2L,20L,2L,1L,2L,1L,1L,3L,1L,1L,2L,5L,1L,9L,1L,23L,1L,291L,1L,3L,2L,9L,7L,1L,1L,3L,10L,5L,2L,1L,13L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159823Inst : IEnumerable<long>
{
public static readonly long[] Value=A159823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159823.Bytes);
public long this[int i]=>Value[i];

public static A159823Inst Instance=new A159823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159824
{
public static readonly long[] Value={ 36L,2L,6L,9L,2L,1L,2L,5L,1L,1L,6L,2L,1L,291L,1L,38L,50L,1L,2L,5L,4L,1L,2L,2L,1L,5L,1L,4L,13L,2L,1L,4L,3L,3L,1L,2L,25L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,1L,43L,1L,2L,7L,3L,1L,1L,1L,2L,4L,2L,1L,1L,3L,1L,3L,3L,2L,2L,16L,3L,5L,2L,1L,5L,2L,1L,10L,1L,1L,3L,1L,13L,1L,1L,3L,1L,10L,4L,1L,1L,1L,38L,1L,2L,2L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159824Inst : IEnumerable<long>
{
public static readonly long[] Value=A159824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159824.Bytes);
public long this[int i]=>Value[i];

public static A159824Inst Instance=new A159824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159825
{
public static readonly long[] Value={ 3814279L,9L,1L,1L,4L,1L,53L,26L,1L,13L,3L,1L,1L,22L,1L,226L,1L,5L,2L,1L,6L,2L,3L,1L,4L,1L,6L,39L,2L,1L,3L,1L,5L,1L,4L,1L,3L,1L,4L,1L,1L,19L,1L,2L,8899L,5L,2L,2L,1L,3L,3L,2L,2L,2L,1L,1L,3L,5L,1L,6L,10L,2L,1L,2L,1L,1L,1L,2L,2L,4L,1L,10L,2L,6L,1L,5L,6L,2L,4L,2L,1L,2L,1L,1L,1L,3L,2L,2L,1L,1L,11L,7L,3L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159825Inst : IEnumerable<long>
{
public static readonly long[] Value=A159825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159825.Bytes);
public long this[int i]=>Value[i];

public static A159825Inst Instance=new A159825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159826
{
public static readonly BigInteger[] Value={ 1L,7L,-193L,-4739L,106945L,5335967L,-92051681L,-8392185851L,97190246657L,16927603534135L,-93187132480001L,-41617110479966707L,-43255626698004287L,BigInteger.Parse("120553299446937287119"),BigInteger.Parse("979955297720482496735"),BigInteger.Parse("-401574891442180151282027"),BigInteger.Parse("-6368261970820612522122239") };
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
public class A159826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159826Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159826.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159826.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159826Inst Instance=new A159826Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159827
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,12L,288L,4032L,47904L,398736L,2668464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159827Inst : IEnumerable<long>
{
public static readonly long[] Value=A159827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159827.Bytes);
public long this[int i]=>Value[i];

public static A159827Inst Instance=new A159827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159828
{
public static readonly long[] Value={ 1L,6L,1L,6L,9L,2L,3L,6L,1L,6L,3L,2L,3L,6L,1L,6L,27L,8L,9L,24L,1L,6L,21L,4L,69L,12L,3L,6L,21L,6L,3L,6L,1L,6L,9L,2L,9L,6L,1L,6L,15L,6L,9L,6L,1L,6L,27L,2L,3L,36L,9L,6L,3L,6L,15L,18L,1L,48L,3L,4L,9L,6L,7L,6L,15L,4L,21L,42L,5L,6L,3L,2L,69L,18L,5L,6L,3L,2L,9L,24L,1L,6L,3L,8L,9L,6L,11L,18L,15L,4L,3L,6L,7L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159828Inst : IEnumerable<long>
{
public static readonly long[] Value=A159828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159828.Bytes);
public long this[int i]=>Value[i];

public static A159828Inst Instance=new A159828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159829
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,4L,15L,2L,3L,2L,11L,10L,9L,2L,7L,14L,5L,4L,9L,2L,15L,2L,7L,16L,15L,8L,13L,2L,1L,10L,3L,4L,15L,2L,11L,10L,9L,2L,7L,6L,13L,22L,5L,2L,1L,6L,29L,10L,29L,10L,3L,2L,11L,12L,3L,8L,3L,2L,19L,6L,15L,8L,1L,2L,1L,18L,5L,2L,1L,18L,1L,12L,17L,14L,15L,26L,7L,6L,3L,2L,19L,12L,1L,18L,3L,8L,15L,2L,11L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159829Inst : IEnumerable<long>
{
public static readonly long[] Value=A159829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159829.Bytes);
public long this[int i]=>Value[i];

public static A159829Inst Instance=new A159829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159830
{
public static readonly long[] Value={ 1L,-1L,1L,2L,-2L,1L,-3L,6L,-3L,1L,7L,-12L,12L,-4L,1L,-10L,35L,-30L,20L,-5L,1L,31L,-60L,105L,-60L,30L,-6L,1L,-21L,217L,-210L,245L,-105L,42L,-7L,1L,204L,-168L,868L,-560L,490L,-168L,56L,-8L,1L,307L,1836L,-756L,2604L,-1260L,882L,-252L,72L,-9L,1L,2811L,3070L,9180L,-2520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159830Inst : IEnumerable<long>
{
public static readonly long[] Value=A159830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159830.Bytes);
public long this[int i]=>Value[i];

public static A159830Inst Instance=new A159830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159831
{
public static readonly BigInteger[] Value={ 1L,9L,-161L,-5805L,64641L,6201009L,-22406529L,-9205523829L,-44893054335L,17417856643929L,254537782136991L,-39860373039075261L,-1036322933400347391L,BigInteger.Parse("106427616904871431425"),BigInteger.Parse("4218120500621335774911"),BigInteger.Parse("-322613681568112387693701"),BigInteger.Parse("-18215300551368460352170239") };
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
public class A159831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159831Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159831.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159831.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159831Inst Instance=new A159831Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159832
{
public static readonly BigInteger[] Value={ 1L,13L,-73L,-7241L,-41135L,6474533L,133942279L,-7659772289L,-326475260383L,10585140766525L,848669947078999L,-14583331342963513L,-2448742706582821007L,10516339034389368661UL,BigInteger.Parse("7840456962356616680615"),BigInteger.Parse("66296583862124835824527"),BigInteger.Parse("-27599003183146895684913599") };
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
public class A159832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159832.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159832Inst Instance=new A159832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159833
{
public static readonly long[] Value={ 0L,4L,19L,54L,124L,250L,459L,784L,1264L,1944L,2875L,4114L,5724L,7774L,10339L,13500L,17344L,21964L,27459L,33934L,41500L,50274L,60379L,71944L,85104L,100000L,116779L,135594L,156604L,179974L,205875L,234484L,265984L,300564L,338419L,379750L,424764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159833Inst : IEnumerable<long>
{
public static readonly long[] Value=A159833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159833.Bytes);
public long this[int i]=>Value[i];

public static A159833Inst Instance=new A159833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159834
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-2L,1L,2L,0L,-3L,1L,-2L,8L,0L,-4L,1L,-6L,-10L,20L,0L,-5L,1L,16L,-36L,-30L,40L,0L,-6L,1L,20L,112L,-126L,-70L,70L,0L,-7L,1L,-132L,160L,448L,-336L,-140L,112L,0L,-8L,1L,-28L,-1188L,720L,1344L,-756L,-252L,168L,0L,-9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159834Inst : IEnumerable<long>
{
public static readonly long[] Value=A159834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159834.Bytes);
public long this[int i]=>Value[i];

public static A159834Inst Instance=new A159834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159835
{
public static readonly long[] Value={ 1L,4L,4L,4L,4L,6L,11L,11L,11L,14L,61L,266L,1006L,1030L,1261L,6264L,7583L,7979L,7986L,12386L,80041L,87434L,130927L,270073L,1653819L,1715177L,1973657L,3483485L,12346987L,17531499L,21237674L,84101406L,95403456L,664784809L,14591838849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159835Inst : IEnumerable<long>
{
public static readonly long[] Value=A159835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159835.Bytes);
public long this[int i]=>Value[i];

public static A159835Inst Instance=new A159835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159836
{
public static readonly long[] Value={ 8L,9L,18L,24L,25L,32L,36L,40L,45L,49L,50L,56L,63L,64L,75L,81L,88L,90L,96L,98L,99L,100L,104L,117L,120L,121L,125L,126L,128L,136L,144L,147L,150L,152L,153L,160L,162L,168L,169L,171L,175L,180L,184L,192L,196L,198L,200L,207L,216L,224L,225L,232L,234L,242L,243L,245L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159836Inst : IEnumerable<long>
{
public static readonly long[] Value=A159836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159836.Bytes);
public long this[int i]=>Value[i];

public static A159836Inst Instance=new A159836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159837
{
public static readonly long[] Value={ 10348965L,100348965L,103489650L,103489965L,103498965L,1000348965L,1003489650L,1003489965L,1003498965L,1023748965L,1032890967L,1032896709L,1032908967L,1032967089L,1034896500L,1034897625L,1034899650L,1034899965L,1034989650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159837Inst : IEnumerable<long>
{
public static readonly long[] Value=A159837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159837.Bytes);
public long this[int i]=>Value[i];

public static A159837Inst Instance=new A159837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159838
{
public static readonly long[] Value={ 10L,66L,70L,78L,114L,130L,154L,174L,222L,238L,282L,310L,318L,370L,390L,418L,474L,510L,574L,618L,642L,670L,678L,690L,742L,754L,790L,798L,814L,822L,870L,874L,930L,978L,1090L,1122L,1162L,1182L,1218L,1230L,1374L,1378L,1398L,1434L,1498L,1542L,1554L,1570L,1578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159838Inst : IEnumerable<long>
{
public static readonly long[] Value=A159838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159838.Bytes);
public long this[int i]=>Value[i];

public static A159838Inst Instance=new A159838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159839
{
public static readonly long[] Value={ 1L,10L,13L,19L,23L,28L,31L,32L,44L,49L,68L,79L,82L,86L,91L,94L,97L,100L,103L,109L,129L,130L,133L,139L,167L,176L,188L,190L,192L,193L,203L,208L,219L,226L,230L,239L,236L,262L,263L,277L,280L,291L,293L,301L,302L,310L,313L,319L,320L,326L,329L,331L,338L,362L,367L,368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159839Inst : IEnumerable<long>
{
public static readonly long[] Value=A159839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159839.Bytes);
public long this[int i]=>Value[i];

public static A159839Inst Instance=new A159839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159840
{
public static readonly BigInteger[] Value={ 1L,15L,-17L,-7515L,-100383L,5768775L,207995055L,-5256335475L,-431188655295L,3708435650175L,994755425985135L,5946917116353525L,-2558835187227126495L,BigInteger.Parse("-55652375114297534025"),BigInteger.Parse("7215309872302076942895"),BigInteger.Parse("296779894971771199420125"),BigInteger.Parse("-21739876411879971311406975") };
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
public class A159840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159840.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159840Inst Instance=new A159840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159841
{
public static readonly long[] Value={ 1L,4L,1L,21L,7L,1L,120L,45L,10L,1L,715L,286L,78L,13L,1L,4368L,1820L,560L,120L,16L,1L,27132L,11628L,3876L,969L,171L,19L,1L,170544L,74613L,26334L,7315L,1540L,231L,22L,1L,1081575L,480700L,177100L,53130L,12650L,2300L,300L,25L,1L,6906900L,3108105L,1184040L,376740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159841Inst : IEnumerable<long>
{
public static readonly long[] Value=A159841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159841.Bytes);
public long this[int i]=>Value[i];

public static A159841Inst Instance=new A159841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159842
{
public static readonly long[] Value={ 1L,2L,3L,7L,5L,10L,7L,20L,14L,18L,11L,41L,15L,28L,31L,58L,21L,60L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159842Inst : IEnumerable<long>
{
public static readonly long[] Value=A159842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159842.Bytes);
public long this[int i]=>Value[i];

public static A159842Inst Instance=new A159842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159843
{
public static readonly long[] Value={ 1L,2L,6L,7L,8L,9L,12L,13L,15L,16L,17L,19L,20L,22L,26L,27L,28L,30L,31L,33L,34L,35L,37L,42L,43L,48L,49L,50L,51L,53L,54L,56L,58L,61L,62L,63L,64L,65L,67L,68L,69L,70L,71L,72L,75L,78L,79L,84L,85L,86L,87L,89L,90L,91L,92L,94L,96L,97L,98L,103L,104L,105L,106L,107L,110L,114L,115L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159843Inst : IEnumerable<long>
{
public static readonly long[] Value=A159843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159843.Bytes);
public long this[int i]=>Value[i];

public static A159843Inst Instance=new A159843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159844
{
public static readonly long[] Value={ 325L,359L,401L,1549L,1795L,2081L,8969L,10411L,12085L,52265L,60671L,70429L,304621L,353615L,410489L,1775461L,2061019L,2392505L,10348145L,12012499L,13944541L,60313409L,70013975L,81274741L,351532309L,408071351L,473703905L,2048880445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159844Inst : IEnumerable<long>
{
public static readonly long[] Value=A159844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159844.Bytes);
public long this[int i]=>Value[i];

public static A159844Inst Instance=new A159844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159845
{
public static readonly long[] Value={ 1L,1L,6L,0L,8L,3L,5L,9L,7L,5L,9L,6L,1L,4L,9L,7L,5L,2L,6L,0L,5L,7L,0L,0L,3L,2L,6L,3L,2L,8L,6L,8L,2L,0L,4L,0L,9L,4L,3L,0L,7L,7L,3L,0L,6L,7L,5L,8L,8L,6L,4L,6L,3L,1L,4L,1L,5L,2L,4L,0L,6L,2L,1L,1L,8L,2L,0L,7L,4L,6L,0L,5L,6L,2L,1L,6L,0L,4L,4L,7L,5L,6L,2L,0L,1L,4L,3L,3L,7L,7L,8L,0L,0L,6L,8L,2L,5L,5L,7L,0L,3L,7L,3L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159845Inst : IEnumerable<long>
{
public static readonly long[] Value=A159845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159845.Bytes);
public long this[int i]=>Value[i];

public static A159845Inst Instance=new A159845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159846
{
public static readonly long[] Value={ 4L,3L,2L,5L,2L,3L,4L,4L,4L,1L,5L,4L,4L,5L,3L,2L,4L,0L,8L,6L,0L,9L,1L,4L,3L,5L,6L,2L,6L,7L,6L,5L,7L,1L,2L,2L,8L,9L,4L,1L,2L,1L,1L,5L,6L,9L,9L,8L,7L,5L,8L,2L,8L,3L,2L,6L,2L,1L,6L,4L,0L,1L,5L,7L,3L,7L,1L,3L,0L,4L,8L,7L,7L,0L,3L,4L,6L,7L,5L,9L,2L,6L,6L,1L,0L,9L,0L,3L,0L,3L,8L,6L,8L,5L,4L,6L,5L,9L,3L,6L,7L,4L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159846Inst : IEnumerable<long>
{
public static readonly long[] Value=A159846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159846.Bytes);
public long this[int i]=>Value[i];

public static A159846Inst Instance=new A159846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159847
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,3L,7L,1L,4L,1L,22L,14L,15L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159847Inst : IEnumerable<long>
{
public static readonly long[] Value=A159847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159847.Bytes);
public long this[int i]=>Value[i];

public static A159847Inst Instance=new A159847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159848
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,13L,19L,28L,34L,38L,57L,85L,87L,90L,103L,122L,135L,139L,173L,186L,199L,205L,243L,300L,309L,347L,520L,524L,530L,539L,552L,586L,595L,614L,652L,658L,667L,705L,711L,910L,1109L,1194L,1279L,1298L,1332L,1370L,1543L,1549L,1562L,1575L,1609L,1618L,1627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159848Inst : IEnumerable<long>
{
public static readonly long[] Value=A159848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159848.Bytes);
public long this[int i]=>Value[i];

public static A159848Inst Instance=new A159848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159849
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,9L,6L,4L,19L,28L,2L,3L,13L,19L,13L,4L,34L,13L,13L,6L,38L,57L,9L,38L,173L,4L,6L,9L,13L,34L,9L,19L,38L,6L,9L,38L,6L,199L,199L,85L,85L,19L,34L,38L,173L,6L,13L,13L,34L,9L,9L,13L,205L,309L,13L,135L,6L,9L,13L,13L,19L,19L,595L,186L,139L,103L,38L,87L,57L,28L,135L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159849Inst : IEnumerable<long>
{
public static readonly long[] Value=A159849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159849.Bytes);
public long this[int i]=>Value[i];

public static A159849Inst Instance=new A159849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159850
{
public static readonly BigInteger[] Value={ 1L,17L,47L,-7429L,-160415L,4464217L,269993839L,-1892147821L,-489536076223L,-4658915114335L,987008017069999L,28053710866880683L,-2150502256703365727L,BigInteger.Parse("-118026514721378720791"),BigInteger.Parse("4759029349325350323695"),BigInteger.Parse("480777330814562061542723"),BigInteger.Parse("-9102061914203466628786559") };
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
public class A159850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159850Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159850.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159850.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159850Inst Instance=new A159850Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159851
{
public static readonly BigInteger[] Value={ 1L,19L,119L,-6935L,-218159L,2568059L,312765511L,2213723041L,-487764037855L,-13553284526621L,804837668442391L,48090864254828249L,-1228751452551908111L,BigInteger.Parse("-163002147394507489205"),BigInteger.Parse("768611269232660622311"),BigInteger.Parse("566854889488011925250449"),BigInteger.Parse("7980183992957668520769601") };
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
public class A159851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159851Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159851.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159851.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159851Inst Instance=new A159851Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159852
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,49L,4L,21L,40L,1L,24L,49L,16L,45L,16L,49L,24L,1L,40L,21L,4L,49L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,49L,4L,21L,40L,1L,24L,49L,16L,45L,16L,49L,24L,1L,40L,21L,4L,49L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,49L,4L,21L,40L,1L,24L,49L,16L,45L,16L,49L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159852Inst : IEnumerable<long>
{
public static readonly long[] Value=A159852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159852.Bytes);
public long this[int i]=>Value[i];

public static A159852Inst Instance=new A159852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159853
{
public static readonly long[] Value={ 1L,-1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,3L,4L,4L,3L,1L,1L,4L,7L,8L,7L,4L,1L,1L,5L,11L,15L,15L,11L,5L,1L,1L,6L,16L,26L,30L,26L,16L,6L,1L,1L,7L,22L,42L,56L,56L,42L,22L,7L,1L,1L,8L,29L,64L,98L,112L,98L,64L,29L,8L,1L,1L,9L,37L,93L,162L,210L,210L,162L,93L,37L,9L,1L,1L,10L,46L,130L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159853Inst : IEnumerable<long>
{
public static readonly long[] Value=A159853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159853.Bytes);
public long this[int i]=>Value[i];

public static A159853Inst Instance=new A159853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159854
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,0L,1L,3L,3L,1L,0L,0L,1L,4L,6L,4L,1L,0L,0L,1L,5L,10L,10L,5L,1L,0L,0L,1L,6L,15L,20L,15L,6L,1L,0L,0L,1L,7L,21L,35L,35L,21L,7L,1L,0L,0L,1L,8L,28L,56L,70L,56L,28L,8L,1L,0L,0L,1L,9L,36L,84L,126L,126L,84L,36L,9L,1L,0L,0L,1L,10L,45L,120L,210L,252L,210L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159854Inst : IEnumerable<long>
{
public static readonly long[] Value=A159854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159854.Bytes);
public long this[int i]=>Value[i];

public static A159854Inst Instance=new A159854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159855
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,0L,1L,-2L,-2L,1L,1L,-2L,-4L,-1L,2L,1L,-2L,-6L,-5L,1L,3L,1L,-2L,-8L,-11L,-4L,4L,4L,1L,-2L,-10L,-19L,-15L,0L,8L,5L,1L,-2L,-12L,-29L,-34L,-15L,8L,13L,6L,1L,-2L,-14L,-41L,-63L,-49L,-7L,21L,19L,7L,1L,-2L,-16L,-55L,-104L,-112L,-56L,14L,34L,20L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159855Inst : IEnumerable<long>
{
public static readonly long[] Value=A159855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159855.Bytes);
public long this[int i]=>Value[i];

public static A159855Inst Instance=new A159855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159856
{
public static readonly long[] Value={ 1L,2L,-1L,3L,-4L,1L,4L,-11L,6L,-1L,5L,-26L,23L,-8L,1L,6L,-57L,72L,-39L,10L,-1L,7L,-120L,201L,-150L,59L,-12L,1L,8L,-247L,522L,-501L,268L,-83L,14L,-1L,9L,-502L,1291L,-1524L,1037L,434L,111L,-16L,1L,10L,-1013L,3084L,-4339L,3598L,-1905L,656L,-143L,18L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159856Inst : IEnumerable<long>
{
public static readonly long[] Value=A159856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159856.Bytes);
public long this[int i]=>Value[i];

public static A159856Inst Instance=new A159856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159857
{
public static readonly BigInteger[] Value={ 1L,21L,199L,-5985L,-270159L,120141L,329415351L,6743277639L,-416420774175L,-21799821766779L,449168189050791L,62188100645671791L,110264394305901969L,BigInteger.Parse("-178278691994606939715"),BigInteger.Parse("-4090744316373113328489"),BigInteger.Parse("518102577833892931856151"),BigInteger.Parse("25729556002946152951394241") };
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
public class A159857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159857Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159857.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159857.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159857Inst Instance=new A159857Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159858
{
public static readonly BigInteger[] Value={ 1L,2L,-1054L,-6340L,3332716L,33496312L,-17563075016L,-247760738608L,129576612091280L,2356200115760672L,-1229116100101646816L,BigInteger.Parse("-27386829424951203392"),BigInteger.Parse("14249679514133063237824"),BigInteger.Parse("376202545407446604740480"),BigInteger.Parse("-195237686946571258563550336"),BigInteger.Parse("-5962787476468241626543090432") };
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
public class A159858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159858Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159858.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159858.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159858Inst Instance=new A159858Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159859
{
public static readonly BigInteger[] Value={ 1L,4L,-1042L,-12632L,3256780L,66485744L,-16962423224L,-489901195808L,123664101613712L,4641180127773760L,-1158964855054670624L,BigInteger.Parse("-53739545172065063296"),BigInteger.Parse("13273074802437996468928"),BigInteger.Parse("735369564714290029481728"),BigInteger.Parse("-179616392573875043315708800"),BigInteger.Parse("-11610759562843564089946190336") };
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
public class A159859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159859Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159859.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159859.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159859Inst Instance=new A159859Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159860
{
public static readonly BigInteger[] Value={ 2L,4L,10L,40L,460L,53590L,718052410L,128899816953780640L,BigInteger.Parse("4313494300416744426870901874924164733839903365825579313972159982440"),BigInteger.Parse("4651558269931934854975620016004337876013135072223108603058097397593938231557041644242694327255059535060293888049465758695393517062060") };
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
public class A159860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159860Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159860.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159860.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159860Inst Instance=new A159860Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159861
{
public static readonly BigInteger[] Value={ 1L,1L,1L,11L,1L,1L,1111L,6L,1L,1L,11111111L,58L,4L,1L,1L,1111111111111111L,5829L,38L,3L,1L,1L,BigInteger.Parse("11111111111111111111111111111111"),58292915L,3813L,29L,3L,1L,1L,BigInteger.Parse("1111111111111111111111111111111111111111111111111111111111111111") };
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
public class A159861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159861Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159861.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159861.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159861Inst Instance=new A159861Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159862
{
public static readonly BigInteger[] Value={ 1L,1L,4L,29L,2265L,18698645L,1602308616574727L,BigInteger.Parse("14017675267522095175220940844027"),BigInteger.Parse("1245902734717669791621141496863001384336371908521990690157218737") };
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
public class A159862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159862Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159862.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159862.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159862Inst Instance=new A159862Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159863
{
public static readonly BigInteger[] Value={ 10113L,101343L,1020412245351433L,1023L,10262054413L,103L,BigInteger.Parse("1034482758620689655172413793"),2076L };
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
public class A159863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159863Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159863.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159863.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159863Inst Instance=new A159863Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}