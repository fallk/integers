using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A245482
{
public static readonly long[] Value={ 3277L,13021L,102943L,233017L,478297L,2756293L,44693587L,465273397L,705483871L,859769191L,2117950381L,3996097561L,8123248981L,10554648343L,11980986577L,15318627451L,21753909997L,30299909641L,33705129193L,37423460467L,41477524747L,45891147541L,97434620557L,106376475037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245482Inst : IEnumerable<long>
{
public static readonly long[] Value=A245482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245482.Bytes);
public long this[int i]=>Value[i];

public static A245482Inst Instance=new A245482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245483
{
public static readonly long[] Value={ 44287L,838861L,247165843L,3138105961L,269971011311L,540609741211L,1034834473201L,3382547898907L,5824512944911L,9752380952381L,25405143539623L,91699453500601L,406683658856861L,794014903012651L,2005395532515211L,7936895933061811L,10230009756097561L,13103072183720201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245483Inst : IEnumerable<long>
{
public static readonly long[] Value=A245483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245483.Bytes);
public long this[int i]=>Value[i];

public static A245483Inst Instance=new A245483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245484
{
public static readonly long[] Value={ 0L,1L,1L,7L,1L,19L,1L,35L,13L,37L,1L,119L,1L,63L,43L,155L,1L,208L,1L,245L,69L,139L,1L,575L,31L,189L,130L,427L,1L,661L,1L,651L,145L,313L,87L,1274L,1L,387L,195L,1205L,1L,1155L,1L,959L,520L,559L,1L,2511L,57L,992L,319L,1309L,1L,1990L,163L,2115L,393L,877L,1L,4025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245484Inst : IEnumerable<long>
{
public static readonly long[] Value=A245484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245484.Bytes);
public long this[int i]=>Value[i];

public static A245484Inst Instance=new A245484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245485
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245485Inst : IEnumerable<long>
{
public static readonly long[] Value=A245485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245485.Bytes);
public long this[int i]=>Value[i];

public static A245485Inst Instance=new A245485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245486
{
public static readonly long[] Value={ 2L,6L,6L,10L,15L,21L,14L,6L,15L,55L,33L,39L,91L,35L,10L,34L,51L,57L,95L,35L,77L,253L,69L,15L,65L,39L,21L,203L,145L,155L,62L,22L,187L,119L,21L,111L,703L,247L,65L,205L,287L,301L,473L,55L,115L,1081L,141L,21L,35L,85L,221L,689L,159L,33L,77L,133L,551L,1711L,295L,305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245486Inst : IEnumerable<long>
{
public static readonly long[] Value=A245486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245486.Bytes);
public long this[int i]=>Value[i];

public static A245486Inst Instance=new A245486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245487
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,3L,3L,0L,4L,6L,4L,5L,10L,10L,11L,15L,20L,22L,27L,35L,43L,49L,63L,79L,92L,112L,144L,171L,204L,257L,316L,375L,462L,573L,692L,838L,1035L,1265L,1532L,1873L,2300L,2798L,3406L,4173L,5099L,6204L,7580L,9273L,11303L,13784L,16855L,20576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245487Inst : IEnumerable<long>
{
public static readonly long[] Value=A245487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245487.Bytes);
public long this[int i]=>Value[i];

public static A245487Inst Instance=new A245487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245488
{
public static readonly long[] Value={ 9L,56L,180L,489L,1019L,1895L,3299L,5308L,8092L,11954L,17086L,23346L,31634L,41672L,53892L,69055L,86779L,107795L,132593L,161137L,193749L,232283L,275561L,323469L,379373L,441693L,509675L,587289L,673043L,766707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245488Inst : IEnumerable<long>
{
public static readonly long[] Value=A245488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245488.Bytes);
public long this[int i]=>Value[i];

public static A245488Inst Instance=new A245488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245489
{
public static readonly long[] Value={ 1L,1L,7L,19L,91L,331L,1387L,5419L,21931L,87211L,349867L,1397419L,5593771L,22366891L,89483947L,357903019L,1431677611L,5726579371L,22906579627L,91625794219L,366504225451L,1466014804651L,5864063412907L,23456245263019L,93824997829291L,375299957762731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245489Inst : IEnumerable<long>
{
public static readonly long[] Value=A245489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245489.Bytes);
public long this[int i]=>Value[i];

public static A245489Inst Instance=new A245489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245490
{
public static readonly BigInteger[] Value={ 1L,1L,256L,7625597484987L,BigInteger.Parse("340282366920938463463374607431768211456") };
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
public class A245490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245490Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245490.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245490.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245490Inst Instance=new A245490Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245491
{
public static readonly BigInteger[] Value={ 9L,87L,1068L,16022L,284704L,5834024L,135430302L,3511116537L,100559404366L,3152738985032L,107400330425888L,3950024143546665L,155996847068247395L,6584073072068125453L,BigInteger.Parse("295764262988176583800"),BigInteger.Parse("14088968131538370019982"),BigInteger.Parse("709394716006812244474473") };
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
public class A245491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245491Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245491.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245491.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245491Inst Instance=new A245491Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245492
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,3L,0L,3L,4L,0L,6L,5L,4L,10L,6L,10L,15L,12L,20L,21L,23L,35L,34L,44L,56L,57L,80L,91L,101L,137L,148L,181L,230L,249L,318L,379L,430L,549L,629L,748L,928L,1060L,1298L,1557L,1809L,2226L,2617L,3109L,3783L,4426L,5336L,6400L,7536L,9120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245492Inst : IEnumerable<long>
{
public static readonly long[] Value=A245492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245492.Bytes);
public long this[int i]=>Value[i];

public static A245492Inst Instance=new A245492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245493
{
public static readonly BigInteger[] Value={ 1L,1L,6L,45L,508L,7225L,126306L,2606065L,62075952L,1675774089L,50565938050L,1686510607111L,61609858744248L,2446470026497705L,104922088624078194L,4833250468667819325L,BigInteger.Parse("238004208840601580416"),BigInteger.Parse("12476420334546637657489"),BigInteger.Parse("693675026024580055139778") };
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
public class A245493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245493Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245493.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245493.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245493Inst Instance=new A245493Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245494
{
public static readonly long[] Value={ 1L,3L,0L,5L,0L,7L,0L,5L,3L,3L,3L,5L,3L,5L,4L,1L,7L,5L,3L,3L,0L,4L,8L,4L,6L,8L,5L,9L,6L,5L,4L,6L,1L,7L,7L,6L,8L,6L,8L,2L,5L,6L,9L,0L,9L,5L,0L,7L,1L,7L,4L,2L,8L,7L,9L,7L,3L,0L,8L,7L,2L,2L,2L,1L,2L,8L,2L,9L,5L,3L,7L,4L,0L,6L,0L,0L,6L,5L,7L,5L,8L,7L,7L,3L,8L,9L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245494Inst : IEnumerable<long>
{
public static readonly long[] Value=A245494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245494.Bytes);
public long this[int i]=>Value[i];

public static A245494Inst Instance=new A245494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245495
{
public static readonly BigInteger[] Value={ 103L,4441L,36650881L,5787936001L,19702293811201L,BigInteger.Parse("1075342687614074880001"),BigInteger.Parse("8547762518578406446202880000001"),BigInteger.Parse("59043709472234119545920159524322926688993280000000001"),BigInteger.Parse("698533028148544417308552639358841460358000936394290829866303488000000000001") };
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
public class A245495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245495Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245495.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245495.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245495Inst Instance=new A245495Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245496
{
public static readonly BigInteger[] Value={ 1L,2L,10L,87L,1096L,18045L,365796L,8793337L,244327616L,7701562377L,271493172100L,10582453248741L,451909972458000L,20980984760560045L,1052197311966267572L,BigInteger.Parse("56683993296812515425"),BigInteger.Parse("3264626390205804733696"),BigInteger.Parse("200168726219982496336401"),BigInteger.Parse("13017989155680578824221060") };
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
public class A245496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245496Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245496.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245496.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245496Inst Instance=new A245496Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245497
{
public static readonly long[] Value={ 2L,2L,8L,2L,18L,8L,18L,8L,50L,8L,72L,18L,32L,32L,128L,18L,162L,32L,72L,50L,242L,32L,200L,72L,162L,72L,392L,32L,450L,128L,200L,128L,288L,72L,648L,162L,288L,128L,800L,72L,882L,200L,288L,242L,1058L,128L,882L,200L,512L,288L,1352L,162L,800L,288L,648L,392L,1682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245497Inst : IEnumerable<long>
{
public static readonly long[] Value=A245497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245497.Bytes);
public long this[int i]=>Value[i];

public static A245497Inst Instance=new A245497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245498
{
public static readonly long[] Value={ 3L,18L,3L,3L,2L,78L,3L,4L,3L,118L,2L,146L,3L,3L,3L,164L,2L,44L,2L,2L,3L,53L,2L,3L,3L,4L,3L,53L,2L,403L,3L,18L,3L,3L,2L,957L,3L,3L,2L,99L,2L,369L,3L,3L,3L,533L,2L,8L,3L,18L,3L,164L,2L,3L,3L,7L,3L,381L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245498Inst : IEnumerable<long>
{
public static readonly long[] Value=A245498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245498.Bytes);
public long this[int i]=>Value[i];

public static A245498Inst Instance=new A245498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245499
{
public static readonly long[] Value={ 1L,2L,3L,6L,3L,6L,8L,4L,5L,8L,10L,6L,8L,12L,7L,8L,14L,8L,10L,12L,15L,9L,10L,12L,15L,18L,11L,18L,22L,12L,15L,20L,13L,18L,26L,14L,15L,18L,20L,21L,15L,18L,20L,24L,16L,17L,18L,34L,18L,24L,27L,19L,32L,38L,20L,24L,30L,21L,27L,28L,22L,24L,33L,23L,32L,46L,24L,27L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245499Inst : IEnumerable<long>
{
public static readonly long[] Value=A245499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245499.Bytes);
public long this[int i]=>Value[i];

public static A245499Inst Instance=new A245499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245500
{
public static readonly long[] Value={ 0L,1L,2L,11L,21L,31L,22L,41L,211L,311L,221L,411L,321L,421L,3111L,2211L,4111L,3211L,4211L,3311L,5211L,4311L,6211L,4221L,32111L,4411L,5221L,42111L,33111L,52111L,43111L,62111L,42211L,53111L,44111L,52211L,63111L,421111L,331111L,521111L,431111L,621111L,422111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245500Inst : IEnumerable<long>
{
public static readonly long[] Value=A245500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245500.Bytes);
public long this[int i]=>Value[i];

public static A245500Inst Instance=new A245500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245501
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,3L,27L,1L,1L,1L,4L,10L,256L,1L,1L,1L,3L,19L,41L,3125L,1L,1L,1L,4L,12L,110L,196L,46656L,1L,1L,1L,3L,19L,73L,751L,1057L,823543L,1L,1L,1L,4L,10L,116L,556L,5902L,6322L,16777216L,1L,1L,1L,3L,21L,41L,901L,4737L,52165L,41393L,387420489L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245501Inst : IEnumerable<long>
{
public static readonly long[] Value=A245501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245501.Bytes);
public long this[int i]=>Value[i];

public static A245501Inst Instance=new A245501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245502
{
public static readonly BigInteger[] Value={ 1L,1L,3L,10L,41L,220L,1921L,25474L,384113L,5785192L,85295105L,1244587246L,18399553801L,286188407116L,4920039471089L,96938148715090L,2172951409994081L,53076309208887760L,1351935357372173953L,BigInteger.Parse("35000099470802409814"),BigInteger.Parse("914038174404012874745"),BigInteger.Parse("24209598764577808155316") };
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
public class A245502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245502Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245502.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245502.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245502Inst Instance=new A245502Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245503
{
public static readonly BigInteger[] Value={ 1L,1L,4L,21L,142L,1131L,10422L,112015L,1396516L,19702665L,306547426L,5177584809L,94168757916L,1833590759131L,38009888806450L,835064706091431L,19389119390412448L,475039405292487825L,12263445905182200882UL,BigInteger.Parse("332913448508180564521"),BigInteger.Parse("9478703390668813103836") };
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
public class A245503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245503Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245503.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245503.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245503Inst Instance=new A245503Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245504
{
public static readonly BigInteger[] Value={ 1L,1L,3L,10L,41L,196L,1057L,7042L,87473L,2004328L,50881121L,1200507694L,26179091017L,538344201292L,10635924720449L,204889902343666L,3902206399428833L,74966895289570768L,1511315984060460865L,BigInteger.Parse("34267718094037895638"),BigInteger.Parse("937490346932078590841"),BigInteger.Parse("30931366331911427839156") };
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
public class A245504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245504Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245504.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245504.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245504Inst Instance=new A245504Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245505
{
public static readonly BigInteger[] Value={ 1L,1L,4L,19L,116L,901L,8422L,89755L,1066088L,14154409L,212952266L,3646226959L,69912304156L,1460516349709L,32480282189006L,759186766079011L,18569220500830928L,475114325555073745L,12719547174925542034UL,BigInteger.Parse("356098625214192355735"),BigInteger.Parse("10413932958067814029316") };
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
public class A245505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245505.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245505Inst Instance=new A245505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245506
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,73L,556L,4737L,44122L,453441L,5226984L,69703201L,1132247854L,22865062497L,541274154604L,13810143608913L,361165919643666L,9534875308290433L,254667431232941008L,6928956222876625473L,BigInteger.Parse("193066959857334885334"),BigInteger.Parse("5521621116955849623201") };
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
public class A245506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245506.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245506Inst Instance=new A245506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245507
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,73L,901L,1921L,112015L,87473L,14154409L,69703201L,2929242031L,679876297L,3090182325361L,107695177409L,442870698673621L,7233741446307841L,475492243447425745L,6964488144903745L,BigInteger.Parse("672629401563923828521"),2588222103446878841L,BigInteger.Parse("615608908275758056730701") };
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
public class A245507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245507.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245507Inst Instance=new A245507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245508
{
public static readonly long[] Value={ 2L,8L,8L,8L,18L,18L,18L,32L,32L,32L,32L,50L,50L,50L,50L,72L,72L,72L,72L,72L,98L,98L,98L,98L,98L,128L,128L,128L,128L,128L,128L,162L,162L,162L,162L,162L,162L,200L,200L,200L,200L,200L,200L,200L,200L,200L,242L,242L,242L,242L,242L,242L,242L,288L,288L,288L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245508Inst : IEnumerable<long>
{
public static readonly long[] Value=A245508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245508.Bytes);
public long this[int i]=>Value[i];

public static A245508Inst Instance=new A245508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245509
{
public static readonly long[] Value={ 3L,5L,3L,2L,3L,1L,1L,3L,3L,2L,2L,1L,1L,3L,3L,2L,2L,1L,1L,3L,2L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,2L,3L,1L,1L,3L,3L,2L,2L,1L,1L,5L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,3L,2L,2L,2L,1L,1L,1L,1L,2L,3L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,2L,2L,1L,1L,3L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245509Inst : IEnumerable<long>
{
public static readonly long[] Value=A245509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245509.Bytes);
public long this[int i]=>Value[i];

public static A245509Inst Instance=new A245509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245510
{
public static readonly long[] Value={ 7L,5L,2L,105L,3L,909L,4995825L,28212939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245510Inst : IEnumerable<long>
{
public static readonly long[] Value=A245510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245510.Bytes);
public long this[int i]=>Value[i];

public static A245510Inst Instance=new A245510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245511
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,3L,2L,4L,1L,1L,2L,3L,2L,4L,1L,1L,2L,4L,2L,3L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,3L,1L,1L,1L,1L,2L,2L,1L,1L,2L,3L,2L,2L,1L,1L,2L,3L,1L,1L,1L,1L,2L,3L,1L,1L,1L,1L,2L,3L,2L,3L,1L,1L,1L,1L,2L,3L,1L,1L,2L,2L,2L,3L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245511Inst : IEnumerable<long>
{
public static readonly long[] Value=A245511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245511.Bytes);
public long this[int i]=>Value[i];

public static A245511Inst Instance=new A245511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245512
{
public static readonly long[] Value={ 2L,4L,5L,9L,279L,15331L,1685775L,205670529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245512Inst : IEnumerable<long>
{
public static readonly long[] Value=A245512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245512.Bytes);
public long this[int i]=>Value[i];

public static A245512Inst Instance=new A245512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245513
{
public static readonly long[] Value={ 6L,7L,3L,4L,3L,3L,2L,6L,3L,2L,2L,3L,3L,6L,3L,2L,2L,4L,3L,3L,2L,1L,3L,2L,1L,4L,2L,5L,2L,2L,2L,3L,1L,3L,3L,1L,2L,3L,3L,2L,2L,3L,2L,5L,2L,1L,2L,3L,1L,2L,2L,1L,3L,3L,1L,3L,2L,2L,2L,3L,2L,6L,1L,2L,3L,1L,2L,5L,2L,4L,2L,2L,3L,3L,1L,3L,2L,1L,2L,3L,2L,1L,3L,2L,1L,2L,2L,1L,3L,2L,1L,1L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245513Inst : IEnumerable<long>
{
public static readonly long[] Value=A245513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245513.Bytes);
public long this[int i]=>Value[i];

public static A245513Inst Instance=new A245513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245514
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,1L,1L,3L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245514Inst : IEnumerable<long>
{
public static readonly long[] Value=A245514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245514.Bytes);
public long this[int i]=>Value[i];

public static A245514Inst Instance=new A245514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245515
{
public static readonly long[] Value={ 1L,2L,0L,0L,0L,0L,0L,0L,0L,0L,11L,0L,0L,0L,0L,0L,0L,0L,19L,0L,0L,0L,0L,0L,0L,0L,0L,0L,29L,0L,31L,0L,0L,0L,0L,0L,0L,0L,0L,0L,41L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,59L,0L,61L,0L,0L,0L,0L,0L,0L,0L,0L,0L,71L,0L,0L,0L,0L,0L,0L,0L,79L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245515Inst : IEnumerable<long>
{
public static readonly long[] Value=A245515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245515.Bytes);
public long this[int i]=>Value[i];

public static A245515Inst Instance=new A245515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245516
{
public static readonly long[] Value={ 5L,3L,9L,3L,3L,3L,7L,7L,3L,21L,9L,7L,19L,5L,7L,39L,15L,61L,15L,19L,21L,3L,19L,17L,21L,5L,21L,7L,85L,17L,7L,21L,511L,27L,27L,59L,3L,19L,91L,45L,3L,29L,321L,65L,9L,379L,69L,125L,49L,5L,9L,45L,289L,341L,61L,89L,171L,171L,139L,21L,139L,75L,25L,49L,15L,51L,57L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245516Inst : IEnumerable<long>
{
public static readonly long[] Value=A245516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245516.Bytes);
public long this[int i]=>Value[i];

public static A245516Inst Instance=new A245516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245517
{
public static readonly long[] Value={ 1L,1L,4L,4L,4L,12L,20L,20L,12L,32L,88L,96L,88L,32L,80L,352L,504L,504L,352L,80L,192L,1328L,2592L,2880L,2592L,1328L,192L,448L,4816L,12852L,17280L,17280L,12852L,4816L,448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245517Inst : IEnumerable<long>
{
public static readonly long[] Value=A245517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245517.Bytes);
public long this[int i]=>Value[i];

public static A245517Inst Instance=new A245517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245518
{
public static readonly long[] Value={ 1L,0L,1L,4L,2L,2L,4L,16L,12L,8L,12L,16L,64L,64L,40L,40L,64L,64L,284L,328L,236L,176L,236L,328L,284L,1360L,1760L,1432L,1000L,1000L,1432L,1760L,1360L,7184L,9928L,9092L,6536L,5312L,6536L,9092L,9928L,7184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245518Inst : IEnumerable<long>
{
public static readonly long[] Value=A245518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245518.Bytes);
public long this[int i]=>Value[i];

public static A245518Inst Instance=new A245518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245519
{
public static readonly long[] Value={ 0L,0L,0L,2L,10L,64L,336L,1872L,11104L,71944L,508032L,3511232L,27192704L,223750464L,1947253504L,17899536448L,173156535168L,1760383827776L,18752453106176L,209034916385472L,2432351796434560L,29509268795249700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245519Inst : IEnumerable<long>
{
public static readonly long[] Value=A245519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245519.Bytes);
public long this[int i]=>Value[i];

public static A245519Inst Instance=new A245519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245520
{
public static readonly long[] Value={ 1L,5L,5L,25L,31L,32L,1014L,1029L,1046L,1052L,1052L,1609194L,1613310L,1615739L,1616376L,1617055L,1617118L,1617155L,1617155L,1617173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245520Inst : IEnumerable<long>
{
public static readonly long[] Value=A245520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245520.Bytes);
public long this[int i]=>Value[i];

public static A245520Inst Instance=new A245520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245521
{
public static readonly long[] Value={ 2L,11L,11L,97L,127L,131L,8069L,8209L,8353L,8419L,8419L,25739339L,25808903L,25849871L,25861123L,25872397L,25873667L,25874437L,25874437L,25874767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245521Inst : IEnumerable<long>
{
public static readonly long[] Value=A245521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245521.Bytes);
public long this[int i]=>Value[i];

public static A245521Inst Instance=new A245521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245522
{
public static readonly long[] Value={ 3L,11L,15L,15L,31L,39L,373L,1285L,1285L,1285L,2119L,2119L,15605L,29223L,52225L,52225L,186157L,186157L,1378927L,3137489L,4189897L,4189897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245522Inst : IEnumerable<long>
{
public static readonly long[] Value=A245522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245522.Bytes);
public long this[int i]=>Value[i];

public static A245522Inst Instance=new A245522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245523
{
public static readonly long[] Value={ 5L,31L,47L,47L,127L,167L,2549L,10501L,10501L,10501L,18503L,18503L,171253L,340519L,642049L,642049L,2545453L,2545453L,21826159L,52420561L,71298761L,71298761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245523Inst : IEnumerable<long>
{
public static readonly long[] Value=A245523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245523.Bytes);
public long this[int i]=>Value[i];

public static A245523Inst Instance=new A245523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245524
{
public static readonly long[] Value={ 1L,3L,10L,14L,27L,33L,52L,60L,85L,95L,126L,138L,175L,189L,232L,248L,297L,315L,370L,390L,451L,473L,540L,564L,637L,663L,742L,770L,855L,885L,976L,1008L,1105L,1139L,1242L,1278L,1387L,1425L,1540L,1580L,1701L,1743L,1870L,1914L,2047L,2093L,2232L,2280L,2425L,2475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245524Inst : IEnumerable<long>
{
public static readonly long[] Value=A245524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245524.Bytes);
public long this[int i]=>Value[i];

public static A245524Inst Instance=new A245524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245525
{
public static readonly long[] Value={ 1L,-1L,-2L,-2L,-4L,-2L,-2L,3L,7L,13L,-6L,3L,19L,6L,-12L,19L,2L,19L,21L,-12L,-11L,-25L,10L,-27L,18L,12L,23L,-27L,-13L,-46L,-16L,-35L,5L,-61L,-17L,8L,-29L,-65L,-44L,-30L,12L,-40L,40L,-95L,90L,88L,53L,93L,97L,-42L,-47L,47L,2L,117L,-16L,34L,27L,51L,-11L,108L,-24L,115L,-29L,30L,-32L,-90L,-87L,141L,24L,131L,-166L,-115L,-96L,-111L,84L,-191L,163L,-156L,115L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245525Inst : IEnumerable<long>
{
public static readonly long[] Value=A245525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245525.Bytes);
public long this[int i]=>Value[i];

public static A245525Inst Instance=new A245525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245526
{
public static readonly long[] Value={ 1L,1L,-2L,-2L,2L,-3L,-7L,3L,5L,-11L,-15L,8L,-18L,-14L,3L,-12L,19L,-18L,25L,14L,5L,21L,11L,7L,-22L,3L,43L,-40L,-7L,-53L,54L,23L,11L,-12L,-7L,41L,6L,-13L,-66L,71L,-32L,18L,94L,-20L,-79L,7L,-88L,12L,11L,-73L,3L,29L,-120L,50L,10L,-60L,-63L,34L,94L,47L,-113L,131L,-18L,128L,60L,57L,79L,22L,-45L,-68L,100L,100L,131L,-171L,56L,-166L,11L,-153L,-174L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245526Inst : IEnumerable<long>
{
public static readonly long[] Value=A245526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245526.Bytes);
public long this[int i]=>Value[i];

public static A245526Inst Instance=new A245526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245527
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,3L,3L,0L,0L,4L,6L,4L,0L,5L,10L,10L,5L,6L,15L,20L,15L,13L,21L,35L,35L,29L,35L,56L,70L,65L,64L,92L,126L,136L,129L,156L,219L,263L,265L,285L,375L,484L,528L,550L,660L,860L,1013L,1078L,1210L,1521L,1873L,2092L,2288L,2732L,3394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245527Inst : IEnumerable<long>
{
public static readonly long[] Value=A245527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245527.Bytes);
public long this[int i]=>Value[i];

public static A245527Inst Instance=new A245527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245528
{
public static readonly BigInteger[] Value={ 19L,101L,35999L,327599L,3306239L,81430271999L,BigInteger.Parse("24779106953279078399999"),BigInteger.Parse("10501089199335077511167999999"),BigInteger.Parse("1372369506422963989169318155460666934165503999999999"),BigInteger.Parse("117024364553755119629556890816711613171571359743999999999") };
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
public class A245528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245528Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245528.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245528.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245528Inst Instance=new A245528Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245529
{
public static readonly long[] Value={ 2693L,123653L,1812389L,2349407L,12686723L,201183431L,332997529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245529Inst : IEnumerable<long>
{
public static readonly long[] Value=A245529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245529.Bytes);
public long this[int i]=>Value[i];

public static A245529Inst Instance=new A245529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245530
{
public static readonly long[] Value={ 1L,36L,144L,4L,400L,576L,784L,14400L,9L,32400L,4356L,3600L,6084L,1587600L,129600L,16L,10404L,11664L,23104L,14400L,15876L,17424L,33856L,20736L,25L,876096L,25401600L,1254400L,53824L,44100L,61504L,57600L,85377600L,4161600L,2822400L,36L,136900L,116964L,97344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245530Inst : IEnumerable<long>
{
public static readonly long[] Value=A245530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245530.Bytes);
public long this[int i]=>Value[i];

public static A245530Inst Instance=new A245530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245531
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,7L,12L,21L,36L,62L,108L,187L,325L,563L,975L,1688L,2925L,5068L,8780L,15210L,26351L,45652L,79091L,137021L,237383L,411255L,712481L,1234342L,2138441L,3704752L,6418316L,11119441L,19263928L,33373883L,57818741L,100168351L,173537132L,300645222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245531Inst : IEnumerable<long>
{
public static readonly long[] Value=A245531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245531.Bytes);
public long this[int i]=>Value[i];

public static A245531Inst Instance=new A245531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245532
{
public static readonly long[] Value={ 0L,1L,7L,3L,2L,7L,1L,4L,0L,5L,4L,7L,3L,6L,6L,9L,9L,1L,2L,8L,8L,0L,8L,3L,1L,8L,9L,8L,6L,9L,0L,6L,7L,3L,9L,9L,0L,7L,0L,9L,5L,8L,3L,6L,0L,6L,3L,6L,4L,3L,2L,1L,4L,5L,1L,3L,0L,4L,9L,2L,1L,6L,3L,3L,6L,8L,3L,4L,6L,0L,0L,3L,2L,4L,2L,1L,6L,7L,2L,6L,3L,1L,2L,7L,4L,1L,2L,3L,4L,3L,8L,3L,0L,6L,2L,0L,3L,9L,5L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245532Inst : IEnumerable<long>
{
public static readonly long[] Value=A245532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245532.Bytes);
public long this[int i]=>Value[i];

public static A245532Inst Instance=new A245532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245533
{
public static readonly long[] Value={ 8L,2L,4L,7L,8L,3L,0L,3L,0L,9L,1L,4L,6L,2L,2L,4L,9L,6L,5L,7L,1L,9L,3L,7L,6L,6L,0L,1L,9L,9L,3L,2L,8L,3L,1L,8L,6L,9L,3L,7L,8L,9L,6L,1L,3L,3L,3L,0L,8L,7L,2L,0L,6L,7L,1L,0L,8L,4L,6L,4L,7L,5L,8L,2L,7L,0L,7L,5L,1L,9L,3L,5L,0L,7L,2L,8L,5L,5L,4L,4L,2L,7L,8L,9L,7L,1L,7L,8L,9L,4L,5L,7L,1L,4L,5L,9L,1L,3L,8L,9L,9L,1L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245533Inst : IEnumerable<long>
{
public static readonly long[] Value=A245533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245533.Bytes);
public long this[int i]=>Value[i];

public static A245533Inst Instance=new A245533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245534
{
public static readonly long[] Value={ 1L,5L,8L,18L,23L,39L,46L,68L,77L,105L,116L,150L,163L,203L,218L,264L,281L,333L,352L,410L,431L,495L,518L,588L,613L,689L,716L,798L,827L,915L,946L,1040L,1073L,1173L,1208L,1314L,1351L,1463L,1502L,1620L,1661L,1785L,1828L,1958L,2003L,2139L,2186L,2328L,2377L,2525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245534Inst : IEnumerable<long>
{
public static readonly long[] Value=A245534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245534.Bytes);
public long this[int i]=>Value[i];

public static A245534Inst Instance=new A245534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245535
{
public static readonly long[] Value={ 0L,6L,5L,7L,8L,3L,8L,8L,8L,2L,6L,6L,4L,4L,8L,0L,9L,9L,0L,5L,6L,5L,5L,1L,2L,1L,8L,0L,8L,7L,4L,7L,0L,4L,6L,6L,9L,4L,9L,9L,5L,6L,4L,8L,0L,3L,2L,1L,6L,0L,5L,1L,2L,7L,3L,0L,7L,1L,3L,2L,0L,4L,7L,5L,3L,5L,4L,7L,9L,5L,3L,9L,7L,2L,9L,6L,1L,7L,7L,0L,4L,0L,8L,5L,8L,7L,1L,0L,5L,8L,8L,9L,9L,7L,8L,4L,5L,3L,3L,7L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245535Inst : IEnumerable<long>
{
public static readonly long[] Value=A245535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245535.Bytes);
public long this[int i]=>Value[i];

public static A245535Inst Instance=new A245535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245536
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,2L,0L,0L,0L,0L,1L,0L,2L,3L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,2L,0L,3L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,2L,2L,0L,0L,2L,3L,0L,4L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245536Inst : IEnumerable<long>
{
public static readonly long[] Value=A245536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245536.Bytes);
public long this[int i]=>Value[i];

public static A245536Inst Instance=new A245536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245537
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,3L,14L,1L,1L,1L,3L,3L,3L,14L,52L,1L,1L,1L,3L,1L,1L,3L,14L,3L,3L,3L,9L,14L,14L,52L,216L,1L,1L,1L,3L,1L,1L,3L,14L,1L,1L,1L,3L,3L,3L,14L,52L,3L,3L,3L,9L,3L,3L,9L,42L,14L,14L,14L,42L,52L,52L,216L,848L,1L,1L,1L,3L,1L,1L,3L,14L,1L,1L,1L,3L,3L,3L,14L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245537Inst : IEnumerable<long>
{
public static readonly long[] Value=A245537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245537.Bytes);
public long this[int i]=>Value[i];

public static A245537Inst Instance=new A245537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245538
{
public static readonly long[] Value={ 1L,1L,3L,1L,2L,3L,14L,1L,2L,2L,6L,3L,6L,14L,52L,1L,2L,2L,6L,2L,4L,6L,28L,3L,6L,6L,18L,14L,28L,52L,216L,1L,2L,2L,6L,2L,4L,6L,28L,2L,4L,4L,12L,6L,12L,28L,104L,3L,6L,6L,18L,6L,12L,18L,84L,14L,28L,28L,84L,52L,104L,216L,848L,1L,2L,2L,6L,2L,4L,6L,28L,2L,4L,4L,12L,6L,12L,28L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245538Inst : IEnumerable<long>
{
public static readonly long[] Value=A245538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245538.Bytes);
public long this[int i]=>Value[i];

public static A245538Inst Instance=new A245538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245539
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,3L,14L,1L,4L,4L,12L,3L,12L,14L,52L,1L,4L,4L,12L,4L,16L,12L,56L,3L,12L,12L,36L,14L,56L,52L,216L,1L,4L,4L,12L,4L,16L,12L,56L,4L,16L,16L,48L,12L,48L,56L,208L,3L,12L,12L,36L,12L,48L,36L,168L,14L,56L,56L,168L,52L,208L,216L,848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245539Inst : IEnumerable<long>
{
public static readonly long[] Value=A245539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245539.Bytes);
public long this[int i]=>Value[i];

public static A245539Inst Instance=new A245539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245540
{
public static readonly long[] Value={ 1L,2L,5L,6L,14L,17L,31L,32L,40L,48L,72L,75L,99L,113L,165L,166L,174L,182L,206L,214L,278L,302L,414L,417L,441L,465L,537L,551L,663L,715L,931L,932L,940L,948L,972L,980L,1044L,1068L,1180L,1188L,1252L,1316L,1508L,1532L,1724L,1836L,2252L,2255L,2279L,2303L,2375L,2399L,2591L,2663L,2999L,3013L,3125L,3237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245540Inst : IEnumerable<long>
{
public static readonly long[] Value=A245540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245540.Bytes);
public long this[int i]=>Value[i];

public static A245540Inst Instance=new A245540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245541
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,3L,6L,1L,1L,1L,3L,3L,3L,6L,10L,1L,1L,1L,3L,1L,1L,3L,6L,3L,3L,3L,9L,6L,6L,10L,15L,1L,1L,1L,3L,1L,1L,3L,6L,1L,1L,1L,3L,3L,3L,6L,10L,3L,3L,3L,9L,3L,3L,9L,18L,6L,6L,6L,18L,10L,10L,15L,21L,1L,1L,1L,3L,1L,1L,3L,6L,1L,1L,1L,3L,3L,3L,6L,10L,1L,1L,1L,3L,1L,1L,3L,6L,3L,3L,3L,9L,6L,6L,10L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245541Inst : IEnumerable<long>
{
public static readonly long[] Value=A245541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245541.Bytes);
public long this[int i]=>Value[i];

public static A245541Inst Instance=new A245541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245542
{
public static readonly long[] Value={ 1L,9L,17L,41L,49L,113L,137L,249L,257L,321L,385L,577L,601L,793L,905L,1321L,1329L,1393L,1457L,1649L,1713L,2225L,2417L,3313L,3337L,3529L,3721L,4297L,4409L,5305L,5721L,7449L,7457L,7521L,7585L,7777L,7841L,8353L,8545L,9441L,9505L,10017L,10529L,12065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245542Inst : IEnumerable<long>
{
public static readonly long[] Value=A245542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245542.Bytes);
public long this[int i]=>Value[i];

public static A245542Inst Instance=new A245542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245543
{
public static readonly long[] Value={ 7L,0L,16L,-16L,56L,-40L,88L,-104L,56L,0L,128L,-168L,168L,-80L,304L,-408L,56L,0L,128L,-128L,448L,-320L,704L,-872L,168L,0L,384L,-464L,784L,-480L,1312L,-1720L,56L,0L,128L,-128L,448L,-320L,704L,-832L,448L,0L,1024L,-1344L,1344L,-640L,2432L,-3304L,168L,0L,384L,-384L,1344L,-960L,2112L,-2576L,784L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245543Inst : IEnumerable<long>
{
public static readonly long[] Value=A245543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245543.Bytes);
public long this[int i]=>Value[i];

public static A245543Inst Instance=new A245543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245544
{
public static readonly long[] Value={ 1L,0L,0L,0L,4L,84L,1992L,94011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245544Inst : IEnumerable<long>
{
public static readonly long[] Value=A245544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245544.Bytes);
public long this[int i]=>Value[i];

public static A245544Inst Instance=new A245544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245545
{
public static readonly long[] Value={ 0L,1L,4L,11L,59L,264L,2764L,29750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245545Inst : IEnumerable<long>
{
public static readonly long[] Value=A245545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245545.Bytes);
public long this[int i]=>Value[i];

public static A245545Inst Instance=new A245545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245546
{
public static readonly long[] Value={ 0L,1L,2L,21L,49L,505L,6361L,137319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245546Inst : IEnumerable<long>
{
public static readonly long[] Value=A245546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245546.Bytes);
public long this[int i]=>Value[i];

public static A245546Inst Instance=new A245546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245547
{
public static readonly long[] Value={ 1L,1L,3L,1L,2L,3L,6L,1L,2L,2L,6L,3L,6L,6L,10L,1L,2L,2L,6L,2L,4L,6L,12L,3L,6L,6L,18L,6L,12L,10L,15L,1L,2L,2L,6L,2L,4L,6L,12L,2L,4L,4L,12L,6L,12L,12L,20L,3L,6L,6L,18L,6L,12L,18L,36L,6L,12L,12L,36L,10L,20L,15L,21L,1L,2L,2L,6L,2L,4L,6L,12L,2L,4L,4L,12L,6L,12L,12L,20L,2L,4L,4L,12L,4L,8L,12L,24L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245547Inst : IEnumerable<long>
{
public static readonly long[] Value=A245547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245547.Bytes);
public long this[int i]=>Value[i];

public static A245547Inst Instance=new A245547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245548
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,1L,2L,3L,1L,3L,1L,1L,1L,1L,1L,2L,2L,3L,2L,1L,1L,3L,1L,4L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,3L,2L,5L,1L,1L,1L,3L,4L,1L,4L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,3L,2L,2L,2L,3L,5L,2L,5L,2L,1L,1L,1L,1L,2L,3L,4L,3L,1L,1L,4L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245548Inst : IEnumerable<long>
{
public static readonly long[] Value=A245548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245548.Bytes);
public long this[int i]=>Value[i];

public static A245548Inst Instance=new A245548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245549
{
public static readonly BigInteger[] Value={ 1L,111L,11001L,1101111L,110010001L,11011110111L,1100100001001L,110111100111111L,11001000111000001L,1101111011001000111L,BigInteger.Parse("110010000101111011001"),BigInteger.Parse("11011110011010000101111") };
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
public class A245549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245549Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245549.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245549.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245549Inst Instance=new A245549Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245550
{
public static readonly long[] Value={ 0L,1L,3L,3L,7L,5L,9L,9L,17L,11L,15L,15L,23L,19L,27L,27L,43L,29L,33L,33L,41L,37L,45L,45L,61L,49L,57L,57L,73L,65L,81L,81L,113L,83L,87L,87L,95L,91L,99L,99L,115L,103L,111L,111L,127L,119L,135L,135L,167L,139L,147L,147L,163L,155L,171L,171L,203L,179L,195L,195L,227L,211L,243L,243L,307L,245L,249L,249L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245550Inst : IEnumerable<long>
{
public static readonly long[] Value=A245550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245550.Bytes);
public long this[int i]=>Value[i];

public static A245550Inst Instance=new A245550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245551
{
public static readonly long[] Value={ 1L,5L,25L,105L,420L,1596L,5880L,21120L,74415L,258115L,883883L,2994355L,10051860L,33479460L,110750580L,364177332L,1191186855L,3877914915L,12571302975L,40598200335L,130657125984L,419173385400L,1340928798300L,4278305877300L,13617034683525L,43243221276801L,137040737988105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245551Inst : IEnumerable<long>
{
public static readonly long[] Value=A245551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245551.Bytes);
public long this[int i]=>Value[i];

public static A245551Inst Instance=new A245551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245552
{
public static readonly long[] Value={ 0L,1L,0L,3L,0L,0L,0L,5L,0L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,0L,9L,0L,0L,0L,0L,0L,0L,0L,0L,0L,11L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,13L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,15L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,17L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245552Inst : IEnumerable<long>
{
public static readonly long[] Value=A245552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245552.Bytes);
public long this[int i]=>Value[i];

public static A245552Inst Instance=new A245552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245553
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,3L,1L,2L,3L,3L,1L,3L,1L,1L,2L,3L,2L,3L,3L,1L,3L,1L,1L,2L,3L,3L,1L,1L,2L,3L,1L,2L,3L,2L,3L,3L,1L,2L,3L,3L,1L,3L,1L,1L,2L,3L,3L,1L,1L,2L,3L,1L,2L,3L,2L,3L,3L,1L,3L,1L,1L,2L,3L,1L,2L,3L,2L,3L,3L,1L,1L,2L,3L,2L,3L,3L,1L,2L,3L,3L,1L,3L,1L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245553Inst : IEnumerable<long>
{
public static readonly long[] Value=A245553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245553.Bytes);
public long this[int i]=>Value[i];

public static A245553Inst Instance=new A245553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245554
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,1L,2L,1L,3L,1L,1L,1L,2L,1L,3L,3L,1L,2L,1L,3L,1L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,3L,1L,2L,1L,3L,1L,1L,1L,2L,1L,3L,3L,1L,2L,1L,3L,1L,1L,2L,1L,3L,1L,2L,1L,3L,3L,1L,2L,1L,3L,1L,1L,2L,1L,3L,3L,1L,2L,1L,3L,1L,1L,2L,1L,3L,3L,1L,2L,1L,3L,1L,1L,1L,2L,1L,3L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245554Inst : IEnumerable<long>
{
public static readonly long[] Value=A245554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245554.Bytes);
public long this[int i]=>Value[i];

public static A245554Inst Instance=new A245554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245555
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,3L,1L,2L,3L,3L,1L,3L,1L,1L,2L,2L,3L,3L,1L,3L,1L,1L,2L,3L,1L,1L,2L,1L,2L,2L,3L,2L,3L,3L,1L,3L,1L,1L,2L,3L,1L,1L,2L,1L,2L,2L,3L,3L,1L,1L,2L,1L,2L,2L,3L,1L,2L,2L,3L,2L,3L,3L,1L,2L,3L,3L,1L,3L,1L,1L,2L,3L,1L,1L,2L,1L,2L,2L,3L,3L,1L,1L,2L,1L,2L,2L,3L,1L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245555Inst : IEnumerable<long>
{
public static readonly long[] Value=A245555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245555.Bytes);
public long this[int i]=>Value[i];

public static A245555Inst Instance=new A245555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245556
{
public static readonly long[] Value={ 1L,4L,6L,4L,7L,12L,19L,12L,7L,10L,18L,28L,36L,28L,18L,10L,13L,24L,37L,48L,61L,48L,37L,24L,13L,16L,30L,46L,60L,76L,90L,76L,60L,46L,30L,16L,19L,36L,55L,72L,91L,108L,127L,108L,91L,72L,55L,36L,19L,22L,42L,64L,84L,106L,126L,148L,168L,148L,126L,106L,84L,64L,42L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245556Inst : IEnumerable<long>
{
public static readonly long[] Value=A245556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245556.Bytes);
public long this[int i]=>Value[i];

public static A245556Inst Instance=new A245556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245557
{
public static readonly long[] Value={ 1L,3L,6L,4L,3L,6L,15L,12L,7L,3L,6L,9L,24L,21L,18L,10L,3L,6L,9L,12L,33L,30L,27L,24L,13L,3L,6L,9L,12L,15L,42L,39L,36L,33L,30L,16L,3L,6L,9L,12L,15L,18L,51L,48L,45L,42L,39L,36L,19L,3L,6L,9L,12L,15L,18L,21L,60L,57L,54L,51L,48L,45L,42L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245557Inst : IEnumerable<long>
{
public static readonly long[] Value=A245557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245557.Bytes);
public long this[int i]=>Value[i];

public static A245557Inst Instance=new A245557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245558
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,3L,2L,1L,1L,3L,5L,5L,3L,1L,1L,3L,7L,8L,7L,3L,1L,1L,4L,9L,14L,14L,9L,4L,1L,1L,4L,12L,20L,25L,20L,12L,4L,1L,1L,5L,15L,30L,42L,42L,30L,15L,5L,1L,1L,5L,18L,40L,66L,75L,66L,40L,18L,5L,1L,1L,6L,22L,55L,99L,132L,132L,99L,55L,22L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245558Inst : IEnumerable<long>
{
public static readonly long[] Value=A245558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245558.Bytes);
public long this[int i]=>Value[i];

public static A245558Inst Instance=new A245558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245559
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,2L,5L,8L,1L,3L,7L,14L,25L,1L,3L,9L,20L,42L,75L,1L,4L,12L,30L,66L,132L,245L,1L,4L,15L,40L,99L,212L,429L,800L,1L,5L,18L,55L,143L,333L,715L,1430L,2700L,1L,5L,22L,70L,200L,497L,1144L,2424L,4862L,9225L,1L,6L,26L,91L,273L,728L,1768L,3978L,8398L,16796L,32065L,1L,6L,30L,112L,364L,1026L,2652L,6288L,13995L,29372L,58786L,112632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245559Inst : IEnumerable<long>
{
public static readonly long[] Value=A245559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245559.Bytes);
public long this[int i]=>Value[i];

public static A245559Inst Instance=new A245559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245560
{
public static readonly long[] Value={ 1L,2L,6L,14L,36L,82L,196L,436L,1000L,2186L,4884L,10540L,23128L,49428L,107048L,227048L,486864L,1026394L,2183860L,4581244L,9686776L,20237372L,42571896L,88632664L,185653936L,385380932L,804316296L,1665340856L,3464899440L,7158117736L,14853106384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245560Inst : IEnumerable<long>
{
public static readonly long[] Value=A245560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245560.Bytes);
public long this[int i]=>Value[i];

public static A245560Inst Instance=new A245560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245561
{
public static readonly long[] Value={ 0L,1L,11L,76L,451L,2501L,13376L,70001L,361251L,1846876L,9381251L,47437501L,239109376L,1202500001L,6037656251L,30279296876L,151725781251L,759820312501L,3803412109376L,19032656250001L,95219707031251L,476302685546876L,2382252050781251L,11913932617187501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245561Inst : IEnumerable<long>
{
public static readonly long[] Value=A245561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245561.Bytes);
public long this[int i]=>Value[i];

public static A245561Inst Instance=new A245561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245562
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,3L,4L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,3L,2L,2L,1L,2L,1L,2L,2L,3L,3L,1L,4L,5L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,3L,1L,4L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245562Inst : IEnumerable<long>
{
public static readonly long[] Value=A245562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245562.Bytes);
public long this[int i]=>Value[i];

public static A245562Inst Instance=new A245562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245563
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,3L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,2L,2L,3L,1L,3L,4L,5L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,3L,1L,4L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,1L,2L,2L,2L,3L,2L,3L,1L,3L,1L,3L,2L,3L,4L,1L,4L,5L,6L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245563Inst : IEnumerable<long>
{
public static readonly long[] Value=A245563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245563.Bytes);
public long this[int i]=>Value[i];

public static A245563Inst Instance=new A245563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245564
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,3L,5L,2L,4L,4L,6L,3L,6L,5L,8L,2L,4L,4L,6L,4L,8L,6L,10L,3L,6L,6L,9L,5L,10L,8L,13L,2L,4L,4L,6L,4L,8L,6L,10L,4L,8L,8L,12L,6L,12L,10L,16L,3L,6L,6L,9L,6L,12L,9L,15L,5L,10L,10L,15L,8L,16L,13L,21L,2L,4L,4L,6L,4L,8L,6L,10L,4L,8L,8L,12L,6L,12L,10L,16L,4L,8L,8L,12L,8L,16L,12L,20L,6L,12L,12L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245564Inst : IEnumerable<long>
{
public static readonly long[] Value=A245564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245564.Bytes);
public long this[int i]=>Value[i];

public static A245564Inst Instance=new A245564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245565
{
public static readonly long[] Value={ 1L,2L,2L,5L,2L,4L,5L,12L,2L,4L,4L,10L,5L,10L,12L,29L,2L,4L,4L,10L,4L,8L,10L,24L,5L,10L,10L,25L,12L,24L,29L,70L,2L,4L,4L,10L,4L,8L,10L,24L,4L,8L,8L,20L,10L,20L,24L,58L,5L,10L,10L,25L,10L,20L,25L,60L,12L,24L,24L,60L,29L,58L,70L,169L,2L,4L,4L,10L,4L,8L,10L,24L,4L,8L,8L,20L,10L,20L,24L,58L,4L,8L,8L,20L,8L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245565Inst : IEnumerable<long>
{
public static readonly long[] Value=A245565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245565.Bytes);
public long this[int i]=>Value[i];

public static A245565Inst Instance=new A245565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245566
{
public static readonly long[] Value={ 4L,1L,8L,9L,6L,1L,0L,9L,5L,8L,3L,9L,3L,8L,2L,6L,9L,6L,5L,5L,2L,7L,0L,3L,6L,4L,5L,4L,5L,2L,4L,0L,4L,4L,2L,7L,5L,9L,4L,2L,3L,8L,9L,9L,2L,5L,9L,1L,5L,9L,3L,6L,5L,9L,4L,1L,3L,2L,8L,5L,7L,7L,4L,2L,5L,9L,8L,9L,8L,7L,0L,6L,4L,9L,1L,2L,0L,6L,1L,9L,9L,0L,1L,7L,6L,0L,7L,4L,0L,6L,3L,9L,5L,8L,9L,6L,8L,5L,6L,3L,3L,8L,2L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245566Inst : IEnumerable<long>
{
public static readonly long[] Value=A245566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245566.Bytes);
public long this[int i]=>Value[i];

public static A245566Inst Instance=new A245566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245567
{
public static readonly BigInteger[] Value={ 2L,1L,1L,5L,76L,5993L,7689745L,2414465044600L,BigInteger.Parse("56130437141763247212112") };
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
public class A245567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245567Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245567.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245567.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245567Inst Instance=new A245567Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245568
{
public static readonly long[] Value={ 5L,17L,617L,857L,1277L,1427L,1697L,2087L,2687L,3557L,4217L,5417L,5477L,7307L,8837L,9437L,10067L,13877L,17657L,18287L,20747L,21587L,23537L,25577L,27917L,28547L,30467L,32117L,32297L,35507L,37337L,37547L,40127L,41177L,41387L,41957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245568Inst : IEnumerable<long>
{
public static readonly long[] Value=A245568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245568.Bytes);
public long this[int i]=>Value[i];

public static A245568Inst Instance=new A245568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245569
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,11L,12L,21L,28L,29L,31L,51L,54L,55L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245569Inst : IEnumerable<long>
{
public static readonly long[] Value=A245569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245569.Bytes);
public long this[int i]=>Value[i];

public static A245569Inst Instance=new A245569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245570
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,2L,3L,1L,1L,1L,1L,3L,1L,1L,3L,1L,1L,3L,1L,1L,7L,3L,1L,1L,3L,1L,1L,4L,7L,3L,1L,1L,3L,1L,1L,9L,2L,7L,3L,1L,1L,3L,1L,1L,1L,9L,1L,7L,3L,1L,1L,3L,1L,1L,11L,1L,9L,1L,7L,3L,1L,1L,3L,1L,1L,6L,11L,1L,9L,1L,7L,3L,1L,1L,3L,1L,1L,13L,3L,11L,1L,9L,1L,7L,3L,1L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245570Inst : IEnumerable<long>
{
public static readonly long[] Value=A245570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245570.Bytes);
public long this[int i]=>Value[i];

public static A245570Inst Instance=new A245570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245571
{
public static readonly BigInteger[] Value={ 31L,14159L,41L,1592653L,59L,9265358979323L,BigInteger.Parse("26535897932384626433832795028841971693993751058209"),653L,53L,35897L,5897L,89L,97L,79L,9323L,BigInteger.Parse("32384626433832795028841971693993751058209749445923078164062862089986280348253421"),23L,38462643383L };
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
public class A245571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245571Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245571.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245571.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245571Inst Instance=new A245571Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245572
{
public static readonly long[] Value={ 3L,2L,-2L,4L,6L,0L,-4L,0L,6L,6L,0L,4L,12L,0L,0L,0L,6L,4L,-6L,4L,0L,0L,-4L,0L,12L,2L,0L,8L,0L,0L,0L,0L,6L,8L,-4L,0L,18L,0L,-4L,0L,0L,4L,0L,4L,12L,0L,0L,0L,12L,2L,-2L,8L,0L,0L,-8L,0L,0L,8L,0L,4L,0L,0L,0L,0L,6L,0L,-8L,4L,12L,0L,0L,0L,18L,4L,0L,4L,12L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245572Inst : IEnumerable<long>
{
public static readonly long[] Value=A245572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245572.Bytes);
public long this[int i]=>Value[i];

public static A245572Inst Instance=new A245572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245573
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,1L,2L,2L,3L,3L,1L,2L,2L,3L,3L,2L,3L,3L,4L,4L,2L,3L,3L,4L,4L,3L,4L,4L,5L,5L,3L,4L,4L,5L,5L,4L,5L,5L,6L,6L,4L,5L,5L,6L,6L,5L,6L,6L,7L,7L,5L,6L,6L,7L,7L,6L,7L,7L,8L,8L,6L,7L,7L,8L,8L,7L,8L,8L,9L,9L,7L,8L,8L,9L,9L,8L,9L,9L,10L,10L,8L,9L,9L,10L,10L,9L,10L,10L,11L,11L,9L,10L,10L,11L,11L,10L,11L,11L,12L,12L,10L,11L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245573Inst : IEnumerable<long>
{
public static readonly long[] Value=A245573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245573.Bytes);
public long this[int i]=>Value[i];

public static A245573Inst Instance=new A245573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245574
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,1L,2L,2L,3L,3L,1L,2L,2L,3L,3L,2L,3L,3L,4L,4L,1L,2L,2L,3L,3L,2L,3L,3L,4L,4L,2L,3L,3L,4L,4L,3L,4L,4L,5L,5L,2L,3L,3L,4L,4L,3L,4L,4L,5L,5L,1L,2L,2L,3L,3L,2L,3L,3L,4L,4L,2L,3L,3L,4L,4L,3L,4L,4L,5L,5L,2L,3L,3L,4L,4L,3L,4L,4L,5L,5L,3L,4L,4L,5L,5L,4L,5L,5L,6L,6L,3L,4L,4L,5L,5L,4L,5L,5L,6L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245574Inst : IEnumerable<long>
{
public static readonly long[] Value=A245574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245574.Bytes);
public long this[int i]=>Value[i];

public static A245574Inst Instance=new A245574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245575
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,2L,4L,2L,3L,2L,4L,2L,3L,4L,2L,2L,4L,2L,5L,0L,4L,4L,4L,0L,3L,4L,4L,2L,2L,4L,2L,4L,5L,0L,4L,0L,6L,4L,2L,2L,3L,2L,6L,2L,2L,4L,4L,0L,4L,2L,5L,4L,2L,2L,2L,4L,4L,2L,6L,0L,3L,4L,4L,0L,2L,6L,4L,2L,4L,2L,2L,0L,7L,4L,4L,0L,6L,0L,4L,2L,2L,6L,2L,2L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245575Inst : IEnumerable<long>
{
public static readonly long[] Value=A245575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245575.Bytes);
public long this[int i]=>Value[i];

public static A245575Inst Instance=new A245575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245576
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,59L,61L,67L,73L,79L,83L,89L,113L,127L,131L,137L,139L,157L,163L,167L,173L,181L,191L,193L,211L,223L,227L,229L,233L,239L,263L,269L,271L,277L,281L,293L,311L,313L,337L,359L,367L,373L,379L,383L,389L,419L,421L,431L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245576Inst : IEnumerable<long>
{
public static readonly long[] Value=A245576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245576.Bytes);
public long this[int i]=>Value[i];

public static A245576Inst Instance=new A245576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245577
{
public static readonly long[] Value={ 12L,90L,208L,212L,234L,242L,314L,366L,404L,410L,416L,486L,540L,590L,750L,888L,908L,1152L,1418L,1444L,1500L,1524L,1658L,1666L,1736L,1798L,1814L,1874L,1940L,1942L,2094L,2138L,2266L,2496L,2584L,3058L,3062L,3206L,3660L,4034L,4080L,4208L,4368L,4422L,4606L,4872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245577Inst : IEnumerable<long>
{
public static readonly long[] Value=A245577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245577.Bytes);
public long this[int i]=>Value[i];

public static A245577Inst Instance=new A245577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245578
{
public static readonly long[] Value={ 1L,10L,18L,22L,32L,38L,50L,58L,72L,82L,98L,110L,128L,142L,162L,178L,200L,218L,242L,262L,288L,310L,338L,362L,392L,418L,450L,478L,512L,542L,578L,610L,648L,682L,722L,758L,800L,838L,882L,922L,968L,1010L,1058L,1102L,1152L,1198L,1250L,1298L,1352L,1402L,1458L,1510L,1568L,1622L,1682L,1738L,1800L,1858L,1922L,1982L,2048L,2110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245578Inst : IEnumerable<long>
{
public static readonly long[] Value=A245578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245578.Bytes);
public long this[int i]=>Value[i];

public static A245578Inst Instance=new A245578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245579
{
public static readonly long[] Value={ 1L,2L,6L,4L,10L,12L,14L,8L,27L,20L,22L,24L,26L,28L,60L,16L,34L,54L,38L,40L,84L,44L,46L,48L,75L,52L,108L,56L,58L,120L,62L,32L,132L,68L,140L,108L,74L,76L,156L,80L,82L,168L,86L,88L,270L,92L,94L,96L,147L,150L,204L,104L,106L,216L,220L,112L,228L,116L,118L,240L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245579Inst : IEnumerable<long>
{
public static readonly long[] Value=A245579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245579.Bytes);
public long this[int i]=>Value[i];

public static A245579Inst Instance=new A245579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245580
{
public static readonly long[] Value={ 3L,18L,76L,322L,1364L,5778L,24476L,103682L,439204L,1860498L,7881196L,33385282L,141422324L,599074578L,2537720636L,10749957122L,45537549124L,192900153618L,817138163596L,3461452808002L,14662949395604L,62113250390418L,263115950957276L,1114577054219522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245580Inst : IEnumerable<long>
{
public static readonly long[] Value=A245580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245580.Bytes);
public long this[int i]=>Value[i];

public static A245580Inst Instance=new A245580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245581
{
public static readonly long[] Value={ 0L,3L,2L,7L,8L,15L,18L,27L,32L,43L,50L,63L,72L,87L,98L,115L,128L,147L,162L,183L,200L,223L,242L,267L,288L,315L,338L,367L,392L,423L,450L,483L,512L,547L,578L,615L,648L,687L,722L,763L,800L,843L,882L,927L,968L,1015L,1058L,1107L,1152L,1203L,1250L,1303L,1352L,1407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245581Inst : IEnumerable<long>
{
public static readonly long[] Value=A245581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245581.Bytes);
public long this[int i]=>Value[i];

public static A245581Inst Instance=new A245581Inst();

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