using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A257162
{
public static readonly long[] Value={ 8L,12L,18L,13L,21L,15L,16L,18L,21L,18L,13L,27L,20L,18L,19L,26L,22L,19L,30L,21L,22L,25L,31L,25L,20L,34L,23L,31L,21L,35L,24L,33L,28L,30L,30L,32L,34L,27L,33L,28L,35L,33L,38L,30L,31L,32L,37L,30L,34L,39L,42L,35L,32L,31L,39L,33L,40L,38L,41L,36L,41L,36L,37L,32L,41L,43L,34L,42L,43L,42L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257162Inst : IEnumerable<long>
{
public static readonly long[] Value=A257162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257162.Bytes);
public long this[int i]=>Value[i];

public static A257162Inst Instance=new A257162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257163
{
public static readonly long[] Value={ 2L,5L,29L,149L,509L,677L,1877L,3677L,8429L,9749L,11909L,13469L,17789L,22709L,27077L,28229L,45389L,46877L,53069L,70229L,72077L,81677L,100469L,102677L,114077L,128549L,141269L,154589L,180077L,192029L,195077L,207509L,223589L,230189L,261077L,312989L,340709L,352949L,395309L,399677L,426389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257163Inst : IEnumerable<long>
{
public static readonly long[] Value=A257163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257163.Bytes);
public long this[int i]=>Value[i];

public static A257163Inst Instance=new A257163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257164
{
public static readonly long[] Value={ 0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257164Inst : IEnumerable<long>
{
public static readonly long[] Value=A257164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257164.Bytes);
public long this[int i]=>Value[i];

public static A257164Inst Instance=new A257164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257165
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,22L,44L,88L,176L,183L,186L,204L,224L,248L,296L,305L,310L,320L,352L,387L,425L,450L,495L,544L,598L,657L,714L,728L,756L,812L,824L,906L,996L,1092L,1184L,1195L,1214L,1235L,1258L,1316L,1329L,1358L,1493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257165Inst : IEnumerable<long>
{
public static readonly long[] Value=A257165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257165.Bytes);
public long this[int i]=>Value[i];

public static A257165Inst Instance=new A257165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257166
{
public static readonly ulong[] Value={ 11L,21817283854511261L,79287805466244209L,841262446570150721L,1006587882969594041L,2682372491413700201L,2714623996387988519L,5009128141636113611L,5012524663381750349L,6120794469172998449L,6195991854028811669L,6232932509314786109L,6808488664768715759L,7126352574372296381L,7993822923596334941L,10756418345074847279UL,11319107721272355839UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257166Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A257166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257166.Bytes);
public ulong this[int i]=>Value[i];

public static A257166Inst Instance=new A257166Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257167
{
public static readonly BigInteger[] Value={ 11L,21817283854511261L,841262446570150721L,1006587882969594041L,2682372491413700201L,5009128141636113611L,7126352574372296381L,7993822923596334941L,12870536149631655611UL,15762479629138737611UL,BigInteger.Parse("22811391659969177381"),BigInteger.Parse("25593071201116914611"),BigInteger.Parse("25908823282383706781"),BigInteger.Parse("42408988436795325461"),BigInteger.Parse("44360646117391789301"),BigInteger.Parse("54533311498517797061"),BigInteger.Parse("54872625531142644341"),BigInteger.Parse("55603189618237916771"),BigInteger.Parse("60815831883653681951") };
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
public class A257167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257167Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257167.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257167.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257167Inst Instance=new A257167Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257168
{
public static readonly BigInteger[] Value={ 79287805466244209L,2714623996387988519L,5012524663381750349L,6120794469172998449L,6195991854028811669L,6232932509314786109L,6808488664768715759L,10756418345074847279UL,11319107721272355839UL,12635619305675250719UL,14028155447337025829UL,14094050870111867489UL,14603617704434643719UL,14777669568340323479UL,15420967329931107779UL,16222575536498135639UL,16624441191356313149UL,17367037621075657349UL,BigInteger.Parse("19289576760019250519") };
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
public class A257168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257168Inst Instance=new A257168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257169
{
public static readonly BigInteger[] Value={ 11L,17L,1158722981124148367L,1240068005144831867L,2243290806352501637L,3172206835341609797L,8402171449067476007L,9422138120166964847UL,14094050870111867483UL,16222575536498135633UL,16485850001899818467UL,16679857156627718057UL,17905159760365247387UL,BigInteger.Parse("26082001869529405727"),BigInteger.Parse("27367669288651556693"),BigInteger.Parse("28025081332808782877"),BigInteger.Parse("30304192466683200797"),BigInteger.Parse("34827058725936837287"),BigInteger.Parse("36351118555624575707"),BigInteger.Parse("44333554877816671757") };
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
public class A257169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257169Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257169.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257169.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257169Inst Instance=new A257169Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257170
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257170Inst : IEnumerable<long>
{
public static readonly long[] Value=A257170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257170.Bytes);
public long this[int i]=>Value[i];

public static A257170Inst Instance=new A257170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257171
{
public static readonly long[] Value={ 1L,5L,9L,13L,27L,36L,62L,78L,120L,145L,207L,243L,329L,378L,492L,556L,702L,783L,965L,1065L,1287L,1408L,1674L,1818L,2132L,2301L,2667L,2863L,3285L,3510L,3992L,4248L,4794L,5083L,5697L,6021L,6707L,7068L,7830L,8230L,9072L,9513L,10439L,10923L,11937L,12466L,13572L,14148L,15350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257171Inst : IEnumerable<long>
{
public static readonly long[] Value=A257171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257171.Bytes);
public long this[int i]=>Value[i];

public static A257171Inst Instance=new A257171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257172
{
public static readonly long[] Value={ 11424L,13248L,14112L,16128L,16632L,17136L,18144L,41328L,91728L,101112L,102144L,102816L,104832L,106272L,111012L,111375L,112288L,112896L,114048L,114240L,114912L,116160L,116928L,123120L,132480L,140112L,141120L,161280L,166320L,171171L,171360L,181440L,203112L,204288L,204336L,220416L,231012L,233772L,239616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257172Inst : IEnumerable<long>
{
public static readonly long[] Value=A257172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257172.Bytes);
public long this[int i]=>Value[i];

public static A257172Inst Instance=new A257172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257173
{
public static readonly long[] Value={ 0L,1L,2L,3L,69L,5L,9L,7L,40L,171L,365L,11L,805L,13L,217L,49L,637L,17L,1519L,19L,671L,125L,403L,23L,143L,2891L,1199L,1351L,917L,29L,559L,31L,799L,1099L,323L,14443L,949L,37L,803L,5027L,679L,41L,2167L,43L,1837L,6253L,341L,47L,253L,2327L,169L,4697L,2021L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257173Inst : IEnumerable<long>
{
public static readonly long[] Value=A257173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257173.Bytes);
public long this[int i]=>Value[i];

public static A257173Inst Instance=new A257173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257174
{
public static readonly long[] Value={ 1L,1L,2L,4L,4L,5L,8L,7L,8L,12L,10L,11L,16L,13L,14L,20L,16L,17L,24L,19L,20L,28L,22L,23L,32L,25L,26L,36L,28L,29L,40L,31L,32L,44L,34L,35L,48L,37L,38L,52L,40L,41L,56L,43L,44L,60L,46L,47L,64L,49L,50L,68L,52L,53L,72L,55L,56L,76L,58L,59L,80L,61L,62L,84L,64L,65L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257174Inst : IEnumerable<long>
{
public static readonly long[] Value=A257174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257174.Bytes);
public long this[int i]=>Value[i];

public static A257174Inst Instance=new A257174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257175
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,5L,5L,6L,7L,7L,8L,9L,10L,10L,11L,12L,12L,13L,14L,14L,15L,16L,17L,17L,18L,19L,19L,20L,21L,22L,22L,23L,24L,24L,25L,26L,27L,27L,28L,29L,29L,30L,31L,31L,32L,33L,34L,34L,35L,36L,36L,37L,38L,39L,39L,40L,41L,41L,42L,43L,43L,44L,45L,46L,46L,47L,48L,48L,49L,50L,51L,51L,52L,53L,53L,54L,55L,56L,56L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257175Inst : IEnumerable<long>
{
public static readonly long[] Value=A257175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257175.Bytes);
public long this[int i]=>Value[i];

public static A257175Inst Instance=new A257175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257176
{
public static readonly long[] Value={ 1L,1L,9L,9L,0L,5L,8L,7L,1L,0L,0L,0L,2L,8L,2L,3L,6L,2L,9L,7L,1L,9L,3L,2L,9L,4L,3L,0L,9L,6L,6L,2L,5L,8L,3L,0L,5L,2L,2L,2L,9L,0L,6L,5L,1L,6L,7L,7L,0L,9L,5L,8L,5L,2L,0L,0L,2L,2L,2L,4L,3L,4L,6L,2L,2L,4L,3L,6L,8L,6L,9L,8L,3L,7L,6L,3L,0L,4L,3L,0L,9L,0L,2L,0L,0L,4L,9L,4L,4L,0L,0L,9L,7L,2L,1L,1L,8L,7L,7L,4L,5L,4L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257176Inst : IEnumerable<long>
{
public static readonly long[] Value=A257176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257176.Bytes);
public long this[int i]=>Value[i];

public static A257176Inst Instance=new A257176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257177
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,2L,2L,3L,3L,2L,3L,3L,3L,4L,4L,4L,4L,4L,4L,6L,5L,5L,6L,6L,6L,7L,5L,7L,5L,7L,5L,10L,6L,8L,8L,9L,6L,11L,5L,11L,7L,11L,7L,13L,7L,13L,9L,13L,9L,15L,7L,16L,8L,15L,8L,17L,7L,16L,10L,17L,9L,20L,8L,21L,11L,20L,8L,21L,7L,22L,11L,22L,11L,23L,10L,28L,12L,24L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257177Inst : IEnumerable<long>
{
public static readonly long[] Value=A257177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257177.Bytes);
public long this[int i]=>Value[i];

public static A257177Inst Instance=new A257177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257178
{
public static readonly long[] Value={ 1L,3L,10L,33L,110L,369L,1247L,4245L,14558L,50295L,175029L,613467L,2165100L,7692345L,27504600L,98941185L,357952580L,1301960925L,4759282415L,17478557925L,64468072820L,238736987535L,887359113700L,3309489922743L,12381998910700L,46460457776739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257178Inst : IEnumerable<long>
{
public static readonly long[] Value=A257178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257178.Bytes);
public long this[int i]=>Value[i];

public static A257178Inst Instance=new A257178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257179
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257179Inst : IEnumerable<long>
{
public static readonly long[] Value=A257179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257179.Bytes);
public long this[int i]=>Value[i];

public static A257179Inst Instance=new A257179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257180
{
public static readonly long[] Value={ 1L,3L,3L,9L,24L,9L,27L,141L,141L,27L,81L,726L,1410L,726L,81L,243L,3471L,11406L,11406L,3471L,243L,729L,15828L,81327L,136872L,81327L,15828L,729L,2187L,69873L,533259L,1390521L,1390521L,533259L,69873L,2187L,6561L,301362L,3295152L,12609198L,19467294L,12609198L,3295152L,301362L,6561L,19683L,1277619L,19489380L,105311556L,237144642L,237144642L,105311556L,19489380L,1277619L,19683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257180Inst : IEnumerable<long>
{
public static readonly long[] Value=A257180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257180.Bytes);
public long this[int i]=>Value[i];

public static A257180Inst Instance=new A257180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257181
{
public static readonly long[] Value={ 1L,-1L,0L,0L,1L,-2L,1L,0L,0L,-1L,2L,-1L,0L,0L,1L,-2L,1L,0L,0L,-1L,2L,-1L,0L,0L,1L,-2L,1L,0L,0L,-1L,2L,-1L,0L,0L,1L,-2L,1L,0L,0L,-1L,2L,-1L,0L,0L,1L,-2L,1L,0L,0L,-1L,2L,-1L,0L,0L,1L,-2L,1L,0L,0L,-1L,2L,-1L,0L,0L,1L,-2L,1L,0L,0L,-1L,2L,-1L,0L,0L,1L,-2L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257181Inst : IEnumerable<long>
{
public static readonly long[] Value=A257181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257181.Bytes);
public long this[int i]=>Value[i];

public static A257181Inst Instance=new A257181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257182
{
public static readonly BigInteger[] Value={ 512L,10925L,252288L,12941212L,1168362160L,209357338632L,70497822050321L,41481946444109537L,BigInteger.Parse("45886972050838654878"),BigInteger.Parse("93050783565680083134452") };
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
public class A257182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257182Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257182.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257182.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257182Inst Instance=new A257182Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257183
{
public static readonly long[] Value={ 2642L,10925L,44795L,213631L,991554L,4507765L,20935219L,97650228L,454044178L,2115208441L,9867664386L,46031851480L,214761098143L,1002223496523L,4677320684206L,21829236904579L,101881854293960L,475514395215723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257183Inst : IEnumerable<long>
{
public static readonly long[] Value=A257183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257183.Bytes);
public long this[int i]=>Value[i];

public static A257183Inst Instance=new A257183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257184
{
public static readonly long[] Value={ 10285L,47283L,252288L,1661786L,10392884L,65770496L,429271992L,2786976155L,18041157691L,117100335307L,760568125579L,4936527355840L,32044309312991L,208026009487640L,1350418789751718L,8766267486325198L,56907414061910205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257184Inst : IEnumerable<long>
{
public static readonly long[] Value=A257184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257184.Bytes);
public long this[int i]=>Value[i];

public static A257184Inst Instance=new A257184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257185
{
public static readonly long[] Value={ 39891L,220126L,1488364L,12941212L,108242033L,895883809L,7678171235L,65710359362L,559193489019L,4764744316836L,40680177824834L,346959411145637L,2959165274950812L,25242372423278445L,215334362798793752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257185Inst : IEnumerable<long>
{
public static readonly long[] Value=A257185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257185.Bytes);
public long this[int i]=>Value[i];

public static A257185Inst Instance=new A257185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257186
{
public static readonly long[] Value={ 160753L,1006996L,9058784L,106574293L,1168362160L,13043226591L,151536930267L,1739514241158L,19843845673139L,227784306114123L,2617237904397733L,30018737831768900L,344399600382753170L,3952623075920272502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257186Inst : IEnumerable<long>
{
public static readonly long[] Value=A257186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257186.Bytes);
public long this[int i]=>Value[i];

public static A257186Inst Instance=new A257186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257187
{
public static readonly BigInteger[] Value={ 639228L,4613955L,57766489L,916707473L,13584142368L,209357338632L,3329338589296L,52183619444529L,815552990856702L,12820383787282287L,201368323746925262L,3158998987149180769L,BigInteger.Parse("49589358799802401415") };
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
public class A257187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257187Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257187.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257187.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257187Inst Instance=new A257187Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257188
{
public static readonly BigInteger[] Value={ 2462249L,21367247L,375658160L,7875023930L,156549880736L,3282787941884L,70497822050321L,1484414256002804L,31272262583077260L,662554668191631490L,14020929804464669108UL,BigInteger.Parse("296312633506422966743"),BigInteger.Parse("6267103481316509058453") };
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
public class A257188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257188Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257188.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257188.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257188Inst Instance=new A257188Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257189
{
public static readonly long[] Value={ 512L,2642L,2642L,10285L,10925L,10285L,39891L,47283L,44795L,39891L,160753L,220126L,252288L,213631L,160753L,639228L,1006996L,1488364L,1661786L,991554L,639228L,2462249L,4613955L,9058784L,12941212L,10392884L,4507765L,2462249L,9299264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257189Inst : IEnumerable<long>
{
public static readonly long[] Value=A257189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257189.Bytes);
public long this[int i]=>Value[i];

public static A257189Inst Instance=new A257189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257190
{
public static readonly long[] Value={ 2642L,10925L,47283L,220126L,1006996L,4613955L,21367247L,98911734L,458586500L,2132449553L,9926655163L,46235660410L,215513433328L,1005039527604L,4688140595267L,21872823325681L,102063694534105L,476294012358476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257190Inst : IEnumerable<long>
{
public static readonly long[] Value=A257190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257190.Bytes);
public long this[int i]=>Value[i];

public static A257190Inst Instance=new A257190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257191
{
public static readonly long[] Value={ 10285L,44795L,252288L,1488364L,9058784L,57766489L,375658160L,2426787341L,15738821146L,102176453195L,663395152836L,4305719804877L,27954130368606L,181465502045290L,1177998713851415L,7647065573314904L,49642206284249539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257191Inst : IEnumerable<long>
{
public static readonly long[] Value=A257191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257191.Bytes);
public long this[int i]=>Value[i];

public static A257191Inst Instance=new A257191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257192
{
public static readonly long[] Value={ 39891L,213631L,1661786L,12941212L,106574293L,916707473L,7875023930L,66916972975L,571865228504L,4885833171477L,41691336304950L,355572944704403L,3034273391475241L,25884761299109748L,220809323036102848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257192Inst : IEnumerable<long>
{
public static readonly long[] Value=A257192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257192.Bytes);
public long this[int i]=>Value[i];

public static A257192Inst Instance=new A257192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257193
{
public static readonly long[] Value={ 160753L,991554L,10392884L,108242033L,1168362160L,13584142368L,156549880736L,1779543980862L,20405105172142L,234422838382574L,2686793441343813L,30815331682566435L,353690053644762846L,4058061915828133288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257193Inst : IEnumerable<long>
{
public static readonly long[] Value=A257193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257193.Bytes);
public long this[int i]=>Value[i];

public static A257193Inst Instance=new A257193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257194
{
public static readonly BigInteger[] Value={ 639228L,4507765L,65770496L,895883809L,13043226591L,209357338632L,3282787941884L,50799369634289L,798667497496483L,12559203813701135L,196742803596018870L,3086984411546130737L,BigInteger.Parse("48479953018885963308") };
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
public class A257194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257194.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257194Inst Instance=new A257194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257195
{
public static readonly BigInteger[] Value={ 2462249L,20935219L,429271992L,7678171235L,151536930267L,3329338589296L,70497822050321L,1467756615413259L,31190829869276947L,661352216555533870L,13957178036658753029UL,BigInteger.Parse("295133876120095539441"),BigInteger.Parse("6247002726722796889697") };
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
public class A257195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257195Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257195.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257195.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257195Inst Instance=new A257195Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257196
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257196Inst : IEnumerable<long>
{
public static readonly long[] Value=A257196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257196.Bytes);
public long this[int i]=>Value[i];

public static A257196Inst Instance=new A257196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257197
{
public static readonly long[] Value={ 116L,146L,1116L,1146L,1156L,1246L,1465L,1556L,1616L,3516L,3621L,4611L,4621L,4631L,11116L,11146L,11156L,11465L,11556L,11642L,15216L,16231L,21556L,22631L,25146L,25162L,25621L,33516L,34156L,35116L,35146L,35162L,36211L,36215L,36512L,46111L,46112L,46211L,46331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257197Inst : IEnumerable<long>
{
public static readonly long[] Value=A257197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257197.Bytes);
public long this[int i]=>Value[i];

public static A257197Inst Instance=new A257197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257198
{
public static readonly long[] Value={ 0L,0L,2L,6L,16L,36L,78L,162L,332L,672L,1354L,2718L,5448L,10908L,21830L,43674L,87364L,174744L,349506L,699030L,1398080L,2796180L,5592382L,11184786L,22369596L,44739216L,89478458L,178956942L,357913912L,715827852L,1431655734L,2863311498L,5726623028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257198Inst : IEnumerable<long>
{
public static readonly long[] Value=A257198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257198.Bytes);
public long this[int i]=>Value[i];

public static A257198Inst Instance=new A257198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257199
{
public static readonly long[] Value={ 1L,5L,16L,41L,91L,182L,336L,582L,957L,1507L,2288L,3367L,4823L,6748L,9248L,12444L,16473L,21489L,27664L,35189L,44275L,55154L,68080L,83330L,101205L,122031L,146160L,173971L,205871L,242296L,283712L,330616L,383537L,443037L,509712L,584193L,667147L,759278L,861328L,974078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257199Inst : IEnumerable<long>
{
public static readonly long[] Value=A257199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257199.Bytes);
public long this[int i]=>Value[i];

public static A257199Inst Instance=new A257199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257200
{
public static readonly long[] Value={ 1L,6L,22L,63L,154L,336L,672L,1254L,2211L,3718L,6006L,9373L,14196L,20944L,30192L,42636L,59109L,80598L,108262L,143451L,187726L,242880L,310960L,394290L,495495L,617526L,763686L,937657L,1143528L,1385824L,1669536L,2000152L,2383689L,2826726L,3336438L,3920631L,4587778L,5347056L,6208384L,7182462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257200Inst : IEnumerable<long>
{
public static readonly long[] Value=A257200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257200.Bytes);
public long this[int i]=>Value[i];

public static A257200Inst Instance=new A257200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257201
{
public static readonly long[] Value={ 1L,7L,29L,92L,246L,582L,1254L,2508L,4719L,8437L,14443L,23816L,38012L,58956L,89148L,131784L,190893L,271491L,379753L,523204L,710930L,953810L,1264770L,1659060L,2154555L,2772081L,3535767L,4473424L,5616952L,7002776L,8672312L,10672464L,13056153L,15882879L,19219317L,23139948L,27727726L,33074782L,39283166L,46465628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257201Inst : IEnumerable<long>
{
public static readonly long[] Value=A257201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257201.Bytes);
public long this[int i]=>Value[i];

public static A257201Inst Instance=new A257201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257202
{
public static readonly long[] Value={ 512L,7800L,49932L,387056L,654637L,516615L,848628L,1271947L,1749293L,2675122L,3991360L,5698952L,8019568L,11234476L,15595519L,21319231L,28669112L,38015446L,50100115L,65102076L,83309215L,106038988L,134027052L,167393397L,207962738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257202Inst : IEnumerable<long>
{
public static readonly long[] Value=A257202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257202.Bytes);
public long this[int i]=>Value[i];

public static A257202Inst Instance=new A257202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257203
{
public static readonly long[] Value={ 2423L,7800L,20815L,67606L,191070L,443711L,992467L,2153497L,4441745L,8865989L,17513940L,33716004L,63122416L,116916487L,215061906L,390592396L,702133715L,1252287829L,2218180477L,3907760319L,6851939815L,11959426756L,20788960871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257203Inst : IEnumerable<long>
{
public static readonly long[] Value=A257203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257203.Bytes);
public long this[int i]=>Value[i];

public static A257203Inst Instance=new A257203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257204
{
public static readonly long[] Value={ 7579L,20815L,49932L,146246L,263630L,411303L,729311L,1137502L,1610329L,2274915L,3169472L,4338292L,5813318L,7747950L,10182266L,13271860L,17219400L,22080758L,28263063L,36156579L,45961370L,58304592L,74030044L,94195258L,120080310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257204Inst : IEnumerable<long>
{
public static readonly long[] Value=A257204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257204.Bytes);
public long this[int i]=>Value[i];

public static A257204Inst Instance=new A257204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257205
{
public static readonly long[] Value={ 22901L,67606L,146246L,387056L,594621L,753005L,1140763L,1355370L,1545878L,1893932L,2274326L,2671736L,3131186L,3765721L,4535616L,5400586L,6434782L,7609215L,9000962L,10630903L,12482102L,14595592L,17066214L,19940731L,23221571L,26931763L,31251495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257205Inst : IEnumerable<long>
{
public static readonly long[] Value=A257205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257205.Bytes);
public long this[int i]=>Value[i];

public static A257205Inst Instance=new A257205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257206
{
public static readonly long[] Value={ 72249L,191070L,263630L,594621L,654637L,640929L,958492L,1132789L,1248657L,1572262L,1941929L,2373418L,2905927L,3560325L,4385532L,5356772L,6499076L,7803937L,9358455L,11231036L,13326754L,15731695L,18564935L,21844896L,25557915L,29764072L,34644954L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257206Inst : IEnumerable<long>
{
public static readonly long[] Value=A257206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257206.Bytes);
public long this[int i]=>Value[i];

public static A257206Inst Instance=new A257206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257207
{
public static readonly long[] Value={ 219706L,443711L,411303L,753005L,640929L,516615L,675943L,769789L,876597L,1089188L,1305183L,1551382L,1851722L,2195415L,2590158L,3029318L,3516086L,4063777L,4672716L,5347330L,6075568L,6871137L,7747708L,8708189L,9740806L,10853545L,12070515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257207Inst : IEnumerable<long>
{
public static readonly long[] Value=A257207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257207.Bytes);
public long this[int i]=>Value[i];

public static A257207Inst Instance=new A257207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257208
{
public static readonly long[] Value={ 616608L,992467L,729311L,1140763L,958492L,675943L,848628L,1025500L,1197017L,1484651L,1806573L,2155273L,2551405L,3016791L,3558516L,4160683L,4814887L,5553807L,6369827L,7256231L,8227854L,9283499L,10430813L,11681467L,13036214L,14490345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257208Inst : IEnumerable<long>
{
public static readonly long[] Value=A257208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257208.Bytes);
public long this[int i]=>Value[i];

public static A257208Inst Instance=new A257208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257209
{
public static readonly long[] Value={ 512L,2423L,2423L,7579L,7800L,7579L,22901L,20815L,20815L,22901L,72249L,67606L,49932L,67606L,72249L,219706L,191070L,146246L,146246L,191070L,219706L,616608L,443711L,263630L,387056L,263630L,443711L,616608L,1656147L,992467L,411303L,594621L,594621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257209Inst : IEnumerable<long>
{
public static readonly long[] Value=A257209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257209.Bytes);
public long this[int i]=>Value[i];

public static A257209Inst Instance=new A257209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257210
{
public static readonly long[] Value={ 271L,371L,1171L,1474L,1475L,1776L,2171L,2271L,2671L,2715L,2761L,3671L,3711L,4174L,4761L,4771L,6761L,7165L,7174L,7261L,7331L,11275L,11474L,11475L,11711L,11715L,11716L,11724L,11725L,11731L,12376L,12715L,12734L,12756L,12776L,13171L,13174L,13275L,13276L,14674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257210Inst : IEnumerable<long>
{
public static readonly long[] Value=A257210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257210.Bytes);
public long this[int i]=>Value[i];

public static A257210Inst Instance=new A257210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257211
{
public static readonly long[] Value={ 128L,178L,871L,1128L,1178L,1218L,1258L,1278L,1284L,1328L,1358L,1368L,1478L,1678L,1681L,1768L,1778L,1784L,1785L,1828L,1874L,1881L,2681L,2861L,2871L,3418L,3581L,3718L,3816L,3841L,4178L,4318L,4815L,4831L,4841L,4881L,5178L,5181L,5182L,5318L,5815L,5841L,5871L,5881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257211Inst : IEnumerable<long>
{
public static readonly long[] Value=A257211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257211.Bytes);
public long this[int i]=>Value[i];

public static A257211Inst Instance=new A257211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257212
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,2L,3L,2L,3L,3L,3L,3L,3L,4L,3L,3L,4L,4L,3L,4L,4L,4L,5L,4L,4L,4L,5L,5L,4L,4L,5L,5L,5L,4L,5L,5L,5L,5L,6L,6L,5L,5L,5L,6L,6L,6L,5L,5L,6L,6L,6L,6L,5L,7L,6L,6L,6L,6L,7L,7L,7L,6L,6L,6L,7L,7L,7L,7L,6L,6L,7L,7L,7L,7L,7L,6L,8L,8L,7L,7L,7L,7L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257212Inst : IEnumerable<long>
{
public static readonly long[] Value=A257212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257212.Bytes);
public long this[int i]=>Value[i];

public static A257212Inst Instance=new A257212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257213
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,3L,4L,4L,3L,5L,4L,4L,5L,5L,5L,4L,6L,6L,5L,5L,7L,6L,6L,6L,5L,7L,7L,7L,6L,6L,8L,8L,7L,7L,7L,6L,8L,8L,8L,8L,7L,7L,9L,9L,9L,8L,8L,8L,7L,10L,9L,9L,9L,9L,8L,8L,10L,10L,10L,10L,9L,9L,9L,8L,11L,11L,10L,10L,10L,10L,9L,9L,11L,11L,11L,11L,11L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257213Inst : IEnumerable<long>
{
public static readonly long[] Value=A257213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257213.Bytes);
public long this[int i]=>Value[i];

public static A257213Inst Instance=new A257213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257214
{
public static readonly BigInteger[] Value={ 1L,0L,5L,24L,337L,3280L,46501L,811496L,15270977L,318449952L,7554700261L,194401167928L,5484157128913L,167431552506608L,5496127228989125L,193614639911456520L,7265814918674507521L,BigInteger.Parse("289758831638674507840"),BigInteger.Parse("12237733598089127162437"),BigInteger.Parse("545392221565792906192472"),BigInteger.Parse("25589486575413268343127761"),BigInteger.Parse("1260584085915542118144276240") };
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
public class A257214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257214Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257214.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257214.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257214Inst Instance=new A257214Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257215
{
public static readonly BigInteger[] Value={ 1L,8L,37L,304L,4081L,51384L,837733L,15583712L,324393985L,7669671400L,195589720261L,5509114219536L,168051665376817L,5506719600441752L,193872344999763781L,7271477485665147328L,BigInteger.Parse("289936454250117720193"),BigInteger.Parse("12242148798010459653576"),BigInteger.Parse("545520427163375125201381"),BigInteger.Parse("25593712286164576808576240") };
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
public class A257215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257215Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257215.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257215.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257215Inst Instance=new A257215Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257216
{
public static readonly BigInteger[] Value={ 1L,1L,13L,61L,641L,7361L,97885L,1649229L,30854689L,642843937L,15224371661L,389990888189L,10993271348449L,335483217883425L,11002846829430877L,387486984911220301L,14537292404339654849UL,BigInteger.Parse("579695285888792228033"),BigInteger.Parse("24479882396099586816013"),BigInteger.Parse("1090912648729168031393853"),BigInteger.Parse("51183198861577845151704001") };
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
public class A257216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257216Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257216.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257216.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257216Inst Instance=new A257216Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257217
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,0L,1L,1L,0L,2L,0L,0L,1L,1L,1L,0L,2L,1L,0L,0L,2L,1L,1L,1L,0L,2L,1L,1L,0L,0L,2L,2L,1L,1L,1L,0L,2L,1L,1L,1L,0L,0L,2L,2L,2L,1L,1L,1L,0L,3L,1L,1L,1L,1L,0L,0L,2L,2L,2L,2L,1L,1L,1L,0L,3L,2L,1L,1L,1L,1L,0L,0L,2L,2L,2L,2L,2L,1L,1L,1L,0L,3L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257217Inst : IEnumerable<long>
{
public static readonly long[] Value=A257217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257217.Bytes);
public long this[int i]=>Value[i];

public static A257217Inst Instance=new A257217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257218
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,8L,10L,5L,15L,9L,18L,12L,16L,24L,30L,20L,40L,32L,48L,36L,27L,54L,72L,60L,45L,75L,25L,50L,70L,7L,14L,28L,42L,21L,63L,126L,84L,56L,112L,64L,96L,120L,80L,100L,150L,90L,108L,81L,162L,216L,144L,168L,140L,35L,105L,210L,180L,135L,225L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257218Inst : IEnumerable<long>
{
public static readonly long[] Value=A257218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257218.Bytes);
public long this[int i]=>Value[i];

public static A257218Inst Instance=new A257218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257219
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,32L,34L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,63L,64L,66L,68L,69L,70L,72L,74L,75L,76L,78L,80L,81L,82L,84L,86L,87L,88L,90L,92L,94L,96L,98L,100L,102L,104L,105L,106L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257219Inst : IEnumerable<long>
{
public static readonly long[] Value=A257219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257219.Bytes);
public long this[int i]=>Value[i];

public static A257219Inst Instance=new A257219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257220
{
public static readonly long[] Value={ 3L,6L,9L,12L,13L,15L,18L,21L,23L,24L,26L,27L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,42L,43L,45L,46L,48L,51L,52L,53L,54L,57L,60L,62L,63L,64L,65L,66L,68L,69L,70L,72L,73L,74L,75L,76L,78L,81L,83L,84L,86L,87L,90L,91L,92L,93L,96L,99L,102L,103L,104L,105L,106L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257220Inst : IEnumerable<long>
{
public static readonly long[] Value=A257220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257220.Bytes);
public long this[int i]=>Value[i];

public static A257220Inst Instance=new A257220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257221
{
public static readonly long[] Value={ 4L,8L,12L,14L,16L,20L,24L,28L,32L,34L,36L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,52L,54L,56L,60L,64L,68L,70L,72L,74L,76L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,108L,112L,114L,116L,120L,123L,124L,126L,128L,129L,132L,134L,135L,136L,138L,140L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257221Inst : IEnumerable<long>
{
public static readonly long[] Value=A257221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257221.Bytes);
public long this[int i]=>Value[i];

public static A257221Inst Instance=new A257221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257222
{
public static readonly long[] Value={ 5L,10L,15L,20L,25L,30L,35L,40L,45L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,65L,70L,75L,80L,85L,90L,95L,100L,102L,104L,105L,106L,108L,110L,112L,114L,115L,116L,118L,120L,125L,130L,135L,140L,145L,150L,151L,152L,153L,154L,155L,156L,157L,158L,159L,160L,162L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257222Inst : IEnumerable<long>
{
public static readonly long[] Value=A257222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257222.Bytes);
public long this[int i]=>Value[i];

public static A257222Inst Instance=new A257222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257223
{
public static readonly long[] Value={ 6L,12L,16L,18L,24L,26L,30L,32L,36L,42L,46L,48L,52L,54L,56L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,72L,76L,78L,80L,84L,86L,90L,92L,96L,102L,104L,106L,108L,112L,114L,116L,120L,122L,124L,126L,128L,130L,132L,134L,136L,138L,144L,146L,150L,152L,156L,160L,161L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257223Inst : IEnumerable<long>
{
public static readonly long[] Value=A257223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257223.Bytes);
public long this[int i]=>Value[i];

public static A257223Inst Instance=new A257223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257224
{
public static readonly long[] Value={ 7L,14L,17L,21L,27L,28L,34L,35L,37L,42L,47L,49L,51L,54L,56L,57L,63L,67L,68L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,81L,84L,85L,87L,91L,94L,97L,98L,102L,105L,107L,108L,111L,112L,114L,117L,119L,126L,127L,133L,134L,135L,136L,137L,140L,141L,142L,144L,146L,147L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257224Inst : IEnumerable<long>
{
public static readonly long[] Value=A257224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257224.Bytes);
public long this[int i]=>Value[i];

public static A257224Inst Instance=new A257224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257225
{
public static readonly long[] Value={ 8L,16L,18L,24L,28L,32L,36L,38L,40L,48L,54L,56L,58L,64L,68L,72L,76L,78L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,96L,98L,104L,108L,112L,114L,116L,118L,120L,126L,128L,136L,138L,140L,144L,148L,152L,156L,158L,160L,162L,164L,166L,168L,170L,172L,174L,176L,178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257225Inst : IEnumerable<long>
{
public static readonly long[] Value=A257225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257225.Bytes);
public long this[int i]=>Value[i];

public static A257225Inst Instance=new A257225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257226
{
public static readonly long[] Value={ 9L,18L,19L,27L,29L,36L,38L,39L,45L,49L,54L,57L,58L,59L,63L,69L,72L,76L,78L,79L,81L,87L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,108L,109L,114L,116L,117L,118L,119L,126L,129L,133L,135L,138L,139L,144L,145L,147L,149L,152L,153L,156L,158L,159L,162L,169L,171L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257226Inst : IEnumerable<long>
{
public static readonly long[] Value=A257226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257226.Bytes);
public long this[int i]=>Value[i];

public static A257226Inst Instance=new A257226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257227
{
public static readonly long[] Value={ 11L,361L,373L,2440L,14002L,68990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257227Inst : IEnumerable<long>
{
public static readonly long[] Value=A257227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257227.Bytes);
public long this[int i]=>Value[i];

public static A257227Inst Instance=new A257227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257228
{
public static readonly BigInteger[] Value={ 2L,BigInteger.Parse("3876345660966505581780035851822613413637045687942554538584103751904155528656612320450718024564637501177857"),BigInteger.Parse("15784273697726525594915158437704910106795669967932151790483411869827615323130147795459165734845011296559523773") };
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
public class A257228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257228Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257228.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257228.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257228Inst Instance=new A257228Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257229
{
public static readonly long[] Value={ -1L,0L,1L,2L,7625597484987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257229Inst : IEnumerable<long>
{
public static readonly long[] Value=A257229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257229.Bytes);
public long this[int i]=>Value[i];

public static A257229Inst Instance=new A257229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257230
{
public static readonly long[] Value={ 0L,0L,0L,-1L,1L,0L,2L,0L,-1L,3L,0L,2L,4L,2L,1L,1L,5L,2L,4L,6L,2L,5L,3L,1L,6L,8L,6L,8L,6L,-3L,7L,5L,9L,2L,10L,6L,6L,8L,7L,7L,11L,3L,11L,10L,12L,2L,2L,11L,13L,11L,9L,13L,5L,10L,10L,10L,14L,10L,12L,14L,7L,3L,13L,15L,13L,4L,12L,8L,16L,14L,12L,11L,13L,13L,15L,13L,11L,16L,12L,10L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257230Inst : IEnumerable<long>
{
public static readonly long[] Value=A257230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257230.Bytes);
public long this[int i]=>Value[i];

public static A257230Inst Instance=new A257230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257231
{
public static readonly long[] Value={ 1L,1L,4L,1L,4L,1L,5L,9L,4L,1L,4L,1L,16L,9L,4L,1L,4L,1L,16L,9L,4L,1L,7L,25L,16L,9L,4L,1L,4L,1L,36L,25L,16L,9L,4L,1L,16L,9L,4L,1L,4L,1L,16L,9L,4L,1L,36L,25L,16L,9L,4L,1L,36L,25L,16L,9L,4L,1L,4L,1L,36L,25L,16L,9L,4L,1L,16L,9L,4L,1L,4L,1L,36L,25L,16L,9L,4L,1L,16L,9L,4L,1L,36L,25L,16L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257231Inst : IEnumerable<long>
{
public static readonly long[] Value=A257231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257231.Bytes);
public long this[int i]=>Value[i];

public static A257231Inst Instance=new A257231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257232
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,0L,4L,2L,1L,1L,5L,3L,2L,2L,0L,6L,4L,3L,3L,1L,1L,7L,5L,4L,4L,2L,2L,0L,8L,6L,5L,5L,3L,3L,1L,1L,9L,7L,6L,6L,4L,4L,2L,2L,1L,10L,8L,7L,7L,5L,5L,3L,3L,2L,1L,11L,9L,8L,8L,6L,6L,4L,4L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257232Inst : IEnumerable<long>
{
public static readonly long[] Value=A257232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257232.Bytes);
public long this[int i]=>Value[i];

public static A257232Inst Instance=new A257232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257233
{
public static readonly long[] Value={ 1L,7L,6L,6L,4L,2L,6L,2L,4L,6L,4L,2L,4L,2L,6L,2L,4L,6L,2L,4L,4L,2L,4L,2L,2L,4L,6L,6L,4L,2L,2L,2L,2L,2L,4L,4L,2L,6L,2L,2L,2L,6L,2L,4L,2L,4L,4L,2L,4L,2L,6L,2L,2L,2L,6L,6L,2L,2L,2L,2L,4L,2L,2L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257233Inst : IEnumerable<long>
{
public static readonly long[] Value=A257233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257233.Bytes);
public long this[int i]=>Value[i];

public static A257233Inst Instance=new A257233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257234
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,0L,0L,-1L,1L,0L,0L,-1L,1L,0L,1L,0L,0L,-1L,1L,0L,1L,0L,0L,1L,0L,0L,-1L,1L,0L,1L,0L,0L,1L,0L,0L,-1L,1L,0L,0L,-1L,1L,0L,1L,0L,0L,1L,0L,0L,-1L,1L,0L,0L,-1L,1L,0L,1L,0L,0L,-1L,1L,0L,1L,0L,0L,1L,0L,0L,-1L,1L,0L,0L,-1L,1L,0L,1L,0L,0L,-1L,1L,0L,1L,0L,0L,1L,0L,0L,-1L,1L,0L,1L,0L,0L,1L,0L,0L,-1L,1L,0L,0L,-1L,1L,0L,1L,0L,0L,-1L,1L,0L,1L,0L,0L,1L,0L,0L,-1L,1L,0L,1L,0L,0L,1L,0L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257234Inst : IEnumerable<long>
{
public static readonly long[] Value=A257234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257234.Bytes);
public long this[int i]=>Value[i];

public static A257234Inst Instance=new A257234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257235
{
public static readonly long[] Value={ 1L,6L,3L,4L,3L,6L,5L,2L,9L,3L,0L,1L,3L,5L,4L,3L,3L,2L,3L,3L,6L,8L,2L,8L,4L,4L,5L,6L,9L,7L,8L,2L,5L,2L,2L,1L,0L,3L,3L,7L,2L,0L,4L,7L,0L,3L,7L,5L,4L,0L,4L,7L,2L,8L,1L,7L,6L,9L,5L,7L,4L,6L,1L,2L,9L,6L,2L,2L,3L,1L,7L,7L,9L,3L,3L,3L,5L,7L,3L,4L,8L,6L,1L,2L,0L,4L,6L,1L,2L,4L,9L,3L,7L,9L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257235Inst : IEnumerable<long>
{
public static readonly long[] Value=A257235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257235.Bytes);
public long this[int i]=>Value[i];

public static A257235Inst Instance=new A257235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257236
{
public static readonly long[] Value={ 2L,0L,3L,8L,5L,1L,3L,1L,9L,8L,1L,2L,4L,5L,0L,6L,1L,7L,6L,8L,5L,7L,1L,3L,7L,4L,2L,3L,5L,4L,3L,1L,0L,2L,4L,8L,5L,1L,8L,5L,6L,2L,2L,1L,0L,9L,3L,0L,6L,2L,3L,9L,3L,4L,9L,9L,1L,0L,6L,8L,1L,4L,2L,7L,2L,1L,9L,6L,2L,5L,8L,9L,1L,1L,4L,2L,8L,1L,7L,5L,4L,9L,6L,2L,3L,5L,8L,7L,5L,1L,6L,8L,2L,9L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257236Inst : IEnumerable<long>
{
public static readonly long[] Value=A257236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257236.Bytes);
public long this[int i]=>Value[i];

public static A257236Inst Instance=new A257236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257237
{
public static readonly long[] Value={ 7L,8L,9L,5L,0L,0L,8L,2L,8L,5L,5L,3L,5L,9L,1L,1L,4L,7L,8L,0L,4L,8L,9L,1L,1L,6L,0L,6L,3L,9L,5L,7L,3L,1L,0L,7L,1L,2L,4L,7L,2L,8L,7L,8L,5L,5L,5L,5L,0L,6L,9L,8L,0L,9L,6L,2L,3L,8L,9L,8L,5L,6L,0L,0L,4L,3L,7L,6L,4L,4L,0L,4L,6L,0L,6L,3L,0L,9L,4L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257237Inst : IEnumerable<long>
{
public static readonly long[] Value=A257237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257237.Bytes);
public long this[int i]=>Value[i];

public static A257237Inst Instance=new A257237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257238
{
public static readonly long[] Value={ 0L,1L,0L,8L,7L,0L,27L,26L,19L,0L,64L,63L,56L,37L,0L,125L,124L,117L,98L,61L,0L,216L,215L,208L,189L,152L,91L,0L,343L,342L,335L,316L,279L,218L,127L,0L,512L,511L,504L,485L,448L,387L,296L,169L,0L,729L,728L,721L,702L,665L,604L,513L,386L,217L,0L,1000L,999L,992L,973L,936L,875L,784L,657L,488L,271L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257238Inst : IEnumerable<long>
{
public static readonly long[] Value=A257238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257238.Bytes);
public long this[int i]=>Value[i];

public static A257238Inst Instance=new A257238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257239
{
public static readonly long[] Value={ 1L,7L,9L,7L,6L,6L,5L,4L,9L,4L,4L,0L,0L,4L,6L,1L,4L,6L,0L,9L,8L,9L,1L,6L,1L,9L,4L,3L,0L,6L,0L,2L,3L,6L,4L,6L,1L,3L,4L,0L,4L,3L,3L,6L,9L,3L,3L,5L,1L,8L,4L,3L,4L,3L,1L,7L,5L,7L,8L,9L,9L,5L,1L,2L,3L,9L,2L,2L,5L,2L,4L,8L,0L,8L,4L,9L,4L,0L,0L,0L,9L,9L,9L,3L,7L,8L,6L,1L,7L,3L,6L,5L,0L,2L,9L,2L,2L,8L,1L,2L,3L,7L,5L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257239Inst : IEnumerable<long>
{
public static readonly long[] Value=A257239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257239.Bytes);
public long this[int i]=>Value[i];

public static A257239Inst Instance=new A257239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257240
{
public static readonly long[] Value={ 2L,6L,1L,2L,8L,8L,7L,8L,6L,4L,7L,1L,7L,5L,4L,4L,7L,5L,4L,4L,0L,7L,2L,4L,9L,9L,3L,8L,6L,2L,9L,7L,6L,2L,9L,1L,2L,8L,7L,5L,7L,7L,1L,2L,8L,4L,8L,0L,6L,3L,2L,8L,1L,7L,2L,3L,0L,2L,7L,0L,0L,5L,1L,8L,2L,1L,0L,1L,8L,3L,5L,8L,4L,9L,1L,1L,2L,5L,7L,3L,6L,3L,4L,4L,2L,2L,7L,1L,1L,3L,9L,6L,0L,1L,9L,8L,4L,8L,5L,6L,8L,6L,7L,6L,0L,3L,6L,8L,1L,9L,0L,6L,1L,3L,2L,0L,6L,7L,5L,6L,3L,7L,2L,8L,3L,9L,8L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257240Inst : IEnumerable<long>
{
public static readonly long[] Value=A257240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257240.Bytes);
public long this[int i]=>Value[i];

public static A257240Inst Instance=new A257240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257241
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,6L,5L,10L,10L,6L,15L,20L,7L,21L,35L,35L,8L,28L,56L,70L,9L,36L,84L,126L,126L,10L,45L,120L,210L,252L,11L,55L,165L,330L,462L,462L,12L,66L,220L,495L,792L,924L,13L,78L,286L,715L,1287L,1716L,1716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257241Inst : IEnumerable<long>
{
public static readonly long[] Value=A257241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257241.Bytes);
public long this[int i]=>Value[i];

public static A257241Inst Instance=new A257241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257242
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,3L,1L,5L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,2L,4L,2L,4L,2L,8L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,5L,1L,7L,1L,3L,3L,5L,3L,7L,3L,13L,1L,1L,1L,1L,1L,3L,1L,5L,1L,1L,1L,1L,1L,3L,1L,5L,1L,1L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257242Inst : IEnumerable<long>
{
public static readonly long[] Value=A257242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257242.Bytes);
public long this[int i]=>Value[i];

public static A257242Inst Instance=new A257242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257243
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,5L,2L,4L,4L,2L,8L,5L,1L,7L,3L,5L,7L,3L,13L,3L,7L,5L,3L,11L,7L,1L,9L,5L,9L,11L,5L,21L,8L,2L,12L,4L,6L,10L,4L,18L,4L,10L,6L,4L,14L,12L,2L,16L,8L,14L,18L,8L,34L,5L,11L,9L,5L,19L,9L,1L,11L,7L,13L,15L,7L,29L,11L,3L,17L,5L,7L,13L,5L,23L,7L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257243Inst : IEnumerable<long>
{
public static readonly long[] Value=A257243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257243.Bytes);
public long this[int i]=>Value[i];

public static A257243Inst Instance=new A257243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257244
{
public static readonly long[] Value={ 2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,5L,5L,5L,3L,3L,3L,3L,3L,5L,5L,7L,7L,7L,7L,7L,3L,3L,3L,19L,7L,7L,3L,5L,5L,5L,3L,7L,5L,5L,5L,19L,11L,11L,3L,13L,13L,13L,3L,23L,13L,13L,5L,11L,11L,11L,3L,61L,7L,31L,3L,13L,13L,19L,3L,43L,13L,13L,3L,7L,5L,5L,5L,61L,11L,31L,23L,23L,3L,127L,7L,7L,3L,151L,7L,19L,3L,181L,7L,13L,3L,43L,31L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257244Inst : IEnumerable<long>
{
public static readonly long[] Value=A257244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257244.Bytes);
public long this[int i]=>Value[i];

public static A257244Inst Instance=new A257244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257245
{
public static readonly long[] Value={ 2L,3L,3L,3L,3L,5L,5L,3L,3L,5L,7L,7L,7L,3L,19L,7L,5L,5L,7L,5L,19L,11L,13L,13L,23L,13L,11L,11L,61L,31L,13L,19L,43L,13L,7L,5L,61L,31L,23L,127L,7L,151L,19L,181L,13L,43L,31L,233L,13L,13L,7L,11L,19L,31L,59L,31L,31L,163L,41L,41L,113L,11L,19L,19L,409L,41L,41L,41L,19L,41L,113L,29L,167L,13L,17L,11L,179L,19L,19L,13L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257245Inst : IEnumerable<long>
{
public static readonly long[] Value=A257245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257245.Bytes);
public long this[int i]=>Value[i];

public static A257245Inst Instance=new A257245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257246
{
public static readonly long[] Value={ 2L,3L,3L,3L,3L,5L,3L,3L,3L,5L,7L,7L,3L,3L,7L,3L,5L,3L,5L,5L,11L,3L,13L,3L,13L,5L,11L,3L,7L,3L,13L,3L,13L,3L,5L,5L,11L,23L,3L,7L,3L,7L,3L,7L,3L,31L,3L,7L,13L,3L,7L,5L,7L,3L,31L,31L,3L,13L,41L,5L,3L,7L,19L,3L,7L,41L,41L,3L,19L,7L,29L,5L,3L,13L,11L,5L,3L,19L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257246Inst : IEnumerable<long>
{
public static readonly long[] Value=A257246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257246.Bytes);
public long this[int i]=>Value[i];

public static A257246Inst Instance=new A257246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257247
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,11L,12L,14L,17L,20L,23L,27L,31L,36L,49L,51L,56L,59L,63L,66L,67L,69L,74L,78L,81L,88L,89L,91L,93L,97L,99L,101L,102L,114L,116L,120L,123L,126L,134L,141L,144L,146L,148L,152L,161L,163L,172L,173L,179L,192L,194L,195L,202L,207L,214L,219L,223L,227L,235L,240L,242L,246L,250L,252L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257247Inst : IEnumerable<long>
{
public static readonly long[] Value=A257247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257247.Bytes);
public long this[int i]=>Value[i];

public static A257247Inst Instance=new A257247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257248
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,2L,2L,1L,1L,2L,0L,1L,2L,3L,3L,2L,2L,2L,1L,1L,3L,1L,2L,2L,3L,0L,1L,2L,3L,4L,4L,3L,3L,3L,2L,2L,3L,2L,2L,2L,4L,1L,1L,3L,2L,3L,1L,3L,4L,2L,2L,1L,2L,3L,3L,4L,0L,1L,2L,3L,4L,5L,5L,4L,4L,4L,3L,3L,4L,3L,3L,3L,4L,2L,2L,3L,3L,3L,2L,3L,5L,2L,2L,2L,2L,4L,4L,3L,1L,1L,3L,2L,4L,2L,3L,4L,5L,1L,3L,3L,3L,4L,2L,3L,2L,2L,1L,4L,4L,2L,5L,1L,3L,3L,2L,3L,4L,4L,5L,0L,1L,2L,3L,4L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257248Inst : IEnumerable<long>
{
public static readonly long[] Value=A257248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257248.Bytes);
public long this[int i]=>Value[i];

public static A257248Inst Instance=new A257248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257249
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,2L,1L,2L,3L,3L,2L,4L,3L,2L,1L,2L,3L,3L,3L,4L,4L,2L,4L,3L,3L,2L,5L,4L,3L,2L,1L,2L,3L,3L,3L,4L,4L,3L,4L,4L,4L,2L,5L,5L,3L,4L,3L,5L,3L,2L,4L,4L,5L,4L,3L,3L,2L,6L,5L,4L,3L,2L,1L,2L,3L,3L,3L,4L,4L,3L,4L,4L,4L,3L,5L,5L,4L,4L,4L,5L,4L,2L,5L,5L,5L,5L,3L,3L,4L,6L,6L,4L,5L,3L,5L,4L,3L,2L,6L,4L,4L,4L,3L,5L,4L,5L,5L,6L,3L,3L,5L,2L,6L,4L,4L,5L,4L,3L,3L,2L,7L,6L,5L,4L,3L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257249Inst : IEnumerable<long>
{
public static readonly long[] Value=A257249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257249.Bytes);
public long this[int i]=>Value[i];

public static A257249Inst Instance=new A257249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257250
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,12L,14L,15L,16L,24L,26L,28L,30L,31L,32L,48L,52L,56L,58L,60L,62L,63L,64L,96L,100L,104L,106L,112L,114L,116L,118L,120L,122L,124L,126L,127L,128L,192L,200L,208L,212L,224L,226L,228L,232L,234L,236L,240L,242L,244L,246L,248L,250L,252L,254L,255L,256L,384L,392L,400L,416L,420L,424L,426L,448L,450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257250Inst : IEnumerable<long>
{
public static readonly long[] Value=A257250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257250.Bytes);
public long this[int i]=>Value[i];

public static A257250Inst Instance=new A257250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257251
{
public static readonly long[] Value={ 2L,2L,6L,2L,6L,20L,2L,6L,10L,42L,2L,6L,20L,28L,110L,2L,6L,10L,14L,22L,156L,2L,6L,20L,28L,44L,52L,272L,2L,6L,10L,14L,22L,26L,34L,342L,2L,6L,20L,28L,44L,52L,68L,76L,506L,2L,6L,10L,42L,66L,78L,102L,114L,138L,812L,2L,6L,20L,14L,22L,26L,34L,38L,46L,58L,930L,2L,6L,10L,42L,66L,78L,102L,114L,138L,174L,186L,1332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257251Inst : IEnumerable<long>
{
public static readonly long[] Value=A257251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257251.Bytes);
public long this[int i]=>Value[i];

public static A257251Inst Instance=new A257251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257252
{
public static readonly long[] Value={ 2L,6L,2L,20L,6L,2L,42L,10L,6L,2L,110L,28L,20L,6L,2L,156L,22L,14L,10L,6L,2L,272L,52L,44L,28L,20L,6L,2L,342L,34L,26L,22L,14L,10L,6L,2L,506L,76L,68L,52L,44L,28L,20L,6L,2L,812L,138L,114L,102L,78L,66L,42L,10L,6L,2L,930L,58L,46L,38L,34L,26L,22L,14L,20L,6L,2L,1332L,186L,174L,138L,114L,102L,78L,66L,42L,10L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257252Inst : IEnumerable<long>
{
public static readonly long[] Value=A257252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257252.Bytes);
public long this[int i]=>Value[i];

public static A257252Inst Instance=new A257252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257253
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,10L,1L,3L,5L,21L,1L,3L,10L,14L,55L,1L,3L,5L,7L,11L,78L,1L,3L,10L,14L,22L,26L,136L,1L,3L,5L,7L,11L,13L,17L,171L,1L,3L,10L,14L,22L,26L,34L,38L,253L,1L,3L,5L,21L,33L,39L,51L,57L,69L,406L,1L,3L,10L,7L,11L,13L,17L,19L,23L,29L,465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257253Inst : IEnumerable<long>
{
public static readonly long[] Value=A257253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257253.Bytes);
public long this[int i]=>Value[i];

public static A257253Inst Instance=new A257253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257254
{
public static readonly long[] Value={ 1L,3L,1L,10L,3L,1L,21L,5L,3L,1L,55L,14L,10L,3L,1L,78L,11L,7L,5L,3L,1L,136L,26L,22L,14L,10L,3L,1L,171L,17L,13L,11L,7L,5L,3L,1L,253L,38L,34L,26L,22L,14L,10L,3L,1L,406L,69L,57L,51L,39L,33L,21L,5L,3L,1L,465L,29L,23L,19L,17L,13L,11L,7L,10L,3L,1L,666L,93L,87L,69L,57L,51L,39L,33L,21L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257254Inst : IEnumerable<long>
{
public static readonly long[] Value=A257254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257254.Bytes);
public long this[int i]=>Value[i];

public static A257254Inst Instance=new A257254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257255
{
public static readonly long[] Value={ 1L,2L,2L,2L,6L,12L,2L,6L,20L,18L,2L,6L,22L,30L,32L,2L,6L,20L,34L,52L,40L,2L,6L,22L,30L,50L,62L,64L,2L,6L,20L,32L,52L,64L,92L,84L,2L,6L,22L,30L,54L,62L,100L,116L,108L,2L,6L,20L,34L,48L,72L,92L,120L,156L,124L,2L,6L,22L,30L,50L,64L,102L,120L,152L,168L,138L,2L,6L,20L,32L,52L,62L,96L,124L,156L,168L,206L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257255Inst : IEnumerable<long>
{
public static readonly long[] Value=A257255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257255.Bytes);
public long this[int i]=>Value[i];

public static A257255Inst Instance=new A257255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257256
{
public static readonly long[] Value={ 1L,2L,12L,18L,32L,40L,64L,84L,108L,124L,138L,170L,206L,214L,274L,296L,318L,338L,348L,378L,426L,454L,498L,532L,564L,600L,662L,678L,710L,736L,766L,836L,874L,920L,944L,954L,1078L,1104L,1120L,1170L,1202L,1254L,1296L,1332L,1378L,1416L,1434L,1466L,1592L,1612L,1660L,1696L,1778L,1786L,1820L,1888L,1932L,1952L,2058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257256Inst : IEnumerable<long>
{
public static readonly long[] Value=A257256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257256.Bytes);
public long this[int i]=>Value[i];

public static A257256Inst Instance=new A257256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257257
{
public static readonly long[] Value={ 2L,2L,6L,2L,6L,14L,2L,6L,16L,24L,2L,6L,14L,28L,44L,2L,6L,16L,26L,48L,60L,2L,6L,14L,28L,48L,60L,84L,2L,6L,16L,24L,52L,64L,86L,122L,2L,6L,14L,26L,48L,66L,94L,126L,142L,2L,6L,16L,28L,48L,62L,86L,132L,144L,176L,2L,6L,14L,26L,44L,60L,94L,120L,146L,166L,216L,2L,6L,16L,24L,48L,64L,86L,132L,142L,180L,234L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257257Inst : IEnumerable<long>
{
public static readonly long[] Value=A257257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257257.Bytes);
public long this[int i]=>Value[i];

public static A257257Inst Instance=new A257257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257258
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,7L,1L,3L,8L,12L,1L,3L,7L,14L,22L,1L,3L,8L,13L,24L,30L,1L,3L,7L,14L,24L,30L,42L,1L,3L,8L,12L,26L,32L,43L,61L,1L,3L,7L,13L,24L,33L,47L,63L,71L,1L,3L,8L,14L,24L,31L,43L,66L,72L,88L,1L,3L,7L,13L,22L,30L,47L,60L,73L,83L,108L,1L,3L,8L,12L,24L,32L,43L,66L,71L,90L,117L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257258Inst : IEnumerable<long>
{
public static readonly long[] Value=A257258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257258.Bytes);
public long this[int i]=>Value[i];

public static A257258Inst Instance=new A257258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257259
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,-1L,-3L,-1L,-6L,-8L,-10L,-7L,-4L,2L,2L,-14L,-90L,-318L,-896L,-2166L,-4691L,-9298L,-17175L,-30007L,-50261L,-81664L,-129637L,-200973L,-301205L,-426500L,-545183L,-561511L,-252122L,836543L,3542930L,9312475L,20508985L,40858087L,76119037L,135203839L,232236417L,390709345L,652711050L,1101492173L,1921013671L,3558812217L,7170401227L,15800043812L,37400877416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257259Inst : IEnumerable<long>
{
public static readonly long[] Value=A257259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257259.Bytes);
public long this[int i]=>Value[i];

public static A257259Inst Instance=new A257259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257260
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,3L,1L,3L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,3L,1L,3L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,3L,1L,3L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,3L,1L,3L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257260Inst : IEnumerable<long>
{
public static readonly long[] Value=A257260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257260.Bytes);
public long this[int i]=>Value[i];

public static A257260Inst Instance=new A257260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257261
{
public static readonly long[] Value={ 0L,1L,2L,1L,0L,1L,3L,1L,2L,1L,3L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,4L,1L,2L,1L,4L,1L,3L,1L,2L,1L,3L,1L,4L,1L,2L,1L,4L,1L,4L,1L,2L,1L,4L,1L,0L,1L,2L,1L,0L,1L,3L,1L,2L,1L,3L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,3L,1L,2L,1L,3L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,3L,1L,2L,1L,3L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257261Inst : IEnumerable<long>
{
public static readonly long[] Value=A257261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257261.Bytes);
public long this[int i]=>Value[i];

public static A257261Inst Instance=new A257261Inst();

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