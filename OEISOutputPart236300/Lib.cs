using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A010973
{
public static readonly long[] Value={ 1L,21L,231L,1771L,10626L,53130L,230230L,888030L,3108105L,10015005L,30045015L,84672315L,225792840L,573166440L,1391975640L,3247943160L,7307872110L,15905368710L,33578000610L,68923264410L,137846528820L,269128937220L,513791607420L,960566918220L,1761039350070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010973Inst : IEnumerable<long>
{
public static readonly long[] Value=A010973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010973.Bytes);
public long this[int i]=>Value[i];

public static A010973Inst Instance=new A010973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010990
{
public static readonly long[] Value={ 1L,38L,741L,9880L,101270L,850668L,6096454L,38320568L,215553195L,1101716330L,5178066751L,22595200368L,92263734836L,354860518600L,1292706174900L,4481381406320L,14844575908435L,47153358767970L,144079707346575L,424655979547800L,1210269541711230L,3342649210440540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010990Inst : IEnumerable<long>
{
public static readonly long[] Value=A010990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010990.Bytes);
public long this[int i]=>Value[i];

public static A010990Inst Instance=new A010990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010991
{
public static readonly long[] Value={ 1L,39L,780L,10660L,111930L,962598L,7059052L,45379620L,260932815L,1362649145L,6540715896L,29135916264L,121399651100L,476260169700L,1768966344600L,6250347750920L,21094923659355L,68248282427325L,212327989773900L,636983969321700L,1847253511032930L,5189902721473470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010991Inst : IEnumerable<long>
{
public static readonly long[] Value=A010991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010991.Bytes);
public long this[int i]=>Value[i];

public static A010991Inst Instance=new A010991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010992
{
public static readonly long[] Value={ 1L,40L,820L,11480L,123410L,1086008L,8145060L,53524680L,314457495L,1677106640L,8217822536L,37353738800L,158753389900L,635013559600L,2403979904200L,8654327655120L,29749251314475L,97997533741800L,310325523515700L,947309492837400L,2794563003870330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010992Inst : IEnumerable<long>
{
public static readonly long[] Value=A010992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010992.Bytes);
public long this[int i]=>Value[i];

public static A010992Inst Instance=new A010992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010993
{
public static readonly long[] Value={ 1L,41L,861L,12341L,135751L,1221759L,9366819L,62891499L,377348994L,2054455634L,10272278170L,47626016970L,206379406870L,841392966470L,3245372870670L,11899700525790L,41648951840265L,139646485582065L,449972009097765L,1397281501935165L,4191844505805495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010993Inst : IEnumerable<long>
{
public static readonly long[] Value=A010993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010993.Bytes);
public long this[int i]=>Value[i];

public static A010993Inst Instance=new A010993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010994
{
public static readonly long[] Value={ 1L,42L,903L,13244L,148995L,1370754L,10737573L,73629072L,450978066L,2505433700L,12777711870L,60403728840L,266783135710L,1108176102180L,4353548972850L,16253249498640L,57902201338905L,197548686920970L,647520696018735L,2044802197953900L,6236646703759395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010994Inst : IEnumerable<long>
{
public static readonly long[] Value=A010994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010994.Bytes);
public long this[int i]=>Value[i];

public static A010994Inst Instance=new A010994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010995
{
public static readonly long[] Value={ 1L,43L,946L,14190L,163185L,1533939L,12271512L,85900584L,536878650L,3042312350L,15820024220L,76223753060L,343006888770L,1451182990950L,5804731963800L,22057981462440L,79960182801345L,277508869722315L,925029565741050L,2969831763694950L,9206478467454345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010995Inst : IEnumerable<long>
{
public static readonly long[] Value=A010995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010995.Bytes);
public long this[int i]=>Value[i];

public static A010995Inst Instance=new A010995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010996
{
public static readonly long[] Value={ 1L,44L,990L,15180L,178365L,1712304L,13983816L,99884400L,636763050L,3679075400L,19499099620L,95722852680L,438729741450L,1889912732400L,7694644696200L,29752626158640L,109712808959985L,387221678682300L,1312251244423350L,4282083008118300L,13488561475572645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010996Inst : IEnumerable<long>
{
public static readonly long[] Value=A010996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010996.Bytes);
public long this[int i]=>Value[i];

public static A010996Inst Instance=new A010996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010997
{
public static readonly long[] Value={ 1L,45L,1035L,16215L,194580L,1906884L,15890700L,115775100L,752538150L,4431613550L,23930713170L,119653565850L,558383307300L,2448296039700L,10142940735900L,39895566894540L,149608375854525L,536830054536825L,1849081298960175L,6131164307078475L,19619725782651120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010997Inst : IEnumerable<long>
{
public static readonly long[] Value=A010997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010997.Bytes);
public long this[int i]=>Value[i];

public static A010997Inst Instance=new A010997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010998
{
public static readonly long[] Value={ 1L,46L,1081L,17296L,211876L,2118760L,18009460L,133784560L,886322710L,5317936260L,29248649430L,148902215280L,707285522580L,3155581562280L,13298522298180L,53194089192720L,202802465047245L,739632519584070L,2588713818544245L,8719878125622720L,28339603908273840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010998Inst : IEnumerable<long>
{
public static readonly long[] Value=A010998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010998.Bytes);
public long this[int i]=>Value[i];

public static A010998Inst Instance=new A010998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010999
{
public static readonly long[] Value={ 1L,47L,1128L,18424L,230300L,2349060L,20358520L,154143080L,1040465790L,6358402050L,35607051480L,184509266760L,891794789340L,4047376351620L,17345898649800L,70539987842520L,273342452889765L,1012974972473835L,3601688791018080L,12321566916640800L,40661170824914640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010999Inst : IEnumerable<long>
{
public static readonly long[] Value=A010999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010999.Bytes);
public long this[int i]=>Value[i];

public static A010999Inst Instance=new A010999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011000
{
public static readonly long[] Value={ 1L,48L,1176L,19600L,249900L,2598960L,22957480L,177100560L,1217566350L,7575968400L,43183019880L,227692286640L,1119487075980L,5166863427600L,22512762077400L,93052749919920L,366395202809685L,1379370175283520L,4981058966301600L,17302625882942400L,57963796707857040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011000Inst : IEnumerable<long>
{
public static readonly long[] Value=A011000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011000.Bytes);
public long this[int i]=>Value[i];

public static A011000Inst Instance=new A011000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011001
{
public static readonly long[] Value={ 1L,49L,1225L,20825L,270725L,2869685L,25827165L,202927725L,1420494075L,8996462475L,52179482355L,279871768995L,1399358844975L,6566222272575L,29078984349975L,122131734269895L,488526937079580L,1867897112363100L,6848956078664700L,24151581961607100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011001Inst : IEnumerable<long>
{
public static readonly long[] Value=A011001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011001.Bytes);
public long this[int i]=>Value[i];

public static A011001Inst Instance=new A011001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011002
{
public static readonly long[] Value={ 1L,3L,1L,6L,0L,7L,4L,0L,1L,2L,9L,5L,2L,4L,9L,2L,4L,6L,0L,8L,1L,9L,2L,1L,8L,9L,0L,1L,7L,9L,6L,9L,9L,9L,0L,5L,5L,1L,6L,0L,0L,6L,8L,5L,9L,0L,2L,0L,5L,8L,2L,2L,1L,7L,6L,7L,3L,1L,9L,2L,2L,6L,5L,8L,5L,9L,5L,8L,6L,6L,7L,9L,5L,1L,9L,7L,3L,0L,2L,1L,3L,3L,0L,5L,0L,7L,4L,3L,1L,5L,0L,2L,4L,6L,6L,0L,1L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011002Inst : IEnumerable<long>
{
public static readonly long[] Value=A011002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011002.Bytes);
public long this[int i]=>Value[i];

public static A011002Inst Instance=new A011002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011003
{
public static readonly long[] Value={ 1L,4L,9L,5L,3L,4L,8L,7L,8L,1L,2L,2L,1L,2L,2L,0L,5L,4L,1L,9L,1L,1L,8L,9L,8L,9L,9L,4L,1L,4L,0L,9L,1L,3L,3L,9L,5L,3L,6L,3L,4L,5L,9L,7L,5L,7L,6L,1L,4L,7L,0L,6L,3L,4L,5L,5L,1L,6L,5L,9L,3L,5L,0L,0L,0L,4L,7L,9L,2L,1L,4L,6L,6L,9L,7L,2L,9L,9L,7L,0L,1L,2L,8L,4L,8L,6L,2L,4L,4L,2L,5L,7L,0L,7L,4L,8L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011003Inst : IEnumerable<long>
{
public static readonly long[] Value=A011003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011003.Bytes);
public long this[int i]=>Value[i];

public static A011003Inst Instance=new A011003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011004
{
public static readonly long[] Value={ 1L,5L,6L,5L,0L,8L,4L,5L,8L,0L,0L,7L,3L,2L,8L,7L,3L,1L,6L,5L,8L,4L,4L,8L,5L,4L,9L,9L,1L,5L,8L,6L,8L,9L,8L,0L,9L,8L,1L,0L,7L,2L,6L,9L,4L,2L,7L,7L,4L,7L,8L,9L,2L,2L,2L,8L,1L,9L,8L,0L,9L,0L,9L,2L,0L,1L,0L,8L,2L,3L,4L,4L,1L,0L,5L,2L,8L,8L,2L,0L,0L,8L,7L,4L,2L,0L,3L,5L,2L,7L,1L,9L,1L,0L,4L,5L,8L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011004Inst : IEnumerable<long>
{
public static readonly long[] Value=A011004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011004.Bytes);
public long this[int i]=>Value[i];

public static A011004Inst Instance=new A011004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011005
{
public static readonly long[] Value={ 1L,6L,2L,6L,5L,7L,6L,5L,6L,1L,6L,9L,7L,7L,8L,5L,7L,4L,3L,2L,1L,1L,2L,3L,2L,3L,4L,5L,4L,9L,3L,7L,6L,0L,1L,7L,3L,0L,1L,8L,2L,7L,0L,7L,9L,2L,2L,6L,9L,4L,9L,7L,6L,1L,8L,1L,8L,7L,4L,5L,5L,5L,8L,3L,4L,8L,8L,6L,7L,6L,7L,4L,1L,1L,7L,2L,6L,8L,0L,0L,1L,8L,6L,9L,7L,3L,4L,2L,5L,6L,7L,8L,2L,3L,0L,5L,3L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011005Inst : IEnumerable<long>
{
public static readonly long[] Value=A011005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011005.Bytes);
public long this[int i]=>Value[i];

public static A011005Inst Instance=new A011005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011022
{
public static readonly long[] Value={ 2L,2L,7L,9L,5L,0L,7L,0L,5L,6L,9L,5L,4L,7L,7L,7L,6L,4L,1L,9L,9L,3L,5L,6L,3L,2L,5L,1L,9L,6L,3L,6L,3L,6L,0L,0L,6L,1L,9L,0L,3L,2L,0L,3L,4L,6L,6L,6L,1L,9L,3L,0L,9L,5L,5L,8L,3L,3L,8L,6L,5L,9L,6L,1L,1L,0L,0L,9L,6L,6L,6L,9L,9L,5L,1L,3L,1L,4L,1L,8L,1L,4L,7L,8L,3L,2L,3L,1L,8L,4L,2L,4L,9L,5L,1L,1L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011022Inst : IEnumerable<long>
{
public static readonly long[] Value=A011022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011022.Bytes);
public long this[int i]=>Value[i];

public static A011022Inst Instance=new A011022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011023
{
public static readonly long[] Value={ 2L,3L,0L,0L,3L,2L,6L,6L,3L,3L,7L,9L,1L,2L,0L,6L,0L,0L,5L,0L,8L,5L,8L,9L,2L,6L,3L,5L,6L,6L,4L,3L,5L,0L,7L,3L,4L,8L,7L,3L,9L,4L,5L,5L,9L,2L,7L,4L,8L,9L,3L,0L,7L,3L,9L,1L,0L,6L,4L,3L,4L,3L,1L,2L,9L,8L,2L,7L,8L,2L,0L,9L,8L,5L,1L,3L,0L,5L,0L,6L,5L,3L,9L,8L,1L,0L,5L,9L,0L,8L,1L,9L,3L,2L,0L,0L,5L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011023Inst : IEnumerable<long>
{
public static readonly long[] Value=A011023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011023.Bytes);
public long this[int i]=>Value[i];

public static A011023Inst Instance=new A011023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011024
{
public static readonly long[] Value={ 2L,3L,2L,0L,5L,9L,5L,7L,8L,7L,1L,0L,6L,0L,8L,3L,6L,7L,5L,7L,9L,5L,1L,6L,2L,6L,7L,2L,4L,3L,6L,1L,7L,9L,0L,7L,4L,5L,6L,6L,4L,9L,5L,0L,0L,6L,6L,6L,1L,9L,9L,3L,2L,5L,7L,4L,0L,9L,3L,0L,2L,1L,4L,9L,9L,2L,2L,5L,3L,3L,1L,7L,6L,2L,4L,6L,4L,2L,0L,2L,1L,3L,0L,8L,0L,9L,9L,9L,1L,4L,7L,8L,8L,0L,7L,5L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011024Inst : IEnumerable<long>
{
public static readonly long[] Value=A011024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011024.Bytes);
public long this[int i]=>Value[i];

public static A011024Inst Instance=new A011024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011025
{
public static readonly long[] Value={ 2L,3L,4L,0L,3L,4L,7L,3L,1L,9L,3L,2L,0L,7L,1L,5L,9L,3L,8L,4L,5L,9L,1L,4L,0L,9L,6L,8L,8L,1L,6L,6L,6L,6L,0L,1L,9L,4L,6L,3L,6L,0L,6L,1L,4L,8L,5L,8L,0L,3L,6L,2L,1L,5L,6L,6L,1L,6L,8L,2L,9L,6L,4L,4L,8L,9L,9L,4L,6L,8L,0L,5L,4L,0L,1L,1L,2L,3L,5L,7L,9L,7L,0L,8L,6L,2L,0L,4L,5L,4L,2L,9L,8L,9L,0L,8L,9L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011025Inst : IEnumerable<long>
{
public static readonly long[] Value=A011025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011025.Bytes);
public long this[int i]=>Value[i];

public static A011025Inst Instance=new A011025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011026
{
public static readonly long[] Value={ 2L,3L,5L,9L,6L,1L,1L,0L,6L,1L,7L,7L,0L,5L,6L,6L,8L,6L,6L,0L,0L,3L,8L,7L,5L,2L,8L,9L,4L,9L,9L,5L,6L,7L,9L,1L,7L,3L,7L,2L,8L,3L,0L,2L,9L,3L,4L,9L,5L,0L,2L,0L,0L,3L,7L,3L,2L,8L,1L,6L,3L,1L,3L,7L,4L,1L,6L,8L,5L,2L,3L,2L,6L,2L,8L,2L,7L,4L,3L,4L,5L,5L,0L,7L,6L,2L,9L,6L,1L,6L,6L,6L,0L,0L,1L,7L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011026Inst : IEnumerable<long>
{
public static readonly long[] Value=A011026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011026.Bytes);
public long this[int i]=>Value[i];

public static A011026Inst Instance=new A011026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011027
{
public static readonly long[] Value={ 2L,3L,7L,8L,4L,1L,4L,2L,3L,0L,0L,0L,5L,4L,4L,2L,1L,3L,3L,4L,3L,4L,9L,9L,9L,9L,4L,1L,1L,2L,0L,9L,5L,1L,8L,3L,0L,5L,8L,5L,9L,4L,4L,1L,8L,4L,9L,2L,7L,6L,3L,4L,8L,2L,6L,0L,3L,8L,0L,0L,4L,4L,4L,9L,4L,3L,8L,9L,3L,3L,3L,3L,6L,4L,5L,3L,8L,3L,4L,3L,1L,9L,7L,4L,1L,5L,6L,2L,6L,8L,9L,0L,7L,6L,2L,7L,5L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011027Inst : IEnumerable<long>
{
public static readonly long[] Value=A011027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011027.Bytes);
public long this[int i]=>Value[i];

public static A011027Inst Instance=new A011027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011028
{
public static readonly long[] Value={ 2L,3L,9L,6L,7L,8L,1L,7L,2L,6L,9L,2L,8L,4L,3L,0L,3L,0L,6L,0L,8L,7L,1L,6L,9L,4L,5L,6L,9L,4L,8L,2L,4L,9L,0L,6L,0L,3L,3L,9L,3L,4L,6L,1L,7L,4L,8L,3L,1L,4L,4L,0L,7L,1L,1L,5L,5L,9L,9L,7L,0L,6L,5L,3L,4L,7L,9L,3L,1L,6L,8L,7L,2L,7L,9L,9L,3L,1L,1L,9L,7L,4L,1L,5L,2L,1L,8L,4L,0L,8L,6L,9L,0L,5L,2L,8L,0L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011028Inst : IEnumerable<long>
{
public static readonly long[] Value=A011028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011028.Bytes);
public long this[int i]=>Value[i];

public static A011028Inst Instance=new A011028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011029
{
public static readonly long[] Value={ 2L,4L,1L,4L,7L,3L,6L,4L,0L,2L,7L,6L,6L,4L,1L,7L,9L,9L,5L,6L,0L,8L,3L,5L,7L,9L,8L,7L,0L,4L,9L,8L,1L,1L,7L,4L,8L,7L,2L,7L,1L,3L,7L,7L,7L,9L,5L,9L,2L,9L,0L,4L,7L,2L,4L,1L,8L,8L,1L,2L,0L,9L,1L,1L,2L,9L,2L,4L,1L,2L,1L,3L,3L,7L,5L,1L,1L,7L,3L,5L,2L,1L,5L,4L,6L,9L,6L,9L,4L,4L,9L,0L,7L,9L,7L,7L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011029Inst : IEnumerable<long>
{
public static readonly long[] Value=A011029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011029.Bytes);
public long this[int i]=>Value[i];

public static A011029Inst Instance=new A011029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011030
{
public static readonly long[] Value={ 2L,4L,3L,2L,2L,9L,9L,2L,7L,9L,0L,9L,7L,7L,8L,7L,3L,4L,9L,9L,5L,0L,0L,7L,2L,8L,8L,4L,4L,6L,2L,5L,3L,7L,1L,9L,1L,9L,6L,5L,3L,7L,1L,0L,3L,8L,8L,1L,8L,4L,0L,5L,8L,8L,8L,9L,8L,9L,1L,4L,8L,4L,4L,9L,4L,1L,0L,5L,6L,6L,9L,7L,4L,9L,4L,8L,8L,1L,5L,2L,5L,5L,9L,6L,7L,7L,2L,3L,4L,2L,1L,2L,9L,5L,6L,8L,4L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011030Inst : IEnumerable<long>
{
public static readonly long[] Value=A011030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011030.Bytes);
public long this[int i]=>Value[i];

public static A011030Inst Instance=new A011030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011031
{
public static readonly long[] Value={ 2L,4L,6L,6L,3L,2L,5L,7L,1L,4L,5L,5L,9L,6L,6L,0L,4L,4L,4L,8L,9L,0L,9L,5L,0L,9L,3L,4L,5L,5L,8L,2L,1L,8L,2L,7L,7L,1L,7L,7L,8L,5L,4L,0L,8L,3L,9L,7L,3L,5L,3L,7L,7L,4L,4L,9L,9L,1L,6L,3L,7L,1L,0L,2L,9L,2L,9L,1L,9L,7L,4L,1L,8L,7L,8L,5L,7L,5L,5L,8L,4L,6L,7L,2L,3L,3L,7L,0L,1L,4L,3L,1L,9L,7L,1L,1L,1L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011031Inst : IEnumerable<long>
{
public static readonly long[] Value=A011031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011031.Bytes);
public long this[int i]=>Value[i];

public static A011031Inst Instance=new A011031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011032
{
public static readonly long[] Value={ 2L,4L,8L,2L,8L,2L,3L,7L,9L,6L,1L,9L,8L,3L,8L,8L,3L,9L,0L,6L,2L,9L,6L,4L,1L,4L,4L,9L,5L,7L,7L,4L,4L,4L,1L,6L,1L,4L,7L,0L,6L,7L,2L,6L,8L,8L,3L,2L,4L,8L,4L,9L,5L,7L,6L,3L,8L,6L,0L,6L,5L,1L,0L,6L,6L,0L,6L,5L,0L,9L,4L,7L,1L,3L,5L,8L,4L,3L,6L,4L,4L,9L,8L,1L,4L,7L,5L,1L,2L,5L,5L,9L,4L,5L,8L,3L,6L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011032Inst : IEnumerable<long>
{
public static readonly long[] Value=A011032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011032.Bytes);
public long this[int i]=>Value[i];

public static A011032Inst Instance=new A011032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011033
{
public static readonly long[] Value={ 2L,4L,9L,8L,9L,9L,9L,3L,9L,9L,4L,3L,9L,3L,8L,3L,2L,5L,9L,8L,6L,2L,4L,4L,7L,7L,4L,4L,4L,0L,8L,6L,8L,9L,8L,6L,7L,3L,9L,9L,6L,3L,7L,0L,7L,8L,1L,9L,1L,9L,0L,2L,0L,9L,3L,0L,4L,0L,5L,9L,9L,5L,4L,5L,9L,3L,5L,6L,1L,7L,7L,7L,9L,7L,7L,7L,8L,3L,7L,4L,5L,8L,8L,7L,3L,7L,8L,4L,6L,7L,7L,6L,3L,7L,2L,1L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011033Inst : IEnumerable<long>
{
public static readonly long[] Value=A011033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011033.Bytes);
public long this[int i]=>Value[i];

public static A011033Inst Instance=new A011033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011034
{
public static readonly long[] Value={ 2L,5L,1L,4L,8L,6L,6L,8L,5L,9L,3L,6L,5L,8L,7L,0L,8L,1L,6L,6L,3L,5L,5L,3L,1L,0L,0L,9L,3L,1L,7L,7L,1L,5L,6L,7L,6L,5L,5L,1L,9L,3L,6L,7L,2L,8L,0L,2L,9L,7L,7L,2L,1L,9L,7L,4L,7L,4L,5L,0L,6L,7L,0L,5L,6L,3L,5L,5L,5L,9L,2L,0L,8L,5L,6L,0L,9L,6L,4L,8L,4L,8L,6L,6L,0L,8L,7L,1L,8L,0L,4L,5L,6L,5L,3L,8L,5L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011034Inst : IEnumerable<long>
{
public static readonly long[] Value=A011034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011034.Bytes);
public long this[int i]=>Value[i];

public static A011034Inst Instance=new A011034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011035
{
public static readonly long[] Value={ 2L,5L,3L,0L,4L,3L,9L,5L,3L,4L,4L,3L,5L,2L,4L,2L,8L,7L,0L,0L,0L,3L,8L,6L,0L,2L,3L,0L,3L,0L,1L,9L,1L,4L,0L,4L,0L,7L,3L,4L,6L,8L,6L,2L,8L,5L,5L,4L,8L,2L,3L,0L,6L,7L,6L,5L,1L,6L,9L,0L,5L,6L,8L,6L,4L,0L,4L,9L,1L,2L,5L,2L,8L,2L,3L,2L,5L,3L,2L,4L,1L,3L,4L,5L,1L,6L,4L,7L,6L,3L,9L,6L,6L,7L,4L,7L,0L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011035Inst : IEnumerable<long>
{
public static readonly long[] Value=A011035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011035.Bytes);
public long this[int i]=>Value[i];

public static A011035Inst Instance=new A011035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011036
{
public static readonly long[] Value={ 2L,5L,4L,5L,7L,2L,9L,8L,9L,5L,0L,2L,1L,8L,3L,0L,5L,1L,8L,2L,6L,9L,7L,8L,8L,9L,6L,0L,5L,7L,6L,2L,8L,8L,6L,8L,5L,1L,9L,6L,9L,6L,0L,8L,3L,1L,3L,0L,1L,9L,2L,7L,0L,8L,9L,4L,3L,2L,0L,6L,0L,7L,9L,3L,6L,9L,3L,7L,3L,6L,0L,0L,0L,0L,4L,3L,1L,6L,3L,6L,2L,8L,0L,9L,1L,1L,6L,0L,7L,7L,5L,8L,5L,9L,6L,3L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011036Inst : IEnumerable<long>
{
public static readonly long[] Value=A011036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011036.Bytes);
public long this[int i]=>Value[i];

public static A011036Inst Instance=new A011036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011037
{
public static readonly long[] Value={ 2L,5L,6L,0L,7L,4L,9L,6L,0L,2L,0L,3L,1L,0L,1L,4L,7L,9L,5L,0L,8L,5L,6L,0L,4L,7L,9L,7L,0L,8L,3L,5L,1L,4L,2L,1L,4L,7L,6L,7L,5L,1L,5L,2L,8L,0L,8L,8L,2L,7L,5L,7L,5L,4L,9L,6L,5L,1L,0L,8L,4L,1L,7L,8L,3L,2L,2L,2L,5L,6L,5L,3L,7L,0L,0L,4L,9L,5L,1L,7L,7L,5L,5L,3L,2L,5L,4L,1L,9L,7L,5L,9L,9L,0L,8L,8L,9L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011037Inst : IEnumerable<long>
{
public static readonly long[] Value=A011037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011037.Bytes);
public long this[int i]=>Value[i];

public static A011037Inst Instance=new A011037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011038
{
public static readonly long[] Value={ 2L,5L,7L,5L,5L,0L,9L,5L,7L,6L,9L,0L,1L,3L,9L,4L,4L,2L,0L,0L,9L,5L,4L,0L,2L,8L,1L,6L,0L,7L,6L,0L,0L,7L,0L,5L,6L,5L,0L,0L,0L,0L,6L,0L,5L,5L,6L,2L,5L,7L,1L,0L,9L,3L,8L,2L,7L,0L,1L,0L,3L,5L,1L,5L,9L,2L,8L,1L,4L,4L,9L,5L,4L,6L,5L,1L,4L,0L,4L,2L,0L,2L,5L,2L,4L,2L,1L,9L,0L,9L,5L,3L,1L,5L,4L,4L,5L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011038Inst : IEnumerable<long>
{
public static readonly long[] Value=A011038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011038.Bytes);
public long this[int i]=>Value[i];

public static A011038Inst Instance=new A011038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011039
{
public static readonly long[] Value={ 2L,5L,9L,0L,0L,2L,0L,0L,6L,4L,1L,1L,1L,3L,5L,1L,4L,5L,2L,6L,8L,4L,1L,7L,5L,3L,9L,5L,6L,7L,3L,4L,8L,9L,3L,7L,6L,1L,7L,9L,5L,8L,2L,3L,6L,5L,3L,7L,0L,6L,7L,6L,1L,4L,1L,8L,2L,2L,3L,3L,7L,3L,4L,0L,7L,1L,4L,2L,1L,0L,0L,1L,3L,7L,7L,0L,6L,7L,4L,0L,4L,8L,6L,1L,5L,7L,2L,7L,5L,7L,8L,6L,7L,4L,9L,4L,3L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011039Inst : IEnumerable<long>
{
public static readonly long[] Value=A011039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011039.Bytes);
public long this[int i]=>Value[i];

public static A011039Inst Instance=new A011039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011040
{
public static readonly long[] Value={ 2L,6L,0L,4L,2L,9L,0L,6L,8L,7L,1L,4L,0L,2L,1L,7L,8L,6L,6L,9L,3L,9L,8L,4L,6L,5L,8L,0L,2L,7L,0L,9L,3L,8L,9L,6L,8L,4L,5L,9L,0L,2L,6L,5L,5L,5L,9L,5L,7L,0L,3L,4L,3L,1L,6L,0L,1L,2L,1L,4L,2L,2L,0L,0L,0L,4L,6L,2L,5L,5L,3L,9L,7L,2L,5L,9L,7L,0L,2L,4L,2L,9L,3L,6L,6L,9L,5L,2L,5L,8L,0L,0L,9L,1L,4L,0L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011040Inst : IEnumerable<long>
{
public static readonly long[] Value=A011040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011040.Bytes);
public long this[int i]=>Value[i];

public static A011040Inst Instance=new A011040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011041
{
public static readonly long[] Value={ 2L,6L,1L,8L,3L,3L,0L,4L,9L,8L,6L,9L,5L,8L,8L,5L,4L,3L,6L,0L,1L,2L,5L,9L,5L,9L,3L,7L,1L,9L,7L,5L,3L,7L,1L,2L,4L,2L,7L,7L,0L,0L,7L,7L,7L,6L,6L,6L,6L,8L,6L,6L,4L,6L,3L,1L,6L,9L,1L,8L,7L,0L,8L,5L,2L,3L,0L,1L,2L,8L,1L,6L,9L,0L,5L,0L,2L,6L,4L,0L,0L,3L,7L,9L,8L,8L,1L,0L,0L,2L,7L,3L,9L,0L,1L,9L,7L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011041Inst : IEnumerable<long>
{
public static readonly long[] Value=A011041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011041.Bytes);
public long this[int i]=>Value[i];

public static A011041Inst Instance=new A011041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011042
{
public static readonly long[] Value={ 2L,6L,3L,2L,1L,4L,8L,0L,2L,5L,9L,0L,4L,9L,8L,4L,9L,2L,1L,6L,3L,8L,4L,3L,7L,8L,0L,3L,5L,9L,3L,9L,9L,8L,1L,1L,0L,3L,2L,0L,1L,3L,7L,1L,8L,0L,4L,1L,1L,6L,4L,4L,3L,5L,3L,4L,6L,3L,8L,4L,5L,3L,1L,7L,1L,9L,1L,7L,3L,3L,5L,9L,0L,3L,9L,4L,6L,0L,4L,2L,6L,6L,1L,0L,1L,4L,8L,6L,3L,0L,0L,4L,9L,3L,2L,0L,3L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011042Inst : IEnumerable<long>
{
public static readonly long[] Value=A011042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011042.Bytes);
public long this[int i]=>Value[i];

public static A011042Inst Instance=new A011042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011043
{
public static readonly long[] Value={ 2L,6L,5L,9L,1L,4L,7L,9L,4L,8L,4L,7L,2L,4L,9L,4L,3L,0L,8L,1L,2L,5L,1L,2L,1L,4L,2L,8L,9L,0L,3L,2L,5L,8L,0L,7L,5L,3L,0L,0L,8L,6L,9L,2L,2L,3L,8L,5L,1L,9L,5L,4L,5L,3L,3L,8L,8L,7L,8L,4L,4L,8L,6L,3L,4L,6L,0L,1L,1L,6L,0L,6L,2L,4L,8L,6L,8L,2L,5L,7L,0L,4L,5L,2L,6L,4L,9L,4L,0L,0L,3L,8L,1L,7L,4L,4L,3L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011043Inst : IEnumerable<long>
{
public static readonly long[] Value=A011043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011043.Bytes);
public long this[int i]=>Value[i];

public static A011043Inst Instance=new A011043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011044
{
public static readonly long[] Value={ 2L,6L,7L,2L,3L,4L,5L,1L,1L,7L,7L,8L,3L,7L,8L,8L,4L,1L,8L,9L,6L,8L,8L,4L,2L,9L,9L,8L,7L,4L,2L,3L,6L,3L,9L,1L,7L,3L,7L,6L,8L,8L,2L,6L,4L,9L,6L,4L,6L,2L,6L,1L,7L,1L,4L,2L,0L,9L,6L,9L,5L,1L,4L,6L,0L,8L,5L,2L,3L,5L,8L,7L,6L,7L,8L,0L,7L,6L,3L,4L,9L,2L,8L,8L,4L,3L,4L,7L,9L,1L,2L,5L,8L,2L,0L,6L,2L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011044Inst : IEnumerable<long>
{
public static readonly long[] Value=A011044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011044.Bytes);
public long this[int i]=>Value[i];

public static A011044Inst Instance=new A011044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011045
{
public static readonly long[] Value={ 2L,6L,8L,5L,3L,4L,9L,6L,1L,4L,2L,8L,2L,6L,5L,0L,2L,7L,0L,6L,0L,9L,8L,9L,4L,4L,7L,7L,4L,9L,8L,9L,6L,3L,2L,5L,3L,1L,8L,0L,6L,0L,4L,3L,0L,7L,2L,5L,4L,1L,9L,9L,9L,9L,2L,4L,2L,4L,7L,4L,9L,8L,9L,5L,2L,3L,1L,0L,6L,4L,6L,5L,3L,5L,1L,3L,1L,2L,1L,8L,2L,0L,7L,4L,0L,9L,5L,8L,6L,3L,9L,4L,3L,4L,7L,6L,3L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011045Inst : IEnumerable<long>
{
public static readonly long[] Value=A011045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011045.Bytes);
public long this[int i]=>Value[i];

public static A011045Inst Instance=new A011045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011046
{
public static readonly long[] Value={ 2L,6L,9L,8L,1L,6L,7L,8L,7L,6L,4L,0L,8L,0L,8L,5L,5L,9L,6L,6L,2L,2L,5L,9L,6L,6L,2L,8L,4L,8L,2L,7L,6L,6L,0L,8L,5L,8L,6L,1L,2L,3L,4L,7L,4L,6L,4L,2L,9L,8L,0L,8L,8L,1L,5L,6L,1L,3L,4L,7L,2L,4L,9L,4L,3L,5L,7L,0L,7L,7L,3L,1L,8L,4L,4L,1L,3L,8L,4L,9L,1L,1L,6L,4L,5L,0L,8L,9L,3L,7L,0L,1L,9L,8L,1L,5L,4L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011046Inst : IEnumerable<long>
{
public static readonly long[] Value=A011046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011046.Bytes);
public long this[int i]=>Value[i];

public static A011046Inst Instance=new A011046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011047
{
public static readonly long[] Value={ 2L,7L,1L,0L,8L,0L,6L,0L,1L,0L,8L,2L,9L,5L,3L,4L,4L,9L,5L,8L,8L,6L,6L,5L,4L,1L,5L,8L,6L,7L,4L,3L,3L,2L,5L,7L,0L,6L,6L,6L,0L,5L,1L,1L,2L,1L,8L,0L,9L,4L,3L,0L,5L,4L,7L,1L,1L,2L,9L,6L,8L,8L,5L,8L,7L,4L,0L,3L,0L,9L,3L,9L,7L,0L,7L,3L,8L,3L,4L,3L,2L,9L,4L,9L,3L,3L,1L,0L,6L,3L,6L,1L,8L,1L,2L,0L,3L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011047Inst : IEnumerable<long>
{
public static readonly long[] Value=A011047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011047.Bytes);
public long this[int i]=>Value[i];

public static A011047Inst Instance=new A011047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011048
{
public static readonly long[] Value={ 2L,7L,2L,3L,2L,6L,9L,8L,1L,5L,3L,3L,1L,5L,0L,0L,1L,5L,3L,5L,3L,9L,0L,4L,7L,1L,5L,6L,2L,5L,9L,1L,5L,7L,0L,1L,3L,0L,8L,1L,5L,4L,8L,3L,6L,0L,5L,4L,1L,5L,9L,1L,2L,4L,7L,9L,0L,1L,0L,9L,3L,6L,1L,6L,7L,8L,8L,0L,8L,1L,4L,0L,1L,8L,3L,9L,5L,1L,8L,5L,5L,9L,4L,3L,6L,0L,1L,3L,8L,6L,0L,0L,4L,3L,0L,7L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011048Inst : IEnumerable<long>
{
public static readonly long[] Value=A011048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011048.Bytes);
public long this[int i]=>Value[i];

public static A011048Inst Instance=new A011048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011049
{
public static readonly long[] Value={ 2L,7L,3L,5L,5L,6L,4L,7L,9L,9L,7L,3L,4L,7L,6L,0L,9L,4L,7L,9L,2L,1L,4L,5L,7L,7L,0L,2L,2L,4L,2L,2L,5L,2L,6L,6L,5L,7L,5L,8L,0L,0L,6L,8L,0L,4L,6L,3L,5L,1L,2L,3L,3L,2L,5L,0L,2L,9L,8L,5L,5L,3L,9L,7L,0L,4L,8L,6L,4L,2L,8L,3L,5L,9L,0L,7L,2L,9L,4L,2L,7L,3L,2L,4L,2L,0L,8L,7L,4L,5L,8L,4L,1L,9L,7L,1L,7L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011049Inst : IEnumerable<long>
{
public static readonly long[] Value=A011049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011049.Bytes);
public long this[int i]=>Value[i];

public static A011049Inst Instance=new A011049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011050
{
public static readonly long[] Value={ 2L,7L,4L,7L,6L,9L,6L,2L,0L,5L,0L,5L,4L,4L,7L,2L,4L,8L,3L,4L,7L,3L,4L,2L,6L,3L,4L,1L,8L,1L,2L,4L,7L,7L,4L,7L,3L,7L,0L,3L,4L,2L,8L,8L,4L,5L,1L,7L,5L,5L,9L,8L,5L,5L,7L,8L,4L,2L,8L,8L,8L,6L,6L,4L,0L,4L,5L,5L,0L,2L,6L,6L,6L,6L,6L,0L,4L,7L,7L,4L,7L,5L,0L,9L,7L,9L,0L,4L,9L,0L,4L,6L,7L,6L,4L,0L,8L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011050Inst : IEnumerable<long>
{
public static readonly long[] Value=A011050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011050.Bytes);
public long this[int i]=>Value[i];

public static A011050Inst Instance=new A011050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011051
{
public static readonly long[] Value={ 2L,7L,5L,9L,6L,6L,9L,0L,2L,1L,0L,7L,1L,8L,9L,4L,4L,6L,3L,0L,0L,2L,0L,2L,5L,7L,4L,4L,2L,5L,8L,2L,5L,9L,2L,5L,1L,0L,0L,4L,8L,4L,2L,8L,2L,3L,9L,7L,1L,2L,5L,3L,2L,9L,5L,4L,8L,1L,6L,6L,4L,5L,2L,4L,7L,4L,6L,6L,9L,6L,9L,5L,3L,3L,3L,9L,5L,8L,3L,8L,2L,5L,6L,6L,5L,4L,6L,4L,2L,1L,7L,7L,7L,0L,9L,9L,8L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011051Inst : IEnumerable<long>
{
public static readonly long[] Value=A011051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011051.Bytes);
public long this[int i]=>Value[i];

public static A011051Inst Instance=new A011051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011052
{
public static readonly long[] Value={ 2L,7L,7L,1L,4L,8L,8L,0L,0L,2L,4L,7L,6L,0L,3L,6L,0L,0L,8L,3L,8L,9L,5L,2L,4L,4L,5L,5L,2L,5L,4L,6L,9L,4L,0L,9L,4L,7L,4L,1L,9L,4L,1L,3L,3L,2L,0L,8L,6L,1L,2L,0L,7L,6L,5L,0L,7L,8L,2L,3L,2L,2L,9L,4L,9L,3L,5L,6L,1L,9L,4L,3L,3L,3L,2L,0L,2L,7L,3L,2L,8L,7L,0L,6L,7L,8L,9L,4L,5L,4L,1L,9L,6L,0L,7L,4L,2L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011052Inst : IEnumerable<long>
{
public static readonly long[] Value=A011052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011052.Bytes);
public long this[int i]=>Value[i];

public static A011052Inst Instance=new A011052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011053
{
public static readonly long[] Value={ 2L,7L,8L,3L,1L,5L,7L,6L,8L,3L,7L,1L,3L,7L,4L,0L,6L,0L,2L,1L,0L,7L,5L,0L,6L,4L,5L,2L,8L,5L,4L,4L,7L,4L,0L,3L,3L,9L,2L,6L,9L,9L,0L,3L,9L,2L,2L,3L,6L,6L,0L,7L,1L,1L,8L,5L,7L,1L,8L,4L,4L,2L,7L,2L,1L,2L,0L,3L,7L,0L,4L,9L,3L,9L,8L,1L,6L,7L,7L,3L,3L,1L,8L,6L,1L,5L,8L,1L,6L,7L,7L,8L,5L,0L,9L,9L,8L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011053Inst : IEnumerable<long>
{
public static readonly long[] Value=A011053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011053.Bytes);
public long this[int i]=>Value[i];

public static A011053Inst Instance=new A011053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011070
{
public static readonly long[] Value={ 2L,9L,7L,1L,8L,2L,7L,8L,6L,6L,2L,0L,0L,8L,4L,1L,5L,2L,7L,9L,3L,3L,1L,8L,3L,6L,9L,9L,3L,4L,4L,3L,0L,0L,8L,1L,0L,8L,6L,1L,3L,2L,6L,5L,0L,1L,3L,7L,2L,8L,1L,6L,9L,6L,3L,9L,9L,4L,4L,6L,6L,3L,4L,9L,1L,3L,5L,6L,8L,7L,1L,0L,4L,7L,7L,5L,5L,4L,2L,9L,8L,0L,5L,8L,4L,5L,3L,5L,1L,5L,7L,1L,5L,3L,7L,3L,5L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011070Inst : IEnumerable<long>
{
public static readonly long[] Value=A011070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011070.Bytes);
public long this[int i]=>Value[i];

public static A011070Inst Instance=new A011070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011071
{
public static readonly long[] Value={ 2L,9L,8L,1L,3L,0L,7L,5L,0L,1L,3L,0L,1L,3L,3L,1L,5L,2L,1L,2L,1L,9L,7L,9L,6L,6L,7L,4L,3L,2L,6L,3L,6L,4L,8L,0L,7L,2L,2L,0L,3L,8L,9L,0L,5L,6L,7L,6L,8L,3L,1L,9L,7L,5L,1L,8L,3L,0L,4L,7L,6L,2L,1L,8L,0L,9L,0L,3L,7L,7L,9L,3L,7L,2L,8L,0L,9L,3L,6L,6L,6L,5L,9L,2L,9L,5L,4L,0L,2L,2L,9L,5L,1L,9L,5L,4L,4L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011071Inst : IEnumerable<long>
{
public static readonly long[] Value=A011071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011071.Bytes);
public long this[int i]=>Value[i];

public static A011071Inst Instance=new A011071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011072
{
public static readonly long[] Value={ 2L,9L,9L,0L,6L,9L,7L,5L,6L,2L,4L,4L,2L,4L,4L,1L,0L,8L,3L,8L,2L,3L,7L,9L,7L,9L,8L,8L,2L,8L,1L,8L,2L,6L,7L,9L,0L,7L,2L,6L,9L,1L,9L,5L,1L,5L,2L,2L,9L,4L,1L,2L,6L,9L,1L,0L,3L,3L,1L,8L,7L,0L,0L,0L,0L,9L,5L,8L,4L,2L,9L,3L,3L,9L,4L,5L,9L,9L,4L,0L,2L,5L,6L,9L,7L,2L,4L,8L,8L,5L,1L,4L,1L,4L,9L,7L,6L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011072Inst : IEnumerable<long>
{
public static readonly long[] Value=A011072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011072.Bytes);
public long this[int i]=>Value[i];

public static A011072Inst Instance=new A011072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011073
{
public static readonly long[] Value={ 3L,0L,0L,9L,2L,1L,6L,6L,9L,8L,4L,3L,4L,5L,6L,3L,8L,2L,2L,5L,5L,9L,4L,0L,8L,5L,2L,3L,3L,7L,8L,2L,3L,5L,8L,3L,9L,6L,2L,8L,1L,1L,4L,0L,0L,2L,2L,9L,3L,1L,6L,0L,4L,5L,8L,1L,4L,3L,6L,0L,9L,1L,5L,2L,3L,9L,4L,4L,9L,5L,8L,1L,1L,7L,5L,0L,2L,4L,8L,4L,6L,1L,9L,5L,3L,4L,2L,8L,4L,0L,7L,4L,2L,0L,9L,8L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011073Inst : IEnumerable<long>
{
public static readonly long[] Value=A011073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011073.Bytes);
public long this[int i]=>Value[i];

public static A011073Inst Instance=new A011073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011074
{
public static readonly long[] Value={ 3L,0L,1L,8L,3L,4L,9L,4L,7L,9L,2L,9L,2L,3L,3L,3L,1L,8L,6L,2L,5L,5L,9L,5L,8L,9L,6L,6L,2L,5L,8L,2L,7L,8L,6L,6L,7L,9L,7L,7L,0L,2L,3L,5L,4L,0L,0L,3L,7L,4L,9L,7L,1L,4L,2L,7L,1L,0L,3L,2L,5L,2L,7L,4L,7L,9L,7L,9L,5L,9L,9L,9L,5L,2L,9L,5L,0L,9L,9L,8L,2L,0L,7L,7L,1L,0L,6L,0L,7L,2L,5L,8L,4L,8L,7L,0L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011074Inst : IEnumerable<long>
{
public static readonly long[] Value=A011074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011074.Bytes);
public long this[int i]=>Value[i];

public static A011074Inst Instance=new A011074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011075
{
public static readonly long[] Value={ 3L,0L,2L,7L,4L,0L,0L,1L,0L,4L,0L,3L,5L,0L,9L,1L,0L,3L,3L,5L,3L,9L,6L,5L,9L,1L,1L,8L,4L,7L,9L,8L,9L,0L,1L,4L,5L,5L,0L,2L,7L,2L,0L,7L,2L,6L,5L,2L,2L,2L,8L,2L,9L,8L,7L,0L,2L,2L,3L,9L,4L,4L,1L,6L,4L,2L,8L,0L,4L,4L,5L,3L,4L,4L,9L,5L,1L,7L,3L,5L,6L,0L,2L,8L,0L,2L,5L,1L,1L,3L,8L,7L,1L,8L,3L,1L,8L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011075Inst : IEnumerable<long>
{
public static readonly long[] Value=A011075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011075.Bytes);
public long this[int i]=>Value[i];

public static A011075Inst Instance=new A011075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011076
{
public static readonly long[] Value={ 3L,0L,3L,6L,3L,7L,0L,2L,7L,6L,7L,1L,0L,8L,1L,1L,0L,5L,7L,4L,6L,8L,1L,8L,0L,4L,5L,8L,8L,8L,8L,1L,0L,4L,3L,6L,6L,0L,8L,4L,5L,0L,3L,0L,4L,3L,0L,4L,5L,8L,7L,8L,3L,2L,6L,0L,0L,5L,9L,5L,2L,4L,5L,9L,2L,6L,9L,4L,5L,1L,2L,0L,9L,8L,3L,6L,9L,7L,4L,6L,6L,3L,2L,4L,1L,0L,1L,7L,6L,3L,4L,9L,5L,9L,8L,8L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011076Inst : IEnumerable<long>
{
public static readonly long[] Value=A011076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011076.Bytes);
public long this[int i]=>Value[i];

public static A011076Inst Instance=new A011076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011077
{
public static readonly long[] Value={ 3L,0L,4L,5L,2L,6L,1L,6L,4L,6L,4L,7L,5L,6L,6L,9L,2L,1L,5L,5L,0L,0L,0L,0L,6L,1L,4L,8L,1L,4L,4L,2L,5L,4L,2L,9L,1L,2L,8L,5L,8L,7L,2L,7L,2L,6L,7L,6L,3L,6L,5L,2L,8L,4L,0L,3L,6L,7L,0L,0L,9L,0L,4L,9L,7L,2L,0L,8L,0L,6L,0L,3L,9L,5L,5L,9L,5L,2L,2L,8L,1L,3L,9L,4L,4L,9L,4L,1L,0L,4L,9L,8L,8L,8L,7L,4L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011077Inst : IEnumerable<long>
{
public static readonly long[] Value=A011077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011077.Bytes);
public long this[int i]=>Value[i];

public static A011077Inst Instance=new A011077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011078
{
public static readonly long[] Value={ 3L,0L,5L,4L,0L,7L,5L,8L,0L,9L,9L,7L,7L,3L,5L,1L,4L,0L,4L,6L,3L,8L,8L,3L,2L,8L,8L,2L,0L,5L,7L,4L,8L,9L,4L,4L,7L,6L,1L,5L,0L,2L,2L,4L,7L,9L,9L,9L,8L,6L,8L,2L,1L,6L,4L,9L,0L,0L,9L,3L,0L,0L,5L,4L,6L,5L,4L,6L,5L,2L,8L,3L,5L,4L,4L,2L,6L,3L,9L,6L,7L,5L,5L,5L,5L,7L,5L,3L,0L,6L,5L,1L,6L,3L,4L,2L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011078Inst : IEnumerable<long>
{
public static readonly long[] Value=A011078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011078.Bytes);
public long this[int i]=>Value[i];

public static A011078Inst Instance=new A011078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011079
{
public static readonly long[] Value={ 3L,0L,6L,2L,8L,1L,4L,3L,1L,3L,6L,0L,8L,7L,8L,6L,0L,3L,1L,1L,8L,9L,0L,6L,0L,8L,2L,2L,9L,8L,2L,7L,0L,9L,5L,6L,6L,5L,7L,5L,3L,8L,6L,1L,2L,5L,0L,6L,7L,1L,0L,1L,9L,2L,1L,7L,3L,0L,7L,5L,6L,2L,6L,8L,5L,1L,4L,9L,6L,6L,9L,8L,9L,9L,4L,3L,9L,3L,0L,7L,6L,4L,8L,0L,6L,1L,7L,0L,5L,7L,4L,4L,3L,0L,0L,0L,3L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011079Inst : IEnumerable<long>
{
public static readonly long[] Value=A011079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011079.Bytes);
public long this[int i]=>Value[i];

public static A011079Inst Instance=new A011079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011080
{
public static readonly long[] Value={ 3L,0L,7L,1L,4L,7L,8L,6L,5L,5L,6L,4L,0L,7L,3L,2L,8L,8L,9L,2L,7L,1L,8L,8L,0L,9L,6L,3L,5L,0L,7L,4L,5L,2L,4L,4L,6L,4L,6L,4L,2L,9L,6L,8L,8L,7L,1L,6L,0L,2L,0L,1L,8L,4L,6L,1L,7L,4L,7L,8L,7L,9L,5L,8L,6L,8L,6L,6L,2L,4L,1L,4L,8L,0L,2L,9L,7L,9L,3L,2L,4L,5L,0L,7L,4L,4L,1L,7L,8L,5L,3L,8L,7L,2L,4L,9L,1L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011080Inst : IEnumerable<long>
{
public static readonly long[] Value=A011080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011080.Bytes);
public long this[int i]=>Value[i];

public static A011080Inst Instance=new A011080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011081
{
public static readonly long[] Value={ 3L,0L,8L,0L,0L,7L,0L,2L,8L,8L,2L,4L,1L,0L,2L,2L,9L,1L,7L,1L,9L,1L,7L,1L,7L,7L,6L,6L,8L,4L,5L,7L,3L,9L,9L,1L,1L,4L,5L,7L,1L,9L,8L,7L,7L,6L,5L,7L,6L,4L,0L,3L,4L,8L,1L,6L,4L,2L,7L,9L,6L,6L,1L,5L,8L,4L,6L,3L,8L,8L,9L,0L,8L,2L,9L,7L,2L,4L,5L,1L,7L,9L,7L,2L,5L,4L,3L,9L,3L,5L,2L,5L,3L,5L,0L,0L,8L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011081Inst : IEnumerable<long>
{
public static readonly long[] Value=A011081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011081.Bytes);
public long this[int i]=>Value[i];

public static A011081Inst Instance=new A011081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011082
{
public static readonly long[] Value={ 3L,0L,8L,8L,5L,9L,0L,6L,1L,9L,3L,8L,7L,6L,6L,1L,1L,7L,3L,9L,4L,2L,0L,5L,7L,9L,1L,8L,6L,9L,1L,4L,4L,6L,1L,9L,0L,1L,8L,0L,7L,3L,7L,5L,4L,9L,5L,4L,1L,9L,3L,0L,1L,6L,2L,9L,7L,2L,6L,4L,1L,7L,3L,8L,8L,6L,4L,9L,5L,1L,3L,2L,6L,5L,4L,6L,3L,5L,0L,0L,5L,0L,4L,4L,2L,3L,1L,4L,0L,6L,3L,8L,8L,2L,7L,7L,4L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011082Inst : IEnumerable<long>
{
public static readonly long[] Value=A011082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011082.Bytes);
public long this[int i]=>Value[i];

public static A011082Inst Instance=new A011082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011083
{
public static readonly long[] Value={ 3L,0L,9L,7L,0L,4L,1L,0L,1L,4L,6L,8L,2L,4L,7L,2L,5L,3L,8L,7L,2L,6L,4L,6L,1L,2L,0L,5L,6L,9L,0L,9L,6L,9L,7L,0L,1L,4L,8L,3L,7L,0L,7L,2L,3L,6L,5L,5L,0L,1L,6L,2L,3L,3L,1L,3L,0L,5L,4L,6L,7L,7L,0L,7L,5L,6L,2L,7L,9L,2L,1L,0L,2L,2L,0L,2L,5L,8L,1L,9L,3L,3L,6L,7L,9L,8L,3L,8L,2L,7L,7L,3L,8L,1L,1L,9L,8L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011083Inst : IEnumerable<long>
{
public static readonly long[] Value=A011083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011083.Bytes);
public long this[int i]=>Value[i];

public static A011083Inst Instance=new A011083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011084
{
public static readonly long[] Value={ 3L,1L,0L,5L,4L,2L,2L,7L,9L,9L,0L,7L,1L,4L,8L,1L,5L,0L,5L,6L,5L,8L,0L,8L,3L,7L,3L,2L,2L,8L,5L,6L,1L,4L,0L,5L,4L,2L,0L,3L,0L,9L,7L,8L,9L,0L,2L,2L,6L,6L,2L,3L,3L,1L,3L,9L,9L,0L,7L,9L,5L,4L,8L,6L,1L,2L,9L,4L,4L,4L,7L,2L,8L,7L,2L,7L,9L,7L,3L,0L,5L,0L,5L,7L,6L,6L,5L,9L,0L,4L,6L,0L,4L,0L,1L,7L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011084Inst : IEnumerable<long>
{
public static readonly long[] Value=A011084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011084.Bytes);
public long this[int i]=>Value[i];

public static A011084Inst Instance=new A011084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011085
{
public static readonly long[] Value={ 3L,1L,1L,3L,7L,3L,7L,2L,5L,8L,4L,7L,7L,7L,6L,9L,8L,3L,3L,7L,0L,6L,4L,7L,2L,7L,9L,2L,0L,6L,7L,1L,2L,7L,3L,8L,1L,3L,0L,1L,8L,5L,8L,1L,9L,8L,4L,8L,5L,6L,2L,9L,0L,5L,9L,6L,8L,2L,0L,3L,9L,9L,7L,2L,3L,7L,8L,3L,7L,2L,5L,8L,7L,3L,2L,8L,6L,0L,2L,2L,8L,9L,5L,1L,5L,8L,7L,1L,0L,8L,9L,6L,0L,0L,3L,5L,9L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011085Inst : IEnumerable<long>
{
public static readonly long[] Value=A011085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011085.Bytes);
public long this[int i]=>Value[i];

public static A011085Inst Instance=new A011085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011102
{
public static readonly long[] Value={ 1L,7L,6L,2L,3L,4L,0L,3L,4L,7L,8L,3L,2L,3L,1L,7L,0L,1L,3L,8L,6L,1L,0L,0L,2L,2L,5L,3L,5L,6L,4L,8L,6L,9L,9L,2L,8L,0L,8L,3L,0L,2L,9L,2L,8L,1L,9L,5L,8L,1L,6L,0L,8L,9L,7L,2L,3L,3L,2L,3L,1L,2L,3L,3L,0L,1L,8L,9L,5L,3L,7L,8L,8L,7L,2L,6L,4L,2L,9L,5L,7L,3L,1L,2L,7L,3L,9L,3L,0L,0L,1L,7L,0L,8L,9L,8L,6L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011102Inst : IEnumerable<long>
{
public static readonly long[] Value=A011102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011102.Bytes);
public long this[int i]=>Value[i];

public static A011102Inst Instance=new A011102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011103
{
public static readonly long[] Value={ 1L,7L,8L,2L,6L,0L,2L,4L,5L,7L,9L,6L,6L,0L,0L,3L,3L,5L,5L,4L,9L,4L,8L,8L,7L,4L,7L,2L,1L,4L,0L,0L,8L,6L,6L,1L,0L,6L,3L,5L,8L,9L,5L,6L,9L,4L,7L,2L,7L,9L,9L,5L,8L,6L,0L,1L,4L,4L,1L,2L,2L,1L,5L,4L,9L,7L,2L,5L,2L,8L,8L,8L,1L,5L,6L,0L,5L,9L,0L,6L,4L,3L,4L,0L,9L,5L,8L,2L,3L,3L,3L,0L,4L,8L,4L,4L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011103Inst : IEnumerable<long>
{
public static readonly long[] Value=A011103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011103.Bytes);
public long this[int i]=>Value[i];

public static A011103Inst Instance=new A011103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011104
{
public static readonly long[] Value={ 1L,8L,0L,1L,9L,8L,3L,1L,2L,7L,3L,1L,7L,1L,4L,2L,3L,0L,5L,1L,8L,2L,5L,5L,3L,9L,5L,2L,9L,6L,1L,8L,9L,0L,2L,5L,8L,9L,4L,3L,7L,0L,9L,7L,0L,2L,2L,8L,0L,0L,5L,3L,2L,6L,8L,0L,3L,7L,2L,5L,2L,0L,3L,0L,4L,2L,9L,4L,0L,7L,6L,2L,3L,5L,6L,3L,0L,6L,7L,0L,2L,6L,6L,8L,8L,0L,4L,4L,2L,5L,7L,5L,4L,4L,4L,8L,3L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011104Inst : IEnumerable<long>
{
public static readonly long[] Value=A011104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011104.Bytes);
public long this[int i]=>Value[i];

public static A011104Inst Instance=new A011104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011105
{
public static readonly long[] Value={ 1L,8L,2L,0L,5L,6L,4L,2L,0L,3L,0L,2L,6L,0L,8L,0L,2L,6L,4L,3L,7L,9L,4L,2L,1L,0L,5L,4L,7L,0L,5L,4L,6L,2L,9L,8L,4L,9L,3L,7L,6L,8L,7L,4L,2L,7L,9L,5L,8L,8L,4L,5L,1L,4L,5L,8L,2L,1L,7L,2L,4L,1L,8L,2L,6L,9L,6L,9L,2L,3L,8L,5L,3L,5L,8L,6L,6L,9L,0L,9L,9L,2L,9L,0L,1L,4L,8L,9L,1L,9L,1L,3L,0L,3L,5L,8L,7L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011105Inst : IEnumerable<long>
{
public static readonly long[] Value=A011105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011105.Bytes);
public long this[int i]=>Value[i];

public static A011105Inst Instance=new A011105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011106
{
public static readonly long[] Value={ 1L,8L,3L,8L,4L,1L,6L,2L,8L,7L,2L,5L,2L,5L,4L,4L,0L,3L,6L,7L,0L,2L,7L,9L,8L,8L,0L,7L,1L,8L,4L,2L,2L,4L,0L,4L,2L,0L,4L,6L,7L,5L,4L,0L,3L,5L,4L,0L,4L,3L,0L,1L,7L,1L,2L,7L,3L,9L,6L,7L,8L,6L,4L,0L,5L,1L,3L,3L,5L,2L,9L,4L,1L,4L,0L,6L,3L,8L,5L,6L,8L,3L,6L,0L,7L,6L,9L,5L,4L,9L,7L,7L,6L,2L,1L,3L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011106Inst : IEnumerable<long>
{
public static readonly long[] Value=A011106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011106.Bytes);
public long this[int i]=>Value[i];

public static A011106Inst Instance=new A011106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011107
{
public static readonly long[] Value={ 1L,8L,5L,5L,6L,0L,0L,7L,3L,6L,2L,5L,8L,0L,8L,4L,3L,3L,4L,7L,3L,2L,7L,7L,0L,5L,2L,1L,3L,2L,1L,6L,7L,4L,7L,9L,4L,5L,9L,9L,4L,9L,0L,5L,3L,7L,1L,5L,1L,9L,1L,8L,5L,0L,9L,1L,6L,3L,3L,2L,1L,3L,1L,7L,9L,8L,1L,5L,0L,1L,0L,7L,6L,9L,7L,0L,9L,2L,8L,3L,9L,0L,2L,3L,0L,1L,9L,7L,1L,5L,2L,0L,6L,6L,5L,3L,1L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011107Inst : IEnumerable<long>
{
public static readonly long[] Value=A011107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011107.Bytes);
public long this[int i]=>Value[i];

public static A011107Inst Instance=new A011107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011108
{
public static readonly long[] Value={ 1L,8L,7L,2L,1L,7L,1L,2L,3L,0L,5L,5L,4L,8L,5L,7L,4L,1L,6L,6L,9L,5L,6L,5L,7L,8L,8L,1L,4L,5L,1L,9L,4L,3L,2L,0L,0L,9L,7L,2L,8L,6L,6L,4L,6L,7L,0L,8L,7L,9L,2L,9L,1L,7L,4L,0L,2L,7L,1L,3L,0L,0L,2L,7L,5L,1L,8L,2L,4L,6L,2L,0L,8L,3L,6L,4L,7L,0L,1L,3L,2L,3L,0L,9L,4L,8L,9L,4L,9L,9L,7L,3L,6L,8L,6L,1L,8L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011108Inst : IEnumerable<long>
{
public static readonly long[] Value=A011108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011108.Bytes);
public long this[int i]=>Value[i];

public static A011108Inst Instance=new A011108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011109
{
public static readonly long[] Value={ 1L,8L,8L,8L,1L,7L,5L,0L,2L,2L,5L,8L,9L,8L,0L,3L,9L,6L,4L,3L,2L,8L,1L,2L,9L,4L,8L,9L,4L,5L,5L,5L,0L,5L,5L,1L,2L,4L,5L,2L,3L,8L,7L,4L,0L,4L,2L,3L,0L,0L,3L,0L,6L,7L,1L,5L,0L,2L,0L,9L,9L,7L,9L,0L,7L,0L,5L,5L,8L,6L,4L,8L,6L,5L,1L,3L,7L,8L,8L,9L,9L,6L,3L,1L,2L,8L,7L,7L,6L,3L,0L,3L,1L,8L,7L,1L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011109Inst : IEnumerable<long>
{
public static readonly long[] Value=A011109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011109.Bytes);
public long this[int i]=>Value[i];

public static A011109Inst Instance=new A011109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011110
{
public static readonly long[] Value={ 1L,9L,0L,3L,6L,5L,3L,9L,3L,8L,7L,1L,5L,8L,7L,8L,4L,8L,9L,8L,9L,6L,1L,4L,7L,2L,8L,8L,1L,1L,9L,0L,9L,7L,7L,7L,8L,6L,5L,5L,0L,6L,2L,5L,8L,6L,1L,0L,8L,5L,6L,0L,5L,5L,2L,5L,8L,2L,3L,6L,1L,6L,8L,6L,9L,7L,2L,1L,1L,8L,2L,6L,3L,4L,4L,4L,6L,0L,5L,7L,8L,6L,9L,4L,4L,1L,9L,6L,2L,2L,5L,8L,4L,2L,2L,2L,3L,0L,4L,9L,9L,8L,5L,2L,4L,1L,1L,7L,6L,1L,4L,6L,6L,2L,6L,2L,7L,8L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011110Inst : IEnumerable<long>
{
public static readonly long[] Value=A011110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011110.Bytes);
public long this[int i]=>Value[i];

public static A011110Inst Instance=new A011110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011111
{
public static readonly long[] Value={ 1L,9L,1L,8L,6L,4L,5L,1L,9L,1L,6L,2L,5L,3L,0L,6L,2L,4L,7L,8L,6L,4L,2L,7L,8L,5L,6L,7L,1L,8L,5L,7L,3L,3L,0L,8L,8L,4L,2L,1L,5L,0L,6L,5L,2L,8L,6L,9L,4L,2L,8L,9L,2L,8L,2L,0L,2L,4L,2L,0L,8L,2L,2L,9L,5L,2L,3L,3L,5L,8L,0L,2L,9L,4L,9L,5L,4L,7L,5L,2L,6L,1L,1L,9L,1L,5L,5L,3L,8L,7L,7L,6L,0L,4L,9L,5L,7L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011111Inst : IEnumerable<long>
{
public static readonly long[] Value=A011111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011111.Bytes);
public long this[int i]=>Value[i];

public static A011111Inst Instance=new A011111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011112
{
public static readonly long[] Value={ 1L,9L,3L,3L,1L,8L,2L,0L,4L,4L,9L,3L,1L,7L,6L,2L,7L,5L,1L,5L,2L,4L,8L,7L,8L,9L,4L,3L,2L,6L,6L,1L,6L,8L,1L,4L,6L,0L,6L,1L,8L,6L,0L,6L,2L,8L,4L,0L,2L,3L,0L,6L,8L,2L,4L,6L,3L,8L,5L,4L,6L,8L,8L,0L,4L,9L,8L,3L,9L,4L,6L,9L,0L,7L,5L,6L,5L,3L,7L,3L,0L,8L,1L,6L,6L,4L,3L,1L,1L,3L,6L,5L,2L,4L,5L,1L,2L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011112Inst : IEnumerable<long>
{
public static readonly long[] Value=A011112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011112.Bytes);
public long this[int i]=>Value[i];

public static A011112Inst Instance=new A011112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011113
{
public static readonly long[] Value={ 1L,9L,4L,7L,2L,9L,4L,3L,6L,1L,2L,3L,0L,3L,3L,6L,2L,7L,3L,0L,5L,2L,4L,1L,0L,2L,1L,1L,8L,4L,2L,6L,6L,8L,4L,6L,6L,8L,3L,8L,7L,1L,7L,6L,2L,1L,9L,9L,4L,5L,4L,1L,5L,9L,0L,9L,7L,0L,9L,1L,1L,7L,5L,3L,1L,2L,3L,9L,1L,4L,4L,7L,5L,2L,5L,4L,9L,5L,6L,6L,5L,3L,9L,5L,5L,5L,5L,2L,4L,6L,3L,4L,2L,2L,8L,1L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011113Inst : IEnumerable<long>
{
public static readonly long[] Value=A011113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011113.Bytes);
public long this[int i]=>Value[i];

public static A011113Inst Instance=new A011113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011114
{
public static readonly long[] Value={ 1L,9L,6L,1L,0L,0L,9L,0L,5L,7L,4L,5L,4L,5L,4L,8L,0L,1L,3L,2L,0L,6L,3L,5L,6L,8L,5L,0L,0L,9L,7L,8L,2L,4L,1L,4L,3L,7L,6L,7L,8L,1L,3L,9L,3L,1L,6L,8L,9L,0L,8L,9L,6L,0L,7L,7L,7L,3L,6L,3L,9L,9L,8L,2L,9L,1L,3L,2L,2L,1L,1L,0L,6L,8L,0L,9L,6L,6L,2L,7L,1L,8L,0L,9L,0L,4L,8L,4L,4L,6L,1L,0L,9L,0L,1L,8L,7L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011114Inst : IEnumerable<long>
{
public static readonly long[] Value=A011114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011114.Bytes);
public long this[int i]=>Value[i];

public static A011114Inst Instance=new A011114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011115
{
public static readonly long[] Value={ 1L,9L,7L,4L,3L,5L,0L,4L,8L,5L,8L,3L,4L,8L,1L,9L,8L,4L,2L,6L,7L,2L,8L,3L,6L,1L,7L,2L,4L,0L,8L,4L,5L,3L,1L,8L,2L,6L,8L,2L,2L,6L,7L,2L,4L,8L,0L,9L,5L,3L,5L,4L,7L,1L,6L,7L,9L,4L,0L,7L,7L,9L,4L,3L,3L,9L,4L,2L,4L,7L,1L,9L,8L,1L,0L,7L,0L,2L,1L,2L,4L,6L,1L,4L,5L,3L,2L,3L,2L,4L,9L,7L,8L,2L,4L,3L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011115Inst : IEnumerable<long>
{
public static readonly long[] Value=A011115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011115.Bytes);
public long this[int i]=>Value[i];

public static A011115Inst Instance=new A011115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011116
{
public static readonly long[] Value={ 1L,9L,8L,7L,3L,4L,0L,7L,5L,4L,6L,6L,4L,4L,5L,7L,9L,5L,8L,5L,6L,6L,3L,0L,3L,6L,7L,3L,6L,0L,7L,4L,5L,9L,6L,7L,5L,0L,5L,1L,3L,2L,6L,1L,8L,4L,6L,2L,2L,4L,5L,6L,4L,6L,1L,4L,0L,9L,6L,7L,0L,4L,5L,0L,3L,9L,1L,3L,7L,0L,0L,4L,0L,5L,2L,5L,8L,3L,1L,6L,8L,7L,9L,8L,2L,5L,2L,2L,2L,1L,2L,8L,6L,7L,3L,4L,7L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011116Inst : IEnumerable<long>
{
public static readonly long[] Value=A011116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011116.Bytes);
public long this[int i]=>Value[i];

public static A011116Inst Instance=new A011116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011117
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,3L,7L,11L,1L,4L,12L,28L,45L,1L,5L,18L,52L,121L,197L,1L,6L,25L,84L,237L,550L,903L,1L,7L,33L,125L,403L,1119L,2591L,4279L,1L,8L,42L,176L,630L,1976L,5424L,12536L,20793L,1L,9L,52L,238L,930L,3206L,9860L,26832L,61921L,103049L,1L,10L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011117Inst : IEnumerable<long>
{
public static readonly long[] Value=A011117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011117.Bytes);
public long this[int i]=>Value[i];

public static A011117Inst Instance=new A011117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011134
{
public static readonly long[] Value={ 2L,1L,7L,7L,9L,0L,6L,4L,2L,4L,4L,8L,2L,7L,7L,9L,8L,9L,4L,6L,6L,5L,2L,6L,4L,8L,3L,5L,5L,7L,5L,2L,0L,7L,1L,0L,7L,0L,1L,0L,6L,6L,6L,4L,8L,6L,0L,9L,6L,1L,6L,2L,0L,2L,1L,7L,7L,7L,9L,0L,8L,8L,1L,8L,5L,1L,9L,1L,4L,9L,3L,6L,7L,1L,3L,6L,9L,2L,4L,3L,5L,4L,5L,2L,0L,6L,2L,4L,3L,7L,9L,7L,5L,4L,5L,5L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011134Inst : IEnumerable<long>
{
public static readonly long[] Value=A011134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011134.Bytes);
public long this[int i]=>Value[i];

public static A011134Inst Instance=new A011134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011135
{
public static readonly long[] Value={ 2L,1L,8L,6L,7L,2L,4L,1L,4L,7L,8L,8L,6L,5L,5L,6L,1L,1L,2L,7L,3L,7L,5L,2L,8L,8L,9L,6L,0L,7L,1L,2L,8L,5L,6L,4L,4L,8L,6L,6L,2L,2L,2L,6L,7L,7L,6L,5L,7L,9L,9L,8L,4L,2L,5L,7L,3L,4L,0L,1L,4L,7L,1L,2L,6L,2L,4L,0L,8L,2L,7L,4L,3L,9L,6L,5L,5L,6L,0L,8L,8L,3L,6L,3L,7L,7L,3L,0L,9L,8L,6L,1L,3L,6L,2L,0L,6L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011135Inst : IEnumerable<long>
{
public static readonly long[] Value=A011135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011135.Bytes);
public long this[int i]=>Value[i];

public static A011135Inst Instance=new A011135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011136
{
public static readonly long[] Value={ 2L,1L,9L,5L,4L,0L,1L,8L,9L,7L,4L,2L,7L,4L,8L,9L,9L,0L,6L,5L,6L,3L,6L,7L,9L,4L,3L,0L,4L,5L,5L,5L,3L,0L,1L,0L,3L,5L,3L,6L,0L,0L,8L,7L,7L,7L,3L,1L,0L,5L,2L,4L,6L,0L,7L,0L,6L,2L,1L,3L,9L,0L,2L,9L,8L,3L,2L,8L,1L,0L,6L,6L,1L,6L,7L,9L,9L,4L,1L,6L,3L,4L,3L,9L,6L,3L,1L,6L,2L,7L,9L,7L,3L,9L,4L,6L,1L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011136Inst : IEnumerable<long>
{
public static readonly long[] Value=A011136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011136.Bytes);
public long this[int i]=>Value[i];

public static A011136Inst Instance=new A011136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011137
{
public static readonly long[] Value={ 2L,2L,0L,3L,9L,4L,4L,5L,7L,5L,4L,4L,2L,9L,6L,0L,2L,9L,3L,3L,4L,3L,9L,0L,2L,9L,2L,1L,4L,5L,2L,7L,9L,8L,6L,1L,3L,3L,3L,8L,4L,9L,7L,4L,7L,0L,1L,9L,8L,7L,1L,7L,8L,6L,2L,7L,1L,7L,8L,3L,2L,8L,5L,0L,9L,5L,2L,2L,0L,7L,3L,3L,3L,7L,0L,0L,8L,6L,2L,0L,5L,2L,9L,8L,2L,0L,2L,4L,8L,0L,4L,5L,9L,4L,1L,3L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011137Inst : IEnumerable<long>
{
public static readonly long[] Value=A011137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011137.Bytes);
public long this[int i]=>Value[i];

public static A011137Inst Instance=new A011137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011138
{
public static readonly long[] Value={ 2L,2L,1L,2L,3L,5L,6L,8L,2L,2L,2L,7L,6L,1L,1L,6L,7L,4L,0L,0L,4L,6L,6L,2L,0L,2L,9L,0L,7L,8L,1L,3L,4L,5L,2L,0L,9L,1L,0L,3L,2L,4L,9L,6L,3L,1L,0L,3L,3L,8L,8L,3L,0L,2L,5L,2L,1L,4L,2L,2L,0L,3L,1L,6L,4L,3L,8L,0L,1L,1L,5L,7L,2L,8L,1L,2L,6L,5L,8L,2L,1L,3L,0L,7L,6L,6L,8L,4L,3L,5L,6L,7L,6L,4L,7L,6L,6L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011138Inst : IEnumerable<long>
{
public static readonly long[] Value=A011138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011138.Bytes);
public long this[int i]=>Value[i];

public static A011138Inst Instance=new A011138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011139
{
public static readonly long[] Value={ 2L,2L,2L,0L,6L,4L,3L,0L,3L,4L,9L,2L,2L,9L,2L,0L,0L,8L,8L,3L,0L,6L,6L,6L,3L,0L,5L,0L,8L,4L,6L,0L,5L,5L,0L,3L,2L,4L,3L,3L,9L,1L,9L,8L,5L,2L,8L,5L,3L,9L,1L,5L,0L,9L,2L,0L,3L,8L,9L,3L,1L,8L,8L,1L,2L,6L,1L,5L,3L,7L,7L,9L,3L,7L,4L,4L,5L,9L,2L,6L,5L,9L,5L,3L,2L,2L,3L,0L,2L,6L,7L,7L,1L,2L,4L,2L,7L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011139Inst : IEnumerable<long>
{
public static readonly long[] Value=A011139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011139.Bytes);
public long this[int i]=>Value[i];

public static A011139Inst Instance=new A011139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011140
{
public static readonly long[] Value={ 2L,2L,2L,8L,8L,0L,7L,3L,8L,4L,0L,3L,3L,5L,1L,8L,6L,0L,7L,2L,1L,2L,8L,0L,1L,4L,5L,4L,6L,0L,6L,9L,9L,3L,8L,0L,1L,4L,6L,3L,5L,3L,7L,7L,7L,6L,6L,7L,8L,7L,3L,9L,2L,6L,9L,9L,2L,6L,1L,5L,7L,9L,0L,9L,4L,0L,5L,4L,2L,8L,7L,0L,8L,8L,0L,1L,5L,9L,3L,5L,2L,4L,2L,5L,3L,9L,4L,9L,0L,6L,0L,8L,6L,3L,3L,6L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011140Inst : IEnumerable<long>
{
public static readonly long[] Value=A011140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011140.Bytes);
public long this[int i]=>Value[i];

public static A011140Inst Instance=new A011140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011141
{
public static readonly long[] Value={ 2L,2L,3L,6L,8L,5L,3L,8L,2L,9L,4L,4L,0L,2L,8L,9L,3L,3L,8L,4L,1L,0L,0L,1L,4L,4L,0L,9L,6L,4L,8L,5L,5L,0L,2L,9L,7L,3L,7L,4L,7L,4L,2L,1L,1L,1L,2L,9L,1L,7L,1L,8L,6L,6L,4L,3L,0L,2L,6L,1L,6L,1L,5L,4L,8L,3L,6L,1L,7L,4L,5L,1L,5L,0L,2L,2L,3L,7L,6L,3L,8L,7L,7L,0L,2L,0L,5L,4L,2L,7L,8L,7L,5L,1L,0L,2L,1L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011141Inst : IEnumerable<long>
{
public static readonly long[] Value=A011141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011141.Bytes);
public long this[int i]=>Value[i];

public static A011141Inst Instance=new A011141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011142
{
public static readonly long[] Value={ 2L,2L,4L,4L,7L,8L,6L,1L,3L,4L,3L,6L,4L,0L,9L,2L,0L,7L,0L,5L,9L,5L,0L,1L,1L,0L,1L,6L,7L,0L,6L,7L,6L,1L,4L,8L,3L,6L,0L,5L,9L,3L,8L,6L,9L,9L,2L,0L,2L,2L,8L,1L,7L,2L,0L,7L,1L,8L,7L,3L,4L,7L,2L,1L,4L,4L,1L,7L,4L,7L,9L,4L,5L,1L,0L,9L,0L,1L,0L,6L,0L,2L,9L,2L,0L,8L,0L,6L,9L,6L,0L,0L,0L,1L,9L,8L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011142Inst : IEnumerable<long>
{
public static readonly long[] Value=A011142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011142.Bytes);
public long this[int i]=>Value[i];

public static A011142Inst Instance=new A011142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011143
{
public static readonly long[] Value={ 2L,2L,5L,2L,6L,0L,7L,8L,7L,8L,4L,3L,2L,3L,2L,5L,4L,1L,1L,5L,1L,5L,4L,7L,6L,6L,7L,5L,2L,7L,7L,2L,7L,0L,6L,7L,6L,7L,4L,3L,5L,0L,7L,4L,8L,2L,9L,3L,6L,2L,1L,4L,3L,4L,6L,1L,1L,2L,8L,6L,3L,6L,5L,5L,0L,9L,3L,0L,3L,9L,3L,0L,5L,4L,4L,9L,0L,4L,0L,2L,6L,6L,0L,2L,7L,4L,1L,4L,6L,9L,7L,0L,3L,0L,2L,2L,9L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011143Inst : IEnumerable<long>
{
public static readonly long[] Value=A011143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011143.Bytes);
public long this[int i]=>Value[i];

public static A011143Inst Instance=new A011143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011144
{
public static readonly long[] Value={ 2L,2L,6L,0L,3L,2L,2L,4L,6L,9L,6L,2L,6L,8L,1L,5L,7L,0L,3L,6L,9L,7L,6L,1L,8L,8L,9L,4L,9L,1L,5L,4L,0L,5L,8L,0L,5L,6L,9L,1L,1L,1L,9L,9L,4L,8L,4L,5L,6L,1L,5L,2L,0L,0L,5L,9L,7L,3L,7L,0L,3L,2L,5L,8L,9L,8L,4L,7L,6L,9L,0L,1L,5L,6L,9L,7L,2L,9L,8L,6L,7L,4L,0L,7L,8L,7L,8L,5L,7L,5L,5L,8L,9L,1L,1L,0L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011144Inst : IEnumerable<long>
{
public static readonly long[] Value=A011144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011144.Bytes);
public long this[int i]=>Value[i];

public static A011144Inst Instance=new A011144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011145
{
public static readonly long[] Value={ 2L,2L,6L,7L,9L,3L,3L,1L,5L,5L,2L,6L,6L,0L,5L,4L,4L,1L,9L,2L,3L,2L,0L,1L,7L,8L,8L,8L,9L,7L,7L,2L,6L,0L,8L,0L,1L,4L,0L,4L,2L,4L,5L,7L,4L,6L,8L,3L,8L,7L,6L,1L,4L,5L,6L,1L,3L,8L,6L,7L,1L,9L,4L,7L,8L,7L,0L,5L,3L,8L,2L,2L,0L,1L,8L,3L,6L,2L,7L,0L,0L,3L,3L,6L,8L,6L,4L,0L,8L,5L,4L,1L,9L,9L,5L,4L,9L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011145Inst : IEnumerable<long>
{
public static readonly long[] Value=A011145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011145.Bytes);
public long this[int i]=>Value[i];

public static A011145Inst Instance=new A011145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011146
{
public static readonly long[] Value={ 2L,2L,7L,5L,4L,4L,3L,0L,3L,2L,1L,1L,4L,5L,3L,0L,3L,3L,7L,9L,1L,4L,6L,4L,3L,8L,2L,6L,7L,7L,6L,6L,4L,3L,2L,5L,5L,8L,2L,4L,8L,9L,5L,4L,8L,1L,9L,5L,8L,3L,6L,2L,1L,8L,9L,6L,2L,8L,1L,2L,9L,7L,2L,0L,4L,5L,2L,2L,5L,4L,0L,5L,6L,1L,1L,0L,4L,5L,2L,4L,1L,1L,5L,3L,5L,3L,1L,1L,4L,0L,0L,9L,9L,1L,1L,8L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011146Inst : IEnumerable<long>
{
public static readonly long[] Value=A011146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011146.Bytes);
public long this[int i]=>Value[i];

public static A011146Inst Instance=new A011146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011147
{
public static readonly long[] Value={ 2L,2L,8L,2L,8L,5L,5L,0L,5L,5L,7L,0L,1L,6L,2L,8L,9L,8L,2L,1L,4L,5L,3L,7L,9L,4L,7L,7L,5L,4L,7L,9L,6L,3L,0L,2L,2L,3L,4L,0L,7L,1L,5L,7L,3L,8L,5L,1L,1L,6L,3L,3L,2L,6L,8L,0L,3L,1L,3L,4L,7L,2L,0L,6L,6L,9L,2L,0L,1L,6L,0L,3L,5L,5L,0L,4L,4L,7L,9L,3L,0L,4L,9L,3L,4L,5L,8L,8L,8L,3L,9L,5L,4L,2L,6L,9L,6L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011147Inst : IEnumerable<long>
{
public static readonly long[] Value=A011147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011147.Bytes);
public long this[int i]=>Value[i];

public static A011147Inst Instance=new A011147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011148
{
public static readonly long[] Value={ 2L,2L,9L,0L,1L,7L,2L,0L,4L,8L,9L,2L,3L,5L,8L,2L,4L,9L,0L,1L,2L,3L,9L,0L,6L,4L,0L,2L,3L,6L,4L,0L,0L,0L,9L,7L,9L,5L,6L,0L,5L,4L,6L,6L,1L,3L,7L,1L,8L,0L,1L,8L,0L,7L,6L,5L,8L,7L,4L,8L,7L,2L,8L,8L,1L,6L,0L,6L,0L,4L,1L,6L,2L,7L,9L,0L,9L,8L,8L,0L,0L,0L,8L,8L,4L,2L,5L,5L,5L,7L,1L,0L,7L,0L,6L,9L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011148Inst : IEnumerable<long>
{
public static readonly long[] Value=A011148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011148.Bytes);
public long this[int i]=>Value[i];

public static A011148Inst Instance=new A011148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011149
{
public static readonly long[] Value={ 2L,2L,9L,7L,3L,9L,6L,7L,0L,9L,9L,9L,4L,0L,7L,0L,0L,1L,3L,5L,9L,7L,2L,5L,3L,8L,9L,3L,5L,5L,5L,8L,5L,5L,1L,7L,8L,8L,8L,7L,7L,0L,1L,7L,7L,8L,1L,9L,5L,5L,9L,5L,0L,1L,1L,0L,2L,7L,4L,2L,2L,2L,3L,6L,9L,8L,7L,2L,0L,6L,4L,1L,2L,5L,0L,7L,0L,2L,6L,1L,1L,3L,6L,2L,2L,9L,4L,6L,2L,2L,6L,0L,2L,3L,0L,1L,6L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011149Inst : IEnumerable<long>
{
public static readonly long[] Value=A011149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011149.Bytes);
public long this[int i]=>Value[i];

public static A011149Inst Instance=new A011149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011166
{
public static readonly long[] Value={ 2L,4L,0L,8L,2L,2L,4L,6L,8L,5L,2L,8L,0L,6L,9L,2L,0L,4L,6L,2L,8L,5L,5L,0L,8L,6L,1L,4L,1L,9L,1L,1L,5L,4L,3L,2L,9L,1L,0L,0L,3L,5L,7L,0L,1L,8L,5L,8L,8L,5L,0L,7L,2L,3L,4L,9L,4L,6L,7L,8L,3L,7L,9L,8L,4L,7L,0L,7L,3L,7L,7L,3L,1L,2L,6L,3L,6L,4L,7L,4L,0L,2L,5L,9L,8L,9L,5L,4L,2L,9L,9L,6L,7L,7L,1L,8L,9L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011166Inst : IEnumerable<long>
{
public static readonly long[] Value=A011166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011166.Bytes);
public long this[int i]=>Value[i];

public static A011166Inst Instance=new A011166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011167
{
public static readonly long[] Value={ 2L,4L,1L,4L,1L,4L,1L,7L,7L,0L,6L,0L,3L,7L,3L,5L,8L,3L,1L,3L,1L,6L,5L,4L,1L,2L,0L,8L,4L,8L,1L,1L,0L,0L,6L,7L,0L,5L,3L,1L,1L,7L,5L,4L,5L,1L,5L,3L,9L,2L,2L,2L,7L,8L,7L,1L,8L,5L,3L,5L,4L,8L,2L,4L,4L,4L,8L,1L,4L,2L,4L,0L,3L,5L,5L,5L,7L,5L,4L,2L,0L,0L,6L,4L,9L,0L,8L,1L,4L,3L,1L,2L,0L,0L,9L,2L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011167Inst : IEnumerable<long>
{
public static readonly long[] Value=A011167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011167.Bytes);
public long this[int i]=>Value[i];

public static A011167Inst Instance=new A011167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011168
{
public static readonly long[] Value={ 2L,4L,2L,0L,0L,0L,1L,4L,0L,6L,9L,6L,5L,9L,6L,2L,4L,2L,2L,0L,0L,0L,2L,2L,5L,7L,3L,3L,4L,5L,1L,0L,0L,8L,5L,6L,1L,6L,8L,5L,5L,2L,0L,4L,6L,8L,1L,2L,7L,5L,2L,0L,3L,7L,6L,9L,2L,5L,5L,0L,6L,1L,2L,7L,0L,7L,9L,4L,2L,2L,6L,2L,9L,4L,9L,3L,5L,8L,7L,1L,7L,3L,3L,1L,9L,3L,3L,4L,9L,3L,1L,8L,3L,4L,4L,6L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011168Inst : IEnumerable<long>
{
public static readonly long[] Value=A011168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011168.Bytes);
public long this[int i]=>Value[i];

public static A011168Inst Instance=new A011168Inst();

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