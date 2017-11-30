using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A200157
{
public static readonly long[] Value={ 8L,39L,112L,275L,730L,1589L,3000L,5181L,8350L,13871L,21588L,32019L,45682L,63225L,88580L,120521L,159996L,208123L,266020L,342493L,433532L,540855L,666180L,811455L,992870L,1201725L,1440468L,1711817L,2018490L,2387707L,2803024L,3268059L,3786430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200157Inst : IEnumerable<long>
{
public static readonly long[] Value=A200157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200157.Bytes);
public long this[int i]=>Value[i];

public static A200157Inst Instance=new A200157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200158
{
public static readonly long[] Value={ 2L,45L,182L,685L,2036L,5153L,11370L,23035L,43284L,76523L,129052L,208597L,324900L,491519L,723994L,1041095L,1467042L,2029069L,2759166L,3697749L,4888510L,6381185L,8237500L,10523625L,13313648L,16697587L,20769202L,25633157L,31415424L,38246327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200158Inst : IEnumerable<long>
{
public static readonly long[] Value=A200158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200158.Bytes);
public long this[int i]=>Value[i];

public static A200158Inst Instance=new A200158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200159
{
public static readonly long[] Value={ 4L,8L,34L,76L,276L,700L,2276L,5992L,18542L,50488L,151814L,420680L,1241580L,3481308L,10162686L,28707288L,83211126L,236138900L,681383716L,1939299184L,5579324890L,15908310224L,45678520824L,130391096068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200159Inst : IEnumerable<long>
{
public static readonly long[] Value=A200159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200159.Bytes);
public long this[int i]=>Value[i];

public static A200159Inst Instance=new A200159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200160
{
public static readonly long[] Value={ 6L,24L,128L,576L,2778L,12440L,57992L,262444L,1202540L,5463896L,24922570L,113239064L,515471532L,2342330752L,10649798938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200160Inst : IEnumerable<long>
{
public static readonly long[] Value=A200160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200160.Bytes);
public long this[int i]=>Value[i];

public static A200160Inst Instance=new A200160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200161
{
public static readonly long[] Value={ 8L,48L,348L,2256L,15040L,96884L,631638L,4072228L,26327538L,169703920L,1094685786L,7052320656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200161Inst : IEnumerable<long>
{
public static readonly long[] Value=A200161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200161.Bytes);
public long this[int i]=>Value[i];

public static A200161Inst Instance=new A200161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200162
{
public static readonly long[] Value={ 10L,80L,726L,6160L,52486L,438968L,3687480L,30776992L,257108784L,2144437176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200162Inst : IEnumerable<long>
{
public static readonly long[] Value=A200162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200162.Bytes);
public long this[int i]=>Value[i];

public static A200162Inst Instance=new A200162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200163
{
public static readonly long[] Value={ 12L,120L,1326L,13888L,145482L,1504820L,15586972L,160772064L,1658521710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200163Inst : IEnumerable<long>
{
public static readonly long[] Value=A200163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200163.Bytes);
public long this[int i]=>Value[i];

public static A200163Inst Instance=new A200163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200164
{
public static readonly long[] Value={ 14L,168L,2180L,27160L,336992L,4141212L,50917674L,624074768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200164Inst : IEnumerable<long>
{
public static readonly long[] Value=A200164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200164.Bytes);
public long this[int i]=>Value[i];

public static A200164Inst Instance=new A200164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200165
{
public static readonly long[] Value={ 2L,4L,0L,6L,8L,2L,8L,24L,34L,0L,10L,48L,128L,76L,2L,12L,80L,348L,576L,276L,0L,14L,120L,726L,2256L,2778L,700L,2L,16L,168L,1326L,6160L,15040L,12440L,2276L,0L,18L,224L,2180L,13888L,52486L,96884L,57992L,5992L,2L,20L,288L,3352L,27160L,145482L,438968L,631638L,262444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200165Inst : IEnumerable<long>
{
public static readonly long[] Value=A200165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200165.Bytes);
public long this[int i]=>Value[i];

public static A200165Inst Instance=new A200165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200166
{
public static readonly long[] Value={ 2L,34L,128L,348L,726L,1326L,2180L,3352L,4874L,6810L,9192L,12084L,15518L,19558L,24236L,29616L,35730L,42642L,50384L,59020L,68582L,79134L,90708L,103368L,117146L,132106L,148280L,165732L,184494L,204630L,226172L,249184L,273698L,299778L,327456L,356796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200166Inst : IEnumerable<long>
{
public static readonly long[] Value=A200166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200166.Bytes);
public long this[int i]=>Value[i];

public static A200166Inst Instance=new A200166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200167
{
public static readonly long[] Value={ 0L,76L,576L,2256L,6160L,13888L,27160L,48380L,80096L,125412L,187552L,270688L,378512L,515980L,687836L,899548L,1156496L,1465440L,1832040L,2263800L,2767676L,3351476L,4022752L,4790848L,5663388L,6650440L,7761148L,9005676L,10393744L,11937276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200167Inst : IEnumerable<long>
{
public static readonly long[] Value=A200167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200167.Bytes);
public long this[int i]=>Value[i];

public static A200167Inst Instance=new A200167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200168
{
public static readonly long[] Value={ 2L,276L,2778L,15040L,52486L,145482L,336992L,695778L,1309052L,2298830L,3808116L,6034796L,9189086L,13554364L,19435742L,27212132L,37285690L,50170962L,66371288L,86532042L,111309444L,141482278L,177842124L,221369312L,272987306L,333851184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200168Inst : IEnumerable<long>
{
public static readonly long[] Value=A200168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200168.Bytes);
public long this[int i]=>Value[i];

public static A200168Inst Instance=new A200168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200169
{
public static readonly long[] Value={ 0L,700L,12440L,96884L,438968L,1504820L,4141212L,9922424L,21253088L,41894660L,76920336L,133925952L,222142748L,354645912L,547265784L,820450936L,1198350296L,1712627752L,2397846536L,3298959016L,4465613072L,5958544292L,7844423744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200169Inst : IEnumerable<long>
{
public static readonly long[] Value=A200169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200169.Bytes);
public long this[int i]=>Value[i];

public static A200169Inst Instance=new A200169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200170
{
public static readonly long[] Value={ 2L,2276L,57992L,631638L,3687480L,15586972L,50917674L,141509152L,344941886L,762917274L,1552478008L,2969607490L,5365606152L,9271467482L,15395275250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200170Inst : IEnumerable<long>
{
public static readonly long[] Value=A200170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200170.Bytes);
public long this[int i]=>Value[i];

public static A200170Inst Instance=new A200170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200171
{
public static readonly long[] Value={ 1L,4L,1L,-3L,7L,1L,16L,-19L,11L,1L,-40L,86L,-54L,16L,1L,134L,-328L,302L,-118L,22L,1L,-427L,1289L,-1483L,827L,-223L,29L,1L,1432L,-5003L,7009L,-5003L,1927L,-383L,37L,1L,-4860L,19450L,-32030L,28030L,-14012L,4006L,-614L,46L,1L,16798L,-75580L,143210L,-148510L,91730L,-34396L,7646L,-934L,56L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200171Inst : IEnumerable<long>
{
public static readonly long[] Value=A200171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200171.Bytes);
public long this[int i]=>Value[i];

public static A200171Inst Instance=new A200171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200172
{
public static readonly long[] Value={ 1L,11L,-54L,302L,-1483L,7009L,-32030L,143210L,-629848L,2735812L,-11767534L,50220042L,-212952283L,898198877L,-3771484798L,15775723922L,-65770848988L,273420862112L,-1133802617998L,4691140763402L,-19371432850768L,79850555673176L,-328627887379774L,1350540667070002L,-5543004766417298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200172Inst : IEnumerable<long>
{
public static readonly long[] Value=A200172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200172.Bytes);
public long this[int i]=>Value[i];

public static A200172Inst Instance=new A200172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200173
{
public static readonly long[] Value={ 1L,16L,-118L,827L,-5003L,28030L,-148510L,755822L,-3730648L,17978182L,-84987758L,395482817L,-1816357723L,8250123002L,-37119350398L,165645101162L,-733919156188L,3231337461302L,-14147884841998L,61636377252452L,-267325773340624L,1154761882042826L,-4969989654817598L,21319249101605002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200173Inst : IEnumerable<long>
{
public static readonly long[] Value=A200173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200173.Bytes);
public long this[int i]=>Value[i];

public static A200173Inst Instance=new A200173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200174
{
public static readonly long[] Value={ 1L,1L,3L,3L,2L,6L,10L,7L,12L,28L,29L,29L,70L,105L,96L,169L,327L,363L,449L,914L,1302L,1426L,2455L,4220L,5030L,6925L,12579L,17582L,21687L,36154L,57823L,73301L,106333L,179101L,250064L,332708L,538040L,825039L,1097810L,1630708L,2613839L,3676575L,5125886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200174Inst : IEnumerable<long>
{
public static readonly long[] Value=A200174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200174.Bytes);
public long this[int i]=>Value[i];

public static A200174Inst Instance=new A200174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200175
{
public static readonly long[] Value={ 1L,2L,3L,6L,12L,15L,29L,72L,133L,214L,394L,853L,1782L,3087L,5597L,11777L,24069L,45200L,83805L,167284L,342971L,664695L,1257505L,2476990L,4999659L,9864713L,19023479L,37228518L,74480796L,147868410L,288747975L,565957525L,1124938149L,2237002991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200175Inst : IEnumerable<long>
{
public static readonly long[] Value=A200175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200175.Bytes);
public long this[int i]=>Value[i];

public static A200175Inst Instance=new A200175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200176
{
public static readonly long[] Value={ 1L,3L,5L,11L,15L,29L,78L,160L,283L,574L,1428L,3087L,5800L,12563L,30105L,63994L,128826L,285423L,656667L,1407398L,2951141L,6564161L,14805297L,31974359L,68620812L,152674200L,340729396L,740843841L,1612122145L,3583332695L,7954071929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200176Inst : IEnumerable<long>
{
public static readonly long[] Value=A200176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200176.Bytes);
public long this[int i]=>Value[i];

public static A200176Inst Instance=new A200176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200177
{
public static readonly long[] Value={ 1L,4L,5L,14L,24L,48L,100L,280L,608L,1094L,2558L,6656L,14475L,29638L,69174L,170043L,384938L,830598L,1910747L,4608078L,10600467L,23514477L,54265809L,129118292L,298774740L,676277578L,1564120363L,3687870415L,8572421420L,19643806169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200177Inst : IEnumerable<long>
{
public static readonly long[] Value=A200177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200177.Bytes);
public long this[int i]=>Value[i];

public static A200177Inst Instance=new A200177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200178
{
public static readonly long[] Value={ 1L,5L,7L,19L,31L,72L,186L,460L,891L,1934L,5241L,12431L,25680L,59390L,152436L,359303L,789835L,1853143L,4609254L,10926157L,24817557L,58735668L,144083442L,342433339L,794002110L,1892015431L,4599853709L,10962118986L,25773744159L,61646299147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200178Inst : IEnumerable<long>
{
public static readonly long[] Value=A200178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200178.Bytes);
public long this[int i]=>Value[i];

public static A200178Inst Instance=new A200178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200179
{
public static readonly long[] Value={ 1L,6L,7L,26L,48L,103L,246L,700L,1573L,3247L,8034L,21608L,50100L,109071L,268358L,690150L,1629202L,3709231L,9026969L,22707455L,54349757L,126747830L,308139152L,765740522L,1845805544L,4379391584L,10654557350L,26290537792L,63724232354L,152906665554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200179Inst : IEnumerable<long>
{
public static readonly long[] Value=A200179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200179.Bytes);
public long this[int i]=>Value[i];

public static A200179Inst Instance=new A200179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200180
{
public static readonly long[] Value={ 1L,7L,9L,31L,53L,141L,380L,1010L,2152L,5014L,14018L,35542L,78385L,188789L,503051L,1241939L,2859687L,6957672L,17863397L,43991846L,103888178L,253531752L,640390692L,1575397895L,3777406958L,9259136398L,23167497450L,57008137128L,138220165963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200180Inst : IEnumerable<long>
{
public static readonly long[] Value=A200180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200180.Bytes);
public long this[int i]=>Value[i];

public static A200180Inst Instance=new A200180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200181
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,3L,3L,3L,1L,4L,5L,6L,2L,1L,5L,5L,11L,12L,6L,1L,6L,7L,14L,15L,15L,10L,1L,7L,7L,19L,24L,29L,29L,7L,1L,8L,9L,26L,31L,48L,78L,72L,12L,1L,9L,9L,31L,48L,72L,100L,160L,133L,28L,1L,10L,11L,38L,53L,103L,186L,280L,283L,214L,29L,1L,11L,11L,47L,74L,141L,246L,460L,608L,574L,394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200181Inst : IEnumerable<long>
{
public static readonly long[] Value=A200181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200181.Bytes);
public long this[int i]=>Value[i];

public static A200181Inst Instance=new A200181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200182
{
public static readonly long[] Value={ 3L,6L,11L,14L,19L,26L,31L,38L,47L,54L,63L,74L,83L,94L,107L,118L,131L,146L,159L,174L,191L,206L,223L,242L,259L,278L,299L,318L,339L,362L,383L,406L,431L,454L,479L,506L,531L,558L,587L,614L,643L,674L,703L,734L,767L,798L,831L,866L,899L,934L,971L,1006L,1043L,1082L,1119L,1158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200182Inst : IEnumerable<long>
{
public static readonly long[] Value=A200182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200182.Bytes);
public long this[int i]=>Value[i];

public static A200182Inst Instance=new A200182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200183
{
public static readonly long[] Value={ 2L,12L,15L,24L,31L,48L,53L,74L,83L,108L,119L,148L,159L,196L,209L,246L,263L,308L,323L,372L,391L,444L,465L,522L,543L,608L,631L,696L,723L,796L,821L,898L,927L,1008L,1039L,1124L,1155L,1248L,1281L,1374L,1411L,1512L,1547L,1652L,1691L,1800L,1841L,1954L,1995L,2116L,2159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200183Inst : IEnumerable<long>
{
public static readonly long[] Value=A200183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200183.Bytes);
public long this[int i]=>Value[i];

public static A200183Inst Instance=new A200183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200184
{
public static readonly long[] Value={ 6L,15L,29L,48L,72L,103L,141L,186L,244L,309L,385L,472L,572L,685L,813L,954L,1110L,1283L,1475L,1682L,1910L,2155L,2421L,2710L,3020L,3351L,3707L,4086L,4492L,4923L,5381L,5864L,6378L,6921L,7493L,8096L,8730L,9395L,10097L,10830L,11598L,12401L,13241L,14118L,15034L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200184Inst : IEnumerable<long>
{
public static readonly long[] Value=A200184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200184.Bytes);
public long this[int i]=>Value[i];

public static A200184Inst Instance=new A200184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200185
{
public static readonly long[] Value={ 10L,29L,78L,100L,186L,246L,380L,464L,686L,798L,1096L,1276L,1658L,1878L,2408L,2668L,3306L,3672L,4432L,4852L,5814L,6288L,7398L,8010L,9278L,9960L,11486L,12236L,13944L,14870L,16774L,17780L,19998L,21088L,23528L,24826L,27494L,28890L,31930L,33424L,36720L,38456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200185Inst : IEnumerable<long>
{
public static readonly long[] Value=A200185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200185.Bytes);
public long this[int i]=>Value[i];

public static A200185Inst Instance=new A200185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200186
{
public static readonly long[] Value={ 1L,4L,6L,14L,24L,54L,104L,230L,464L,1028L,2128L,4720L,9918L,22038L,46760L,104056L,222338L,495358L,1064138L,2373070L,5119796L,11425974L,24738074L,55242788L,119958510L,268018844L,583462384L,1304179214L,2845288284L,6362293924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200186Inst : IEnumerable<long>
{
public static readonly long[] Value=A200186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200186.Bytes);
public long this[int i]=>Value[i];

public static A200186Inst Instance=new A200186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200187
{
public static readonly long[] Value={ 1L,6L,14L,48L,144L,482L,1534L,5148L,16826L,56918L,188706L,642300L,2149072L,7348408L,24749244L,84919630L,287439908L,988917344L,3360535304L,11586463472L,39498606276L,136421151864L,466287543690L,1612808711870L,5524756100592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200187Inst : IEnumerable<long>
{
public static readonly long[] Value=A200187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200187.Bytes);
public long this[int i]=>Value[i];

public static A200187Inst Instance=new A200187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200188
{
public static readonly long[] Value={ 1L,8L,28L,120L,506L,2240L,9856L,44562L,199932L,914676L,4152696L,19143782L,87622590L,406118090L,1869888346L,8701509206L,40245967276L,187867050760L,872020225984L,4080661245080L,18995817588580L,89071683414448L,415623180115020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200188Inst : IEnumerable<long>
{
public static readonly long[] Value=A200188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200188.Bytes);
public long this[int i]=>Value[i];

public static A200188Inst Instance=new A200188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200189
{
public static readonly long[] Value={ 1L,10L,44L,242L,1298L,7266L,40632L,231916L,1320876L,7630236L,43951298L,255926506L,1485664226L,8700154180L,50792100530L,298703878402L,1751415860436L,10333766393384L,60797757383394L,359661008763242L,2121869963574120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200189Inst : IEnumerable<long>
{
public static readonly long[] Value=A200189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200189.Bytes);
public long this[int i]=>Value[i];

public static A200189Inst Instance=new A200189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200190
{
public static readonly long[] Value={ 1L,12L,66L,426L,2794L,18838L,127800L,881008L,6081086L,42452472L,296258332L,2085263400L,14662923954L,103810065802L,734016517080L,5219300699654L,37060739113354L,264413563521598L,1883784631395118L,13476226807283384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200190Inst : IEnumerable<long>
{
public static readonly long[] Value=A200190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200190.Bytes);
public long this[int i]=>Value[i];

public static A200190Inst Instance=new A200190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200191
{
public static readonly long[] Value={ 1L,14L,90L,688L,5300L,41938L,334278L,2702398L,21910764L,179391752L,1470318926L,12138752566L,100237526220L,832451175714L,6911760321744L,57654489610890L,480698731253616L,4023489592590784L,33656450218770442L,282477294114249058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200191Inst : IEnumerable<long>
{
public static readonly long[] Value=A200191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200191.Bytes);
public long this[int i]=>Value[i];

public static A200191Inst Instance=new A200191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200192
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,0L,1L,6L,6L,2L,1L,8L,14L,14L,0L,1L,10L,28L,48L,24L,2L,1L,12L,44L,120L,144L,54L,0L,1L,14L,66L,242L,506L,482L,104L,2L,1L,16L,90L,426L,1298L,2240L,1534L,230L,0L,1L,18L,120L,688L,2794L,7266L,9856L,5148L,464L,2L,1L,20L,152L,1040L,5300L,18838L,40632L,44562L,16826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200192Inst : IEnumerable<long>
{
public static readonly long[] Value=A200192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200192.Bytes);
public long this[int i]=>Value[i];

public static A200192Inst Instance=new A200192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200193
{
public static readonly long[] Value={ 2L,14L,48L,120L,242L,426L,688L,1040L,1494L,2066L,2768L,3612L,4614L,5786L,7140L,8692L,10454L,12438L,14660L,17132L,19866L,22878L,26180L,29784L,33706L,37958L,42552L,47504L,52826L,58530L,64632L,71144L,78078L,85450L,93272L,101556L,110318L,119570L,129324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200193Inst : IEnumerable<long>
{
public static readonly long[] Value=A200193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200193.Bytes);
public long this[int i]=>Value[i];

public static A200193Inst Instance=new A200193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200194
{
public static readonly long[] Value={ 0L,24L,144L,506L,1298L,2794L,5300L,9220L,14974L,23094L,34120L,48712L,67524L,91346L,120950L,157254L,201146L,253672L,315838L,388820L,473738L,571896L,684534L,813084L,958900L,1123544L,1308488L,1515422L,1745934L,2001842L,2284852L,2596912L,2939842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200194Inst : IEnumerable<long>
{
public static readonly long[] Value=A200194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200194.Bytes);
public long this[int i]=>Value[i];

public static A200194Inst Instance=new A200194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200195
{
public static readonly long[] Value={ 2L,54L,482L,2240L,7266L,18838L,41938L,83600L,153278L,263198L,428718L,668684L,1005790L,1466934L,2083578L,2892104L,3934174L,5257082L,6914122L,8964936L,11475878L,14520370L,18179258L,22541172L,27702886L,33769670L,40855654L,49084180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200195Inst : IEnumerable<long>
{
public static readonly long[] Value=A200195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200195.Bytes);
public long this[int i]=>Value[i];

public static A200195Inst Instance=new A200195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200196
{
public static readonly long[] Value={ 0L,104L,1534L,9856L,40632L,127800L,334278L,765598L,1585416L,3034396L,5450616L,9293800L,15170448L,23863548L,36362438L,53897896L,77976766L,110422568L,153414642L,209534448L,281809258L,373763982L,489469484L,633600106L,811486280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200196Inst : IEnumerable<long>
{
public static readonly long[] Value=A200196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200196.Bytes);
public long this[int i]=>Value[i];

public static A200196Inst Instance=new A200196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200197
{
public static readonly long[] Value={ 12L,22L,50L,90L,192L,360L,752L,1472L,3060L,6104L,12596L,25368L,52230L,106038L,218204L,445350L,916598L,1877598L,3866920L,7942794L,16372182L,33699352L,69526894L,143344944L,296012610L,611113112L,1263073756L,2610512928L,5399923198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200197Inst : IEnumerable<long>
{
public static readonly long[] Value=A200197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200197.Bytes);
public long this[int i]=>Value[i];

public static A200197Inst Instance=new A200197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200198
{
public static readonly long[] Value={ 68L,246L,1042L,3940L,16092L,63326L,256314L,1028100L,4169932L,16889228L,68746558L,279997576L,1143494160L,4675439056L,19150647962L,78534289030L,322481118006L,1325578996662L,5454538071104L,22464846352590L,92602356718092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200198Inst : IEnumerable<long>
{
public static readonly long[] Value=A200198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200198.Bytes);
public long this[int i]=>Value[i];

public static A200198Inst Instance=new A200198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200199
{
public static readonly long[] Value={ 186L,1106L,6418L,37226L,217946L,1282168L,7609122L,45311478L,270793444L,1623115640L,9752855676L,58737147004L,354446311678L,2142635088724L,12972537700224L,78651690691664L,477462935113362L,2901805987457704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200199Inst : IEnumerable<long>
{
public static readonly long[] Value=A200199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200199.Bytes);
public long this[int i]=>Value[i];

public static A200199Inst Instance=new A200199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200200
{
public static readonly long[] Value={ 422L,3196L,24542L,187530L,1453304L,11315108L,88657470L,697548282L,5508571400L,43635932538L,346582563516L,2759102483488L,22009380252406L,175882840702296L,1407766935222636L,11283861015674038L,90561415687714086L,727670172922068894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200200Inst : IEnumerable<long>
{
public static readonly long[] Value=A200200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200200.Bytes);
public long this[int i]=>Value[i];

public static A200200Inst Instance=new A200200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200201
{
public static readonly long[] Value={ 798L,7450L,70400L,667620L,6428538L,62141592L,604864626L,5910438976L,57975632400L,570460963084L,5628281238070L,55659731103340L,551565557625452L,5475686423922678L,54447753338275452L,542185148049168142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200201Inst : IEnumerable<long>
{
public static readonly long[] Value=A200201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200201.Bytes);
public long this[int i]=>Value[i];

public static A200201Inst Instance=new A200201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200202
{
public static readonly long[] Value={ 1316L,14842L,168054L,1910006L,21939870L,253625670L,2949336370L,34451583494L,403936559664L,4751104584700L,56034400780878L,662427465209118L,7847270531133920L,93130188698344434L,1107048144990218486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200202Inst : IEnumerable<long>
{
public static readonly long[] Value=A200202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200202.Bytes);
public long this[int i]=>Value[i];

public static A200202Inst Instance=new A200202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200203
{
public static readonly ulong[] Value={ 2064L,26932L,352840L,4664818L,62361448L,838749476L,11349503058L,154248783948L,2104280597600L,28798650135574L,395207143815892L,5436349736878032L,74936087200093134L,1034832015199700638L,14313834216014729042UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200203Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A200203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200203.Bytes);
public ulong this[int i]=>Value[i];

public static A200203Inst Instance=new A200203Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200204
{
public static readonly long[] Value={ 12L,68L,22L,186L,246L,50L,422L,1106L,1042L,90L,798L,3196L,6418L,3940L,192L,1316L,7450L,24542L,37226L,16092L,360L,2064L,14842L,70400L,187530L,217946L,63326L,752L,3048L,26932L,168054L,667620L,1453304L,1282168L,256314L,1472L,4254L,44910L,352840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200204Inst : IEnumerable<long>
{
public static readonly long[] Value=A200204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200204.Bytes);
public long this[int i]=>Value[i];

public static A200204Inst Instance=new A200204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200205
{
public static readonly long[] Value={ 12L,68L,186L,422L,798L,1316L,2064L,3048L,4254L,5802L,7682L,9864L,12500L,15564L,19010L,23022L,27558L,32556L,38232L,44528L,51366L,58994L,67338L,76304L,86172L,96852L,108234L,120630L,133934L,148020L,163232L,179448L,196526L,214842L,234258L,254616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200205Inst : IEnumerable<long>
{
public static readonly long[] Value=A200205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200205.Bytes);
public long this[int i]=>Value[i];

public static A200205Inst Instance=new A200205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200206
{
public static readonly long[] Value={ 22L,246L,1106L,3196L,7450L,14842L,26932L,44910L,71050L,106802L,155056L,217506L,297896L,397820L,522032L,672214L,853824L,1068640L,1323238L,1619004L,1963760L,2358796L,2812794L,3326992L,3911394L,4566542L,5303990L,6124024L,7039122L,8049358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200206Inst : IEnumerable<long>
{
public static readonly long[] Value=A200206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200206.Bytes);
public long this[int i]=>Value[i];

public static A200206Inst Instance=new A200206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200207
{
public static readonly long[] Value={ 50L,1042L,6418L,24542L,70400L,168054L,352840L,672632L,1191380L,1990668L,3169582L,4851400L,7182342L,10332674L,14504130L,19925886L,26858060L,35599134L,46482708L,59877540L,76196440L,95896240L,119471266L,147472836L,180499346L,219187302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200207Inst : IEnumerable<long>
{
public static readonly long[] Value=A200207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200207.Bytes);
public long this[int i]=>Value[i];

public static A200207Inst Instance=new A200207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200208
{
public static readonly long[] Value={ 90L,3940L,37226L,187530L,667620L,1910006L,4664818L,10140128L,20184636L,37418930L,65462890L,109237270L,175066404L,271040286L,407440210L,596771596L,854269356L,1198528290L,1651314456L,2238353836L,2990103390L,3941357552L,5132247474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200208Inst : IEnumerable<long>
{
public static readonly long[] Value=A200208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200208.Bytes);
public long this[int i]=>Value[i];

public static A200208Inst Instance=new A200208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200209
{
public static readonly long[] Value={ 192L,16092L,217946L,1453304L,6428538L,21939870L,62361448L,154585536L,345422978L,710643132L,1366075526L,2483991350L,4309599382L,7180688000L,11557570298L,18048274072L,27438624488L,40742003838L,59232871060L,84489363024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200209Inst : IEnumerable<long>
{
public static readonly long[] Value=A200209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200209.Bytes);
public long this[int i]=>Value[i];

public static A200209Inst Instance=new A200209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200210
{
public static readonly long[] Value={ 360L,63326L,1282168L,11315108L,62141592L,253625670L,838749476L,2371034404L,5950389676L,13585723472L,28694253866L,56870615234L,106810248534L,191533300498L,330111908464L,549616167606L,887398698638L,1394638491438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200210Inst : IEnumerable<long>
{
public static readonly long[] Value=A200210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200210.Bytes);
public long this[int i]=>Value[i];

public static A200210Inst Instance=new A200210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200211
{
public static readonly long[] Value={ 752L,256314L,7609122L,88657470L,604864626L,2949336370L,11349503058L,36580061138L,103109058584L,261224766796L,606238931956L,1309542607976L,2662545910816L,5138238853810L,9483237615484L,16833404882270L,28865075618702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200211Inst : IEnumerable<long>
{
public static readonly long[] Value=A200211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200211.Bytes);
public long this[int i]=>Value[i];

public static A200211Inst Instance=new A200211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200212
{
public static readonly long[] Value={ 1L,1L,3L,11L,42L,174L,763L,3457L,16075L,76351L,368767L,1805682L,8943948L,44736096L,225646033L,1146461185L,5862224756L,30144922281L,155791900727L,808773877919L,4215675455503L,22054576750972L,115765182718467L,609508331610920L,3218059655553030L,17034314889643633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200212Inst : IEnumerable<long>
{
public static readonly long[] Value=A200212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200212.Bytes);
public long this[int i]=>Value[i];

public static A200212Inst Instance=new A200212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200213
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,0L,2L,0L,2L,0L,4L,0L,2L,2L,2L,0L,4L,0L,4L,2L,2L,0L,6L,0L,2L,2L,4L,0L,6L,0L,4L,2L,2L,2L,6L,0L,2L,2L,6L,0L,6L,0L,4L,4L,2L,0L,8L,0L,4L,2L,4L,0L,6L,2L,6L,2L,2L,0L,10L,0L,2L,4L,4L,2L,6L,0L,4L,2L,6L,0L,10L,0L,2L,4L,4L,2L,6L,0L,8L,2L,2L,0L,10L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200213Inst : IEnumerable<long>
{
public static readonly long[] Value=A200213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200213.Bytes);
public long this[int i]=>Value[i];

public static A200213Inst Instance=new A200213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200214
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,6L,0L,0L,0L,6L,0L,6L,0L,0L,0L,0L,0L,12L,0L,0L,0L,0L,0L,6L,0L,6L,0L,0L,0L,18L,0L,0L,0L,6L,0L,6L,0L,0L,0L,6L,0L,18L,0L,0L,0L,0L,0L,6L,0L,12L,0L,0L,0L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200214Inst : IEnumerable<long>
{
public static readonly long[] Value=A200214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200214.Bytes);
public long this[int i]=>Value[i];

public static A200214Inst Instance=new A200214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200215
{
public static readonly long[] Value={ 1L,1L,3L,13L,61L,306L,1623L,8937L,50565L,292283L,1718827L,10250916L,61854848L,376949934L,2316738789L,14343701657L,89379109846L,560108223900L,3527723269978L,22318890516413L,141778326349191L,903936594232782L,5782447430948438L,37102633354583532L,238729798670985104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200215Inst : IEnumerable<long>
{
public static readonly long[] Value=A200215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200215.Bytes);
public long this[int i]=>Value[i];

public static A200215Inst Instance=new A200215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200216
{
public static readonly BigInteger[] Value={ 93844L,322001299796379844L,BigInteger.Parse("1114592308630995805123571151844"),BigInteger.Parse("3858108676488182444301031186675778188809844"),BigInteger.Parse("13354661111806898918013326915229994453818137920195953844") };
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
public class A200216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200216Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200216.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200216.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200216Inst Instance=new A200216Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200217
{
public static readonly BigInteger[] Value={ 28748141L,BigInteger.Parse("182720147509505842286585077"),BigInteger.Parse("1176722513851727970194784616032383058302343205"),BigInteger.Parse("7578123615032687003769196301877008424487234722410713810234126013") };
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
public class A200217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200217Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200217.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200217.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200217Inst Instance=new A200217Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200218
{
public static readonly BigInteger[] Value={ -297L,548147655L,-1019827620252441L,BigInteger.Parse("1897387247823873407415"),BigInteger.Parse("-3530085179800800999132960777"),BigInteger.Parse("6567716416847133270037051381858983"),BigInteger.Parse("-12219223258107727669457593220846745613305"),BigInteger.Parse("22733840433256343397153666138928891468676446359") };
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
public class A200218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200218Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200218.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200218.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200218Inst Instance=new A200218Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200219
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,4L,3L,2L,1L,4L,1L,2L,0L,8L,1L,6L,1L,4L,1L,2L,1L,8L,0L,2L,9L,2L,1L,4L,1L,16L,0L,2L,0L,12L,1L,2L,0L,8L,1L,4L,1L,2L,3L,2L,1L,16L,7L,10L,2L,2L,1L,18L,0L,8L,0L,2L,1L,8L,1L,2L,3L,32L,2L,4L,1L,4L,0L,2L,1L,24L,1L,2L,0L,4L,6L,4L,1L,16L,27L,2L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200219Inst : IEnumerable<long>
{
public static readonly long[] Value=A200219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200219.Bytes);
public long this[int i]=>Value[i];

public static A200219Inst Instance=new A200219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200220
{
public static readonly long[] Value={ 1L,1L,2L,6L,10L,24L,52L,105L,238L,495L,1068L,2304L,4893L,10556L,22570L,48363L,103805L,222224L,476634L,1021515L,2189200L,4693415L,10058607L,21561120L,46215400L,99056688L,212327858L,455105352L,975492413L,2090916520L,4481729501L,9606342690L,20590584676L,44134642493L,94599971180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200220Inst : IEnumerable<long>
{
public static readonly long[] Value=A200220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200220.Bytes);
public long this[int i]=>Value[i];

public static A200220Inst Instance=new A200220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200221
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,3L,0L,0L,0L,3L,0L,3L,0L,3L,0L,0L,0L,9L,0L,0L,1L,3L,0L,6L,0L,6L,0L,0L,0L,12L,0L,0L,0L,9L,0L,6L,0L,3L,3L,0L,0L,18L,0L,3L,0L,3L,0L,9L,0L,9L,0L,0L,0L,21L,0L,0L,3L,10L,0L,6L,0L,3L,0L,6L,0L,27L,0L,0L,3L,3L,0L,6L,0L,18L,3L,0L,0L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200221Inst : IEnumerable<long>
{
public static readonly long[] Value=A200221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200221.Bytes);
public long this[int i]=>Value[i];

public static A200221Inst Instance=new A200221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200222
{
public static readonly long[] Value={ 1L,2L,4L,12L,42L,164L,688L,3024L,13680L,63110L,295520L,1401012L,6713280L,32470468L,158343504L,777725264L,3843992546L,19104857608L,95419519076L,478668009828L,2410698765472L,12184259877320L,61782045169312L,314202878599696L,1602270787137472L,8191160756085318L,41971595130249968L,215522156779513584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200222Inst : IEnumerable<long>
{
public static readonly long[] Value=A200222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200222.Bytes);
public long this[int i]=>Value[i];

public static A200222Inst Instance=new A200222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200223
{
public static readonly long[] Value={ 3L,2L,3L,1L,1L,4L,3L,3L,3L,8L,8L,6L,2L,2L,6L,2L,8L,4L,5L,3L,5L,6L,3L,7L,0L,4L,9L,2L,3L,1L,1L,7L,1L,4L,9L,1L,1L,9L,9L,1L,6L,3L,6L,2L,8L,8L,2L,6L,6L,1L,5L,9L,4L,3L,8L,5L,8L,7L,5L,7L,8L,7L,3L,5L,7L,6L,5L,0L,5L,3L,8L,8L,8L,6L,0L,1L,7L,1L,0L,9L,8L,2L,8L,0L,4L,8L,2L,3L,7L,4L,7L,7L,2L,7L,6L,2L,7L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200223Inst : IEnumerable<long>
{
public static readonly long[] Value=A200223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200223.Bytes);
public long this[int i]=>Value[i];

public static A200223Inst Instance=new A200223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200224
{
public static readonly long[] Value={ 8L,4L,8L,9L,0L,5L,1L,8L,8L,3L,2L,9L,5L,2L,2L,3L,6L,1L,7L,3L,4L,5L,6L,3L,8L,1L,6L,2L,6L,6L,1L,3L,2L,6L,7L,6L,8L,3L,4L,5L,9L,5L,3L,3L,8L,7L,9L,9L,7L,8L,6L,6L,5L,2L,5L,8L,0L,4L,1L,9L,1L,3L,6L,6L,3L,5L,7L,5L,7L,3L,3L,0L,4L,0L,5L,9L,1L,3L,7L,2L,4L,9L,5L,3L,8L,3L,2L,3L,5L,4L,5L,6L,3L,8L,6L,2L,5L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200224Inst : IEnumerable<long>
{
public static readonly long[] Value=A200224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200224.Bytes);
public long this[int i]=>Value[i];

public static A200224Inst Instance=new A200224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200225
{
public static readonly long[] Value={ 2L,5L,8L,3L,7L,5L,8L,6L,0L,0L,8L,3L,4L,8L,6L,9L,4L,8L,5L,9L,8L,4L,3L,8L,2L,6L,1L,2L,2L,9L,7L,3L,3L,0L,9L,2L,9L,7L,5L,3L,9L,3L,8L,6L,9L,2L,8L,8L,7L,3L,0L,8L,4L,4L,2L,5L,8L,4L,9L,6L,2L,5L,0L,9L,9L,9L,8L,6L,0L,7L,4L,8L,4L,6L,5L,9L,9L,3L,6L,8L,5L,2L,5L,8L,6L,9L,6L,6L,4L,7L,7L,0L,7L,6L,1L,3L,9L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200225Inst : IEnumerable<long>
{
public static readonly long[] Value=A200225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200225.Bytes);
public long this[int i]=>Value[i];

public static A200225Inst Instance=new A200225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200226
{
public static readonly long[] Value={ 1L,0L,1L,2L,2L,6L,5L,5L,6L,2L,9L,6L,9L,2L,0L,9L,4L,1L,7L,3L,3L,4L,5L,5L,4L,4L,1L,9L,9L,3L,8L,2L,7L,2L,1L,4L,5L,5L,8L,9L,6L,1L,2L,7L,1L,3L,9L,8L,2L,8L,6L,8L,9L,9L,1L,3L,1L,2L,1L,0L,7L,8L,3L,4L,0L,7L,3L,9L,5L,8L,9L,3L,1L,6L,8L,9L,8L,9L,6L,3L,8L,0L,4L,1L,5L,9L,0L,7L,5L,0L,4L,6L,8L,3L,4L,6L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200226Inst : IEnumerable<long>
{
public static readonly long[] Value=A200226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200226.Bytes);
public long this[int i]=>Value[i];

public static A200226Inst Instance=new A200226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200227
{
public static readonly long[] Value={ 2L,1L,2L,2L,0L,7L,2L,6L,1L,5L,9L,7L,9L,1L,8L,2L,9L,8L,9L,7L,8L,2L,3L,7L,4L,0L,5L,0L,1L,0L,3L,7L,5L,4L,0L,3L,7L,3L,2L,0L,7L,9L,1L,5L,7L,5L,0L,6L,1L,9L,7L,1L,1L,7L,0L,2L,4L,0L,1L,5L,1L,2L,3L,5L,4L,5L,2L,5L,4L,6L,3L,6L,4L,7L,4L,6L,8L,2L,1L,5L,3L,4L,7L,1L,5L,8L,9L,5L,1L,0L,6L,7L,2L,1L,5L,0L,0L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200227Inst : IEnumerable<long>
{
public static readonly long[] Value=A200227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200227.Bytes);
public long this[int i]=>Value[i];

public static A200227Inst Instance=new A200227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200228
{
public static readonly long[] Value={ 1L,1L,6L,4L,7L,2L,0L,1L,3L,2L,6L,0L,0L,0L,8L,6L,5L,4L,8L,1L,4L,4L,1L,7L,3L,6L,0L,3L,9L,1L,7L,6L,2L,9L,3L,4L,2L,8L,3L,8L,8L,5L,9L,8L,2L,9L,2L,3L,6L,1L,6L,8L,4L,5L,0L,1L,3L,9L,9L,2L,3L,7L,8L,1L,6L,7L,5L,4L,2L,8L,8L,0L,2L,7L,2L,0L,0L,6L,5L,0L,9L,7L,8L,3L,9L,7L,1L,5L,4L,7L,9L,2L,5L,5L,4L,8L,9L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200228Inst : IEnumerable<long>
{
public static readonly long[] Value=A200228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200228.Bytes);
public long this[int i]=>Value[i];

public static A200228Inst Instance=new A200228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200229
{
public static readonly long[] Value={ 6L,0L,1L,0L,8L,4L,6L,0L,8L,5L,4L,4L,7L,4L,4L,5L,7L,8L,0L,8L,4L,0L,9L,1L,5L,7L,5L,7L,9L,3L,7L,9L,2L,4L,3L,7L,0L,9L,6L,4L,9L,2L,5L,9L,9L,3L,5L,3L,1L,9L,7L,6L,9L,7L,2L,6L,3L,5L,3L,5L,4L,8L,0L,6L,8L,5L,1L,4L,2L,3L,0L,5L,2L,9L,4L,8L,1L,1L,0L,4L,5L,6L,6L,1L,1L,3L,2L,2L,1L,0L,5L,2L,6L,2L,2L,3L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200229Inst : IEnumerable<long>
{
public static readonly long[] Value=A200229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200229.Bytes);
public long this[int i]=>Value[i];

public static A200229Inst Instance=new A200229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200230
{
public static readonly long[] Value={ 8L,3L,3L,6L,2L,0L,4L,7L,0L,3L,0L,7L,4L,5L,4L,0L,7L,8L,2L,7L,4L,1L,7L,0L,1L,7L,8L,7L,1L,2L,5L,3L,2L,1L,2L,3L,7L,6L,7L,9L,6L,5L,3L,2L,7L,8L,9L,8L,2L,4L,5L,2L,5L,4L,1L,1L,9L,4L,2L,2L,6L,0L,7L,2L,6L,4L,5L,0L,6L,9L,6L,2L,9L,4L,9L,8L,9L,7L,3L,7L,4L,7L,5L,9L,4L,9L,1L,0L,9L,8L,5L,1L,9L,8L,7L,7L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200230Inst : IEnumerable<long>
{
public static readonly long[] Value=A200230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200230.Bytes);
public long this[int i]=>Value[i];

public static A200230Inst Instance=new A200230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200231
{
public static readonly long[] Value={ 5L,0L,8L,0L,6L,6L,6L,8L,3L,7L,0L,1L,8L,6L,8L,1L,3L,4L,6L,5L,3L,0L,5L,9L,4L,8L,4L,2L,0L,3L,5L,0L,9L,8L,2L,1L,8L,9L,4L,8L,2L,6L,2L,6L,7L,3L,3L,4L,2L,3L,8L,3L,3L,0L,9L,1L,6L,6L,9L,1L,7L,6L,3L,5L,0L,8L,2L,6L,5L,1L,1L,8L,0L,2L,3L,3L,0L,6L,1L,7L,3L,4L,6L,3L,9L,0L,2L,2L,0L,8L,5L,4L,5L,9L,6L,4L,8L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200231Inst : IEnumerable<long>
{
public static readonly long[] Value=A200231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200231.Bytes);
public long this[int i]=>Value[i];

public static A200231Inst Instance=new A200231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200232
{
public static readonly long[] Value={ 9L,6L,3L,2L,9L,1L,3L,7L,6L,6L,1L,9L,6L,7L,9L,1L,0L,4L,6L,5L,5L,6L,4L,1L,8L,2L,9L,6L,6L,4L,1L,6L,4L,2L,3L,0L,2L,3L,0L,3L,9L,1L,9L,8L,6L,7L,2L,7L,0L,6L,2L,5L,1L,0L,1L,2L,1L,4L,5L,6L,4L,6L,1L,4L,8L,6L,2L,1L,1L,4L,2L,3L,8L,3L,8L,8L,9L,9L,3L,5L,1L,0L,0L,4L,1L,0L,9L,7L,1L,9L,4L,2L,1L,6L,6L,1L,4L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200232Inst : IEnumerable<long>
{
public static readonly long[] Value=A200232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200232.Bytes);
public long this[int i]=>Value[i];

public static A200232Inst Instance=new A200232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200233
{
public static readonly long[] Value={ 4L,3L,2L,0L,5L,2L,7L,6L,0L,4L,2L,5L,7L,2L,3L,1L,3L,1L,9L,9L,6L,3L,8L,3L,6L,0L,7L,4L,5L,5L,3L,7L,2L,2L,8L,0L,5L,2L,2L,3L,5L,0L,2L,1L,7L,0L,6L,9L,8L,9L,9L,8L,4L,6L,3L,1L,2L,6L,8L,8L,5L,4L,9L,9L,4L,2L,0L,0L,8L,9L,3L,8L,0L,5L,2L,1L,6L,6L,7L,1L,4L,8L,1L,7L,7L,7L,5L,4L,4L,3L,8L,3L,6L,7L,9L,0L,7L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200233Inst : IEnumerable<long>
{
public static readonly long[] Value=A200233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200233.Bytes);
public long this[int i]=>Value[i];

public static A200233Inst Instance=new A200233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200234
{
public static readonly long[] Value={ 1L,0L,9L,2L,9L,6L,1L,3L,1L,2L,6L,1L,9L,6L,9L,4L,2L,6L,9L,6L,4L,3L,3L,8L,2L,9L,1L,2L,5L,5L,6L,6L,2L,2L,1L,9L,2L,9L,1L,4L,5L,1L,8L,5L,8L,8L,1L,8L,0L,2L,8L,9L,8L,8L,9L,9L,6L,1L,7L,6L,3L,5L,6L,9L,6L,8L,9L,4L,4L,7L,6L,1L,6L,7L,6L,3L,4L,5L,1L,0L,2L,5L,1L,1L,5L,0L,5L,4L,3L,1L,2L,2L,5L,4L,0L,3L,8L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200234Inst : IEnumerable<long>
{
public static readonly long[] Value=A200234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200234.Bytes);
public long this[int i]=>Value[i];

public static A200234Inst Instance=new A200234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200235
{
public static readonly long[] Value={ 3L,7L,1L,1L,2L,2L,3L,4L,9L,4L,6L,9L,2L,7L,2L,8L,0L,5L,3L,3L,4L,1L,9L,9L,9L,9L,6L,8L,8L,0L,9L,3L,8L,5L,6L,5L,6L,5L,1L,2L,3L,2L,4L,3L,8L,8L,6L,7L,4L,2L,5L,0L,8L,9L,6L,7L,6L,3L,4L,5L,2L,4L,2L,0L,1L,5L,5L,2L,9L,8L,3L,5L,9L,4L,0L,9L,7L,0L,6L,9L,2L,5L,8L,1L,2L,3L,2L,9L,9L,9L,3L,5L,7L,3L,5L,1L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200235Inst : IEnumerable<long>
{
public static readonly long[] Value=A200235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200235.Bytes);
public long this[int i]=>Value[i];

public static A200235Inst Instance=new A200235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200236
{
public static readonly long[] Value={ 1L,2L,1L,7L,2L,4L,5L,4L,2L,8L,9L,4L,5L,4L,5L,9L,0L,2L,7L,6L,9L,3L,2L,4L,5L,8L,6L,3L,5L,4L,5L,6L,0L,7L,5L,9L,8L,0L,1L,4L,4L,3L,6L,1L,3L,7L,3L,3L,1L,6L,6L,6L,9L,9L,0L,4L,7L,4L,1L,7L,5L,2L,2L,5L,7L,9L,2L,2L,5L,5L,9L,2L,8L,8L,9L,6L,7L,8L,5L,5L,1L,4L,3L,9L,4L,3L,5L,4L,6L,8L,8L,7L,5L,3L,5L,3L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200236Inst : IEnumerable<long>
{
public static readonly long[] Value=A200236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200236.Bytes);
public long this[int i]=>Value[i];

public static A200236Inst Instance=new A200236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200237
{
public static readonly long[] Value={ 7L,2L,5L,7L,7L,3L,9L,3L,1L,3L,7L,5L,0L,9L,8L,1L,4L,8L,9L,5L,1L,8L,1L,3L,2L,6L,4L,6L,5L,2L,3L,1L,3L,6L,2L,0L,5L,0L,7L,1L,0L,0L,3L,6L,3L,9L,2L,4L,3L,7L,9L,1L,2L,8L,7L,9L,4L,2L,5L,4L,9L,7L,2L,3L,0L,8L,5L,0L,1L,2L,8L,3L,0L,9L,4L,0L,3L,4L,8L,6L,7L,3L,5L,7L,4L,1L,1L,8L,6L,2L,0L,6L,8L,6L,3L,3L,7L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200237Inst : IEnumerable<long>
{
public static readonly long[] Value=A200237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200237.Bytes);
public long this[int i]=>Value[i];

public static A200237Inst Instance=new A200237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200238
{
public static readonly long[] Value={ 9L,3L,0L,0L,5L,7L,1L,1L,0L,0L,9L,2L,4L,8L,9L,2L,4L,6L,7L,8L,8L,2L,4L,6L,8L,1L,4L,4L,0L,5L,6L,4L,2L,9L,8L,7L,6L,1L,2L,8L,2L,5L,6L,1L,0L,1L,9L,3L,3L,3L,0L,7L,7L,4L,3L,6L,2L,1L,4L,0L,0L,8L,2L,0L,5L,2L,4L,8L,3L,3L,0L,7L,8L,7L,5L,2L,4L,1L,7L,9L,3L,2L,7L,7L,1L,6L,9L,0L,3L,3L,2L,7L,7L,5L,3L,4L,1L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200238Inst : IEnumerable<long>
{
public static readonly long[] Value=A200238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200238.Bytes);
public long this[int i]=>Value[i];

public static A200238Inst Instance=new A200238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200239
{
public static readonly long[] Value={ 6L,3L,7L,6L,6L,1L,1L,5L,7L,9L,4L,6L,0L,7L,3L,1L,3L,4L,1L,1L,9L,8L,9L,5L,4L,5L,6L,5L,8L,8L,1L,9L,6L,2L,0L,1L,3L,7L,3L,3L,9L,9L,2L,2L,8L,0L,7L,2L,7L,3L,3L,8L,6L,9L,5L,5L,6L,1L,0L,6L,2L,3L,0L,9L,0L,1L,0L,1L,4L,0L,5L,4L,5L,4L,4L,3L,3L,0L,7L,9L,6L,8L,0L,0L,1L,4L,3L,8L,4L,6L,5L,1L,0L,7L,1L,4L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200239Inst : IEnumerable<long>
{
public static readonly long[] Value=A200239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200239.Bytes);
public long this[int i]=>Value[i];

public static A200239Inst Instance=new A200239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200240
{
public static readonly long[] Value={ 1L,0L,3L,9L,8L,2L,9L,6L,9L,3L,3L,2L,4L,6L,0L,7L,5L,9L,6L,0L,7L,1L,7L,9L,3L,5L,3L,2L,1L,2L,0L,3L,8L,7L,7L,6L,2L,6L,4L,1L,3L,2L,0L,9L,3L,9L,9L,9L,6L,8L,7L,3L,4L,1L,4L,4L,0L,5L,9L,2L,6L,3L,0L,4L,7L,3L,9L,8L,1L,6L,8L,8L,9L,6L,2L,3L,0L,3L,5L,4L,8L,8L,6L,6L,3L,9L,1L,6L,5L,0L,2L,9L,3L,0L,7L,2L,3L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200240Inst : IEnumerable<long>
{
public static readonly long[] Value=A200240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200240.Bytes);
public long this[int i]=>Value[i];

public static A200240Inst Instance=new A200240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200241
{
public static readonly long[] Value={ 4L,9L,5L,5L,9L,4L,2L,3L,2L,7L,9L,8L,1L,1L,0L,8L,0L,3L,9L,6L,6L,6L,9L,4L,0L,8L,1L,3L,6L,0L,6L,6L,6L,2L,3L,4L,8L,1L,2L,3L,0L,0L,4L,8L,8L,5L,5L,2L,1L,1L,1L,9L,5L,6L,6L,1L,7L,6L,5L,0L,5L,3L,3L,1L,4L,8L,8L,0L,6L,1L,9L,9L,6L,4L,2L,7L,5L,6L,6L,0L,3L,9L,4L,8L,5L,9L,8L,0L,7L,7L,1L,0L,7L,1L,4L,6L,6L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200241Inst : IEnumerable<long>
{
public static readonly long[] Value=A200241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200241.Bytes);
public long this[int i]=>Value[i];

public static A200241Inst Instance=new A200241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200242
{
public static readonly long[] Value={ 1L,2L,5L,5L,9L,6L,7L,0L,2L,4L,9L,4L,3L,7L,2L,9L,6L,2L,8L,8L,5L,4L,2L,8L,3L,2L,1L,5L,3L,9L,7L,6L,4L,4L,4L,0L,2L,9L,8L,0L,6L,0L,3L,7L,6L,1L,1L,7L,9L,2L,9L,5L,7L,7L,3L,0L,3L,4L,6L,6L,1L,3L,9L,2L,6L,3L,8L,4L,5L,3L,4L,5L,3L,8L,0L,0L,6L,5L,3L,6L,1L,7L,3L,8L,6L,7L,1L,5L,5L,0L,1L,4L,0L,1L,0L,6L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200242Inst : IEnumerable<long>
{
public static readonly long[] Value=A200242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200242.Bytes);
public long this[int i]=>Value[i];

public static A200242Inst Instance=new A200242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200243
{
public static readonly long[] Value={ 1L,3L,8L,5L,6L,4L,0L,6L,4L,6L,0L,5L,5L,1L,0L,1L,8L,3L,4L,8L,2L,1L,9L,5L,7L,0L,7L,3L,2L,0L,4L,6L,9L,7L,8L,9L,3L,5L,5L,4L,2L,4L,4L,2L,0L,3L,0L,4L,8L,3L,0L,4L,5L,0L,2L,4L,4L,4L,6L,4L,5L,5L,8L,3L,5L,6L,1L,5L,4L,6L,4L,1L,3L,5L,2L,7L,0L,4L,0L,0L,2L,9L,6L,6L,4L,9L,1L,6L,9L,4L,9L,4L,0L,5L,7L,9L,8L,8L,6L,0L,5L,4L,0L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200243Inst : IEnumerable<long>
{
public static readonly long[] Value=A200243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200243.Bytes);
public long this[int i]=>Value[i];

public static A200243Inst Instance=new A200243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200244
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200244Inst : IEnumerable<long>
{
public static readonly long[] Value=A200244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200244.Bytes);
public long this[int i]=>Value[i];

public static A200244Inst Instance=new A200244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200245
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,2L,3L,3L,4L,5L,5L,5L,5L,6L,6L,7L,7L,7L,7L,8L,8L,8L,9L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,14L,14L,14L,15L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,17L,18L,19L,19L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,26L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200245Inst : IEnumerable<long>
{
public static readonly long[] Value=A200245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200245.Bytes);
public long this[int i]=>Value[i];

public static A200245Inst Instance=new A200245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200246
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200246Inst : IEnumerable<long>
{
public static readonly long[] Value=A200246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200246.Bytes);
public long this[int i]=>Value[i];

public static A200246Inst Instance=new A200246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200247
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,4L,5L,5L,5L,6L,7L,8L,8L,9L,9L,10L,11L,12L,12L,13L,14L,14L,14L,15L,15L,16L,17L,18L,18L,19L,20L,21L,21L,21L,22L,23L,23L,24L,25L,26L,27L,28L,29L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,38L,38L,38L,39L,39L,39L,40L,40L,41L,41L,42L,42L,43L,43L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200247Inst : IEnumerable<long>
{
public static readonly long[] Value=A200247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200247.Bytes);
public long this[int i]=>Value[i];

public static A200247Inst Instance=new A200247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200248
{
public static readonly BigInteger[] Value={ 0L,1L,2L,9L,68L,710L,9414L,151032L,2840648L,61247664L,1488691530L,40262372480L,1199047315212L,38984874829056L,1373954963380622L,52171222364513280L,2123286652815757200L,BigInteger.Parse("92201888436661409792"),BigInteger.Parse("4255016114128163220882"),BigInteger.Parse("207954945060162884960256") };
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
public class A200248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200248Inst Instance=new A200248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200249
{
public static readonly long[] Value={ 6L,21L,75L,267L,951L,3387L,12063L,42963L,153015L,544971L,1940943L,6912771L,24620199L,87686139L,312298815L,1112268723L,3961403799L,14108748843L,50249054127L,178964660067L,637392088455L,2270105585499L,8085100933407L,28795513971219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200249Inst : IEnumerable<long>
{
public static readonly long[] Value=A200249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200249.Bytes);
public long this[int i]=>Value[i];

public static A200249Inst Instance=new A200249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200250
{
public static readonly long[] Value={ 8L,36L,164L,750L,3434L,15724L,71970L,329455L,1508139L,6903702L,31602661L,144665637L,662227235L,3031438038L,13876832881L,63523149100L,290786125630L,1331114279973L,6093362338144L,27893220846536L,127685131134366L,584496598744029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200250Inst : IEnumerable<long>
{
public static readonly long[] Value=A200250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200250.Bytes);
public long this[int i]=>Value[i];

public static A200250Inst Instance=new A200250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200251
{
public static readonly long[] Value={ 2L,3L,3L,4L,6L,5L,5L,10L,12L,8L,6L,15L,26L,24L,13L,7L,21L,45L,69L,48L,21L,8L,28L,75L,135L,181L,96L,34L,9L,36L,112L,267L,405L,476L,192L,55L,10L,45L,164L,448L,951L,1215L,1252L,384L,89L,11L,55L,225L,750L,1792L,3387L,3645L,3292L,768L,144L,12L,66L,305L,1125L,3434L,7168L,12063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200251Inst : IEnumerable<long>
{
public static readonly long[] Value=A200251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200251.Bytes);
public long this[int i]=>Value[i];

public static A200251Inst Instance=new A200251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200252
{
public static readonly long[] Value={ 5L,12L,26L,45L,75L,112L,164L,225L,305L,396L,510L,637L,791L,960L,1160L,1377L,1629L,1900L,2210L,2541L,2915L,3312L,3756L,4225L,4745L,5292L,5894L,6525L,7215L,7936L,8720L,9537L,10421L,11340L,12330L,13357L,14459L,15600L,16820L,18081L,19425L,20812L,22286L,23805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200252Inst : IEnumerable<long>
{
public static readonly long[] Value=A200252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200252.Bytes);
public long this[int i]=>Value[i];

public static A200252Inst Instance=new A200252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200253
{
public static readonly long[] Value={ 8L,24L,69L,135L,267L,448L,750L,1125L,1690L,2376L,3339L,4459L,5957L,7680L,9900L,12393L,15516L,19000L,23265L,27951L,33583L,39744L,47034L,54925L,64142L,74088L,85575L,97875L,111945L,126976L,144024L,162129L,182512L,204120L,228285L,253783L,282131L,312000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200253Inst : IEnumerable<long>
{
public static readonly long[] Value=A200253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200253.Bytes);
public long this[int i]=>Value[i];

public static A200253Inst Instance=new A200253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200254
{
public static readonly long[] Value={ 13L,48L,181L,405L,951L,1792L,3434L,5625L,9365L,14256L,21855L,31213L,44863L,61440L,84500L,111537L,147789L,190000L,244905L,307461L,386903L,476928L,588990L,714025L,867061L,1037232L,1242451L,1468125L,1736895L,2031616L,2378792L,2756193L,3196493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200254Inst : IEnumerable<long>
{
public static readonly long[] Value=A200254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200254.Bytes);
public long this[int i]=>Value[i];

public static A200254Inst Instance=new A200254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200255
{
public static readonly long[] Value={ 21L,96L,476L,1215L,3387L,7168L,15724L,28125L,51895L,85536L,143052L,218491L,337869L,491520L,721208L,1003833L,1407681L,1900000L,2578060L,3382071L,4457431L,5723136L,7375716L,9282325L,11720787L,14521248L,18038972L,22021875L,26948985L,32505856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200255Inst : IEnumerable<long>
{
public static readonly long[] Value=A200255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200255.Bytes);
public long this[int i]=>Value[i];

public static A200255Inst Instance=new A200255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200256
{
public static readonly long[] Value={ 34L,192L,1252L,3645L,12063L,28672L,71970L,140625L,287570L,513216L,936348L,1529437L,2544535L,3932160L,6155908L,9034497L,13408074L,19000000L,27138660L,37202781L,51353159L,68677632L,92363430L,120670225L,158439658L,203297472L,261905308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200256Inst : IEnumerable<long>
{
public static readonly long[] Value=A200256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200256.Bytes);
public long this[int i]=>Value[i];

public static A200256Inst Instance=new A200256Inst();

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