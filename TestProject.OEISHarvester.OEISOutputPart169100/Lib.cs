using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A199557
{
public static readonly long[] Value={ 11L,81L,641L,5121L,40961L,327681L,2621441L,20971521L,167772161L,1342177281L,10737418241L,85899345921L,687194767361L,5497558138881L,43980465111041L,351843720888321L,2814749767106561L,22517998136852481L,180143985094819841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199557Inst : IEnumerable<long>
{
public static readonly long[] Value=A199557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199557.Bytes);
public long this[int i]=>Value[i];

public static A199557Inst Instance=new A199557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199558
{
public static readonly long[] Value={ 12L,89L,705L,5633L,45057L,360449L,2883585L,23068673L,184549377L,1476395009L,11811160065L,94489280513L,755914244097L,6047313952769L,48378511622145L,387028092977153L,3096224743817217L,24769797950537729L,198158383604301825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199558Inst : IEnumerable<long>
{
public static readonly long[] Value=A199558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199558.Bytes);
public long this[int i]=>Value[i];

public static A199558Inst Instance=new A199558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199559
{
public static readonly long[] Value={ 3L,19L,163L,1459L,13123L,118099L,1062883L,9565939L,86093443L,774840979L,6973568803L,62762119219L,564859072963L,5083731656659L,45753584909923L,411782264189299L,3706040377703683L,33354363399333139L,300189270593998243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199559Inst : IEnumerable<long>
{
public static readonly long[] Value=A199559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199559.Bytes);
public long this[int i]=>Value[i];

public static A199559Inst Instance=new A199559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199560
{
public static readonly long[] Value={ 2L,14L,122L,1094L,9842L,88574L,797162L,7174454L,64570082L,581130734L,5230176602L,47071589414L,423644304722L,3812798742494L,34315188682442L,308836698141974L,2779530283277762L,25015772549499854L,225141952945498682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199560Inst : IEnumerable<long>
{
public static readonly long[] Value=A199560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199560.Bytes);
public long this[int i]=>Value[i];

public static A199560Inst Instance=new A199560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199561
{
public static readonly long[] Value={ 4L,28L,244L,2188L,19684L,177148L,1594324L,14348908L,129140164L,1162261468L,10460353204L,94143178828L,847288609444L,7625597484988L,68630377364884L,617673396283948L,5559060566555524L,50031545098999708L,450283905890997364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199561Inst : IEnumerable<long>
{
public static readonly long[] Value=A199561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199561.Bytes);
public long this[int i]=>Value[i];

public static A199561Inst Instance=new A199561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199562
{
public static readonly long[] Value={ 5L,37L,325L,2917L,26245L,236197L,2125765L,19131877L,172186885L,1549681957L,13947137605L,125524238437L,1129718145925L,10167463313317L,91507169819845L,823564528378597L,7412080755407365L,66708726798666277L,600378541187996485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199562Inst : IEnumerable<long>
{
public static readonly long[] Value=A199562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199562.Bytes);
public long this[int i]=>Value[i];

public static A199562Inst Instance=new A199562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199563
{
public static readonly long[] Value={ 6L,46L,406L,3646L,32806L,295246L,2657206L,23914846L,215233606L,1937102446L,17433922006L,156905298046L,1412147682406L,12709329141646L,114383962274806L,1029455660473246L,9265100944259206L,83385908498332846L,750473176484995606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199563Inst : IEnumerable<long>
{
public static readonly long[] Value=A199563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199563.Bytes);
public long this[int i]=>Value[i];

public static A199563Inst Instance=new A199563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199564
{
public static readonly long[] Value={ 7L,55L,487L,4375L,39367L,354295L,3188647L,28697815L,258280327L,2324522935L,20920706407L,188286357655L,1694577218887L,15251194969975L,137260754729767L,1235346792567895L,11118121133111047L,100063090197999415L,900567811781994727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199564Inst : IEnumerable<long>
{
public static readonly long[] Value=A199564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199564.Bytes);
public long this[int i]=>Value[i];

public static A199564Inst Instance=new A199564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199565
{
public static readonly long[] Value={ 2L,16L,142L,1276L,11482L,103336L,930022L,8370196L,75331762L,677985856L,6101872702L,54916854316L,494251688842L,4448265199576L,40034386796182L,360309481165636L,3242785330490722L,29185067974416496L,262665611769748462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199565Inst : IEnumerable<long>
{
public static readonly long[] Value=A199565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199565.Bytes);
public long this[int i]=>Value[i];

public static A199565Inst Instance=new A199565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199566
{
public static readonly long[] Value={ 4L,32L,284L,2552L,22964L,206672L,1860044L,16740392L,150663524L,1355971712L,12203745404L,109833708632L,988503377684L,8896530399152L,80068773592364L,720618962331272L,6485570660981444L,58370135948832992L,525331223539496924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199566Inst : IEnumerable<long>
{
public static readonly long[] Value=A199566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199566.Bytes);
public long this[int i]=>Value[i];

public static A199566Inst Instance=new A199566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199567
{
public static readonly long[] Value={ 8L,64L,568L,5104L,45928L,413344L,3720088L,33480784L,301327048L,2711943424L,24407490808L,219667417264L,1977006755368L,17793060798304L,160137547184728L,1441237924662544L,12971141321962888L,116740271897665984L,1050662447078993848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199567Inst : IEnumerable<long>
{
public static readonly long[] Value=A199567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199567.Bytes);
public long this[int i]=>Value[i];

public static A199567Inst Instance=new A199567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199568
{
public static readonly long[] Value={ 1L,0L,1L,-6L,0L,1L,0L,-48L,0L,1L,280L,0L,-200L,0L,1L,0L,8640L,0L,-600L,0L,1L,-52080L,0L,99960L,0L,-1470L,0L,1L,0L,-4300800L,0L,689920L,0L,-3136L,0L,1L,27651456L,0L,-110557440L,0L,3429216L,0L,-6048L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199568Inst : IEnumerable<long>
{
public static readonly long[] Value=A199568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199568.Bytes);
public long this[int i]=>Value[i];

public static A199568Inst Instance=new A199568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199569
{
public static readonly BigInteger[] Value={ 1L,1L,4L,30L,384L,7480L,207360L,7780080L,380190720L,23481311616L,1789201612800L,164904696633600L,18084647927808000L,2327418985883397120L,BigInteger.Parse("347368297708734382080"),BigInteger.Parse("59514548453599599360000"),BigInteger.Parse("11601363342443780505600000"),BigInteger.Parse("2552998389393196650531225600") };
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
public class A199569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199569Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199569.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199569.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199569Inst Instance=new A199569Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199570
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,3L,2L,3L,1L,4L,1L,4L,2L,4L,1L,4L,3L,4L,1L,4L,3L,4L,2L,4L,3L,4L,1L,5L,1L,5L,2L,5L,1L,5L,3L,5L,1L,5L,3L,5L,2L,5L,3L,5L,1L,5L,4L,5L,1L,5L,4L,5L,2L,5L,4L,5L,1L,5L,4L,5L,3L,5L,4L,5L,1L,5L,4L,5L,3L,5L,4L,5L,2L,5L,4L,5L,3L,5L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199570Inst : IEnumerable<long>
{
public static readonly long[] Value=A199570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199570.Bytes);
public long this[int i]=>Value[i];

public static A199570Inst Instance=new A199570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199571
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,4L,0L,1L,0L,0L,2L,0L,1L,0L,16L,2L,2L,0L,1L,0L,0L,6L,0L,2L,0L,1L,0L,64L,10L,8L,0L,2L,0L,1L,0L,0L,22L,0L,6L,0L,2L,0L,1L,0L,256L,42L,32L,2L,6L,0L,2L,0L,1L,0L,0L,86L,0L,20L,0L,6L,0L,2L,0L,1L,0L,1024L,170L,128L,14L,22L,0L,6L,0L,2L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199571Inst : IEnumerable<long>
{
public static readonly long[] Value=A199571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199571.Bytes);
public long this[int i]=>Value[i];

public static A199571Inst Instance=new A199571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199572
{
public static readonly long[] Value={ 1L,0L,4L,0L,16L,0L,64L,0L,256L,0L,1024L,0L,4096L,0L,16384L,0L,65536L,0L,262144L,0L,1048576L,0L,4194304L,0L,16777216L,0L,67108864L,0L,268435456L,0L,1073741824L,0L,4294967296L,0L,17179869184L,0L,68719476736L,0L,274877906944L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199572Inst : IEnumerable<long>
{
public static readonly long[] Value=A199572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199572.Bytes);
public long this[int i]=>Value[i];

public static A199572Inst Instance=new A199572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199573
{
public static readonly long[] Value={ 1L,0L,2L,0L,8L,0L,32L,0L,128L,0L,512L,0L,2048L,0L,8192L,0L,32768L,0L,131072L,0L,524288L,0L,2097152L,0L,8388608L,0L,33554432L,0L,134217728L,0L,536870912L,0L,2147483648L,0L,8589934592L,0L,34359738368L,0L,137438953472L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199573Inst : IEnumerable<long>
{
public static readonly long[] Value=A199573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199573.Bytes);
public long this[int i]=>Value[i];

public static A199573Inst Instance=new A199573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199574
{
public static readonly BigInteger[] Value={ 1L,2L,6L,40L,544L,16640L,1050624L,134250496L,34360262656L,17592202821632L,18014399046352896L,BigInteger.Parse("36893488181778841600"),BigInteger.Parse("151115727454027670093824"),BigInteger.Parse("1237940039285661749875834880"),BigInteger.Parse("20282409603651706452744270249984") };
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
public class A199574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199574Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199574.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199574.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199574Inst Instance=new A199574Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199575
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,16L,18L,21L,23L,26L,30L,34L,38L,43L,48L,55L,62L,70L,79L,89L,100L,113L,127L,144L,162L,183L,207L,233L,263L,296L,334L,377L,426L,480L,541L,611L,689L,777L,876L,989L,1115L,1258L,1418L,1600L,1804L,2035L,2295L,2589L,2920L,3293L,3714L,4189L,4725L,5329L,6010L,6778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199575Inst : IEnumerable<long>
{
public static readonly long[] Value=A199575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199575.Bytes);
public long this[int i]=>Value[i];

public static A199575Inst Instance=new A199575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199576
{
public static readonly BigInteger[] Value={ 1L,2L,8L,54L,528L,7690L,159360L,4158014L,124676608L,4135694994L,150596213760L,6039479167942L,267570859708416L,13065427748191130L,697795440530685952L,BigInteger.Parse("40363581479632997070"),BigInteger.Parse("2506569447568159211520"),BigInteger.Parse("166039728985388864259874"),BigInteger.Parse("11683091140202632175419392") };
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
public class A199576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199576.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199576Inst Instance=new A199576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199577
{
public static readonly long[] Value={ 1L,-3L,1L,11L,-8L,1L,-50L,58L,-15L,1L,274L,-444L,177L,-24L,1L,-1764L,3708L,-2016L,416L,-35L,1L,13068L,-33984L,23544L,-6560L,835L,-48L,1L,-109584L,341136L,-288360L,101560L,-17370L,1506L,-63L,1L,1026576L,-3733920L,3736440L,-1595040L,343410L,-39900L,2513L,-80L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199577Inst : IEnumerable<long>
{
public static readonly long[] Value=A199577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199577.Bytes);
public long this[int i]=>Value[i];

public static A199577Inst Instance=new A199577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199578
{
public static readonly BigInteger[] Value={ 1L,-2L,4L,-6L,-16L,310L,-3144L,28826L,-260000L,2345094L,-20901880L,176084986L,-1216168944L,1862029910L,186232275544L,-6005924996070L,144514137334976L,-3177768345524954L,67577079942366120L,-1420754665075404166L,BigInteger.Parse("29799354626069718640") };
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
public class A199578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199578Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199578.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199578.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199578Inst Instance=new A199578Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199579
{
public static readonly long[] Value={ 1L,4L,28L,232L,2056L,18784L,174112L,1625152L,15220288L,142777600L,1340416768L,12588825088L,118252556800L,1110898849792L,10436554713088L,98050271875072L,921180638875648L,8654518327066624L,81309636020912128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199579Inst : IEnumerable<long>
{
public static readonly long[] Value=A199579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199579.Bytes);
public long this[int i]=>Value[i];

public static A199579Inst Instance=new A199579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199580
{
public static readonly long[] Value={ 0L,2L,1L,-3L,0L,1L,8L,-4L,-4L,1L,-30L,30L,15L,-10L,1L,144L,-216L,-48L,84L,-18L,1L,-840L,1680L,0L,-700L,245L,-28L,1L,5760L,-14400L,2880L,6000L,-3120L,552L,-40L,1L,-45360L,136080L,-52920L,-52920L,39690L,-9702L,1071L,-54L,1L,403200L,-1411200L,806400L,470400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199580Inst : IEnumerable<long>
{
public static readonly long[] Value=A199580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199580.Bytes);
public long this[int i]=>Value[i];

public static A199580Inst Instance=new A199580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199581
{
public static readonly long[] Value={ 1L,2L,7L,29L,107L,431L,1619L,6079L,22937L,87083L,332393L,1273541L,4896103L,18877711L,72968563L,282664351L,1097088989L,4265342057L,16608401041L,64758466127L,252814859149L,988089813541L,3865761355523L,15138431958437L,59333638261529L,232737382916429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199581Inst : IEnumerable<long>
{
public static readonly long[] Value=A199581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199581.Bytes);
public long this[int i]=>Value[i];

public static A199581Inst Instance=new A199581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199582
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,13L,29L,53L,107L,211L,431L,809L,1619L,3037L,6079L,11467L,22937L,43541L,87083L,166183L,332393L,636761L,1273541L,2448049L,4896103L,9438851L,18877711L,36484271L,72968563L,141332173L,282664351L,548544487L,1097088989L,2132671027L,4265342057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199582Inst : IEnumerable<long>
{
public static readonly long[] Value=A199582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199582.Bytes);
public long this[int i]=>Value[i];

public static A199582Inst Instance=new A199582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199583
{
public static readonly BigInteger[] Value={ 2L,2L,3L,2L,5L,70L,7L,2L,3L,33L,11L,1155L,13L,78L,26L,2L,17L,2156564410L,19L,6006L,26L,114L,23L,2156564410L,5L,33L,3L,1365L,29L,110L,31L,2L,62L,15L,201L,2156564410L,37L,30L,14L,BigInteger.Parse("961380175077106319535"),41L,1385670L,43L,2805L,26L,266L,47L,BigInteger.Parse("961380175077106319535") };
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
public class A199583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199583Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199583.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199583.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199583Inst Instance=new A199583Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199584
{
public static readonly long[] Value={ 0L,0L,0L,5L,35L,11L,495L,2645L,40637L,30867L,1260454L,2631033L,66043942L,64295478L,2600316008L,3797601337L,124025248853L,133588278925L,5375377028818L,6829626340182L,252066556346402L,284362587554599L,11455309274558540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199584Inst : IEnumerable<long>
{
public static readonly long[] Value=A199584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199584.Bytes);
public long this[int i]=>Value[i];

public static A199584Inst Instance=new A199584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199585
{
public static readonly BigInteger[] Value={ 0L,0L,20L,23L,1951L,60323L,592219L,3399003L,220861580L,6086397307L,79879768821L,386032959689L,29317433209618L,852122544867919L,11206152487777257L,56509336646678083L,4391723268352660596L,BigInteger.Parse("130483481066218119340") };
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
public class A199585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199585.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199585Inst Instance=new A199585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199586
{
public static readonly long[] Value={ 0L,5L,23L,2943L,69023L,4748991L,207722398L,12106398432L,637249804809L,36336881030430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199586Inst : IEnumerable<long>
{
public static readonly long[] Value=A199586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199586.Bytes);
public long this[int i]=>Value[i];

public static A199586Inst Instance=new A199586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199587
{
public static readonly long[] Value={ 0L,35L,1951L,69023L,46969504L,10056342898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199587Inst : IEnumerable<long>
{
public static readonly long[] Value=A199587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199587.Bytes);
public long this[int i]=>Value[i];

public static A199587Inst Instance=new A199587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199588
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,5L,20L,5L,0L,0L,35L,23L,23L,35L,0L,0L,11L,1951L,2943L,1951L,11L,0L,1L,495L,60323L,69023L,69023L,60323L,495L,1L,4L,2645L,592219L,4748991L,46969504L,4748991L,592219L,2645L,4L,6L,40637L,3399003L,207722398L,10056342898L,10056342898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199588Inst : IEnumerable<long>
{
public static readonly long[] Value=A199588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199588.Bytes);
public long this[int i]=>Value[i];

public static A199588Inst Instance=new A199588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199589
{
public static readonly long[] Value={ 1L,1L,3L,7L,1L,5L,8L,0L,4L,2L,6L,0L,3L,2L,5L,7L,6L,1L,2L,8L,3L,7L,6L,6L,7L,9L,5L,1L,9L,2L,0L,0L,9L,8L,7L,6L,2L,5L,8L,1L,3L,6L,0L,3L,9L,4L,2L,2L,9L,9L,0L,6L,5L,8L,5L,9L,6L,2L,8L,8L,7L,9L,6L,4L,9L,4L,4L,2L,5L,1L,0L,6L,6L,5L,6L,8L,5L,0L,9L,4L,5L,4L,9L,8L,5L,3L,1L,6L,7L,7L,7L,6L,7L,8L,9L,9L,7L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199589Inst : IEnumerable<long>
{
public static readonly long[] Value=A199589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199589.Bytes);
public long this[int i]=>Value[i];

public static A199589Inst Instance=new A199589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199590
{
public static readonly long[] Value={ 2L,5L,7L,7L,7L,2L,8L,0L,1L,0L,3L,1L,4L,4L,0L,8L,4L,4L,7L,2L,9L,4L,4L,9L,3L,9L,7L,2L,7L,0L,6L,3L,5L,8L,2L,2L,7L,0L,8L,9L,4L,4L,1L,2L,5L,7L,0L,0L,9L,7L,7L,3L,1L,9L,7L,8L,2L,3L,1L,4L,6L,3L,9L,3L,9L,5L,8L,0L,8L,6L,4L,4L,5L,7L,6L,7L,3L,0L,5L,3L,7L,0L,8L,5L,8L,2L,4L,9L,9L,8L,0L,0L,3L,1L,0L,1L,5L,7L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199590Inst : IEnumerable<long>
{
public static readonly long[] Value=A199590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199590.Bytes);
public long this[int i]=>Value[i];

public static A199590Inst Instance=new A199590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199591
{
public static readonly BigInteger[] Value={ 6L,26L,626L,390626L,152587890626L,BigInteger.Parse("23283064365386962890626"),BigInteger.Parse("542101086242752217003726400434970855712890626") };
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
public class A199591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199591Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199591.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199591.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199591Inst Instance=new A199591Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199592
{
public static readonly BigInteger[] Value={ 12L,122L,14642L,214358882L,45949729863572162L,BigInteger.Parse("2111377674535255285545615254209922"),BigInteger.Parse("4457915684525902395869512133369841539490161434991526715513934826242") };
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
public class A199592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199592.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199592Inst Instance=new A199592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199593
{
public static readonly long[] Value={ 9L,12L,17L,19L,22L,26L,29L,31L,32L,39L,40L,41L,42L,45L,48L,49L,52L,54L,57L,59L,62L,63L,68L,69L,70L,72L,73L,74L,79L,82L,83L,85L,87L,89L,92L,96L,97L,99L,100L,101L,102L,107L,108L,109L,110L,112L,114L,115L,119L,121L,122L,124L,126L,129L,131L,132L,135L,136L,138L,139L,142L,143L,146L,149L,151L,152L,157L,158L,159L,161L,162L,165L,166L,169L,171L,172L,173L,176L,177L,178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199593Inst : IEnumerable<long>
{
public static readonly long[] Value=A199593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199593.Bytes);
public long this[int i]=>Value[i];

public static A199593Inst Instance=new A199593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199594
{
public static readonly long[] Value={ 0L,0L,0L,2L,3L,5L,10L,18L,31L,56L,100L,177L,315L,561L,997L,1773L,3154L,5609L,9975L,17741L,31552L,56114L,99798L,177489L,315660L,561395L,998430L,1775687L,3158023L,5616480L,9988795L,17764868L,31594456L,56190096L,99932940L,177728697L,316086865L,562154046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199594Inst : IEnumerable<long>
{
public static readonly long[] Value=A199594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199594.Bytes);
public long this[int i]=>Value[i];

public static A199594Inst Instance=new A199594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199595
{
public static readonly long[] Value={ 1L,4L,9L,11L,14L,18L,21L,23L,24L,31L,32L,33L,34L,37L,40L,41L,44L,46L,49L,51L,54L,55L,60L,61L,62L,64L,65L,66L,71L,74L,75L,77L,79L,81L,84L,88L,89L,91L,92L,93L,94L,99L,100L,101L,102L,104L,106L,107L,111L,113L,114L,116L,118L,121L,123L,124L,127L,128L,130L,131L,134L,135L,138L,141L,143L,144L,149L,150L,151L,153L,154L,157L,158L,161L,163L,164L,165L,168L,169L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199595Inst : IEnumerable<long>
{
public static readonly long[] Value=A199595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199595.Bytes);
public long this[int i]=>Value[i];

public static A199595Inst Instance=new A199595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199596
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,2L,1L,1L,3L,1L,1L,2L,2L,1L,3L,2L,1L,2L,2L,1L,2L,1L,1L,3L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,3L,1L,1L,3L,1L,1L,2L,2L,1L,3L,2L,0L,2L,2L,1L,3L,1L,1L,3L,1L,1L,2L,1L,1L,3L,1L,1L,3L,2L,1L,2L,1L,1L,3L,2L,1L,2L,2L,1L,2L,2L,0L,3L,2L,1L,3L,1L,1L,3L,2L,1L,2L,1L,1L,2L,2L,1L,3L,2L,1L,2L,1L,1L,3L,2L,1L,2L,1L,1L,2L,2L,1L,3L,2L,1L,3L,1L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199596Inst : IEnumerable<long>
{
public static readonly long[] Value=A199596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199596.Bytes);
public long this[int i]=>Value[i];

public static A199596Inst Instance=new A199596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199597
{
public static readonly long[] Value={ 1L,1L,8L,8L,1L,8L,5L,1L,3L,4L,4L,5L,1L,4L,3L,8L,8L,0L,3L,2L,1L,7L,8L,1L,0L,9L,7L,2L,9L,0L,7L,6L,5L,2L,5L,9L,7L,3L,8L,3L,2L,4L,2L,5L,6L,1L,2L,8L,4L,1L,4L,7L,1L,9L,4L,1L,8L,2L,3L,9L,5L,2L,8L,3L,2L,3L,4L,1L,8L,6L,0L,9L,9L,1L,3L,4L,2L,2L,9L,6L,0L,3L,4L,2L,6L,1L,8L,0L,9L,6L,9L,1L,8L,3L,4L,8L,8L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199597Inst : IEnumerable<long>
{
public static readonly long[] Value=A199597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199597.Bytes);
public long this[int i]=>Value[i];

public static A199597Inst Instance=new A199597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199598
{
public static readonly long[] Value={ 1L,8L,3L,8L,2L,4L,3L,4L,5L,4L,9L,7L,1L,0L,3L,9L,6L,4L,2L,3L,1L,9L,1L,9L,8L,8L,7L,1L,2L,2L,9L,0L,1L,0L,2L,1L,4L,4L,8L,8L,8L,0L,1L,5L,0L,0L,3L,3L,4L,7L,8L,3L,4L,0L,0L,4L,6L,9L,5L,6L,8L,7L,1L,4L,5L,3L,1L,4L,7L,2L,6L,3L,3L,5L,8L,4L,1L,5L,2L,5L,0L,7L,2L,3L,8L,7L,0L,9L,1L,9L,6L,4L,2L,7L,5L,3L,6L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199598Inst : IEnumerable<long>
{
public static readonly long[] Value=A199598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199598.Bytes);
public long this[int i]=>Value[i];

public static A199598Inst Instance=new A199598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199599
{
public static readonly long[] Value={ 2L,1L,2L,5L,9L,8L,6L,5L,4L,9L,9L,7L,7L,7L,0L,3L,0L,4L,2L,5L,1L,2L,1L,6L,2L,5L,5L,7L,8L,8L,0L,4L,3L,1L,8L,4L,7L,2L,1L,0L,0L,7L,9L,4L,1L,4L,4L,8L,1L,7L,8L,7L,8L,7L,7L,6L,3L,0L,8L,5L,5L,5L,2L,6L,5L,9L,0L,7L,3L,8L,7L,4L,2L,9L,2L,8L,5L,4L,4L,8L,2L,8L,5L,5L,0L,2L,4L,6L,7L,5L,6L,2L,4L,7L,5L,7L,8L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199599Inst : IEnumerable<long>
{
public static readonly long[] Value=A199599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199599.Bytes);
public long this[int i]=>Value[i];

public static A199599Inst Instance=new A199599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199600
{
public static readonly long[] Value={ 6L,5L,5L,5L,3L,8L,2L,9L,9L,5L,3L,9L,6L,9L,4L,5L,0L,7L,1L,8L,5L,8L,6L,6L,2L,4L,6L,3L,4L,3L,9L,9L,3L,0L,7L,3L,9L,2L,4L,2L,1L,1L,6L,4L,8L,9L,3L,5L,7L,8L,0L,4L,1L,0L,7L,7L,0L,6L,4L,5L,5L,0L,1L,6L,5L,7L,7L,8L,0L,5L,4L,3L,6L,1L,0L,6L,4L,1L,7L,4L,5L,9L,5L,2L,4L,0L,1L,1L,8L,4L,7L,9L,0L,9L,2L,2L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199600Inst : IEnumerable<long>
{
public static readonly long[] Value=A199600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199600.Bytes);
public long this[int i]=>Value[i];

public static A199600Inst Instance=new A199600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199601
{
public static readonly long[] Value={ 2L,3L,0L,6L,4L,7L,8L,3L,4L,7L,1L,0L,4L,8L,0L,2L,6L,8L,7L,7L,0L,5L,9L,0L,6L,4L,3L,9L,6L,6L,9L,2L,0L,9L,2L,4L,6L,6L,5L,8L,7L,8L,6L,5L,4L,2L,2L,7L,8L,7L,0L,3L,5L,8L,3L,1L,2L,8L,1L,4L,4L,5L,4L,6L,8L,0L,1L,3L,9L,1L,8L,3L,1L,5L,7L,4L,3L,0L,8L,2L,4L,7L,9L,5L,1L,8L,9L,0L,3L,4L,5L,1L,0L,4L,7L,2L,4L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199601Inst : IEnumerable<long>
{
public static readonly long[] Value=A199601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199601.Bytes);
public long this[int i]=>Value[i];

public static A199601Inst Instance=new A199601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199602
{
public static readonly long[] Value={ 2L,5L,4L,0L,0L,9L,2L,4L,1L,8L,0L,4L,2L,7L,4L,7L,3L,6L,3L,8L,5L,0L,7L,9L,4L,3L,9L,3L,9L,9L,4L,8L,3L,4L,3L,7L,4L,4L,6L,3L,1L,5L,7L,7L,5L,4L,4L,3L,1L,5L,3L,2L,7L,4L,5L,9L,6L,7L,9L,8L,4L,0L,7L,8L,5L,5L,7L,7L,9L,6L,6L,2L,5L,6L,4L,7L,9L,3L,4L,9L,9L,2L,1L,3L,9L,2L,7L,0L,4L,1L,6L,8L,5L,5L,2L,6L,8L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199602Inst : IEnumerable<long>
{
public static readonly long[] Value=A199602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199602.Bytes);
public long this[int i]=>Value[i];

public static A199602Inst Instance=new A199602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199603
{
public static readonly long[] Value={ 1L,1L,7L,0L,1L,2L,0L,9L,5L,0L,0L,0L,2L,6L,2L,6L,0L,5L,3L,7L,0L,6L,0L,4L,3L,0L,1L,1L,8L,5L,8L,9L,7L,1L,0L,8L,1L,9L,9L,9L,4L,0L,2L,0L,2L,5L,9L,5L,5L,5L,1L,5L,6L,4L,7L,4L,1L,6L,8L,1L,9L,7L,4L,4L,3L,7L,0L,0L,2L,4L,9L,2L,4L,7L,7L,1L,7L,3L,0L,8L,4L,2L,6L,4L,7L,9L,9L,0L,8L,0L,1L,1L,0L,0L,7L,0L,8L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199603Inst : IEnumerable<long>
{
public static readonly long[] Value=A199603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199603.Bytes);
public long this[int i]=>Value[i];

public static A199603Inst Instance=new A199603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199604
{
public static readonly long[] Value={ 2L,9L,3L,8L,1L,0L,0L,3L,9L,3L,9L,7L,0L,8L,1L,1L,8L,0L,7L,6L,5L,8L,1L,3L,6L,4L,7L,8L,4L,2L,5L,9L,1L,2L,9L,5L,9L,6L,7L,0L,2L,1L,8L,6L,1L,7L,3L,2L,2L,3L,1L,0L,1L,7L,8L,4L,6L,7L,1L,7L,6L,3L,8L,5L,3L,5L,4L,6L,7L,8L,5L,9L,2L,9L,2L,8L,3L,6L,7L,4L,6L,4L,2L,0L,8L,0L,2L,3L,0L,3L,2L,4L,8L,7L,2L,5L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199604Inst : IEnumerable<long>
{
public static readonly long[] Value=A199604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199604.Bytes);
public long this[int i]=>Value[i];

public static A199604Inst Instance=new A199604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199605
{
public static readonly long[] Value={ 9L,3L,0L,4L,9L,5L,0L,0L,2L,6L,3L,5L,9L,7L,0L,1L,0L,9L,7L,6L,3L,3L,4L,1L,0L,2L,4L,0L,2L,5L,4L,7L,8L,5L,1L,2L,5L,8L,6L,4L,4L,8L,8L,2L,4L,4L,1L,4L,8L,8L,7L,7L,2L,8L,1L,5L,2L,2L,7L,2L,8L,2L,8L,2L,0L,8L,3L,0L,6L,9L,2L,4L,0L,1L,9L,7L,5L,5L,2L,4L,2L,5L,1L,0L,1L,9L,2L,8L,9L,1L,3L,1L,7L,8L,3L,6L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199605Inst : IEnumerable<long>
{
public static readonly long[] Value=A199605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199605.Bytes);
public long this[int i]=>Value[i];

public static A199605Inst Instance=new A199605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199606
{
public static readonly long[] Value={ 3L,0L,1L,7L,9L,6L,3L,0L,8L,1L,0L,6L,8L,6L,2L,8L,8L,7L,2L,6L,6L,7L,8L,1L,4L,4L,3L,3L,8L,8L,5L,7L,6L,8L,9L,7L,0L,3L,7L,8L,3L,2L,7L,2L,9L,4L,7L,3L,8L,3L,3L,3L,0L,9L,4L,0L,6L,2L,7L,6L,8L,4L,4L,5L,7L,5L,7L,0L,0L,2L,3L,7L,8L,0L,9L,9L,2L,1L,2L,9L,5L,1L,4L,6L,0L,3L,3L,7L,8L,7L,6L,8L,4L,3L,4L,7L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199606Inst : IEnumerable<long>
{
public static readonly long[] Value=A199606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199606.Bytes);
public long this[int i]=>Value[i];

public static A199606Inst Instance=new A199606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199607
{
public static readonly long[] Value={ 5L,9L,7L,3L,3L,9L,2L,5L,0L,3L,6L,4L,8L,5L,3L,9L,7L,5L,0L,0L,4L,9L,7L,3L,6L,1L,3L,5L,9L,9L,7L,6L,6L,9L,0L,2L,8L,3L,3L,1L,8L,5L,7L,5L,6L,4L,1L,8L,4L,9L,2L,4L,1L,1L,3L,2L,7L,4L,2L,3L,8L,5L,1L,2L,2L,2L,8L,8L,6L,9L,5L,9L,3L,7L,4L,7L,8L,7L,0L,0L,7L,9L,2L,5L,4L,4L,7L,4L,1L,3L,0L,9L,1L,3L,3L,4L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199607Inst : IEnumerable<long>
{
public static readonly long[] Value=A199607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199607.Bytes);
public long this[int i]=>Value[i];

public static A199607Inst Instance=new A199607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199608
{
public static readonly long[] Value={ 3L,0L,4L,8L,1L,3L,8L,5L,9L,5L,3L,6L,5L,1L,1L,6L,6L,8L,9L,1L,4L,4L,6L,0L,5L,0L,5L,9L,3L,7L,3L,9L,0L,5L,2L,2L,0L,8L,5L,4L,6L,4L,6L,8L,6L,6L,9L,9L,5L,5L,4L,2L,6L,9L,2L,1L,5L,9L,2L,4L,3L,6L,0L,5L,4L,8L,2L,5L,1L,2L,3L,3L,6L,9L,6L,4L,0L,1L,1L,0L,6L,2L,4L,0L,2L,2L,9L,6L,6L,8L,6L,6L,4L,7L,6L,6L,7L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199608Inst : IEnumerable<long>
{
public static readonly long[] Value=A199608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199608.Bytes);
public long this[int i]=>Value[i];

public static A199608Inst Instance=new A199608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199609
{
public static readonly long[] Value={ 1L,1L,4L,2L,2L,5L,6L,4L,0L,2L,2L,4L,4L,7L,4L,0L,1L,1L,0L,0L,4L,4L,6L,1L,5L,8L,7L,8L,2L,3L,5L,8L,6L,4L,3L,5L,2L,5L,1L,5L,3L,4L,4L,8L,3L,4L,4L,5L,7L,6L,4L,5L,7L,4L,8L,1L,0L,1L,7L,4L,4L,4L,6L,2L,4L,3L,1L,6L,6L,5L,1L,6L,7L,4L,3L,3L,7L,0L,9L,4L,5L,1L,6L,0L,9L,7L,2L,6L,6L,3L,4L,9L,3L,4L,7L,6L,2L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199609Inst : IEnumerable<long>
{
public static readonly long[] Value=A199609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199609.Bytes);
public long this[int i]=>Value[i];

public static A199609Inst Instance=new A199609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199610
{
public static readonly long[] Value={ 3L,0L,6L,5L,6L,2L,0L,7L,6L,0L,3L,3L,6L,8L,5L,8L,5L,6L,1L,8L,6L,7L,4L,5L,7L,5L,5L,2L,8L,5L,0L,8L,2L,1L,3L,2L,5L,0L,6L,5L,4L,0L,2L,0L,6L,8L,2L,0L,1L,7L,0L,6L,2L,6L,3L,9L,9L,4L,5L,6L,9L,0L,5L,4L,3L,3L,1L,2L,5L,4L,8L,2L,7L,3L,8L,3L,4L,7L,4L,3L,0L,4L,4L,5L,7L,0L,8L,1L,7L,8L,0L,0L,8L,7L,6L,1L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199610Inst : IEnumerable<long>
{
public static readonly long[] Value=A199610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199610.Bytes);
public long this[int i]=>Value[i];

public static A199610Inst Instance=new A199610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199611
{
public static readonly long[] Value={ 1L,2L,5L,2L,3L,5L,3L,2L,3L,4L,0L,0L,2L,5L,8L,8L,7L,6L,3L,1L,8L,6L,3L,2L,8L,1L,2L,1L,9L,7L,5L,3L,8L,0L,4L,3L,5L,9L,0L,1L,2L,8L,0L,6L,1L,0L,5L,6L,6L,1L,8L,9L,9L,9L,2L,3L,8L,6L,1L,4L,4L,3L,1L,3L,0L,8L,0L,8L,0L,2L,4L,1L,3L,3L,5L,3L,2L,6L,7L,5L,6L,7L,8L,9L,0L,9L,6L,2L,7L,6L,9L,1L,9L,2L,7L,6L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199611Inst : IEnumerable<long>
{
public static readonly long[] Value=A199611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199611.Bytes);
public long this[int i]=>Value[i];

public static A199611Inst Instance=new A199611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199612
{
public static readonly long[] Value={ 3L,5L,9L,5L,3L,0L,4L,8L,6L,7L,1L,6L,1L,5L,4L,7L,9L,9L,1L,8L,7L,7L,6L,0L,6L,9L,3L,5L,0L,8L,3L,4L,1L,8L,7L,1L,4L,9L,1L,3L,1L,1L,1L,4L,3L,7L,7L,7L,5L,5L,2L,9L,3L,2L,5L,1L,8L,5L,5L,2L,2L,4L,8L,6L,9L,1L,2L,8L,2L,5L,3L,0L,1L,8L,4L,3L,4L,6L,3L,7L,8L,9L,3L,9L,0L,1L,3L,7L,9L,2L,1L,4L,0L,7L,2L,6L,9L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199612Inst : IEnumerable<long>
{
public static readonly long[] Value=A199612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199612.Bytes);
public long this[int i]=>Value[i];

public static A199612Inst Instance=new A199612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199613
{
public static readonly long[] Value={ 1L,0L,7L,7L,3L,0L,9L,9L,1L,7L,5L,2L,4L,0L,7L,2L,0L,3L,0L,3L,3L,9L,9L,7L,9L,6L,1L,5L,1L,2L,6L,8L,1L,3L,6L,6L,4L,7L,9L,1L,6L,5L,3L,9L,9L,5L,8L,3L,8L,5L,8L,7L,9L,3L,4L,0L,9L,3L,3L,1L,5L,0L,2L,2L,5L,4L,2L,0L,7L,7L,4L,2L,2L,3L,3L,2L,4L,7L,1L,0L,7L,3L,0L,2L,3L,3L,9L,5L,0L,3L,9L,8L,7L,4L,5L,2L,2L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199613Inst : IEnumerable<long>
{
public static readonly long[] Value=A199613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199613.Bytes);
public long this[int i]=>Value[i];

public static A199613Inst Instance=new A199613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199614
{
public static readonly long[] Value={ 3L,5L,5L,3L,2L,4L,1L,6L,8L,0L,6L,8L,2L,8L,9L,2L,5L,2L,3L,9L,5L,7L,2L,6L,5L,5L,5L,6L,2L,3L,4L,4L,9L,4L,9L,0L,2L,0L,6L,7L,7L,6L,2L,6L,1L,8L,6L,1L,7L,2L,3L,9L,1L,5L,4L,2L,8L,6L,0L,0L,4L,2L,8L,8L,8L,6L,6L,0L,4L,0L,7L,4L,9L,0L,2L,5L,6L,2L,7L,1L,6L,0L,1L,8L,7L,4L,7L,3L,5L,7L,2L,1L,8L,0L,8L,2L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199614Inst : IEnumerable<long>
{
public static readonly long[] Value=A199614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199614.Bytes);
public long this[int i]=>Value[i];

public static A199614Inst Instance=new A199614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199615
{
public static readonly long[] Value={ 8L,5L,6L,3L,7L,4L,0L,4L,9L,7L,4L,4L,3L,4L,6L,1L,0L,9L,3L,2L,2L,0L,7L,8L,0L,6L,2L,5L,6L,4L,7L,2L,9L,1L,9L,9L,4L,7L,6L,6L,0L,0L,5L,0L,8L,8L,7L,5L,4L,8L,2L,4L,0L,9L,4L,3L,3L,1L,0L,1L,4L,8L,8L,7L,0L,6L,8L,7L,1L,6L,7L,3L,4L,6L,5L,9L,9L,3L,0L,2L,8L,3L,6L,5L,7L,7L,2L,0L,9L,8L,7L,5L,0L,6L,7L,2L,6L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199615Inst : IEnumerable<long>
{
public static readonly long[] Value=A199615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199615.Bytes);
public long this[int i]=>Value[i];

public static A199615Inst Instance=new A199615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199616
{
public static readonly long[] Value={ 3L,5L,1L,5L,6L,1L,3L,1L,9L,9L,6L,8L,7L,3L,5L,8L,0L,2L,3L,8L,4L,2L,1L,8L,0L,2L,1L,0L,7L,0L,4L,0L,3L,0L,7L,9L,2L,2L,1L,7L,8L,8L,8L,8L,6L,7L,9L,8L,1L,9L,3L,3L,5L,0L,7L,3L,8L,3L,3L,3L,5L,6L,9L,7L,8L,4L,4L,2L,4L,3L,4L,5L,9L,1L,6L,5L,7L,2L,6L,4L,8L,5L,7L,2L,3L,9L,2L,0L,0L,0L,7L,5L,7L,6L,0L,2L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199616Inst : IEnumerable<long>
{
public static readonly long[] Value=A199616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199616.Bytes);
public long this[int i]=>Value[i];

public static A199616Inst Instance=new A199616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199617
{
public static readonly long[] Value={ 5L,5L,3L,5L,4L,3L,3L,8L,1L,7L,8L,6L,0L,3L,3L,6L,2L,8L,7L,0L,2L,0L,3L,4L,4L,9L,0L,5L,9L,1L,1L,8L,1L,6L,9L,3L,0L,4L,0L,6L,3L,2L,5L,8L,0L,1L,1L,9L,4L,8L,5L,5L,2L,5L,1L,2L,7L,6L,2L,5L,4L,7L,5L,2L,7L,1L,3L,8L,3L,1L,4L,4L,4L,4L,6L,9L,3L,7L,3L,9L,8L,3L,1L,0L,6L,3L,4L,6L,4L,5L,4L,9L,0L,8L,8L,0L,0L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199617Inst : IEnumerable<long>
{
public static readonly long[] Value=A199617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199617.Bytes);
public long this[int i]=>Value[i];

public static A199617Inst Instance=new A199617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199618
{
public static readonly long[] Value={ 3L,4L,8L,2L,2L,6L,7L,6L,2L,4L,7L,8L,6L,1L,9L,3L,2L,0L,9L,0L,8L,6L,7L,0L,3L,6L,6L,7L,5L,5L,7L,6L,8L,0L,3L,7L,0L,7L,6L,2L,6L,9L,3L,1L,5L,6L,9L,4L,5L,6L,0L,3L,6L,9L,3L,8L,3L,9L,7L,6L,9L,9L,3L,4L,9L,0L,0L,4L,8L,4L,2L,1L,8L,7L,6L,3L,9L,8L,5L,1L,0L,8L,3L,9L,9L,3L,9L,4L,9L,6L,8L,6L,4L,8L,5L,8L,9L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199618Inst : IEnumerable<long>
{
public static readonly long[] Value=A199618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199618.Bytes);
public long this[int i]=>Value[i];

public static A199618Inst Instance=new A199618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199619
{
public static readonly long[] Value={ 8L,0L,0L,0L,5L,3L,3L,4L,2L,6L,2L,7L,4L,1L,5L,7L,5L,9L,3L,6L,8L,5L,9L,0L,2L,7L,9L,9L,0L,8L,9L,3L,3L,2L,1L,9L,6L,3L,2L,4L,4L,6L,5L,3L,4L,4L,8L,6L,4L,6L,6L,6L,1L,1L,0L,4L,6L,2L,1L,6L,6L,9L,1L,9L,5L,3L,4L,1L,3L,1L,1L,0L,2L,7L,7L,5L,0L,4L,3L,4L,1L,5L,9L,6L,8L,4L,1L,0L,1L,2L,2L,2L,9L,0L,1L,5L,2L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199619Inst : IEnumerable<long>
{
public static readonly long[] Value=A199619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199619.Bytes);
public long this[int i]=>Value[i];

public static A199619Inst Instance=new A199619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199620
{
public static readonly long[] Value={ 3L,4L,5L,2L,8L,9L,9L,8L,8L,8L,5L,3L,2L,9L,2L,7L,7L,8L,0L,3L,3L,6L,3L,0L,0L,8L,3L,7L,8L,6L,4L,9L,8L,3L,8L,8L,4L,0L,8L,8L,3L,6L,8L,5L,5L,6L,5L,7L,8L,5L,1L,5L,3L,8L,6L,4L,0L,5L,6L,2L,7L,2L,9L,0L,9L,5L,5L,1L,8L,5L,6L,4L,0L,8L,5L,9L,2L,4L,4L,5L,4L,6L,8L,3L,0L,5L,7L,0L,2L,5L,8L,4L,9L,8L,6L,0L,9L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199620Inst : IEnumerable<long>
{
public static readonly long[] Value=A199620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199620.Bytes);
public long this[int i]=>Value[i];

public static A199620Inst Instance=new A199620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199621
{
public static readonly long[] Value={ 4L,5L,0L,1L,8L,3L,6L,1L,1L,2L,9L,4L,8L,7L,3L,5L,7L,3L,0L,3L,6L,5L,3L,8L,6L,9L,6L,7L,6L,2L,6L,8L,1L,8L,2L,7L,3L,2L,0L,1L,3L,6L,5L,0L,1L,7L,2L,3L,0L,5L,5L,4L,3L,4L,0L,1L,5L,0L,5L,8L,4L,9L,1L,3L,6L,3L,6L,4L,1L,5L,6L,6L,9L,8L,5L,2L,2L,3L,3L,7L,9L,5L,4L,7L,4L,1L,4L,1L,3L,3L,0L,6L,9L,9L,2L,3L,1L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199621Inst : IEnumerable<long>
{
public static readonly long[] Value=A199621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199621.Bytes);
public long this[int i]=>Value[i];

public static A199621Inst Instance=new A199621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199622
{
public static readonly long[] Value={ 5L,2L,1L,7L,7L,0L,5L,3L,3L,6L,3L,0L,4L,1L,5L,9L,0L,7L,6L,0L,2L,2L,2L,6L,7L,1L,7L,5L,2L,3L,9L,3L,7L,8L,8L,2L,9L,5L,7L,5L,1L,0L,8L,9L,8L,0L,1L,9L,0L,1L,6L,1L,5L,6L,1L,5L,0L,9L,6L,0L,0L,6L,2L,7L,2L,1L,1L,0L,4L,7L,2L,8L,7L,3L,1L,4L,9L,5L,9L,6L,8L,5L,8L,0L,7L,2L,5L,8L,7L,8L,1L,8L,9L,8L,2L,5L,1L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199622Inst : IEnumerable<long>
{
public static readonly long[] Value=A199622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199622.Bytes);
public long this[int i]=>Value[i];

public static A199622Inst Instance=new A199622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199623
{
public static readonly long[] Value={ 9L,9L,2L,2L,9L,1L,7L,9L,4L,9L,1L,6L,1L,1L,7L,6L,9L,8L,1L,8L,4L,1L,1L,9L,3L,3L,8L,5L,0L,1L,7L,5L,7L,4L,7L,5L,0L,7L,7L,1L,2L,0L,7L,8L,2L,7L,0L,7L,3L,9L,8L,0L,6L,9L,9L,6L,6L,6L,7L,7L,4L,0L,5L,7L,3L,7L,6L,2L,8L,7L,1L,8L,8L,3L,1L,4L,8L,6L,5L,8L,8L,9L,7L,1L,7L,7L,3L,3L,2L,1L,4L,1L,0L,1L,5L,9L,5L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199623Inst : IEnumerable<long>
{
public static readonly long[] Value=A199623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199623.Bytes);
public long this[int i]=>Value[i];

public static A199623Inst Instance=new A199623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199624
{
public static readonly long[] Value={ 1L,3L,3L,8L,8L,7L,3L,8L,8L,9L,8L,5L,5L,4L,8L,5L,2L,6L,4L,0L,6L,2L,5L,5L,4L,1L,5L,4L,7L,5L,4L,3L,5L,2L,9L,1L,5L,6L,4L,7L,1L,6L,6L,9L,4L,4L,9L,9L,8L,4L,0L,9L,2L,9L,2L,0L,4L,5L,9L,2L,9L,2L,1L,3L,4L,5L,3L,9L,8L,8L,4L,8L,7L,3L,1L,6L,6L,9L,0L,2L,5L,1L,4L,9L,1L,7L,5L,5L,7L,6L,1L,5L,0L,2L,2L,6L,0L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199624Inst : IEnumerable<long>
{
public static readonly long[] Value=A199624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199624.Bytes);
public long this[int i]=>Value[i];

public static A199624Inst Instance=new A199624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199625
{
public static readonly long[] Value={ 4L,2L,5L,7L,1L,1L,4L,2L,3L,2L,3L,6L,2L,8L,2L,9L,5L,5L,0L,2L,7L,8L,5L,0L,2L,3L,0L,7L,9L,0L,3L,4L,1L,3L,2L,6L,9L,2L,8L,6L,5L,8L,1L,3L,7L,3L,5L,0L,8L,9L,3L,7L,8L,2L,7L,7L,8L,7L,8L,9L,7L,7L,8L,4L,6L,8L,1L,5L,7L,1L,1L,7L,1L,9L,8L,7L,5L,4L,7L,7L,3L,9L,5L,2L,5L,2L,4L,6L,5L,2L,0L,7L,8L,3L,7L,5L,9L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199625Inst : IEnumerable<long>
{
public static readonly long[] Value=A199625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199625.Bytes);
public long this[int i]=>Value[i];

public static A199625Inst Instance=new A199625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199626
{
public static readonly long[] Value={ 0L,-4L,-6L,-8L,-7L,-12L,-13L,-16L,-14L,-20L,-20L,-24L,-21L,-28L,-27L,-32L,-28L,-36L,-34L,-40L,-35L,-44L,-41L,-48L,-42L,-52L,-48L,-56L,-49L,-60L,-55L,-64L,-56L,-68L,-62L,-72L,-63L,-76L,-69L,-80L,-70L,-84L,-76L,-88L,-77L,-92L,-83L,-96L,-84L,-100L,-90L,-104L,-91L,-108L,-97L,-112L,-98L,-116L,-104L,-120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199626Inst : IEnumerable<long>
{
public static readonly long[] Value=A199626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199626.Bytes);
public long this[int i]=>Value[i];

public static A199626Inst Instance=new A199626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199627
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,2L,4L,7L,8L,9L,12L,15L,16L,17L,20L,23L,24L,25L,28L,31L,32L,33L,36L,39L,40L,41L,44L,47L,48L,49L,52L,55L,56L,57L,60L,63L,64L,65L,68L,71L,72L,73L,76L,79L,80L,81L,84L,87L,88L,89L,92L,95L,96L,97L,100L,103L,104L,105L,108L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199627Inst : IEnumerable<long>
{
public static readonly long[] Value=A199627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199627.Bytes);
public long this[int i]=>Value[i];

public static A199627Inst Instance=new A199627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199628
{
public static readonly long[] Value={ 1L,4L,7L,14L,32L,50L,71L,122L,185L,238L,319L,430L,528L,626L,752L,884L,1000L,1116L,1249L,1384L,1503L,1620L,1753L,1888L,2007L,2124L,2257L,2392L,2511L,2628L,2761L,2896L,3015L,3132L,3265L,3400L,3519L,3636L,3769L,3904L,4023L,4140L,4273L,4408L,4527L,4644L,4777L,4912L,5031L,5148L,5281L,5416L,5535L,5652L,5785L,5920L,6039L,6156L,6289L,6424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199628Inst : IEnumerable<long>
{
public static readonly long[] Value=A199628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199628.Bytes);
public long this[int i]=>Value[i];

public static A199628Inst Instance=new A199628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199629
{
public static readonly long[] Value={ 1L,6L,16L,35L,86L,182L,317L,558L,975L,1514L,2249L,3366L,4749L,6338L,8417L,10920L,13563L,16538L,19961L,23514L,27123L,30974L,34997L,38994L,42972L,47048L,51197L,55285L,59313L,63408L,67567L,71660L,75689L,79784L,83943L,88036L,92065L,96160L,100319L,104412L,108441L,112536L,116695L,120788L,124817L,128912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199629Inst : IEnumerable<long>
{
public static readonly long[] Value=A199629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199629.Bytes);
public long this[int i]=>Value[i];

public static A199629Inst Instance=new A199629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199630
{
public static readonly long[] Value={ 3175462089L,3175804269L,3204957816L,3206549178L,3210754689L,3254196708L,3260974851L,3275409816L,3284591706L,3290581476L,3406829517L,3410856297L,3459186720L,3469857012L,3475806912L,3501249678L,3512067849L,3519876240L,3549716208L,3564980172L,3587902614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199630Inst : IEnumerable<long>
{
public static readonly long[] Value=A199630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199630.Bytes);
public long this[int i]=>Value[i];

public static A199630Inst Instance=new A199630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199631
{
public static readonly long[] Value={ 4680215379L,4752360918L,4765380219L,4915280637L,5063248197L,5164738920L,5382417906L,5426370189L,5429013678L,5628130974L,5679321048L,5697841320L,5762831940L,5783610492L,5786430129L,5903467821L,6019285734L,6053147982L,6095721483L,6143720958L,6158723094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199631Inst : IEnumerable<long>
{
public static readonly long[] Value=A199631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199631.Bytes);
public long this[int i]=>Value[i];

public static A199631Inst Instance=new A199631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199632
{
public static readonly long[] Value={ 7351062489L,8105632794L,8401253976L,8731945026L,9164072385L,9238750614L,9615278340L,9847103256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199632Inst : IEnumerable<long>
{
public static readonly long[] Value=A199632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199632.Bytes);
public long this[int i]=>Value[i];

public static A199632Inst Instance=new A199632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199633
{
public static readonly long[] Value={ 7025869314L,7143258096L,7931584062L,8094273561L,8920416357L,9247560381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199633Inst : IEnumerable<long>
{
public static readonly long[] Value=A199633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199633.Bytes);
public long this[int i]=>Value[i];

public static A199633Inst Instance=new A199633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199634
{
public static readonly long[] Value={ 3265920L,534L,74L,13L,8L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199634Inst : IEnumerable<long>
{
public static readonly long[] Value=A199634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199634.Bytes);
public long this[int i]=>Value[i];

public static A199634Inst Instance=new A199634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199635
{
public static readonly long[] Value={ 8L,9L,11L,19L,20L,27L,29L,38L,49L,55L,57L,64L,66L,67L,74L,78L,87L,104L,105L,114L,122L,154L,171L,179L,198L,202L,211L,237L,249L,250L,276L,295L,297L,315L,343L,373L,390L,393L,399L,428L,429L,441L,479L,485L,489L,497L,534L,535L,583L,604L,610L,619L,690L,767L,786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199635Inst : IEnumerable<long>
{
public static readonly long[] Value=A199635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199635.Bytes);
public long this[int i]=>Value[i];

public static A199635Inst Instance=new A199635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199636
{
public static readonly long[] Value={ 5L,3L,21L,13L,85L,17L,53L,11L,35L,113L,341L,7L,23L,69L,75L,213L,227L,15L,45L,141L,151L,453L,1365L,9L,29L,93L,277L,301L,853L,909L,19L,61L,181L,201L,565L,605L,1813L,5461L,37L,117L,369L,373L,401L,403L,1109L,1137L,1205L,3413L,3637L,25L,77L,81L,241L,245L,267L,725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199636Inst : IEnumerable<long>
{
public static readonly long[] Value=A199636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199636.Bytes);
public long this[int i]=>Value[i];

public static A199636Inst Instance=new A199636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199637
{
public static readonly long[] Value={ 5L,3L,21L,13L,85L,17L,11L,7L,15L,9L,19L,37L,25L,49L,33L,65L,43L,87L,57L,39L,79L,153L,105L,203L,135L,271L,185L,123L,247L,169L,329L,219L,159L,295L,569L,379L,283L,505L,377L,251L,167L,111L,223L,445L,297L,593L,395L,263L,175L,351L,233L,155L,103L,207L,137L,91L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199637Inst : IEnumerable<long>
{
public static readonly long[] Value=A199637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199637.Bytes);
public long this[int i]=>Value[i];

public static A199637Inst Instance=new A199637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199638
{
public static readonly long[] Value={ 5L,3L,21L,13L,85L,53L,341L,227L,1365L,909L,5461L,3637L,21845L,14563L,87381L,58253L,349525L,233013L,1398101L,932067L,5592405L,3728269L,22369621L,14913077L,89478485L,59652323L,357913941L,238609293L,1431655765L,954437173L,5726623061L,3817748707L,22906492245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199638Inst : IEnumerable<long>
{
public static readonly long[] Value=A199638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199638.Bytes);
public long this[int i]=>Value[i];

public static A199638Inst Instance=new A199638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199639
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,12L,16L,19L,22L,24L,28L,31L,32L,43L,48L,64L,76L,79L,96L,103L,112L,128L,139L,142L,163L,166L,184L,192L,199L,211L,223L,256L,262L,268L,271L,283L,304L,307L,316L,331L,352L,367L,376L,379L,384L,412L,439L,448L,454L,463L,496L,499L,512L,526L,547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199639Inst : IEnumerable<long>
{
public static readonly long[] Value=A199639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199639.Bytes);
public long this[int i]=>Value[i];

public static A199639Inst Instance=new A199639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199640
{
public static readonly long[] Value={ 0L,3L,112L,29229L,32177372L,176701683386L,4539946639286136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199640Inst : IEnumerable<long>
{
public static readonly long[] Value=A199640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199640.Bytes);
public long this[int i]=>Value[i];

public static A199640Inst Instance=new A199640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199641
{
public static readonly long[] Value={ 1L,3L,13L,60L,288L,1384L,6628L,31772L,152304L,730036L,3499340L,16773680L,80402532L,385399644L,1847365808L,8855120468L,42445929772L,203459338800L,975257291396L,4674775757500L,22407962058928L,107409807372276L,514855687878924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199641Inst : IEnumerable<long>
{
public static readonly long[] Value=A199641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199641.Bytes);
public long this[int i]=>Value[i];

public static A199641Inst Instance=new A199641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199642
{
public static readonly long[] Value={ 1L,13L,112L,1265L,12748L,134748L,1396083L,14584050L,151837464L,1582988477L,16494233432L,171904221068L,1791430664487L,18669394073270L,194560012081184L,2027588187779377L,21130256645906468L,220206564513115724L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199642Inst : IEnumerable<long>
{
public static readonly long[] Value=A199642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199642.Bytes);
public long this[int i]=>Value[i];

public static A199642Inst Instance=new A199642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199643
{
public static readonly BigInteger[] Value={ 2L,60L,1265L,29229L,658770L,15066222L,342328663L,7797114144L,177447181083L,4039488090307L,91947444344704L,2092999963213610L,47642308975551650L,1084472533833020100L,BigInteger.Parse("24685590900071146822"),BigInteger.Parse("561912613968766782369") };
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
public class A199643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199643Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199643.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199643.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199643Inst Instance=new A199643Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199644
{
public static readonly BigInteger[] Value={ 3L,288L,12748L,658770L,32177372L,1614250077L,80053957248L,3988024796446L,198328767139736L,9869645990489747L,491026123739354858L,BigInteger.Parse("24431608808618462704"),BigInteger.Parse("1215575822472077464282"),BigInteger.Parse("60480991464785183388557") };
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
public class A199644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199644Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199644.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199644.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199644Inst Instance=new A199644Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199645
{
public static readonly BigInteger[] Value={ 6L,1384L,134748L,15066222L,1614250077L,176701683386L,19161971644783L,2085499380111100L,226676302441401393L,BigInteger.Parse("24649864713781053665"),BigInteger.Parse("2680046304287719376722"),BigInteger.Parse("291407720701800854792287") };
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
public class A199645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199645Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199645.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199645.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199645Inst Instance=new A199645Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199646
{
public static readonly BigInteger[] Value={ 11L,6628L,1396083L,342328663L,80053957248L,19161971644783L,4539946639286136L,1079929763429897946L,BigInteger.Parse("256503858825070983388") };
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
public class A199646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199646Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199646.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199646.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199646Inst Instance=new A199646Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199647
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,2L,13L,13L,2L,3L,60L,112L,60L,3L,6L,288L,1265L,1265L,288L,6L,11L,1384L,12748L,29229L,12748L,1384L,11L,22L,6628L,134748L,658770L,658770L,134748L,6628L,22L,43L,31772L,1396083L,15066222L,32177372L,15066222L,1396083L,31772L,43L,86L,152304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199647Inst : IEnumerable<long>
{
public static readonly long[] Value=A199647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199647.Bytes);
public long this[int i]=>Value[i];

public static A199647Inst Instance=new A199647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199648
{
public static readonly BigInteger[] Value={ 1L,14L,2584L,3695683L,39209840355L,3083761998081891L,BigInteger.Parse("1797997097480559332224"),BigInteger.Parse("7771716024559573445914487875") };
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
public class A199648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199648Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199648.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199648.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199648Inst Instance=new A199648Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199649
{
public static readonly long[] Value={ 2L,14L,113L,953L,8037L,67774L,571530L,4819638L,40643380L,342740340L,2890284724L,24373395288L,205537673480L,1733272476824L,14616461440144L,123258718919184L,1039424750772560L,8765333779162336L,73916920107029408L,623331776719986016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199649Inst : IEnumerable<long>
{
public static readonly long[] Value=A199649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199649.Bytes);
public long this[int i]=>Value[i];

public static A199649Inst Instance=new A199649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199650
{
public static readonly BigInteger[] Value={ 5L,113L,2584L,59212L,1357484L,31120632L,713445976L,16355879648L,374961537040L,8596061907680L,197066293538400L,4517780870646656L,103570953858672192L,2374383085485820032L,BigInteger.Parse("54433167085958461312"),BigInteger.Parse("1247890324488906825728") };
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
public class A199650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199650Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199650.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199650.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199650Inst Instance=new A199650Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199651
{
public static readonly BigInteger[] Value={ 14L,953L,59212L,3695683L,230693158L,14399942873L,898852775335L,56106912155198L,3502225890582058L,218610965399514236L,13645822881807986686UL,BigInteger.Parse("851780155556891684028"),BigInteger.Parse("53168609887984551128913"),BigInteger.Parse("3318815376219262701965237") };
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
public class A199651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199651Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199651.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199651.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199651Inst Instance=new A199651Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199652
{
public static readonly BigInteger[] Value={ 41L,8037L,1357484L,230693158L,39209840355L,6663970316970L,1132589231853096L,192491652879392515L,BigInteger.Parse("32715334199617664326"),BigInteger.Parse("5560205218374521415185"),BigInteger.Parse("944996676143473092852595"),BigInteger.Parse("160608949278619262130353064") };
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
public class A199652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199652.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199652Inst Instance=new A199652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199653
{
public static readonly BigInteger[] Value={ 122L,67774L,31120632L,14399942873L,6663970316970L,3083761998081891L,1427019666767669979L,BigInteger.Parse("660357476435139192982"),BigInteger.Parse("305582323780950052573456"),BigInteger.Parse("141409100632588861437301956"),BigInteger.Parse("65437468685616944338442793185") };
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
public class A199653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199653.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199653Inst Instance=new A199653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199654
{
public static readonly BigInteger[] Value={ 365L,571530L,713445976L,898852775335L,1132589231853096L,1427019666767669979L,BigInteger.Parse("1797997097480559332224"),BigInteger.Parse("2265416280260844187870380"),BigInteger.Parse("2854348741463033805904551375"),BigInteger.Parse("3596383952736036093799275624989") };
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
public class A199654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199654.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199654Inst Instance=new A199654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199655
{
public static readonly long[] Value={ 1L,2L,2L,5L,14L,5L,14L,113L,113L,14L,41L,953L,2584L,953L,41L,122L,8037L,59212L,59212L,8037L,122L,365L,67774L,1357484L,3695683L,1357484L,67774L,365L,1094L,571530L,31120632L,230693158L,230693158L,31120632L,571530L,1094L,3281L,4819638L,713445976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199655Inst : IEnumerable<long>
{
public static readonly long[] Value=A199655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199655.Bytes);
public long this[int i]=>Value[i];

public static A199655Inst Instance=new A199655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199656
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,19L,1L,15L,65L,175L,1L,31L,211L,781L,2101L,1L,63L,665L,3367L,11529L,31031L,1L,127L,2059L,14197L,61741L,201811L,543607L,1L,255L,6305L,58975L,325089L,1288991L,4085185L,11012415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199656Inst : IEnumerable<long>
{
public static readonly long[] Value=A199656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199656.Bytes);
public long this[int i]=>Value[i];

public static A199656Inst Instance=new A199656Inst();

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