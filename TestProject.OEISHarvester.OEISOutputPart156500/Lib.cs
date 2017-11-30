using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A192925
{
public static readonly long[] Value={ 0L,1L,3L,11L,51L,281L,1808L,13333L,111041L,1031758L,10588015L,118985914L,1453708722L,19189390169L,272212629009L,4130239145929L,66751752077187L,1144920631189237L,20772556460037154L,397492611715916267L,8000930139415926955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192925Inst : IEnumerable<long>
{
public static readonly long[] Value=A192925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192925.Bytes);
public long this[int i]=>Value[i];

public static A192925Inst Instance=new A192925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192926
{
public static readonly long[] Value={ 35L,133L,152L,160L,351L,370L,378L,468L,476L,495L,503L,1339L,1358L,1366L,1456L,1464L,1483L,1491L,1674L,1682L,1701L,1709L,1799L,1807L,1826L,1834L,2205L,2224L,2232L,2322L,2330L,2349L,2357L,2540L,2548L,2567L,2575L,2665L,2673L,2692L,2700L,3528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192926Inst : IEnumerable<long>
{
public static readonly long[] Value=A192926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192926.Bytes);
public long this[int i]=>Value[i];

public static A192926Inst Instance=new A192926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192927
{
public static readonly BigInteger[] Value={ 0L,0L,4L,24L,152L,1056L,7884L,62336L,516060L,4435888L,39338456L,358164768L,3335087752L,31663393880L,305740631660L,2996450625216L,29756512979124L,298991371001192L,3036071594865808L,31123847225593944L,321822051245586716L,3353854189297573504L,BigInteger.Parse("35203483037473883368"),BigInteger.Parse("371948773494408980616"),BigInteger.Parse("3953755503217954761364") };
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
public class A192927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192927Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192927.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192927.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192927Inst Instance=new A192927Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192928
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,3L,5L,6L,9L,11L,16L,20L,29L,37L,53L,69L,98L,130L,183L,245L,343L,463L,646L,877L,1220L,1664L,2310L,3161L,4381L,6009L,8319L,11430L,15811L,21751L,30070L,41405L,57216L,78836L,108906L,150130L,207346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192928Inst : IEnumerable<long>
{
public static readonly long[] Value=A192928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192928.Bytes);
public long this[int i]=>Value[i];

public static A192928Inst Instance=new A192928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192929
{
public static readonly BigInteger[] Value={ 1L,2L,6L,30L,210L,4620L,120120L,4084080L,116396280L,2677114440L,310545275040L,14440355289360L,1068586291412640L,114873026326858800L,9419588158802421600UL,BigInteger.Parse("442720643463713815200"),BigInteger.Parse("54011918502573085454400"),BigInteger.Parse("8587895041909120587249600") };
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
public class A192929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192929Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192929.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192929.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192929Inst Instance=new A192929Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192930
{
public static readonly long[] Value={ 9L,1L,5L,0L,8L,9L,6L,4L,0L,7L,9L,6L,3L,4L,2L,0L,9L,3L,4L,2L,1L,9L,8L,3L,8L,1L,4L,1L,7L,5L,9L,3L,1L,0L,7L,1L,0L,9L,2L,9L,6L,2L,8L,9L,7L,1L,4L,9L,7L,3L,8L,6L,0L,1L,1L,3L,2L,9L,2L,1L,4L,2L,0L,7L,9L,0L,5L,8L,2L,2L,1L,8L,8L,2L,2L,5L,9L,2L,4L,8L,4L,2L,3L,4L,4L,8L,0L,7L,5L,4L,0L,0L,4L,4L,4L,3L,3L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192930Inst : IEnumerable<long>
{
public static readonly long[] Value=A192930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192930.Bytes);
public long this[int i]=>Value[i];

public static A192930Inst Instance=new A192930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192931
{
public static readonly long[] Value={ 11L,13L,22L,35L,38L,41L,46L,58L,70L,75L,79L,98L,109L,125L,158L,171L,193L,237L,257L,286L,305L,462L,738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192931Inst : IEnumerable<long>
{
public static readonly long[] Value=A192931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192931.Bytes);
public long this[int i]=>Value[i];

public static A192931Inst Instance=new A192931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192932
{
public static readonly long[] Value={ 9L,0L,4L,9L,4L,25L,25L,49L,100L,144L,289L,484L,841L,1521L,2601L,4624L,8100L,14161L,24964L,43681L,76729L,134689L,236196L,414736L,727609L,1276900L,2241009L,3932289L,6901129L,12110400L,21252100L,37295449L,65448100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192932Inst : IEnumerable<long>
{
public static readonly long[] Value=A192932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192932.Bytes);
public long this[int i]=>Value[i];

public static A192932Inst Instance=new A192932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192933
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,12L,4L,16L,44L,88L,8L,40L,136L,360L,720L,16L,96L,384L,1216L,3152L,6304L,32L,224L,1024L,3712L,11296L,28896L,57792L,64L,512L,2624L,10624L,36416L,108032L,273856L,547712L,128L,1152L,6528L,29056L,109696L,362624L,1056896L,2661504L,5323008L,256L,2560L,15872L,76800L,314880L,1135616L,3659776L,10528768L,26380544L,52761088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192933Inst : IEnumerable<long>
{
public static readonly long[] Value=A192933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192933.Bytes);
public long this[int i]=>Value[i];

public static A192933Inst Instance=new A192933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192934
{
public static readonly BigInteger[] Value={ 1L,225L,22201L,5555449L,111112681L,3333330225L,555555566736L,2222222266944L,33333333393562596L,88888888888905609L,88888888888905609L,2222222222222640225L,2222222222222640225L,BigInteger.Parse("111111111111119590793871025"),BigInteger.Parse("5555555555555557064110500049"),BigInteger.Parse("11111111111111115805344390916") };
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
public class A192934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192934Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192934.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192934.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192934Inst Instance=new A192934Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192935
{
public static readonly BigInteger[] Value={ 1L,1L,4L,39L,592L,12965L,378276L,14062363L,643946920L,35426253465L,2295988778440L,172565368741931L,14847924324645996L,1446814927797156541L,BigInteger.Parse("158201328106874927980"),BigInteger.Parse("19258822568210913998955"),BigInteger.Parse("2592339296719295037808336"),BigInteger.Parse("383513887126740027040942577") };
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
public class A192935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192935Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192935.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192935.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192935Inst Instance=new A192935Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192936
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,71L,463L,3497L,29975L,287265L,3042545L,35284315L,444617525L,6048575335L,88347242335L,1378930649745L,22903345844335L,403342641729665L,7506843094993825L,147226845692229875L,3034786640911840925L,BigInteger.Parse("65592491119118514375") };
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
public class A192936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192936Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192936.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192936.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192936Inst Instance=new A192936Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192937
{
public static readonly BigInteger[] Value={ 100L,9999L,999898L,99989797L,9998979696L,999897969595L,99989796959494L,9998979695949393L,999897969594939292L,BigInteger.Parse("99989796959493929191"),BigInteger.Parse("9998979695949392919090"),BigInteger.Parse("999897969594939291908989") };
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
public class A192937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192937Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192937.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192937.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192937Inst Instance=new A192937Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192938
{
public static readonly long[] Value={ 2L,9L,0L,7L,7L,2L,9L,7L,8L,9L,6L,9L,4L,1L,1L,3L,8L,3L,7L,1L,3L,2L,5L,9L,6L,6L,9L,7L,1L,6L,4L,5L,2L,2L,2L,9L,6L,4L,8L,3L,1L,8L,9L,5L,5L,0L,0L,6L,1L,4L,6L,7L,3L,0L,3L,5L,8L,4L,6L,0L,1L,4L,8L,5L,1L,2L,8L,2L,7L,6L,9L,2L,9L,8L,4L,0L,8L,0L,0L,7L,4L,2L,1L,7L,7L,0L,4L,6L,0L,1L,6L,9L,8L,2L,9L,5L,1L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192938Inst : IEnumerable<long>
{
public static readonly long[] Value=A192938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192938.Bytes);
public long this[int i]=>Value[i];

public static A192938Inst Instance=new A192938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192939
{
public static readonly BigInteger[] Value={ 1L,2L,9L,61L,546L,6043L,79475L,1209160L,20873685L,402896615L,8595041400L,200773098515L,5095839723205L,139624739872970L,4107177047046645L,129087781738773385L,4316962772836390050L,BigInteger.Parse("153048896045632212175"),BigInteger.Parse("5733602882337419294975") };
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
public class A192939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192939Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192939.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192939.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192939Inst Instance=new A192939Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192988
{
public static readonly BigInteger[] Value={ 1L,2L,3L,4L,9L,21L,91L,1517L,385318L,24745571498L,BigInteger.Parse("102057218155974827415"),BigInteger.Parse("1735945962956039658808082636319818286550") };
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
public class A192988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192988Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192988.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192988.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192988Inst Instance=new A192988Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192989
{
public static readonly long[] Value={ 1L,3L,15L,87L,585L,4383L,35919L,318195L,3015441L,30354075L,322626159L,3603292047L,42120047385L,513557128503L,6512375759535L,85673471945067L,1166675225150241L,16413589529042355L,238151194659626319L,3558129109803374535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192989Inst : IEnumerable<long>
{
public static readonly long[] Value=A192989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192989.Bytes);
public long this[int i]=>Value[i];

public static A192989Inst Instance=new A192989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192990
{
public static readonly long[] Value={ 1L,0L,0L,6L,72L,144L,288L,0L,144L,72L,37584L,95904L,98496L,51840L,11664L,25920L,31104L,1296L,7776L,1296L,53529984L,127899648L,130761216L,69921792L,17915904L,11321856L,26002944L,23887872L,10202112L,1430784L,2985984L,2612736L,124416L,373248L,31104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192990Inst : IEnumerable<long>
{
public static readonly long[] Value=A192990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192990.Bytes);
public long this[int i]=>Value[i];

public static A192990Inst Instance=new A192990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192991
{
public static readonly long[] Value={ 8L,12L,16L,18L,20L,24L,28L,30L,32L,36L,40L,42L,44L,48L,50L,52L,56L,60L,64L,66L,68L,70L,72L,76L,78L,80L,84L,88L,92L,96L,98L,100L,102L,104L,110L,112L,114L,116L,120L,124L,128L,130L,132L,136L,138L,140L,144L,148L,152L,154L,156L,160L,164L,168L,170L,172L,174L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192991Inst : IEnumerable<long>
{
public static readonly long[] Value=A192991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192991.Bytes);
public long this[int i]=>Value[i];

public static A192991Inst Instance=new A192991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192992
{
public static readonly long[] Value={ 7L,11L,15L,17L,19L,23L,27L,29L,31L,35L,39L,41L,43L,47L,49L,51L,55L,59L,63L,65L,67L,69L,71L,75L,77L,79L,83L,87L,91L,95L,97L,99L,101L,103L,109L,111L,113L,115L,119L,123L,127L,129L,131L,135L,137L,139L,143L,147L,151L,153L,155L,159L,163L,167L,169L,171L,173L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192992Inst : IEnumerable<long>
{
public static readonly long[] Value=A192992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192992.Bytes);
public long this[int i]=>Value[i];

public static A192992Inst Instance=new A192992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192993
{
public static readonly long[] Value={ 164L,1441L,1625L,1961L,2564L,4841L,12116L,14449L,16400L,25625L,46241L,48464L,115625L,116641L,144100L,148841L,160025L,162500L,163844L,169169L,184964L,193636L,196100L,256400L,361225L,368649L,466564L,484100L,493025L,961009L,973441L,1166464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192993Inst : IEnumerable<long>
{
public static readonly long[] Value=A192993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192993.Bytes);
public long this[int i]=>Value[i];

public static A192993Inst Instance=new A192993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192994
{
public static readonly long[] Value={ 106L,117L,256L,318L,365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192994Inst : IEnumerable<long>
{
public static readonly long[] Value=A192994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192994.Bytes);
public long this[int i]=>Value[i];

public static A192994Inst Instance=new A192994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192995
{
public static readonly BigInteger[] Value={ 0L,1L,1L,5L,24L,184L,2052L,34481L,852317L,31436448L,1719054683L,139749375352L,16887682211105L,3032513808121101L,809442991768500676L,BigInteger.Parse("321179427812462958357"),BigInteger.Parse("189437827654558885755438") };
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
public class A192995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192995Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192995.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192995.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192995Inst Instance=new A192995Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192996
{
public static readonly ulong[] Value={ 0L,1L,1L,6L,35L,530L,10783L,383882L,21009035L,1882728991L,268304587720L,61675577951783L,22726670515099851L,13466905835356717045UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192996Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A192996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192996.Bytes);
public ulong this[int i]=>Value[i];

public static A192996Inst Instance=new A192996Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192997
{
public static readonly long[] Value={ 0L,1L,1L,6L,35L,675L,17727L,1019259L,90018848L,14424049245L,3763663443702L,1688522843271598L,1263001202178738616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192997Inst : IEnumerable<long>
{
public static readonly long[] Value=A192997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192997.Bytes);
public long this[int i]=>Value[i];

public static A192997Inst Instance=new A192997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192998
{
public static readonly long[] Value={ 0L,1L,1L,6L,35L,696L,19367L,1427148L,166223667L,40685390643L,16395208634778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192998Inst : IEnumerable<long>
{
public static readonly long[] Value=A192998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192998.Bytes);
public long this[int i]=>Value[i];

public static A192998Inst Instance=new A192998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192999
{
public static readonly long[] Value={ 0L,1L,1L,6L,35L,697L,19477L,1547414L,202362287L,65040382838L,35339335932669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192999Inst : IEnumerable<long>
{
public static readonly long[] Value=A192999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192999.Bytes);
public long this[int i]=>Value[i];

public static A192999Inst Instance=new A192999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193000
{
public static readonly long[] Value={ 0L,1L,1L,6L,35L,697L,19477L,1565794L,210688406L,77029067005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193000Inst : IEnumerable<long>
{
public static readonly long[] Value=A193000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193000.Bytes);
public long this[int i]=>Value[i];

public static A193000Inst Instance=new A193000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193001
{
public static readonly long[] Value={ 0L,1L,1L,6L,35L,697L,19477L,1567298L,211653572L,80504100636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193001Inst : IEnumerable<long>
{
public static readonly long[] Value=A193001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193001.Bytes);
public long this[int i]=>Value[i];

public static A193001Inst Instance=new A193001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193002
{
public static readonly long[] Value={ -3L,1L,0L,1L,0L,3L,1L,0L,2L,0L,1L,0L,1L,0L,-3L,1L,0L,0L,0L,-5L,0L,1L,0L,-1L,0L,-6L,0L,3L,1L,0L,-2L,0L,-6L,0L,8L,0L,1L,0L,-3L,0L,-5L,0L,14L,0L,-3L,1L,0L,-4L,0L,-3L,0L,20L,0L,-11L,0L,1L,0L,-5L,0L,0L,0L,25L,0L,-25L,0L,3L,1L,0L,-6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193002Inst : IEnumerable<long>
{
public static readonly long[] Value=A193002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193002.Bytes);
public long this[int i]=>Value[i];

public static A193002Inst Instance=new A193002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193003
{
public static readonly long[] Value={ 225L,576L,900L,3600L,8649L,11025L,14400L,19881L,20449L,21025L,27225L,28224L,34596L,38025L,44100L,47961L,53824L,57600L,58564L,62001L,65025L,69696L,79524L,81225L,81796L,84100L,93025L,97344L,106929L,108900L,119025L,131769L,138384L,140625L,152100L,164025L,166464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193003Inst : IEnumerable<long>
{
public static readonly long[] Value=A193003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193003.Bytes);
public long this[int i]=>Value[i];

public static A193003Inst Instance=new A193003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193084
{
public static readonly long[] Value={ 3L,0L,2L,9L,5L,8L,8L,7L,1L,4L,3L,3L,6L,2L,6L,0L,0L,1L,1L,9L,7L,5L,8L,4L,9L,8L,0L,2L,3L,5L,4L,8L,1L,1L,3L,6L,5L,2L,9L,3L,9L,1L,8L,9L,2L,1L,9L,5L,4L,7L,5L,9L,8L,1L,0L,0L,5L,2L,4L,4L,4L,4L,7L,6L,5L,9L,5L,1L,2L,9L,6L,5L,6L,8L,4L,9L,8L,4L,8L,7L,2L,3L,9L,3L,2L,3L,1L,0L,8L,4L,8L,6L,2L,6L,2L,0L,4L,0L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193084Inst : IEnumerable<long>
{
public static readonly long[] Value=A193084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193084.Bytes);
public long this[int i]=>Value[i];

public static A193084Inst Instance=new A193084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193085
{
public static readonly long[] Value={ 1L,1L,6L,6L,3L,4L,7L,3L,4L,8L,1L,9L,0L,8L,6L,4L,5L,4L,0L,4L,8L,1L,3L,2L,1L,6L,5L,5L,4L,7L,0L,2L,0L,1L,7L,2L,3L,9L,5L,9L,3L,0L,1L,2L,3L,1L,1L,8L,9L,4L,4L,5L,7L,2L,1L,4L,3L,5L,9L,2L,0L,7L,2L,5L,7L,0L,8L,4L,1L,5L,3L,4L,1L,0L,5L,8L,7L,1L,2L,2L,6L,8L,7L,1L,3L,1L,6L,0L,4L,9L,7L,5L,9L,5L,2L,9L,9L,3L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193085Inst : IEnumerable<long>
{
public static readonly long[] Value=A193085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193085.Bytes);
public long this[int i]=>Value[i];

public static A193085Inst Instance=new A193085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193086
{
public static readonly long[] Value={ 2L,3L,9L,2L,5L,2L,8L,6L,5L,9L,2L,7L,2L,4L,2L,9L,0L,9L,7L,3L,8L,7L,4L,9L,2L,1L,1L,6L,5L,8L,9L,2L,2L,7L,7L,1L,9L,8L,4L,9L,9L,5L,5L,0L,1L,4L,5L,3L,6L,9L,6L,8L,6L,8L,6L,9L,2L,7L,7L,4L,8L,7L,9L,3L,5L,5L,3L,7L,5L,2L,1L,7L,6L,8L,8L,0L,0L,2L,3L,7L,4L,2L,1L,2L,5L,7L,9L,4L,2L,1L,4L,5L,3L,5L,9L,1L,0L,0L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193086Inst : IEnumerable<long>
{
public static readonly long[] Value=A193086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193086.Bytes);
public long this[int i]=>Value[i];

public static A193086Inst Instance=new A193086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193087
{
public static readonly long[] Value={ 4L,8L,1L,2L,7L,6L,6L,6L,1L,3L,1L,5L,0L,7L,0L,8L,0L,3L,0L,0L,6L,9L,7L,2L,2L,2L,2L,9L,6L,1L,1L,3L,4L,3L,9L,6L,9L,5L,8L,4L,7L,1L,5L,9L,4L,6L,4L,5L,7L,5L,4L,6L,2L,0L,7L,2L,7L,6L,6L,6L,3L,0L,6L,2L,5L,3L,0L,0L,2L,7L,9L,3L,1L,2L,4L,7L,4L,4L,3L,9L,1L,6L,8L,7L,1L,7L,8L,9L,4L,4L,7L,5L,9L,8L,6L,8L,4L,5L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193087Inst : IEnumerable<long>
{
public static readonly long[] Value=A193087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193087.Bytes);
public long this[int i]=>Value[i];

public static A193087Inst Instance=new A193087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193088
{
public static readonly long[] Value={ 2L,9L,6L,0L,6L,7L,2L,8L,1L,1L,2L,9L,8L,0L,8L,0L,5L,1L,0L,7L,9L,7L,3L,9L,7L,7L,0L,1L,3L,9L,6L,9L,6L,3L,9L,2L,9L,1L,6L,5L,2L,7L,5L,6L,4L,7L,6L,9L,2L,8L,5L,8L,3L,3L,3L,5L,0L,7L,5L,8L,0L,7L,9L,8L,7L,6L,2L,8L,9L,2L,5L,3L,0L,4L,5L,2L,5L,8L,2L,4L,8L,8L,3L,8L,4L,4L,3L,4L,7L,1L,8L,5L,1L,6L,5L,6L,5L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193088Inst : IEnumerable<long>
{
public static readonly long[] Value=A193088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193088.Bytes);
public long this[int i]=>Value[i];

public static A193088Inst Instance=new A193088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193089
{
public static readonly long[] Value={ 5L,1L,8L,7L,2L,3L,3L,3L,8L,6L,8L,4L,9L,2L,9L,1L,9L,6L,9L,9L,3L,0L,2L,7L,7L,7L,7L,0L,3L,8L,8L,6L,5L,6L,0L,3L,0L,4L,1L,5L,2L,8L,4L,0L,5L,3L,5L,4L,2L,4L,5L,3L,7L,9L,2L,7L,2L,3L,3L,3L,6L,9L,3L,7L,4L,6L,9L,9L,7L,2L,0L,6L,8L,7L,5L,2L,5L,5L,6L,0L,8L,3L,1L,2L,8L,2L,1L,0L,5L,5L,2L,4L,0L,1L,3L,1L,5L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193089Inst : IEnumerable<long>
{
public static readonly long[] Value=A193089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193089.Bytes);
public long this[int i]=>Value[i];

public static A193089Inst Instance=new A193089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193090
{
public static readonly long[] Value={ 1L,5L,3L,4L,8L,6L,7L,2L,9L,1L,5L,3L,4L,8L,6L,7L,2L,9L,1L,5L,3L,4L,8L,6L,7L,2L,9L,1L,5L,3L,4L,8L,6L,7L,2L,9L,1L,5L,3L,4L,8L,6L,7L,2L,9L,1L,5L,3L,4L,8L,6L,7L,2L,9L,1L,5L,3L,4L,8L,6L,7L,2L,9L,1L,5L,3L,4L,8L,6L,7L,2L,9L,1L,5L,3L,4L,8L,6L,7L,2L,9L,1L,5L,3L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193090Inst : IEnumerable<long>
{
public static readonly long[] Value=A193090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193090.Bytes);
public long this[int i]=>Value[i];

public static A193090Inst Instance=new A193090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193091
{
public static readonly long[] Value={ 1L,1L,3L,1L,6L,14L,1L,9L,37L,79L,1L,12L,69L,242L,494L,1L,15L,110L,516L,1658L,3294L,1L,18L,160L,928L,3870L,11764L,22952L,1L,21L,219L,1505L,7589L,29307L,85741L,165127L,1L,24L,287L,2274L,13355L,61332L,224357L,638250L,1217270L,1L,27L,364L,3262L,21789L,115003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193091Inst : IEnumerable<long>
{
public static readonly long[] Value=A193091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193091.Bytes);
public long this[int i]=>Value[i];

public static A193091Inst Instance=new A193091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193092
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,3L,7L,13L,1L,4L,12L,32L,69L,1L,5L,18L,58L,173L,421L,1L,6L,25L,92L,321L,1058L,2867L,1L,7L,33L,135L,523L,1977L,7159L,21477L,1L,8L,42L,188L,790L,3256L,13344L,53008L,175769L,1L,9L,52L,252L,1134L,4986L,21996L,97956L,427401L,1567273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193092Inst : IEnumerable<long>
{
public static readonly long[] Value=A193092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193092.Bytes);
public long this[int i]=>Value[i];

public static A193092Inst Instance=new A193092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193093
{
public static readonly long[] Value={ 1L,2L,3L,6L,14L,19L,24L,72L,130L,169L,120L,432L,918L,1482L,1877L,720L,3000L,7224L,13140L,19846L,24675L,5040L,23760L,63600L,127104L,210726L,304006L,372611L,40320L,211680L,622080L,1350000L,2412408L,3754656L,5234114L,6340961L,362880L,2096640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193093Inst : IEnumerable<long>
{
public static readonly long[] Value=A193093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193093.Bytes);
public long this[int i]=>Value[i];

public static A193093Inst Instance=new A193093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193094
{
public static readonly long[] Value={ 1L,2L,1L,6L,4L,3L,24L,18L,16L,13L,120L,96L,90L,84L,71L,720L,600L,576L,558L,532L,461L,5040L,4320L,4200L,4128L,4050L,3908L,3447L,40320L,35280L,34560L,34200L,33888L,33462L,32540L,29093L,362880L,322560L,317520L,315360L,313800L,312096L,309330L,302436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193094Inst : IEnumerable<long>
{
public static readonly long[] Value=A193094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193094.Bytes);
public long this[int i]=>Value[i];

public static A193094Inst Instance=new A193094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193095
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193095Inst : IEnumerable<long>
{
public static readonly long[] Value=A193095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193095.Bytes);
public long this[int i]=>Value[i];

public static A193095Inst Instance=new A193095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193096
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,15L,16L,17L,18L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,42L,43L,45L,46L,47L,48L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193096Inst : IEnumerable<long>
{
public static readonly long[] Value=A193096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193096.Bytes);
public long this[int i]=>Value[i];

public static A193096Inst Instance=new A193096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193097
{
public static readonly long[] Value={ 11L,14L,19L,41L,44L,49L,91L,94L,99L,116L,125L,136L,149L,161L,169L,181L,251L,254L,259L,361L,364L,369L,416L,425L,436L,449L,464L,481L,491L,494L,499L,641L,644L,649L,811L,814L,819L,916L,925L,936L,949L,964L,981L,1001L,1004L,1009L,1100L,1121L,1144L,1169L,1196L,1211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193097Inst : IEnumerable<long>
{
public static readonly long[] Value=A193097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193097.Bytes);
public long this[int i]=>Value[i];

public static A193097Inst Instance=new A193097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193098
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,171L,2283L,39942L,874944L,23243829L,731486637L,26782956144L,1124838704976L,53567894139165L,2865318598843281L,170774893724336223L,11264050942430761881UL,BigInteger.Parse("817374450539598433587"),BigInteger.Parse("64917115563124199691834") };
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
public class A193098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193098Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193098.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193098.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193098Inst Instance=new A193098Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193099
{
public static readonly BigInteger[] Value={ 1L,1L,4L,34L,466L,9044L,230827L,7388781L,287044354L,13212057907L,707417718215L,43431362340153L,3022050938855344L,236053437141340206L,BigInteger.Parse("20532456001485751429"),BigInteger.Parse("1975258248906891145913"),BigInteger.Parse("208928124926501980596761"),BigInteger.Parse("24172548454436633069025270") };
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
public class A193099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193099Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193099.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193099.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193099Inst Instance=new A193099Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193132
{
public static readonly BigInteger[] Value={ 12L,384L,9216L,196608L,3932160L,75497472L,1409286144L,25769803776L,463856467968L,8246337208320L,145135534866432L,2533274790395904L,43910096366862336L,756604737398243328L,12970366926827028480UL,BigInteger.Parse("221360928884514619392"),BigInteger.Parse("3763135791036748529664") };
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
public class A193132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193132Inst Instance=new A193132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193133
{
public static readonly BigInteger[] Value={ 6L,384L,40500L,6635520L,1575656250L,513684799488L,220582915793352L,120795955200000000L,BigInteger.Parse("82216552273527680910"),BigInteger.Parse("68109100646400000000000"),BigInteger.Parse("67494804435374515656152124"),BigInteger.Parse("78856224336671036002906669056"),BigInteger.Parse("107280635057716632701242675781250"),BigInteger.Parse("168147940124376203057814634978344960") };
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
public class A193133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193133Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193133.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193133.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193133Inst Instance=new A193133Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193134
{
public static readonly BigInteger[] Value={ 1L,16L,4096L,2147483648L,BigInteger.Parse("14167099448608935641088"),BigInteger.Parse("99884502526333896315983085285953467624610139734016") };
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
public class A193134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193134Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193134.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193134.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193134Inst Instance=new A193134Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193135
{
public static readonly BigInteger[] Value={ 1L,1L,16L,82944L,126806761930752L,BigInteger.Parse("128639638970899317558746284032000000"),BigInteger.Parse("2382934566897117854359749541365491697135987197889852217491456000000000000000000000") };
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
public class A193135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193135Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193135.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193135.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193135Inst Instance=new A193135Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193136
{
public static readonly BigInteger[] Value={ 3L,135L,20503125L,BigInteger.Parse("119709242282867431640625"),BigInteger.Parse("39709946214287663263304759568121660162631769708241336047649383544921875") };
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
public class A193136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193136Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193136.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193136.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193136Inst Instance=new A193136Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193137
{
public static readonly BigInteger[] Value={ 1L,4L,11664L,34359738368L,BigInteger.Parse("156250000000000000000"),BigInteger.Parse("1602290118148446192720414467162112"),BigInteger.Parse("51474209353901743798532351474208319634964075249664"),BigInteger.Parse("6901746346790563787434755862277025452451108972170386555162524223799296"),BigInteger.Parse("4975485429479965133191172688112648024339045329697799688022189817696644226227176076118574759936") };
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
public class A193137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193137Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193137.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193137.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193137Inst Instance=new A193137Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193138
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193138Inst : IEnumerable<long>
{
public static readonly long[] Value=A193138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193138.Bytes);
public long this[int i]=>Value[i];

public static A193138Inst Instance=new A193138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193139
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,3L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,3L,0L,1L,0L,1L,1L,0L,0L,3L,0L,0L,1L,1L,0L,0L,1L,3L,1L,0L,0L,3L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,3L,0L,0L,1L,1L,1L,1L,0L,3L,0L,0L,0L,3L,1L,0L,1L,3L,0L,1L,1L,1L,1L,0L,1L,3L,0L,0L,1L,1L,0L,1L,0L,3L,3L,0L,0L,1L,0L,1L,1L,3L,0L,1L,1L,1L,1L,0L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193139Inst : IEnumerable<long>
{
public static readonly long[] Value=A193139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193139.Bytes);
public long this[int i]=>Value[i];

public static A193139Inst Instance=new A193139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193140
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,3L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,3L,1L,1L,0L,1L,1L,0L,0L,3L,0L,1L,1L,1L,1L,0L,1L,3L,1L,1L,0L,3L,1L,0L,1L,1L,3L,1L,0L,1L,1L,1L,0L,3L,1L,1L,1L,1L,1L,1L,0L,3L,0L,1L,0L,3L,3L,0L,1L,3L,1L,1L,1L,1L,1L,0L,1L,3L,1L,0L,1L,1L,1L,1L,0L,3L,3L,1L,0L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,0L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193140Inst : IEnumerable<long>
{
public static readonly long[] Value=A193140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193140.Bytes);
public long this[int i]=>Value[i];

public static A193140Inst Instance=new A193140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193141
{
public static readonly long[] Value={ 433L,443L,541L,673L,719L,827L,829L,881L,947L,953L,1171L,1217L,1223L,1277L,1289L,1297L,1559L,1583L,1609L,1619L,1709L,1747L,1801L,1861L,1871L,1879L,1889L,1973L,2003L,2017L,2081L,2087L,2131L,2137L,2141L,2213L,2221L,2251L,2269L,2287L,2297L,2311L,2339L,2341L,2393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193141Inst : IEnumerable<long>
{
public static readonly long[] Value=A193141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193141.Bytes);
public long this[int i]=>Value[i];

public static A193141Inst Instance=new A193141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193142
{
public static readonly long[] Value={ 79L,103L,127L,131L,139L,151L,157L,163L,167L,179L,181L,191L,193L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,293L,307L,311L,313L,317L,331L,337L,347L,349L,353L,359L,367L,373L,379L,383L,389L,397L,401L,409L,419L,421L,431L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193142Inst : IEnumerable<long>
{
public static readonly long[] Value=A193142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193142.Bytes);
public long this[int i]=>Value[i];

public static A193142Inst Instance=new A193142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193143
{
public static readonly long[] Value={ 103L,127L,139L,151L,163L,167L,179L,191L,199L,211L,223L,227L,229L,239L,241L,251L,263L,271L,277L,281L,283L,307L,311L,313L,331L,337L,347L,349L,353L,359L,367L,373L,379L,383L,389L,397L,401L,409L,419L,421L,431L,433L,439L,443L,449L,457L,461L,463L,467L,479L,487L,491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193143Inst : IEnumerable<long>
{
public static readonly long[] Value=A193143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193143.Bytes);
public long this[int i]=>Value[i];

public static A193143Inst Instance=new A193143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193144
{
public static readonly long[] Value={ 43L,211L,241L,463L,1123L,1483L,3307L,3907L,4831L,6007L,12433L,14281L,20023L,20593L,24181L,26083L,37831L,41413L,42643L,43891L,46441L,47743L,77563L,82657L,95791L,98911L,108571L,145543L,156421L,158803L,200257L,205663L,239611L,284623L,288907L,304153L,307471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193144Inst : IEnumerable<long>
{
public static readonly long[] Value=A193144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193144.Bytes);
public long this[int i]=>Value[i];

public static A193144Inst Instance=new A193144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193145
{
public static readonly long[] Value={ 0L,1L,2L,2L,16L,16L,18L,19L,512L,584L,674L,749L,912L,973L,770L,856L,65536L,65536L,65538L,65539L,65552L,65553L,65554L,65554L,69120L,69465L,68834L,69052L,68240L,68572L,67650L,67849L,33554432L,34603040L,35652098L,36700721L,37756944L,38805813L,39854162L,40903012L,42084864L,43138625L,44171426L,45225206L,46289296L,47334592L,48396610L,49441799L,52494336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193145Inst : IEnumerable<long>
{
public static readonly long[] Value=A193145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193145.Bytes);
public long this[int i]=>Value[i];

public static A193145Inst Instance=new A193145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193146
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,8L,10L,15L,20L,29L,39L,55L,75L,105L,144L,200L,275L,381L,525L,726L,1001L,1383L,1908L,2635L,3636L,5020L,6928L,9564L,13200L,18221L,25149L,34714L,47914L,66136L,91285L,126000L,173914L,240051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193146Inst : IEnumerable<long>
{
public static readonly long[] Value=A193146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193146.Bytes);
public long this[int i]=>Value[i];

public static A193146Inst Instance=new A193146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193147
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,8L,15L,26L,45L,80L,140L,245L,431L,756L,1326L,2328L,4085L,7168L,12580L,22076L,38740L,67985L,119305L,209365L,367411L,644761L,1131476L,1985603L,3484490L,6114853L,10730820L,18831276L,33046585L,57992715L,101770120L,178594110L,313410816L,549997641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193147Inst : IEnumerable<long>
{
public static readonly long[] Value=A193147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193147.Bytes);
public long this[int i]=>Value[i];

public static A193147Inst Instance=new A193147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193196
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,9L,19L,29L,57L,94L,172L,280L,519L,833L,1472L,2433L,4185L,6800L,11666L,18816L,31686L,51340L,84929L,136561L,225476L,359746L,586133L,936243L,1511650L,2397400L,3856698L,6084186L,9711492L,15299490L,24247456L,38016261L,60079125L,93752706L,147284928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193196Inst : IEnumerable<long>
{
public static readonly long[] Value=A193196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193196.Bytes);
public long this[int i]=>Value[i];

public static A193196Inst Instance=new A193196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193197
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,6L,9L,15L,22L,34L,50L,78L,119L,188L,295L,466L,728L,1134L,1742L,2659L,4018L,6037L,9018L,13443L,19993L,29749L,44274L,65976L,98372L,146781L,218922L,326290L,485476L,720817L,1067293L,1575713L,2318852L,3401845L,4975174L,7255629L,10553845L,15317091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193197Inst : IEnumerable<long>
{
public static readonly long[] Value=A193197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193197.Bytes);
public long this[int i]=>Value[i];

public static A193197Inst Instance=new A193197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193198
{
public static readonly BigInteger[] Value={ 1L,1L,4L,28L,352L,7696L,296704L,19845568L,2325071872L,472050401536L,167325747134464L,102717666720160768L,BigInteger.Parse("109887628080679616512"),BigInteger.Parse("203517277347030338768896"),BigInteger.Parse("656102983404750860283019264"),BigInteger.Parse("3660938644168893995628877692928") };
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
public class A193198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193198Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193198.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193198.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193198Inst Instance=new A193198Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193199
{
public static readonly BigInteger[] Value={ 1L,1L,5L,49L,1025L,42241L,3610625L,609251329L,210923290625L,144320565411841L,201501092228890625L,BigInteger.Parse("556475188311619534849"),BigInteger.Parse("3125896980250691972890625"),BigInteger.Parse("34751531654955460673195212801"),BigInteger.Parse("784223845648499469575195012890625") };
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
public class A193199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193199Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193199.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193199.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193199Inst Instance=new A193199Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193200
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,10L,17L,32L,54L,92L,170L,311L,555L,986L,1756L,3100L,5370L,9295L,16552L,30535L,57564L,108830L,202947L,369829L,659380L,1162254L,2053619L,3675529L,6683060L,12293599L,22697283L,41734139L,76077655L,137460434L,247056655L,444239896L,803916709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193200Inst : IEnumerable<long>
{
public static readonly long[] Value=A193200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193200.Bytes);
public long this[int i]=>Value[i];

public static A193200Inst Instance=new A193200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193201
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,18L,39L,81L,170L,355L,748L,1576L,3334L,7054L,14935L,31591L,66732L,140708L,296379L,624389L,1317807L,2790095L,5930254L,12652077L,27071714L,58019282L,124377335L,266404590L,569755992L,1216513200L,2593884456L,5526424017L,11773433242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193201Inst : IEnumerable<long>
{
public static readonly long[] Value=A193201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193201.Bytes);
public long this[int i]=>Value[i];

public static A193201Inst Instance=new A193201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193202
{
public static readonly BigInteger[] Value={ 1L,2L,0L,12L,-160L,3240L,-86688L,2922640L,-119971584L,5847901920L,-332122243200L,21653202377664L,-1601381638172160L,133036354347921024L,BigInteger.Parse("-12314128238585510400"),BigInteger.Parse("1261212911036957548800"),BigInteger.Parse("-142082122642808666185728"),BigInteger.Parse("17514853400850824425213440"),BigInteger.Parse("-2351847513553411263501035520"),BigInteger.Parse("342599734607249938595012582400") };
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
public class A193202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193202Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193202.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193202.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193202Inst Instance=new A193202Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193203
{
public static readonly BigInteger[] Value={ 1L,2L,8L,136L,8256L,1405440L,602922752L,618218766848L,1468496379454976L,7913439173996188672L,BigInteger.Parse("95288304033198904688640"),BigInteger.Parse("2534320562857451371729985536"),BigInteger.Parse("147510069367873486819642346127360"),BigInteger.Parse("18647939279377935249755798151259226112") };
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
public class A193203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193203Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193203.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193203.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193203Inst Instance=new A193203Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193204
{
public static readonly BigInteger[] Value={ 1L,2L,12L,264L,18192L,3363168L,1536410944L,1659081681024L,4119831378999040L,BigInteger.Parse("23085227981131301376"),BigInteger.Parse("287864665471943041639424"),BigInteger.Parse("7902500071635377252245854208"),BigInteger.Parse("473485024165978066993819500335104"),BigInteger.Parse("61476984240894226792319001395455369216") };
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
public class A193204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193204Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193204.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193204.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193204Inst Instance=new A193204Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193205
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,76L,1452L,45612L,2095992L,131601136L,10790109464L,1117867502280L,142679360514256L,21987281765799840L,4023859534010994768L,BigInteger.Parse("862536439626951197192"),BigInteger.Parse("214034590216271750690880"),BigInteger.Parse("60867125826968771742513120"),BigInteger.Parse("19663683837171331703090010864") };
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
public class A193205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193205.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193205Inst Instance=new A193205Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193206
{
public static readonly BigInteger[] Value={ 1L,1L,3L,21L,293L,7025L,257973L,13401901L,932658707L,83605059701L,9373165053231L,1284252646176937L,211069744296165851L,BigInteger.Parse("40975307787528699929"),BigInteger.Parse("9274936424952726229667"),BigInteger.Parse("2420958940356091360967253"),BigInteger.Parse("721771327240539119577124369") };
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
public class A193206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193206Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193206.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193206.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193206Inst Instance=new A193206Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193207
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,11L,126L,2383L,65847L,2484405L,122300214L,7600462726L,581393350442L,53649579705613L,5874521948167920L,752862908769402263L,BigInteger.Parse("111616832101497426539"),BigInteger.Parse("18952126477270139013143"),BigInteger.Parse("3653537196995939362232795"),BigInteger.Parse("793546121525181745226364532") };
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
public class A193207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193207Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193207.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193207.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193207Inst Instance=new A193207Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193208
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,80L,1209L,27737L,894103L,38403519L,2115673941L,145255332677L,12151475985497L,1216265051303224L,143479123196637632L,BigInteger.Parse("19697155685049948369"),BigInteger.Parse("3112917525687211858754"),BigInteger.Parse("561063341027596872760709"),BigInteger.Parse("114388074212705591785616006") };
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
public class A193208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193208Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193208.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193208.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193208Inst Instance=new A193208Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193209
{
public static readonly BigInteger[] Value={ 1L,1L,2L,11L,142L,3394L,128368L,7003110L,518966378L,50079318914L,6097188090560L,913799530877734L,165277883587449772L,BigInteger.Parse("35492379675559089096"),BigInteger.Parse("8926289062300717394696"),BigInteger.Parse("2598758767007565055432545"),BigInteger.Parse("867087614897934091698944876") };
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
public class A193209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193209Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193209.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193209.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193209Inst Instance=new A193209Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193210
{
public static readonly BigInteger[] Value={ 1L,1L,3L,24L,393L,11043L,473041L,28601334L,2315263942L,241478700774L,31517159612387L,5030510468876181L,963773726037574349L,BigInteger.Parse("218238081089074417113"),BigInteger.Parse("57654070089428439591645"),BigInteger.Parse("17573072391553388287162662"),BigInteger.Parse("6120849041684563565434585529") };
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
public class A193210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193210Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193210.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193210.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193210Inst Instance=new A193210Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193211
{
public static readonly long[] Value={ 1L,6L,5L,3L,7L,4L,5L,5L,1L,5L,0L,7L,7L,7L,7L,1L,9L,2L,9L,7L,0L,7L,9L,0L,6L,2L,3L,8L,3L,6L,6L,4L,5L,9L,7L,1L,4L,5L,6L,6L,2L,2L,3L,0L,7L,0L,2L,5L,1L,8L,4L,1L,6L,9L,2L,7L,0L,1L,1L,0L,5L,2L,0L,2L,9L,4L,6L,5L,6L,8L,6L,4L,8L,0L,8L,8L,3L,1L,8L,2L,7L,2L,1L,5L,6L,9L,3L,1L,5L,1L,6L,5L,0L,1L,3L,9L,8L,5L,9L,5L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193211Inst : IEnumerable<long>
{
public static readonly long[] Value=A193211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193211.Bytes);
public long this[int i]=>Value[i];

public static A193211Inst Instance=new A193211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193244
{
public static readonly long[] Value={ 16562L,28593L,35378L,43218L,54977L,94178L,106353L,122018L,134162L,137633L,149058L,181202L,195122L,198497L,235298L,235553L,264113L,264992L,300833L,318402L,324818L,364658L,384833L,439922L,457488L,462722L,514098L,522242L,566048L,611618L,624962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193244Inst : IEnumerable<long>
{
public static readonly long[] Value=A193244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193244.Bytes);
public long this[int i]=>Value[i];

public static A193244Inst Instance=new A193244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193245
{
public static readonly long[] Value={ 0L,1L,2L,11L,24L,35L,85L,175L,274L,322L,546L,720L,870L,1320L,1624L,1925L,2717L,3731L,5005L,6580L,6769L,8500L,10812L,13068L,13566L,16815L,20615L,22449L,25025L,30107L,35926L,40320L,42550L,50050L,58500L,63273L,67977L,78561L,90335L,103385L,117800L,118124L,133672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193245Inst : IEnumerable<long>
{
public static readonly long[] Value=A193245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193245.Bytes);
public long this[int i]=>Value[i];

public static A193245Inst Instance=new A193245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193246
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,10L,11L,15L,21L,24L,28L,35L,36L,45L,50L,55L,66L,78L,85L,91L,105L,120L,136L,153L,171L,175L,190L,210L,225L,231L,253L,274L,276L,300L,322L,325L,351L,378L,406L,435L,465L,496L,528L,546L,561L,595L,630L,666L,703L,720L,735L,741L,780L,820L,861L,870L,903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193246Inst : IEnumerable<long>
{
public static readonly long[] Value=A193246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193246.Bytes);
public long this[int i]=>Value[i];

public static A193246Inst Instance=new A193246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193247
{
public static readonly BigInteger[] Value={ 2L,0L,8L,192L,63776L,4294321152L,18446744022173838464UL,BigInteger.Parse("340282366920938463205120190760593525760"),BigInteger.Parse("115792089237316195423570985008687907847825466794905548626109625623336235655680") };
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
public class A193247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193247Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193247.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193247.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193247Inst Instance=new A193247Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193248
{
public static readonly long[] Value={ 1L,93L,455L,1267L,2709L,4961L,8203L,12615L,18377L,25669L,34671L,45563L,58525L,73737L,91379L,111631L,134673L,160685L,189847L,222339L,258341L,298033L,341595L,389207L,441049L,497301L,558143L,623755L,694317L,770009L,851011L,937503L,1029665L,1127677L,1231719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193248Inst : IEnumerable<long>
{
public static readonly long[] Value=A193248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193248.Bytes);
public long this[int i]=>Value[i];

public static A193248Inst Instance=new A193248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193249
{
public static readonly long[] Value={ 1L,153L,755L,2107L,4509L,8261L,13663L,21015L,30617L,42769L,57771L,75923L,97525L,122877L,152279L,186031L,224433L,267785L,316387L,370539L,430541L,496693L,569295L,648647L,735049L,828801L,930203L,1039555L,1157157L,1283309L,1418311L,1562463L,1716065L,1879417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193249Inst : IEnumerable<long>
{
public static readonly long[] Value=A193249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193249.Bytes);
public long this[int i]=>Value[i];

public static A193249Inst Instance=new A193249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193250
{
public static readonly long[] Value={ 1L,51L,245L,679L,1449L,2651L,4381L,6735L,9809L,13699L,18501L,24311L,31225L,39339L,48749L,59551L,71841L,85715L,101269L,118599L,137801L,158971L,182205L,207599L,235249L,265251L,297701L,332695L,370329L,410699L,453901L,500031L,549185L,601459L,656949L,715751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193250Inst : IEnumerable<long>
{
public static readonly long[] Value=A193250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193250.Bytes);
public long this[int i]=>Value[i];

public static A193250Inst Instance=new A193250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193251
{
public static readonly long[] Value={ 1L,123L,605L,1687L,3609L,6611L,10933L,16815L,24497L,34219L,46221L,60743L,78025L,98307L,121829L,148831L,179553L,214235L,253117L,296439L,344441L,397363L,455445L,518927L,588049L,663051L,744173L,831655L,925737L,1026659L,1134661L,1249983L,1372865L,1503547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193251Inst : IEnumerable<long>
{
public static readonly long[] Value=A193251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193251.Bytes);
public long this[int i]=>Value[i];

public static A193251Inst Instance=new A193251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193252
{
public static readonly long[] Value={ 1L,75L,365L,1015L,2169L,3971L,6565L,10095L,14705L,20539L,27741L,36455L,46825L,58995L,73109L,89311L,107745L,128555L,151885L,177879L,206681L,238435L,273285L,311375L,352849L,397851L,446525L,499015L,555465L,616019L,680821L,750015L,823745L,902155L,985389L,1073591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193252Inst : IEnumerable<long>
{
public static readonly long[] Value=A193252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193252.Bytes);
public long this[int i]=>Value[i];

public static A193252Inst Instance=new A193252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193253
{
public static readonly long[] Value={ 1L,183L,905L,2527L,5409L,9911L,16393L,25215L,36737L,51319L,69321L,91103L,117025L,147447L,182729L,223231L,269313L,321335L,379657L,444639L,516641L,596023L,683145L,778367L,882049L,994551L,1116233L,1247455L,1388577L,1539959L,1701961L,1874943L,2059265L,2255287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193253Inst : IEnumerable<long>
{
public static readonly long[] Value=A193253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193253.Bytes);
public long this[int i]=>Value[i];

public static A193253Inst Instance=new A193253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193254
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,4L,1L,4L,1L,6L,1L,4L,4L,1L,1L,1L,4L,13L,1L,4L,6L,12L,1L,6L,4L,13L,4L,8L,1L,24L,1L,6L,1L,4L,4L,13L,13L,4L,1L,6L,4L,32L,6L,4L,12L,24L,1L,32L,6L,1L,4L,14L,13L,6L,4L,13L,8L,30L,1L,24L,24L,4L,1L,4L,6L,48L,1L,12L,4L,48L,4L,13L,13L,6L,13L,24L,4L,56L,1L,40L,6L,42L,4L,1L,32L,8L,6L,12L,4L,4L,12L,24L,24L,13L,1L,4L,32L,24L,6L,31L,1L,72L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193254Inst : IEnumerable<long>
{
public static readonly long[] Value=A193254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193254.Bytes);
public long this[int i]=>Value[i];

public static A193254Inst Instance=new A193254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193255
{
public static readonly long[] Value={ 449L,2141L,2213L,3137L,4339L,4349L,4421L,5701L,9623L,13093L,14653L,16447L,16567L,22901L,27091L,36061L,41491L,45403L,45413L,45433L,50417L,52691L,54631L,54941L,55049L,56963L,57089L,58943L,60601L,61043L,61051L,63607L,65831L,66301L,67843L,68543L,72019L,73421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193255Inst : IEnumerable<long>
{
public static readonly long[] Value=A193255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193255.Bytes);
public long this[int i]=>Value[i];

public static A193255Inst Instance=new A193255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193256
{
public static readonly BigInteger[] Value={ 3L,54L,524880L,803355125990400000L,BigInteger.Parse("4800637927396055428150118355522551808000000000000000000") };
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
public class A193256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193256Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193256.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193256.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193256Inst Instance=new A193256Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193257
{
public static readonly long[] Value={ 7L,27L,169L,1217L,9512L,78030L,661458L,5740303L,50701542L,454011971L,4110416300L,37550193649L,345618860220L,3201414635780L,29816233849000L,279007258230819L,2621647966812031L,24723998785919976L,233922961602470390L,2219671974013732243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193257Inst : IEnumerable<long>
{
public static readonly long[] Value=A193257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193257.Bytes);
public long this[int i]=>Value[i];

public static A193257Inst Instance=new A193257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193258
{
public static readonly long[] Value={ 1L,3L,7L,11L,13L,27L,31L,35L,49L,61L,77L,79L,93L,101L,115L,117L,133L,163L,183L,187L,193L,235L,245L,257L,271L,279L,323L,335L,343L,381L,399L,439L,481L,497L,507L,535L,549L,569L,619L,669L,681L,693L,713L,739L,815L,833L,863L,905L,941L,973L,1033L,1053L,1089L,1119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193258Inst : IEnumerable<long>
{
public static readonly long[] Value=A193258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193258.Bytes);
public long this[int i]=>Value[i];

public static A193258Inst Instance=new A193258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193259
{
public static readonly long[] Value={ 1L,4L,5L,9L,10L,12L,13L,18L,19L,21L,22L,25L,26L,28L,29L,35L,36L,38L,39L,42L,43L,45L,46L,50L,51L,53L,54L,57L,58L,60L,61L,68L,69L,71L,72L,75L,76L,78L,79L,83L,84L,86L,87L,90L,91L,93L,94L,99L,100L,102L,103L,106L,107L,109L,110L,114L,115L,117L,118L,121L,122L,124L,125L,133L,134L,136L,137L,140L,141L,143L,144L,148L,149L,151L,152L,155L,156L,158L,159L,164L,165L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193259Inst : IEnumerable<long>
{
public static readonly long[] Value=A193259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193259.Bytes);
public long this[int i]=>Value[i];

public static A193259Inst Instance=new A193259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193292
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,4L,2L,4L,2L,3L,2L,4L,4L,8L,2L,4L,4L,16L,4L,4L,2L,12L,6L,4L,8L,16L,2L,16L,4L,16L,4L,4L,8L,32L,8L,8L,4L,64L,4L,16L,2L,32L,16L,8L,2L,48L,8L,48L,4L,16L,4L,32L,16L,96L,16L,8L,4L,192L,4L,8L,16L,64L,8L,16L,8L,32L,16L,128L,4L,256L,4L,16L,24L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193292Inst : IEnumerable<long>
{
public static readonly long[] Value=A193292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193292.Bytes);
public long this[int i]=>Value[i];

public static A193292Inst Instance=new A193292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193293
{
public static readonly long[] Value={ 1L,1L,1L,4L,6L,1L,14L,32L,18L,72L,90L,13L,234L,420L,372L,1536L,1598L,360L,4332L,12096L,5908L,18000L,28658L,2496L,93062L,122148L,106920L,473760L,514230L,142848L,1349244L,3391488L,1782180L,5708056L,11924808L,1555200L,24664200L,40504200L,31758948L,209212416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193293Inst : IEnumerable<long>
{
public static readonly long[] Value=A193293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193293.Bytes);
public long this[int i]=>Value[i];

public static A193293Inst Instance=new A193293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193294
{
public static readonly long[] Value={ 0L,0L,2L,0L,0L,14L,0L,0L,36L,0L,0L,390L,0L,0L,744L,0L,0L,5040L,0L,0L,11816L,0L,0L,154752L,0L,0L,213840L,0L,0L,1999872L,0L,0L,3564360L,0L,0L,46656000L,0L,0L,63517896L,0L,0L,526048320L,0L,0L,1465647264L,0L,0L,16665772032L,0L,0L,20377766312L,0L,0L,173039328000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193294Inst : IEnumerable<long>
{
public static readonly long[] Value=A193294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193294.Bytes);
public long this[int i]=>Value[i];

public static A193294Inst Instance=new A193294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193295
{
public static readonly long[] Value={ 1L,3L,2L,4L,2L,5L,3L,5L,3L,5L,2L,5L,3L,6L,3L,7L,2L,6L,3L,5L,3L,6L,3L,6L,5L,5L,4L,6L,2L,8L,3L,7L,4L,6L,3L,6L,3L,6L,3L,7L,2L,6L,4L,5L,4L,7L,3L,8L,4L,6L,3L,7L,3L,8L,4L,6L,3L,6L,2L,6L,4L,8L,5L,9L,3L,6L,3L,6L,3L,8L,2L,7L,4L,5L,5L,6L,3L,8L,5L,7L,5L,6L,3L,6L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193295Inst : IEnumerable<long>
{
public static readonly long[] Value=A193295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193295.Bytes);
public long this[int i]=>Value[i];

public static A193295Inst Instance=new A193295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193296
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,5L,15L,51L,191L,773L,3338L,15243L,73131L,366815L,1916260L,10394665L,58404853L,339223859L,2033188222L,12556915219L,79807729238L,521399203037L,3497978659977L,24076009827669L,169865542733652L,1227553152971419L,9079751310622581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193296Inst : IEnumerable<long>
{
public static readonly long[] Value=A193296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193296.Bytes);
public long this[int i]=>Value[i];

public static A193296Inst Instance=new A193296Inst();

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