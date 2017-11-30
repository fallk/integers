using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A276749
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,749L,349707L,6584568222L,2542670826073083L,BigInteger.Parse("87482825374559636232439"),BigInteger.Parse("1084004198573118046271860417698544"),BigInteger.Parse("947790766920144318254338856937912501990845477"),BigInteger.Parse("546110521982991331256716555878135043551458467258822092049841"),BigInteger.Parse("1013482348116310649878997474896504367633097553028647215670516799670576593506574") };
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
public class A276749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276749Inst Instance=new A276749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276750
{
public static readonly BigInteger[] Value={ 1L,5L,22L,117L,821L,7796L,101417L,1810093L,44561794L,1515368605L,71428667861L,4677209119632L,426268582440013L,54220470799325101L,9632796180856419722UL,BigInteger.Parse("2397253932245127919389"),BigInteger.Parse("835827069207839232602401"),BigInteger.Parse("409329501365419311969616628"),BigInteger.Parse("281600921299273941316256813501"),BigInteger.Parse("272632759803890415543364253988037"),BigInteger.Parse("371636574592049013061911521355729422"),BigInteger.Parse("713832787857018847209335427225631327093") };
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
public class A276750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276750Inst Instance=new A276750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276751
{
public static readonly BigInteger[] Value={ 1L,1L,3L,14L,111L,1813L,57846L,3941129L,515554887L,139563384274L,73929755773659L,78682910542834037L,BigInteger.Parse("169524995438153307498"),BigInteger.Parse("712160156293232925362965"),BigInteger.Parse("6241130803695426404771763891"),BigInteger.Parse("104223975880844169453617144998346"),BigInteger.Parse("3697419824526049703366356719095712903"),BigInteger.Parse("247087719554207540966918934263865223952113"),BigInteger.Parse("35252698554630762784745670915756020139337705854"),BigInteger.Parse("9472029798481852471047526788494040155248502738148149") };
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
public class A276751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276751Inst Instance=new A276751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276752
{
public static readonly BigInteger[] Value={ 1L,1L,5L,30L,327L,7085L,307280L,28472653L,5000661017L,1886425568702L,1331753751874235L,2008313162512681569L,BigInteger.Parse("5765904212733638946976"),BigInteger.Parse("34525801618218187545094977"),BigInteger.Parse("406111805399407205212602871837"),BigInteger.Parse("9635669704681654899673855841540822"),BigInteger.Parse("464496624513770925349468939192278531231"),BigInteger.Parse("43718131231809168093455159164707384418710045"),BigInteger.Parse("8598321846236415035740539472279473819390935625008") };
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
public class A276752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276752Inst Instance=new A276752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276753
{
public static readonly BigInteger[] Value={ 1L,5L,34L,381L,8401L,334688L,27151993L,4091831133L,1251353635162L,737891198902325L,864695662715974585L,BigInteger.Parse("2033353960345783330704"),BigInteger.Parse("9255876152303901497918425"),BigInteger.Parse("87365856252845525476020365429"),BigInteger.Parse("1563265999862817889675899566032954"),BigInteger.Parse("59157049408983740505063226640565220029"),BigInteger.Parse("4200428372739940183291465697348398947046393"),BigInteger.Parse("634544126271277747190512917479290795324884131840") };
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
public class A276753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276753Inst Instance=new A276753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276754
{
public static readonly BigInteger[] Value={ 1L,9L,76L,1157L,33291L,1792296L,196919213L,39766253741L,16931726147956L,13298466280839329L,BigInteger.Parse("22076711237844558263"),BigInteger.Parse("69166686377284889199104"),BigInteger.Parse("448760359479425463648647769"),BigInteger.Parse("5685081590883001302122022078913"),BigInteger.Parse("144528951819771627855280850227089996"),BigInteger.Parse("7431791795502279858136165452572662669213"),BigInteger.Parse("743200333842768450767851829731370148558347843"),BigInteger.Parse("154769006272445896954868694741314742556915451805336") };
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
public class A276754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276754Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276754.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276754Inst Instance=new A276754Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276755
{
public static readonly BigInteger[] Value={ 1L,1L,5L,65L,1625L,66625L,4330625L,489360625L,110106140625L,52961053640625L,54285079981640625L,BigInteger.Parse("114704374001206640625"),BigInteger.Parse("484625980155098056640625"),BigInteger.Parse("4032572780870570929306640625") };
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
public class A276755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276755Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276755.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276755Inst Instance=new A276755Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276772
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,10L,16L,52L,70L,76L,100L,356L,644L,740L,764L,676L,3176L,6376L,8776L,9376L,9496L,5776L,30112L,75112L,113512L,135112L,139432L,140152L,53824L,336848L,933080L,1668080L,2138480L,2350160L,2385440L,2390480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276772Inst : IEnumerable<long>
{
public static readonly long[] Value=A276772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276772.Bytes);
public long this[int i]=>Value[i];

public static A276772Inst Instance=new A276772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276773
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,9L,16L,41L,50L,51L,81L,225L,306L,322L,323L,441L,1341L,1966L,2162L,2187L,2188L,2601L,8377L,13138L,15074L,15474L,15510L,15511L,16129L,54545L,90266L,107955L,112855L,113584L,113633L,113634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276773Inst : IEnumerable<long>
{
public static readonly long[] Value=A276773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276773.Bytes);
public long this[int i]=>Value[i];

public static A276773Inst Instance=new A276773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276774
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,6L,6L,4L,10L,19L,12L,11L,4L,26L,50L,55L,20L,16L,4L,76L,171L,150L,125L,30L,22L,4L,232L,532L,651L,350L,245L,42L,29L,4L,764L,1961L,2128L,1876L,700L,434L,56L,37L,4L,2620L,6876L,9297L,6384L,4536L,1260L,714L,72L,46L,4L,9496L,27145L,34380L,32565L,15960L,9702L,2100L,1110L,90L,56L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276774Inst : IEnumerable<long>
{
public static readonly long[] Value=A276774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276774.Bytes);
public long this[int i]=>Value[i];

public static A276774Inst Instance=new A276774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276775
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,4L,6L,5L,6L,9L,15L,11L,7L,8L,21L,36L,32L,17L,9L,10L,51L,91L,83L,56L,24L,11L,12L,127L,232L,226L,157L,88L,32L,13L,14L,323L,603L,608L,459L,266L,129L,41L,15L,16L,835L,1585L,1655L,1305L,832L,419L,180L,51L,17L,18L,2188L,4213L,4517L,3726L,2499L,1397L,626L,242L,62L,19L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276775Inst : IEnumerable<long>
{
public static readonly long[] Value=A276775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276775.Bytes);
public long this[int i]=>Value[i];

public static A276775Inst Instance=new A276775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276776
{
public static readonly long[] Value={ 29L,109L,80L,264L,235L,155L,519L,490L,411L,256L,901L,871L,792L,637L,381L,1433L,1403L,1324L,1169L,913L,532L,2140L,2111L,2032L,1877L,1621L,1240L,708L,3049L,3020L,2941L,2786L,2530L,2149L,1617L,909L,4185L,4155L,4076L,3921L,3665L,3284L,2752L,2044L,1135L,5571L,5542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276776Inst : IEnumerable<long>
{
public static readonly long[] Value=A276776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276776.Bytes);
public long this[int i]=>Value[i];

public static A276776Inst Instance=new A276776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276777
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,6L,1L,4L,6L,19L,27L,1L,5L,10L,47L,131L,472L,1L,6L,16L,103L,497L,3253L,19735L,1L,7L,23L,203L,1606L,18435L,221778L,2773763L,1L,8L,32L,373L,4647L,91028L,2074059L,51107344L,1245930065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276777Inst : IEnumerable<long>
{
public static readonly long[] Value=A276777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276777.Bytes);
public long this[int i]=>Value[i];

public static A276777Inst Instance=new A276777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276778
{
public static readonly long[] Value={ 1L,4L,9L,20L,42L,85L,173L,347L,697L,1395L,2792L,5587L,11175L,22352L,44706L,89414L,178830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276778Inst : IEnumerable<long>
{
public static readonly long[] Value=A276778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276778.Bytes);
public long this[int i]=>Value[i];

public static A276778Inst Instance=new A276778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276779
{
public static readonly long[] Value={ 6L,22L,71L,218L,659L,1985L,5963L,17898L,53704L,161124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276779Inst : IEnumerable<long>
{
public static readonly long[] Value=A276779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276779.Bytes);
public long this[int i]=>Value[i];

public static A276779Inst Instance=new A276779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276780
{
public static readonly long[] Value={ 9L,41L,171L,694L,2790L,11172L,44702L,178825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276780Inst : IEnumerable<long>
{
public static readonly long[] Value=A276780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276780.Bytes);
public long this[int i]=>Value[i];

public static A276780Inst Instance=new A276780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276781
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,3L,1L,1L,2L,1L,2L,3L,4L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,2L,3L,4L,5L,1L,2L,3L,4L,1L,2L,1L,2L,3L,4L,1L,2L,1L,2L,3L,4L,1L,2L,3L,4L,5L,6L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,3L,4L,1L,2L,1L,2L,3L,4L,5L,6L,1L,2L,1L,2L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276781Inst : IEnumerable<long>
{
public static readonly long[] Value=A276781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276781.Bytes);
public long this[int i]=>Value[i];

public static A276781Inst Instance=new A276781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276782
{
public static readonly long[] Value={ 2L,6L,15L,22L,36L,58L,95L,96L,147L,148L,209L,210L,305L,306L,901L,902L,903L,904L,905L,906L,1149L,1150L,1353L,1354L,1355L,1356L,1357L,1358L,1359L,1360L,5621L,5622L,8499L,8500L,9585L,9586L,15719L,15720L,15721L,15722L,15723L,15724L,15725L,15726L,19653L,19654L,19655L,19656L,19657L,19658L,19659L,19660L,31449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276782Inst : IEnumerable<long>
{
public static readonly long[] Value=A276782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276782.Bytes);
public long this[int i]=>Value[i];

public static A276782Inst Instance=new A276782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276783
{
public static readonly long[] Value={ 0L,3L,4L,6L,7L,13L,14L,16L,17L,18L,19L,22L,23L,29L,30L,33L,34L,39L,40L,42L,43L,44L,45L,48L,49L,53L,55L,58L,59L,61L,62L,64L,67L,68L,71L,76L,77L,80L,81L,84L,85L,88L,89L,92L,93L,94L,95L,100L,102L,105L,107L,110L,112L,113L,115L,118L,119L,121L,122L,124L,126L,127L,131L,134L,135L,137L,138L,142L,143L,146L,147L,152L,154L,157L,158L,160L,161L,163L,165L,166L,168L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276783Inst : IEnumerable<long>
{
public static readonly long[] Value=A276783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276783.Bytes);
public long this[int i]=>Value[i];

public static A276783Inst Instance=new A276783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276784
{
public static readonly long[] Value={ 1L,2L,5L,8L,9L,10L,11L,12L,15L,20L,21L,24L,25L,26L,27L,28L,31L,32L,35L,36L,37L,38L,41L,46L,47L,50L,51L,52L,54L,56L,57L,60L,63L,65L,66L,69L,70L,72L,73L,74L,75L,78L,79L,82L,83L,86L,87L,90L,91L,96L,97L,98L,99L,101L,103L,104L,106L,108L,109L,111L,114L,116L,117L,120L,123L,125L,128L,129L,130L,132L,133L,136L,139L,140L,141L,144L,145L,148L,149L,150L,151L,153L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276784Inst : IEnumerable<long>
{
public static readonly long[] Value=A276784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276784.Bytes);
public long this[int i]=>Value[i];

public static A276784Inst Instance=new A276784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276785
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,4L,12L,31L,75L,175L,399L,894L,1975L,4313L,9330L,20026L,42704L,90558L,191117L,401654L,841016L,1755249L,3652663L,7581369L,15698735L,32438224L,66897295L,137718495L,283056086L,580906268L,1190538424L,2436854280L,4982012329L,10174319500L,20756971236L,42306806495L,86153127395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276785Inst : IEnumerable<long>
{
public static readonly long[] Value=A276785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276785.Bytes);
public long this[int i]=>Value[i];

public static A276785Inst Instance=new A276785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276786
{
public static readonly long[] Value={ 1L,3L,4L,7L,9L,10L,13L,15L,19L,21L,22L,27L,28L,31L,31L,39L,40L,43L,45L,46L,55L,57L,58L,63L,63L,64L,67L,79L,81L,82L,85L,87L,91L,93L,94L,94L,111L,115L,117L,118L,121L,127L,127L,129L,130L,135L,136L,139L,159L,163L,165L,166L,171L,172L,175L,175L,183L,187L,189L,189L,190L,190L,193L,202L,223L,231L,235L,237L,238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276786Inst : IEnumerable<long>
{
public static readonly long[] Value=A276786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276786.Bytes);
public long this[int i]=>Value[i];

public static A276786Inst Instance=new A276786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276787
{
public static readonly long[] Value={ 31L,63L,94L,127L,175L,189L,190L,255L,283L,351L,379L,381L,382L,511L,526L,567L,568L,571L,703L,759L,763L,765L,766L,850L,1023L,1039L,1053L,1054L,1135L,1137L,1138L,1143L,1144L,1147L,1407L,1471L,1519L,1527L,1531L,1533L,1534L,1579L,1701L,1702L,1705L,1714L,2047L,2079L,2107L,2109L,2110L,2191L,2271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276787Inst : IEnumerable<long>
{
public static readonly long[] Value=A276787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276787.Bytes);
public long this[int i]=>Value[i];

public static A276787Inst Instance=new A276787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276804
{
public static readonly BigInteger[] Value={ 3L,15L,21L,1155L,39L,3315L,5187L,111546435L,87L,13485L,22533L,1575169365L,48633L,6022953885L,12684118629L,BigInteger.Parse("961380175077106319535"),183L,61305L,90951L,24466273755L,187941L,88836891585L,157950690807L,BigInteger.Parse("133754519645521334494935"),536007L,573342567585L };
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
public class A276804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276804Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276804.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276804Inst Instance=new A276804Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276805
{
public static readonly long[] Value={ 6L,3L,20L,15L,42L,7L,72L,45L,110L,33L,156L,91L,210L,30L,272L,153L,342L,95L,420L,231L,506L,69L,600L,325L,702L,189L,812L,435L,930L,124L,1056L,561L,1190L,315L,1332L,703L,1482L,195L,1640L,861L,1806L,473L,1980L,1035L,2162L,282L,2352L,1225L,2550L,663L,2756L,1431L,2970L,385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276805Inst : IEnumerable<long>
{
public static readonly long[] Value=A276805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276805.Bytes);
public long this[int i]=>Value[i];

public static A276805Inst Instance=new A276805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276806
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,2L,1L,1L,0L,2L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,0L,2L,0L,3L,1L,1L,1L,2L,0L,1L,1L,2L,0L,2L,0L,2L,2L,1L,0L,3L,1L,2L,1L,2L,0L,2L,1L,2L,1L,1L,0L,2L,0L,1L,2L,3L,1L,2L,0L,2L,1L,2L,0L,3L,0L,1L,2L,2L,1L,2L,0L,3L,2L,1L,0L,2L,1L,1L,1L,2L,0L,2L,1L,2L,1L,1L,1L,3L,0L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276806Inst : IEnumerable<long>
{
public static readonly long[] Value=A276806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276806.Bytes);
public long this[int i]=>Value[i];

public static A276806Inst Instance=new A276806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276807
{
public static readonly long[] Value={ 2L,4L,7L,7L,7L,15L,15L,23L,31L,23L,23L,31L,47L,39L,47L,55L,55L,63L,71L,63L,63L,87L,87L,95L,95L,119L,87L,119L,111L,95L,135L,135L,143L,151L,135L,167L,159L,151L,143L,167L,167L,175L,191L,191L,215L,183L,231L,231L,215L,207L,223L,255L,223L,231L,255L,271L,279L,263L,303L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276807Inst : IEnumerable<long>
{
public static readonly long[] Value=A276807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276807.Bytes);
public long this[int i]=>Value[i];

public static A276807Inst Instance=new A276807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276808
{
public static readonly long[] Value={ 17L,1733L,18433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276808Inst : IEnumerable<long>
{
public static readonly long[] Value=A276808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276808.Bytes);
public long this[int i]=>Value[i];

public static A276808Inst Instance=new A276808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276809
{
public static readonly long[] Value={ 7L,17L,11L,13L,23L,53L,67L,37L,47L,59L,61L,73L,83L,173L,281L,107L,353L,367L,269L,283L,293L,157L,167L,179L,193L,607L,617L,641L,653L,227L,509L,263L,547L,277L,1193L,907L,313L,653L,1669L,347L,359L,1087L,383L,773L,787L,397L,421L,1783L,907L,457L,467L,479L,1447L,503L,1543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276809Inst : IEnumerable<long>
{
public static readonly long[] Value=A276809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276809.Bytes);
public long this[int i]=>Value[i];

public static A276809Inst Instance=new A276809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276810
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,39L,48L,49L,57L,58L,59L,67L,68L,69L,75L,76L,78L,79L,84L,85L,86L,87L,89L,93L,94L,95L,96L,97L,98L,149L,158L,167L,176L,185L,194L,199L,239L,248L,257L,275L,284L,289L,293L,298L,329L,347L,356L,365L,374L,379L,388L,392L,397L,419L,428L,437L,469L,473L,478L,482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276810Inst : IEnumerable<long>
{
public static readonly long[] Value=A276810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276810.Bytes);
public long this[int i]=>Value[i];

public static A276810Inst Instance=new A276810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276811
{
public static readonly BigInteger[] Value={ 1L,1L,2L,1L,3L,4L,31L,20L,47L,5832L,322L,84L,BigInteger.Parse("4576568315415066934826490"),324L,843L,480L,3769607182320L,2209L,BigInteger.Parse("707932145558030519866865515025923563263974776037874477588352"),BigInteger.Parse("69670959389872974262939756520"),39603L };
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
public class A276811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276811Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276811.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276811Inst Instance=new A276811Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276812
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,2L,0L,2L,2L,0L,4L,2L,0L,2L,0L,2L,0L,4L,2L,0L,4L,2L,2L,4L,2L,0L,2L,0L,2L,4L,2L,2L,0L,2L,0L,0L,4L,2L,0L,2L,0L,2L,0L,2L,0L,0L,4L,2L,0L,2L,2L,0L,6L,0L,0L,2L,0L,4L,2L,0L,4L,4L,2L,0L,2L,6L,4L,2L,0L,2L,2L,6L,0L,4L,2L,2L,4L,0L,2L,2L,0L,2L,0L,4L,2L,2L,4L,2L,0L,0L,8L,4L,0L,4L,2L,0L,2L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276812Inst : IEnumerable<long>
{
public static readonly long[] Value=A276812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276812.Bytes);
public long this[int i]=>Value[i];

public static A276812Inst Instance=new A276812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276813
{
public static readonly long[] Value={ 2L,1L,1L,8L,1L,4L,2L,2L,16L,3L,3L,1L,3L,1L,1L,2L,1L,1L,3L,1L,3L,3L,5L,1L,13L,1L,4L,1L,1L,13L,4L,3L,1L,4L,1L,1L,6L,5L,9L,1L,13L,2L,15L,1L,2L,3L,3L,1L,4L,9L,2L,14L,1L,4L,1L,7L,1L,1L,11L,1L,4L,5L,2L,3L,2L,1L,14L,1L,1L,2L,1L,1L,1L,1L,20L,3L,2L,1L,2L,2L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276813Inst : IEnumerable<long>
{
public static readonly long[] Value=A276813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276813.Bytes);
public long this[int i]=>Value[i];

public static A276813Inst Instance=new A276813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276814
{
public static readonly long[] Value={ -3L,-4L,6L,-5L,22L,-30L,-6L,36L,16L,-168L,192L,-7L,54L,46L,-294L,-266L,1428L,-1386L,-8L,76L,64L,-480L,30L,-832L,2560L,-128L,3520L,-12800L,10752L,-9L,102L,86L,-738L,78L,-1260L,4356L,-594L,-558L,11484L,-23166L,3564L,-42900L,118404L,-87516L,-10L,132L,112L,-1080L,100L,-1840L,7040L,48L,-1680L,-800L,18240L,-40320L,-760L,8640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276814Inst : IEnumerable<long>
{
public static readonly long[] Value=A276814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276814.Bytes);
public long this[int i]=>Value[i];

public static A276814Inst Instance=new A276814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276815
{
public static readonly long[] Value={ 3L,4L,-24L,5L,-70L,210L,6L,-96L,-48L,960L,-1920L,7L,-126L,-126L,1386L,1386L,-12012L,18018L,8L,-160L,-160L,1920L,-80L,3840L,-17920L,640L,-26880L,143360L,-172032L,9L,-198L,-198L,2574L,-198L,5148L,-25740L,2574L,2574L,-77220L,218790L,-25740L,437580L,-1662804L,1662804L,10L,-240L,-240L,3360L,-240L,6720L,-35840L,-120L,6720L,3360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276815Inst : IEnumerable<long>
{
public static readonly long[] Value=A276815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276815.Bytes);
public long this[int i]=>Value[i];

public static A276815Inst Instance=new A276815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276816
{
public static readonly long[] Value={ -24L,480L,-120L,6720L,3360L,-241920L,1774080L,-560L,40320L,40320L,-1774080L,20160L,-3548160L,61501440L,-591360L,92252160L,-1845043200L,8364195840L,-2520L,221760L,221760L,-11531520L,221760L,-23063040L,461260800L,110880L,-23063040L,-11531520L,1383782400L,-15682867200L,-11531520L,691891200L,1383782400L,-62731468800L,476759162880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276816Inst : IEnumerable<long>
{
public static readonly long[] Value=A276816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276816.Bytes);
public long this[int i]=>Value[i];

public static A276816Inst Instance=new A276816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276817
{
public static readonly long[] Value={ -1L,2L,6L,-3L,-16L,8L,-48L,4L,30L,-20L,140L,10L,-140L,420L,-5L,-48L,36L,-288L,-24L,384L,-1280L,12L,-192L,-96L,1920L,-3840L,6L,70L,-56L,504L,42L,-756L,2772L,-28L,504L,252L,-5544L,12012L,14L,-252L,-252L,2772L,2772L,-24024L,36036L,-7L,-96L,80L,-800L,-64L,1280L,-5120L,48L,-960L,-480L,11520L,-26880L,-32L,640L,640L,-7680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276817Inst : IEnumerable<long>
{
public static readonly long[] Value=A276817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276817.Bytes);
public long this[int i]=>Value[i];

public static A276817Inst Instance=new A276817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276818
{
public static readonly long[] Value={ 6L,10L,14L,15L,21L,22L,26L,30L,33L,34L,38L,39L,42L,46L,51L,57L,58L,62L,65L,66L,69L,74L,78L,82L,85L,86L,87L,91L,93L,94L,102L,106L,111L,114L,118L,122L,123L,129L,130L,133L,134L,138L,141L,142L,145L,146L,158L,159L,166L,170L,174L,177L,178L,182L,183L,185L,186L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276818Inst : IEnumerable<long>
{
public static readonly long[] Value=A276818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276818.Bytes);
public long this[int i]=>Value[i];

public static A276818Inst Instance=new A276818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276819
{
public static readonly long[] Value={ 1L,5L,18L,40L,71L,111L,160L,218L,285L,361L,446L,540L,643L,755L,876L,1006L,1145L,1293L,1450L,1616L,1791L,1975L,2168L,2370L,2581L,2801L,3030L,3268L,3515L,3771L,4036L,4310L,4593L,4885L,5186L,5496L,5815L,6143L,6480L,6826L,7181L,7545L,7918L,8300L,8691L,9091L,9500L,9918L,10345L,10781L,11226L,11680L,12143L,12615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276819Inst : IEnumerable<long>
{
public static readonly long[] Value=A276819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276819.Bytes);
public long this[int i]=>Value[i];

public static A276819Inst Instance=new A276819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276836
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,3L,1L,4L,3L,5L,1L,6L,1L,7L,15L,2L,1L,9L,1L,5L,21L,11L,1L,2L,5L,13L,9L,7L,1L,15L,1L,8L,11L,17L,35L,27L,1L,19L,39L,5L,1L,7L,1L,44L,45L,69L,1L,54L,7L,125L,17L,39L,1L,27L,55L,14L,57L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276836Inst : IEnumerable<long>
{
public static readonly long[] Value=A276836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276836.Bytes);
public long this[int i]=>Value[i];

public static A276836Inst Instance=new A276836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276837
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,2L,1L,0L,1L,1L,2L,3L,1L,0L,1L,1L,2L,6L,5L,1L,0L,1L,1L,2L,6L,12L,8L,1L,0L,1L,1L,2L,6L,24L,25L,13L,1L,0L,1L,1L,2L,6L,24L,60L,57L,21L,1L,0L,1L,1L,2L,6L,24L,120L,150L,124L,34L,1L,0L,1L,1L,2L,6L,24L,120L,360L,399L,268L,55L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276837Inst : IEnumerable<long>
{
public static readonly long[] Value=A276837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276837.Bytes);
public long this[int i]=>Value[i];

public static A276837Inst Instance=new A276837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276838
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,60L,150L,399L,1145L,3132L,8420L,22716L,62128L,169536L,460885L,1251777L,3406238L,9272354L,25229036L,68622196L,186682470L,507925571L,1381929921L,3759616968L,10228269080L,27827267544L,75707898304L,205971928848L,560368255081L,1524544463441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276838Inst : IEnumerable<long>
{
public static readonly long[] Value=A276838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276838.Bytes);
public long this[int i]=>Value[i];

public static A276838Inst Instance=new A276838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276839
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,360L,1050L,3192L,10305L,35505L,116620L,374172L,1195764L,3848248L,12538476L,40807108L,132283092L,427799593L,1383464353L,4481902342L,14529001194L,47085299068L,152520137944L,493941015012L,1599895591174L,5182983937428L,16791233651977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276839Inst : IEnumerable<long>
{
public static readonly long[] Value=A276839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276839.Bytes);
public long this[int i]=>Value[i];

public static A276839Inst Instance=new A276839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276840
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,720L,2520L,8400L,28728L,103050L,390555L,1566813L,5994636L,22318676L,82337580L,304360184L,1134352752L,4275368704L,16107425628L,60453074344L,226179710040L,845165016029L,3159696003981L,11832636916230L,44346582492034L,166184942954284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276840Inst : IEnumerable<long>
{
public static readonly long[] Value=A276840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276840.Bytes);
public long this[int i]=>Value[i];

public static A276840Inst Instance=new A276840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276841
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,720L,5040L,20160L,75600L,287280L,1133550L,4686660L,20368569L,93109737L,406088940L,1719126780L,7184340564L,29966843736L,125593803792L,530881463680L,2267064321984L,9681953067016L,41200660295772L,174712473986620L,739333708856220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276841Inst : IEnumerable<long>
{
public static readonly long[] Value=A276841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276841.Bytes);
public long this[int i]=>Value[i];

public static A276841Inst Instance=new A276841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276842
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,720L,5040L,40320L,181440L,756000L,3160080L,13602600L,60926580L,285159966L,1396646055L,7158444465L,35019420060L,165994449732L,774542703708L,3596199290264L,16729008975792L,78297230499296L,369560004222048L,1760728654735744L,8392003472443920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276842Inst : IEnumerable<long>
{
public static readonly long[] Value=A276842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276842.Bytes);
public long this[int i]=>Value[i];

public static A276842Inst Instance=new A276842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276843
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,720L,5040L,40320L,362880L,1814400L,8316000L,37920960L,176833800L,852972120L,4277399490L,22346336880L,121693555905L,690665206113L,3742590924108L,19625337285660L,101084160732660L,516806625700056L,2640952527095376L,13549247936670720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276843Inst : IEnumerable<long>
{
public static readonly long[] Value=A276843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276843.Bytes);
public long this[int i]=>Value[i];

public static A276843Inst Instance=new A276843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276844
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,720L,5040L,40320L,362880L,3628800L,19958400L,99792000L,492972480L,2475673200L,12794581800L,68438391840L,379887726960L,2190484006290L,13122638916147L,81648757479285L,485188719524460L,2787398328848820L,15702226260438924L,87625414510220472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276844Inst : IEnumerable<long>
{
public static readonly long[] Value=A276844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276844.Bytes);
public long this[int i]=>Value[i];

public static A276844Inst Instance=new A276844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276845
{
public static readonly long[] Value={ 1L,2L,5L,6L,40L,47L,49L,58L,67L,142L,170L,173L,232L,530L,539L,559L,1651L,1858L,2695L,6257L,6714L,8854L,15066L,15091L,16890L,51366L,85249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276845Inst : IEnumerable<long>
{
public static readonly long[] Value=A276845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276845.Bytes);
public long this[int i]=>Value[i];

public static A276845Inst Instance=new A276845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276846
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,9L,15L,21L,22L,44L,49L,53L,63L,127L,145L,393L,856L,1006L,1883L,2263L,5684L,13324L,14291L,27435L,38897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276846Inst : IEnumerable<long>
{
public static readonly long[] Value=A276846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276846.Bytes);
public long this[int i]=>Value[i];

public static A276846Inst Instance=new A276846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276847
{
public static readonly long[] Value={ 1L,0L,-1L,0L,-2L,0L,0L,0L,1L,0L,4L,0L,-2L,0L,2L,0L,2L,0L,-4L,0L,0L,0L,-8L,0L,-1L,0L,-1L,0L,6L,0L,8L,0L,-4L,0L,0L,0L,6L,0L,2L,0L,-6L,0L,4L,0L,-2L,0L,0L,0L,-7L,0L,-2L,0L,-2L,0L,-8L,0L,4L,0L,4L,0L,-2L,0L,0L,0L,4L,0L,-4L,0L,8L,0L,8L,0L,10L,0L,1L,0L,0L,0L,-8L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276847Inst : IEnumerable<long>
{
public static readonly long[] Value=A276847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276847.Bytes);
public long this[int i]=>Value[i];

public static A276847Inst Instance=new A276847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276848
{
public static readonly long[] Value={ 3L,11L,17L,29L,59L,227L,269L,1277L,1289L,1607L,2129L,2789L,3527L,3917L,4637L,4787L,5639L,8999L,13679L,14549L,18119L,27737L,36779L,38447L,39227L,44267L,62129L,71327L,75989L,80669L,83219L,88799L,93479L,97367L,99707L,113147L,113159L,115769L,122027L,122387L,124337L,124769L,132749L,150209L,160079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276848Inst : IEnumerable<long>
{
public static readonly long[] Value=A276848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276848.Bytes);
public long this[int i]=>Value[i];

public static A276848Inst Instance=new A276848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276849
{
public static readonly long[] Value={ 5L,2L,9L,20L,49L,118L,285L,688L,1661L,4010L,9681L,23372L,56425L,136222L,328869L,793960L,1916789L,4627538L,11171865L,26971268L,65114401L,157200070L,379514541L,916229152L,2211972845L,5340174842L,12892322529L,31124819900L,75141962329L,181408744558L,437959451445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276849Inst : IEnumerable<long>
{
public static readonly long[] Value=A276849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276849.Bytes);
public long this[int i]=>Value[i];

public static A276849Inst Instance=new A276849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276850
{
public static readonly long[] Value={ 2L,-10L,5L,42L,-42L,6L,3L,-168L,252L,-56L,-56L,7L,7L,660L,-1320L,540L,360L,-144L,24L,72L,8L,8L,4L,24L,72L,8L,8L,4L,-2574L,6435L,-3960L,1980L,495L,1485L,495L,-90L,180L,90L,90L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276850Inst : IEnumerable<long>
{
public static readonly long[] Value=A276850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276850.Bytes);
public long this[int i]=>Value[i];

public static A276850Inst Instance=new A276850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276851
{
public static readonly long[] Value={ 2L,-2L,1L,14L,-14L,2L,1L,-24L,36L,-7L,-7L,1L,1L,165L,-330L,135L,90L,-56L,6L,18L,2L,2L,1L,6L,18L,2L,2L,-1L,-286L,715L,-440L,220L,55L,165L,55L,-10L,20L,10L,10L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276851Inst : IEnumerable<long>
{
public static readonly long[] Value=A276851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276851.Bytes);
public long this[int i]=>Value[i];

public static A276851Inst Instance=new A276851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277300
{
public static readonly BigInteger[] Value={ 1L,5L,60L,1000L,19970L,448160L,10926360L,283651245L,7740058300L,220046970860L,6476695275680L,196438030797880L,6117627849485360L,195082685133612800L,6355848358118392400L,BigInteger.Parse("211189970909192038500"),BigInteger.Parse("7146354688384980282000"),BigInteger.Parse("245970478274041025623200"),BigInteger.Parse("8602606263466490521359400"),BigInteger.Parse("305460999044315834902424200"),BigInteger.Parse("11003870605124169641012461600") };
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
public class A277300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277300Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277300.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277300Inst Instance=new A277300Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277301
{
public static readonly BigInteger[] Value={ 1L,5L,70L,1425L,35410L,999210L,30855820L,1020407105L,35642665050L,1302725802510L,49490450201460L,1944619121474970L,78734794663758580L,3275324221277662900L,BigInteger.Parse("139667810517388712600"),BigInteger.Parse("6093781146211490413825"),BigInteger.Parse("271623891311306597652650"),BigInteger.Parse("12353670814537544856558950"),BigInteger.Parse("572686428900679117724156900"),BigInteger.Parse("27036308383662996662940155550"),BigInteger.Parse("1298856469077709523772645582300") };
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
public class A277301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277301Inst Instance=new A277301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277302
{
public static readonly BigInteger[] Value={ 1L,5L,80L,1900L,55490L,1848660L,67630080L,2657251005L,110560510400L,4824793769260L,219334788340040L,10334817935549420L,502814686712631520L,BigInteger.Parse("25184673137026274600"),BigInteger.Parse("1295595210394570426800"),BigInteger.Parse("68326193725188929358600"),BigInteger.Parse("3688253200687778850553800"),BigInteger.Parse("203524353764195058692833200"),BigInteger.Parse("11468618360097679305600299400"),BigInteger.Parse("659345494779348103800864088800"),BigInteger.Parse("38644445208422874351089132287200") };
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
public class A277302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277302Inst Instance=new A277302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277303
{
public static readonly BigInteger[] Value={ 1L,5L,90L,2425L,80630L,3065810L,128271540L,5774538945L,275743894750L,13832116773110L,723891526915820L,39323723086794730L,2208811824884144540L,BigInteger.Parse("127904686371063157700"),BigInteger.Parse("7617441454740093233000"),BigInteger.Parse("465691699545009287055825"),BigInteger.Parse("29179499379365501297165550"),BigInteger.Parse("1871486497257264286902367950"),BigInteger.Parse("122731222232573572625823907900"),BigInteger.Parse("8222122259910817121846641763950"),BigInteger.Parse("562251437460415648354364719018900") };
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
public class A277303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277303Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277303.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277303Inst Instance=new A277303Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277304
{
public static readonly BigInteger[] Value={ 1L,6L,84L,1614L,36948L,947412L,26334072L,778107150L,24133349532L,778923367284L,26000354998920L,893459845502916L,31496296778304936L,1135911643635146712L,BigInteger.Parse("41820127450763818896"),BigInteger.Parse("1568983653501973667262"),BigInteger.Parse("59898843849911992994340"),BigInteger.Parse("2324166762372316001442540"),BigInteger.Parse("91565378725229449617874824"),BigInteger.Parse("3659689884915567083966937156"),BigInteger.Parse("148284110214725433666804447912") };
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
public class A277304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277304Inst Instance=new A277304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277305
{
public static readonly BigInteger[] Value={ 1L,6L,132L,4350L,176964L,8235252L,421814232L,23252672574L,1359954622860L,83572511671092L,5359130778285096L,356786692299782916L,BigInteger.Parse("24565803644793789192"),BigInteger.Parse("1744056102774572824920"),BigInteger.Parse("127369971591949093219920"),BigInteger.Parse("9550397045409732902387790"),BigInteger.Parse("734084078724419876468356500"),BigInteger.Parse("57766855968717521513179054860"),BigInteger.Parse("4648888743682938087701732224680") };
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
public class A277305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277305Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277305.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277305Inst Instance=new A277305Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277306
{
public static readonly BigInteger[] Value={ 1L,1L,0L,-4L,2L,52L,-96L,-975L,4240L,18460L,-183448L,-101716L,7373216L,-23650520L,-230147920L,2198499720L,664806792L,-124144328784L,703989911368L,3189500786336L,-68800373946656L,284782780974128L,2913071885553608L,-47063844278787824L,170357147598919640L,2621783446017272624L,BigInteger.Parse("-41775596442709927664"),BigInteger.Parse("166446909354828214608") };
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
public class A277306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277306Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277306.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277306Inst Instance=new A277306Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277307
{
public static readonly BigInteger[] Value={ 1L,1L,8L,92L,1298L,20988L,375120L,7252065L,149534312L,3256987724L,74418884792L,1774657501252L,43995940957120L,1130453689908568L,30031716838365552L,823263454676130312L,BigInteger.Parse("23249951990747403528"),BigInteger.Parse("675517165191231019920"),BigInteger.Parse("20168579968950108809736"),BigInteger.Parse("618158189347428262782816"),BigInteger.Parse("19432224179107494743506272"),BigInteger.Parse("626034612821085407187912624") };
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
public class A277307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277307Inst Instance=new A277307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277308
{
public static readonly BigInteger[] Value={ 1L,2L,20L,298L,5492L,116124L,2710776L,68308170L,1831522940L,51744512380L,1529687560328L,47075470016012L,1502258036769256L,49560341916549320L,1686236991420431760L,BigInteger.Parse("59054595629732284890"),BigInteger.Parse("2125432920387784135812"),BigInteger.Parse("78509698415432235272292"),BigInteger.Parse("2972996232264052816975752"),BigInteger.Parse("115303660044380692013332428") };
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
public class A277308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277308Inst Instance=new A277308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277309
{
public static readonly BigInteger[] Value={ 1L,2L,28L,570L,14284L,410604L,13046728L,448252682L,16417945620L,634848045084L,25737059674104L,1088311917852828L,47813839403065432L,2175881570186952520L,BigInteger.Parse("102316326149365110320"),BigInteger.Parse("4961686220242926811690"),BigInteger.Parse("247733650768933667153660"),BigInteger.Parse("12718117037478356041212500"),BigInteger.Parse("670565414769224589112024760"),BigInteger.Parse("36274908884974158393988101900"),BigInteger.Parse("2011581759381610503724213971960") };
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
public class A277309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277309Inst Instance=new A277309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277310
{
public static readonly BigInteger[] Value={ 1L,1L,10L,141L,2422L,47562L,1031764L,24214405L,606444990L,16055089470L,446238074892L,12955112773554L,391332183548956L,12261884937532340L,397576302315045800L,13313017677172350965UL,BigInteger.Parse("459635990935574444942"),BigInteger.Parse("16339309997761322057206"),BigInteger.Parse("597340515437542895494748"),BigInteger.Parse("22435278085988347895795526"),BigInteger.Parse("864900964565994975048855444"),BigInteger.Parse("34195693888939483596581262668"),BigInteger.Parse("1385553440866978431053220575128") };
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
public class A277310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277310Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277310.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277310Inst Instance=new A277310Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277311
{
public static readonly BigInteger[] Value={ 1L,1L,12L,200L,4034L,92752L,2353272L,64579809L,1891598860L,58591554652L,1906271367296L,64816527248936L,2294331974613872L,84290267670946720L,3206227129084419920L,BigInteger.Parse("126022120854865417140"),BigInteger.Parse("5110001578581607976400"),BigInteger.Parse("213458728365617240931360"),BigInteger.Parse("9175021814527973211291880"),BigInteger.Parse("405366362599820848509766760"),BigInteger.Parse("18392202994173383123235536800"),BigInteger.Parse("856255190568423353781484124240") };
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
public class A277311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277311Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277311.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277311Inst Instance=new A277311Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277312
{
public static readonly long[] Value={ 4L,9L,25L,49L,15L,169L,289L,361L,33L,841L,961L,1369L,1681L,1849L,69L,65L,87L,3721L,4489L,115L,5329L,91L,123L,7921L,9409L,10201L,10609L,159L,11881L,12769L,16129L,215L,18769L,19321L,185L,22801L,24649L,26569L,249L,221L,267L,32761L,329L,37249L,38809L,39601L,247L,259L,339L,52441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277312Inst : IEnumerable<long>
{
public static readonly long[] Value=A277312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277312.Bytes);
public long this[int i]=>Value[i];

public static A277312Inst Instance=new A277312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277313
{
public static readonly long[] Value={ 8L,2L,0L,3L,5L,9L,8L,6L,2L,2L,0L,8L,7L,8L,9L,7L,8L,8L,4L,7L,3L,4L,6L,6L,7L,9L,4L,9L,4L,0L,6L,3L,9L,1L,5L,8L,4L,1L,5L,9L,0L,9L,7L,5L,3L,4L,1L,3L,1L,6L,1L,9L,3L,7L,6L,5L,4L,6L,8L,7L,6L,7L,4L,9L,4L,8L,5L,0L,2L,4L,0L,7L,0L,1L,9L,2L,2L,9L,3L,8L,4L,6L,3L,2L,4L,5L,1L,7L,7L,4L,5L,4L,4L,7L,9L,2L,9L,9L,2L,8L,8L,2L,9L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277313Inst : IEnumerable<long>
{
public static readonly long[] Value=A277313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277313.Bytes);
public long this[int i]=>Value[i];

public static A277313Inst Instance=new A277313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277314
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,2L,3L,1L,3L,2L,3L,2L,3L,3L,4L,1L,4L,3L,3L,2L,3L,3L,4L,2L,4L,3L,4L,3L,4L,4L,5L,1L,5L,4L,4L,3L,4L,3L,4L,2L,4L,3L,4L,3L,4L,4L,5L,2L,5L,4L,4L,3L,4L,4L,5L,3L,5L,4L,5L,4L,5L,5L,6L,1L,6L,5L,5L,4L,5L,4L,5L,3L,5L,4L,4L,3L,4L,4L,5L,2L,5L,4L,4L,3L,4L,4L,5L,3L,5L,4L,5L,4L,5L,5L,6L,2L,6L,5L,5L,4L,5L,4L,5L,3L,5L,4L,5L,4L,5L,5L,6L,3L,6L,5L,5L,4L,5L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277314Inst : IEnumerable<long>
{
public static readonly long[] Value=A277314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277314.Bytes);
public long this[int i]=>Value[i];

public static A277314Inst Instance=new A277314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277315
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,3L,1L,2L,1L,1L,1L,2L,2L,3L,2L,4L,3L,3L,1L,3L,2L,3L,1L,2L,1L,1L,1L,2L,2L,3L,2L,5L,3L,4L,2L,4L,4L,6L,3L,5L,3L,3L,1L,3L,3L,5L,2L,5L,3L,4L,1L,3L,2L,3L,1L,2L,1L,1L,1L,2L,2L,3L,2L,5L,3L,4L,2L,6L,5L,8L,3L,7L,4L,4L,2L,4L,4L,8L,4L,10L,6L,7L,3L,6L,5L,8L,3L,5L,3L,3L,1L,3L,3L,5L,3L,7L,5L,6L,2L,6L,5L,8L,3L,7L,4L,4L,1L,4L,3L,5L,2L,5L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277315Inst : IEnumerable<long>
{
public static readonly long[] Value=A277315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277315.Bytes);
public long this[int i]=>Value[i];

public static A277315Inst Instance=new A277315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277364
{
public static readonly long[] Value={ 1L,0L,1L,1L,8L,16L,122L,365L,2795L,11051L,86472L,422005L,3403127L,19628064L,164029595L,1084948961L,9433737120L,69998462014L,635182667816L,5199414528808L,49344452550230L,439841775811967L,4371727233798927L,42000637216351225L,437489737355466560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277364Inst : IEnumerable<long>
{
public static readonly long[] Value=A277364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277364.Bytes);
public long this[int i]=>Value[i];

public static A277364Inst Instance=new A277364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277365
{
public static readonly long[] Value={ 2L,6L,12L,20L,34L,49L,56L,72L,98L,112L,144L,176L,196L,228L,224L,272L,344L,406L,392L,384L,448L,520L,576L,688L,688L,772L,913L,912L,912L,1028L,992L,1040L,1220L,1152L,1376L,1624L,1624L,1708L,1624L,1728L,1728L,1824L,2160L,2080L,2080L,2215L,2559L,2752L,2884L,2884L,2752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277365Inst : IEnumerable<long>
{
public static readonly long[] Value=A277365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277365.Bytes);
public long this[int i]=>Value[i];

public static A277365Inst Instance=new A277365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277366
{
public static readonly long[] Value={ 1729L,670033L,6840001L,83099521L,193708801L,321197185L,367804801L,484662529L,1752710401L,2320690177L,5064928705L,12820178449L,32220147601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277366Inst : IEnumerable<long>
{
public static readonly long[] Value=A277366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277366.Bytes);
public long this[int i]=>Value[i];

public static A277366Inst Instance=new A277366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277367
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,3L,1L,1L,2L,1L,1L,1L,1L,4L,3L,2L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,5L,2L,1L,1L,3L,3L,3L,1L,1L,1L,1L,1L,4L,4L,4L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,6L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,1L,2L,10L,10L,1L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277367Inst : IEnumerable<long>
{
public static readonly long[] Value=A277367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277367.Bytes);
public long this[int i]=>Value[i];

public static A277367Inst Instance=new A277367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277368
{
public static readonly long[] Value={ 1L,4L,10L,16L,25L,26L,34L,56L,58L,60L,64L,74L,81L,82L,90L,96L,100L,106L,120L,121L,122L,132L,146L,178L,184L,194L,202L,204L,216L,218L,226L,234L,248L,274L,276L,289L,298L,306L,312L,314L,346L,348L,362L,364L,376L,386L,394L,408L,440L,458L,466L,480L,482L,492L,504L,514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277368Inst : IEnumerable<long>
{
public static readonly long[] Value=A277368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277368.Bytes);
public long this[int i]=>Value[i];

public static A277368Inst Instance=new A277368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277369
{
public static readonly long[] Value={ 5L,8L,21L,50L,121L,292L,705L,1702L,4109L,9920L,23949L,57818L,139585L,336988L,813561L,1964110L,4741781L,11447672L,27637125L,66721922L,161080969L,388883860L,938848689L,2266581238L,5472011165L,13210603568L,31893218301L,76997040170L,185887298641L,448771637452L,1083430573545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277369Inst : IEnumerable<long>
{
public static readonly long[] Value=A277369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277369.Bytes);
public long this[int i]=>Value[i];

public static A277369Inst Instance=new A277369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277370
{
public static readonly long[] Value={ 1L,3L,15L,69L,2155L,34073L,876047637L,97090036327L,420397381695L,2125899832395L,3177544777277L,34434175473881L,40845965389135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277370Inst : IEnumerable<long>
{
public static readonly long[] Value=A277370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277370.Bytes);
public long this[int i]=>Value[i];

public static A277370Inst Instance=new A277370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277371
{
public static readonly long[] Value={ 1L,2L,4L,5L,26L,205L,2404L,88171L,1785134L,2010899L,58796834L,639723359L,657788549L,2050134685L,4809019972L,6114530474L,11931055777L,1292089439947L,1294667166242L,4586221808305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277371Inst : IEnumerable<long>
{
public static readonly long[] Value=A277371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277371.Bytes);
public long this[int i]=>Value[i];

public static A277371Inst Instance=new A277371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277372
{
public static readonly BigInteger[] Value={ 0L,1L,10L,141L,2584L,58745L,1602576L,51165205L,1874935168L,77644293201L,3588075308800L,183111507687581L,10230243235200000L,621111794820235849L,BigInteger.Parse("40722033570202507264"),BigInteger.Parse("2867494972696071121125"),BigInteger.Parse("215840579093024990396416"),BigInteger.Parse("17294837586403146090259745"),BigInteger.Parse("1469799445329208661211021312") };
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
public class A277372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277372Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277372.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277372Inst Instance=new A277372Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277373
{
public static readonly BigInteger[] Value={ 1L,2L,14L,168L,2840L,61870L,1649232L,51988748L,1891712384L,78031713690L,3598075308800L,183396819358192L,10239159335648256L,621414669926828102L,BigInteger.Parse("40733145577028065280"),BigInteger.Parse("2867932866586451980500"),BigInteger.Parse("215859025837098699948032"),BigInteger.Parse("17295664826665032427023922"),BigInteger.Parse("1469838791737283957748596736") };
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
public class A277373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277373Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277373.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277373Inst Instance=new A277373Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277374
{
public static readonly BigInteger[] Value={ 1L,2L,3L,6L,50L,100L,1794L,3588L,114840L,229680L,11483880L,22967760L,1653679440L,3307358880L,324121165200L,648242330400L,82975018331520L,165950036663040L,26883905939049600L,53767811878099200L,10753562375623468800UL,BigInteger.Parse("21507124751246937600"),BigInteger.Parse("5204724189801718982400") };
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
public class A277374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277374Inst Instance=new A277374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277375
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,7L,11L,6L,13L,17L,19L,23L,29L,31L,8L,37L,41L,43L,47L,53L,59L,61L,67L,9L,71L,73L,79L,83L,89L,97L,101L,103L,107L,10L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,12L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,14L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,293L,307L,311L,15L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277375Inst : IEnumerable<long>
{
public static readonly long[] Value=A277375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277375.Bytes);
public long this[int i]=>Value[i];

public static A277375Inst Instance=new A277375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277376
{
public static readonly long[] Value={ 2L,1L,4L,3L,6L,8L,9L,5L,10L,12L,14L,15L,16L,7L,18L,20L,21L,22L,24L,25L,26L,11L,27L,28L,30L,32L,33L,34L,35L,36L,38L,39L,40L,13L,42L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,17L,58L,60L,62L,63L,64L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,19L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277376Inst : IEnumerable<long>
{
public static readonly long[] Value=A277376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277376.Bytes);
public long this[int i]=>Value[i];

public static A277376Inst Instance=new A277376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277377
{
public static readonly long[] Value={ 1L,0L,3L,2L,4L,6L,5L,8L,10L,12L,14L,16L,7L,18L,20L,22L,24L,26L,28L,30L,9L,32L,34L,36L,38L,40L,42L,44L,46L,48L,11L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,13L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,15L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,118L,120L,122L,124L,126L,17L,128L,130L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277377Inst : IEnumerable<long>
{
public static readonly long[] Value=A277377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277377.Bytes);
public long this[int i]=>Value[i];

public static A277377Inst Instance=new A277377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277378
{
public static readonly BigInteger[] Value={ 1L,2L,9L,50L,361L,3042L,29929L,331298L,4100625L,55777922L,828691369L,13316140818L,230256982201L,4257449540450L,83834039024649L,1750225301567618L,38614608429012001L,897325298084953602L,BigInteger.Parse("21904718673762721225"),BigInteger.Parse("560258287738117292018"),BigInteger.Parse("14981472258320814527241") };
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
public class A277378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277378Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277378.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277378Inst Instance=new A277378Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277379
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,40L,296L,1936L,17872L,164480L,1820800L,21442816L,279255296L,3967316992L,59837670400L,988024924160L,17009993230336L,318566665977856L,6177885274406912L,129053377688043520L,2786107670662021120L,BigInteger.Parse("64136976817284448256"),BigInteger.Parse("1525720008470138454016") };
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
public class A277379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277379Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277379.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277379Inst Instance=new A277379Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277444
{
public static readonly long[] Value={ 0L,0L,2L,0L,0L,6L,0L,2L,0L,12L,0L,0L,42L,24L,20L,0L,2L,48L,420L,120L,30L,0L,0L,306L,2160L,2420L,360L,42L,0L,2L,600L,17532L,27600L,9750L,840L,56L,0L,0L,2442L,115464L,375260L,191760L,30702L,1680L,72L,0L,2L,6048L,830100L,4810680L,4098510L,917280L,81032L,3024L,90L,0L,0L,20706L,5745120L,62813540L,85691640L,28669662L,3406368L,187560L,5040L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277444Inst : IEnumerable<long>
{
public static readonly long[] Value=A277444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277444.Bytes);
public long this[int i]=>Value[i];

public static A277444Inst Instance=new A277444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277445
{
public static readonly BigInteger[] Value={ 1L,-2L,-4L,4L,48L,-160L,-32L,2176L,6912L,0L,-273408L,41984L,19456L,-37027840L,-141705216L,0L,3833856L,-34359869440L,0L,1625620480000L,11045440585728L,-47710208L,-520279482695680L,7719016726528L,909115392000L,-207717914210467840L,0L,0L,BigInteger.Parse("100736516652659638272"),BigInteger.Parse("-721057900040447590400") };
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
public class A277445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277445Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277445.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277445Inst Instance=new A277445Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277446
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,3L,1L,1L,2L,1L,2L,2L,3L,4L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,3L,2L,3L,3L,4L,5L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,2L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,3L,3L,4L,3L,4L,4L,5L,6L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,3L,1L,3L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277446Inst : IEnumerable<long>
{
public static readonly long[] Value=A277446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277446.Bytes);
public long this[int i]=>Value[i];

public static A277446Inst Instance=new A277446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277447
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,1L,1L,3L,4L,2L,1L,2L,3L,1L,1L,2L,1L,3L,3L,5L,1L,2L,1L,4L,1L,3L,2L,3L,4L,1L,1L,2L,1L,3L,1L,3L,1L,3L,2L,3L,3L,5L,6L,1L,1L,2L,1L,2L,1L,4L,1L,2L,2L,3L,2L,5L,2L,4L,3L,4L,5L,1L,1L,1L,1L,3L,1L,3L,1L,3L,1L,4L,1L,3L,2L,2L,3L,3L,2L,4L,3L,3L,3L,3L,4L,5L,4L,8L,1L,2L,1L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,4L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277447Inst : IEnumerable<long>
{
public static readonly long[] Value=A277447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277447.Bytes);
public long this[int i]=>Value[i];

public static A277447Inst Instance=new A277447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277448
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,3L,1L,1L,1L,6L,1L,3L,1L,4L,2L,1L,1L,2L,2L,6L,1L,4L,2L,3L,4L,2L,3L,4L,1L,4L,3L,1L,1L,2L,1L,2L,2L,4L,3L,6L,1L,2L,1L,4L,3L,2L,2L,3L,3L,5L,1L,2L,1L,3L,1L,4L,2L,2L,2L,4L,3L,5L,4L,1L,1L,2L,1L,2L,1L,3L,1L,2L,1L,3L,2L,4L,2L,4L,4L,6L,1L,1L,1L,3L,1L,2L,1L,4L,1L,3L,2L,2L,2L,3L,2L,3L,3L,4L,3L,6L,5L,1L,1L,2L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277448Inst : IEnumerable<long>
{
public static readonly long[] Value=A277448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277448.Bytes);
public long this[int i]=>Value[i];

public static A277448Inst Instance=new A277448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277449
{
public static readonly long[] Value={ 34L,74L,100L,130L,202L,244L,290L,394L,452L,514L,650L,724L,802L,970L,1060L,1154L,1354L,1460L,1570L,1802L,1924L,2050L,2314L,2452L,2594L,2890L,3044L,3202L,3364L,3530L,3700L,3874L,4234L,4420L,4610L,5002L,5204L,5410L,5834L,6052L,6274L,6730L,6964L,7202L,7690L,7940L,8194L,8714L,8980L,9250L,9802L,10084L,10370L,10954L,11252L,11554L,12170L,12484L,12802L,13450L,13780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277449Inst : IEnumerable<long>
{
public static readonly long[] Value=A277449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277449.Bytes);
public long this[int i]=>Value[i];

public static A277449Inst Instance=new A277449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277450
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277450Inst : IEnumerable<long>
{
public static readonly long[] Value=A277450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277450.Bytes);
public long this[int i]=>Value[i];

public static A277450Inst Instance=new A277450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277451
{
public static readonly long[] Value={ 1L,30L,120L,480L,1920L,7680L,30720L,122880L,491520L,1966080L,7864320L,31457280L,125829120L,503316480L,2013265920L,8053063680L,32212254720L,128849018880L,515396075520L,2061584302080L,8246337208320L,32985348833280L,131941395333120L,527765581332480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277451Inst : IEnumerable<long>
{
public static readonly long[] Value=A277451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277451.Bytes);
public long this[int i]=>Value[i];

public static A277451Inst Instance=new A277451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277452
{
public static readonly BigInteger[] Value={ 1L,2L,13L,226L,7889L,458026L,39684637L,4788052298L,766526598721L,157108817646514L,40104442275129101L,12472587843118746322UL,BigInteger.Parse("4641978487740740993233"),BigInteger.Parse("2036813028164774540010266"),BigInteger.Parse("1040451608604560812273060189"),BigInteger.Parse("612098707457003526384666111226") };
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
public class A277452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277452Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277452.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277452Inst Instance=new A277452Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277453
{
public static readonly BigInteger[] Value={ 1L,3L,41L,1531L,111393L,13262051L,2336744233L,570621092091L,184341785557121L,76092709735150723L,BigInteger.Parse("39064090158380196201"),BigInteger.Parse("24408768326642565035963"),BigInteger.Parse("18237590837527919131499041"),BigInteger.Parse("16056004231253610384348995811"),BigInteger.Parse("16448689708899063469247204152553") };
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
public class A277453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277453Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277453.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277453Inst Instance=new A277453Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277454
{
public static readonly BigInteger[] Value={ 1L,3L,21L,271L,5065L,122811L,3651997L,128566663L,5227782161L,241072839667L,12430169195941L,708612945554559L,44253858433505497L,3004570398043291819L,BigInteger.Parse("220341964157226260525"),BigInteger.Parse("17357760973540312138231"),BigInteger.Parse("1461813975265547356467745"),BigInteger.Parse("131061164660246579394042339") };
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
public class A277454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277454Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277454.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277454Inst Instance=new A277454Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277455
{
public static readonly long[] Value={ 0L,0L,1L,4L,6L,10L,20L,1L,36L,172L,2192L,3371L,1L,22327L,135561L,517656L,284492L,933118L,5446991L,24265724L,18238138L,93800069L,334654476L,1368408363L,2584589232L,1823879615L,25669818480L,41583822879L,1967330543L,29409700520L,1265785403L,3239855363874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277455Inst : IEnumerable<long>
{
public static readonly long[] Value=A277455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277455.Bytes);
public long this[int i]=>Value[i];

public static A277455Inst Instance=new A277455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277456
{
public static readonly BigInteger[] Value={ 1L,4L,43L,847L,23881L,870721L,38894653L,2055873037L,125480383153L,8684069883409L,671922832985941L,57475677232902589L,5385592533714824521L,BigInteger.Parse("548596467532888667257"),BigInteger.Parse("60358911366712739334541"),BigInteger.Parse("7133453715771227363127301"),BigInteger.Parse("901261693601873814393568993") };
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
public class A277456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277456Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277456.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277456Inst Instance=new A277456Inst();

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