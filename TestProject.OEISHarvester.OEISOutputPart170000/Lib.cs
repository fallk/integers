using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A200457
{
public static readonly long[] Value={ 6L,144L,728L,2334L,5720L,12002L,22276L,38174L,61290L,93704L,137374L,194964L,268842L,362092L,477620L,618954L,789324L,992970L,1233412L,1515270L,1842742L,2220844L,2654034L,3148080L,3707758L,4339192L,5047836L,5840186L,6721964L,7700510L,8781768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200457Inst : IEnumerable<long>
{
public static readonly long[] Value=A200457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200457.Bytes);
public long this[int i]=>Value[i];

public static A200457Inst Instance=new A200457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200458
{
public static readonly long[] Value={ 10L,486L,3788L,16380L,50852L,127988L,278906L,547518L,991740L,1686602L,2726152L,4224676L,6319970L,9175294L,12980046L,17954222L,24348932L,32448240L,42572590L,55080404L,70369230L,88879322L,111095332L,137546940L,168813148L,205524308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200458Inst : IEnumerable<long>
{
public static readonly long[] Value=A200458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200458.Bytes);
public long this[int i]=>Value[i];

public static A200458Inst Instance=new A200458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200459
{
public static readonly long[] Value={ 14L,1582L,19802L,115140L,451708L,1375006L,3513884L,7910100L,16176994L,30639164L,54582252L,92444962L,150029642L,234839570L,356372880L,526276044L,758938962L,1071722528L,1485196016L,2023848468L,2716453852L,3596089776L,4701336350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200459Inst : IEnumerable<long>
{
public static readonly long[] Value=A200459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200459.Bytes);
public long this[int i]=>Value[i];

public static A200459Inst Instance=new A200459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200460
{
public static readonly long[] Value={ 22L,5478L,103726L,820650L,4062384L,14923636L,44716536L,115516220L,266427776L,562116652L,1103746930L,2042412926L,3596047852L,6069519806L,9877920686L,15574753386L,23883962076L,35735712652L,52308828350L,75077488038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200460Inst : IEnumerable<long>
{
public static readonly long[] Value=A200460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200460.Bytes);
public long this[int i]=>Value[i];

public static A200460Inst Instance=new A200460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200461
{
public static readonly long[] Value={ 34L,18692L,548204L,5876818L,36725772L,163058296L,572857272L,1697721154L,4418429664L,10383073842L,22471124198L,45437973772L,86792210440L,157952348940L,275717978586L,464147942094L,756885155284L,1199972729134L,1855294240358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200461Inst : IEnumerable<long>
{
public static readonly long[] Value=A200461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200461.Bytes);
public long this[int i]=>Value[i];

public static A200461Inst Instance=new A200461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200462
{
public static readonly long[] Value={ 2L,3L,5L,8L,13L,20L,29L,43L,63L,91L,130L,184L,262L,370L,519L,724L,1010L,1408L,1955L,2705L,3735L,5157L,7107L,9775L,13418L,18406L,25227L,34529L,47200L,64455L,87969L,119952L,163415L,222427L,302568L,411334L,558808L,758640L,1029312L,1395882L,1891970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200462Inst : IEnumerable<long>
{
public static readonly long[] Value=A200462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200462.Bytes);
public long this[int i]=>Value[i];

public static A200462Inst Instance=new A200462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200463
{
public static readonly long[] Value={ 3L,6L,12L,24L,48L,98L,199L,400L,800L,1597L,3188L,6360L,12679L,25273L,50376L,100400L,200077L,398698L,794502L,1583212L,3154828L,6286514L,12526942L,24961994L,49740765L,99116372L,197505241L,393560803L,784232662L,1562708632L,3113946596L,6205036280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200463Inst : IEnumerable<long>
{
public static readonly long[] Value=A200463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200463.Bytes);
public long this[int i]=>Value[i];

public static A200463Inst Instance=new A200463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200464
{
public static readonly long[] Value={ 4L,10L,26L,69L,181L,455L,1120L,2794L,6955L,17254L,42770L,105825L,262026L,648672L,1605786L,3974375L,9835789L,24343416L,60250311L,149117782L,369056036L,913396093L,2260628044L,5594995167L,13847440350L,34272006253L,84822308047L,209933077581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200464Inst : IEnumerable<long>
{
public static readonly long[] Value=A200464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200464.Bytes);
public long this[int i]=>Value[i];

public static A200464Inst Instance=new A200464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200465
{
public static readonly long[] Value={ 5L,15L,45L,135L,405L,1213L,3627L,10846L,32429L,96970L,289870L,866499L,2590128L,7742621L,23144448L,69183744L,206804024L,618180094L,1847865864L,5523643627L,16511274210L,49355507149L,147533484214L,441007079909L,1318258258809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200465Inst : IEnumerable<long>
{
public static readonly long[] Value=A200465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200465.Bytes);
public long this[int i]=>Value[i];

public static A200465Inst Instance=new A200465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200466
{
public static readonly long[] Value={ 6L,21L,75L,267L,951L,3328L,11576L,40309L,140298L,487872L,1695490L,5890943L,20469215L,71122969L,247110741L,858548734L,2982886197L,10363606865L,36006690099L,125099226783L,434636165827L,1510070809645L,5246488474683L,18228043608602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200466Inst : IEnumerable<long>
{
public static readonly long[] Value=A200466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200466.Bytes);
public long this[int i]=>Value[i];

public static A200466Inst Instance=new A200466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200467
{
public static readonly long[] Value={ 7L,28L,112L,448L,1792L,7140L,28434L,113193L,450812L,1795581L,7151892L,28486092L,113459436L,451907189L,1799936702L,7169108310L,28554377148L,113731374269L,452989138551L,1804244048124L,7186257254293L,28622677050945L,114003380196965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200467Inst : IEnumerable<long>
{
public static readonly long[] Value=A200467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200467.Bytes);
public long this[int i]=>Value[i];

public static A200467Inst Instance=new A200467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200468
{
public static readonly long[] Value={ 8L,36L,164L,750L,3434L,15446L,69136L,309748L,1386973L,6207948L,27781867L,124317636L,556310068L,2489502301L,11140314293L,49852273554L,223086037878L,998302588120L,4467360525658L,19991251154656L,89460006607948L,400329985806851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200468Inst : IEnumerable<long>
{
public static readonly long[] Value=A200468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200468.Bytes);
public long this[int i]=>Value[i];

public static A200468Inst Instance=new A200468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200469
{
public static readonly long[] Value={ 2L,3L,3L,4L,6L,5L,5L,10L,12L,8L,6L,15L,26L,24L,13L,7L,21L,45L,69L,48L,20L,8L,28L,75L,135L,181L,98L,29L,9L,36L,112L,267L,405L,455L,199L,43L,10L,45L,164L,448L,951L,1213L,1120L,400L,63L,11L,55L,225L,750L,1792L,3328L,3627L,2794L,800L,91L,12L,66L,305L,1125L,3434L,7140L,11576L,10846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200469Inst : IEnumerable<long>
{
public static readonly long[] Value=A200469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200469.Bytes);
public long this[int i]=>Value[i];

public static A200469Inst Instance=new A200469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200470
{
public static readonly long[] Value={ 20L,98L,455L,1213L,3328L,7140L,15446L,28023L,51356L,85228L,141665L,217763L,335496L,489964L,716380L,1000977L,1400376L,1894984L,2565347L,3373769L,4439204L,5709980L,7346722L,9262315L,11681488L,14491782L,17981005L,21979651L,26872568L,32446832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200470Inst : IEnumerable<long>
{
public static readonly long[] Value=A200470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200470.Bytes);
public long this[int i]=>Value[i];

public static A200470Inst Instance=new A200470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200471
{
public static readonly long[] Value={ 29L,199L,1120L,3627L,11576L,28434L,69136L,139566L,281169L,509465L,917176L,1519297L,2507652L,3907871L,6070416L,8983497L,13266213L,18901105L,26867168L,37023721L,50931188L,68369984L,91636040L,120165960L,157385059L,202502115L,260240316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200471Inst : IEnumerable<long>
{
public static readonly long[] Value=A200471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200471.Bytes);
public long this[int i]=>Value[i];

public static A200471Inst Instance=new A200471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200472
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,3L,0L,1L,1L,0L,0L,0L,1L,1L,10L,15L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,35L,0L,105L,0L,0L,0L,1L,1L,0L,280L,0L,0L,0L,0L,0L,1L,1L,126L,0L,0L,945L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,462L,5775L,15400L,0L,10395L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200472Inst : IEnumerable<long>
{
public static readonly long[] Value=A200472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200472.Bytes);
public long this[int i]=>Value[i];

public static A200472Inst Instance=new A200472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200473
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,10L,15L,1L,1L,1L,1L,35L,105L,1L,1L,280L,1L,1L,126L,945L,1L,1L,1L,1L,462L,5775L,15400L,10395L,1L,1L,1L,1L,1716L,135135L,1L,1L,126126L,1401400L,1L,1L,6435L,2627625L,2027025L,1L,1L,1L,1L,24310L,2858856L,190590400L,34459425L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200473Inst : IEnumerable<long>
{
public static readonly long[] Value=A200473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200473.Bytes);
public long this[int i]=>Value[i];

public static A200473Inst Instance=new A200473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200474
{
public static readonly long[] Value={ 3L,6L,2L,4L,6L,1L,5L,3L,1L,2L,4L,3L,1L,3L,2L,1L,3L,2L,3L,3L,1L,0L,1L,0L,1L,6L,1L,2L,0L,4L,0L,2L,2L,1L,2L,2L,0L,3L,0L,1L,0L,4L,4L,1L,0L,1L,2L,0L,3L,1L,1L,1L,0L,1L,1L,0L,3L,4L,1L,0L,1L,4L,1L,2L,0L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,2L,0L,2L,0L,1L,1L,1L,2L,1L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200474Inst : IEnumerable<long>
{
public static readonly long[] Value=A200474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200474.Bytes);
public long this[int i]=>Value[i];

public static A200474Inst Instance=new A200474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200475
{
public static readonly long[] Value={ 1L,1L,3L,13L,65L,350L,1981L,11627L,70132L,432090L,2707595L,17202779L,110563543L,717547090L,4695774335L,30952628861L,205318395288L,1369539030021L,9180527051187L,61813112864984L,417850301293691L,2834802846097200L,19294989810689802L,131723105933867817L,901709774424393614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200475Inst : IEnumerable<long>
{
public static readonly long[] Value=A200475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200475.Bytes);
public long this[int i]=>Value[i];

public static A200475Inst Instance=new A200475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200476
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,3L,1L,3L,1L,8L,3L,9L,6L,16L,9L,24L,17L,35L,29L,49L,45L,81L,73L,110L,115L,166L,166L,240L,250L,347L,372L,491L,539L,715L,776L,988L,1109L,1393L,1553L,1935L,2178L,2676L,3034L,3674L,4176L,5056L,5734L,6862L,7834L,9316L,10615L,12576L,14341L,16890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200476Inst : IEnumerable<long>
{
public static readonly long[] Value=A200476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200476.Bytes);
public long this[int i]=>Value[i];

public static A200476Inst Instance=new A200476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200477
{
public static readonly long[] Value={ 6L,5L,9L,6L,0L,6L,2L,2L,6L,9L,1L,3L,3L,5L,3L,9L,0L,4L,4L,3L,4L,8L,1L,9L,3L,9L,2L,7L,7L,3L,3L,5L,5L,8L,5L,0L,5L,7L,5L,1L,0L,3L,4L,0L,5L,2L,0L,2L,9L,6L,0L,9L,8L,1L,4L,6L,9L,4L,6L,0L,6L,6L,3L,9L,7L,5L,9L,1L,8L,4L,6L,4L,7L,4L,1L,9L,3L,8L,5L,8L,9L,9L,9L,8L,0L,3L,8L,7L,2L,0L,5L,7L,1L,1L,9L,9L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200477Inst : IEnumerable<long>
{
public static readonly long[] Value=A200477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200477.Bytes);
public long this[int i]=>Value[i];

public static A200477Inst Instance=new A200477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200478
{
public static readonly long[] Value={ 1L,1L,3L,6L,3L,1L,1L,5L,7L,7L,5L,0L,5L,6L,6L,5L,7L,0L,2L,3L,1L,0L,8L,5L,5L,2L,8L,6L,1L,7L,8L,4L,4L,3L,8L,6L,4L,5L,8L,5L,6L,0L,5L,6L,8L,7L,8L,4L,5L,0L,2L,7L,6L,6L,3L,7L,3L,7L,3L,2L,8L,5L,9L,0L,7L,0L,6L,0L,3L,8L,2L,9L,5L,9L,0L,4L,2L,3L,2L,5L,0L,6L,8L,3L,4L,1L,1L,5L,9L,6L,8L,5L,3L,0L,1L,3L,6L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200478Inst : IEnumerable<long>
{
public static readonly long[] Value=A200478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200478.Bytes);
public long this[int i]=>Value[i];

public static A200478Inst Instance=new A200478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200479
{
public static readonly long[] Value={ 1L,2L,8L,1L,5L,9L,8L,1L,8L,8L,3L,8L,9L,5L,4L,6L,5L,5L,1L,8L,1L,6L,8L,0L,9L,9L,7L,6L,0L,1L,5L,6L,1L,0L,9L,5L,7L,3L,8L,6L,8L,5L,9L,0L,5L,6L,4L,0L,3L,2L,7L,6L,0L,4L,2L,4L,2L,5L,3L,3L,9L,4L,9L,7L,0L,7L,6L,8L,5L,8L,0L,5L,0L,6L,4L,5L,2L,5L,4L,8L,1L,9L,3L,8L,7L,1L,0L,2L,1L,4L,2L,9L,9L,3L,0L,9L,4L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200479Inst : IEnumerable<long>
{
public static readonly long[] Value=A200479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200479.Bytes);
public long this[int i]=>Value[i];

public static A200479Inst Instance=new A200479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200480
{
public static readonly long[] Value={ 1L,3L,5L,0L,8L,9L,8L,4L,1L,5L,9L,2L,7L,0L,6L,2L,6L,0L,3L,1L,1L,7L,1L,8L,7L,7L,8L,6L,3L,9L,8L,9L,5L,4L,8L,5L,4L,7L,9L,4L,9L,2L,5L,5L,8L,7L,3L,1L,9L,8L,5L,9L,6L,1L,3L,3L,5L,6L,0L,2L,5L,2L,2L,9L,2L,6L,2L,4L,2L,7L,6L,1L,9L,6L,9L,7L,8L,9L,2L,7L,0L,0L,2L,0L,1L,5L,7L,2L,3L,0L,9L,1L,9L,9L,8L,1L,1L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200480Inst : IEnumerable<long>
{
public static readonly long[] Value=A200480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200480.Bytes);
public long this[int i]=>Value[i];

public static A200480Inst Instance=new A200480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200481
{
public static readonly long[] Value={ 3L,7L,3L,7L,5L,2L,2L,6L,6L,8L,3L,0L,3L,9L,4L,3L,9L,3L,0L,2L,4L,3L,6L,2L,4L,5L,4L,0L,8L,6L,3L,6L,0L,6L,4L,3L,2L,8L,4L,4L,8L,3L,5L,6L,7L,8L,4L,9L,8L,0L,8L,1L,4L,5L,1L,1L,4L,9L,7L,6L,1L,7L,2L,9L,7L,4L,5L,9L,1L,5L,2L,9L,0L,1L,3L,3L,5L,3L,8L,4L,5L,8L,8L,7L,7L,5L,8L,1L,2L,2L,2L,3L,0L,0L,6L,1L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200481Inst : IEnumerable<long>
{
public static readonly long[] Value=A200481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200481.Bytes);
public long this[int i]=>Value[i];

public static A200481Inst Instance=new A200481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200482
{
public static readonly long[] Value={ 8L,0L,4L,2L,0L,3L,5L,6L,2L,1L,3L,8L,6L,9L,2L,6L,4L,6L,0L,3L,3L,8L,2L,6L,9L,4L,5L,5L,4L,3L,8L,6L,9L,6L,7L,6L,8L,9L,0L,4L,1L,8L,0L,7L,8L,3L,4L,8L,4L,8L,8L,9L,6L,4L,8L,4L,3L,0L,8L,8L,2L,3L,3L,4L,4L,4L,5L,5L,7L,4L,0L,1L,9L,2L,3L,2L,1L,6L,2L,3L,2L,2L,6L,2L,3L,1L,1L,8L,5L,8L,9L,8L,6L,4L,3L,5L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200482Inst : IEnumerable<long>
{
public static readonly long[] Value=A200482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200482.Bytes);
public long this[int i]=>Value[i];

public static A200482Inst Instance=new A200482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200483
{
public static readonly long[] Value={ 1L,1L,0L,9L,5L,3L,6L,9L,1L,8L,7L,7L,1L,0L,3L,7L,7L,5L,1L,3L,0L,9L,1L,7L,8L,3L,5L,9L,0L,7L,3L,5L,6L,1L,4L,8L,5L,7L,9L,9L,3L,7L,6L,7L,3L,1L,9L,0L,0L,8L,8L,0L,7L,2L,7L,7L,6L,2L,1L,9L,0L,0L,7L,5L,1L,6L,2L,7L,8L,3L,1L,8L,1L,0L,0L,3L,8L,1L,4L,2L,6L,2L,3L,7L,6L,8L,2L,6L,6L,0L,5L,2L,0L,9L,1L,3L,3L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200483Inst : IEnumerable<long>
{
public static readonly long[] Value=A200483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200483.Bytes);
public long this[int i]=>Value[i];

public static A200483Inst Instance=new A200483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200484
{
public static readonly long[] Value={ 1L,2L,5L,5L,4L,4L,5L,6L,4L,8L,9L,2L,1L,7L,7L,2L,0L,6L,0L,8L,3L,1L,9L,7L,6L,5L,0L,7L,2L,1L,7L,5L,5L,9L,2L,7L,0L,5L,5L,0L,3L,7L,7L,7L,0L,2L,7L,6L,5L,1L,8L,1L,4L,9L,1L,7L,2L,2L,4L,7L,0L,8L,2L,6L,6L,9L,9L,3L,6L,9L,7L,5L,6L,0L,6L,2L,3L,0L,3L,4L,4L,1L,7L,1L,3L,3L,9L,1L,9L,4L,5L,7L,1L,2L,0L,3L,7L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200484Inst : IEnumerable<long>
{
public static readonly long[] Value=A200484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200484.Bytes);
public long this[int i]=>Value[i];

public static A200484Inst Instance=new A200484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200485
{
public static readonly long[] Value={ 2L,6L,6L,0L,8L,4L,5L,5L,4L,1L,1L,2L,8L,5L,2L,7L,2L,1L,7L,8L,8L,6L,4L,2L,1L,4L,4L,2L,7L,8L,3L,5L,9L,0L,7L,1L,3L,2L,5L,7L,8L,0L,4L,3L,5L,9L,4L,7L,6L,9L,1L,4L,3L,9L,2L,3L,7L,2L,1L,2L,9L,3L,8L,1L,9L,4L,9L,7L,7L,3L,7L,7L,2L,1L,3L,4L,5L,7L,4L,5L,4L,2L,8L,4L,2L,2L,1L,2L,3L,2L,7L,8L,8L,2L,5L,4L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200485Inst : IEnumerable<long>
{
public static readonly long[] Value=A200485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200485.Bytes);
public long this[int i]=>Value[i];

public static A200485Inst Instance=new A200485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200486
{
public static readonly long[] Value={ 5L,6L,2L,0L,3L,2L,0L,3L,3L,5L,2L,3L,6L,8L,9L,9L,2L,3L,5L,8L,6L,2L,2L,1L,6L,3L,2L,1L,4L,4L,2L,7L,2L,1L,1L,4L,7L,6L,7L,7L,5L,1L,6L,4L,6L,6L,5L,3L,9L,9L,0L,1L,6L,9L,8L,6L,4L,7L,7L,7L,0L,1L,3L,2L,8L,0L,5L,1L,7L,6L,3L,9L,7L,0L,1L,0L,5L,5L,7L,0L,3L,2L,4L,0L,4L,5L,9L,9L,0L,1L,4L,4L,1L,7L,8L,6L,9L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200486Inst : IEnumerable<long>
{
public static readonly long[] Value=A200486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200486.Bytes);
public long this[int i]=>Value[i];

public static A200486Inst Instance=new A200486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200487
{
public static readonly long[] Value={ 8L,5L,9L,4L,6L,0L,9L,4L,1L,0L,0L,6L,0L,2L,7L,0L,7L,4L,0L,8L,1L,4L,4L,7L,6L,4L,1L,6L,1L,4L,2L,2L,2L,6L,1L,0L,6L,2L,0L,1L,7L,2L,4L,2L,2L,7L,9L,3L,8L,2L,1L,7L,6L,9L,7L,6L,3L,6L,1L,0L,9L,7L,5L,7L,5L,3L,6L,5L,4L,5L,9L,2L,2L,8L,6L,3L,6L,0L,3L,0L,1L,1L,7L,4L,6L,8L,9L,1L,0L,7L,0L,1L,8L,0L,7L,6L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200487Inst : IEnumerable<long>
{
public static readonly long[] Value=A200487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200487.Bytes);
public long this[int i]=>Value[i];

public static A200487Inst Instance=new A200487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200488
{
public static readonly long[] Value={ 1L,0L,9L,0L,1L,8L,3L,4L,1L,5L,1L,3L,8L,3L,2L,5L,5L,1L,8L,7L,4L,7L,3L,8L,3L,9L,8L,8L,3L,2L,7L,2L,2L,1L,9L,1L,0L,5L,6L,0L,8L,1L,8L,3L,0L,8L,0L,4L,3L,8L,5L,5L,6L,9L,7L,0L,7L,2L,9L,2L,4L,9L,3L,6L,2L,8L,4L,9L,2L,7L,8L,4L,5L,1L,0L,3L,9L,0L,4L,5L,9L,3L,1L,0L,2L,0L,3L,7L,2L,7L,4L,1L,8L,9L,2L,2L,7L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200488Inst : IEnumerable<long>
{
public static readonly long[] Value=A200488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200488.Bytes);
public long this[int i]=>Value[i];

public static A200488Inst Instance=new A200488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200489
{
public static readonly long[] Value={ 2L,0L,8L,0L,4L,5L,7L,0L,0L,8L,8L,3L,7L,1L,6L,3L,5L,2L,6L,2L,9L,6L,4L,4L,8L,1L,3L,6L,0L,8L,9L,7L,9L,5L,2L,2L,7L,2L,3L,5L,4L,4L,8L,3L,3L,8L,0L,7L,4L,3L,9L,9L,2L,4L,5L,2L,0L,6L,6L,4L,8L,3L,6L,5L,9L,2L,1L,1L,2L,5L,3L,7L,5L,2L,9L,8L,9L,2L,4L,4L,0L,7L,0L,9L,9L,2L,5L,2L,7L,6L,1L,5L,3L,8L,2L,3L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200489Inst : IEnumerable<long>
{
public static readonly long[] Value=A200489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200489.Bytes);
public long this[int i]=>Value[i];

public static A200489Inst Instance=new A200489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200490
{
public static readonly long[] Value={ 4L,3L,1L,4L,4L,3L,5L,4L,4L,9L,6L,7L,0L,4L,5L,5L,3L,5L,1L,5L,4L,8L,7L,4L,3L,8L,7L,5L,0L,8L,5L,5L,3L,8L,7L,3L,7L,0L,4L,0L,6L,2L,4L,5L,8L,7L,4L,9L,8L,9L,0L,5L,7L,9L,1L,2L,3L,4L,1L,6L,7L,7L,0L,1L,4L,7L,4L,5L,6L,6L,2L,6L,1L,3L,7L,5L,5L,8L,6L,7L,9L,6L,7L,4L,0L,5L,9L,6L,7L,0L,1L,4L,6L,0L,7L,2L,7L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200490Inst : IEnumerable<long>
{
public static readonly long[] Value=A200490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200490.Bytes);
public long this[int i]=>Value[i];

public static A200490Inst Instance=new A200490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200491
{
public static readonly long[] Value={ 6L,6L,4L,5L,5L,1L,2L,2L,7L,8L,1L,8L,2L,3L,0L,7L,2L,6L,9L,1L,0L,9L,6L,1L,1L,8L,8L,5L,0L,3L,0L,0L,9L,0L,4L,0L,4L,0L,4L,2L,2L,4L,6L,0L,6L,8L,4L,7L,8L,8L,6L,3L,6L,4L,3L,0L,0L,1L,0L,8L,4L,6L,3L,0L,9L,1L,5L,4L,6L,8L,7L,6L,4L,8L,4L,6L,5L,6L,4L,9L,5L,5L,2L,9L,5L,1L,5L,6L,7L,6L,8L,1L,4L,6L,2L,7L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200491Inst : IEnumerable<long>
{
public static readonly long[] Value=A200491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200491.Bytes);
public long this[int i]=>Value[i];

public static A200491Inst Instance=new A200491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200492
{
public static readonly long[] Value={ 8L,8L,9L,4L,7L,3L,0L,3L,5L,0L,3L,2L,5L,9L,7L,1L,7L,8L,1L,5L,5L,7L,0L,1L,8L,7L,0L,7L,4L,5L,6L,3L,7L,6L,9L,1L,0L,5L,1L,7L,0L,4L,0L,1L,1L,5L,8L,6L,0L,5L,1L,0L,5L,5L,5L,0L,0L,2L,5L,3L,9L,4L,6L,0L,6L,1L,1L,3L,7L,1L,6L,0L,8L,0L,4L,0L,1L,4L,2L,4L,8L,2L,8L,2L,6L,5L,9L,5L,9L,1L,6L,3L,0L,3L,2L,2L,7L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200492Inst : IEnumerable<long>
{
public static readonly long[] Value=A200492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200492.Bytes);
public long this[int i]=>Value[i];

public static A200492Inst Instance=new A200492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200493
{
public static readonly long[] Value={ 1L,2L,2L,5L,1L,1L,8L,4L,0L,4L,9L,0L,9L,9L,7L,7L,2L,0L,4L,2L,0L,6L,0L,6L,4L,4L,3L,2L,8L,8L,6L,9L,5L,7L,7L,6L,6L,2L,2L,5L,2L,6L,6L,8L,6L,3L,4L,4L,6L,4L,3L,9L,0L,1L,0L,8L,6L,0L,1L,8L,6L,6L,8L,2L,4L,7L,8L,0L,9L,8L,7L,9L,6L,0L,6L,9L,4L,2L,7L,0L,3L,1L,2L,9L,7L,5L,6L,7L,2L,6L,7L,1L,9L,9L,5L,8L,8L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200493Inst : IEnumerable<long>
{
public static readonly long[] Value=A200493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200493.Bytes);
public long this[int i]=>Value[i];

public static A200493Inst Instance=new A200493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200494
{
public static readonly long[] Value={ 1L,3L,3L,9L,7L,0L,0L,0L,0L,4L,3L,1L,9L,6L,5L,6L,6L,5L,2L,2L,4L,3L,8L,9L,3L,6L,5L,9L,7L,7L,1L,9L,6L,6L,6L,8L,3L,8L,2L,9L,0L,2L,2L,2L,2L,2L,9L,9L,7L,0L,2L,8L,0L,4L,8L,6L,2L,7L,9L,1L,2L,0L,2L,1L,5L,6L,3L,0L,4L,8L,4L,4L,0L,9L,4L,2L,2L,9L,1L,0L,4L,8L,0L,9L,8L,4L,6L,3L,3L,0L,1L,2L,7L,8L,1L,9L,1L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200494Inst : IEnumerable<long>
{
public static readonly long[] Value=A200494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200494.Bytes);
public long this[int i]=>Value[i];

public static A200494Inst Instance=new A200494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200495
{
public static readonly long[] Value={ 1L,3L,9L,0L,1L,3L,3L,0L,5L,2L,8L,3L,3L,6L,3L,1L,7L,1L,4L,7L,9L,1L,9L,1L,2L,7L,1L,2L,3L,7L,5L,5L,7L,9L,9L,3L,8L,9L,3L,6L,5L,5L,0L,4L,9L,8L,4L,7L,7L,9L,0L,3L,9L,8L,9L,9L,1L,6L,0L,7L,4L,5L,1L,1L,4L,3L,6L,2L,7L,8L,7L,9L,3L,2L,9L,2L,9L,1L,7L,8L,9L,7L,8L,9L,6L,2L,8L,0L,0L,1L,8L,8L,1L,0L,5L,9L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200495Inst : IEnumerable<long>
{
public static readonly long[] Value=A200495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200495.Bytes);
public long this[int i]=>Value[i];

public static A200495Inst Instance=new A200495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200496
{
public static readonly long[] Value={ 1L,4L,2L,0L,7L,9L,4L,7L,4L,4L,8L,7L,9L,0L,2L,5L,8L,4L,9L,1L,8L,6L,2L,4L,8L,2L,4L,1L,8L,2L,3L,6L,9L,9L,1L,7L,2L,2L,9L,7L,1L,3L,2L,8L,3L,7L,8L,3L,4L,3L,4L,7L,2L,2L,4L,7L,5L,4L,9L,3L,0L,9L,0L,2L,8L,9L,6L,7L,5L,3L,0L,5L,9L,6L,9L,4L,4L,2L,2L,7L,3L,3L,2L,9L,6L,5L,8L,6L,6L,4L,2L,0L,3L,3L,6L,3L,6L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200496Inst : IEnumerable<long>
{
public static readonly long[] Value=A200496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200496.Bytes);
public long this[int i]=>Value[i];

public static A200496Inst Instance=new A200496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200497
{
public static readonly long[] Value={ 4L,6L,5L,5L,4L,5L,2L,1L,5L,9L,7L,9L,7L,5L,5L,1L,3L,6L,9L,7L,8L,5L,6L,5L,8L,8L,3L,2L,1L,5L,8L,7L,7L,1L,4L,8L,5L,8L,7L,0L,5L,2L,3L,1L,4L,9L,5L,1L,7L,6L,6L,5L,9L,0L,6L,7L,6L,8L,7L,6L,8L,9L,1L,1L,0L,9L,3L,7L,2L,9L,9L,5L,7L,1L,3L,1L,9L,6L,8L,7L,7L,7L,8L,3L,8L,1L,5L,8L,4L,2L,5L,8L,0L,5L,9L,2L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200497Inst : IEnumerable<long>
{
public static readonly long[] Value=A200497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200497.Bytes);
public long this[int i]=>Value[i];

public static A200497Inst Instance=new A200497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200498
{
public static readonly long[] Value={ 1L,3L,1L,5L,3L,8L,1L,9L,3L,1L,8L,4L,0L,0L,9L,1L,9L,5L,4L,9L,5L,2L,3L,1L,4L,0L,8L,2L,6L,8L,7L,1L,0L,5L,5L,7L,9L,8L,3L,3L,0L,3L,0L,8L,0L,7L,4L,3L,8L,8L,4L,2L,4L,2L,2L,0L,8L,2L,0L,0L,7L,7L,6L,6L,0L,3L,9L,9L,0L,5L,4L,0L,6L,4L,7L,9L,8L,5L,8L,7L,4L,4L,6L,3L,7L,5L,7L,6L,2L,0L,8L,4L,2L,6L,7L,7L,0L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200498Inst : IEnumerable<long>
{
public static readonly long[] Value=A200498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200498.Bytes);
public long this[int i]=>Value[i];

public static A200498Inst Instance=new A200498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200499
{
public static readonly long[] Value={ 2L,8L,9L,9L,2L,7L,3L,5L,6L,0L,6L,5L,5L,8L,9L,8L,9L,8L,2L,2L,0L,1L,4L,1L,6L,0L,2L,5L,9L,1L,1L,2L,0L,7L,7L,3L,9L,7L,5L,8L,2L,7L,3L,5L,5L,2L,9L,5L,2L,3L,0L,3L,9L,4L,6L,2L,2L,0L,6L,0L,3L,6L,2L,6L,3L,8L,7L,7L,3L,8L,5L,7L,7L,0L,0L,3L,8L,6L,5L,9L,6L,2L,3L,4L,9L,5L,5L,7L,6L,1L,2L,9L,2L,3L,0L,5L,6L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200499Inst : IEnumerable<long>
{
public static readonly long[] Value=A200499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200499.Bytes);
public long this[int i]=>Value[i];

public static A200499Inst Instance=new A200499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200500
{
public static readonly long[] Value={ 7L,1L,9L,8L,5L,8L,2L,0L,2L,3L,9L,4L,7L,0L,8L,5L,8L,6L,2L,5L,0L,2L,1L,5L,6L,0L,9L,9L,6L,3L,7L,2L,0L,7L,2L,5L,6L,1L,7L,2L,3L,0L,4L,8L,5L,6L,2L,9L,8L,9L,7L,2L,5L,5L,2L,5L,4L,1L,5L,6L,5L,6L,7L,8L,9L,7L,5L,4L,1L,0L,6L,3L,8L,5L,9L,0L,3L,9L,5L,0L,4L,9L,0L,5L,0L,2L,0L,7L,6L,1L,5L,0L,0L,0L,5L,4L,7L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200500Inst : IEnumerable<long>
{
public static readonly long[] Value=A200500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200500.Bytes);
public long this[int i]=>Value[i];

public static A200500Inst Instance=new A200500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200501
{
public static readonly long[] Value={ 1L,1L,4L,0L,7L,9L,4L,8L,9L,4L,5L,9L,0L,9L,1L,3L,3L,2L,8L,2L,5L,3L,3L,5L,3L,8L,0L,8L,0L,7L,1L,8L,8L,8L,3L,7L,1L,1L,4L,6L,5L,8L,3L,4L,0L,8L,2L,8L,7L,3L,5L,6L,7L,5L,7L,4L,8L,3L,4L,3L,0L,2L,5L,1L,0L,2L,7L,3L,9L,7L,7L,2L,7L,3L,2L,3L,2L,6L,8L,1L,0L,0L,5L,6L,5L,9L,4L,1L,6L,8L,0L,7L,2L,2L,1L,8L,2L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200501Inst : IEnumerable<long>
{
public static readonly long[] Value=A200501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200501.Bytes);
public long this[int i]=>Value[i];

public static A200501Inst Instance=new A200501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200502
{
public static readonly long[] Value={ 1L,2L,8L,9L,1L,6L,8L,1L,2L,5L,3L,8L,3L,7L,6L,0L,4L,2L,4L,9L,4L,2L,1L,5L,1L,4L,6L,1L,2L,0L,8L,9L,2L,5L,2L,2L,4L,6L,2L,9L,6L,0L,6L,6L,0L,9L,7L,2L,0L,5L,0L,6L,8L,8L,1L,4L,8L,4L,0L,6L,8L,8L,5L,1L,4L,1L,3L,3L,1L,7L,6L,6L,9L,5L,7L,8L,1L,7L,7L,7L,3L,4L,4L,5L,6L,9L,9L,0L,5L,9L,6L,1L,3L,5L,5L,0L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200502Inst : IEnumerable<long>
{
public static readonly long[] Value=A200502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200502.Bytes);
public long this[int i]=>Value[i];

public static A200502Inst Instance=new A200502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200503
{
public static readonly long[] Value={ 90L,15960L,24360L,1047480L,2605680L,2856000L,3605070L,4438560L,5268900L,17958150L,21955290L,23910600L,37284660L,40198200L,62438460L,64094520L,66134250L,70590030L,77649390L,83360970L,90070470L,93143820L,98228130L,117164040L,131312160L,151078830L,154904820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200503Inst : IEnumerable<long>
{
public static readonly long[] Value=A200503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200503.Bytes);
public long this[int i]=>Value[i];

public static A200503Inst Instance=new A200503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200504
{
public static readonly long[] Value={ 7L,97L,19417L,43777L,3400207L,11664547L,37055647L,82984537L,89483827L,94752727L,381674467L,1569747997L,2019957337L,5892947647L,6797589427L,14048370097L,23438578897L,24649559647L,29637700987L,29869155847L,45555183127L,52993564567L,58430706067L,93378527647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200504Inst : IEnumerable<long>
{
public static readonly long[] Value=A200504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200504.Bytes);
public long this[int i]=>Value[i];

public static A200504Inst Instance=new A200504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200505
{
public static readonly long[] Value={ 0L,0L,4L,4L,0L,0L,4L,4L,5L,0L,4L,4L,24L,5L,4L,4L,0L,15L,4L,4L,75L,0L,4L,4L,0L,0L,4L,4L,5L,39L,4L,4L,15L,5L,4L,4L,24L,35L,4L,4L,175L,31L,4L,4L,0L,39L,4L,4L,5L,0L,4L,4L,35L,5L,4L,4L,21L,55L,4L,4L,24L,0L,4L,4L,31L,39L,4L,4L,5L,399L,4L,4L,31L,5L,4L,4L,0L,15L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200505Inst : IEnumerable<long>
{
public static readonly long[] Value=A200505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200505.Bytes);
public long this[int i]=>Value[i];

public static A200505Inst Instance=new A200505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200506
{
public static readonly long[] Value={ 0L,0L,0L,5L,5L,0L,0L,9L,5L,5L,7L,0L,63L,5L,5L,36L,9L,7L,5L,5L,0L,44L,9L,5L,5L,9L,16L,0L,5L,5L,16L,7L,0L,5L,5L,0L,0L,21L,5L,5L,9L,16L,16L,5L,5L,7L,12L,0L,5L,5L,28L,36L,7L,5L,5L,12L,192L,16L,5L,5L,37L,9L,16L,5L,5L,24L,7L,9L,5L,5L,9L,0L,0L,5L,5L,36L,9L,52L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200506Inst : IEnumerable<long>
{
public static readonly long[] Value=A200506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200506.Bytes);
public long this[int i]=>Value[i];

public static A200506Inst Instance=new A200506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200507
{
public static readonly long[] Value={ 0L,0L,3L,0L,8L,3L,0L,0L,3L,7L,8L,3L,8L,0L,3L,16L,7L,3L,8L,0L,3L,16L,28L,3L,0L,16L,3L,16L,8L,3L,7L,16L,3L,0L,8L,3L,8L,7L,3L,28L,0L,3L,8L,16L,3L,0L,19L,3L,0L,0L,3L,7L,8L,3L,0L,20L,3L,16L,7L,3L,8L,100L,3L,16L,35L,3L,8L,28L,3L,16L,20L,3L,7L,16L,3L,16L,8L,3L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200507Inst : IEnumerable<long>
{
public static readonly long[] Value=A200507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200507.Bytes);
public long this[int i]=>Value[i];

public static A200507Inst Instance=new A200507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200508
{
public static readonly long[] Value={ 0L,0L,4L,7L,0L,7L,4L,0L,0L,7L,4L,8L,7L,20L,4L,0L,7L,7L,4L,7L,9L,16L,4L,7L,7L,16L,4L,8L,0L,9L,4L,7L,9L,7L,4L,8L,48L,7L,4L,0L,7L,9L,4L,8L,7L,7L,4L,7L,0L,20L,4L,7L,7L,12L,4L,0L,9L,16L,4L,7L,0L,7L,4L,0L,0L,7L,4L,8L,7L,16L,4L,0L,7L,7L,4L,7L,32L,9L,4L,7L,7L,44L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200508Inst : IEnumerable<long>
{
public static readonly long[] Value=A200508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200508.Bytes);
public long this[int i]=>Value[i];

public static A200508Inst Instance=new A200508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200509
{
public static readonly long[] Value={ 0L,0L,4L,4L,8L,0L,4L,4L,0L,0L,4L,4L,8L,9L,4L,4L,9L,0L,4L,4L,8L,80L,4L,4L,45L,9L,4L,4L,8L,80L,4L,4L,0L,45L,4L,4L,8L,21L,4L,4L,9L,61L,4L,4L,8L,0L,4L,4L,45L,9L,4L,4L,8L,0L,4L,4L,0L,80L,4L,4L,8L,9L,4L,4L,15L,0L,4L,4L,8L,45L,4L,4L,0L,15L,4L,4L,8L,0L,4L,4L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200509Inst : IEnumerable<long>
{
public static readonly long[] Value=A200509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200509.Bytes);
public long this[int i]=>Value[i];

public static A200509Inst Instance=new A200509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200510
{
public static readonly long[] Value={ 0L,0L,3L,5L,9L,3L,0L,9L,3L,0L,0L,3L,35L,5L,3L,11L,9L,3L,5L,0L,3L,16L,9L,3L,11L,9L,3L,20L,5L,3L,16L,9L,3L,5L,9L,3L,0L,11L,3L,0L,9L,3L,20L,5L,3L,32L,11L,3L,5L,9L,3L,0L,9L,3L,28L,37L,3L,11L,5L,3L,200L,9L,3L,5L,0L,3L,16L,9L,3L,16L,9L,3L,35L,5L,3L,0L,9L,3L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200510Inst : IEnumerable<long>
{
public static readonly long[] Value=A200510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200510.Bytes);
public long this[int i]=>Value[i];

public static A200510Inst Instance=new A200510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200511
{
public static readonly long[] Value={ 12L,18L,20L,24L,28L,36L,40L,44L,45L,48L,50L,52L,54L,56L,63L,68L,72L,75L,76L,80L,88L,92L,96L,98L,99L,100L,104L,108L,112L,116L,117L,124L,135L,136L,144L,147L,148L,152L,153L,160L,162L,164L,171L,172L,175L,176L,184L,188L,189L,192L,196L,200L,207L,208L,212L,216L,224L,225L,232L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200511Inst : IEnumerable<long>
{
public static readonly long[] Value=A200511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200511.Bytes);
public long this[int i]=>Value[i];

public static A200511Inst Instance=new A200511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200512
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,12L,0L,0L,0L,15L,16L,0L,24L,0L,0L,0L,0L,12L,24L,0L,0L,16L,0L,0L,15L,16L,16L,0L,40L,12L,20L,0L,0L,0L,0L,0L,24L,16L,28L,15L,0L,12L,16L,64L,0L,20L,0L,0L,0L,20L,20L,39L,40L,12L,15L,0L,0L,16L,16L,0L,24L,0L,0L,0L,0L,12L,24L,0L,40L,15L,20L,112L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200512Inst : IEnumerable<long>
{
public static readonly long[] Value=A200512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200512.Bytes);
public long this[int i]=>Value[i];

public static A200512Inst Instance=new A200512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200513
{
public static readonly long[] Value={ 0L,0L,8L,0L,8L,9L,0L,0L,0L,0L,8L,9L,8L,0L,9L,0L,0L,12L,8L,0L,8L,28L,0L,9L,0L,20L,8L,0L,8L,9L,20L,80L,9L,0L,8L,0L,8L,0L,9L,63L,0L,9L,8L,80L,8L,20L,0L,9L,0L,28L,8L,63L,8L,12L,0L,0L,9L,36L,8L,9L,8L,0L,12L,0L,532L,9L,8L,80L,8L,108L,20L,15L,0L,0L,8L,63L,8L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200513Inst : IEnumerable<long>
{
public static readonly long[] Value=A200513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200513.Bytes);
public long this[int i]=>Value[i];

public static A200513Inst Instance=new A200513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200514
{
public static readonly long[] Value={ 0L,3L,4L,0L,3L,0L,4L,3L,0L,0L,3L,16L,0L,3L,4L,0L,3L,0L,4L,3L,0L,0L,3L,16L,0L,3L,4L,16L,3L,40L,4L,3L,0L,0L,3L,0L,0L,3L,4L,16L,3L,63L,4L,3L,63L,0L,3L,20L,0L,3L,4L,20L,3L,40L,4L,3L,80L,0L,3L,16L,0L,3L,4L,0L,3L,0L,4L,3L,0L,40L,3L,16L,80L,3L,4L,16L,3L,0L,4L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200514Inst : IEnumerable<long>
{
public static readonly long[] Value=A200514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200514.Bytes);
public long this[int i]=>Value[i];

public static A200514Inst Instance=new A200514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200515
{
public static readonly long[] Value={ 0L,4L,4L,0L,0L,4L,4L,5L,0L,4L,4L,0L,5L,4L,4L,0L,24L,4L,4L,0L,0L,4L,4L,35L,0L,4L,4L,5L,15L,4L,4L,0L,5L,4L,4L,0L,24L,4L,4L,0L,24L,4L,4L,15L,0L,4L,4L,5L,0L,4L,4L,0L,5L,4L,4L,39L,0L,4L,4L,0L,24L,4L,4L,0L,24L,4L,4L,5L,35L,4L,4L,0L,5L,4L,4L,0L,0L,4L,4L,63L,0L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200515Inst : IEnumerable<long>
{
public static readonly long[] Value=A200515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200515.Bytes);
public long this[int i]=>Value[i];

public static A200515Inst Instance=new A200515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200516
{
public static readonly long[] Value={ 0L,5L,5L,0L,7L,9L,5L,5L,0L,0L,0L,5L,5L,0L,9L,0L,5L,5L,7L,0L,9L,5L,5L,9L,0L,7L,5L,5L,0L,9L,0L,5L,5L,36L,16L,0L,5L,5L,9L,7L,0L,5L,5L,0L,21L,0L,5L,5L,0L,43L,9L,5L,5L,7L,16L,16L,5L,5L,0L,9L,7L,5L,5L,0L,0L,9L,5L,5L,9L,36L,16L,5L,5L,0L,7L,0L,5L,5L,32L,24L,0L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200516Inst : IEnumerable<long>
{
public static readonly long[] Value=A200516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200516.Bytes);
public long this[int i]=>Value[i];

public static A200516Inst Instance=new A200516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200517
{
public static readonly long[] Value={ 0L,3L,0L,0L,3L,7L,8L,3L,0L,0L,3L,16L,7L,3L,8L,0L,3L,16L,0L,3L,8L,16L,3L,16L,0L,3L,7L,16L,3L,0L,8L,3L,0L,7L,3L,0L,8L,3L,8L,16L,3L,28L,0L,3L,8L,19L,3L,7L,0L,3L,20L,0L,3L,16L,7L,3L,100L,0L,3L,16L,8L,3L,8L,0L,3L,16L,28L,3L,7L,16L,3L,16L,0L,3L,0L,7L,3L,19L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200517Inst : IEnumerable<long>
{
public static readonly long[] Value=A200517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200517.Bytes);
public long this[int i]=>Value[i];

public static A200517Inst Instance=new A200517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200518
{
public static readonly long[] Value={ 0L,0L,4L,0L,7L,7L,4L,9L,0L,7L,4L,7L,7L,8L,4L,0L,7L,0L,4L,7L,32L,8L,4L,7L,0L,7L,4L,16L,0L,8L,4L,9L,7L,7L,4L,0L,0L,7L,4L,7L,7L,0L,4L,9L,7L,8L,4L,7L,0L,9L,4L,7L,9L,7L,4L,12L,0L,0L,4L,16L,7L,7L,4L,0L,0L,7L,4L,7L,7L,8L,4L,16L,7L,0L,4L,7L,9L,8L,4L,7L,0L,7L,4L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200518Inst : IEnumerable<long>
{
public static readonly long[] Value=A200518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200518.Bytes);
public long this[int i]=>Value[i];

public static A200518Inst Instance=new A200518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200519
{
public static readonly long[] Value={ 0L,4L,4L,0L,8L,4L,4L,0L,0L,4L,4L,9L,8L,4L,4L,0L,0L,4L,4L,0L,8L,4L,4L,9L,0L,4L,4L,0L,8L,4L,4L,80L,9L,4L,4L,0L,8L,4L,4L,63L,0L,4L,4L,80L,8L,4L,4L,9L,0L,4L,4L,45L,8L,4L,4L,0L,9L,4L,4L,9L,8L,4L,4L,0L,133L,4L,4L,80L,8L,4L,4L,15L,0L,4L,4L,63L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200519Inst : IEnumerable<long>
{
public static readonly long[] Value=A200519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200519.Bytes);
public long this[int i]=>Value[i];

public static A200519Inst Instance=new A200519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200520
{
public static readonly long[] Value={ 0L,3L,5L,0L,3L,9L,0L,3L,0L,11L,3L,9L,5L,3L,9L,0L,3L,5L,11L,3L,9L,0L,3L,9L,0L,3L,0L,5L,3L,9L,16L,3L,5L,20L,3L,0L,1001L,3L,9L,0L,3L,9L,5L,3L,0L,56L,3L,5L,0L,3L,9L,11L,3L,11L,0L,3L,9L,5L,3L,9L,112L,3L,5L,0L,3L,9L,16L,3L,9L,0L,3L,0L,5L,3L,9L,11L,3L,5L,16L,3L,0L,3367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200520Inst : IEnumerable<long>
{
public static readonly long[] Value=A200520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200520.Bytes);
public long this[int i]=>Value[i];

public static A200520Inst Instance=new A200520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200521
{
public static readonly long[] Value={ 420L,630L,660L,780L,840L,924L,990L,1020L,1050L,1092L,1140L,1170L,1260L,1320L,1380L,1386L,1428L,1470L,1530L,1540L,1560L,1596L,1638L,1650L,1680L,1710L,1716L,1740L,1820L,1848L,1860L,1890L,1932L,1950L,1980L,2040L,2070L,2100L,2142L,2184L,2220L,2244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200521Inst : IEnumerable<long>
{
public static readonly long[] Value=A200521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200521.Bytes);
public long this[int i]=>Value[i];

public static A200521Inst Instance=new A200521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200522
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,15L,12L,0L,0L,20L,16L,24L,0L,32L,20L,0L,0L,28L,12L,56L,15L,16L,16L,0L,112L,68L,16L,40L,0L,20L,12L,0L,0L,52L,20L,15L,80L,16L,16L,0L,112L,36L,12L,56L,33L,28L,28L,0L,0L,20L,15L,40L,128L,16L,12L,0L,117L,48L,16L,24L,0L,44L,28L,0L,0L,15L,12L,40L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200522Inst : IEnumerable<long>
{
public static readonly long[] Value=A200522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200522.Bytes);
public long this[int i]=>Value[i];

public static A200522Inst Instance=new A200522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200523
{
public static readonly long[] Value={ 0L,0L,0L,0L,8L,0L,8L,9L,0L,0L,12L,0L,8L,9L,8L,20L,9L,0L,0L,12L,8L,80L,8L,0L,45L,9L,0L,0L,8L,80L,8L,9L,0L,45L,9L,20L,8L,21L,8L,80L,9L,80L,28L,9L,8L,0L,8L,0L,91L,9L,20L,36L,8L,0L,8L,12L,0L,80L,9L,80L,8L,9L,8L,28L,15L,0L,91L,9L,8L,45L,8L,0L,0L,15L,0L,20L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200523Inst : IEnumerable<long>
{
public static readonly long[] Value=A200523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200523.Bytes);
public long this[int i]=>Value[i];

public static A200523Inst Instance=new A200523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200524
{
public static readonly long[] Value={ 0L,0L,3L,0L,0L,3L,4L,0L,3L,16L,4L,3L,0L,20L,3L,0L,0L,3L,4L,56L,3L,16L,4L,3L,80L,16L,3L,40L,0L,3L,4L,0L,3L,20L,4L,3L,64L,16L,3L,0L,63L,3L,4L,56L,3L,28L,4L,3L,0L,20L,3L,40L,63L,3L,4L,0L,3L,16L,4L,3L,0L,28L,3L,0L,0L,3L,4L,40L,3L,16L,4L,3L,85L,16L,3L,56L,63L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200524Inst : IEnumerable<long>
{
public static readonly long[] Value=A200524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200524.Bytes);
public long this[int i]=>Value[i];

public static A200524Inst Instance=new A200524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200525
{
public static readonly long[] Value={ 385L,2585L,7315L,8911L,27001L,39905L,48391L,87283L,192211L,196285L,319705L,410089L,425585L,441091L,624605L,679855L,1310185L,1899163L,2460439L,2586971L,2777041L,6654005L,7042411L,7501261L,8291459L,9516637L,10484585L,11141671L,12527281L,13015891L,13788319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200525Inst : IEnumerable<long>
{
public static readonly long[] Value=A200525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200525.Bytes);
public long this[int i]=>Value[i];

public static A200525Inst Instance=new A200525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200526
{
public static readonly BigInteger[] Value={ 2156316023L,211148507797805L,BigInteger.Parse("392841376460687116573"),BigInteger.Parse("13886731309220741899538675431"),BigInteger.Parse("1359801885649216204023955447726829"),BigInteger.Parse("2529908688645864568558938918274367865293"),BigInteger.Parse("89430911052730984787593270943984417274689212615") };
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
public class A200526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200526Inst Instance=new A200526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200527
{
public static readonly long[] Value={ 3L,20L,243L,4848L,167171L,10000162L,1056792824L,201092476918L,70051408245054L,45119084364602004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200527Inst : IEnumerable<long>
{
public static readonly long[] Value=A200527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200527.Bytes);
public long this[int i]=>Value[i];

public static A200527Inst Instance=new A200527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200528
{
public static readonly long[] Value={ 6L,20L,57L,146L,354L,825L,1873L,4169L,9144L,19825L,42590L,90815L,192457L,405760L,851740L,1781227L,3713015L,7718092L,16003641L,33111477L,68374642L,140947848L,290098848L,596244613L,1223916576L,2509450811L,5139839214L,10517282966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200528Inst : IEnumerable<long>
{
public static readonly long[] Value=A200528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200528.Bytes);
public long this[int i]=>Value[i];

public static A200528Inst Instance=new A200528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200529
{
public static readonly long[] Value={ 11L,57L,243L,905L,3135L,10292L,32556L,100065L,300847L,888587L,2586994L,7441963L,21193523L,59838942L,167704775L,466986683L,1293018711L,3562315723L,9770764284L,26693067952L,72663897633L,197170483178L,533459459628L,1439508706370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200529Inst : IEnumerable<long>
{
public static readonly long[] Value=A200529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200529.Bytes);
public long this[int i]=>Value[i];

public static A200529Inst Instance=new A200529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200530
{
public static readonly long[] Value={ 19L,146L,905L,4848L,23925L,111085L,494555L,2132979L,8981773L,37125420L,151253915L,609247412L,2432002859L,9638730963L,37983584772L,149003379789L,582403346152L,2269881052166L,8826625108206L,34261690527204L,132805131519232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200530Inst : IEnumerable<long>
{
public static readonly long[] Value=A200530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200530.Bytes);
public long this[int i]=>Value[i];

public static A200530Inst Instance=new A200530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200531
{
public static readonly long[] Value={ 32L,354L,3135L,23925L,167171L,1092645L,6820330L,41135050L,241717185L,1391776867L,7886862976L,44130194797L,244429190692L,1342743707709L,7326819179875L,39759798789392L,214782513374737L,1155893422272121L,6201199013944784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200531Inst : IEnumerable<long>
{
public static readonly long[] Value=A200531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200531.Bytes);
public long this[int i]=>Value[i];

public static A200531Inst Instance=new A200531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200532
{
public static readonly long[] Value={ 53L,825L,10292L,111085L,1092645L,10000162L,87098434L,731106792L,5964324991L,47562454949L,372415747947L,2872854627301L,21889626638130L,165068050869351L,1233859196014348L,9153541048411929L,67464412472963033L,494406133695289336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200532Inst : IEnumerable<long>
{
public static readonly long[] Value=A200532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200532.Bytes);
public long this[int i]=>Value[i];

public static A200532Inst Instance=new A200532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200533
{
public static readonly long[] Value={ 87L,1873L,32556L,494555L,6820330L,87098434L,1056792824L,12348422785L,140068079857L,1551453118671L,16861973522704L,180469353488204L,1907201493832312L,19944555935687461L,206749466424763994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200533Inst : IEnumerable<long>
{
public static readonly long[] Value=A200533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200533.Bytes);
public long this[int i]=>Value[i];

public static A200533Inst Instance=new A200533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200534
{
public static readonly long[] Value={ 3L,6L,6L,11L,20L,11L,19L,57L,57L,19L,32L,146L,243L,146L,32L,53L,354L,905L,905L,354L,53L,87L,825L,3135L,4848L,3135L,825L,87L,142L,1873L,10292L,23925L,23925L,10292L,1873L,142L,231L,4169L,32556L,111085L,167171L,111085L,32556L,4169L,231L,375L,9144L,100065L,494555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200534Inst : IEnumerable<long>
{
public static readonly long[] Value=A200534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200534.Bytes);
public long this[int i]=>Value[i];

public static A200534Inst Instance=new A200534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200535
{
public static readonly long[] Value={ 1L,1L,4L,5L,9L,12L,16L,20L,24L,28L,32L,36L,40L,44L,48L,52L,56L,60L,64L,68L,72L,76L,80L,84L,88L,92L,96L,100L,104L,108L,112L,116L,120L,124L,128L,132L,136L,140L,144L,148L,152L,156L,160L,164L,168L,172L,176L,180L,184L,188L,192L,196L,200L,204L,208L,212L,216L,220L,224L,228L,232L,236L,240L,244L,248L,252L,256L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200535Inst : IEnumerable<long>
{
public static readonly long[] Value=A200535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200535.Bytes);
public long this[int i]=>Value[i];

public static A200535Inst Instance=new A200535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200536
{
public static readonly long[] Value={ 1L,1L,3L,2L,1L,6L,13L,12L,4L,1L,9L,33L,63L,66L,36L,8L,1L,12L,62L,180L,321L,360L,248L,96L,16L,1L,15L,100L,390L,985L,1683L,1970L,1560L,800L,240L,32L,1L,18L,147L,720L,2355L,5418L,8989L,10836L,9420L,5760L,2352L,576L,64L,1L,21L,203L,1197L,4809L,13923L,29953L,48639L,59906L,55692L,38472L,19152L,6496L,1344L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200536Inst : IEnumerable<long>
{
public static readonly long[] Value=A200536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200536.Bytes);
public long this[int i]=>Value[i];

public static A200536Inst Instance=new A200536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200537
{
public static readonly long[] Value={ 1L,1L,9L,13L,40L,72L,144L,252L,432L,720L,1152L,1872L,2880L,4608L,6912L,10944L,16128L,25344L,36864L,57600L,82944L,129024L,184320L,285696L,405504L,626688L,884736L,1363968L,1916928L,2949120L,4128768L,6340608L,8847360L,13565952L,18874368L,28901376L,40108032L,61341696L,84934656L,129761280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200537Inst : IEnumerable<long>
{
public static readonly long[] Value=A200537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200537.Bytes);
public long this[int i]=>Value[i];

public static A200537Inst Instance=new A200537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200538
{
public static readonly long[] Value={ 1L,1L,6L,20L,99L,441L,2193L,10795L,55233L,284735L,1494404L,7914270L,42360541L,228460935L,1241224182L,6784445340L,37288826697L,205937705799L,1142317727466L,6361104740100L,35548154733969L,199295884785459L,1120615326442269L,6318077793648075L,35710056983891367L,202297486497822121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200538Inst : IEnumerable<long>
{
public static readonly long[] Value=A200538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200538.Bytes);
public long this[int i]=>Value[i];

public static A200538Inst Instance=new A200538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200539
{
public static readonly long[] Value={ 1L,1L,4L,12L,45L,168L,663L,2667L,10982L,45925L,194732L,834912L,3614063L,15771795L,69316740L,306534564L,1362986799L,6089916936L,27328613142L,123118156260L,556626199974L,2524659817449L,11484671681511L,52384730922720L,239534402969925L,1097805759803893L,5042014405418968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200539Inst : IEnumerable<long>
{
public static readonly long[] Value=A200539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200539.Bytes);
public long this[int i]=>Value[i];

public static A200539Inst Instance=new A200539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200540
{
public static readonly long[] Value={ 1L,2L,10L,48L,261L,1470L,8619L,51816L,318155L,1985630L,12561308L,80360280L,519013571L,3379514970L,22161470850L,146227235904L,970126550763L,6467496499590L,43304243215638L,291087137589552L,1963598081845335L,13288619577124122L,90195242361688863L,613843707553183800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200540Inst : IEnumerable<long>
{
public static readonly long[] Value=A200540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200540.Bytes);
public long this[int i]=>Value[i];

public static A200540Inst Instance=new A200540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200541
{
public static readonly long[] Value={ 1L,1L,4L,12L,35L,104L,312L,924L,2754L,8195L,24386L,72576L,215991L,642785L,1912960L,5693016L,16942573L,50421592L,150056090L,446571180L,1329008590L,3955167387L,11770690808L,35029911168L,104250013425L,310251009501L,923315841860L,2747814245904L,8177573467339L,24336691577000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200541Inst : IEnumerable<long>
{
public static readonly long[] Value=A200541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200541.Bytes);
public long this[int i]=>Value[i];

public static A200541Inst Instance=new A200541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200542
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,8L,17L,41L,113L,340L,1070L,3592L,12979L,50107L,204325L,875702L,3947560L,18724328L,93137201L,484066913L,2623523381L,14811843184L,87000588266L,530736806728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200542Inst : IEnumerable<long>
{
public static readonly long[] Value=A200542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200542.Bytes);
public long this[int i]=>Value[i];

public static A200542Inst Instance=new A200542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200543
{
public static readonly long[] Value={ 1L,1L,2L,12L,35L,117L,408L,1364L,4617L,15645L,52882L,178920L,605331L,2047705L,6927424L,23435384L,79281057L,268206185L,907335090L,3069491988L,10384017875L,35128880685L,118840150776L,402033352684L,1360069088841L,4601080767717L,15565344749410L,52657184101648L,178137977818211L,602636462317425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200543Inst : IEnumerable<long>
{
public static readonly long[] Value=A200543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200543.Bytes);
public long this[int i]=>Value[i];

public static A200543Inst Instance=new A200543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200544
{
public static readonly long[] Value={ 1L,1L,3L,6L,14L,28L,61L,122L,253L,505L,1017L,2008L,3976L,7769L,15169L,29379L,56751L,108993L,208725L,397913L,756385L,1432578L,2705744L,5094749L,9568504L,17922756L,33492061L,62438472L,116151352L,215612548L,399451325L,738612472L,1363261171L,2511748010L,4620024202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200544Inst : IEnumerable<long>
{
public static readonly long[] Value=A200544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200544.Bytes);
public long this[int i]=>Value[i];

public static A200544Inst Instance=new A200544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200545
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,4L,1L,0L,1L,13L,9L,1L,0L,1L,46L,56L,16L,1L,0L,1L,199L,334L,160L,25L,1L,0L,1L,1072L,2157L,1408L,365L,36L,1L,0L,1L,6985L,15701L,12445L,4417L,721L,49L,1L,0L,1L,53218L,129214L,116698L,50944L,11452L,1288L,64L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200545Inst : IEnumerable<long>
{
public static readonly long[] Value=A200545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200545.Bytes);
public long this[int i]=>Value[i];

public static A200545Inst Instance=new A200545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200546
{
public static readonly long[] Value={ 4L,14L,26L,72L,142L,362L,778L,1938L,4366L,10628L,24532L,59138L,138680L,333014L,788374L,1890870L,4503208L,10803262L,25831504L,62025512L,148725902L,357516682L,859055042L,2067463940L,4975921904L,11988835382L,28892947100L,69685951942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200546Inst : IEnumerable<long>
{
public static readonly long[] Value=A200546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200546.Bytes);
public long this[int i]=>Value[i];

public static A200546Inst Instance=new A200546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200547
{
public static readonly long[] Value={ 14L,76L,280L,1240L,4978L,21626L,91058L,393660L,1686980L,7309386L,31632968L,137600876L,599055566L,2615427970L,11433493630L,50075195034L,219589525108L,964264276780L,4238966033150L,18655002576606L,82175337524524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200547Inst : IEnumerable<long>
{
public static readonly long[] Value=A200547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200547.Bytes);
public long this[int i]=>Value[i];

public static A200547Inst Instance=new A200547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200548
{
public static readonly long[] Value={ 30L,200L,1184L,7254L,43698L,266812L,1639804L,10152636L,63132188L,394016210L,2466471522L,15481097890L,97396742734L,614019893832L,3878005568152L,24532092598782L,155413031752230L,985836563404470L,6260856742508844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200548Inst : IEnumerable<long>
{
public static readonly long[] Value=A200548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200548.Bytes);
public long this[int i]=>Value[i];

public static A200548Inst Instance=new A200548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200549
{
public static readonly long[] Value={ 52L,446L,3396L,26850L,211374L,1689732L,13587804L,109957140L,893510530L,7288331916L,59637096784L,489325754576L,4024444316206L,33167657580268L,273853057747366L,2264784856966600L,18757225819498566L,155553439876468586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200549Inst : IEnumerable<long>
{
public static readonly long[] Value=A200549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200549.Bytes);
public long this[int i]=>Value[i];

public static A200549Inst Instance=new A200549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200550
{
public static readonly long[] Value={ 80L,836L,7778L,75792L,737460L,7286542L,72366820L,723237026L,7258296910L,73127883596L,739101010202L,7490787201124L,76099633989974L,774719436417776L,7901415122713726L,80719023935569240L,825814487838111514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200550Inst : IEnumerable<long>
{
public static readonly long[] Value=A200550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200550.Bytes);
public long this[int i]=>Value[i];

public static A200550Inst Instance=new A200550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200551
{
public static readonly long[] Value={ 114L,1368L,15476L,178834L,2076774L,24378976L,288237528L,3427837106L,40950125796L,491063998130L,5907663402532L,71267752107030L,861806880210532L,10443265297671942L,126784115884242080L,1541722886174306634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200551Inst : IEnumerable<long>
{
public static readonly long[] Value=A200551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200551.Bytes);
public long this[int i]=>Value[i];

public static A200551Inst Instance=new A200551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200552
{
public static readonly long[] Value={ 154L,2134L,27806L,372150L,5012084L,68263780L,936121220L,12911643944L,178893425570L,2488110363432L,34717386812304L,485767803378730L,6813227225653584L,95761068651953630L,1348433104134460586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200552Inst : IEnumerable<long>
{
public static readonly long[] Value=A200552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200552.Bytes);
public long this[int i]=>Value[i];

public static A200552Inst Instance=new A200552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200553
{
public static readonly long[] Value={ 4L,14L,14L,30L,76L,26L,52L,200L,280L,72L,80L,446L,1184L,1240L,142L,114L,836L,3396L,7254L,4978L,362L,154L,1368L,7778L,26850L,43698L,21626L,778L,200L,2134L,15476L,75792L,211374L,266812L,91058L,1938L,252L,3140L,27806L,178834L,737460L,1689732L,1639804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200553Inst : IEnumerable<long>
{
public static readonly long[] Value=A200553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200553.Bytes);
public long this[int i]=>Value[i];

public static A200553Inst Instance=new A200553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200554
{
public static readonly long[] Value={ 14L,76L,200L,446L,836L,1368L,2134L,3140L,4368L,5942L,7852L,10064L,12734L,15836L,19320L,23374L,27956L,33000L,38726L,45076L,51968L,59654L,68060L,77088L,87022L,97772L,109224L,121694L,135076L,149240L,164534L,180836L,198000L,216406L,235916L,256368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200554Inst : IEnumerable<long>
{
public static readonly long[] Value=A200554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200554.Bytes);
public long this[int i]=>Value[i];

public static A200554Inst Instance=new A200554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200555
{
public static readonly long[] Value={ 26L,280L,1184L,3396L,7778L,15476L,27806L,46346L,72902L,109528L,158422L,222162L,303412L,405134L,530518L,683014L,866156L,1083954L,1340420L,1639900L,1986968L,2386470L,2843276L,3362828L,3950486L,4611980L,5353268L,6180592L,7100158L,8118840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200555Inst : IEnumerable<long>
{
public static readonly long[] Value=A200555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200555.Bytes);
public long this[int i]=>Value[i];

public static A200555Inst Instance=new A200555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200556
{
public static readonly long[] Value={ 72L,1240L,7254L,26850L,75792L,178834L,372150L,705270L,1242888L,2067650L,3281874L,5009232L,7397868L,10621792L,14882672L,20413220L,27478160L,36376230L,47443518L,61054528L,77624122L,97610834L,121518006L,149895400L,183343046L,222512226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200556Inst : IEnumerable<long>
{
public static readonly long[] Value=A200556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200556.Bytes);
public long this[int i]=>Value[i];

public static A200556Inst Instance=new A200556Inst();

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