using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A197305
{
public static readonly long[] Value={ 8L,122L,1139L,15930L,207538L,2533633L,32070816L,406507906L,5121683931L,64661725576L,817020106978L,10316814032165L,130270307404176L,1645111173920002L,20774993393517759L,262348958240337732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197305Inst : IEnumerable<long>
{
public static readonly long[] Value=A197305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197305.Bytes);
public long this[int i]=>Value[i];

public static A197305Inst Instance=new A197305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197306
{
public static readonly BigInteger[] Value={ 13L,275L,3750L,85087L,1711736L,32070816L,638181656L,12585831905L,246443960437L,4851375382650L,95481614034558L,1877187670574508L,36916252065609179L,726088509349589766L,14280238700708392851UL,BigInteger.Parse("280852355095712813555") };
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
public class A197306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197306Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197306.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197306.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197306Inst Instance=new A197306Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197307
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,10L,10L,3L,5L,23L,31L,23L,5L,8L,57L,98L,98L,57L,8L,13L,122L,344L,639L,344L,122L,13L,21L,275L,1139L,3181L,3181L,1139L,275L,21L,34L,623L,3750L,15930L,27709L,15930L,3750L,623L,34L,55L,1394L,12470L,85087L,207538L,207538L,85087L,12470L,1394L,55L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197307Inst : IEnumerable<long>
{
public static readonly long[] Value=A197307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197307.Bytes);
public long this[int i]=>Value[i];

public static A197307Inst Instance=new A197307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197308
{
public static readonly long[] Value={ 1L,11L,73L,101L,137L,803L,1111L,1507L,7373L,10001L,13837L,81103L,110011L,152207L,1010101L,11111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197308Inst : IEnumerable<long>
{
public static readonly long[] Value=A197308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197308.Bytes);
public long this[int i]=>Value[i];

public static A197308Inst Instance=new A197308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197309
{
public static readonly long[] Value={ 1L,3L,9L,37L,111L,333L,333667L,1001001L,3003003L,12345679L,37037037L,111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197309Inst : IEnumerable<long>
{
public static readonly long[] Value=A197309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197309.Bytes);
public long this[int i]=>Value[i];

public static A197309Inst Instance=new A197309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197310
{
public static readonly long[] Value={ 1L,0L,5L,160L,1033L,24704L,2241018L,282284587L,82874179361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197310Inst : IEnumerable<long>
{
public static readonly long[] Value=A197310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197310.Bytes);
public long this[int i]=>Value[i];

public static A197310Inst Instance=new A197310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197311
{
public static readonly long[] Value={ 1L,0L,3L,2L,9L,6L,27L,18L,83L,56L,257L,176L,797L,556L,2475L,1766L,7699L,5640L,23995L,18106L,74937L,58408L,234541L,189266L,735771L,615834L,2313757L,2011340L,7294375L,6591454L,23056393L,21667064L,73073221L,71416640L,232226565L,235964308L,740061147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197311Inst : IEnumerable<long>
{
public static readonly long[] Value=A197311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197311.Bytes);
public long this[int i]=>Value[i];

public static A197311Inst Instance=new A197311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197312
{
public static readonly long[] Value={ 2L,3L,5L,10L,128L,79L,249L,662L,2767L,3969L,14343L,26565L,85744L,172877L,540761L,1086259L,3216870L,6970421L,19943621L,43866426L,122208464L,276719535L,753092637L,1739409216L,4652758432L,10905015671L,28759884710L,68307698666L,178118628885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197312Inst : IEnumerable<long>
{
public static readonly long[] Value=A197312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197312.Bytes);
public long this[int i]=>Value[i];

public static A197312Inst Instance=new A197312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197313
{
public static readonly long[] Value={ 1L,2L,10L,160L,152L,790L,2724L,6242L,26422L,91756L,281296L,990140L,3437208L,11190922L,37836768L,129296206L,433975472L,1455029298L,4951850734L,16696765546L,56134653324L,190052231444L,641906625424L,2162290128232L,7306324921304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197313Inst : IEnumerable<long>
{
public static readonly long[] Value=A197313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197313.Bytes);
public long this[int i]=>Value[i];

public static A197313Inst Instance=new A197313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197314
{
public static readonly long[] Value={ 2L,9L,128L,152L,1033L,4780L,24903L,113774L,553807L,2751427L,13385323L,64601708L,318081207L,1550881210L,7598781154L,37018138503L,181198882339L,884596380240L,4326961466564L,21126289404408L,103287098681855L,504482396779592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197314Inst : IEnumerable<long>
{
public static readonly long[] Value=A197314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197314.Bytes);
public long this[int i]=>Value[i];

public static A197314Inst Instance=new A197314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197315
{
public static readonly long[] Value={ 4L,6L,79L,790L,4780L,24704L,189212L,1400102L,8813744L,62844698L,436492213L,3010736948L,20777197101L,144191070226L,998239321771L,6903357295660L,47811537748912L,330940337259970L,2291691748249353L,15860451380186238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197315Inst : IEnumerable<long>
{
public static readonly long[] Value=A197315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197315.Bytes);
public long this[int i]=>Value[i];

public static A197315Inst Instance=new A197315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197316
{
public static readonly long[] Value={ 2L,27L,249L,2724L,24903L,189212L,2241018L,20425821L,208960627L,1984221109L,20223402011L,195734767851L,1964217477394L,19163046359315L,191509608470344L,1875354477655910L,18682249962661264L,183413216662448071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197316Inst : IEnumerable<long>
{
public static readonly long[] Value=A197316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197316.Bytes);
public long this[int i]=>Value[i];

public static A197316Inst Instance=new A197316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197317
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,2L,1L,3L,3L,1L,2L,2L,5L,2L,2L,4L,9L,10L,10L,9L,4L,2L,6L,128L,160L,128L,6L,2L,4L,27L,79L,152L,152L,79L,27L,4L,8L,18L,249L,790L,1033L,790L,249L,18L,8L,4L,83L,662L,2724L,4780L,4780L,2724L,662L,83L,4L,8L,56L,2767L,6242L,24903L,24704L,24903L,6242L,2767L,56L,8L,16L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197317Inst : IEnumerable<long>
{
public static readonly long[] Value=A197317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197317.Bytes);
public long this[int i]=>Value[i];

public static A197317Inst Instance=new A197317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197318
{
public static readonly long[] Value={ 1L,3L,7L,11L,13L,21L,33L,37L,39L,77L,91L,101L,111L,143L,231L,259L,273L,303L,407L,429L,481L,707L,777L,1001L,1111L,1221L,1313L,1443L,2121L,2849L,3003L,3333L,3367L,3737L,3939L,5291L,7777L,8547L,9191L,9901L,10101L,11211L,14443L,15873L,23331L,26159L,27573L,29703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197318Inst : IEnumerable<long>
{
public static readonly long[] Value=A197318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197318.Bytes);
public long this[int i]=>Value[i];

public static A197318Inst Instance=new A197318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197319
{
public static readonly long[] Value={ 22846L,364426L,400036L,280840L,381442L,351232L,72964L,895162L,1347868L,4289842L,1145458L,1096462L,8301784L,1025596L,9687706L,35668L,9521416L,2232424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197319Inst : IEnumerable<long>
{
public static readonly long[] Value=A197319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197319.Bytes);
public long this[int i]=>Value[i];

public static A197319Inst Instance=new A197319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197320
{
public static readonly BigInteger[] Value={ 1L,2L,31L,2024L,522241L,536215712L,2198218022911L,36024948845706368L,BigInteger.Parse("2361111184527977349121"),BigInteger.Parse("618964706995596541734949376"),BigInteger.Parse("649035559893095618486323487178751"),BigInteger.Parse("2722257150515888128204116425527951075328"),BigInteger.Parse("45671917999814457716384401535256546748378644481") };
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
public class A197320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197320Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197320.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197320.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197320Inst Instance=new A197320Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197321
{
public static readonly BigInteger[] Value={ 1L,88L,4224L,146432L,4100096L,98402304L,2099249152L,40785412096L,734137417728L,12398765277184L,198380244434944L,3029807369551872L,44437174753427456L,628956934971588608L,8625695108181786624L,BigInteger.Parse("115009268109090488320"),BigInteger.Parse("1495120485418176348160"),BigInteger.Parse("18996824991195652423680") };
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
public class A197321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197321Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197321.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197321.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197321Inst Instance=new A197321Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197322
{
public static readonly BigInteger[] Value={ 3L,20L,254L,4632L,110408L,3243617L,113177496L,4570858599L,209655304352L,10763674952097L,611433842280387L,38071427445729200L,2578294348444597266L,BigInteger.Parse("188670154792420320214"),BigInteger.Parse("14834716200104606205407"),BigInteger.Parse("1247263229999781126495327"),BigInteger.Parse("111661618863544248806155259") };
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
public class A197322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197322Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197322.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197322.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197322Inst Instance=new A197322Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197323
{
public static readonly BigInteger[] Value={ 4L,42L,813L,22518L,811368L,35946075L,1888624971L,114746269757L,7912720985079L,610470884770406L,52094956940751710L,4871691779130290166L,BigInteger.Parse("495409898474358881326"),BigInteger.Parse("54427906182810588386673"),BigInteger.Parse("6424384909407981686846705"),BigInteger.Parse("810777549111969648699638306"),BigInteger.Parse("108944087230453697240059783283") };
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
public class A197323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197323Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197323.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197323.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197323Inst Instance=new A197323Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197324
{
public static readonly BigInteger[] Value={ 5L,72L,1876L,69729L,3363232L,199205126L,13982257728L,1134344816184L,104416147080711L,10750872867074586L,1224163955433850943L,BigInteger.Parse("152733676280699540998"),BigInteger.Parse("20719969553916698313304"),BigInteger.Parse("3036565789908881887393113"),BigInteger.Parse("478082645334119488823777214"),BigInteger.Parse("80475210949356295594385157620") };
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
public class A197324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197324Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197324.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197324.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197324Inst Instance=new A197324Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197325
{
public static readonly BigInteger[] Value={ 6L,110L,3605L,168151L,10162550L,753640010L,66200225626L,6719243243859L,773662803646264L,99627047203913814L,14186632841753756405UL,BigInteger.Parse("2213340465298424454702"),BigInteger.Parse("375449162169269152689331"),BigInteger.Parse("68797650004483898373052060"),BigInteger.Parse("13542753444466024362689788808") };
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
public class A197325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197325Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197325.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197325.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197325Inst Instance=new A197325Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197326
{
public static readonly long[] Value={ 1L,3L,5L,1L,8L,8L,4L,1L,3L,6L,6L,5L,4L,4L,1L,9L,4L,8L,9L,6L,3L,0L,7L,9L,8L,1L,1L,0L,4L,6L,7L,8L,8L,0L,1L,8L,2L,3L,8L,0L,2L,9L,3L,1L,8L,0L,6L,2L,2L,4L,9L,8L,5L,0L,7L,9L,8L,8L,6L,6L,4L,0L,8L,9L,0L,2L,6L,7L,2L,7L,7L,3L,7L,8L,2L,7L,1L,6L,0L,2L,2L,4L,8L,4L,2L,3L,9L,9L,1L,9L,1L,9L,9L,7L,4L,8L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197326Inst : IEnumerable<long>
{
public static readonly long[] Value=A197326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197326.Bytes);
public long this[int i]=>Value[i];

public static A197326Inst Instance=new A197326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197327
{
public static readonly long[] Value={ 1L,7L,9L,6L,4L,2L,6L,1L,6L,0L,2L,6L,2L,7L,7L,8L,6L,5L,5L,3L,0L,3L,2L,2L,3L,6L,0L,5L,7L,6L,2L,6L,7L,6L,3L,0L,9L,7L,4L,4L,2L,9L,6L,2L,4L,6L,0L,4L,8L,0L,9L,2L,4L,6L,0L,6L,7L,1L,0L,6L,3L,7L,4L,8L,2L,6L,0L,1L,6L,7L,1L,1L,3L,9L,5L,4L,4L,0L,2L,8L,6L,8L,5L,5L,3L,2L,5L,4L,8L,4L,3L,8L,1L,7L,3L,1L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197327Inst : IEnumerable<long>
{
public static readonly long[] Value=A197327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197327.Bytes);
public long this[int i]=>Value[i];

public static A197327Inst Instance=new A197327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197328
{
public static readonly long[] Value={ 2L,1L,7L,3L,1L,6L,8L,1L,3L,1L,5L,3L,0L,3L,6L,5L,4L,3L,4L,8L,6L,3L,4L,2L,7L,0L,4L,2L,8L,6L,0L,1L,0L,2L,7L,6L,9L,2L,4L,5L,0L,3L,3L,1L,2L,5L,0L,3L,4L,5L,0L,7L,0L,6L,0L,4L,4L,5L,0L,3L,6L,1L,4L,4L,1L,8L,4L,1L,8L,8L,1L,8L,5L,0L,4L,5L,9L,4L,1L,9L,8L,2L,4L,1L,0L,0L,7L,2L,4L,4L,8L,8L,1L,3L,4L,9L,5L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197328Inst : IEnumerable<long>
{
public static readonly long[] Value=A197328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197328.Bytes);
public long this[int i]=>Value[i];

public static A197328Inst Instance=new A197328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197329
{
public static readonly long[] Value={ 1L,0L,8L,6L,5L,8L,4L,0L,6L,5L,7L,6L,5L,1L,8L,2L,7L,1L,7L,4L,3L,1L,7L,1L,3L,5L,2L,1L,4L,3L,0L,0L,5L,1L,3L,8L,4L,6L,2L,2L,5L,1L,6L,5L,6L,2L,5L,1L,7L,2L,5L,3L,5L,3L,0L,2L,2L,2L,5L,1L,8L,0L,7L,2L,0L,9L,2L,0L,9L,4L,0L,9L,2L,5L,2L,2L,9L,7L,0L,9L,9L,1L,2L,0L,5L,0L,3L,6L,2L,2L,4L,4L,0L,6L,7L,4L,7L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197329Inst : IEnumerable<long>
{
public static readonly long[] Value=A197329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197329.Bytes);
public long this[int i]=>Value[i];

public static A197329Inst Instance=new A197329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197330
{
public static readonly long[] Value={ 1L,2L,0L,9L,3L,8L,6L,1L,0L,2L,8L,7L,1L,7L,0L,5L,2L,3L,4L,2L,5L,4L,4L,3L,0L,4L,4L,4L,6L,2L,6L,8L,0L,4L,9L,1L,6L,0L,6L,5L,5L,0L,4L,6L,6L,6L,0L,7L,6L,3L,7L,4L,4L,5L,0L,4L,0L,4L,3L,9L,7L,7L,2L,5L,7L,0L,5L,1L,4L,0L,3L,6L,1L,7L,7L,2L,6L,4L,8L,7L,2L,9L,6L,3L,7L,3L,1L,1L,6L,6L,2L,8L,5L,0L,6L,8L,6L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197330Inst : IEnumerable<long>
{
public static readonly long[] Value=A197330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197330.Bytes);
public long this[int i]=>Value[i];

public static A197330Inst Instance=new A197330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197331
{
public static readonly long[] Value={ 1L,3L,5L,2L,4L,0L,4L,8L,2L,8L,4L,2L,2L,2L,7L,8L,5L,5L,5L,7L,0L,3L,5L,4L,3L,6L,2L,8L,9L,2L,9L,2L,4L,1L,6L,4L,2L,1L,4L,3L,0L,6L,4L,6L,0L,3L,1L,1L,5L,6L,1L,9L,0L,4L,1L,5L,8L,8L,7L,0L,2L,1L,4L,5L,4L,9L,9L,4L,1L,9L,1L,1L,3L,0L,5L,5L,7L,7L,5L,8L,2L,7L,6L,5L,6L,1L,1L,8L,0L,0L,5L,0L,8L,3L,6L,7L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197331Inst : IEnumerable<long>
{
public static readonly long[] Value=A197331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197331.Bytes);
public long this[int i]=>Value[i];

public static A197331Inst Instance=new A197331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197332
{
public static readonly long[] Value={ 8L,3L,6L,7L,1L,6L,3L,1L,2L,1L,6L,3L,9L,9L,1L,8L,6L,7L,7L,3L,4L,2L,1L,3L,9L,2L,9L,9L,2L,6L,7L,0L,2L,8L,4L,9L,6L,7L,9L,5L,5L,1L,5L,8L,6L,6L,8L,5L,2L,7L,0L,5L,6L,9L,5L,9L,8L,5L,6L,2L,5L,6L,3L,2L,4L,3L,2L,1L,6L,3L,7L,7L,4L,1L,9L,2L,9L,4L,4L,7L,3L,3L,5L,1L,7L,7L,7L,6L,4L,5L,8L,6L,2L,9L,9L,6L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197332Inst : IEnumerable<long>
{
public static readonly long[] Value=A197332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197332.Bytes);
public long this[int i]=>Value[i];

public static A197332Inst Instance=new A197332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197333
{
public static readonly long[] Value={ 9L,0L,1L,6L,0L,3L,2L,1L,8L,9L,4L,8L,1L,8L,5L,7L,0L,3L,8L,0L,2L,3L,6L,2L,4L,1L,9L,2L,8L,6L,1L,6L,1L,0L,9L,4L,7L,6L,2L,0L,4L,3L,0L,6L,8L,7L,4L,3L,7L,4L,6L,0L,2L,7L,7L,2L,5L,8L,0L,1L,4L,3L,0L,3L,3L,2L,9L,4L,6L,0L,7L,5L,3L,7L,0L,5L,1L,7L,2L,1L,8L,4L,3L,7L,4L,1L,2L,0L,0L,3L,3L,8L,9L,1L,1L,7L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197333Inst : IEnumerable<long>
{
public static readonly long[] Value=A197333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197333.Bytes);
public long this[int i]=>Value[i];

public static A197333Inst Instance=new A197333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197334
{
public static readonly long[] Value={ 2L,3L,6L,6L,5L,2L,1L,8L,6L,9L,3L,0L,3L,8L,8L,6L,0L,5L,2L,2L,1L,9L,2L,5L,4L,2L,2L,2L,0L,6L,5L,9L,8L,6L,0L,8L,3L,0L,7L,3L,3L,1L,1L,3L,0L,4L,1L,5L,5L,7L,1L,2L,4L,2L,7L,4L,7L,1L,0L,5L,2L,6L,5L,7L,4L,6L,3L,1L,3L,2L,7L,6L,9L,7L,0L,3L,3L,9L,9L,0L,0L,7L,6L,7L,0L,3L,1L,3L,1L,5L,9L,0L,2L,0L,5L,3L,0L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197334Inst : IEnumerable<long>
{
public static readonly long[] Value=A197334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197334.Bytes);
public long this[int i]=>Value[i];

public static A197334Inst Instance=new A197334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197335
{
public static readonly long[] Value={ 3L,0L,9L,9L,8L,1L,4L,8L,9L,0L,7L,0L,1L,3L,6L,9L,1L,0L,3L,1L,8L,0L,1L,6L,2L,2L,6L,8L,6L,0L,1L,8L,7L,1L,9L,4L,6L,5L,0L,1L,4L,6L,2L,3L,5L,1L,1L,5L,7L,2L,9L,0L,4L,4L,3L,3L,8L,1L,7L,2L,9L,0L,6L,4L,4L,5L,5L,3L,0L,9L,9L,9L,2L,5L,5L,3L,2L,3L,6L,5L,3L,2L,4L,1L,2L,1L,5L,3L,3L,6L,4L,8L,5L,9L,6L,7L,7L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197335Inst : IEnumerable<long>
{
public static readonly long[] Value=A197335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197335.Bytes);
public long this[int i]=>Value[i];

public static A197335Inst Instance=new A197335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197336
{
public static readonly long[] Value={ 1L,2L,11L,167L,4005L,238206L,30771790L,8790242932L,5613820818788L,8031626024398536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197336Inst : IEnumerable<long>
{
public static readonly long[] Value=A197336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197336.Bytes);
public long this[int i]=>Value[i];

public static A197336Inst Instance=new A197336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197337
{
public static readonly long[] Value={ 1L,5L,11L,38L,103L,297L,856L,2458L,7045L,20229L,58099L,166807L,478862L,1374798L,3947115L,11332271L,32534963L,93408015L,268175294L,769933854L,2210486645L,6346325657L,18220355429L,52310797713L,150184749648L,431181704516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197337Inst : IEnumerable<long>
{
public static readonly long[] Value=A197337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197337.Bytes);
public long this[int i]=>Value[i];

public static A197337Inst Instance=new A197337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197338
{
public static readonly long[] Value={ 1L,8L,38L,167L,681L,2864L,12148L,51480L,217587L,919656L,3889592L,16451263L,69570928L,294209541L,1244221402L,5261851987L,22252448435L,94105875249L,397975165117L,1683043391582L,7117616634217L,30100509329656L,127295517065791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197338Inst : IEnumerable<long>
{
public static readonly long[] Value=A197338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197338.Bytes);
public long this[int i]=>Value[i];

public static A197338Inst Instance=new A197338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197339
{
public static readonly long[] Value={ 1L,18L,103L,681L,4005L,25336L,159818L,998934L,6247167L,39159520L,245281909L,1536123953L,9621537368L,60265981592L,377473012241L,2364297523481L,14808808584343L,92755034615479L,580971270750017L,3638915917088053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197339Inst : IEnumerable<long>
{
public static readonly long[] Value=A197339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197339.Bytes);
public long this[int i]=>Value[i];

public static A197339Inst Instance=new A197339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197340
{
public static readonly long[] Value={ 1L,37L,297L,2864L,25336L,238206L,2218128L,20616615L,191742443L,1785824065L,16629090574L,154844024184L,1441946937763L,13428059890422L,125048396631303L,1164514063002820L,10844571608332582L,100990468863127178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197340Inst : IEnumerable<long>
{
public static readonly long[] Value=A197340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197340.Bytes);
public long this[int i]=>Value[i];

public static A197340Inst Instance=new A197340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197341
{
public static readonly long[] Value={ 1L,73L,856L,12148L,159818L,2218128L,30771790L,425710602L,5901225887L,81906890563L,1136740659494L,15777299597218L,219003011443420L,3040043574547156L,42200212094991310L,585805173715282824L,8131923948348934992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197341Inst : IEnumerable<long>
{
public static readonly long[] Value=A197341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197341.Bytes);
public long this[int i]=>Value[i];

public static A197341Inst Instance=new A197341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197342
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,5L,5L,1L,1L,8L,11L,8L,1L,1L,18L,38L,38L,18L,1L,1L,37L,103L,167L,103L,37L,1L,1L,73L,297L,681L,681L,297L,73L,1L,1L,151L,856L,2864L,4005L,2864L,856L,151L,1L,1L,306L,2458L,12148L,25336L,25336L,12148L,2458L,306L,1L,1L,621L,7045L,51480L,159818L,238206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197342Inst : IEnumerable<long>
{
public static readonly long[] Value=A197342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197342.Bytes);
public long this[int i]=>Value[i];

public static A197342Inst Instance=new A197342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197343
{
public static readonly long[] Value={ 1L,1L,18L,441L,17577L,2036994L,617973077L,434261782615L,734428231903592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197343Inst : IEnumerable<long>
{
public static readonly long[] Value=A197343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197343.Bytes);
public long this[int i]=>Value[i];

public static A197343Inst Instance=new A197343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197344
{
public static readonly long[] Value={ 1L,1L,9L,17L,33L,89L,249L,553L,1321L,3361L,8281L,19801L,48561L,119729L,292017L,711473L,1743129L,4266529L,10420753L,25472041L,62314921L,152363161L,372445401L,910689521L,2226903849L,5444657417L,13311984513L,32549302369L,79585485409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197344Inst : IEnumerable<long>
{
public static readonly long[] Value=A197344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197344.Bytes);
public long this[int i]=>Value[i];

public static A197344Inst Instance=new A197344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197345
{
public static readonly long[] Value={ 1L,9L,18L,83L,245L,914L,3155L,11287L,39850L,141325L,501819L,1782870L,6328399L,22463277L,79770690L,283288919L,1005900951L,3571642082L,12682562591L,45035370321L,159915993486L,567839908711L,2016337387209L,7159825934978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197345Inst : IEnumerable<long>
{
public static readonly long[] Value=A197345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197345.Bytes);
public long this[int i]=>Value[i];

public static A197345Inst Instance=new A197345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197346
{
public static readonly long[] Value={ 1L,17L,83L,441L,2289L,12399L,71411L,387651L,2116197L,11718977L,64938109L,356963085L,1965892155L,10861424867L,59918428781L,330197022079L,1821334406081L,10048722879503L,55415859459949L,305604003423219L,1685661404741659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197346Inst : IEnumerable<long>
{
public static readonly long[] Value=A197346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197346.Bytes);
public long this[int i]=>Value[i];

public static A197346Inst Instance=new A197346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197347
{
public static readonly long[] Value={ 1L,33L,245L,2289L,17577L,152111L,1367870L,11976207L,102819888L,901652503L,7960734146L,69634517247L,607725930336L,5332051608248L,46793978443276L,409707198498049L,3587805656462116L,31453002589770190L,275677556151201299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197347Inst : IEnumerable<long>
{
public static readonly long[] Value=A197347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197347.Bytes);
public long this[int i]=>Value[i];

public static A197347Inst Instance=new A197347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197348
{
public static readonly long[] Value={ 1L,89L,914L,12399L,152111L,2036994L,28226359L,380264123L,5116945034L,69501003275L,947104916619L,12842955562852L,174219658047809L,2367698149031075L,32167182450501802L,436760612415551953L,5931634825068872065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197348Inst : IEnumerable<long>
{
public static readonly long[] Value=A197348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197348.Bytes);
public long this[int i]=>Value[i];

public static A197348Inst Instance=new A197348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197349
{
public static readonly BigInteger[] Value={ 1L,249L,3155L,71411L,1367870L,28226359L,617973077L,13101311077L,275521117202L,5873309926156L,125869557117323L,2679302153154361L,57014937116227499L,1216703701139959983L,BigInteger.Parse("25962340043703794411"),BigInteger.Parse("553346306492392023723") };
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
public class A197349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197349Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197349.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197349.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197349Inst Instance=new A197349Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197350
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,9L,9L,1L,1L,17L,18L,17L,1L,1L,33L,83L,83L,33L,1L,1L,89L,245L,441L,245L,89L,1L,1L,249L,914L,2289L,2289L,914L,249L,1L,1L,553L,3155L,12399L,17577L,12399L,3155L,553L,1L,1L,1321L,11287L,71411L,152111L,152111L,71411L,11287L,1321L,1L,1L,3361L,39850L,387651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197350Inst : IEnumerable<long>
{
public static readonly long[] Value=A197350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197350.Bytes);
public long this[int i]=>Value[i];

public static A197350Inst Instance=new A197350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197351
{
public static readonly long[] Value={ 0L,1L,17L,18L,289L,290L,306L,307L,4913L,4914L,4930L,4931L,5202L,5203L,5219L,5220L,83521L,83522L,83538L,83539L,83810L,83811L,83827L,83828L,88434L,88435L,88451L,88452L,88723L,88724L,88740L,88741L,1419857L,1419858L,1419874L,1419875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197351Inst : IEnumerable<long>
{
public static readonly long[] Value=A197351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197351.Bytes);
public long this[int i]=>Value[i];

public static A197351Inst Instance=new A197351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197352
{
public static readonly long[] Value={ 0L,1L,18L,19L,324L,325L,342L,343L,5832L,5833L,5850L,5851L,6156L,6157L,6174L,6175L,104976L,104977L,104994L,104995L,105300L,105301L,105318L,105319L,110808L,110809L,110826L,110827L,111132L,111133L,111150L,111151L,1889568L,1889569L,1889586L,1889587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197352Inst : IEnumerable<long>
{
public static readonly long[] Value=A197352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197352.Bytes);
public long this[int i]=>Value[i];

public static A197352Inst Instance=new A197352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197353
{
public static readonly long[] Value={ 0L,1L,19L,20L,361L,362L,380L,381L,6859L,6860L,6878L,6879L,7220L,7221L,7239L,7240L,130321L,130322L,130340L,130341L,130682L,130683L,130701L,130702L,137180L,137181L,137199L,137200L,137541L,137542L,137560L,137561L,2476099L,2476100L,2476118L,2476119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197353Inst : IEnumerable<long>
{
public static readonly long[] Value=A197353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197353.Bytes);
public long this[int i]=>Value[i];

public static A197353Inst Instance=new A197353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197354
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,8L,9L,7L,8L,10L,11L,12L,13L,15L,16L,9L,10L,12L,13L,14L,15L,17L,18L,16L,17L,19L,20L,21L,22L,24L,25L,11L,12L,14L,15L,16L,17L,19L,20L,18L,19L,21L,22L,23L,24L,26L,27L,20L,21L,23L,24L,25L,26L,28L,29L,27L,28L,30L,31L,32L,33L,35L,36L,13L,14L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197354Inst : IEnumerable<long>
{
public static readonly long[] Value=A197354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197354.Bytes);
public long this[int i]=>Value[i];

public static A197354Inst Instance=new A197354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197355
{
public static readonly BigInteger[] Value={ 1L,8L,66L,560L,4876L,43488L,396664L,3695168L,35114640L,340039808L,3352381984L,33619852032L,342711219904L,3548566208000L,37299021381504L,397752024876032L,4300986840453376L,47135959519660032L,523321228732695040L,5883464372569321472L,BigInteger.Parse("66953921672396983296") };
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
public class A197355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197355Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197355.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197355.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197355Inst Instance=new A197355Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197356
{
public static readonly BigInteger[] Value={ 1L,4L,40L,1216L,140800L,68583424L,138280960000L,1127848949579776L,BigInteger.Parse("36911566343372800000"),BigInteger.Parse("4836368016228644955357184"),BigInteger.Parse("2535397941156689968365568000000"),BigInteger.Parse("5316967764024635660932200566930538496"),BigInteger.Parse("44601618005626665627415483458173009920000000") };
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
public class A197356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197356Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197356.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197356.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197356Inst Instance=new A197356Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197357
{
public static readonly long[] Value={ 1L,10L,55L,670L,4840L,55252L,436975L,4816030L,40051495L,432457640L,3715101654L,39581170420L,347847754670L,3671331273480L,32811494188975L,343900019857310L,3113537578058979L,32458256583753952L,296896918816556380L,3081918923741896840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197357Inst : IEnumerable<long>
{
public static readonly long[] Value=A197357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197357.Bytes);
public long this[int i]=>Value[i];

public static A197357Inst Instance=new A197357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197358
{
public static readonly long[] Value={ 1L,1L,33L,803L,79051L,24799027L,22225081365L,66858428077735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197358Inst : IEnumerable<long>
{
public static readonly long[] Value=A197358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197358.Bytes);
public long this[int i]=>Value[i];

public static A197358Inst Instance=new A197358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197359
{
public static readonly long[] Value={ 1L,9L,33L,113L,593L,2435L,10317L,45615L,195093L,841571L,3646693L,15718319L,67872219L,293228491L,1265855985L,5466238427L,23604968149L,101924529475L,440126714041L,1900525775017L,8206607484875L,35437081228013L,153021248588503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197359Inst : IEnumerable<long>
{
public static readonly long[] Value=A197359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197359.Bytes);
public long this[int i]=>Value[i];

public static A197359Inst Instance=new A197359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197360
{
public static readonly long[] Value={ 1L,17L,113L,803L,5855L,41459L,300943L,2224023L,16153497L,116797601L,851944533L,6202923531L,45107191789L,328173759843L,2387891294531L,17373638032901L,126409617048273L,919727576644501L,6691670125651177L,48687601545703711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197360Inst : IEnumerable<long>
{
public static readonly long[] Value=A197360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197360.Bytes);
public long this[int i]=>Value[i];

public static A197360Inst Instance=new A197360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197361
{
public static readonly long[] Value={ 1L,33L,593L,5855L,79051L,1041263L,13639968L,178359981L,2325301494L,30421739045L,398559303702L,5208529268691L,68100059270101L,890956015271870L,11653212521783971L,152394870737191233L,1993174813555117586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197361Inst : IEnumerable<long>
{
public static readonly long[] Value=A197361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197361.Bytes);
public long this[int i]=>Value[i];

public static A197361Inst Instance=new A197361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197362
{
public static readonly BigInteger[] Value={ 1L,89L,2435L,41459L,1041263L,24799027L,564930689L,13016997513L,302413118055L,7014256316261L,162356900029937L,3756243587537729L,87022713805696677L,2015969474427313369L,BigInteger.Parse("46677826922272579365"),BigInteger.Parse("1080890025532285110563") };
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
public class A197362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197362Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197362.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197362.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197362Inst Instance=new A197362Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197363
{
public static readonly BigInteger[] Value={ 1L,249L,10317L,300943L,13639968L,564930689L,22225081365L,916121380455L,37586117262267L,1524500056348640L,62133636167189064L,2537563935267330621L,BigInteger.Parse("103445371582832062080"),BigInteger.Parse("4215904817820876539413"),BigInteger.Parse("171923620467459691011031") };
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
public class A197363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197363Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197363.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197363.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197363Inst Instance=new A197363Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197364
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,9L,9L,1L,1L,17L,33L,17L,1L,1L,33L,113L,113L,33L,1L,1L,89L,593L,803L,593L,89L,1L,1L,249L,2435L,5855L,5855L,2435L,249L,1L,1L,553L,10317L,41459L,79051L,41459L,10317L,553L,1L,1L,1321L,45615L,300943L,1041263L,1041263L,300943L,45615L,1321L,1L,1L,3361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197364Inst : IEnumerable<long>
{
public static readonly long[] Value=A197364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197364.Bytes);
public long this[int i]=>Value[i];

public static A197364Inst Instance=new A197364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197365
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,16L,8L,63L,54L,3L,296L,368L,56L,1623L,2649L,753L,15L,10176L,20544L,9024L,576L,71793L,172596L,104814L,13572L,105L,562848L,1569408L,1228608L,259968L,7968L,4853949L,15398829L,14824314L,4532034L,306729L,945L,45664896L,162412416L,185991936L,75929856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197365Inst : IEnumerable<long>
{
public static readonly long[] Value=A197365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197365.Bytes);
public long this[int i]=>Value[i];

public static A197365Inst Instance=new A197365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197366
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,2L,0L,3L,1L,2L,1L,2L,0L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197366Inst : IEnumerable<long>
{
public static readonly long[] Value=A197366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197366.Bytes);
public long this[int i]=>Value[i];

public static A197366Inst Instance=new A197366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197367
{
public static readonly BigInteger[] Value={ 1L,1L,32L,161L,7485L,509018L,79831388L,27751402365L,20901475723923L,34381589920722561L,BigInteger.Parse("123453405715147118697") };
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
public class A197367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197367Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197367.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197367Inst Instance=new A197367Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197368
{
public static readonly long[] Value={ 1L,3L,32L,45L,189L,646L,1873L,6209L,19883L,62891L,201940L,644884L,2058462L,6580709L,21022103L,67159181L,214583759L,685563259L,2190314160L,6997940987L,22357818950L,71431546562L,228218559544L,729140737836L,2329549699706L,7442735684274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197368Inst : IEnumerable<long>
{
public static readonly long[] Value=A197368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197368.Bytes);
public long this[int i]=>Value[i];

public static A197368Inst Instance=new A197368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197369
{
public static readonly long[] Value={ 1L,7L,45L,161L,899L,4023L,19387L,92169L,436539L,2077281L,9861263L,46848707L,222547181L,1057107041L,5021579939L,23853406065L,113308835575L,538241104209L,2556757711375L,12145141483565L,57691981461499L,274049091332625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197369Inst : IEnumerable<long>
{
public static readonly long[] Value=A197369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197369.Bytes);
public long this[int i]=>Value[i];

public static A197369Inst Instance=new A197369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197370
{
public static readonly long[] Value={ 1L,17L,189L,899L,7485L,50831L,355929L,2503359L,17611057L,123747825L,869308845L,6110148907L,42934775357L,301710593001L,2120231045803L,14899304646125L,104701046013783L,735760461321649L,5170369292373967L,36333455835692225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197370Inst : IEnumerable<long>
{
public static readonly long[] Value=A197370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197370.Bytes);
public long this[int i]=>Value[i];

public static A197370Inst Instance=new A197370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197371
{
public static readonly long[] Value={ 1L,41L,646L,4023L,50831L,509018L,5198997L,54278107L,559939403L,5785336959L,59865826196L,618821603760L,6398319110978L,66160018680427L,684049467447585L,7072850485476387L,73130794356723859L,756143068281744553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197371Inst : IEnumerable<long>
{
public static readonly long[] Value=A197371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197371.Bytes);
public long this[int i]=>Value[i];

public static A197371Inst Instance=new A197371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197372
{
public static readonly long[] Value={ 1L,99L,1873L,19387L,355929L,5198997L,79831388L,1224953019L,18720559109L,286695564063L,4387392987375L,67144325650311L,1027713403550939L,15728844758196796L,240730652255271607L,3684411293604740543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197372Inst : IEnumerable<long>
{
public static readonly long[] Value=A197372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197372.Bytes);
public long this[int i]=>Value[i];

public static A197372Inst Instance=new A197372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197373
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,7L,32L,7L,1L,1L,17L,45L,45L,17L,1L,1L,41L,189L,161L,189L,41L,1L,1L,99L,646L,899L,899L,646L,99L,1L,1L,239L,1873L,4023L,7485L,4023L,1873L,239L,1L,1L,577L,6209L,19387L,50831L,50831L,19387L,6209L,577L,1L,1L,1393L,19883L,92169L,355929L,509018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197373Inst : IEnumerable<long>
{
public static readonly long[] Value=A197373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197373.Bytes);
public long this[int i]=>Value[i];

public static A197373Inst Instance=new A197373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197374
{
public static readonly long[] Value={ 5L,2L,9L,9L,9L,1L,6L,2L,5L,0L,8L,5L,6L,3L,4L,9L,8L,7L,1L,9L,4L,1L,0L,6L,8L,4L,9L,8L,9L,4L,5L,3L,1L,6L,1L,0L,7L,7L,1L,5L,6L,0L,5L,6L,1L,4L,6L,0L,7L,6L,7L,2L,5L,9L,0L,3L,8L,0L,7L,1L,5L,7L,2L,5L,5L,0L,6L,3L,5L,9L,0L,0L,5L,1L,8L,4L,3L,2L,3L,7L,4L,0L,8L,1L,6L,4L,6L,0L,9L,8L,0L,0L,0L,0L,1L,5L,0L,7L,6L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197374Inst : IEnumerable<long>
{
public static readonly long[] Value=A197374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197374.Bytes);
public long this[int i]=>Value[i];

public static A197374Inst Instance=new A197374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197375
{
public static readonly long[] Value={ 9L,6L,7L,9L,1L,9L,9L,1L,7L,1L,6L,2L,8L,4L,0L,1L,2L,4L,6L,1L,0L,7L,0L,3L,7L,5L,3L,8L,3L,1L,8L,3L,0L,1L,7L,4L,1L,3L,5L,2L,2L,3L,3L,0L,3L,9L,8L,2L,9L,3L,4L,7L,6L,7L,0L,1L,7L,9L,1L,5L,6L,8L,1L,4L,0L,9L,1L,6L,1L,9L,1L,7L,8L,8L,2L,1L,0L,4L,5L,9L,5L,3L,9L,4L,9L,3L,7L,5L,7L,7L,2L,1L,1L,6L,6L,9L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197375Inst : IEnumerable<long>
{
public static readonly long[] Value=A197375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197375.Bytes);
public long this[int i]=>Value[i];

public static A197375Inst Instance=new A197375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197376
{
public static readonly long[] Value={ 2L,2L,1L,4L,2L,9L,7L,4L,3L,5L,5L,8L,8L,1L,8L,1L,0L,0L,6L,0L,3L,4L,1L,3L,0L,9L,2L,0L,3L,5L,7L,0L,7L,4L,0L,8L,0L,1L,4L,0L,0L,9L,5L,2L,9L,0L,8L,0L,2L,8L,6L,5L,2L,9L,3L,3L,5L,3L,0L,7L,8L,4L,1L,4L,8L,6L,7L,4L,2L,0L,6L,7L,7L,9L,5L,4L,7L,2L,5L,5L,8L,8L,0L,2L,6L,8L,3L,4L,2L,5L,7L,3L,7L,2L,3L,4L,1L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197376Inst : IEnumerable<long>
{
public static readonly long[] Value=A197376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197376.Bytes);
public long this[int i]=>Value[i];

public static A197376Inst Instance=new A197376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197377
{
public static readonly long[] Value={ 2L,5L,4L,4L,1L,8L,6L,2L,3L,6L,9L,4L,4L,4L,4L,3L,0L,2L,4L,1L,5L,8L,8L,3L,3L,0L,1L,6L,9L,9L,5L,2L,5L,4L,2L,4L,0L,2L,2L,0L,0L,9L,8L,6L,3L,9L,7L,8L,9L,3L,3L,7L,9L,2L,8L,5L,8L,2L,1L,5L,4L,4L,9L,0L,7L,1L,0L,6L,0L,2L,4L,6L,3L,6L,8L,5L,4L,2L,2L,7L,0L,3L,0L,4L,7L,5L,6L,9L,4L,0L,5L,1L,9L,5L,8L,7L,1L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197377Inst : IEnumerable<long>
{
public static readonly long[] Value=A197377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197377.Bytes);
public long this[int i]=>Value[i];

public static A197377Inst Instance=new A197377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197378
{
public static readonly long[] Value={ 1L,9L,5L,0L,7L,2L,1L,8L,5L,4L,6L,5L,2L,8L,5L,4L,5L,7L,6L,2L,8L,6L,6L,6L,5L,5L,1L,8L,2L,0L,4L,0L,1L,1L,5L,4L,4L,6L,4L,5L,0L,1L,6L,3L,4L,2L,9L,2L,8L,2L,1L,8L,2L,3L,0L,8L,4L,5L,4L,6L,0L,2L,4L,3L,6L,0L,3L,5L,8L,9L,9L,8L,7L,1L,5L,7L,0L,7L,0L,3L,3L,2L,5L,1L,5L,5L,4L,0L,3L,5L,5L,1L,6L,0L,0L,0L,4L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197378Inst : IEnumerable<long>
{
public static readonly long[] Value=A197378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197378.Bytes);
public long this[int i]=>Value[i];

public static A197378Inst Instance=new A197378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197379
{
public static readonly long[] Value={ 1L,7L,5L,6L,9L,7L,7L,1L,2L,3L,8L,6L,5L,4L,8L,3L,8L,9L,2L,5L,0L,7L,8L,1L,8L,5L,0L,4L,0L,0L,4L,1L,4L,5L,3L,4L,5L,3L,1L,3L,5L,2L,3L,5L,1L,9L,3L,7L,1L,9L,4L,6L,1L,8L,0L,9L,8L,7L,0L,4L,5L,4L,7L,1L,2L,5L,4L,7L,9L,8L,0L,0L,8L,0L,5L,3L,6L,4L,1L,5L,3L,9L,8L,7L,4L,6L,0L,9L,6L,0L,5L,0L,8L,6L,2L,5L,6L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197379Inst : IEnumerable<long>
{
public static readonly long[] Value=A197379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197379.Bytes);
public long this[int i]=>Value[i];

public static A197379Inst Instance=new A197379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197380
{
public static readonly long[] Value={ 2L,1L,1L,4L,4L,9L,8L,2L,9L,4L,0L,9L,7L,4L,0L,0L,3L,5L,4L,9L,4L,7L,5L,9L,3L,5L,4L,2L,6L,5L,1L,5L,5L,6L,8L,4L,4L,2L,9L,3L,1L,9L,2L,8L,5L,6L,6L,7L,8L,4L,9L,2L,6L,3L,2L,4L,0L,0L,4L,6L,6L,1L,2L,2L,8L,2L,3L,7L,3L,1L,1L,3L,9L,2L,8L,3L,8L,4L,1L,9L,7L,9L,6L,0L,9L,7L,1L,4L,2L,0L,6L,3L,1L,3L,2L,6L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197380Inst : IEnumerable<long>
{
public static readonly long[] Value=A197380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197380.Bytes);
public long this[int i]=>Value[i];

public static A197380Inst Instance=new A197380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197381
{
public static readonly long[] Value={ 8L,8L,7L,3L,6L,0L,4L,8L,4L,4L,7L,7L,8L,5L,1L,6L,3L,6L,8L,6L,1L,3L,1L,4L,2L,5L,6L,8L,0L,8L,3L,6L,9L,0L,1L,2L,5L,1L,3L,0L,6L,8L,4L,3L,9L,8L,9L,4L,4L,2L,1L,2L,8L,2L,1L,5L,5L,7L,2L,9L,6L,2L,2L,6L,0L,6L,1L,9L,8L,2L,8L,8L,7L,9L,9L,0L,9L,8L,9L,9L,9L,6L,4L,7L,5L,8L,9L,9L,9L,1L,8L,3L,6L,4L,8L,4L,8L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197381Inst : IEnumerable<long>
{
public static readonly long[] Value=A197381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197381.Bytes);
public long this[int i]=>Value[i];

public static A197381Inst Instance=new A197381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197382
{
public static readonly long[] Value={ 2L,4L,8L,3L,7L,3L,6L,2L,0L,6L,1L,2L,3L,1L,3L,2L,7L,5L,7L,6L,0L,9L,7L,3L,7L,1L,4L,4L,8L,1L,9L,7L,5L,1L,1L,6L,8L,6L,9L,8L,9L,9L,0L,0L,7L,1L,2L,3L,6L,6L,9L,3L,8L,8L,1L,8L,0L,0L,6L,6L,3L,0L,8L,9L,3L,7L,7L,0L,5L,4L,2L,4L,9L,2L,9L,6L,5L,2L,6L,5L,3L,0L,2L,2L,7L,0L,2L,3L,9L,0L,5L,9L,7L,9L,5L,5L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197382Inst : IEnumerable<long>
{
public static readonly long[] Value=A197382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197382.Bytes);
public long this[int i]=>Value[i];

public static A197382Inst Instance=new A197382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197383
{
public static readonly long[] Value={ 5L,2L,1L,3L,3L,7L,8L,2L,9L,5L,7L,1L,7L,1L,5L,6L,9L,8L,6L,9L,1L,9L,8L,8L,5L,6L,4L,4L,5L,4L,9L,1L,7L,9L,7L,7L,3L,0L,9L,1L,8L,1L,3L,9L,4L,7L,3L,3L,6L,8L,8L,7L,1L,9L,5L,4L,9L,1L,8L,4L,8L,6L,2L,5L,1L,5L,5L,9L,0L,6L,0L,9L,6L,1L,0L,2L,5L,9L,8L,8L,8L,9L,7L,4L,9L,7L,5L,6L,9L,0L,0L,3L,9L,4L,9L,7L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197383Inst : IEnumerable<long>
{
public static readonly long[] Value=A197383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197383.Bytes);
public long this[int i]=>Value[i];

public static A197383Inst Instance=new A197383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197384
{
public static readonly long[] Value={ 1L,5L,4L,0L,6L,7L,5L,0L,0L,2L,9L,3L,4L,0L,1L,2L,5L,1L,0L,8L,8L,0L,4L,7L,8L,2L,3L,9L,5L,2L,2L,4L,3L,4L,3L,4L,4L,3L,8L,8L,3L,9L,4L,1L,0L,2L,0L,4L,5L,4L,5L,6L,5L,9L,8L,2L,5L,0L,3L,9L,3L,5L,7L,5L,6L,3L,9L,3L,4L,3L,1L,2L,7L,5L,8L,0L,4L,6L,1L,6L,2L,9L,3L,8L,1L,4L,7L,6L,2L,0L,9L,3L,9L,5L,9L,1L,4L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197384Inst : IEnumerable<long>
{
public static readonly long[] Value=A197384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197384.Bytes);
public long this[int i]=>Value[i];

public static A197384Inst Instance=new A197384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197385
{
public static readonly long[] Value={ 2L,8L,8L,4L,4L,9L,4L,1L,6L,5L,1L,2L,4L,6L,1L,5L,2L,8L,8L,3L,7L,9L,4L,6L,3L,5L,9L,5L,7L,1L,3L,8L,7L,1L,6L,3L,9L,1L,5L,1L,7L,5L,0L,8L,6L,6L,9L,3L,6L,1L,0L,8L,8L,2L,2L,5L,7L,3L,4L,3L,5L,7L,8L,7L,1L,6L,2L,4L,8L,9L,9L,2L,1L,4L,3L,4L,8L,7L,3L,8L,4L,5L,7L,2L,3L,6L,3L,2L,1L,8L,0L,0L,2L,2L,6L,7L,0L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197385Inst : IEnumerable<long>
{
public static readonly long[] Value=A197385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197385.Bytes);
public long this[int i]=>Value[i];

public static A197385Inst Instance=new A197385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197386
{
public static readonly long[] Value={ 1L,2L,1L,3L,0L,3L,7L,5L,6L,3L,4L,4L,5L,3L,6L,4L,5L,1L,1L,9L,4L,9L,3L,2L,1L,3L,9L,7L,3L,2L,0L,4L,5L,8L,9L,2L,3L,3L,7L,9L,6L,8L,0L,3L,7L,0L,3L,7L,8L,7L,6L,7L,6L,1L,3L,4L,3L,4L,2L,2L,1L,5L,3L,3L,5L,1L,7L,1L,0L,7L,5L,9L,6L,2L,8L,0L,7L,7L,6L,9L,9L,7L,0L,8L,4L,4L,8L,4L,3L,9L,6L,7L,8L,6L,1L,5L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197386Inst : IEnumerable<long>
{
public static readonly long[] Value=A197386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197386.Bytes);
public long this[int i]=>Value[i];

public static A197386Inst Instance=new A197386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197387
{
public static readonly long[] Value={ 2L,1L,5L,3L,2L,1L,5L,0L,6L,6L,6L,8L,2L,6L,9L,8L,3L,3L,5L,4L,3L,3L,9L,0L,1L,2L,2L,7L,8L,4L,4L,6L,1L,3L,4L,8L,4L,2L,9L,2L,6L,1L,6L,3L,2L,0L,4L,9L,1L,8L,4L,6L,4L,1L,3L,8L,6L,0L,7L,7L,3L,3L,0L,9L,6L,6L,2L,0L,5L,4L,0L,3L,7L,4L,3L,9L,6L,7L,3L,8L,3L,8L,0L,6L,4L,6L,8L,2L,1L,6L,8L,7L,7L,8L,3L,0L,9L,4L,58L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197387Inst : IEnumerable<long>
{
public static readonly long[] Value=A197387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197387.Bytes);
public long this[int i]=>Value[i];

public static A197387Inst Instance=new A197387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197388
{
public static readonly long[] Value={ 2L,4L,6L,1L,0L,2L,9L,2L,2L,1L,4L,8L,3L,2L,8L,7L,4L,2L,4L,5L,6L,8L,5L,9L,8L,7L,6L,6L,1L,2L,9L,7L,1L,4L,4L,1L,5L,1L,6L,9L,6L,5L,4L,9L,7L,2L,0L,3L,9L,6L,7L,0L,0L,8L,6L,9L,7L,8L,9L,2L,8L,0L,1L,9L,4L,2L,3L,5L,1L,3L,2L,8L,9L,4L,3L,2L,9L,1L,2L,9L,0L,7L,3L,4L,1L,2L,3L,8L,0L,2L,5L,4L,3L,1L,8L,6L,5L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197388Inst : IEnumerable<long>
{
public static readonly long[] Value=A197388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197388.Bytes);
public long this[int i]=>Value[i];

public static A197388Inst Instance=new A197388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197389
{
public static readonly long[] Value={ 1L,9L,0L,3L,9L,9L,2L,2L,5L,1L,9L,3L,0L,9L,5L,6L,2L,7L,3L,4L,0L,4L,2L,7L,7L,7L,2L,4L,5L,5L,5L,6L,8L,3L,2L,1L,1L,0L,9L,6L,8L,0L,6L,9L,1L,6L,0L,0L,7L,1L,2L,9L,1L,5L,2L,1L,7L,7L,5L,3L,3L,7L,7L,4L,3L,2L,9L,8L,8L,2L,8L,5L,4L,0L,0L,0L,7L,4L,6L,4L,7L,3L,1L,1L,5L,2L,3L,7L,7L,6L,5L,0L,2L,7L,7L,5L,4L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197389Inst : IEnumerable<long>
{
public static readonly long[] Value=A197389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197389.Bytes);
public long this[int i]=>Value[i];

public static A197389Inst Instance=new A197389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197390
{
public static readonly long[] Value={ 9L,9L,7L,2L,7L,3L,0L,3L,0L,9L,5L,9L,9L,9L,6L,5L,7L,1L,6L,6L,4L,3L,8L,3L,4L,5L,7L,5L,4L,4L,6L,4L,5L,3L,9L,4L,1L,3L,2L,0L,9L,1L,2L,7L,5L,4L,4L,8L,6L,0L,4L,0L,3L,8L,7L,1L,4L,0L,6L,7L,1L,9L,8L,4L,7L,2L,2L,7L,0L,6L,4L,5L,0L,7L,7L,2L,3L,0L,9L,3L,7L,1L,9L,7L,4L,2L,1L,0L,6L,3L,9L,5L,0L,1L,5L,8L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197390Inst : IEnumerable<long>
{
public static readonly long[] Value=A197390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197390.Bytes);
public long this[int i]=>Value[i];

public static A197390Inst Instance=new A197390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197391
{
public static readonly long[] Value={ 2L,0L,7L,0L,5L,3L,4L,3L,2L,1L,0L,0L,7L,2L,5L,6L,5L,9L,0L,1L,3L,9L,5L,8L,5L,2L,2L,0L,5L,5L,2L,0L,4L,9L,7L,4L,4L,8L,2L,4L,4L,6L,5L,1L,2L,0L,3L,3L,5L,4L,2L,1L,5L,6L,1L,0L,0L,0L,1L,5L,0L,8L,1L,0L,9L,0L,2L,2L,0L,0L,3L,2L,3L,6L,8L,0L,3L,3L,7L,1L,4L,3L,2L,0L,8L,1L,9L,1L,4L,3L,4L,0L,4L,3L,9L,9L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197391Inst : IEnumerable<long>
{
public static readonly long[] Value=A197391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197391.Bytes);
public long this[int i]=>Value[i];

public static A197391Inst Instance=new A197391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197392
{
public static readonly long[] Value={ 0L,8L,9L,3L,1L,1L,7L,7L,4L,8L,5L,4L,4L,8L,4L,7L,6L,2L,9L,4L,4L,5L,4L,2L,3L,6L,0L,1L,7L,1L,0L,9L,9L,4L,7L,7L,0L,8L,2L,6L,4L,5L,8L,9L,5L,0L,0L,5L,0L,8L,4L,9L,4L,2L,4L,4L,4L,3L,9L,3L,3L,8L,9L,1L,3L,0L,1L,1L,5L,7L,8L,4L,5L,7L,0L,9L,8L,7L,2L,0L,2L,8L,1L,0L,1L,7L,1L,0L,3L,2L,5L,5L,5L,9L,6L,8L,4L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197392Inst : IEnumerable<long>
{
public static readonly long[] Value=A197392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197392.Bytes);
public long this[int i]=>Value[i];

public static A197392Inst Instance=new A197392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197393
{
public static readonly long[] Value={ 2L,5L,3L,8L,6L,5L,6L,3L,3L,5L,9L,0L,7L,9L,4L,1L,6L,9L,7L,8L,7L,2L,3L,7L,0L,2L,9L,9L,4L,0L,7L,5L,7L,7L,6L,1L,4L,7L,9L,5L,7L,4L,2L,5L,5L,4L,6L,7L,6L,1L,7L,2L,2L,0L,2L,9L,0L,3L,3L,7L,8L,3L,6L,5L,7L,7L,3L,1L,7L,7L,1L,3L,8L,6L,6L,7L,6L,6L,1L,9L,6L,4L,1L,5L,3L,6L,5L,0L,3L,5L,3L,3L,7L,0L,3L,3L,9L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197393Inst : IEnumerable<long>
{
public static readonly long[] Value=A197393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197393.Bytes);
public long this[int i]=>Value[i];

public static A197393Inst Instance=new A197393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197394
{
public static readonly long[] Value={ 2L,9L,9L,8L,8L,7L,3L,7L,3L,2L,3L,3L,1L,8L,9L,8L,6L,2L,1L,7L,7L,6L,8L,5L,1L,9L,0L,3L,1L,3L,9L,1L,6L,1L,0L,2L,1L,9L,0L,2L,4L,5L,5L,2L,2L,8L,6L,7L,3L,2L,7L,1L,9L,5L,4L,0L,2L,6L,0L,1L,4L,1L,6L,1L,9L,5L,0L,6L,8L,4L,6L,1L,8L,6L,6L,1L,4L,4L,9L,9L,7L,3L,2L,2L,8L,5L,1L,0L,3L,2L,9L,6L,2L,7L,6L,4L,0L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197394Inst : IEnumerable<long>
{
public static readonly long[] Value=A197394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197394.Bytes);
public long this[int i]=>Value[i];

public static A197394Inst Instance=new A197394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197395
{
public static readonly long[] Value={ 1L,1L,17L,547L,19603L,1982913L,534127371L,330460207137L,459425284426157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197395Inst : IEnumerable<long>
{
public static readonly long[] Value=A197395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197395.Bytes);
public long this[int i]=>Value[i];

public static A197395Inst Instance=new A197395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197396
{
public static readonly long[] Value={ 1L,9L,17L,81L,257L,1003L,3417L,12673L,46165L,168569L,614795L,2245461L,8191537L,29913649L,109228305L,398768515L,1455927145L,5315748449L,19407950069L,70859924513L,258716449075L,944591935629L,3448776039137L,12591745130321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197396Inst : IEnumerable<long>
{
public static readonly long[] Value=A197396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197396.Bytes);
public long this[int i]=>Value[i];

public static A197396Inst Instance=new A197396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197397
{
public static readonly long[] Value={ 1L,17L,81L,547L,2571L,13397L,78101L,423957L,2255611L,12173719L,66864485L,361733507L,1953439221L,10607016995L,57610139877L,312099473393L,1691511381425L,9176876436943L,49767044309153L,269799849310117L,1462993236129599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197397Inst : IEnumerable<long>
{
public static readonly long[] Value=A197397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197397.Bytes);
public long this[int i]=>Value[i];

public static A197397Inst Instance=new A197397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197398
{
public static readonly long[] Value={ 1L,33L,257L,2571L,19603L,159463L,1353761L,11871747L,99322949L,832736311L,7100237801L,60485596877L,511509684117L,4330650440271L,36779000662959L,312087013491651L,2645221650088423L,22429333082583617L,190276664212068839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197398Inst : IEnumerable<long>
{
public static readonly long[] Value=A197398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197398.Bytes);
public long this[int i]=>Value[i];

public static A197398Inst Instance=new A197398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197399
{
public static readonly long[] Value={ 1L,89L,1003L,13397L,159463L,1982913L,26456233L,338629635L,4353024153L,55929879939L,722493236409L,9314480449393L,119992375800087L,1545874022307093L,19926794194335021L,256859243868710897L,3310199428923647595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197399Inst : IEnumerable<long>
{
public static readonly long[] Value=A197399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197399.Bytes);
public long this[int i]=>Value[i];

public static A197399Inst Instance=new A197399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197400
{
public static readonly BigInteger[] Value={ 1L,249L,3417L,78101L,1353761L,26456233L,534127371L,10702459629L,210165095895L,4163535286913L,82989760611503L,1647146588097919L,32676624824656185L,648733177064446543L,12886037922010071897UL,BigInteger.Parse("255825582321287654665") };
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
public class A197400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197400Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197400.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197400.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197400Inst Instance=new A197400Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197401
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,9L,9L,1L,1L,17L,17L,17L,1L,1L,33L,81L,81L,33L,1L,1L,89L,257L,547L,257L,89L,1L,1L,249L,1003L,2571L,2571L,1003L,249L,1L,1L,553L,3417L,13397L,19603L,13397L,3417L,553L,1L,1L,1321L,12673L,78101L,159463L,159463L,78101L,12673L,1321L,1L,1L,3361L,46165L,423957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197401Inst : IEnumerable<long>
{
public static readonly long[] Value=A197401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197401.Bytes);
public long this[int i]=>Value[i];

public static A197401Inst Instance=new A197401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197402
{
public static readonly long[] Value={ 1L,9L,60L,3305L,356211L,93153650L,77683473682L,174585377113223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197402Inst : IEnumerable<long>
{
public static readonly long[] Value=A197402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197402.Bytes);
public long this[int i]=>Value[i];

public static A197402Inst Instance=new A197402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197403
{
public static readonly long[] Value={ 3L,9L,20L,71L,227L,664L,2107L,6675L,20696L,65029L,205057L,643930L,2026105L,6384135L,20104382L,63329883L,199576691L,628932096L,1982100085L,6247388117L,19691746204L,62069757373L,195654894641L,616749232724L,1944155102539L,6128552692107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197403Inst : IEnumerable<long>
{
public static readonly long[] Value=A197403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197403.Bytes);
public long this[int i]=>Value[i];

public static A197403Inst Instance=new A197403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197404
{
public static readonly long[] Value={ 4L,20L,60L,358L,1626L,7232L,34717L,160988L,748843L,3514426L,16448990L,76889286L,359867470L,1684122959L,7879951514L,36879246800L,172597946528L,807735845097L,3780221117751L,17691605965676L,82797291928191L,387496301051514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197404Inst : IEnumerable<long>
{
public static readonly long[] Value=A197404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197404.Bytes);
public long this[int i]=>Value[i];

public static A197404Inst Instance=new A197404Inst();

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