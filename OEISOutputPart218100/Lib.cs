using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A268762
{
public static readonly long[] Value={ 5L,44L,223L,1148L,5170L,23156L,99057L,418924L,1736105L,7122856L,28898144L,116346184L,465034573L,1848051516L,7306228767L,28758043956L,112751067666L,440538622908L,1715952146561L,6665380161836L,25826102521633L,99840968906384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268762Inst : IEnumerable<long>
{
public static readonly long[] Value=A268762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268762.Bytes);
public long this[int i]=>Value[i];

public static A268762Inst Instance=new A268762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268763
{
public static readonly long[] Value={ 10L,105L,762L,5170L,32056L,193573L,1129042L,6475898L,36505596L,203462597L,1122256900L,6140903312L,33367393732L,180252797855L,968778729426L,5183858768244L,27630592631158L,146768594783741L,777214421588348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268763Inst : IEnumerable<long>
{
public static readonly long[] Value=A268763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268763.Bytes);
public long this[int i]=>Value[i];

public static A268763Inst Instance=new A268763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268764
{
public static readonly long[] Value={ 20L,258L,2607L,23156L,193573L,1552272L,12111209L,92571436L,696659613L,5178525870L,38112289517L,278191828634L,2016589831189L,14532118028260L,104191269908219L,743719988895596L,5288057396240333L,37470071363668612L,264689231027772351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268764Inst : IEnumerable<long>
{
public static readonly long[] Value=A268764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268764.Bytes);
public long this[int i]=>Value[i];

public static A268764Inst Instance=new A268764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268765
{
public static readonly long[] Value={ 38L,595L,8500L,99057L,1129042L,12111209L,127676872L,1312123185L,13311824510L,133228716170L,1321110678618L,12988699400546L,126844585914726L,1231361200765123L,11893679949360102L,114371480492930683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268765Inst : IEnumerable<long>
{
public static readonly long[] Value=A268765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268765.Bytes);
public long this[int i]=>Value[i];

public static A268765Inst Instance=new A268765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268766
{
public static readonly long[] Value={ 0L,1L,1L,2L,6L,2L,5L,15L,15L,5L,10L,44L,56L,44L,10L,20L,105L,223L,223L,105L,20L,38L,258L,762L,1148L,762L,258L,38L,71L,595L,2607L,5170L,5170L,2607L,595L,71L,130L,1368L,8500L,23156L,32056L,23156L,8500L,1368L,130L,235L,3069L,27411L,99057L,193573L,193573L,99057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268766Inst : IEnumerable<long>
{
public static readonly long[] Value=A268766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268766.Bytes);
public long this[int i]=>Value[i];

public static A268766Inst Instance=new A268766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268767
{
public static readonly BigInteger[] Value={ 0L,12L,112L,2296L,64112L,3104544L,255353744L,36091542548L,8990276037592L,3911658481295924L,3022669494445395808L,BigInteger.Parse("4128305052223833006600"),BigInteger.Parse("10045914708457218016317000"),BigInteger.Parse("43496963453603913793217952196") };
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
public class A268767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268767Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268767.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268767.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268767Inst Instance=new A268767Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268768
{
public static readonly long[] Value={ 3L,12L,32L,100L,248L,620L,1456L,3380L,7656L,17148L,37920L,83140L,180824L,390796L,839824L,1796180L,3825352L,8116764L,17165568L,36195300L,76118840L,159694252L,334301552L,698429300L,1456510888L,3032326460L,6303262176L,13083742980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268768Inst : IEnumerable<long>
{
public static readonly long[] Value=A268768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268768.Bytes);
public long this[int i]=>Value[i];

public static A268768Inst Instance=new A268768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268769
{
public static readonly long[] Value={ 12L,32L,112L,446L,1524L,5214L,17000L,54822L,173244L,541910L,1676448L,5146030L,15683076L,47518926L,143238872L,429867830L,1285009740L,3828046534L,11368576272L,33669165246L,99465517716L,293175780030L,862355454792L,2531766659654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268769Inst : IEnumerable<long>
{
public static readonly long[] Value=A268769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268769.Bytes);
public long this[int i]=>Value[i];

public static A268769Inst Instance=new A268769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268770
{
public static readonly long[] Value={ 36L,100L,446L,2296L,10340L,46312L,198114L,837848L,3472210L,14245712L,57796288L,232692368L,930069146L,3696103032L,14612457534L,57516087912L,225502135332L,881077245816L,3431904293122L,13330760323672L,51652205043266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268770Inst : IEnumerable<long>
{
public static readonly long[] Value=A268770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268770.Bytes);
public long this[int i]=>Value[i];

public static A268770Inst Instance=new A268770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268771
{
public static readonly long[] Value={ 96L,248L,1524L,10340L,64112L,387146L,2258084L,12951796L,73011192L,406925194L,2244513800L,12281806624L,66734787464L,360505595710L,1937557458852L,10367717536488L,55261185262316L,293537189567482L,1554428843176696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268771Inst : IEnumerable<long>
{
public static readonly long[] Value=A268771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268771.Bytes);
public long this[int i]=>Value[i];

public static A268771Inst Instance=new A268771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268772
{
public static readonly long[] Value={ 240L,620L,5214L,46312L,387146L,3104544L,24222418L,185142872L,1393319226L,10357051740L,76224579034L,556383657268L,4033179662378L,29064236056520L,208382539816438L,1487439977791192L,10576114792480666L,74940142727337224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268772Inst : IEnumerable<long>
{
public static readonly long[] Value=A268772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268772.Bytes);
public long this[int i]=>Value[i];

public static A268772Inst Instance=new A268772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268773
{
public static readonly long[] Value={ 576L,1456L,17000L,198114L,2258084L,24222418L,255353744L,2624246370L,26623649020L,266457432340L,2642221357236L,25977398801092L,253689171829452L,2462722401530246L,23787359898720204L,228742960985861366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268773Inst : IEnumerable<long>
{
public static readonly long[] Value=A268773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268773.Bytes);
public long this[int i]=>Value[i];

public static A268773Inst Instance=new A268773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268774
{
public static readonly long[] Value={ 0L,3L,3L,12L,12L,12L,36L,32L,32L,36L,96L,100L,112L,100L,96L,240L,248L,446L,446L,248L,240L,576L,620L,1524L,2296L,1524L,620L,576L,1344L,1456L,5214L,10340L,10340L,5214L,1456L,1344L,3072L,3380L,17000L,46312L,64112L,46312L,17000L,3380L,3072L,6912L,7656L,54822L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268774Inst : IEnumerable<long>
{
public static readonly long[] Value=A268774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268774.Bytes);
public long this[int i]=>Value[i];

public static A268774Inst Instance=new A268774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268775
{
public static readonly long[] Value={ 4L,11L,26L,65L,148L,343L,766L,1709L,3752L,8195L,17746L,38233L,81916L,174767L,371366L,786437L,1660240L,3495259L,7340026L,15379121L,32156324L,67108871L,139810126L,290805085L,603979768L,1252698803L,2594876066L,5368709129L,11095332172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268775Inst : IEnumerable<long>
{
public static readonly long[] Value=A268775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268775.Bytes);
public long this[int i]=>Value[i];

public static A268775Inst Instance=new A268775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268776
{
public static readonly long[] Value={ 7L,26L,91L,316L,1031L,3354L,10615L,33344L,103339L,317958L,970515L,2945172L,8888719L,26705714L,79909167L,238257768L,708129267L,2098664158L,6203795403L,18296271036L,53845375703L,158159174410L,463734769895L,1357486034320L,3967761581627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268776Inst : IEnumerable<long>
{
public static readonly long[] Value=A268776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268776.Bytes);
public long this[int i]=>Value[i];

public static A268776Inst Instance=new A268776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268777
{
public static readonly long[] Value={ 13L,65L,316L,1462L,6383L,27531L,115391L,478849L,1957904L,7940136L,31916445L,127480373L,506131101L,1999695453L,7865869056L,30823236470L,120372357259L,468663337303L,1819741296607L,7048393305965L,27239539562644L,105056982554032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268777Inst : IEnumerable<long>
{
public static readonly long[] Value=A268777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268777.Bytes);
public long this[int i]=>Value[i];

public static A268777Inst Instance=new A268777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268778
{
public static readonly long[] Value={ 23L,148L,1031L,6383L,38483L,224960L,1288693L,7271509L,40511381L,223527424L,1223021243L,6646278717L,35903716877L,192977652868L,1032630435883L,5504232072227L,29238119105311L,154834459041646L,817685821067843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268778Inst : IEnumerable<long>
{
public static readonly long[] Value=A268778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268778.Bytes);
public long this[int i]=>Value[i];

public static A268778Inst Instance=new A268778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268779
{
public static readonly long[] Value={ 41L,343L,3354L,27531L,224960L,1755113L,13493468L,101738555L,758303322L,5590121407L,40870469356L,296640792103L,2140108184248L,15358691305417L,109723986174308L,780748875032869L,5535897115345958L,39128843941494495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268779Inst : IEnumerable<long>
{
public static readonly long[] Value=A268779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268779.Bytes);
public long this[int i]=>Value[i];

public static A268779Inst Instance=new A268779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268780
{
public static readonly long[] Value={ 72L,766L,10615L,115391L,1288693L,13493468L,140404442L,1425678976L,14341399141L,142487073304L,1404716302427L,13742060955231L,133640514636584L,1292631496259982L,12446235637750465L,119353876258739189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268780Inst : IEnumerable<long>
{
public static readonly long[] Value=A268780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268780.Bytes);
public long this[int i]=>Value[i];

public static A268780Inst Instance=new A268780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268781
{
public static readonly long[] Value={ 2L,4L,4L,7L,11L,7L,13L,26L,26L,13L,23L,65L,91L,65L,23L,41L,148L,316L,316L,148L,41L,72L,343L,1031L,1462L,1031L,343L,72L,126L,766L,3354L,6383L,6383L,3354L,766L,126L,219L,1709L,10615L,27531L,38483L,27531L,10615L,1709L,219L,379L,3752L,33344L,115391L,224960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268781Inst : IEnumerable<long>
{
public static readonly long[] Value=A268781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268781.Bytes);
public long this[int i]=>Value[i];

public static A268781Inst Instance=new A268781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268782
{
public static readonly BigInteger[] Value={ 0L,5L,72L,1714L,67100L,4725018L,611932378L,148013550916L,67580406047498L,58605374440440754L,BigInteger.Parse("97015414668307967168"),BigInteger.Parse("307604236621005318739500"),BigInteger.Parse("1873151902121241161650454526"),BigInteger.Parse("21951627197224261891003815976598") };
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
public class A268782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268782Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268782.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268782.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268782Inst Instance=new A268782Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268783
{
public static readonly long[] Value={ 1L,5L,17L,48L,131L,338L,850L,2091L,5061L,12095L,28608L,67095L,156244L,361652L,832757L,1908885L,4358285L,9915728L,22489147L,50862918L,114743814L,258261695L,580072917L,1300393467L,2910078592L,6501783407L,14504787560L,32313853992L,71896385513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268783Inst : IEnumerable<long>
{
public static readonly long[] Value=A268783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268783.Bytes);
public long this[int i]=>Value[i];

public static A268783Inst Instance=new A268783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268784
{
public static readonly long[] Value={ 2L,17L,72L,302L,1144L,4207L,14984L,52335L,179854L,610504L,2051436L,6836258L,22622554L,74418562L,243553160L,793537401L,2575357784L,8329124488L,26854438804L,86342760711L,276915214344L,886094782671L,2829527431748L,9018299661270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268784Inst : IEnumerable<long>
{
public static readonly long[] Value=A268784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268784.Bytes);
public long this[int i]=>Value[i];

public static A268784Inst Instance=new A268784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268785
{
public static readonly long[] Value={ 5L,48L,302L,1714L,9085L,46195L,228384L,1105510L,5267662L,24786180L,115455033L,533317129L,2446323573L,11154503019L,50600348892L,228514035985L,1027932765869L,4607917805325L,20591918472965L,91765529043193L,407916504889146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268785Inst : IEnumerable<long>
{
public static readonly long[] Value=A268785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268785.Bytes);
public long this[int i]=>Value[i];

public static A268785Inst Instance=new A268785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268786
{
public static readonly long[] Value={ 10L,131L,1144L,9085L,67100L,477128L,3295246L,22302699L,148575958L,977609634L,6368239274L,41140907455L,263939673228L,1683296018391L,10680625988516L,67468330344536L,424526386272378L,2661981983940811L,16640406499054332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268786Inst : IEnumerable<long>
{
public static readonly long[] Value=A268786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268786.Bytes);
public long this[int i]=>Value[i];

public static A268786Inst Instance=new A268786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268787
{
public static readonly long[] Value={ 20L,338L,4207L,46195L,477128L,4725018L,45515227L,429442918L,3988796543L,36591758790L,332327545513L,2993282062865L,26773510121640L,238060527618025L,2105957538309226L,18547209960131466L,162707970808249851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268787Inst : IEnumerable<long>
{
public static readonly long[] Value=A268787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268787.Bytes);
public long this[int i]=>Value[i];

public static A268787Inst Instance=new A268787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268788
{
public static readonly long[] Value={ 38L,850L,14984L,228384L,3295246L,45515227L,611932378L,8057509992L,104456486696L,1337467436839L,16954554895936L,213155407369839L,2661273257222436L,33030289066656341L,407868045265169610L,5014148928763408926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268788Inst : IEnumerable<long>
{
public static readonly long[] Value=A268788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268788.Bytes);
public long this[int i]=>Value[i];

public static A268788Inst Instance=new A268788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268789
{
public static readonly long[] Value={ 0L,1L,1L,2L,5L,2L,5L,17L,17L,5L,10L,48L,72L,48L,10L,20L,131L,302L,302L,131L,20L,38L,338L,1144L,1714L,1144L,338L,38L,71L,850L,4207L,9085L,9085L,4207L,850L,71L,130L,2091L,14984L,46195L,67100L,46195L,14984L,2091L,130L,235L,5061L,52335L,228384L,477128L,477128L,228384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268789Inst : IEnumerable<long>
{
public static readonly long[] Value=A268789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268789.Bytes);
public long this[int i]=>Value[i];

public static A268789Inst Instance=new A268789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268790
{
public static readonly long[] Value={ 177L,213L,219L,267L,309L,327L,381L,393L,411L,417L,447L,453L,471L,501L,519L,537L,573L,579L,633L,681L,717L,723L,753L,771L,789L,807L,813L,843L,849L,879L,921L,933L,1011L,1041L,1047L,1059L,1077L,1101L,1119L,1137L,1149L,1167L,1191L,1203L,1227L,1257L,1263L,1293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268790Inst : IEnumerable<long>
{
public static readonly long[] Value=A268790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268790.Bytes);
public long this[int i]=>Value[i];

public static A268790Inst Instance=new A268790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268791
{
public static readonly BigInteger[] Value={ 0L,22L,248L,4800L,168740L,11138352L,1384570516L,325815151556L,145913571668076L,124768928833331732L,BigInteger.Parse("204377241703937153076"),BigInteger.Parse("642788798787566885184552"),BigInteger.Parse("3889478620658657294120765368"),BigInteger.Parse("45350632160719542617837369658508") };
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
public class A268791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268791Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268791.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268791.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268791Inst Instance=new A268791Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268792
{
public static readonly long[] Value={ 3L,22L,78L,234L,652L,1714L,4360L,10820L,26366L,63346L,150482L,354196L,827310L,1919884L,4430664L,10175910L,23272918L,53029498L,120435100L,272714858L,615904208L,1387638220L,3119557838L,6999162874L,15675003042L,35046218020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268792Inst : IEnumerable<long>
{
public static readonly long[] Value=A268792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268792.Bytes);
public long this[int i]=>Value[i];

public static A268792Inst Instance=new A268792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268793
{
public static readonly long[] Value={ 12L,78L,248L,950L,3384L,11948L,41248L,140698L,474472L,1586038L,5262024L,17348096L,56884272L,185647624L,603388088L,1953997896L,6307338900L,20300666174L,65169102416L,208712267048L,666993883320L,2127375490930L,6773070493400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268793Inst : IEnumerable<long>
{
public static readonly long[] Value=A268793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268793.Bytes);
public long this[int i]=>Value[i];

public static A268793Inst Instance=new A268793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268794
{
public static readonly long[] Value={ 36L,234L,950L,4800L,23994L,117062L,561116L,2652936L,12405748L,57490444L,264428454L,1208522850L,5493284922L,24851601802L,111963916212L,502590509990L,2248738675490L,10032298715910L,44640056867750L,198161794087570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268794Inst : IEnumerable<long>
{
public static readonly long[] Value=A268794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268794.Bytes);
public long this[int i]=>Value[i];

public static A268794Inst Instance=new A268794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268795
{
public static readonly long[] Value={ 96L,652L,3384L,23994L,168740L,1158904L,7801688L,51781418L,339641264L,2206871084L,14226779556L,91107781858L,580148670100L,3676143046622L,23194484120032L,145793482383084L,913349363853072L,5704743147188222L,35535874740219072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268795Inst : IEnumerable<long>
{
public static readonly long[] Value=A268795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268795.Bytes);
public long this[int i]=>Value[i];

public static A268795Inst Instance=new A268795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268796
{
public static readonly long[] Value={ 240L,1714L,11948L,117062L,1158904L,11138352L,104971262L,974000420L,8927994302L,81031120788L,729449219322L,6521558348746L,57964319359808L,512593621373638L,4513059897036336L,39580897460175788L,345946165584055346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268796Inst : IEnumerable<long>
{
public static readonly long[] Value=A268796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268796.Bytes);
public long this[int i]=>Value[i];

public static A268796Inst Instance=new A268796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268797
{
public static readonly long[] Value={ 576L,4360L,41248L,561116L,7801688L,104971262L,1384570516L,17967375416L,230262982692L,2921020155826L,36745483472428L,459003330021886L,5699362152372404L,70403795917829390L,865796392149477244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268797Inst : IEnumerable<long>
{
public static readonly long[] Value=A268797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268797.Bytes);
public long this[int i]=>Value[i];

public static A268797Inst Instance=new A268797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268798
{
public static readonly long[] Value={ 0L,3L,3L,12L,22L,12L,36L,78L,78L,36L,96L,234L,248L,234L,96L,240L,652L,950L,950L,652L,240L,576L,1714L,3384L,4800L,3384L,1714L,576L,1344L,4360L,11948L,23994L,23994L,11948L,4360L,1344L,3072L,10820L,41248L,117062L,168740L,117062L,41248L,10820L,3072L,6912L,26366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268798Inst : IEnumerable<long>
{
public static readonly long[] Value=A268798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268798.Bytes);
public long this[int i]=>Value[i];

public static A268798Inst Instance=new A268798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268799
{
public static readonly long[] Value={ 4L,8L,12L,20L,24L,36L,40L,56L,60L,64L,68L,112L,120L,132L,144L,156L,168L,176L,184L,200L,240L,256L,272L,280L,296L,356L,396L,444L,452L,480L,532L,616L,620L,672L,692L,708L,840L,864L,896L,916L,1004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268799Inst : IEnumerable<long>
{
public static readonly long[] Value=A268799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268799.Bytes);
public long this[int i]=>Value[i];

public static A268799Inst Instance=new A268799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268800
{
public static readonly long[] Value={ 3L,11L,31L,83L,283L,383L,1327L,2591L,7351L,7759L,11171L,11587L,31391L,46919L,147919L,288023L,360611L,425603L,507163L,666203L,1414703L,2198887L,3358151L,9287659L,11512547L,11648531L,24315047L,42453823L,145554779L,161720147L,184007671L,766668811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268800Inst : IEnumerable<long>
{
public static readonly long[] Value=A268800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268800.Bytes);
public long this[int i]=>Value[i];

public static A268800Inst Instance=new A268800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268801
{
public static readonly long[] Value={ 7L,19L,43L,103L,307L,419L,1367L,2647L,7411L,7823L,11239L,11699L,31511L,47051L,148063L,288179L,360779L,425779L,507347L,666403L,1414943L,2199143L,3358423L,9287939L,11512843L,11648887L,24315443L,42454267L,145555231L,161720627L,184008203L,766669427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268801Inst : IEnumerable<long>
{
public static readonly long[] Value=A268801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268801.Bytes);
public long this[int i]=>Value[i];

public static A268801Inst Instance=new A268801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268802
{
public static readonly BigInteger[] Value={ 3L,34L,332L,5848L,195384L,12432856L,1508087180L,348686105792L,154172619407288L,130573457756588328L,BigInteger.Parse("212323461305457440492"),BigInteger.Parse("663970589813116610557692"),BigInteger.Parse("3999438097971983178736358520"),BigInteger.Parse("46462227980008803491191644654968") };
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
public class A268802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268802Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268802.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268802.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268802Inst Instance=new A268802Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268803
{
public static readonly long[] Value={ 9L,34L,104L,290L,772L,1972L,4914L,12010L,28922L,68836L,162274L,379524L,881712L,2036734L,4681646L,10714994L,24430816L,55516546L,125777028L,284188780L,640549034L,1440572818L,3233256010L,7243375068L,16199546178L,36172883716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268803Inst : IEnumerable<long>
{
public static readonly long[] Value=A268803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268803.Bytes);
public long this[int i]=>Value[i];

public static A268803Inst Instance=new A268803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268804
{
public static readonly long[] Value={ 24L,104L,332L,1202L,4158L,14308L,48460L,162722L,541744L,1791504L,5889586L,19264864L,62738690L,203528858L,658003018L,2120809106L,6816832928L,21856821554L,69922091542L,223229394256L,711333766468L,2262803472594L,7186710244256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268804Inst : IEnumerable<long>
{
public static readonly long[] Value=A268804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268804.Bytes);
public long this[int i]=>Value[i];

public static A268804Inst Instance=new A268804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268805
{
public static readonly long[] Value={ 60L,290L,1202L,5848L,28452L,135912L,640926L,2990786L,13835892L,63544542L,290056316L,1317009868L,5952527788L,26795651036L,120193389832L,537427198324L,2396207992178L,10656560102448L,47282655935580L,209348341875062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268805Inst : IEnumerable<long>
{
public static readonly long[] Value=A268805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268805.Bytes);
public long this[int i]=>Value[i];

public static A268805Inst Instance=new A268805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268806
{
public static readonly long[] Value={ 144L,772L,4158L,28452L,195384L,1316226L,8734264L,57302798L,372342650L,2400532536L,15373692036L,97900054556L,620374078660L,3914367133320L,24605301916568L,154148669247610L,962830699411796L,5997782979007294L,37271323919688010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268806Inst : IEnumerable<long>
{
public static readonly long[] Value=A268806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268806.Bytes);
public long this[int i]=>Value[i];

public static A268806Inst Instance=new A268806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268807
{
public static readonly long[] Value={ 336L,1972L,14308L,135912L,1316226L,12432856L,115671422L,1062318610L,9657289546L,87052567448L,779167091050L,6932066063186L,61353778718298L,540579543332426L,4744132651089162L,41488807479780664L,361699301828001722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268807Inst : IEnumerable<long>
{
public static readonly long[] Value=A268807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268807.Bytes);
public long this[int i]=>Value[i];

public static A268807Inst Instance=new A268807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268808
{
public static readonly long[] Value={ 768L,4914L,48460L,640926L,8734264L,115671422L,1508087180L,19390335102L,246666802206L,3110082281974L,38924665296474L,484120668061458L,5988867204857378L,73740656947715536L,904257358969806890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268808Inst : IEnumerable<long>
{
public static readonly long[] Value=A268808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268808.Bytes);
public long this[int i]=>Value[i];

public static A268808Inst Instance=new A268808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268809
{
public static readonly long[] Value={ 3L,9L,9L,24L,34L,24L,60L,104L,104L,60L,144L,290L,332L,290L,144L,336L,772L,1202L,1202L,772L,336L,768L,1972L,4158L,5848L,4158L,1972L,768L,1728L,4914L,14308L,28452L,28452L,14308L,4914L,1728L,3840L,12010L,48460L,135912L,195384L,135912L,48460L,12010L,3840L,8448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268809Inst : IEnumerable<long>
{
public static readonly long[] Value=A268809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268809.Bytes);
public long this[int i]=>Value[i];

public static A268809Inst Instance=new A268809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268810
{
public static readonly long[] Value={ 0L,2L,8L,18L,30L,44L,62L,84L,108L,134L,164L,198L,234L,272L,314L,360L,408L,458L,512L,570L,630L,692L,758L,828L,900L,974L,1052L,1134L,1218L,1304L,1394L,1488L,1584L,1682L,1784L,1890L,1998L,2108L,2222L,2340L,2460L,2582L,2708L,2838L,2970L,3104L,3242L,3384L,3528L,3674L,3824L,3978L,4134L,4292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268810Inst : IEnumerable<long>
{
public static readonly long[] Value=A268810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268810.Bytes);
public long this[int i]=>Value[i];

public static A268810Inst Instance=new A268810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268811
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,3L,3L,1L,1L,2L,1L,1L,2L,2L,3L,3L,2L,3L,3L,5L,5L,6L,5L,5L,6L,1L,1L,2L,1L,1L,2L,2L,3L,3L,1L,1L,2L,1L,1L,2L,2L,3L,3L,2L,3L,3L,5L,5L,6L,5L,5L,6L,2L,3L,3L,5L,5L,6L,5L,5L,6L,6L,7L,7L,6L,7L,7L,8L,8L,10L,6L,7L,7L,6L,7L,7L,8L,8L,10L,1L,1L,2L,1L,1L,2L,2L,3L,3L,1L,1L,2L,1L,1L,2L,2L,3L,3L,2L,3L,3L,5L,5L,6L,5L,5L,6L,1L,1L,2L,1L,1L,2L,2L,3L,3L,1L,1L,2L,1L,1L,2L,2L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268811Inst : IEnumerable<long>
{
public static readonly long[] Value=A268811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268811.Bytes);
public long this[int i]=>Value[i];

public static A268811Inst Instance=new A268811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268812
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,23L,31L,53L,59L,61L,89L,191L,277L,283L,887L,1373L,1979L,3037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268812Inst : IEnumerable<long>
{
public static readonly long[] Value=A268812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268812.Bytes);
public long this[int i]=>Value[i];

public static A268812Inst Instance=new A268812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268813
{
public static readonly long[] Value={ 2L,8L,0L,6L,1L,3L,3L,0L,5L,0L,7L,7L,0L,7L,6L,3L,4L,8L,9L,1L,5L,2L,9L,2L,3L,6L,7L,0L,0L,6L,3L,1L,8L,0L,3L,2L,5L,4L,5L,9L,5L,8L,4L,9L,9L,9L,1L,5L,2L,3L,2L,9L,1L,4L,4L,6L,9L,7L,7L,2L,6L,6L,3L,7L,9L,5L,0L,2L,7L,6L,9L,6L,9L,3L,8L,9L,4L,9L,0L,6L,1L,4L,9L,7L,0L,7L,2L,2L,2L,1L,6L,9L,8L,3L,1L,3L,7L,8L,5L,2L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268813Inst : IEnumerable<long>
{
public static readonly long[] Value=A268813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268813.Bytes);
public long this[int i]=>Value[i];

public static A268813Inst Instance=new A268813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268814
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,5L,14L,62L,298L,1494L,8140L,47146L,289250L,1873304L,12756416L,91062073L,679616480L,5290206513L,42858740990L,360686972473L,3147670023632L,28439719809159L,265647698228954L,2561823514680235L,25475177517626196L,260922963832247729L,2749617210928715246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268814Inst : IEnumerable<long>
{
public static readonly long[] Value=A268814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268814.Bytes);
public long this[int i]=>Value[i];

public static A268814Inst Instance=new A268814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268815
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,5L,19L,76L,360L,1792L,9634L,55286L,336396L,2162554L,14629720L,103818489L,770678553L,5969822993L,48148947503L,403545713463L,3508356996105L,31587389832791L,294087418038113L,2827471212909189L,28037001032306431L,286398141349873925L,3010540174760962975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268815Inst : IEnumerable<long>
{
public static readonly long[] Value=A268815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268815.Bytes);
public long this[int i]=>Value[i];

public static A268815Inst Instance=new A268815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268816
{
public static readonly long[] Value={ 0L,1L,4L,7L,12L,15L,10L,11L,26L,25L,30L,29L,20L,21L,16L,19L,48L,51L,54L,55L,62L,61L,58L,57L,40L,41L,44L,47L,36L,39L,34L,35L,98L,97L,102L,101L,108L,109L,104L,107L,120L,123L,126L,127L,118L,117L,114L,113L,80L,81L,84L,87L,92L,95L,90L,91L,74L,73L,78L,77L,68L,69L,64L,67L,192L,195L,198L,199L,206L,205L,202L,201L,216L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268816Inst : IEnumerable<long>
{
public static readonly long[] Value=A268816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268816.Bytes);
public long this[int i]=>Value[i];

public static A268816Inst Instance=new A268816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268817
{
public static readonly long[] Value={ 0L,1L,6L,4L,3L,9L,2L,7L,12L,22L,5L,11L,24L,13L,10L,8L,15L,45L,14L,19L,48L,21L,18L,16L,23L,25L,30L,28L,27L,17L,26L,31L,20L,94L,29L,35L,96L,37L,34L,32L,39L,41L,46L,44L,43L,33L,42L,47L,36L,49L,54L,52L,51L,57L,50L,55L,60L,38L,53L,59L,40L,61L,58L,56L,63L,189L,62L,67L,192L,69L,66L,64L,71L,73L,78L,76L,75L,65L,74L,79L,68L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268817Inst : IEnumerable<long>
{
public static readonly long[] Value=A268817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268817.Bytes);
public long this[int i]=>Value[i];

public static A268817Inst Instance=new A268817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268818
{
public static readonly long[] Value={ 0L,1L,6L,4L,3L,10L,2L,7L,15L,5L,14L,11L,8L,13L,18L,16L,23L,29L,22L,19L,32L,21L,9L,24L,12L,25L,30L,28L,27L,34L,26L,31L,39L,45L,38L,35L,48L,37L,57L,40L,60L,41L,46L,44L,43L,17L,42L,47L,20L,49L,54L,52L,51L,58L,50L,55L,63L,53L,62L,59L,56L,61L,66L,64L,71L,77L,70L,67L,80L,69L,89L,72L,92L,73L,78L,76L,75L,113L,74L,79L,116L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268818Inst : IEnumerable<long>
{
public static readonly long[] Value=A268818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268818.Bytes);
public long this[int i]=>Value[i];

public static A268818Inst Instance=new A268818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268819
{
public static readonly long[] Value={ 0L,98305L,3L,0L,6L,98306L,2L,98305L,12L,98311L,14L,3L,1L,98307L,9L,0L,24L,98317L,24L,6L,16L,98319L,27L,98306L,0L,98304L,23L,2L,30L,98312L,2L,98305L,48L,98329L,0L,12L,52L,98329L,6L,98311L,3L,98321L,3L,14L,14L,98330L,3L,3L,41L,98305L,43L,1L,4L,98326L,45L,98307L,6L,98335L,43L,9L,27L,98307L,19L,0L,27L,98353L,2L,24L,100L,98305L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268819Inst : IEnumerable<long>
{
public static readonly long[] Value=A268819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268819.Bytes);
public long this[int i]=>Value[i];

public static A268819Inst Instance=new A268819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268820
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,3L,1L,0L,4L,6L,3L,1L,0L,5L,2L,2L,3L,1L,0L,6L,12L,7L,2L,3L,1L,0L,7L,4L,6L,6L,2L,3L,1L,0L,8L,7L,13L,5L,6L,2L,3L,1L,0L,9L,5L,12L,7L,7L,6L,2L,3L,1L,0L,10L,24L,5L,15L,4L,7L,6L,2L,3L,1L,0L,11L,8L,4L,13L,5L,5L,7L,6L,2L,3L,1L,0L,12L,11L,25L,4L,14L,12L,5L,7L,6L,2L,3L,1L,0L,13L,9L,24L,12L,15L,4L,4L,5L,7L,6L,2L,3L,1L,0L,14L,13L,9L,27L,12L,10L,13L,4L,5L,7L,6L,2L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268820Inst : IEnumerable<long>
{
public static readonly long[] Value=A268820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268820.Bytes);
public long this[int i]=>Value[i];

public static A268820Inst Instance=new A268820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268821
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,13L,12L,5L,4L,25L,24L,9L,8L,15L,14L,11L,10L,49L,48L,17L,16L,23L,22L,19L,18L,27L,26L,31L,30L,21L,20L,29L,28L,97L,96L,33L,32L,39L,38L,35L,34L,43L,42L,47L,46L,37L,36L,45L,44L,51L,50L,55L,54L,61L,60L,53L,52L,41L,40L,57L,56L,63L,62L,59L,58L,193L,192L,65L,64L,71L,70L,67L,66L,75L,74L,79L,78L,69L,68L,77L,76L,83L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268821Inst : IEnumerable<long>
{
public static readonly long[] Value=A268821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268821.Bytes);
public long this[int i]=>Value[i];

public static A268821Inst Instance=new A268821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268822
{
public static readonly long[] Value={ 0L,1L,3L,2L,9L,8L,5L,4L,13L,12L,17L,16L,7L,6L,15L,14L,21L,20L,25L,24L,31L,30L,23L,22L,11L,10L,27L,26L,33L,32L,29L,28L,37L,36L,41L,40L,47L,46L,39L,38L,59L,58L,43L,42L,49L,48L,45L,44L,19L,18L,51L,50L,57L,56L,53L,52L,61L,60L,65L,64L,55L,54L,63L,62L,69L,68L,73L,72L,79L,78L,71L,70L,91L,90L,75L,74L,81L,80L,77L,76L,115L,114L,83L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268822Inst : IEnumerable<long>
{
public static readonly long[] Value=A268822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268822.Bytes);
public long this[int i]=>Value[i];

public static A268822Inst Instance=new A268822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268823
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,5L,7L,15L,13L,4L,12L,27L,25L,8L,24L,14L,10L,9L,11L,51L,49L,16L,48L,22L,18L,17L,19L,26L,30L,29L,31L,23L,21L,28L,20L,99L,97L,32L,96L,38L,34L,33L,35L,42L,46L,45L,47L,39L,37L,44L,36L,50L,54L,53L,55L,63L,61L,52L,60L,43L,41L,56L,40L,62L,58L,57L,59L,195L,193L,64L,192L,70L,66L,65L,67L,74L,78L,77L,79L,71L,69L,76L,68L,82L,86L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268823Inst : IEnumerable<long>
{
public static readonly long[] Value=A268823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268823.Bytes);
public long this[int i]=>Value[i];

public static A268823Inst Instance=new A268823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268824
{
public static readonly long[] Value={ 0L,1L,3L,2L,9L,5L,4L,6L,13L,17L,16L,18L,10L,8L,15L,7L,21L,25L,24L,26L,34L,32L,23L,31L,14L,12L,27L,11L,33L,29L,28L,30L,37L,41L,40L,42L,50L,48L,39L,47L,62L,60L,43L,59L,49L,45L,44L,46L,22L,20L,51L,19L,57L,53L,52L,54L,61L,65L,64L,66L,58L,56L,63L,55L,69L,73L,72L,74L,82L,80L,71L,79L,94L,92L,75L,91L,81L,77L,76L,78L,118L,116L,83L,115L,89L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268824Inst : IEnumerable<long>
{
public static readonly long[] Value=A268824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268824.Bytes);
public long this[int i]=>Value[i];

public static A268824Inst Instance=new A268824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268825
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,4L,5L,14L,15L,12L,13L,26L,27L,24L,25L,10L,11L,8L,9L,50L,51L,48L,49L,18L,19L,16L,17L,30L,31L,28L,29L,22L,23L,20L,21L,98L,99L,96L,97L,34L,35L,32L,33L,46L,47L,44L,45L,38L,39L,36L,37L,54L,55L,52L,53L,62L,63L,60L,61L,42L,43L,40L,41L,58L,59L,56L,57L,194L,195L,192L,193L,66L,67L,64L,65L,78L,79L,76L,77L,70L,71L,68L,69L,86L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268825Inst : IEnumerable<long>
{
public static readonly long[] Value=A268825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268825.Bytes);
public long this[int i]=>Value[i];

public static A268825Inst Instance=new A268825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268826
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,4L,5L,18L,19L,16L,17L,10L,11L,8L,9L,26L,27L,24L,25L,34L,35L,32L,33L,14L,15L,12L,13L,30L,31L,28L,29L,42L,43L,40L,41L,50L,51L,48L,49L,62L,63L,60L,61L,46L,47L,44L,45L,22L,23L,20L,21L,54L,55L,52L,53L,66L,67L,64L,65L,58L,59L,56L,57L,74L,75L,72L,73L,82L,83L,80L,81L,94L,95L,92L,93L,78L,79L,76L,77L,118L,119L,116L,117L,86L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268826Inst : IEnumerable<long>
{
public static readonly long[] Value=A268826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268826.Bytes);
public long this[int i]=>Value[i];

public static A268826Inst Instance=new A268826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268827
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,5L,12L,4L,10L,14L,13L,15L,30L,26L,25L,27L,11L,9L,24L,8L,54L,50L,49L,51L,19L,17L,48L,16L,31L,29L,20L,28L,18L,22L,21L,23L,102L,98L,97L,99L,35L,33L,96L,32L,47L,45L,36L,44L,34L,38L,37L,39L,55L,53L,60L,52L,58L,62L,61L,63L,46L,42L,41L,43L,59L,57L,40L,56L,198L,194L,193L,195L,67L,65L,192L,64L,79L,77L,68L,76L,66L,70L,69L,71L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268827Inst : IEnumerable<long>
{
public static readonly long[] Value=A268827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268827.Bytes);
public long this[int i]=>Value[i];

public static A268827Inst Instance=new A268827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268828
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,4L,5L,20L,18L,9L,17L,7L,11L,10L,12L,28L,26L,33L,25L,31L,35L,34L,36L,19L,15L,14L,16L,32L,30L,13L,29L,44L,42L,49L,41L,47L,51L,50L,52L,67L,63L,62L,64L,48L,46L,61L,45L,27L,23L,22L,24L,56L,54L,21L,53L,68L,66L,57L,65L,55L,59L,58L,60L,76L,74L,81L,73L,79L,83L,82L,84L,99L,95L,94L,96L,80L,78L,93L,77L,123L,119L,118L,120L,88L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268828Inst : IEnumerable<long>
{
public static readonly long[] Value=A268828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268828.Bytes);
public long this[int i]=>Value[i];

public static A268828Inst Instance=new A268828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268829
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,3L,1L,15L,0L,1L,1L,9L,7L,1L,3L,1L,27L,7L,1L,5L,1L,1L,29L,0L,1L,0L,0L,3L,1L,23L,3L,1L,5L,9L,1L,3L,1L,17L,3L,1L,3L,15L,15L,5L,3L,1L,51L,0L,1L,3L,0L,0L,15L,0L,1L,1L,53L,7L,1L,13L,31L,11L,9L,1L,1L,3L,1L,63L,7L,1L,0L,21L,7L,27L,9L,0L,5L,3L,1L,57L,0L,1L,13L,0L,5L,29L,0L,13L,1L,0L,3L,1L,43L,3L,1L,3L,53L,15L,23L,9L,25L,1L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268829Inst : IEnumerable<long>
{
public static readonly long[] Value=A268829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268829.Bytes);
public long this[int i]=>Value[i];

public static A268829Inst Instance=new A268829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268830
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,4L,1L,0L,4L,2L,3L,1L,0L,5L,6L,2L,3L,1L,0L,6L,8L,9L,2L,3L,1L,0L,7L,3L,8L,9L,2L,3L,1L,0L,8L,7L,5L,5L,6L,2L,3L,1L,0L,9L,10L,4L,4L,7L,8L,2L,3L,1L,0L,10L,12L,13L,6L,4L,6L,7L,2L,3L,1L,0L,11L,15L,12L,13L,5L,4L,6L,7L,2L,3L,1L,0L,12L,11L,17L,17L,18L,5L,4L,6L,7L,2L,3L,1L,0L,13L,5L,16L,16L,19L,20L,5L,4L,6L,7L,2L,3L,1L,0L,14L,13L,7L,18L,16L,18L,19L,5L,4L,6L,7L,2L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268830Inst : IEnumerable<long>
{
public static readonly long[] Value=A268830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268830.Bytes);
public long this[int i]=>Value[i];

public static A268830Inst Instance=new A268830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268831
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,5L,4L,13L,12L,11L,10L,15L,14L,31L,30L,27L,26L,9L,8L,25L,24L,55L,54L,51L,50L,17L,16L,49L,48L,29L,28L,21L,20L,19L,18L,23L,22L,103L,102L,99L,98L,33L,32L,97L,96L,45L,44L,37L,36L,35L,34L,39L,38L,53L,52L,61L,60L,59L,58L,63L,62L,47L,46L,43L,42L,57L,56L,41L,40L,199L,198L,195L,194L,65L,64L,193L,192L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268831Inst : IEnumerable<long>
{
public static readonly long[] Value=A268831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268831.Bytes);
public long this[int i]=>Value[i];

public static A268831Inst Instance=new A268831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268832
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,4L,5L,19L,18L,11L,10L,9L,8L,13L,12L,27L,26L,35L,34L,33L,32L,37L,36L,21L,20L,17L,16L,31L,30L,15L,14L,43L,42L,51L,50L,49L,48L,53L,52L,69L,68L,65L,64L,47L,46L,63L,62L,29L,28L,25L,24L,55L,54L,23L,22L,67L,66L,59L,58L,57L,56L,61L,60L,75L,74L,83L,82L,81L,80L,85L,84L,101L,100L,97L,96L,79L,78L,95L,94L,125L,124L,121L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268832Inst : IEnumerable<long>
{
public static readonly long[] Value=A268832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268832.Bytes);
public long this[int i]=>Value[i];

public static A268832Inst Instance=new A268832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268833
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,1L,2L,1L,0L,1L,2L,3L,2L,0L,1L,2L,3L,2L,3L,0L,1L,2L,1L,2L,1L,2L,0L,1L,2L,3L,2L,3L,2L,1L,0L,1L,2L,1L,2L,3L,4L,3L,2L,0L,1L,2L,1L,2L,3L,4L,3L,2L,3L,0L,1L,2L,3L,2L,3L,4L,3L,2L,3L,4L,0L,1L,2L,3L,2L,3L,4L,3L,2L,1L,4L,3L,0L,1L,2L,1L,2L,1L,2L,3L,2L,3L,2L,3L,2L,0L,1L,2L,1L,2L,3L,2L,1L,2L,3L,2L,3L,2L,3L,0L,1L,2L,3L,2L,3L,4L,3L,2L,3L,4L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268833Inst : IEnumerable<long>
{
public static readonly long[] Value=A268833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268833.Bytes);
public long this[int i]=>Value[i];

public static A268833Inst Instance=new A268833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268834
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,1L,2L,1L,0L,2L,3L,2L,1L,0L,3L,2L,3L,2L,1L,0L,2L,1L,2L,1L,2L,1L,0L,1L,2L,3L,2L,3L,2L,1L,0L,2L,3L,4L,3L,2L,1L,2L,1L,0L,3L,2L,3L,4L,3L,2L,1L,2L,1L,0L,4L,3L,2L,3L,4L,3L,2L,3L,2L,1L,0L,3L,4L,1L,2L,3L,4L,3L,2L,3L,2L,1L,0L,2L,3L,2L,3L,2L,3L,2L,1L,2L,1L,2L,1L,0L,3L,2L,3L,2L,3L,2L,1L,2L,3L,2L,1L,2L,1L,0L,2L,1L,2L,1L,4L,3L,2L,3L,4L,3L,2L,3L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268834Inst : IEnumerable<long>
{
public static readonly long[] Value=A268834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268834.Bytes);
public long this[int i]=>Value[i];

public static A268834Inst Instance=new A268834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268835
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,2L,3L,2L,3L,4L,5L,2L,1L,4L,3L,2L,3L,4L,5L,4L,3L,6L,5L,2L,3L,2L,1L,4L,5L,4L,3L,2L,3L,4L,5L,4L,3L,6L,5L,4L,5L,4L,3L,6L,7L,6L,5L,2L,3L,4L,3L,2L,3L,2L,3L,4L,5L,6L,5L,4L,3L,4L,3L,2L,3L,4L,5L,4L,3L,6L,5L,4L,5L,4L,3L,6L,7L,6L,5L,4L,5L,6L,5L,4L,5L,4L,5L,6L,7L,8L,7L,6L,5L,6L,5L,2L,3L,4L,3L,4L,5L,4L,5L,2L,3L,4L,5L,2L,1L,4L,3L,4L,5L,6L,5L,6L,5L,6L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268835Inst : IEnumerable<long>
{
public static readonly long[] Value=A268835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268835.Bytes);
public long this[int i]=>Value[i];

public static A268835Inst Instance=new A268835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268836
{
public static readonly long[] Value={ 0L,2L,8L,12L,26L,38L,46L,56L,86L,114L,138L,164L,180L,198L,220L,240L,302L,362L,418L,476L,524L,574L,628L,680L,712L,746L,784L,820L,866L,910L,950L,992L,1118L,1242L,1362L,1484L,1596L,1710L,1828L,1944L,2040L,2138L,2240L,2340L,2450L,2558L,2662L,2768L,2832L,2898L,2968L,3036L,3114L,3190L,3262L,3336L,3430L,3522L,3610L,3700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268836Inst : IEnumerable<long>
{
public static readonly long[] Value=A268836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268836.Bytes);
public long this[int i]=>Value[i];

public static A268836Inst Instance=new A268836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268837
{
public static readonly long[] Value={ 0L,2L,7L,18L,17L,48L,56L,80L,67L,122L,136L,194L,204L,268L,281L,328L,291L,378L,396L,498L,510L,640L,675L,792L,790L,886L,965L,1098L,1093L,1208L,1248L,1344L,1227L,1378L,1356L,1530L,1538L,1792L,1815L,2016L,2008L,2218L,2339L,2602L,2619L,2892L,2970L,3208L,3150L,3294L,3385L,3586L,3691L,4012L,4174L,4440L,4367L,4554L,4644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268837Inst : IEnumerable<long>
{
public static readonly long[] Value=A268837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268837.Bytes);
public long this[int i]=>Value[i];

public static A268837Inst Instance=new A268837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268838
{
public static readonly long[] Value={ 1L,4L,756L,45696L,2955700L,560028096L,126412047692L,93784124187136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268838Inst : IEnumerable<long>
{
public static readonly long[] Value=A268838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268838.Bytes);
public long this[int i]=>Value[i];

public static A268838Inst Instance=new A268838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268839
{
public static readonly BigInteger[] Value={ 9L,108L,1197L,13176L,144945L,1594404L,17538453L,192922992L,2122152921L,23343682140L,256780503549L,2824585539048L,31070440929537L,341774850224916L,3759523352474085L,41354756877214944L,454902325649364393L,5003925582143008332L,BigInteger.Parse("55043181403573091661") };
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
public class A268839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268839Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268839.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268839.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268839Inst Instance=new A268839Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268840
{
public static readonly BigInteger[] Value={ 1L,641L,195709L,46922017L,10258694241L,2176464012941L,460827731023773L,98540942707986273L,BigInteger.Parse("21364658238692907265"),BigInteger.Parse("4697818999010952011441"),BigInteger.Parse("1046430770756355786405517"),BigInteger.Parse("235755137688345453796236397"),BigInteger.Parse("53640184515807269993604743389"),BigInteger.Parse("12308974812428409561104536925709") };
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
public class A268840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268840.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268840Inst Instance=new A268840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268841
{
public static readonly BigInteger[] Value={ 1L,11389L,50775091L,162588279629L,449363984934526L,1162145520205261219L,BigInteger.Parse("2931247600219365331976"),BigInteger.Parse("7370846583668954571029069"),BigInteger.Parse("18683332440278067962764855531"),BigInteger.Parse("47964531978782851644184417448714"),BigInteger.Parse("124871404619023570844557764310152386") };
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
public class A268841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268841Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268841.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268841.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268841Inst Instance=new A268841Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268842
{
public static readonly BigInteger[] Value={ 1L,248749L,20117051281L,1077273394836829L,BigInteger.Parse("47342758641593552281"),BigInteger.Parse("1878320344216429026862153"),BigInteger.Parse("70803267480031877368227941803"),BigInteger.Parse("2612508237897293571677286548812861"),BigInteger.Parse("96042041352156959435669839199503441435"),BigInteger.Parse("3553102771891168237056005934820411063204249") };
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
public class A268842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268842Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268842.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268842.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268842Inst Instance=new A268842Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268843
{
public static readonly BigInteger[] Value={ 1L,6439075L,11260558754404L,12084070123028603391UL,BigInteger.Parse("10162884447920460534301136"),BigInteger.Parse("7465237877942551321425443305798"),BigInteger.Parse("5078529731893937404909347067888886466"),BigInteger.Parse("3315159778348807570604149155371730111763599"),BigInteger.Parse("2124172213523649116114190361767338538457819064671") };
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
public class A268843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268843Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268843.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268843.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268843Inst Instance=new A268843Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268844
{
public static readonly BigInteger[] Value={ 1L,192621953L,8445885515991841L,BigInteger.Parse("211301962987912098409729"),BigInteger.Parse("3969183064899133655031651559801"),BigInteger.Parse("63178476289432401423971737795658030945"),BigInteger.Parse("909546798992441266072332791609067485208949369"),BigInteger.Parse("12324197596430667064913735085330208112438377122058241") };
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
public class A268844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268844Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268844.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268844.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268844Inst Instance=new A268844Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268845
{
public static readonly BigInteger[] Value={ 1L,6536413529L,8167981106765263789L,BigInteger.Parse("5426679072605204732028894233"),BigInteger.Parse("2599293828638212400913690945686101111"),BigInteger.Parse("1025794060996626005769021866749636185341527229"),BigInteger.Parse("358281333933096129012031117609647623312585201668494007") };
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
public class A268845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268845Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268845.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268845.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268845Inst Instance=new A268845Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268846
{
public static readonly BigInteger[] Value={ 1L,248040482741L,BigInteger.Parse("9891092676022013399311"),BigInteger.Parse("195676681342450229063393365876181"),BigInteger.Parse("2683885055441747960475755652405552969614101"),BigInteger.Parse("29539005031390270063835072245497576346701114916209911"),BigInteger.Parse("282011782951614089942684801199121868144180995938610087493133121") };
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
public class A268846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268846Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268846.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268846.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268846Inst Instance=new A268846Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268847
{
public static readonly BigInteger[] Value={ 1L,1L,69L,31451L,46922017L,162588279629L,1077273394836829L,12084070123028603391UL,BigInteger.Parse("211301962987912098409729"),BigInteger.Parse("5426679072605204732028894233"),BigInteger.Parse("195676681342450229063393365876181"),BigInteger.Parse("9562449832974304724626743446267704131"),BigInteger.Parse("615516610914323638585463757154352054695009") };
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
public class A268847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268847Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268847.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268847.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268847Inst Instance=new A268847Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268848
{
public static readonly BigInteger[] Value={ 1L,1L,251L,729811L,10258694241L,449363984934526L,BigInteger.Parse("47342758641593552281"),BigInteger.Parse("10162884447920460534301136"),BigInteger.Parse("3969183064899133655031651559801"),BigInteger.Parse("2599293828638212400913690945686101111"),BigInteger.Parse("2683885055441747960475755652405552969614101") };
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
public class A268848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268848Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268848.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268848.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268848Inst Instance=new A268848Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268849
{
public static readonly BigInteger[] Value={ 1L,1L,923L,16928840L,2176464012941L,1162145520205261219L,BigInteger.Parse("1878320344216429026862153"),BigInteger.Parse("7465237877942551321425443305798"),BigInteger.Parse("63178476289432401423971737795658030945"),BigInteger.Parse("1025794060996626005769021866749636185341527229"),BigInteger.Parse("29539005031390270063835072245497576346701114916209911") };
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
public class A268849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268849Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268849.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268849.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268849Inst Instance=new A268849Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268850
{
public static readonly BigInteger[] Value={ 1L,1L,3431L,397222288L,460827731023773L,BigInteger.Parse("2931247600219365331976"),BigInteger.Parse("70803267480031877368227941803"),BigInteger.Parse("5078529731893937404909347067888886466"),BigInteger.Parse("909546798992441266072332791609067485208949369"),BigInteger.Parse("358281333933096129012031117609647623312585201668494007") };
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
public class A268850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268850Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268850.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268850.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268850Inst Instance=new A268850Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268851
{
public static readonly BigInteger[] Value={ 1L,1L,12869L,9450343019L,98540942707986273L,BigInteger.Parse("7370846583668954571029069"),BigInteger.Parse("2612508237897293571677286548812861"),BigInteger.Parse("3315159778348807570604149155371730111763599"),BigInteger.Parse("12324197596430667064913735085330208112438377122058241") };
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
public class A268851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268851Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268851.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268851.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268851Inst Instance=new A268851Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268852
{
public static readonly BigInteger[] Value={ 1L,1L,48619L,227749730869L,BigInteger.Parse("21364658238692907265"),BigInteger.Parse("18683332440278067962764855531"),BigInteger.Parse("96042041352156959435669839199503441435"),BigInteger.Parse("2124172213523649116114190361767338538457819064671"),BigInteger.Parse("161347197004751609388708454579308609212572710243373701247489") };
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
public class A268852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268852Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268852.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268852.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268852Inst Instance=new A268852Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268853
{
public static readonly BigInteger[] Value={ 1L,1L,184755L,5549991941777L,BigInteger.Parse("4697818999010952011441"),BigInteger.Parse("47964531978782851644184417448714"),BigInteger.Parse("3553102771891168237056005934820411063204249"),BigInteger.Parse("1355554085495648757684163048897568469564674091083870680"),BigInteger.Parse("2077847308887546704733072843165544143697549966176523511722695300153") };
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
public class A268853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268853Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268853.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268853.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268853Inst Instance=new A268853Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268854
{
public static readonly long[] Value={ 39L,24L,21L,15L,18L,24L,189L,67734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268854Inst : IEnumerable<long>
{
public static readonly long[] Value=A268854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268854.Bytes);
public long this[int i]=>Value[i];

public static A268854Inst Instance=new A268854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268855
{
public static readonly long[] Value={ 30L,21L,18L,15L,39L,120L,435L,541875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268855Inst : IEnumerable<long>
{
public static readonly long[] Value=A268855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268855.Bytes);
public long this[int i]=>Value[i];

public static A268855Inst Instance=new A268855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268856
{
public static readonly long[] Value={ 39L,36L,30L,21L,21L,15L,27L,675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268856Inst : IEnumerable<long>
{
public static readonly long[] Value=A268856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268856.Bytes);
public long this[int i]=>Value[i];

public static A268856Inst Instance=new A268856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268857
{
public static readonly long[] Value={ 5L,6L,7L,9L,8L,9L,12L,11L,18L,11L,11L,10L,13L,16L,19L,19L,23L,25L,35L,25L,32L,27L,37L,30L,46L,39L,45L,30L,31L,29L,27L,32L,32L,39L,34L,29L,34L,31L,34L,36L,33L,31L,29L,34L,31L,42L,37L,36L,45L,48L,64L,45L,60L,50L,67L,58L,66L,68L,72L,72L,79L,75L,80L,67L,69L,73L,65L,56L,61L,52L,53L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268857Inst : IEnumerable<long>
{
public static readonly long[] Value=A268857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268857.Bytes);
public long this[int i]=>Value[i];

public static A268857Inst Instance=new A268857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268858
{
public static readonly long[] Value={ 139L,239L,439L,739L,839L,1039L,1439L,2039L,2239L,2339L,2539L,2939L,3539L,3739L,4139L,4339L,4639L,5039L,5639L,5839L,5939L,7039L,7639L,8039L,8539L,8839L,9239L,9439L,9539L,9739L,9839L,10039L,10139L,10639L,10739L,10939L,11239L,11839L,11939L,12239L,12539L,12739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268858Inst : IEnumerable<long>
{
public static readonly long[] Value=A268858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268858.Bytes);
public long this[int i]=>Value[i];

public static A268858Inst Instance=new A268858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268859
{
public static readonly long[] Value={ 421L,521L,821L,1021L,1321L,1621L,1721L,2221L,2521L,2621L,3121L,3221L,3821L,4021L,4421L,4621L,4721L,5021L,5521L,5821L,6121L,6221L,6421L,6521L,7121L,7321L,7621L,8221L,8521L,8821L,9221L,9421L,9521L,9721L,10321L,11321L,11621L,11821L,12421L,12721L,12821L,13121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268859Inst : IEnumerable<long>
{
public static readonly long[] Value=A268859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268859.Bytes);
public long this[int i]=>Value[i];

public static A268859Inst Instance=new A268859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268860
{
public static readonly long[] Value={ 127L,227L,727L,827L,1327L,1427L,1627L,2027L,2927L,3527L,3727L,4027L,4127L,4327L,5227L,5527L,5827L,5927L,6427L,6827L,7027L,7127L,7727L,7927L,8527L,8627L,9127L,9227L,10427L,10627L,11027L,11527L,11827L,11927L,12227L,12527L,13127L,13327L,13627L,14327L,14627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268860Inst : IEnumerable<long>
{
public static readonly long[] Value=A268860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268860.Bytes);
public long this[int i]=>Value[i];

public static A268860Inst Instance=new A268860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268861
{
public static readonly long[] Value={ 7L,26L,63L,124L,215L,342L,511L,1330L,1727L,2196L,2743L,3374L,4095L,7999L,9260L,10647L,12166L,13823L,17575L,19682L,24388L,26999L,29790L,32767L,39303L,42874L,46655L,54871L,59318L,63999L,74087L,79506L,85183L,91124L,103822L,110591L,124999L,132650L,140607L,148876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268861Inst : IEnumerable<long>
{
public static readonly long[] Value=A268861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268861.Bytes);
public long this[int i]=>Value[i];

public static A268861Inst Instance=new A268861Inst();

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